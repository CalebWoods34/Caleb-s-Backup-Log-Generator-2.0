'imports block
Imports System.IO
Imports ClosedXML.Excel
Imports Microsoft.VisualBasic.FileIO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    'declaration block
    Dim UserEnteredPassword As String, CalebPin As String, KevinPin As String, VinhPin As String, MikePin As String
    Dim strtext As String
    Public CureDeviceName As String, PartNumberTextBoxUserEntry As String, JobNumberTextBoxUserEntry As String, SerialNumberTextBoxUserEntry As String
    Dim MessageBoxTitle As String
    Public filepath As String, filepath2 As String
    Public intcount As Integer
    Public textin As StreamReader, template As StreamReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'search for CSV file and set filename equal to the file name and path
        OpenFileDialog1.Title = "Select the backup data log (.csv): " 'This titles the search box 
        OpenFileDialog1.Filter = "Comma Seperated Value File (*.csv)|*.csv"
        OpenFileDialog1.InitialDirectory = "S:\AutoCure\BackupLogs\logs" 'This directs the openfiledialog box to search this directory
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        BackupLogTextBox.Text = filepath
        'calls cleardatagridviews to clear datagridviewforcsv, datagridviewforselectedrange, and text boxes each time a new csv is looked for
        Call ClearDataGridViews()
        'reads CSV into datagridview
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
        Dim s As String = filepath
        s = s.Substring(s.IndexOf("s\") + 7)
        s = s.Substring(0, s.IndexOf(".") - 9)
        CureDeviceNameTextBox.Text = s
        If filepath.Contains("Alarms") OrElse filepath.Contains("batch") OrElse filepath.Contains("comms") OrElse filepath.Contains("Maint") OrElse filepath.Contains("mnt_P14") OrElse filepath.Contains("NAA") OrElse filepath.Contains("PressALM") OrElse filepath.Contains("PumpTest") OrElse filepath.Contains("UtltyRm") OrElse filepath.Contains("VARTMAlm") Then
            MessageBox.Show("This folder is not supported by the backup log generator. Contact Caleb if this error persists.", MessageBoxTitle)
            Call ClearFilepathAndBackupLogTextBox()
            Call ClearDataGridViews()
        End If
    End Sub
    Private Sub CreateBackupLogButton_click(sender As Object, e As EventArgs) Handles CreateBackupLogButton.Click
        'clear rows and columns for each CSV loaded
        DataGridViewForSelectedRange.Columns.Clear()
        DataGridViewForSelectedRange.Rows.Clear()
        'copy columns
        Try
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
            'create excel file for datagridviewforselectedrange
            DataGridViewForSelectedRange.SelectAll()
            Dim DataGridViewForSelectedRangeExportToExcel As Object = DataGridViewForSelectedRange.GetClipboardContent()
            If DataGridViewForSelectedRangeExportToExcel IsNot Nothing Then
                Clipboard.SetDataObject(DataGridViewForSelectedRangeExportToExcel)
            End If
            Dim xlexcel As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlexcel = New Excel.Application()
            xlexcel.Visible = True
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)
            Dim CR As Excel.Range = CType(xlWorkSheet.Cells(1, 1), Excel.Range)
            CR.[Select]()
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
            'Copy from excel file to template
            Dim template As String
            Dim xlworkbookfortemplate As Microsoft.Office.Interop.Excel.Application
            Dim xltemplateapp As Microsoft.Office.Interop.Excel.Workbook
            Dim xlworksheetfortemplate As Microsoft.Office.Interop.Excel.Worksheet
            If filepath.Contains("oven") OrElse filepath.Contains("Oven") Then
                OpenFileDialog2.InitialDirectory = "Z:\AutoCure\Calebs Backup Log Generator 2.0\Templates\Oven Template"
                OpenFileDialog2.FileName = "Z:\AutoCure\Caleb's Backup Log Generator 2.0\Templates\Oven Template\FDI Log Template - Oven.xlsx"
            ElseIf filepath.Contains("press") OrElse filepath.Contains("Press") Then
                OpenFileDialog2.InitialDirectory = "Z:\AutoCure\Calebs Backup Log Generator 2.0\Templates\Press Template"
                OpenFileDialog2.FileName = "Z:\AutoCure\Caleb's Backup Log Generator 2.0\Templates\Press Template\FDI Log Template - Press.xlsx"
            ElseIf filepath.Contains("vartm") OrElse filepath.Contains("VARTM") Then
                OpenFileDialog2.InitialDirectory = "Z:\AutoCure\Calebs Backup Log Generator 2.0\Templates\Press Template"
                OpenFileDialog2.FileName = "Z:\AutoCure\Caleb's Backup Log Generator 2.0\Templates\Press Template\FDI Log Template - Press.xlsx"
            ElseIf filepath.Contains("pump1") OrElse filepath.Contains("Pump1") OrElse filepath.Contains("pump7") OrElse filepath.Contains("Pump7") OrElse filepath.Contains("pump8") OrElse filepath.Contains("Pump8") OrElse filepath.Contains("pump9") OrElse filepath.Contains("Pump9") Then
                OpenFileDialog2.InitialDirectory = "Z:\AutoCure\Calebs Backup Log Generator 2.0\Templates\IVEC Template"
                OpenFileDialog2.FileName = "Z:\AutoCure\Caleb's Backup Log Generator 2.0\Templates\IVEC Pump Template\FDI Log Template - IVEC Pump.xlsx"
            ElseIf filepath.Contains("pump10") OrElse filepath.Contains("Pump10") OrElse filepath.Contains("pump12") OrElse filepath.Contains("Pump12") OrElse filepath.Contains("pump13") OrElse filepath.Contains("Pump13") OrElse filepath.Contains("pump14") OrElse filepath.Contains("Pump14") Then
                OpenFileDialog2.InitialDirectory = "Z:\AutoCure\Calebs Backup Log Generator 2.0\Templates\Mahr Template"
                OpenFileDialog2.FileName = "Z:\AutoCure\Caleb's Backup Log Generator 2.0\Templates\Mahr Pump Template\FDI Log Template - Mahr Pump.xlsx"
            Else
                OpenFileDialog2.FileName = Nothing
            End If
        Catch
            Dim messageboxtitle As String
            messageboxtitle = "Caleb's Backup Log Generator 2.0"
            MessageBox.Show("ERROR - The selected rows were blank or there was an issue with the backup log generation. Contact Caleb for further assistance. ", messageboxtitle)
        End Try
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
End Class
