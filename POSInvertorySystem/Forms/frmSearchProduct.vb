Public Class frmSearchProduct
    Private Sub FrmSearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT ITEMBARCODE, ITEMNAME, DESCRIPTION, UPRICE FROM tblitems WHERE ITEMQTY > 0"
        LoadDTG(query, dgReport)
        txtSearch.Select()
        dgdesign()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        query = "SELECT ITEMBARCODE, ITEMNAME, DESCRIPTION, UPRICE FROM tblitems WHERE ITEMQTY > 0 AND ITEMNAME LIKE '%" & txtSearch.Text & "%'"
        LoadDTG(query, dgReport)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtSearch.Clear()
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            frmPOS.TXTITEMID.Text = dgReport.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub DgReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReport.CellContentClick


    End Sub

    Private Sub dgReport_KeyDown(sender As Object, e As KeyEventArgs) Handles dgReport.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmPOS.TXTITEMID.Text = dgReport.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub dgdesign()

        dgReport.Columns(0).HeaderCell.Value = "Barcode"
        dgReport.Columns(1).HeaderCell.Value = "Item Name"
        dgReport.Columns(2).HeaderCell.Value = "Description"
        dgReport.Columns(3).HeaderCell.Value = "Unit Price"


        dgReport.Columns(0).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(3).DefaultCellStyle.Font = New Font("tahoma", 10)


        dgReport.ColumnHeadersDefaultCellStyle.Font = New Font("tahoma", 12)
        dgReport.ColumnHeadersDefaultCellStyle.Alignment = ContentAlignment.MiddleCenter

        dgReport.Columns(0).Width = 170
        dgReport.Columns(1).Width = 200
        dgReport.Columns(2).Width = 220
        dgReport.Columns(3).Width = 120


        dgReport.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dgReport.Columns(3).ValueType = GetType(Decimal)
        dgReport.Columns(3).DefaultCellStyle.Format = "N2"
    End Sub
End Class