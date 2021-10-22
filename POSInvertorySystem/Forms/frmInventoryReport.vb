Public Class frmInventoryReport
    Private Sub FrmInventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgInventory()
        dgDesign()
        txtSearch.Select()
    End Sub

    Private Sub dtgInventory()
        query = "SELECT tblItems.ITEMNAME, tblItems.DESCRIPTION, Last(tblItems.ITEMQTY) + SUM(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.TRANSQTY) AS SOLD, Last(tblItems.ITEMQTY) AS REMAINING" &
       " FROM tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE = tblsoldout.ITEMBARCODE" &
       " GROUP BY tblItems.ITEMNAME, tblItems.DESCRIPTION"
        LoadDTG(query, dgReport)
    End Sub

    Private Sub dgDesign()
        'column headers title
        dgReport.Columns(0).HeaderCell.Value = "Item Name"
        dgReport.Columns(1).HeaderCell.Value = "Description"
        dgReport.Columns(2).HeaderCell.Value = "Quantity"
        dgReport.Columns(3).HeaderCell.Value = "Sold"
        dgReport.Columns(4).HeaderCell.Value = "Remaining"

        'cell font size
        dgReport.Columns(0).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(3).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(4).DefaultCellStyle.Font = New Font("tahoma", 10)


        'column header font size
        dgReport.ColumnHeadersDefaultCellStyle.Font = New Font("tahoma", 11, FontStyle.Bold)

        'column header width
        dgReport.Columns(0).Width = 215
        dgReport.Columns(1).Width = 215
        dgReport.Columns(2).Width = 120
        dgReport.Columns(3).Width = 120
        dgReport.Columns(4).Width = 120

        'cell alignment
        dgReport.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgReport.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgReport.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgReport.ColumnHeadersDefaultCellStyle.Alignment = ContentAlignment.MiddleCenter
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dtgInventory()
        txtSearch.Clear()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub search()
        query = "SELECT tblItems.ITEMNAME, tblItems.DESCRIPTION, Last(tblItems.ITEMQTY) + SUM(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.TRANSQTY) AS SOLD, Last(tblItems.ITEMQTY) AS REMAINING" &
" FROM tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE = tblsoldout.ITEMBARCODE WHERE tblitems.ITEMQTY < " & Val(txtSearch.Text) & "" &
" GROUP BY tblItems.ITEMNAME, tblItems.DESCRIPTION"
        LoadDTG(query, dgReport)
    End Sub

    Private Sub insertLogs()
        query = "INSERT INTO tblLogsInventory(ITEMNAME, ITEMDESCRIPTION, ITEMQTY, SOLD, REMAINING) VALUES ()"
    End Sub
End Class