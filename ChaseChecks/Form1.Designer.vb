<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConvertForm))
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.getFile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.csvBox = New System.Windows.Forms.TextBox()
        Me.acceptButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fileBox = New System.Windows.Forms.ComboBox()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.CsvcData1 = New ChaseChecks.csvcData()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CsvcData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFile"
        Me.OpenFile.Filter = "Excel Files (*.xl;*.xlsx;*.xlsm;*.xlsb;*.xlam;*.xltx;*.xltm;*.xls;*.xla;*.xlt;*.x" & _
    "lm;*.xlw)|*.xl;*.xlsx;*.xlsm;*.xlsb;*.xlam;*.xltx;*.xltm;*.xls;*.xla;*.xlt;*.xlm" & _
    ";*.xlw|All Files|*.*"
        Me.OpenFile.Title = "Select Excel File"
        '
        'getFile
        '
        Me.getFile.Location = New System.Drawing.Point(302, 16)
        Me.getFile.Name = "getFile"
        Me.getFile.Size = New System.Drawing.Size(75, 23)
        Me.getFile.TabIndex = 2
        Me.getFile.Text = "Browse..."
        Me.getFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.csvBox)
        Me.GroupBox1.Controls.Add(Me.acceptButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 283)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CSV File"
        '
        'csvBox
        '
        Me.csvBox.Location = New System.Drawing.Point(7, 20)
        Me.csvBox.Multiline = True
        Me.csvBox.Name = "csvBox"
        Me.csvBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.csvBox.Size = New System.Drawing.Size(547, 228)
        Me.csvBox.TabIndex = 2
        Me.csvBox.WordWrap = False
        '
        'acceptButton
        '
        Me.acceptButton.AutoSize = True
        Me.acceptButton.Location = New System.Drawing.Point(447, 254)
        Me.acceptButton.Name = "acceptButton"
        Me.acceptButton.Size = New System.Drawing.Size(107, 23)
        Me.acceptButton.TabIndex = 1
        Me.acceptButton.Text = "Accept Conversion"
        Me.acceptButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please review and make any necessary changes before accepting."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fileBox)
        Me.GroupBox2.Controls.Add(Me.getFile)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 49)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Please choose Excel Check file"
        '
        'fileBox
        '
        Me.fileBox.AllowDrop = True
        Me.fileBox.FormattingEnabled = True
        Me.fileBox.Location = New System.Drawing.Point(7, 16)
        Me.fileBox.Name = "fileBox"
        Me.fileBox.Size = New System.Drawing.Size(289, 21)
        Me.fileBox.TabIndex = 3
        '
        'convertButton
        '
        Me.convertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.convertButton.Location = New System.Drawing.Point(405, 17)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(166, 44)
        Me.convertButton.TabIndex = 6
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'CsvcData1
        '
        Me.CsvcData1.DataSetName = "csvcData"
        Me.CsvcData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConvertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConvertForm"
        Me.Text = "Convert XLSX to CSV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CsvcData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents getFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents csvBox As System.Windows.Forms.TextBox
    Friend WithEvents acceptButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents convertButton As System.Windows.Forms.Button
    Friend WithEvents fileBox As System.Windows.Forms.ComboBox
    Friend WithEvents CsvcData1 As ChaseChecks.csvcData

End Class
