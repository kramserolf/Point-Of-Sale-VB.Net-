<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterNewItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsPOS = New System.Windows.Forms.ToolStripButton()
        Me.tsSearchProducts = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageProductsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ManageUsersToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManageProductsToolStripMenuItem
        '
        Me.ManageProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterNewItemsToolStripMenuItem, Me.RegisterCategoryToolStripMenuItem, Me.StockInToolStripMenuItem})
        Me.ManageProductsToolStripMenuItem.Name = "ManageProductsToolStripMenuItem"
        Me.ManageProductsToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.ManageProductsToolStripMenuItem.Text = "Manage Products"
        '
        'RegisterNewItemsToolStripMenuItem
        '
        Me.RegisterNewItemsToolStripMenuItem.Name = "RegisterNewItemsToolStripMenuItem"
        Me.RegisterNewItemsToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.RegisterNewItemsToolStripMenuItem.Text = "Register New Items"
        '
        'RegisterCategoryToolStripMenuItem
        '
        Me.RegisterCategoryToolStripMenuItem.Name = "RegisterCategoryToolStripMenuItem"
        Me.RegisterCategoryToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.RegisterCategoryToolStripMenuItem.Text = "Register Category"
        '
        'StockInToolStripMenuItem
        '
        Me.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem"
        Me.StockInToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.StockInToolStripMenuItem.Text = "Stock-In"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupDatabaseToolStripMenuItem, Me.RestoreDatabaseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        '
        'RestoreDatabaseToolStripMenuItem
        '
        Me.RestoreDatabaseToolStripMenuItem.Enabled = False
        Me.RestoreDatabaseToolStripMenuItem.Name = "RestoreDatabaseToolStripMenuItem"
        Me.RestoreDatabaseToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.RestoreDatabaseToolStripMenuItem.Text = "Restore Database"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPOS, Me.tsSearchProducts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1800, 77)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsPOS
        '
        Me.tsPOS.Image = CType(resources.GetObject("tsPOS.Image"), System.Drawing.Image)
        Me.tsPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPOS.Name = "tsPOS"
        Me.tsPOS.Size = New System.Drawing.Size(69, 74)
        Me.tsPOS.Text = "POS (F1)"
        Me.tsPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSearchProducts
        '
        Me.tsSearchProducts.Image = CType(resources.GetObject("tsSearchProducts.Image"), System.Drawing.Image)
        Me.tsSearchProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearchProducts.Name = "tsSearchProducts"
        Me.tsSearchProducts.Size = New System.Drawing.Size(131, 74)
        Me.tsSearchProducts.Text = "Find Products (F2)"
        Me.tsSearchProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 105)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1800, 792)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = ".accdb"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterNewItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsPOS As ToolStripButton
    Friend WithEvents tsSearchProducts As ToolStripButton
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RegisterCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
