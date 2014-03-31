Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Text
Imports System.Xml.XPath
Imports System.Xml
Imports System

Public Class ConvertForm

    Private filename As String
    Private pathname As String
    Private _dataPath As String = "csvcData.xml"
    Private filePaths(0) As String

    Private Sub getFile_Click(sender As Object, e As EventArgs) Handles getFile.Click
        Dim location As csvcData.fileLocationsRow
        location = CsvcData1.fileLocations.NewfileLocationsRow()

        If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            filename = OpenFile.FileName
            'filenameBox.Text = filename
            fileBox.Text = filename
            With fileBox
                .SelectionStart = Len(.Text)
            End With
            location.filePath = filename
        End If

        csvBox.Clear()
        If (Not pathExists(filename)) Then
            CsvcData1.fileLocations.Rows.Add(location)
            CsvcData1.WriteXml(_dataPath)
        End If
    End Sub

    Private Sub convertButton_Click(sender As Object, e As EventArgs) Handles convertButton.Click
        Dim xlApp As Excel.Application
        Dim xlBook As Excel.Workbook
        Dim s As Excel.Worksheet

        Dim erow, ecol, x, i As Long
        Dim dCell As String

        xlApp = CreateObject("Excel.Application")
        xlBook = xlApp.Workbooks.Open(filename, 0, True)
        pathname = xlBook.Path

        s = xlBook.Sheets(1)

        ecol = s.Cells(1, s.Columns.Count).End(Excel.XlDirection.xlToLeft).Column
        erow = s.Cells(s.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row

        csvBox.Clear()

        For x = 1 To erow
            For i = 1 To ecol
                dCell = s.Cells(x, i).value()
                If (i = ecol) Then
                    csvBox.AppendText(dCell + Environment.NewLine)
                ElseIf i = 1 And x <> 1 Then
                    csvBox.AppendText("""" + dCell + """" + ",")
                Else
                    csvBox.AppendText(dCell + ",")
                End If

            Next
        Next

        'r = s.Rows(1)
        'r = r.EntireRow

        'csvBox.Text = String.Join(",", r)

        xlBook.Close()
        xlApp.Quit()
    End Sub

    Private Sub acceptButton_Click(sender As Object, e As EventArgs) Handles acceptButton.Click
        Dim fs As FileStream = File.Create(pathname + "\CHASE Upload File.csv")

        Dim info As Byte() = New UTF8Encoding(True).GetBytes(csvBox.Text)

        fs.Write(info, 0, info.Length)
        fs.Close()

        System.Diagnostics.Process.Start("explorer.exe", pathname)

    End Sub

    Private Sub ConvertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initPrevLocations()
        CsvcData1.ReadXml(_dataPath)

        Dim table As DataTable = CsvcData1.fileLocations

        Dim row As DataRow
        For Each row In table.Rows
            Dim column As DataColumn = table.Columns.Item(1)
            fileBox.Items.Add(row(column))
            'For Each column In table.Columns
            'fileBox.Items.Add(row(column))
            'Next column
        Next row

        'Dim thisTable As DataTable

        ' For Each thisTable In CsvcData1.Tables
        'Dim row As DataRow

        'Next

    End Sub

    Private Sub initPrevLocations()
        Dim x As Integer = 0
        Using File As New FileStream(_dataPath, FileMode.Open, FileAccess.Read)
            Dim Doc As New XPathDocument(File)
            Dim Nav = Doc.CreateNavigator

            Dim manager As XmlNamespaceManager = New XmlNamespaceManager(Nav.NameTable)
            manager.AddNamespace("d", "http://tempuri.org/csvcData.xsd")

            Dim fPath = Nav.Select("//d:csvcData/d:fileLocations/d:filePath", manager)
            While fPath.MoveNext
                ReDim Preserve filePaths(UBound(filePaths) + 1)
                filePaths(x) = fPath.Current.Value
                x += 1
                'msg = MsgBox("Now this is how to do it... : " + fPath.Current.Value)
            End While
        End Using
    End Sub

    Private Sub fileBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fileBox.SelectedIndexChanged
        filename = fileBox.SelectedValue

    End Sub

    Public Function pathExists(ByVal path As String) As Boolean
        Dim i As Integer

        For i = 0 To filePaths.Length
            If path = filePaths(i) Then
                Return True
            End If
        Next

        Return False
    End Function

End Class
