Imports System.IO
Imports System.Text
Public Class ImportItems

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Dim filepath As String = TextBox1.Text
        Dim textreader As New StreamReader(filepath, Encoding.Default)
        Dim sline As String = ""
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = OpenFileDialog1.FileName
        Else
            TextBox1.Clear()
        End If
    End Sub
End Class