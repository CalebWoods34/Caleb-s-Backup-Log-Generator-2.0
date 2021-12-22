'imports block
Imports System.IO
Imports ClosedXML.Excel
Imports Microsoft.VisualBasic.FileIO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    'declaration block
    Public UserEnteredPassword As String, CalebPin As String, KevinPin As String, VinhPin As String, MikePin As String
    Dim strtext As String
    Public CureDeviceName As String, PartNumberTextBoxUserEntry As String, JobNumberTextBoxUserEntry As String, SerialNumberTextBoxUserEntry As String
    Dim MessageBoxTitle As String
    Public filepath As String, filepath2 As String
    Public intcount As Integer
    Public textin As StreamReader, template As StreamReader
    Public s As String
    Public ExcelSheetUserIdentification As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disables the buttons on startup until the password has been entered for the program
        TextBoxForUserAuthentication.Visible = False
        SelectBackupLogBrowseButton.Enabled = False
        GroupBoxForTCs.Enabled = False
        CreateBackupLogButton.Enabled = False
        PartNumberTextBox.Enabled = False
        JobNumberTextBox.Enabled = False
        SerialNumberTextBox.Enabled = False
        'adds values to the pin numbers
        VinhPin = 1314
        KevinPin = 2002
        CalebPin = 3189
    End Sub

    'password required before a backup log can be created
    Private Sub PasswordButton_click(sender As Object, e As EventArgs) Handles PasswordButton.Click
        UserEnteredPassword = InputBox("Please enter your 4-digit PIN number")
        If Not UserEnteredPassword = VinhPin And Not UserEnteredPassword = CalebPin And Not UserEnteredPassword = KevinPin Then
            Call IncorrectPasswordLockout()
        Else
            Call CorrectPasswordEntry()
            If UserEnteredPassword = VinhPin Then
                ExcelSheetUserIdentification = "Vinh Nguyen, E396"
                TextBoxForUserAuthentication.Text = ExcelSheetUserIdentification
            ElseIf UserEnteredPassword = CalebPin Then
                ExcelSheetUserIdentification = "Caleb Woods, E405"
                TextBoxForUserAuthentication.Text = ExcelSheetUserIdentification
            ElseIf UserEnteredPassword = KevinPin Then
                ExcelSheetUserIdentification = "Kevin Forward, E208"
                TextBoxForUserAuthentication.Text = ExcelSheetUserIdentification
            End If
        End If
    End Sub
    Private Sub PartNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles PartNumberTextBox.TextChanged
        PartNumberTextBoxUserEntry = PartNumberTextBox.Text
    End Sub
    Private Sub JobNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles JobNumberTextBox.TextChanged
        JobNumberTextBoxUserEntry = JobNumberTextBox.Text
    End Sub
    Private Sub SerialNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SerialNumberTextBox.TextChanged
        SerialNumberTextBoxUserEntry = SerialNumberTextBox.Text
    End Sub
    Private Sub SelectBackupLogBrowseButton_click(sender As Object, e As EventArgs) Handles SelectBackupLogBrowseButton.Click

        'calls openfiledialogsearchforcsv to search for CSV file and set filename equal to the file name and path
        Call OpenFileDialogSearchForCSV()

        'calls cleardatagridviews to clear datagridviewforcsv, datagridviewforselectedrange, and text boxes each time a new csv is looked for
        Call ClearDataGridViews()

        'reads CSV into datagridview
        Try
            textin = New StreamReader(New FileStream(filepath, FileMode.Open, FileAccess.Read)) 'Code borrowed from the unfinished backup log generator in AC 2.0
            Dim Writestring() As String = Split(textin.ReadLine, ",")
            For i As Integer = 0 To Writestring.Count - 1
                DataGridViewForCSV.Columns.Add(Writestring(i), Writestring(i))
            Next
            intcount = Writestring.Count - 1
            Do While textin.Peek <> -1
                Dim Write() As String = Split(textin.ReadLine, ",")
                DataGridViewForCSV.Rows.Add(Write)
            Loop
            textin.Close()

            'creates rownumbers for datagridforcsv
            Dim rowNumber As Integer = 0
            For Each row As DataGridViewRow In DataGridViewForCSV.Rows
                If row.IsNewRow Then Continue For
                row.HeaderCell.Value = "row " & rowNumber
                rowNumber += 1
            Next
            DataGridViewForCSV.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)

            'automatically parse filepath for cure device name and print to text box, error catches for unsupported devices as well
            s = filepath
            s = s.Substring(s.IndexOf("s\") + 7)
            s = s.Substring(0, s.IndexOf(".") - 9)
            CureDeviceNameTextBox.Text = s
            If filepath.Contains("Alarms") OrElse filepath.Contains("batch") OrElse filepath.Contains("comms") OrElse filepath.Contains("Maint") OrElse filepath.Contains("mnt_P14") OrElse filepath.Contains("NAA") OrElse filepath.Contains("PressALM") OrElse filepath.Contains("PumpTest") OrElse filepath.Contains("UtltyRm") OrElse filepath.Contains("VARTMAlm") Then
                MessageBox.Show("This folder is not supported by the backup log generator. Contact Caleb if this error persists.", MessageBoxTitle)
                Call ClearFilepathAndBackupLogTextBox()
                Call ClearDataGridViews()
                Call ClearThermocoupleSelection()
                GroupBoxForTCs.Enabled = False
            End If
            GroupBoxForTCs.Enabled = True

            'call to function to scan for device name and disables thermocouple selection choice depending on cure device 
            Call ClearThermocoupleSelection()
            Call CheckThermocoupleCompatibility()
            CreateBackupLogButton.Enabled = True
        Catch
            Call ClearDataGridViews()
            Call ClearFilepathAndBackupLogTextBox()
            Call ClearThermocoupleSelection()
            GroupBoxForTCs.Enabled = False
            MessageBox.Show("Invalid file choice. Please try again.", MessageBoxTitle)
        End Try

    End Sub
    Private Sub CreateBackupLogButton_click(sender As Object, e As EventArgs) Handles CreateBackupLogButton.Click

        'disables buttons and text boxes after click until log generation is finished in order to avoid errors
        DataGridViewForCSV.Enabled = False
        CreateBackupLogButton.Enabled = False
        SelectBackupLogBrowseButton.Enabled = False
        PartNumberTextBox.Enabled = False
        JobNumberTextBox.Enabled = False
        SerialNumberTextBox.Enabled = False
        GroupBoxForTCs.Enabled = False

        'clear rows and columns for each CSV loaded
        DataGridViewForSelectedRange.Columns.Clear()
        DataGridViewForSelectedRange.Rows.Clear()
        For Each datacolumn As DataGridViewColumn In DataGridViewForCSV.Columns
            DataGridViewForSelectedRange.Columns.Add(TryCast(datacolumn.Clone(), DataGridViewColumn))
        Next

        'copy rows and cells
        Dim SelectedDataRow As DataGridViewRow = New DataGridViewRow()
        For k As Integer = 0 To DataGridViewForCSV.SelectedRows.Count - 1
            SelectedDataRow = CType(DataGridViewForCSV.SelectedRows(k).Clone(), DataGridViewRow)
            Dim SelectedDataRowIndex As Integer = 0
            For Each cell As DataGridViewCell In DataGridViewForCSV.SelectedRows(k).Cells
                SelectedDataRow.Cells(SelectedDataRowIndex).Value = cell.Value
                SelectedDataRowIndex += 1
            Next
            DataGridViewForSelectedRange.Rows.Add(SelectedDataRow)
        Next

        'invert rows so they display properly in the selected range datagridview
        Dim rows As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()
        rows.AddRange(DataGridViewForSelectedRange.Rows.Cast(Of DataGridViewRow)())
        rows.Reverse()
        DataGridViewForSelectedRange.Rows.Clear()
        DataGridViewForSelectedRange.Rows.AddRange(rows.ToArray())

        'create row numbers
        Dim rowNumber As Integer = 0
        For Each row As DataGridViewRow In DataGridViewForSelectedRange.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = "row " & rowNumber
            rowNumber += 1
        Next

        'format row headers to be easier to read
        DataGridViewForSelectedRange.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)

        'move contents of datagridviewforselectedrange to clipboard to copy contents to the template
        DataGridViewForSelectedRange.SelectAll()
        Dim DataGridViewForSelectedRangeExportToExcel As Object = DataGridViewForSelectedRange.GetClipboardContent()
        If DataGridViewForSelectedRangeExportToExcel IsNot Nothing Then
            Clipboard.SetDataObject(DataGridViewForSelectedRangeExportToExcel)
        End If

        'copy clipboard to excel file
        Dim xlapp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim MissingValue As Object = System.Reflection.Missing.Value
        xlapp = New Excel.Application
        xlWorkBook = xlapp.Workbooks.Add(MissingValue)
        xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

        'fills excel sheet and changes log layout depend on pump or cure device 
        If s.Contains("Pump") Then
            xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        Else
            xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait
        End If
        Dim DataGridViewForSelectedRangeChosenRange As Excel.Range = CType(xlWorkSheet.Cells(1, 1), Excel.Range)
        DataGridViewForSelectedRangeChosenRange.[Select]()
        xlWorkSheet.PasteSpecial(DataGridViewForSelectedRangeChosenRange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
        xlWorkSheet.Columns.AutoFit()
        xlWorkSheet.Rows.AutoFit()
        'hides columns in excel sheet if TC box isn't selected for Ovens 
        If s.Contains("Oven") OrElse s.Contains("OVEN") Then
            If TC1Box.Checked = False Then
                xlWorkSheet.Range("F:F").EntireColumn.Hidden = True
            End If
            If TC2Box.Checked = False Then
                xlWorkSheet.Range("G:G").EntireColumn.Hidden = True
            End If
            If TC3Box.Checked = False Then
                xlWorkSheet.Range("H:H").EntireColumn.Hidden = True
            End If
            If TC4Box.Checked = False Then
                xlWorkSheet.Range("I:I").EntireColumn.Hidden = True
            End If
            If TC5Box.Checked = False Then
                xlWorkSheet.Range("J:J").EntireColumn.Hidden = True
            End If
            If TCBox6.Checked = False Then
                xlWorkSheet.Range("K:K").EntireColumn.Hidden = True
            End If
            If TCBox7.Checked = False Then
                xlWorkSheet.Range("L:L").EntireColumn.Hidden = True
            End If
            If TCBox8.Checked = False Then
                xlWorkSheet.Range("M:M").EntireColumn.Hidden = True
            End If
            If TCBox9.Checked = False Then
                xlWorkSheet.Range("N:N").EntireColumn.Hidden = True
            End If
            If TCBox10.Checked = False Then
                xlWorkSheet.Range("O:O").EntireColumn.Hidden = True
            End If
            If TCBox11.Checked = False Then
                xlWorkSheet.Range("P:P").EntireColumn.Hidden = True
            End If
            If TCBox12.Checked = False Then
                xlWorkSheet.Range("Q:Q").EntireColumn.Hidden = True
            End If
            If TCBox13.Checked = False Then
                xlWorkSheet.Range("R:R").EntireColumn.Hidden = True
            End If
            If TCBox14.Checked = False Then
                xlWorkSheet.Range("S:S").EntireColumn.Hidden = True
            End If
            If TCBox15.Checked = False Then
                xlWorkSheet.Range("T:T").EntireColumn.Hidden = True
            End If
            If TCBox16.Checked = False Then
                xlWorkSheet.Range("U:U").EntireColumn.Hidden = True
            End If
            If TCBox17.Checked = False Then
                xlWorkSheet.Range("V:V").EntireColumn.Hidden = True
            End If
            If TCBox18.Checked = False Then
                xlWorkSheet.Range("W:W").EntireColumn.Hidden = True
            End If
            If TCBox19.Checked = False Then
                xlWorkSheet.Range("X:X").EntireColumn.Hidden = True
            End If
            If TCBox20.Checked = False Then
                xlWorkSheet.Range("Y:Y").EntireColumn.Hidden = True
            End If
            If TCBox21.Checked = False Then
                xlWorkSheet.Range("Z:Z").EntireColumn.Hidden = True
            End If
            If TCBox22.Checked = False Then
                xlWorkSheet.Range("AA:AA").EntireColumn.Hidden = True
            End If
            If TCBox23.Checked = False Then
                xlWorkSheet.Range("AB:AB").EntireColumn.Hidden = True
            End If
            If TCBox24.Checked = False Then
                xlWorkSheet.Range("AC:AC").EntireColumn.Hidden = True
            End If
            If TCBox25.Checked = False Then
                xlWorkSheet.Range("AD:AD").EntireColumn.Hidden = True
            End If
            If TCBox26.Checked = False Then
                xlWorkSheet.Range("AE:AE").EntireColumn.Hidden = True
            End If
            If TCBox27.Checked = False Then
                xlWorkSheet.Range("AF:AF").EntireColumn.Hidden = True
            End If
            If TCBox28.Checked = False Then
                xlWorkSheet.Range("AG:AG").EntireColumn.Hidden = True
            End If
            If TCBox29.Checked = False Then
                xlWorkSheet.Range("AH:AH").EntireColumn.Hidden = True
            End If
            If TCBox30.Checked = False Then
                xlWorkSheet.Range("AI:AI").EntireColumn.Hidden = True
            End If
            If TCBox31.Checked = False Then
                xlWorkSheet.Range("AJ:AJ").EntireColumn.Hidden = True
            End If
            If TCBox32.Checked = False Then
                xlWorkSheet.Range("AK:AK").EntireColumn.Hidden = True
            End If
            xlWorkSheet.Range("AL:AL").EntireColumn.Hidden = True
        End If

        'scans to determine if the backup log is a press log and adjusts log accordingly
        If s.Contains("Press") OrElse s.Contains("VARTM") Then
            xlWorkSheet.Range("F:F").EntireColumn.Hidden = True
            xlWorkSheet.Range("G:G").EntireColumn.Hidden = True
        End If

        'format excel sheets
        xlWorkSheet.PageSetup.Zoom = False
        xlWorkSheet.PageSetup.FitToPagesWide = 1
        xlWorkSheet.PageSetup.FitToPagesTall = False
        xlWorkSheet.PageSetup.PrintGridlines = True
        xlWorkBook.Sheets.Add.name = "Sheet2"
        xlWorkBook.Sheets("Sheet2").range("A1:D1").merge()
        xlWorkBook.Sheets("Sheet2").range("A2:D2").merge()
        xlWorkBook.Sheets("Sheet2").range("A3:D3").merge()
        xlWorkBook.Sheets("Sheet2").range("A4:D4").merge()
        xlWorkBook.Sheets("Sheet2").range("A5:D5").merge()
        xlWorkBook.Sheets("Sheet2").range("A6:D6").merge()
        xlWorkBook.Sheets("Sheet2").range("A7:D7").merge()
        xlWorkBook.Sheets("Sheet2").cells(1, 1) = "FDI Backup Log"
        xlWorkBook.Sheets("Sheet2").cells(2, 1) = "Printed on:   " & DateTime.Now
        xlWorkBook.Sheets("Sheet2").cells(3, 1) = "Print by:   " & ExcelSheetUserIdentification
        xlWorkBook.Sheets("Sheet2").cells(4, 1) = "Cure Device:   " & CureDeviceNameTextBox.Text
        xlWorkBook.Sheets("Sheet2").cells(5, 1) = "Job Number:   " & JobNumberTextBox.Text
        xlWorkBook.Sheets("Sheet2").cells(6, 1) = "Part Number:   " & PartNumberTextBox.Text
        xlWorkBook.Sheets("Sheet2").cells(7, 1) = "Serial Number:   " & SerialNumberTextBox.Text
        xlapp.Visible = False
        xlWorkBook.Sheets("Sheet1").exportasfixedformat(0, "S:\AutoCure\Caleb's Backup Log Generator 2.0\Backup Log PDF files\BackupLog.pdf")
        xlWorkBook.Sheets("Sheet2").exportasfixedformat(0, "S:\AutoCure\Caleb's Backup Log Generator 2.0\Backup Log PDF files\BackupLogInformation.pdf")
        Dim messageboxtitle2 As String
        messageboxtitle2 = "Caleb's Backup Log Generator 2.0"
        MessageBox.Show("PDF files generated and placed in (S:\AutoCure\Caleb's Backup Log Generator 2.0). PDF Files will be overwritten for each subsequent backup log.", messageboxtitle2)
        xlWorkBook.Saved = False
        'xlapp.Quit()

        'reactivates buttons and clears text boxes after log generation to avoid errors
        DataGridViewForCSV.Enabled = True
        CreateBackupLogButton.Enabled = True
        SelectBackupLogBrowseButton.Enabled = True
        PartNumberTextBox.Enabled = True
        JobNumberTextBox.Enabled = True
        SerialNumberTextBox.Enabled = True
    End Sub







    'functions

    'function for clearing text boxes
    Public Sub ClearAllTextBoxes()
        CureDeviceNameTextBox.Text = Nothing
        JobNumberTextBox.Text = Nothing
        SerialNumberTextBox.Text = Nothing
        PartNumberTextBox.Text = Nothing
    End Sub
    'function for clearing datagridviews
    Public Sub ClearDataGridViews()
        DataGridViewForCSV.Columns.Clear()
        DataGridViewForCSV.Rows.Clear()
        DataGridViewForSelectedRange.Columns.Clear()
        DataGridViewForSelectedRange.Rows.Clear()
    End Sub

    'function for clearing text boxes and filepath variable
    Public Sub ClearFilepathAndBackupLogTextBox()
        filepath = Nothing
        BackupLogTextBox.Text = Nothing
        MessageBoxTitle = "Caleb's Backup Log Generator 2.0"
    End Sub

    'function for openfiledialog to find CSV
    Public Sub OpenFileDialogSearchForCSV()
        OpenFileDialog1.Title = "Select the backup data log (.csv): " 'This titles the search box 
        OpenFileDialog1.Filter = "Comma Seperated Value File (*.csv)|*.csv"
        OpenFileDialog1.InitialDirectory = "S:\AutoCure\BackupLogs\logs" 'This directs the openfiledialog box to search this directory
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        BackupLogTextBox.Text = filepath
    End Sub

    'function to disable certain thermocouples for presses and VARTMs
    Public Sub DisableThermocouplesForPressAndVARTM()
        TC1Box.Enabled = False
        TC1Box.Checked = True
        TC2Box.Enabled = False
        TC3Box.Enabled = False
        TC4Box.Enabled = False
        TC5Box.Enabled = False
        TCBox6.Enabled = False
        TCBox7.Enabled = False
        TCBox8.Enabled = False
        TCBox9.Enabled = False
        TCBox10.Enabled = False
        TCBox11.Enabled = False
        TCBox12.Enabled = False
        TCBox13.Enabled = False
        TCBox14.Enabled = False
        TCBox15.Enabled = False
        TCBox16.Enabled = False
        TCBox17.Enabled = False
        TCBox18.Enabled = False
        TCBox19.Enabled = False
        TCBox20.Enabled = False
        TCBox21.Enabled = False
        TCBox22.Enabled = False
        TCBox23.Enabled = False
        TCBox24.Enabled = False
        TCBox25.Enabled = False
        TCBox26.Enabled = False
        TCBox27.Enabled = False
        TCBox28.Enabled = False
        TCBox29.Enabled = False
        TCBox30.Enabled = False
        TCBox31.Enabled = False
        TCBox32.Enabled = False
    End Sub

    'function to clear thermocouple selection
    Public Sub ClearThermocoupleSelection()
        TC1Box.Checked = False
        TC2Box.Checked = False
        TC3Box.Checked = False
        TC4Box.Checked = False
        TC5Box.Checked = False
        TCBox6.Checked = False
        TCBox7.Checked = False
        TCBox8.Checked = False
        TCBox9.Checked = False
        TCBox10.Checked = False
        TCBox11.Checked = False
        TCBox12.Checked = False
        TCBox13.Checked = False
        TCBox14.Checked = False
        TCBox15.Checked = False
        TCBox16.Checked = False
        TCBox17.Checked = False
        TCBox18.Checked = False
        TCBox19.Checked = False
        TCBox20.Checked = False
        TCBox21.Checked = False
        TCBox22.Checked = False
        TCBox23.Checked = False
        TCBox24.Checked = False
        TCBox25.Checked = False
        TCBox26.Checked = False
        TCBox27.Checked = False
        TCBox28.Checked = False
        TCBox29.Checked = False
        TCBox30.Checked = False
        TCBox31.Checked = False
        TCBox32.Checked = False
    End Sub

    'function for enabling all TCs for ovens F and A 
    Public Sub EnableAllTCsForOvensAandF()
        TC1Box.Enabled = True
        TC2Box.Enabled = True
        TC3Box.Enabled = True
        TC4Box.Enabled = True
        TC5Box.Enabled = True
        TCBox6.Enabled = True
        TCBox7.Enabled = True
        TCBox8.Enabled = True
        TCBox9.Enabled = True
        TCBox10.Enabled = True
        TCBox11.Enabled = True
        TCBox12.Enabled = True
        TCBox13.Enabled = True
        TCBox14.Enabled = True
        TCBox15.Enabled = True
        TCBox16.Enabled = True
        TCBox17.Enabled = True
        TCBox18.Enabled = True
        TCBox19.Enabled = True
        TCBox20.Enabled = True
        TCBox21.Enabled = True
        TCBox22.Enabled = True
        TCBox23.Enabled = True
        TCBox24.Enabled = True
        TCBox25.Enabled = True
        TCBox26.Enabled = True
        TCBox27.Enabled = True
        TCBox28.Enabled = True
        TCBox29.Enabled = True
        TCBox30.Enabled = True
        TCBox31.Enabled = True
        TCBox32.Enabled = True
    End Sub

    'function for enabling select TCs on oven B
    Public Sub EnableSelectTCsforOvenB()
        TC1Box.Enabled = True
        TC2Box.Enabled = True
        TC3Box.Enabled = True
        TC4Box.Enabled = True
        TC5Box.Enabled = True
        TCBox6.Enabled = True
        TCBox7.Enabled = True
        TCBox8.Enabled = True
        TCBox9.Enabled = False
        TCBox10.Enabled = False
        TCBox11.Enabled = False
        TCBox12.Enabled = False
        TCBox13.Enabled = False
        TCBox14.Enabled = False
        TCBox15.Enabled = False
        TCBox16.Enabled = False
        TCBox17.Enabled = False
        TCBox18.Enabled = False
        TCBox19.Enabled = False
        TCBox20.Enabled = False
        TCBox21.Enabled = False
        TCBox22.Enabled = False
        TCBox23.Enabled = False
        TCBox24.Enabled = False
        TCBox25.Enabled = False
        TCBox26.Enabled = False
        TCBox27.Enabled = False
        TCBox28.Enabled = False
        TCBox29.Enabled = False
        TCBox30.Enabled = False
        TCBox31.Enabled = False
        TCBox32.Enabled = False
    End Sub

    'function for enabling select TCs on oven C
    Public Sub EnableSelectTCsforOvenCandOvenAandOvenFAlternates()
        TC1Box.Enabled = True
        TC2Box.Enabled = True
        TC3Box.Enabled = True
        TC4Box.Enabled = True
        TC5Box.Enabled = True
        TCBox6.Enabled = True
        TCBox7.Enabled = True
        TCBox8.Enabled = True
        TCBox9.Enabled = True
        TCBox10.Enabled = True
        TCBox11.Enabled = True
        TCBox12.Enabled = True
        TCBox13.Enabled = True
        TCBox14.Enabled = True
        TCBox15.Enabled = True
        TCBox16.Enabled = True
        TCBox17.Enabled = False
        TCBox18.Enabled = False
        TCBox19.Enabled = False
        TCBox20.Enabled = False
        TCBox21.Enabled = False
        TCBox22.Enabled = False
        TCBox23.Enabled = False
        TCBox24.Enabled = False
        TCBox25.Enabled = False
        TCBox26.Enabled = False
        TCBox27.Enabled = False
        TCBox28.Enabled = False
        TCBox29.Enabled = False
        TCBox30.Enabled = False
        TCBox31.Enabled = False
        TCBox32.Enabled = False
    End Sub

    'function for enabling select TCs on oven G
    Public Sub EnableSelectTCsforOvenG()
        TC1Box.Enabled = True
        TC2Box.Enabled = True
        TC3Box.Enabled = True
        TC4Box.Enabled = True
        TC5Box.Enabled = True
        TCBox6.Enabled = True
        TCBox7.Enabled = False
        TCBox8.Enabled = False
        TCBox9.Enabled = False
        TCBox10.Enabled = False
        TCBox11.Enabled = False
        TCBox12.Enabled = False
        TCBox13.Enabled = False
        TCBox14.Enabled = False
        TCBox15.Enabled = False
        TCBox16.Enabled = False
        TCBox17.Enabled = False
        TCBox18.Enabled = False
        TCBox19.Enabled = False
        TCBox20.Enabled = False
        TCBox21.Enabled = False
        TCBox22.Enabled = False
        TCBox23.Enabled = False
        TCBox24.Enabled = False
        TCBox25.Enabled = False
        TCBox26.Enabled = False
        TCBox27.Enabled = False
        TCBox28.Enabled = False
        TCBox29.Enabled = False
        TCBox30.Enabled = False
        TCBox31.Enabled = False
        TCBox32.Enabled = False
    End Sub

    'function for enabling select TCs on ovens D and E
    Public Sub EnableSelectTCsforOvensDandE()
        TC1Box.Enabled = True
        TC2Box.Enabled = True
        TC3Box.Enabled = True
        TC4Box.Enabled = True
        TC5Box.Enabled = False
        TCBox6.Enabled = False
        TCBox7.Enabled = False
        TCBox8.Enabled = False
        TCBox9.Enabled = False
        TCBox10.Enabled = False
        TCBox11.Enabled = False
        TCBox12.Enabled = False
        TCBox13.Enabled = False
        TCBox14.Enabled = False
        TCBox15.Enabled = False
        TCBox16.Enabled = False
        TCBox17.Enabled = False
        TCBox18.Enabled = False
        TCBox19.Enabled = False
        TCBox20.Enabled = False
        TCBox21.Enabled = False
        TCBox22.Enabled = False
        TCBox23.Enabled = False
        TCBox24.Enabled = False
        TCBox25.Enabled = False
        TCBox26.Enabled = False
        TCBox27.Enabled = False
        TCBox28.Enabled = False
        TCBox29.Enabled = False
        TCBox30.Enabled = False
        TCBox31.Enabled = False
        TCBox32.Enabled = False
    End Sub

    'function for checking thermocouple compatibility 
    Public Sub CheckThermocoupleCompatibility()
        If OpenFileDialog1.FileName.Contains("Pump1") OrElse OpenFileDialog1.FileName.Contains("Pump7") OrElse OpenFileDialog1.FileName.Contains("Pump8") OrElse OpenFileDialog1.FileName.Contains("Pump9") OrElse OpenFileDialog1.FileName.Contains("Pump10") OrElse OpenFileDialog1.FileName.Contains("Pump11") OrElse OpenFileDialog1.FileName.Contains("Pump12") OrElse s.Contains("Pump13") OrElse OpenFileDialog1.FileName.Contains("Pump14") Then
            GroupBoxForTCs.Enabled = False
        End If
        If OpenFileDialog1.FileName.Contains("Press") OrElse OpenFileDialog1.FileName.Contains("VARTM") Then
            Call DisableThermocouplesForPressAndVARTM()
        End If
        If OpenFileDialog1.FileName.Contains("OvenA") OrElse OpenFileDialog1.FileName.Contains("OvenF") Then
            Call EnableAllTCsForOvensAandF()
        End If
        If OpenFileDialog1.FileName.Contains("OvenB") Then
            Call EnableSelectTCsforOvenB()
        End If
        If OpenFileDialog1.FileName.Contains("OvenC") OrElse OpenFileDialog1.FileName.Contains("OVENALT") OrElse OpenFileDialog1.FileName.Contains("OvenART") OrElse OpenFileDialog1.FileName.Contains("OvenFLT") OrElse OpenFileDialog1.FileName.Contains("OvenFRT") Then
            Call EnableSelectTCsforOvenCandOvenAandOvenFAlternates()
        End If
        If OpenFileDialog1.FileName.Contains("OvenG") Then
            Call EnableSelectTCsforOvenG()
        End If
        If OpenFileDialog1.FileName.Contains("OvenD") OrElse OpenFileDialog1.FileName.Contains("OvenE") Then
            Call EnableSelectTCsforOvensDandE()
        End If
    End Sub

    'function for disabling buttons until the correct password has been entered
    Public Sub IncorrectPasswordLockout()
        SelectBackupLogBrowseButton.Enabled = False
        GroupBoxForTCs.Enabled = False
        CreateBackupLogButton.Enabled = False
        PartNumberTextBox.Enabled = False
        JobNumberTextBox.Enabled = False
        SerialNumberTextBox.Enabled = False
        MessageBoxTitle = "Caleb's Backup Log Generator 2.0"
        MessageBox.Show("Incorrect PIN number. Please try again. ", MessageBoxTitle)
    End Sub

    'function for enabling buttons if the correct password was entered
    Public Sub CorrectPasswordEntry()
        TextBoxForUserAuthentication.Visible = True
        SelectBackupLogBrowseButton.Enabled = True
        GroupBoxForTCs.Enabled = True
        CreateBackupLogButton.Enabled = True
        PartNumberTextBox.Enabled = True
        JobNumberTextBox.Enabled = True
        SerialNumberTextBox.Enabled = True
        PasswordButton.Enabled = False
    End Sub

End Class