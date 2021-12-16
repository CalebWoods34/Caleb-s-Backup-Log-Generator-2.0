<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewForCSV = New System.Windows.Forms.DataGridView()
        Me.BackupLogDataLabel = New System.Windows.Forms.Label()
        Me.SelectBackupLogLabel = New System.Windows.Forms.Label()
        Me.SelectBackupLogBrowseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EnterPartDetailsAndCureDeviceNameLabel = New System.Windows.Forms.Label()
        Me.BackupLogTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CureDeviceNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PartNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CreateLogLabel = New System.Windows.Forms.Label()
        Me.CreateBackupLogButton = New System.Windows.Forms.Button()
        Me.DataGridViewForSelectedRange = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewForCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewForSelectedRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Location = New System.Drawing.Point(12, 9)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(512, 13)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "This program allows for the creation of cure or injection logs from backup log fi" &
    "les. Follow the steps in order. "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'DataGridViewForCSV
        '
        Me.DataGridViewForCSV.AllowUserToAddRows = False
        Me.DataGridViewForCSV.AllowUserToDeleteRows = False
        Me.DataGridViewForCSV.AllowUserToResizeColumns = False
        Me.DataGridViewForCSV.AllowUserToResizeRows = False
        Me.DataGridViewForCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewForCSV.Location = New System.Drawing.Point(303, 68)
        Me.DataGridViewForCSV.Name = "DataGridViewForCSV"
        Me.DataGridViewForCSV.ReadOnly = True
        Me.DataGridViewForCSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForCSV.Size = New System.Drawing.Size(417, 468)
        Me.DataGridViewForCSV.TabIndex = 1
        '
        'BackupLogDataLabel
        '
        Me.BackupLogDataLabel.AutoSize = True
        Me.BackupLogDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BackupLogDataLabel.Location = New System.Drawing.Point(303, 54)
        Me.BackupLogDataLabel.Name = "BackupLogDataLabel"
        Me.BackupLogDataLabel.Size = New System.Drawing.Size(99, 15)
        Me.BackupLogDataLabel.TabIndex = 2
        Me.BackupLogDataLabel.Text = "Backup Log Data: "
        '
        'SelectBackupLogLabel
        '
        Me.SelectBackupLogLabel.AutoSize = True
        Me.SelectBackupLogLabel.Location = New System.Drawing.Point(12, 54)
        Me.SelectBackupLogLabel.Name = "SelectBackupLogLabel"
        Me.SelectBackupLogLabel.Size = New System.Drawing.Size(116, 13)
        Me.SelectBackupLogLabel.TabIndex = 3
        Me.SelectBackupLogLabel.Text = "1. Select Backup Log: "
        '
        'SelectBackupLogBrowseButton
        '
        Me.SelectBackupLogBrowseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SelectBackupLogBrowseButton.Location = New System.Drawing.Point(15, 71)
        Me.SelectBackupLogBrowseButton.Name = "SelectBackupLogBrowseButton"
        Me.SelectBackupLogBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectBackupLogBrowseButton.TabIndex = 4
        Me.SelectBackupLogBrowseButton.Text = "Browse..."
        Me.SelectBackupLogBrowseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 46)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "3.  Click the starting row and highlight to the ending row in the Backup Log Data" &
    " grid window to select. "
        '
        'EnterPartDetailsAndCureDeviceNameLabel
        '
        Me.EnterPartDetailsAndCureDeviceNameLabel.AutoSize = True
        Me.EnterPartDetailsAndCureDeviceNameLabel.Location = New System.Drawing.Point(12, 177)
        Me.EnterPartDetailsAndCureDeviceNameLabel.Name = "EnterPartDetailsAndCureDeviceNameLabel"
        Me.EnterPartDetailsAndCureDeviceNameLabel.Size = New System.Drawing.Size(104, 13)
        Me.EnterPartDetailsAndCureDeviceNameLabel.TabIndex = 11
        Me.EnterPartDetailsAndCureDeviceNameLabel.Text = "2. Enter Part Details:"
        '
        'BackupLogTextBox
        '
        Me.BackupLogTextBox.Enabled = False
        Me.BackupLogTextBox.Location = New System.Drawing.Point(15, 101)
        Me.BackupLogTextBox.Name = "BackupLogTextBox"
        Me.BackupLogTextBox.Size = New System.Drawing.Size(260, 20)
        Me.BackupLogTextBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cure Device Name: "
        '
        'CureDeviceNameTextBox
        '
        Me.CureDeviceNameTextBox.Enabled = False
        Me.CureDeviceNameTextBox.Location = New System.Drawing.Point(121, 136)
        Me.CureDeviceNameTextBox.Name = "CureDeviceNameTextBox"
        Me.CureDeviceNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CureDeviceNameTextBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Part Number: "
        '
        'PartNumberTextBox
        '
        Me.PartNumberTextBox.Location = New System.Drawing.Point(121, 206)
        Me.PartNumberTextBox.Name = "PartNumberTextBox"
        Me.PartNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PartNumberTextBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Job Number: "
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(121, 244)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JobNumberTextBox.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Serial Number: "
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(121, 281)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SerialNumberTextBox.TabIndex = 0
        '
        'CreateLogLabel
        '
        Me.CreateLogLabel.AutoSize = True
        Me.CreateLogLabel.Location = New System.Drawing.Point(12, 373)
        Me.CreateLogLabel.Name = "CreateLogLabel"
        Me.CreateLogLabel.Size = New System.Drawing.Size(127, 13)
        Me.CreateLogLabel.TabIndex = 20
        Me.CreateLogLabel.Text = "4. Generate Backup Log:"
        '
        'CreateBackupLogButton
        '
        Me.CreateBackupLogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CreateBackupLogButton.Location = New System.Drawing.Point(73, 403)
        Me.CreateBackupLogButton.Name = "CreateBackupLogButton"
        Me.CreateBackupLogButton.Size = New System.Drawing.Size(122, 53)
        Me.CreateBackupLogButton.TabIndex = 21
        Me.CreateBackupLogButton.Text = "Generate Backup Log"
        Me.CreateBackupLogButton.UseVisualStyleBackColor = True
        '
        'DataGridViewForSelectedRange
        '
        Me.DataGridViewForSelectedRange.AllowUserToAddRows = False
        Me.DataGridViewForSelectedRange.AllowUserToDeleteRows = False
        Me.DataGridViewForSelectedRange.AllowUserToResizeColumns = False
        Me.DataGridViewForSelectedRange.AllowUserToResizeRows = False
        Me.DataGridViewForSelectedRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewForSelectedRange.Enabled = False
        Me.DataGridViewForSelectedRange.Location = New System.Drawing.Point(752, 68)
        Me.DataGridViewForSelectedRange.Name = "DataGridViewForSelectedRange"
        Me.DataGridViewForSelectedRange.ReadOnly = True
        Me.DataGridViewForSelectedRange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForSelectedRange.Size = New System.Drawing.Size(417, 468)
        Me.DataGridViewForSelectedRange.TabIndex = 23
        Me.DataGridViewForSelectedRange.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 547)
        Me.Controls.Add(Me.DataGridViewForSelectedRange)
        Me.Controls.Add(Me.CreateBackupLogButton)
        Me.Controls.Add(Me.CreateLogLabel)
        Me.Controls.Add(Me.SerialNumberTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.JobNumberTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PartNumberTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CureDeviceNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BackupLogTextBox)
        Me.Controls.Add(Me.EnterPartDetailsAndCureDeviceNameLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SelectBackupLogBrowseButton)
        Me.Controls.Add(Me.SelectBackupLogLabel)
        Me.Controls.Add(Me.BackupLogDataLabel)
        Me.Controls.Add(Me.DataGridViewForCSV)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Name = "Form1"
        Me.Text = "Caleb's Backup Log Generator 2.0"
        CType(Me.DataGridViewForCSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewForSelectedRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderLabel As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents DataGridViewForCSV As DataGridView
    Friend WithEvents BackupLogDataLabel As Label
    Friend WithEvents SelectBackupLogLabel As Label
    Friend WithEvents SelectBackupLogBrowseButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents EnterPartDetailsAndCureDeviceNameLabel As Label
    Friend WithEvents BackupLogTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CureDeviceNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PartNumberTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents JobNumberTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SerialNumberTextBox As TextBox
    Friend WithEvents CreateLogLabel As Label
    Friend WithEvents CreateBackupLogButton As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DataGridViewForSelectedRange As DataGridView
End Class
