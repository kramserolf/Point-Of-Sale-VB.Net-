Imports CrystalDecisions.CrystalReports.Engine
Public Class frmPOS
    Private Sub totsales()

        query = "SELECT SUM( SUBTOTAL)" &
                " FROM tblsoldout AS S,tblUser AS U " &
                " WHERE S.USERID=U.USERID AND DATEVALUE(TRANSDATE)=DATEVALUE(NOW()) AND U.USERID=" & LBLUSERID.Text
        result = RETRIEVESIGLE(query)
        If result = True Then
            lbltotalsales.Text = dt.Rows(0).Item(0)

        End If
    End Sub
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtAutoNumber(3, LBLTRANSID)

            LBLUSERID.Text = UserID

            'lblUname.Text = UserID


            txtAutoComplete("SELECT ITEMBARCODE FROM tblItems", TXTITEMID)
            Timer1.Start()


            ' dtgCart.RowHeadersVisible = False
            TXTITEMID.Clear()
            TXTITEMID.Focus()
            TXTTENDERED.Enabled = False
            totsales()
            dgdesign()
            Timer1.Start()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TXTITEMID_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTITEMID.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            lowStocks()

            Try
                Dim maxrow As Integer
                Dim itemid As String = TXTITEMID.Text
                Dim tot As Double
                query = "SELECT ITEMBARCODE,ITEMNAME,DESCRIPTION,UPRICE,ITEMQTY FROM tblItems WHERE ITEMQTY > 0 AND ITEMBARCODE='" & itemid & "'"

                result = RETRIEVESIGLE(query)

                If result = True Then


                    With dt.Rows(0)
                        Dim row As String() = New String() { .Item(0),
                                                                  .Item(1),
                                                                  .Item(2),
                                                                  .Item(3), 1, .Item(3), .Item(4)}
                        Select Case dtgCart.Rows.Count
                            Case > 0
                                For Each r As DataGridViewRow In dtgCart.Rows
                                    'If r.Cells(4).FormattedValue < 10 Then
                                    'MsgBox("Low stocks alert!", MsgBoxStyle.Exclamation, "Message")

                                    'Beep()
                                    'TXTITEMID.Clear()
                                    'TEMID.Focus()
                                    'Return
                                    'End If
                                Next
                                dtgCart.Rows.Add(row)

                                maxrow = dtgCart.Rows.Count - 1


                                With dtgCart

                                    .Rows(maxrow).Selected = True

                                End With


                                TXTITEMID.Clear()
                                TXTITEMID.Focus()
                            Case 0
                                dtgCart.Rows.Add(row)
                        End Select
                    End With


                    For i = 0 To dtgCart.Rows.Count - 1
                        tot += dtgCart.Rows(i).Cells(5).Value
                    Next

                    LBLSUBTOTAL.Text = Format(tot, "0.00")
                    LBLTOTPRICE.Text = Format(tot, "0.00")
                    'LBLSUBTOT.Text = tot.ToString("#.##")
                    btnaddQty.Enabled = True
                    btnVoid.Enabled = True
                    BTNSAVE.Enabled = False
                    BTNTENDER.Enabled = True
                    BTNESCAPE.Enabled = True
                    TXTITEMID.Clear()
                    TXTITEMID.Focus()
                    dtgCart.RowHeadersVisible = False
                    dtgCart.Refresh()


                Else
                    MsgBox("Item not available!", MsgBoxStyle.Exclamation, "Message")
                End If

            Catch ex As Exception
                MsgBox("Input is incorrect! Try again.", MsgBoxStyle.Exclamation, "Message")
            End Try
        End If
    End Sub

    Private Sub btnaddQty_Click(sender As Object, e As EventArgs) Handles btnaddQty.Click
        Try
            Dim v As Integer
            Dim inpt As Integer
            Dim col3, col4, col5 As Double
            Dim tot As Double

            For Each R As DataGridViewRow In dtgCart.Rows

                v = R.Selected

                If v = -1 Then

                    col3 = R.Cells(3).FormattedValue
                    col4 = R.Cells(4).FormattedValue
                    col5 = R.Cells(5).FormattedValue
                    inpt = InputBox("Item: " & R.Cells(1).FormattedValue, "Add Quantity", R.Cells(4).FormattedValue)

                    query = "SELECT ITEMQTY FROM tblItems WHERE ITEMBARCODE='" & R.Cells(0).FormattedValue & "'"
                    result = RETRIEVESIGLE(query)

                    col4 = inpt

                    Select Case dt.Rows(0).Item(0)
                        Case Is >= col4
                            col5 = col3 * col4
                            R.Cells(4).Value = col4
                            R.Cells(5).Value = col5
                        Case Is < col4
                            MsgBox("Input quantity exceeded! Try again.", MsgBoxStyle.Exclamation, "Input Exceeded")
                            Call btnaddQty_Click(sender, e)
                    End Select
                End If

            Next

            For i = 0 To dtgCart.Rows.Count - 1
                tot += dtgCart.Rows(i).Cells(5).FormattedValue
                'qty += dtgCart.Rows(i).Cells(3).Value
            Next
            LBLSUBTOTAL.Text = Format(tot, "0.00")
            LBLTOTPRICE.Text = Format(tot, "0.00")
            'LBLSUBTOT.Text = tot
            TXTITEMID.Focus()
        Catch ex As Exception
            'MsgBox(ex.Message)
            TXTITEMID.Focus()
        End Try
    End Sub

    Private Sub LBLSUBTOTAL_TextChanged(sender As Object, e As EventArgs) Handles LBLSUBTOTAL.TextChanged
        Try
            'Dim vat As Double
            ' Dim totvat As Double
            Dim tot As Double

            tot = Double.Parse(LBLSUBTOTAL.Text)

            LBLSUBTOT.Text = Format(tot, "0.00")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNTENDER_Click(sender As Object, e As EventArgs) Handles BTNTENDER.Click
        Try
            With TXTTENDERED
                .Enabled = True
                .Focus()
            End With
            BTNSAVE.Enabled = True
            TXTITEMID.Enabled = False
            dtgCart.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTTENDERED_TextChanged(sender As Object, e As EventArgs) Handles TXTTENDERED.TextChanged
        Try
            Dim tot As Double
            If TXTTENDERED.Text = "" Then
                LBLCHANGE.Text = 0.00
            Else
                tot = TXTTENDERED.Text - LBLSUBTOT.Text
                LBLCHANGE.Text = Format(tot, "0.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try

            If TXTTENDERED.Text = "" And LBLCHANGE.Text = 0 Then
                MsgBox("Enter the correct amount!.", MsgBoxStyle.Exclamation, "Message")
            Else
                If LBLCHANGE.Text < 0 Then
                    MsgBox("Enter the correct amount!.", MsgBoxStyle.Exclamation, "Message")
                Else
                    For Each r As DataGridViewRow In dtgCart.Rows
                        'insert soldout
                        query = "INSERT INTO tblsoldout (TRANSNUM,ITEMBARCODE,TRANSDATE,TRANSQTY,SUBTOTAL,USERID) " &
                                " VALUES (" & LBLTRANSID.Text & ",'" & r.Cells(0).FormattedValue & "','" & Now() &
                                "'," & r.Cells(4).FormattedValue & "," & r.Cells(5).FormattedValue & "," & LBLUSERID.Text & ")"
                        JANOBECREATE(query)

                        'insert to receipt
                        query = "INSERT INTO tblReceipt (TRANSDATE,TRANSNUM,ITEMNAME,PRICE,ITEMQTY,SUBTOTAL,TOTAL,TENDEREDAMOUNT,CHANGE,USERID) VALUES ('" & Now() & "'," & LBLTRANSID.Text & ", '" & r.Cells(1).FormattedValue & "','" & r.Cells(3).FormattedValue & "', '" & r.Cells(4).FormattedValue & "', '" & r.Cells(5).FormattedValue & "'," & LBLSUBTOT.Text & "," & TXTTENDERED.Text & "," & LBLCHANGE.Text & ", " & LBLUSERID.Text & ")"
                        JANOBECREATE(query)

                        'update quantity
                        query = "UPDATE tblItems SET ITEMQTY =ITEMQTY - " & r.Cells(4).FormattedValue & " WHERE ITEMBARCODE='" & r.Cells(0).FormattedValue & "'"
                        JANOBEUPDATE(query)

                        'insert into tblReportSummary
                        'query = "INSERT INTO tblReportSummary (TRANSDATE, TRANSNUM, TOTAL, CASHIER) VALUES ('" & Now() & "', " & LBLTRANSID.Text & ", " & LBLSUBTOT.Text & ", " & lblUname.Text & ")"
                        'JANOBECREATE(query)

                    Next

                    'insert to tblsummary
                    query = "INSERT INTO tblsummary (TRANSNUM, TRANSDATE, TOTALPRICE,TENDEREDAMOUNT,CHANGEAMOUNT) " &
                    "VALUES (" & LBLTRANSID.Text & ",'" & Now() & "'," & LBLTOTPRICE.Text & "," & TXTTENDERED.Text & "," & LBLCHANGE.Text & ")"
                    JANOBECREATE(query)



                    Dim sql As String
                    sql = "SELECT * FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM  " &
                    "WHERE C.CATEGPROID=I.CATEGPROID AND I.ITEMBARCODE=SO.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID AND SO.TRANSNUM=" & LBLTRANSID.Text



                    updateAutoNumber(3, LBLTRANSID)
                    txtAutoNumber(3, LBLTRANSID)
                    print()
                    ' frmReceipt.ShowDialog()

                    TXTITEMID.Clear()
                    LBLTOTPRICE.Text = 0.00
                    LBLCHANGE.Text = "0.00"
                    LBLSUBTOT.Text = 0.00
                    LBLSUBTOTAL.Text = 0.00

                    dtgCart.Rows.Clear()
                    TXTITEMID.Enabled = True
                    dtgCart.Enabled = True
                    BTNESCAPE.Enabled = False
                    btnaddQty.Enabled = False
                    btnVoid.Enabled = False
                    BTNTENDER.Enabled = False
                    TXTTENDERED.Enabled = False
                    BTNSAVE.Enabled = False
                    TXTITEMID.Focus()
                End If

            End If
            totsales()
            query = "delete * from tblReceipt"
            TXTTENDERED.Clear()
            JANOBEDELETE(query)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            lblDate.Text = Now.ToString("MMMM d,yyyy")
            lblTime.Text = Now.ToString("h:mm tt")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Try
            dtgCart.Rows.Remove(dtgCart.CurrentRow)
            Dim tot As Double
            For i = 0 To dtgCart.Rows.Count - 1
                tot += dtgCart.Rows(i).Cells(5).Value
                'qty += dtgCart.Rows(i).Cells(3).Value
            Next
            LBLSUBTOTAL.Text = Format(tot, "0.00")
            LBLTOTPRICE.Text = Format(tot, "0.00")
            'LBLSUBTOT.Text = tot


            If LBLTOTPRICE.Text = 0 Then
                btnaddQty.Enabled = False
                btnVoid.Enabled = False
                BTNSAVE.Enabled = False
                BTNTENDER.Enabled = False
                BTNESCAPE.Enabled = False
            End If
            TXTITEMID.Clear()
            TXTITEMID.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNESCAPE_Click(sender As Object, e As EventArgs) Handles BTNESCAPE.Click
        Try
            With TXTTENDERED
                .Enabled = False
                .Clear()
                TXTITEMID.Enabled = True
                TXTITEMID.Focus()
                dtgCart.Enabled = True
                BTNSAVE.Enabled = False

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TToolStripMenuItem.Click
        Call btnaddQty_Click(sender, e)
    End Sub

    Private Sub VoidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoidToolStripMenuItem.Click
        Call btnVoid_Click(sender, e)
    End Sub

    Private Sub TENDEREDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TENDEREDToolStripMenuItem.Click
        Call BTNTENDER_Click(sender, e)
    End Sub

    Private Sub ESCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESCToolStripMenuItem.Click
        Call BTNESCAPE_Click(sender, e)
    End Sub
    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        Call BtnSearch_Click(sender, e)
    End Sub

    Private Sub dgdesign()
        dtgCart.Columns(0).DefaultCellStyle.Font = New Font("tahoma", 12)
        dtgCart.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 12)
        dtgCart.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 12)
        dtgCart.Columns(3).DefaultCellStyle.Font = New Font("tahoma", 12)
        dtgCart.Columns(4).DefaultCellStyle.Font = New Font("tahoma", 12)
        dtgCart.Columns(5).DefaultCellStyle.Font = New Font("tahoma", 12)
        dtgCart.Columns(6).DefaultCellStyle.Font = New Font("tahoma", 12)

        dtgCart.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtgCart.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgCart.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtgCart.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtgCart.ColumnHeadersDefaultCellStyle.Alignment = ContentAlignment.MiddleCenter

    End Sub
    Private Sub TXTTENDERED_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTTENDERED.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTNSAVE.PerformClick()
        End If
    End Sub
    Private Sub print()
        Try
            Dim myReport As New ReportDocument()
            myReport.Load(Application.StartupPath & "\CrystalReport1.rpt")
            'Pass database and Parameter info here
            myReport.PrintOptions.PrinterName = "POS-90"
            myReport.Refresh()
            myReport.PrintToPrinter(1, True, 0, 0) 'This prints one copy of all pages to the default printer, and collates them
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearchProduct.Show()
    End Sub


    Private Sub lowStocks()
        'If dtgCart.CurrentRow.Cells(6).Value < 10 Then
        'MsgBox("Low stocks alert!", MsgBoxStyle.Exclamation, "Alert Message")
        'End If
        query = "SELECT ITEMBARCODE,ITEMNAME,DESCRIPTION,UPRICE,ITEMQTY FROM tblItems WHERE ITEMQTY < 10 AND ITEMBARCODE='" & TXTITEMID.Text & "'"

        result = RETRIEVESIGLE(query)
        If result = True Then
            MsgBox("Low stocks alert!", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
End Class