Public Class frmTransEdit
    Private Sub frmTransEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLMSG.Text = ""
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click


        'CHECKING IF HAS AN INPUT QUANTITY
        If TXTQTY.Text <> "" And Val(LBLPRICE.Text) > 0 Then

            Select Case Me.Text
                Case "STOCK-IN"
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'STOCK IN TABLE
                    'THIS RETRIEVE QUERY IS USED TO CHECK IF THE TRANSACTION NUMBER HAS ALREADY EXIST,
                    ' IF EXIST, UPDATE THE TRANSACTION TABLE AND ADD A QUANTITY TO THE STOCKS
                    checkQuery = "SELECT TRANSQTY FROM tblStockIn WHERE TRANSNUM=" & TXTTRANSNUM.Text
                    RETRIEVESIGLE(checkQuery)

                    If dt.Rows.Count > 0 Then 'THIS PROCESS IS TO UPDATE THE STOCKIN TABLE
                        'RESULT:

                        'FIRST, YOU HAVE TO DECREASE THE QUANTITY OF THE STOCKS SO THAT IT WILL RETURN TO ITS ORIGINAL QUANTITY 
                        updateQuery = "UPDATE tblItems SET ITEMQTY = ITEMQTY -" & dt.Rows(0).Item(0) & " WHERE  ITEMBARCODE ='" & LBLITEMID.Text & "'"
                        JANOBEUPDATE(updateQuery)

                        'SECOND, YOU HAVE TO ADD THE QUANTITY OF THE STOCKS 
                        updateQuery = "UPDATE tblItems SET ITEMQTY = ITEMQTY + " & TXTQTY.Text & " WHERE  ITEMBARCODE ='" & LBLITEMID.Text & "'"
                        JANOBEUPDATE(updateQuery)


                        updateQuery = "UPDATE tblStockIn  SET TRANSQTY =" & TXTQTY.Text & ", TOTPRICE=" & LBLPRICE.Text & ",TRANSDATE='" & DTPTRANSTDATE.Value & "' WHERE  TRANSNUM =" & TXTTRANSNUM.Text
                        JANOBEUPDATE(updateQuery)

                        With LBLMSG
                            .Text = ""
                            .BackColor = Color.Transparent
                            .Text = "Transaction has been updated."
                            .BackColor = Color.Cyan
                            .ForeColor = Color.Black
                        End With


                    End If
            End Select



        Else
            'ERROR MSG
            With LBLMSG
                .Text = "Put the correct quantity in order to saved."
                .BackColor = Color.Red
                .ForeColor = Color.White
            End With
        End If

    End Sub

    Private Sub TXTQTY_TextChanged(sender As Object, e As EventArgs) Handles TXTQTY.TextChanged
        Try
            If TXTQTY.Text = "" Then
                LBLPRICE.Text = 0

            Else

                LBLPRICE.Text = Double.Parse(LBLUNITPRICE.Text) * TXTQTY.Text
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmTransEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        List_of_Stocks(frmStockin.DTGLIST)
    End Sub
End Class