Public Class frmManageUsers
    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call btnnew_Click(sender, e)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtname.Text <> "" And txtusername.Text <> "" And txtpass.Text <> "" And cbotype.Text <> "" Then
            If LBLUSERID.Text = "USERID" Then

                query = "INSERT INTO tblUser ( U_NAME,U_UNAME,U_PASS,U_TYPE) VALUES ('" & txtname.Text & "','" & txtusername.Text _
                & "','" & txtpass.Text & "','" & cbotype.Text & "')"

                result = JANOBECREATE(query)

                If result = True Then
                    MsgBox("New record has been successfully saved in the database!")
                Else
                    MsgBox("Proccess cannot be execute. Please contact administrator!", MsgBoxStyle.Exclamation)
                End If
            Else

                query = "UPDATE tblUser SET U_NAME='" & txtname.Text & "',U_UNAME='" & txtusername.Text _
                & "',U_PASS='" & txtpass.Text & "',U_TYPE='" & cbotype.Text & "' WHERE USERID=" & LBLUSERID.Text
                result = JANOBEUPDATE(query)

                If result = True Then
                    MsgBox("The record has been updated in the database!")
                Else
                    MsgBox("Proccess cannot be execute. Please contact administrator!", MsgBoxStyle.Exclamation)
                End If
            End If

            Call btnnew_Click(sender, e)

            query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username], U_TYPE AS [Role] FROM tblUser"
            RETRIEVEDATA(query, dtglist)
        Else
            MsgBox("Fields are required!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        clear(Panel2)
        cbotype.Text = ""
        LBLUSERID.Text = "USERID"

        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username], U_TYPE AS [Role] FROM tblUser"
        RETRIEVEDATA(query, dtglist)

        btndelete.Enabled = False
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        query = "DELETE * FROM tblUser WHERE USERID = " & dtglist.CurrentRow.Cells(0).Value
        result = JANOBEDELETE(query)

        If result < 0 Then
            MsgBox("New record has been deleted in the database!")
        Else
            MsgBox("Proccess cannot be execute. Please contact administrator!", MsgBoxStyle.Exclamation)
        End If
        Call btnnew_Click(sender, e)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username] ,U_TYPE AS [Role] FROM tblUser WHERE (USERID & ' ' & U_NAME  & ' ' &  U_UNAME  & ' ' &  U_TYPE) LIKE '%" & txtsearch.Text & "%'"
        RETRIEVEDATA(query, dtglist)
    End Sub

    Private Sub dtglist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellClick
        Try
            LBLUSERID.Text = dtglist.CurrentRow.Cells(0).Value
            query = "SELECT * FROM tblUser WHERE USERID=" & dtglist.CurrentRow.Cells(0).Value
            RETRIEVESIGLE(query)
            With dt.Rows(0)
                If dt.Rows.Count > 0 Then
                    txtname.Text = .Item(1)
                    txtusername.Text = .Item(2)
                    txtpass.Text = .Item(3)
                    cbotype.Text = .Item(4)
                End If
            End With
            btndelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class