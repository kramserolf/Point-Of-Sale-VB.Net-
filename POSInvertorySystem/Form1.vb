Public Class Form1
    Private Sub RegisterNewItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewItemsToolStripMenuItem.Click
        frmProducts.ShowDialog()
        clear(frmProducts)

    End Sub

    Private Sub disabled_menu()
        ManageProductsToolStripMenuItem.Enabled = False
        ManageUsersToolStripMenuItem.Enabled = False
        ReportsToolStripMenuItem.Enabled = False
        tsPOS.Enabled = False
        tsSearchProducts.Enabled = False
        LoginToolStripMenuItem.Text = "Login"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disabled_menu()
        frmLogin.ShowDialog()
    End Sub

    Private Sub StockInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockInToolStripMenuItem.Click
        frmStockin.ShowDialog()
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsPOS.Click
        frmPOS.ShowDialog()
    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportToolStripMenuItem.Click
        'query = "SELECT tblItems.ITEMBARCODE, tblItems.ITEMNAME, tblItems.DESCRIPTION, tblItems.OPRICE, Last(tblItems.ITEMQTY) + SUM(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.TRANSQTY) AS SOLD, Last(tblItems.ITEMQTY) AS REMAINING" &
        '" FROM tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE = tblsoldout.ITEMBARCODE " &
        '" GROUP BY tblItems.ITEMBARCODE, tblItems.ITEMNAME, tblItems.DESCRIPTION, tblItems.OPRICE"
        'reports(query, "inventory", frmReport.CrystalReportViewer1)
        frmInventoryReport.ShowDialog()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        'query = "SELECT tblItems.ITEMBARCODE , [ITEMNAME] & ' ' & [DESCRIPTION] AS Products, Sum(tblsoldout.TRANSQTY) AS QTY, Sum(tblsoldout.SUBTOTAL) AS TotalAmount
        '        From tblItems INNER JOIN tblsoldout ON tblItems.ITEMBARCODE = tblsoldout.ITEMBARCODE WHERE FORMAT(TRANSDATE,'mm/dd/yyyy') = FORMAT(Now(),'mm/dd/yyyy') 
        'GROUP BY tblItems.ITEMBARCODE, [ITEMNAME] & ' ' & [DESCRIPTION]"
        ' reports(query, "sales", frmReport.CrystalReportViewer1)
        frmSalesReport.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tsSearchProducts.Click
        frmListProducts.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Login" Then
            frmLogin.ShowDialog()
        Else
            disabled_menu()
        End If
    End Sub

    Private Sub RegisterCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterCategoryToolStripMenuItem.Click
        frmCategory.ShowDialog()
    End Sub

    Private Sub ManageUsersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        frmManageUsers.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            tsPOS.PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            tsSearchProducts.PerformClick()
        End If

    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        Try
            'set the destination and a file name with the date and time
            Dim backupfiledestination As String = Application.StartupPath & "\dbbackup" & Format(Now(), "yyyy-M-d H m") & ".accdb"
            'location of the database file that you want to backup
            Dim databaseFile As String = Application.StartupPath & "\jerneydb.accdb"

            'create a backup by using Filecopy Command to copy the file from  location to destination
            FileCopy(databaseFile, backupfiledestination)
            MsgBox("Database Backup has been Created Successfully!")
        Catch ex As Exception
            'catch an error  
            MsgBox(ex.Message)
        End Try

        RestoreDatabaseToolStripMenuItem.Enabled = True
    End Sub

    Private Sub RestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseToolStripMenuItem.Click
        Try
            'set a your database file
            Dim restorefile As String = Application.StartupPath & "\dbbackup.accdb"
            'declare a variable for storing the text message.
            Dim msgText As String
            'filtering the file
            OpenFileDialog1.Filter = "Access | *.accdb"
            'open the file directory
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                'set a text message
                msgText = "Are you sure you want to restore your database? It will overwite your database since the backup have made."
                'validate if you want to restore or not
                If MessageBox.Show(msgText, "Restore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    'restore your database
                    FileCopy(OpenFileDialog1.FileName, restorefile)
                    MsgBox("Database has been restore")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class
