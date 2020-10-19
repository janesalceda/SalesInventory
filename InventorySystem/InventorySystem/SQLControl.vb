Imports System.Data.SqlClient
Public Class SQLControl
    Private DBcon As New SqlConnection("Server=LEMONADE\SQLEXPRESS;Database=SalesAndInventory;Trusted_Connection=True")
    'Private DBcon As New SqlConnection("Server=SD_SQL_TRAINING;Database=janeExplore;User Id=sa;Password=81at84;")
    'Private DBcon As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
    Private DBcmd As SqlCommand

    'DB DATA
    Public DBDa As SqlDataAdapter
    Public DBDT As DataTable

    'QUERY PARAMETERS
    Public params As New List(Of SqlParameter)

    'QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    'ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBcon = New SqlConnection(ConnectionString)
    End Sub
    'EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        Exception = ""

        Try
            DBcon.Open()
            'CREATE DB COMMAND
            DBcmd = New SqlCommand(Query, DBcon)

            'Load PArams into dbcmd
            params.ForEach(Sub(p) DBcmd.Parameters.Add(p))

            'CLEAR PARAM LIST
            params.Clear()
            'EXECUTE THE COMMAND AND FILL OUR DATASET
            DBDT = New DataTable
            DBDa = New SqlDataAdapter(DBcmd)
            RecordCount = DBDa.Fill(DBDT)
        Catch ex As Exception
            'CAPTURE ERROR
            Exception = "ExecuteQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBcon.State = ConnectionState.Open Then DBcon.Close()
        End Try
    End Sub
    Public Sub AddParams(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        params.Add(NewParam)
    End Sub
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
End Class
