'imports block
Imports System.IO
Imports ClosedXML.Excel
Imports Microsoft.VisualBasic.FileIO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    'declaration block
    Public IntStartDataPoint As Int32, IntEndDataPoint As Int32
    Dim UserEnteredPassword As String, CalebPin As String, KevinPin As String, VinhPin As String, MikePin As String
    Dim strtext As String
    Dim xlApp As New Excel.Application, xlWorkBook As Excel.Workbook, xlWorkSheet As Object, xlformattedapp As New Excel.Application, xlformattedworksheet As Excel.Workbook
    Public CureDeviceNameTextBoxUserEntry As String, PartNumberTextBoxUserEntry As String, JobNumberTextBoxUserEntry As String, SerialNumberTextBoxUserEntry As String
    Dim MessageBoxTitle As String
    Public filepath As String, filepath2 As String
    Public intcount As Integer
    Public textin As StreamReader, template As StreamReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub CureDeviceNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CureDeviceNameTextBox.TextChanged
        CureDeviceNameTextBoxUserEntry = CureDeviceNameTextBox.Text
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
        'search for CSV file
        OpenFileDialog1.Title = "Select the backup data log (.csv): " 'This titles the search box 
        OpenFileDialog1.Filter = "Comma Seperated Value File (*.csv)|*.csv"
        OpenFileDialog1.InitialDirectory = "S:\AutoCure\BackupLogs\logs" 'This directs the openfiledialog box to search this directory
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        BackupLogTextBox.Text = filepath
        'clear datagridviewforcsv, datagridviewforselectedrange, and text boxes each time a new csv is looked for
        DataGridViewForCSV.Columns.Clear()
        DataGridViewForCSV.Rows.Clear()
        LogEndTextBox.Text = Nothing
        LogStartTextBox.Text = Nothing
        DataGridViewForSelectedRange.Columns.Clear()
        DataGridViewForSelectedRange.Rows.Clear()
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

    End Sub
    Private Sub CreateBackupLogButton_click(sender As Object, e As EventArgs) Handles CreateBackupLogButton.Click
        'clear rows and columns for each CSV loaded
        DataGridViewForSelectedRange.Columns.Clear()
        DataGridViewForSelectedRange.Rows.Clear()
        'copy columns
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
        'create excel file for backup log
    End Sub
End Class
