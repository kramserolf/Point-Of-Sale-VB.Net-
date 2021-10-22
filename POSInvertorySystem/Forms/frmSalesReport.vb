Public Class frmSalesReport
    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgSales()
        dgDesign()
        txtSearch.Select()

    End Sub

    Private Sub dtgSales()
        'query = "SELECT tblItems.ITEMBARCODE , [ITEMNAME] & ' ' & [DESCRIPTION] AS Products, Sum(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.SUBTOTAL) AS TotalAmount, tblsoldout.TRANSNUM
        'From tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE = tblsoldout.ITEMBARCODE WHERE FORMAT(TRANSDATE,'mm/dd/yyyy') = FORMAT(Now(),'mm/dd/yyyy') 
        'GROUP BY tblItems.ITEMBARCODE, [ITEMNAME] & ' ' & [DESCRIPTION], tblsoldout.TRANSN"
        'query = "SELECT DISTINCT tblsoldout.TRANSDATE, tblsoldout.TRANSNUM, tblsummary.TOTALPRICE FROM tblsoldout LEFT JOIN tblsummary ON tblsoldout.TRANSNUM=tblsummary.TRANSNUM GROUP BY tblsoldout.TRANSNUM, tblsoldout.TRANSDATE, tblsummary.TOTALPRICE"
        query = "SELECT TRANSDATE, TRANSNUM, TOTALPRICE FROM tblsummary GROUP BY TRANSDATE, TRANSNUM, TOTALPRICE"
        LoadDTG(query, dgReport)
        'dgReport.Rows.RemoveAt(dgReport.Rows.Count - 1)
    End Sub

    Private Sub dgDesign()
        'column headers title
        dgReport.Columns(0).HeaderCell.Value = "Transaction Date"
        dgReport.Columns(1).HeaderCell.Value = "Transaction No."
        dgReport.Columns(2).HeaderCell.Value = "Total"

        'cell font size
        dgReport.Columns(0).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 10)
        dgReport.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 10)


        'column header font size
        dgReport.ColumnHeadersDefaultCellStyle.Font = New Font("tahoma", 12, FontStyle.Bold)

        'column header width
        dgReport.Columns(0).Width = 280
        dgReport.Columns(1).Width = 280
        dgReport.Columns(2).Width = 225

        'cell alignment
        dgReport.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgReport.ColumnHeadersDefaultCellStyle.Alignment = ContentAlignment.MiddleCenter

        'cell formatting
        dgReport.Columns(0).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgReport.Columns(2).ValueType = GetType(Decimal)
        dgReport.Columns(2).DefaultCellStyle.Format = "N2"
    End Sub




    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        query = "SELECT TRANSDATE, TRANSNUM, TOTALPRICE FROM tblsummary WHERE FORMAT(TRANSDATE, 'dd/MM/yyyy') BETWEEN '" & dtFrom.Value & "' AND '" & dtTo.Value & "' GROUP BY TRANSDATE, TRANSNUM, TOTALPRICE"
        LoadDTG(query, dgReport)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dtgSales()
        btnSearch.Enabled = False
    End Sub

    Private Sub DtFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtFrom.ValueChanged
        Label4.Text = dtFrom.Value()
    End Sub

    Private Sub DtTo_ValueChanged(sender As Object, e As EventArgs) Handles dtTo.ValueChanged
        btnSearch.Enabled = True
    End Sub



    Private Sub TxtSearchTrans_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        query = "SELECT TRANSDATE, TRANSNUM, TOTALPRICE FROM tblsummary WHERE TRANSNUM LIKE '%" & txtSearch.Text & "%' GROUP BY TRANSDATE, TRANSNUM,TOTALPRICE"
        LoadDTG(query, dgReport)
    End Sub
End Class