Module config
    Private OleDbpassword = "JET OLEDB:Database Password = janobe"
    Private Function configdb() As OleDb.OleDbConnection

        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" _
                                     & Application.StartupPath & "\jerneydb.accdb; " & OleDbpassword)
    End Function
    Public con As OleDb.OleDbConnection = configdb()
End Module
