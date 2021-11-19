Public Class frmProducts
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        dgdesignItems()
        txtBarcode.Select()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        Try
            'txtAutoNumber(2, LBLCATEGID)

            If TXTPRONAME.Text = "" Or TXTDESC.Text = "" Or TXTCATEGORY.Text = "Select" Or txtUprice.Text = "" Then
                MsgBox("Empty fields are required inorder to save!", MsgBoxStyle.Exclamation, "Required")

            Else
                query = "Select * From tblCategory where CATEGPROID=" & LBLCATEGID.Text
                result = RETRIEVESIGLE(query)
                If Not result = True Then
                    query = "INSERT INTO tblCategory (CATEGPROID,CATEGORIES) VALUES (" & LBLCATEGID.Text & ",'" & TXTCATEGORY.Text & "')"
                    JANOBECREATE(query)
                End If


                query = "Select * From tblitems where ITEMBARCODE='" & txtBarcode.Text & "'"
                result = RETRIEVESIGLE(query)

                If result = True Then
                    query = "UPDATE tblItems SET ITEMNAME= '" & TXTPRONAME.Text & "',DESCRIPTION='" & TXTDESC.Text &
                    "',OPRICE=" & txtUprice.Text & ", UPRICE =" & price.Text & ",CATEGPROID=" & LBLCATEGID.Text & " WHERE ITEMBARCODE='" & txtBarcode.Text & "'"
                    JANOBEUPDATE(query)
                    MsgBox("Item has been updated in the database!")
                Else
                    query = "INSERT INTO tblItems (ITEMBARCODE,ITEMNAME,DESCRIPTION,OPRICE,UPRICE,ITEMQTY,CATEGPROID) " &
                            " VALUES ( '" & txtBarcode.Text & "','" & TXTPRONAME.Text & "','" & TXTDESC.Text & "'," &
                            txtUprice.Text & "," & price.Text & ", '" & TXTQTY.Text & "'," & LBLCATEGID.Text & ")"
                    JANOBECREATE(query)
                    MsgBox("New Item has been saved in the database!")
                End If




                loadData()
                txtBarcode.Clear()
                updateAutoNumber(2, LBLCATEGID)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtpercent_TextChanged(sender As Object, e As EventArgs) Handles txtUprice.TextChanged
        'Dim subtot As Double
        ' Dim PERCNT As String
        ' Dim tot As Double
        'Try

        'If txtpercent.Text = "" Then
        'price.Text = txtUprice.Text
        'Else
        'PERCNT = txtpercent.Text / 100
        'MsgBox(PERCNT)

        'subtot = txtUprice.Text * PERCNT

        'MsgBox(subtot)

        'tot = txtUprice.Text + subtot
        '
        'price.Text = tot

        'MsgBox(tot)
        ' lblMarkupPrice.Text
        '  End If


        ' Catch ex As Exception

        ' End Try
    End Sub

    Private Sub txtUprice_Click(sender As Object, e As EventArgs) Handles txtUprice.Click
        txtUprice.SelectAll()
        'txtpercent.SelectAll()
    End Sub
    Private Sub loadData()
        ALL_STOCKS(dtgList)
        LBLCATEGID.Text = 0
        If LBLCATEGID.Text = 0 Then
            query = "Select * From tblCategory"
            CBOFILL(query, TXTCATEGORY, "CATEGORIES", "CATEGPROID")
        End If
        clear(Me)
    End Sub



    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs)
        Try
            If Not txtBarcode.Text = "" Then
                query = "Select * From tblitems AS I,tblCategory AS C where I.CATEGPROID=C.CATEGPROID AND ITEMBARCODE='" & txtBarcode.Text & "'"
                result = RETRIEVESIGLE(query)

                If result = True Then
                    With dt.Rows(0)
                        TXTPRONAME.Text = .Item("ITEMNAME")
                        TXTDESC.Text = .Item("DESCRIPTION")
                        txtUprice.Text = .Item("OPRICE")
                        price.Text = .Item("UPRICE")
                        TXTCATEGORY.Text = .Item("CATEGORIES")
                        LBLCATEGID.Text = .Item("C.CATEGPROID")
                        'MsgBox(dt.Rows(0).Item(6))
                    End With
                Else
                    TXTPRONAME.Clear()
                    TXTDESC.Clear()
                    txtUprice.Clear()
                    price.Text = 0.0
                    query = "Select * From tblCategory"
                    CBOFILL(query, TXTCATEGORY, "CATEGORIES", "CATEGPROID")
                    LBLCATEGID.Text = 0
                    btnDelete.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'query = "DELETE * FROM tblPriceUpdate WHERE PROID = " & dtgList.CurrentRow.Cells(1).Value
        'JANOBEDELETE(query)

        query = "DELETE * FROM tblStockIn WHERE ITEMBARCODE = '" & dtgList.CurrentRow.Cells(1).Value & "'"
        JANOBEDELETE(query)

        query = "DELETE * FROM tblsoldout WHERE ITEMBARCODE = '" & dtgList.CurrentRow.Cells(1).Value & "'"
        JANOBEDELETE(query)

        'query = "DELETE * FROM tblReturnedPro WHERE PROID = " & dtgList.CurrentRow.Cells(1).Value
        'JANOBEDELETE(query)

        query = "DELETE * FROM tblitems WHERE ITEMBARCODE = '" & dtgList.CurrentRow.Cells(1).Value & "'"
        JANOBEDELETE(query)

        loadData()
    End Sub

    Private Sub TXTCATEGORY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTCATEGORY.SelectedIndexChanged
        Try

            LBLCATEGID.Text = TXTCATEGORY.SelectedValue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        ALL_STOCKS_SEARCH(dtgList, "AND ITEMNAME LIKE '%" & TXTSEARCH.Text & "%'")
    End Sub

    Private Sub dgdesignItems()

        dtgList.Columns(1).HeaderCell.Value = "Barcode"
        dtgList.Columns(2).HeaderCell.Value = "Item Name"
        dtgList.Columns(3).HeaderCell.Value = "Description"
        dtgList.Columns(4).HeaderCell.Value = "Category"
        dtgList.Columns(5).HeaderCell.Value = "Unit Price"
        dtgList.Columns(6).HeaderCell.Value = "Price"
        dtgList.Columns(7).HeaderCell.Value = "Qty"


        dtgList.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 10)
        dtgList.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 10)
        dtgList.Columns(3).DefaultCellStyle.Font = New Font("tahoma", 10)
        dtgList.Columns(4).DefaultCellStyle.Font = New Font("tahoma", 10)
        dtgList.Columns(5).DefaultCellStyle.Font = New Font("tahoma", 10)
        dtgList.Columns(6).DefaultCellStyle.Font = New Font("tahoma", 10)
        dtgList.Columns(7).DefaultCellStyle.Font = New Font("tahoma", 10)

        dtgList.ColumnHeadersDefaultCellStyle.Font = New Font("tahoma", 12)

        dtgList.Columns(1).Width = 145
        dtgList.Columns(2).Width = 170
        dtgList.Columns(3).Width = 170
        dtgList.Columns(4).Width = 100
        dtgList.Columns(5).Width = 90
        dtgList.Columns(6).Width = 90
        dtgList.Columns(7).Width = 55

        dtgList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtgList.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtgList.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dtgList.Columns(5).ValueType = GetType(Decimal)
        dtgList.Columns(5).DefaultCellStyle.Format = "N2"
        dtgList.Columns(6).ValueType = GetType(Decimal)
        dtgList.Columns(6).DefaultCellStyle.Format = "N2"
    End Sub

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs)
        Try
            'Update products table
            updateQuery = "UPDATE tblItems SET ITEMNAME = '" & TXTPRONAME.Text & "', DESCRIPTION =  '" & TXTDESC.Text & "', ITEMQTY=  '" & TXTQTY.Text & "', OPRICE= '" & txtUprice.Text & "', UPRICE = '" & price.Text & "', CATEGPROID = '" & LBLCATEGID.Text & "' WHERE ITEMBARCODE= '" & txtBarcode.Text & "'"
            result = JANOBEUPDATE(updateQuery)

            If result = False Then
                MsgBox("Update process has encountered a problem. Please Try again!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Product successfully updated!", MsgBoxStyle.Information)
                frmProducts_Load(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtgList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellContentDoubleClick
        frmProductsUpdate.txtBarcode.Text = dtgList.CurrentRow.Cells(1).Value
        frmProductsUpdate.TXTPRONAME.Text = dtgList.CurrentRow.Cells(2).Value
        frmProductsUpdate.TXTDESC.Text = dtgList.CurrentRow.Cells(3).Value
        frmProductsUpdate.TXTCATEGORY.Text = dtgList.CurrentRow.Cells(4).Value
        frmProductsUpdate.txtUprice.Text = dtgList.CurrentRow.Cells(5).Value
        frmProductsUpdate.TXTQTY.Text = dtgList.CurrentRow.Cells(7).Value
        frmProductsUpdate.txtmprice.Text = dtgList.CurrentRow.Cells(6).Value
        frmProductsUpdate.lblcategid.Text = LBLCATEGID.Text
        frmProductsUpdate.ShowDialog()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtBarcode.Enabled = True
        TXTPRONAME.Enabled = True
        TXTDESC.Enabled = True
        TXTCATEGORY.Enabled = True
        TXTQTY.Enabled = True
        txtUprice.Enabled = True
        price.Enabled = True
        BTNSAVE.Enabled = True
        txtBarcode.Select()
    End Sub
End Class