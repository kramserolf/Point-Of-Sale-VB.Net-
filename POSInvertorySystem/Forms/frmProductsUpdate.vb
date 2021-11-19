Public Class frmProductsUpdate
    Private Sub FrmProductsUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            'Update products table
            updateQuery = "UPDATE tblItems SET ITEMNAME = '" & TXTPRONAME.Text & "', DESCRIPTION =  '" & TXTDESC.Text & "', ITEMQTY=  '" & TXTQTY.Text & "', OPRICE= '" & txtUprice.Text & "', UPRICE= '" & txtmprice.Text & "', CATEGPROID = '" & lblcategid.Text & "' WHERE ITEMBARCODE= '" & txtBarcode.Text & "'"
            result = JANOBEUPDATE(updateQuery)

            If result = False Then
                MsgBox("Update process has encountered a problem. Please Try again!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Product successfully updated!", MsgBoxStyle.Information)
                Me.Close()
                ALL_STOCKS(frmProducts.dtgList)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class