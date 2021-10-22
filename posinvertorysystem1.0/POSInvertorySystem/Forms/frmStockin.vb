Public Class frmStockin
    Private Sub frmStockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear(GroupBox1)
        TXTPRICE.Text = 0.0
        TXTQTY.Text = 0
        TXTTOT.Text = 0.0

        List_of_Stocks(DTGLIST)

        txtAutoNumber(1, LBLTRANSNUM)

        Autocomplete_ItemName(TXTITEM)

        txtAutoComplete("Select ITEMBARCODE From tblItems", txtitemid)

        LBLMSG.Text = ""

        toolstrpAccountId.Text = UserID

    End Sub

    Private Sub txtitemid_TextChanged(sender As Object, e As EventArgs) Handles txtitemid.TextChanged
        Try

            If txtitemid.Text = "" Then
                TXTDESC.Clear()
                TXTITEM.Clear()
                TXTCATEGORY.Clear()

                TXTPRICE.Text = 0.0
                TXTQTY.Text = 0
                TXTTOT.Text = 0.0
            Else
                query = "SELECT  ITEMNAME,CATEGORIES ,DESCRIPTION,UPRICE FROM tblItems AS i, tblCategory AS c WHERE i.CATEGPROID=c.CATEGPROID AND ITEMBARCODE  = '" & txtitemid.Text & "'"
                result = RETRIEVESIGLE(query)

                If result = True Then
                    If dt.Rows.Count > 0 Then
                        With dt.Rows(0)
                            TXTITEM.Text = .Item(0)
                            TXTCATEGORY.Text = .Item(1)
                            TXTDESC.Text = .Item(2)
                            TXTPRICE.Text = .Item(3)
                        End With
                    Else
                        TXTDESC.Clear()
                        TXTITEM.Clear()
                        TXTCATEGORY.Clear()

                        TXTPRICE.Text = 0.0
                        TXTQTY.Text = 0
                        TXTTOT.Text = 0.0
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtitemid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtitemid.KeyDown

        If e.KeyCode = Keys.Enter Then
            TXTQTY.Focus()
        End If
    End Sub

    Private Sub TXTQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTQTY.KeyPress
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                ElseIf TXTQTY.Text.Contains(".") Then
                    MessageBox.Show("Only one decimal point allowed")
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub TXTQTY_TextChanged(sender As Object, e As EventArgs) Handles TXTQTY.TextChanged
        Try
            If TXTQTY.Text = "" Then
                TXTTOT.Text = 0
            Else
                TXTTOT.Text = Double.Parse(TXTPRICE.Text) * Double.Parse(TXTQTY.Text)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click


        Try
            If TXTDESC.Text <> "" And TXTQTY.Text <> "" Then

                'ADDING THE QTY OF THE STOCK
                updateQuery = "UPDATE tblItems SET ITEMQTY= ITEMQTY + " & TXTQTY.Text & " WHERE ITEMBARCODE='" & txtitemid.Text & "'"
                result = JANOBEUPDATE(updateQuery)

                If result = False Then
                    MsgBox("The query in tblItems cannot be execute. Please contact administrator!", MsgBoxStyle.Exclamation)
                End If

                'STOCK IN PROCESS

                query = "INSERT INTO tblStockIn (TRANSNUM,ITEMBARCODE,TRANSDATE,TRANSQTY,TOTPRICE,USERID) VALUES (" & LBLTRANSNUM.Text & ",'" & txtitemid.Text & "','" & DTPTRANSDATE.Value & "'," & TXTQTY.Text & "," & TXTTOT.Text & "," & toolstrpAccountId.Text & ")"
                result = JANOBECREATE(query)

                If result = False Then
                    MsgBox("The query in tblStockIn cannot be execute. Please contact administrator!", MsgBoxStyle.Exclamation)
                End If


                'END
                'SUCCESS MSH
                LBLMSG.Text = "The " & TXTITEM.Text & " has been added into the inventory."
                LBLMSG.BackColor = Color.Aquamarine
                LBLMSG.ForeColor = Color.Black

                'update autonumber
                updateAutoNumber(1, LBLTRANSNUM)
                txtAutoNumber(1, LBLTRANSNUM)
            Else
                LBLMSG.Text = "Fill up the correct product in the empty fields inorder to save."
                LBLMSG.BackColor = Color.Red
                LBLMSG.ForeColor = Color.White
                Beep()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        TXTDESC.Clear()
        TXTITEM.Clear()
        txtitemid.Clear()
        TXTCATEGORY.Clear()

        TXTPRICE.Text = 0.0
        TXTQTY.Text = 0
        TXTTOT.Text = 0.0
        'CBOUNIT.Text = ""
        LBLMSG.Text = ""
        LBLMSG.BackColor = Color.Transparent
        ' autonum
        txtAutoNumber(1, LBLTRANSNUM)

        List_of_Stocks(DTGLIST)


    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Me.Close()
    End Sub

    Private Sub DTPTO_ValueChanged(sender As Object, e As EventArgs) Handles DTPTO.ValueChanged, DTPFROM.ValueChanged
        Dim dfrom As Date = DTPFROM.Text
        Dim dto As Date = DTPTO.Text
        Dim condition As String

        condition = "DATEVALUE(TRANSDATE) BETWEEN #" & dfrom & "# AND #" & dto & "# AND (TRANSNUM  & ' '  & ITEMNAME & ' '   & CATEGORIES  & ' '  & UPRICE & ' '  & TRANSQTY &  ' '  &  TOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
        Search_Stocks(condition, DTGLIST)
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = "" Then
            'query = "SELECT I.ITEMID, TRANSNUM AS [Transaction#], ITEMNAME AS [Item],UNITPRICE AS [UnitPrice] ,TRANSDATE AS [TransactionDate],TRANSQTY  AS [Quantity], TOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblItems AS I, tblCategory AS C WHERE S.ITEMID=I.ITEMID AND I.CATEGPROID=C.CATEGPROID  AND " & _
            '         " (TRANSNUM  & ' '  & ITEMNAME & ' '   & CATEGORIES  & ' '  & UNITPRICE & ' '  & TRANSQTY &  ' '  &  TOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
            'RETRIEVEDATA(query, DTGLIST)

            List_of_Stocks(DTGLIST)

        Else
            Dim dfrom As Date = DTPFROM.Text
            Dim dto As Date = DTPTO.Text

            Dim condition As String

            condition = "DATEVALUE(TRANSDATE) BETWEEN #" & dfrom & "# AND #" & dto & "# AND (TRANSNUM  & ' '  & ITEMNAME & ' '   & CATEGORIES  & ' '  & UPRICE & ' '  & TRANSQTY &  ' '  &  TOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
            Search_Stocks(condition, DTGLIST)

            'query = "SELECT I.ITEMID, TRANSNUM AS [Transaction#], ITEMNAME AS [Item],UNITPRICE AS [UnitPrice] ,TRANSDATE AS [TransactionDate],TRANSQTY  AS [Quantity], TOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblItems AS I, tblCategory AS C WHERE S.ITEMID=I.ITEMID AND I.CATEGPROID=C.CATEGPROID  AND " & _
            '        "  DATEVALUE(TRANSDATE) BETWEEN #" & dfrom & "# AND #" & dto & "# AND (TRANSNUM  & ' '  & ITEMNAME & ' '   & CATEGORIES  & ' '  & UNITPRICE & ' '  & TRANSQTY &  ' '  &  TOTPRICE) LIKE '%" & TXTSEARCH.Text & "%'"
            'RETRIEVEDATA(query, DTGLIST)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            'EDIT A SPECIFIC TRANSACTION
            query = "SELECT I.ITEMBARCODE,TRANSNUM,ITEMNAME,UPRICE,TRANSDATE,TRANSQTY,TOTPRICE,CATEGORIES,DESCRIPTION " &
            " FROM tblStockIn as S, tblItems AS I, tblCategory AS C " &
            " WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID AND TRANSNUM = " & DTGLIST.CurrentRow.Cells(2).Value
            result = RETRIEVESIGLE(query)


            'MsgBox(DTGLIST.CurrentRow.Cells(1).Value)

            'CHECKING IF THE DATA IS EXIST
            If dt.Rows.Count > 0 Then
                'RESULT:
                'PASSING THE DATA TO ITS CURRESPONDING FIELDS
                With FRMTRANSEDIT
                    .StartPosition = FormStartPosition.CenterScreen
                    .Show()
                    .Focus()
                    .MaximizeBox = False


                    .LBLITEMID.Text = dt.Rows(0).Item(0)
                    .TXTTRANSNUM.Text = dt.Rows(0).Item(1)
                    .TXTITEM.Text = dt.Rows(0).Item(2)
                    .LBLUNITPRICE.Text = dt.Rows(0).Item(3)
                    .DTPTRANSTDATE.Text = dt.Rows(0).Item(4)
                    .TXTQTY.Text = dt.Rows(0).Item(5)
                    .LBLPRICE.Text = dt.Rows(0).Item(6)
                    .TXTCATEGORY.Text = dt.Rows(0).Item(7)
                    .TXTDESC.Text = dt.Rows(0).Item(8)
                    .Text = "STOCK-IN"
                End With


            Else
                'REFRESHING AND CLEARING
                clear(GroupBox1)
                clear(GroupBox3)
                TXTCATEGORY.Text = "Select"
                txtAutoNumber(1, LBLTRANSNUM)

            End If
        Catch ex As Exception
            MsgBox("Please select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try

    End Sub
End Class