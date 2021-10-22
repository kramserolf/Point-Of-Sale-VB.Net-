Public Class frmListProducts
    Private Sub frmListProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        dgDesign()
        TXTSEARCH.Select()
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        query = "SELECT tblItems.ITEMBARCODE as Barcode, (tblItems.ITEMNAME & ' ' & tblItems.DESCRIPTION ) as Products, tblItems.OPRICE as Price, Last(tblItems.ITEMQTY)+SUM(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.TRANSQTY) AS SOLD, Last(tblItems.ITEMQTY) AS REMAINING
                FROM tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE=tblsoldout.ITEMBARCODE WHERE (tblItems.ITEMNAME & ' ' & tblItems.DESCRIPTION ) LIKE '%" & TXTSEARCH.Text & "%'
                GROUP BY tblItems.ITEMBARCODE, tblItems.ITEMNAME, tblItems.DESCRIPTION, tblItems.OPRICE"
        LoadDTG(query, DTGLIST)
    End Sub

    Private Sub loadData()
        query = "SELECT tblItems.ITEMBARCODE as Barcode, (tblItems.ITEMNAME & ' ' & tblItems.DESCRIPTION ) as Products, tblItems.OPRICE as Price, Last(tblItems.ITEMQTY)+SUM(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.TRANSQTY) AS SOLD, Last(tblItems.ITEMQTY) AS REMAINING
                FROM tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE=tblsoldout.ITEMBARCODE
                GROUP BY tblItems.ITEMBARCODE, tblItems.ITEMNAME, tblItems.DESCRIPTION, tblItems.OPRICE"
        LoadDTG(query, DTGLIST)
    End Sub

    Private Sub dgDesign()
        'column headers title
        DTGLIST.Columns(0).HeaderCell.Value = "Barcode"
        DTGLIST.Columns(1).HeaderCell.Value = "Products"
        DTGLIST.Columns(2).HeaderCell.Value = "Price"
        DTGLIST.Columns(3).HeaderCell.Value = "Quantity"
        DTGLIST.Columns(4).HeaderCell.Value = "Sold"
        DTGLIST.Columns(5).HeaderCell.Value = "Remaining"

        'cell font size
        DTGLIST.Columns(0).DefaultCellStyle.Font = New Font("tahoma", 10)
        DTGLIST.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 10)
        DTGLIST.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 10)
        DTGLIST.Columns(3).DefaultCellStyle.Font = New Font("tahoma", 10)
        DTGLIST.Columns(4).DefaultCellStyle.Font = New Font("tahoma", 10)
        DTGLIST.Columns(5).DefaultCellStyle.Font = New Font("tahoma", 10)


        'column header font size
        DTGLIST.ColumnHeadersDefaultCellStyle.Font = New Font("tahoma", 12, FontStyle.Bold)

        'column header width
        DTGLIST.Columns(0).Width = 180
        DTGLIST.Columns(1).Width = 284
        DTGLIST.Columns(2).Width = 110
        DTGLIST.Columns(3).Width = 93
        DTGLIST.Columns(4).Width = 93
        DTGLIST.Columns(5).Width = 93

        'cell alignment
        DTGLIST.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DTGLIST.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DTGLIST.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DTGLIST.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DTGLIST.ColumnHeadersDefaultCellStyle.Alignment = ContentAlignment.MiddleCenter


        'cell formatting
        DTGLIST.Columns(2).ValueType = GetType(Decimal)
        DTGLIST.Columns(2).DefaultCellStyle.Format = "N2"
    End Sub
End Class