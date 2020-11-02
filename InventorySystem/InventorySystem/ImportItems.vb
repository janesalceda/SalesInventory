Imports System.IO
Imports System.Text
Imports ExcelDataReader
Public Class ImportItems
    Dim tables As DataTableCollection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Dim filepath As String = TextBox1.Text
        Dim fi As New IO.FileInfo(filepath)
        Dim extn As String = fi.Extension

        If extn = ".csv" Then
            Dim textreader As New StreamReader(filepath, Encoding.Default)
            Dim sline As String

            DataGridView1.Rows.Clear()
            Do
                sline = textreader.ReadLine
                If sline Is Nothing Then Exit Do
                Dim words() As String = sline.Split(",")
                DataGridView1.Rows.Add("")
                For ix As Integer = 0 To words.Length - 1
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(ix).Value = words(ix)
                Next
            Loop
            textreader.Close()
        Else
            Using stream = File.Open(TextBox1.Text, FileMode.Open, FileAccess.Read)
                Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                    Dim result As DataSet = reader.AsDataSet(
                        New ExcelDataSetConfiguration() With {
                        .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                        .UseHeaderRow = True}})
                    tables = result.Tables
                    cboSheet.Items.Clear()
                    For Each table As DataTable In tables
                        cboSheet.Items.Add(table.TableName)
                    Next
                End Using
            End Using
        End If
    End Sub


    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        ' DataGridView1.DataSource = dt
        If dt IsNot Nothing Then
            Dim list As List(Of Items) = New List(Of Items)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim item As Items = New Items
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = OpenFileDialog1.FileName
        Else
            TextBox1.Clear()
        End If
    End Sub
End Class