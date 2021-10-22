Public Class frmCategory
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            query = "INSERT INTO tblCategory (CATEGORIES) " &
                           " VALUES ( '" & txtCategory.Text & "')"
            JANOBECREATE(query)
            MsgBox("New Item has been saved in the database!")
            txtCategory.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class