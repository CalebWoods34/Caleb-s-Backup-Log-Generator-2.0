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
        Me.GroupBoxForTCs = New System.Windows.Forms.GroupBox()
        Me.TCBox32 = New System.Windows.Forms.CheckBox()
        Me.TCBox31 = New System.Windows.Forms.CheckBox()
        Me.TCBox30 = New System.Windows.Forms.CheckBox()
        Me.TCBox29 = New System.Windows.Forms.CheckBox()
        Me.TCBox28 = New System.Windows.Forms.CheckBox()
        Me.TCBox27 = New System.Windows.Forms.CheckBox()
        Me.TCBox26 = New System.Windows.Forms.CheckBox()
        Me.TCBox25 = New System.Windows.Forms.CheckBox()
        Me.TCBox24 = New System.Windows.Forms.CheckBox()
        Me.TCBox23 = New System.Windows.Forms.CheckBox()
        Me.TCBox22 = New System.Windows.Forms.CheckBox()
        Me.TCBox21 = New System.Windows.Forms.CheckBox()
        Me.TCBox20 = New System.Windows.Forms.CheckBox()
        Me.TCBox19 = New System.Windows.Forms.CheckBox()
        Me.TCBox18 = New System.Windows.Forms.CheckBox()
        Me.TCBox17 = New System.Windows.Forms.CheckBox()
        Me.TCBox16 = New System.Windows.Forms.CheckBox()
        Me.TCBox15 = New System.Windows.Forms.CheckBox()
        Me.TCBox14 = New System.Windows.Forms.CheckBox()
        Me.TCBox13 = New System.Windows.Forms.CheckBox()
        Me.TCBox12 = New System.Windows.Forms.CheckBox()
        Me.TCBox11 = New System.Windows.Forms.CheckBox()
        Me.TCBox10 = New System.Windows.Forms.CheckBox()
        Me.TCBox9 = New System.Windows.Forms.CheckBox()
        Me.TCBox8 = New System.Windows.Forms.CheckBox()
        Me.TC4Box = New System.Windows.Forms.CheckBox()
        Me.TC3Box = New System.Windows.Forms.CheckBox()
        Me.TCBox7 = New System.Windows.Forms.CheckBox()
        Me.TC2Box = New System.Windows.Forms.CheckBox()
        Me.TC1Box = New System.Windows.Forms.CheckBox()
        Me.TCBox6 = New System.Windows.Forms.CheckBox()
        Me.TC5Box = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordButton = New System.Windows.Forms.Button()
        Me.TextBoxForUserAuthentication = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewForCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewForSelectedRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxForTCs.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Location = New System.Drawing.Point(12, 9)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(790, 13)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "This program allows for the creation of cure or injection logs from backup log fi" &
    "les for authorized individuals. Enter your 4-digit PIN number and follow the ste" &
    "ps in order. "
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
        Me.DataGridViewForCSV.Location = New System.Drawing.Point(301, 68)
        Me.DataGridViewForCSV.Name = "DataGridViewForCSV"
        Me.DataGridViewForCSV.ReadOnly = True
        Me.DataGridViewForCSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForCSV.Size = New System.Drawing.Size(500, 678)
        Me.DataGridViewForCSV.TabIndex = 1
        '
        'BackupLogDataLabel
        '
        Me.BackupLogDataLabel.AutoSize = True
        Me.BackupLogDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BackupLogDataLabel.Location = New System.Drawing.Point(301, 54)
        Me.BackupLogDataLabel.Name = "BackupLogDataLabel"
        Me.BackupLogDataLabel.Size = New System.Drawing.Size(99, 15)
        Me.BackupLogDataLabel.TabIndex = 2
        Me.BackupLogDataLabel.Text = "Backup Log Data: "
        '
        'SelectBackupLogLabel
        '
        Me.SelectBackupLogLabel.AutoSize = True
        Me.SelectBackupLogLabel.Location = New System.Drawing.Point(12, 113)
        Me.SelectBackupLogLabel.Name = "SelectBackupLogLabel"
        Me.SelectBackupLogLabel.Size = New System.Drawing.Size(116, 13)
        Me.SelectBackupLogLabel.TabIndex = 3
        Me.SelectBackupLogLabel.Text = "2. Select Backup Log: "
        '
        'SelectBackupLogBrowseButton
        '
        Me.SelectBackupLogBrowseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SelectBackupLogBrowseButton.Location = New System.Drawing.Point(15, 129)
        Me.SelectBackupLogBrowseButton.Name = "SelectBackupLogBrowseButton"
        Me.SelectBackupLogBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectBackupLogBrowseButton.TabIndex = 4
        Me.SelectBackupLogBrowseButton.Text = "Browse..."
        Me.SelectBackupLogBrowseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 600)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 46)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "4.  Click the starting row and highlight to the ending row in the Backup Log Data" &
    " grid window to select. "
        '
        'EnterPartDetailsAndCureDeviceNameLabel
        '
        Me.EnterPartDetailsAndCureDeviceNameLabel.AutoSize = True
        Me.EnterPartDetailsAndCureDeviceNameLabel.Location = New System.Drawing.Point(12, 198)
        Me.EnterPartDetailsAndCureDeviceNameLabel.Name = "EnterPartDetailsAndCureDeviceNameLabel"
        Me.EnterPartDetailsAndCureDeviceNameLabel.Size = New System.Drawing.Size(104, 13)
        Me.EnterPartDetailsAndCureDeviceNameLabel.TabIndex = 11
        Me.EnterPartDetailsAndCureDeviceNameLabel.Text = "3. Enter Part Details:"
        '
        'BackupLogTextBox
        '
        Me.BackupLogTextBox.Enabled = False
        Me.BackupLogTextBox.Location = New System.Drawing.Point(16, 158)
        Me.BackupLogTextBox.Name = "BackupLogTextBox"
        Me.BackupLogTextBox.Size = New System.Drawing.Size(280, 20)
        Me.BackupLogTextBox.TabIndex = 12
        '
        'CureDeviceNameTextBox
        '
        Me.CureDeviceNameTextBox.Enabled = False
        Me.CureDeviceNameTextBox.Location = New System.Drawing.Point(791, 42)
        Me.CureDeviceNameTextBox.Name = "CureDeviceNameTextBox"
        Me.CureDeviceNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CureDeviceNameTextBox.TabIndex = 14
        Me.CureDeviceNameTextBox.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Part Number: "
        '
        'PartNumberTextBox
        '
        Me.PartNumberTextBox.Location = New System.Drawing.Point(123, 226)
        Me.PartNumberTextBox.Name = "PartNumberTextBox"
        Me.PartNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PartNumberTextBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Job Number: "
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(123, 264)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JobNumberTextBox.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Serial Number: "
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(123, 301)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SerialNumberTextBox.TabIndex = 0
        '
        'CreateLogLabel
        '
        Me.CreateLogLabel.AutoSize = True
        Me.CreateLogLabel.Location = New System.Drawing.Point(12, 664)
        Me.CreateLogLabel.Name = "CreateLogLabel"
        Me.CreateLogLabel.Size = New System.Drawing.Size(127, 13)
        Me.CreateLogLabel.TabIndex = 20
        Me.CreateLogLabel.Text = "5. Generate Backup Log:"
        '
        'CreateBackupLogButton
        '
        Me.CreateBackupLogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CreateBackupLogButton.Location = New System.Drawing.Point(71, 693)
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
        Me.DataGridViewForSelectedRange.Location = New System.Drawing.Point(801, 68)
        Me.DataGridViewForSelectedRange.Name = "DataGridViewForSelectedRange"
        Me.DataGridViewForSelectedRange.ReadOnly = True
        Me.DataGridViewForSelectedRange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewForSelectedRange.Size = New System.Drawing.Size(417, 541)
        Me.DataGridViewForSelectedRange.TabIndex = 23
        Me.DataGridViewForSelectedRange.Visible = False
        '
        'GroupBoxForTCs
        '
        Me.GroupBoxForTCs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox32)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox31)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox30)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox29)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox28)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox27)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox26)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox25)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox24)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox23)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox22)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox21)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox20)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox19)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox18)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox17)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox16)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox15)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox14)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox13)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox12)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox11)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox10)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox9)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox8)
        Me.GroupBoxForTCs.Controls.Add(Me.TC4Box)
        Me.GroupBoxForTCs.Controls.Add(Me.TC3Box)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox7)
        Me.GroupBoxForTCs.Controls.Add(Me.TC2Box)
        Me.GroupBoxForTCs.Controls.Add(Me.TC1Box)
        Me.GroupBoxForTCs.Controls.Add(Me.TCBox6)
        Me.GroupBoxForTCs.Controls.Add(Me.TC5Box)
        Me.GroupBoxForTCs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxForTCs.Location = New System.Drawing.Point(16, 344)
        Me.GroupBoxForTCs.Name = "GroupBoxForTCs"
        Me.GroupBoxForTCs.Size = New System.Drawing.Size(280, 221)
        Me.GroupBoxForTCs.TabIndex = 24
        Me.GroupBoxForTCs.TabStop = False
        Me.GroupBoxForTCs.Text = "Select Thermocouple"
        '
        'TCBox32
        '
        Me.TCBox32.AutoSize = True
        Me.TCBox32.Location = New System.Drawing.Point(220, 195)
        Me.TCBox32.Name = "TCBox32"
        Me.TCBox32.Size = New System.Drawing.Size(52, 17)
        Me.TCBox32.TabIndex = 31
        Me.TCBox32.Text = "TC32"
        Me.TCBox32.UseVisualStyleBackColor = True
        '
        'TCBox31
        '
        Me.TCBox31.AutoSize = True
        Me.TCBox31.Location = New System.Drawing.Point(150, 195)
        Me.TCBox31.Name = "TCBox31"
        Me.TCBox31.Size = New System.Drawing.Size(52, 17)
        Me.TCBox31.TabIndex = 30
        Me.TCBox31.Text = "TC31"
        Me.TCBox31.UseVisualStyleBackColor = True
        '
        'TCBox30
        '
        Me.TCBox30.AutoSize = True
        Me.TCBox30.Location = New System.Drawing.Point(80, 195)
        Me.TCBox30.Name = "TCBox30"
        Me.TCBox30.Size = New System.Drawing.Size(52, 17)
        Me.TCBox30.TabIndex = 29
        Me.TCBox30.Text = "TC30"
        Me.TCBox30.UseVisualStyleBackColor = True
        '
        'TCBox29
        '
        Me.TCBox29.AutoSize = True
        Me.TCBox29.Location = New System.Drawing.Point(10, 195)
        Me.TCBox29.Name = "TCBox29"
        Me.TCBox29.Size = New System.Drawing.Size(52, 17)
        Me.TCBox29.TabIndex = 28
        Me.TCBox29.Text = "TC29"
        Me.TCBox29.UseVisualStyleBackColor = True
        '
        'TCBox28
        '
        Me.TCBox28.AutoSize = True
        Me.TCBox28.Location = New System.Drawing.Point(220, 170)
        Me.TCBox28.Name = "TCBox28"
        Me.TCBox28.Size = New System.Drawing.Size(52, 17)
        Me.TCBox28.TabIndex = 27
        Me.TCBox28.Text = "TC28"
        Me.TCBox28.UseVisualStyleBackColor = True
        '
        'TCBox27
        '
        Me.TCBox27.AutoSize = True
        Me.TCBox27.Location = New System.Drawing.Point(150, 170)
        Me.TCBox27.Name = "TCBox27"
        Me.TCBox27.Size = New System.Drawing.Size(52, 17)
        Me.TCBox27.TabIndex = 26
        Me.TCBox27.Text = "TC27"
        Me.TCBox27.UseVisualStyleBackColor = True
        '
        'TCBox26
        '
        Me.TCBox26.AutoSize = True
        Me.TCBox26.Location = New System.Drawing.Point(80, 170)
        Me.TCBox26.Name = "TCBox26"
        Me.TCBox26.Size = New System.Drawing.Size(52, 17)
        Me.TCBox26.TabIndex = 25
        Me.TCBox26.Text = "TC26"
        Me.TCBox26.UseVisualStyleBackColor = True
        '
        'TCBox25
        '
        Me.TCBox25.AutoSize = True
        Me.TCBox25.Location = New System.Drawing.Point(10, 170)
        Me.TCBox25.Name = "TCBox25"
        Me.TCBox25.Size = New System.Drawing.Size(52, 17)
        Me.TCBox25.TabIndex = 24
        Me.TCBox25.Text = "TC25"
        Me.TCBox25.UseVisualStyleBackColor = True
        '
        'TCBox24
        '
        Me.TCBox24.AutoSize = True
        Me.TCBox24.Location = New System.Drawing.Point(220, 145)
        Me.TCBox24.Name = "TCBox24"
        Me.TCBox24.Size = New System.Drawing.Size(52, 17)
        Me.TCBox24.TabIndex = 23
        Me.TCBox24.Text = "TC24"
        Me.TCBox24.UseVisualStyleBackColor = True
        '
        'TCBox23
        '
        Me.TCBox23.AutoSize = True
        Me.TCBox23.Location = New System.Drawing.Point(150, 145)
        Me.TCBox23.Name = "TCBox23"
        Me.TCBox23.Size = New System.Drawing.Size(52, 17)
        Me.TCBox23.TabIndex = 22
        Me.TCBox23.Text = "TC23"
        Me.TCBox23.UseVisualStyleBackColor = True
        '
        'TCBox22
        '
        Me.TCBox22.AutoSize = True
        Me.TCBox22.Location = New System.Drawing.Point(80, 145)
        Me.TCBox22.Name = "TCBox22"
        Me.TCBox22.Size = New System.Drawing.Size(52, 17)
        Me.TCBox22.TabIndex = 21
        Me.TCBox22.Text = "TC22"
        Me.TCBox22.UseVisualStyleBackColor = True
        '
        'TCBox21
        '
        Me.TCBox21.AutoSize = True
        Me.TCBox21.Location = New System.Drawing.Point(10, 145)
        Me.TCBox21.Name = "TCBox21"
        Me.TCBox21.Size = New System.Drawing.Size(52, 17)
        Me.TCBox21.TabIndex = 20
        Me.TCBox21.Text = "TC21"
        Me.TCBox21.UseVisualStyleBackColor = True
        '
        'TCBox20
        '
        Me.TCBox20.AutoSize = True
        Me.TCBox20.Location = New System.Drawing.Point(220, 120)
        Me.TCBox20.Name = "TCBox20"
        Me.TCBox20.Size = New System.Drawing.Size(52, 17)
        Me.TCBox20.TabIndex = 19
        Me.TCBox20.Text = "TC20"
        Me.TCBox20.UseVisualStyleBackColor = True
        '
        'TCBox19
        '
        Me.TCBox19.AutoSize = True
        Me.TCBox19.Location = New System.Drawing.Point(150, 120)
        Me.TCBox19.Name = "TCBox19"
        Me.TCBox19.Size = New System.Drawing.Size(52, 17)
        Me.TCBox19.TabIndex = 18
        Me.TCBox19.Text = "TC19"
        Me.TCBox19.UseVisualStyleBackColor = True
        '
        'TCBox18
        '
        Me.TCBox18.AutoSize = True
        Me.TCBox18.Location = New System.Drawing.Point(80, 120)
        Me.TCBox18.Name = "TCBox18"
        Me.TCBox18.Size = New System.Drawing.Size(52, 17)
        Me.TCBox18.TabIndex = 17
        Me.TCBox18.Text = "TC18"
        Me.TCBox18.UseVisualStyleBackColor = True
        '
        'TCBox17
        '
        Me.TCBox17.AutoSize = True
        Me.TCBox17.Location = New System.Drawing.Point(10, 120)
        Me.TCBox17.Name = "TCBox17"
        Me.TCBox17.Size = New System.Drawing.Size(52, 17)
        Me.TCBox17.TabIndex = 16
        Me.TCBox17.Text = "TC17"
        Me.TCBox17.UseVisualStyleBackColor = True
        '
        'TCBox16
        '
        Me.TCBox16.AutoSize = True
        Me.TCBox16.Location = New System.Drawing.Point(220, 95)
        Me.TCBox16.Name = "TCBox16"
        Me.TCBox16.Size = New System.Drawing.Size(52, 17)
        Me.TCBox16.TabIndex = 15
        Me.TCBox16.Text = "TC16"
        Me.TCBox16.UseVisualStyleBackColor = True
        '
        'TCBox15
        '
        Me.TCBox15.AutoSize = True
        Me.TCBox15.Location = New System.Drawing.Point(150, 95)
        Me.TCBox15.Name = "TCBox15"
        Me.TCBox15.Size = New System.Drawing.Size(52, 17)
        Me.TCBox15.TabIndex = 14
        Me.TCBox15.Text = "TC15"
        Me.TCBox15.UseVisualStyleBackColor = True
        '
        'TCBox14
        '
        Me.TCBox14.AutoSize = True
        Me.TCBox14.Location = New System.Drawing.Point(80, 95)
        Me.TCBox14.Name = "TCBox14"
        Me.TCBox14.Size = New System.Drawing.Size(52, 17)
        Me.TCBox14.TabIndex = 13
        Me.TCBox14.Text = "TC14"
        Me.TCBox14.UseVisualStyleBackColor = True
        '
        'TCBox13
        '
        Me.TCBox13.AutoSize = True
        Me.TCBox13.Location = New System.Drawing.Point(10, 95)
        Me.TCBox13.Name = "TCBox13"
        Me.TCBox13.Size = New System.Drawing.Size(52, 17)
        Me.TCBox13.TabIndex = 12
        Me.TCBox13.Text = "TC13"
        Me.TCBox13.UseVisualStyleBackColor = True
        '
        'TCBox12
        '
        Me.TCBox12.AutoSize = True
        Me.TCBox12.Location = New System.Drawing.Point(220, 70)
        Me.TCBox12.Name = "TCBox12"
        Me.TCBox12.Size = New System.Drawing.Size(52, 17)
        Me.TCBox12.TabIndex = 11
        Me.TCBox12.Text = "TC12"
        Me.TCBox12.UseVisualStyleBackColor = True
        '
        'TCBox11
        '
        Me.TCBox11.AutoSize = True
        Me.TCBox11.Location = New System.Drawing.Point(150, 70)
        Me.TCBox11.Name = "TCBox11"
        Me.TCBox11.Size = New System.Drawing.Size(52, 17)
        Me.TCBox11.TabIndex = 10
        Me.TCBox11.Text = "TC11"
        Me.TCBox11.UseVisualStyleBackColor = True
        '
        'TCBox10
        '
        Me.TCBox10.AutoSize = True
        Me.TCBox10.Location = New System.Drawing.Point(80, 70)
        Me.TCBox10.Name = "TCBox10"
        Me.TCBox10.Size = New System.Drawing.Size(52, 17)
        Me.TCBox10.TabIndex = 9
        Me.TCBox10.Text = "TC10"
        Me.TCBox10.UseVisualStyleBackColor = True
        '
        'TCBox9
        '
        Me.TCBox9.AutoSize = True
        Me.TCBox9.Location = New System.Drawing.Point(10, 70)
        Me.TCBox9.Name = "TCBox9"
        Me.TCBox9.Size = New System.Drawing.Size(46, 17)
        Me.TCBox9.TabIndex = 8
        Me.TCBox9.Text = "TC9"
        Me.TCBox9.UseVisualStyleBackColor = True
        '
        'TCBox8
        '
        Me.TCBox8.AutoSize = True
        Me.TCBox8.Location = New System.Drawing.Point(220, 45)
        Me.TCBox8.Name = "TCBox8"
        Me.TCBox8.Size = New System.Drawing.Size(46, 17)
        Me.TCBox8.TabIndex = 7
        Me.TCBox8.Text = "TC8"
        Me.TCBox8.UseVisualStyleBackColor = True
        '
        'TC4Box
        '
        Me.TC4Box.AutoSize = True
        Me.TC4Box.Location = New System.Drawing.Point(220, 20)
        Me.TC4Box.Name = "TC4Box"
        Me.TC4Box.Size = New System.Drawing.Size(46, 17)
        Me.TC4Box.TabIndex = 3
        Me.TC4Box.Text = "TC4"
        Me.TC4Box.UseVisualStyleBackColor = True
        '
        'TC3Box
        '
        Me.TC3Box.AutoSize = True
        Me.TC3Box.Location = New System.Drawing.Point(150, 20)
        Me.TC3Box.Name = "TC3Box"
        Me.TC3Box.Size = New System.Drawing.Size(46, 17)
        Me.TC3Box.TabIndex = 2
        Me.TC3Box.Text = "TC3"
        Me.TC3Box.UseVisualStyleBackColor = True
        '
        'TCBox7
        '
        Me.TCBox7.AutoSize = True
        Me.TCBox7.Location = New System.Drawing.Point(150, 45)
        Me.TCBox7.Name = "TCBox7"
        Me.TCBox7.Size = New System.Drawing.Size(46, 17)
        Me.TCBox7.TabIndex = 6
        Me.TCBox7.Text = "TC7"
        Me.TCBox7.UseVisualStyleBackColor = True
        '
        'TC2Box
        '
        Me.TC2Box.AutoSize = True
        Me.TC2Box.Location = New System.Drawing.Point(80, 20)
        Me.TC2Box.Name = "TC2Box"
        Me.TC2Box.Size = New System.Drawing.Size(46, 17)
        Me.TC2Box.TabIndex = 1
        Me.TC2Box.Text = "TC2"
        Me.TC2Box.UseVisualStyleBackColor = True
        '
        'TC1Box
        '
        Me.TC1Box.AutoSize = True
        Me.TC1Box.Location = New System.Drawing.Point(10, 20)
        Me.TC1Box.Name = "TC1Box"
        Me.TC1Box.Size = New System.Drawing.Size(46, 17)
        Me.TC1Box.TabIndex = 0
        Me.TC1Box.Text = "TC1"
        Me.TC1Box.UseVisualStyleBackColor = True
        '
        'TCBox6
        '
        Me.TCBox6.AutoSize = True
        Me.TCBox6.Location = New System.Drawing.Point(80, 45)
        Me.TCBox6.Name = "TCBox6"
        Me.TCBox6.Size = New System.Drawing.Size(46, 17)
        Me.TCBox6.TabIndex = 5
        Me.TCBox6.Text = "TC6"
        Me.TCBox6.UseVisualStyleBackColor = True
        '
        'TC5Box
        '
        Me.TC5Box.AutoSize = True
        Me.TC5Box.Location = New System.Drawing.Point(10, 45)
        Me.TC5Box.Name = "TC5Box"
        Me.TC5Box.Size = New System.Drawing.Size(46, 17)
        Me.TC5Box.TabIndex = 4
        Me.TC5Box.Text = "TC5"
        Me.TC5Box.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "1. Enter 4-digit PIN:"
        '
        'PasswordButton
        '
        Me.PasswordButton.Location = New System.Drawing.Point(118, 47)
        Me.PasswordButton.Name = "PasswordButton"
        Me.PasswordButton.Size = New System.Drawing.Size(105, 23)
        Me.PasswordButton.TabIndex = 26
        Me.PasswordButton.Text = "Enter Password..."
        Me.PasswordButton.UseVisualStyleBackColor = True
        '
        'TextBoxForUserAuthentication
        '
        Me.TextBoxForUserAuthentication.Enabled = False
        Me.TextBoxForUserAuthentication.Location = New System.Drawing.Point(123, 76)
        Me.TextBoxForUserAuthentication.Name = "TextBoxForUserAuthentication"
        Me.TextBoxForUserAuthentication.Size = New System.Drawing.Size(170, 20)
        Me.TextBoxForUserAuthentication.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "User ID: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 758)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxForUserAuthentication)
        Me.Controls.Add(Me.PasswordButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxForTCs)
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
        Me.GroupBoxForTCs.ResumeLayout(False)
        Me.GroupBoxForTCs.PerformLayout()
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
    Friend WithEvents GroupBoxForTCs As GroupBox
    Friend WithEvents TCBox32 As CheckBox
    Friend WithEvents TCBox31 As CheckBox
    Friend WithEvents TCBox30 As CheckBox
    Friend WithEvents TCBox29 As CheckBox
    Friend WithEvents TCBox28 As CheckBox
    Friend WithEvents TCBox27 As CheckBox
    Friend WithEvents TCBox26 As CheckBox
    Friend WithEvents TCBox25 As CheckBox
    Friend WithEvents TCBox24 As CheckBox
    Friend WithEvents TCBox23 As CheckBox
    Friend WithEvents TCBox22 As CheckBox
    Friend WithEvents TCBox21 As CheckBox
    Friend WithEvents TCBox20 As CheckBox
    Friend WithEvents TCBox19 As CheckBox
    Friend WithEvents TCBox18 As CheckBox
    Friend WithEvents TCBox17 As CheckBox
    Friend WithEvents TCBox16 As CheckBox
    Friend WithEvents TCBox15 As CheckBox
    Friend WithEvents TCBox14 As CheckBox
    Friend WithEvents TCBox13 As CheckBox
    Friend WithEvents TCBox12 As CheckBox
    Friend WithEvents TCBox11 As CheckBox
    Friend WithEvents TCBox10 As CheckBox
    Friend WithEvents TCBox9 As CheckBox
    Friend WithEvents TCBox8 As CheckBox
    Friend WithEvents TC4Box As CheckBox
    Friend WithEvents TC3Box As CheckBox
    Friend WithEvents TCBox7 As CheckBox
    Friend WithEvents TC2Box As CheckBox
    Friend WithEvents TC1Box As CheckBox
    Friend WithEvents TCBox6 As CheckBox
    Friend WithEvents TC5Box As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordButton As Button
    Friend WithEvents TextBoxForUserAuthentication As TextBox
    Friend WithEvents Label2 As Label
End Class
