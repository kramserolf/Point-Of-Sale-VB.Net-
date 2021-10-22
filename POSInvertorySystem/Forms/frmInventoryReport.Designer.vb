<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryReport))
        Me.dgReport = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgReport
        '
        Me.dgReport.AllowUserToAddRows = False
        Me.dgReport.AllowUserToDeleteRows = False
        Me.dgReport.AllowUserToResizeColumns = False
        Me.dgReport.AllowUserToResizeRows = False
        Me.dgReport.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReport.Location = New System.Drawing.Point(20, 66)
        Me.dgReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgReport.Name = "dgReport"
        Me.dgReport.RowHeadersVisible = False
        Me.dgReport.Size = New System.Drawing.Size(1060, 598)
        Me.dgReport.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(116, 15)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(345, 34)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRefresh
        '
        Me.btnRefresh.Active = False
        Me.btnRefresh.Activecolor = System.Drawing.Color.DodgerBlue
        Me.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.BorderRadius = 7
        Me.btnRefresh.ButtonText = "Refresh"
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.btnRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRefresh.Iconimage = Global.POSInvertorySystem.My.Resources.Resources.refresh
        Me.btnRefresh.Iconimage_right = Nothing
        Me.btnRefresh.Iconimage_right_Selected = Nothing
        Me.btnRefresh.Iconimage_Selected = Nothing
        Me.btnRefresh.IconMarginLeft = 9
        Me.btnRefresh.IconMarginRight = 0
        Me.btnRefresh.IconRightVisible = True
        Me.btnRefresh.IconRightZoom = 0R
        Me.btnRefresh.IconVisible = True
        Me.btnRefresh.IconZoom = 60.0R
        Me.btnRefresh.IsTab = False
        Me.btnRefresh.Location = New System.Drawing.Point(795, 12)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.btnRefresh.OnHovercolor = System.Drawing.Color.SteelBlue
        Me.btnRefresh.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRefresh.selected = False
        Me.btnRefresh.Size = New System.Drawing.Size(139, 41)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh.Textcolor = System.Drawing.Color.White
        Me.btnRefresh.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.Active = False
        Me.btnSearch.Activecolor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.BorderRadius = 7
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.DisabledColor = System.Drawing.Color.Gray
        Me.btnSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSearch.Iconimage = Global.POSInvertorySystem.My.Resources.Resources.search
        Me.btnSearch.Iconimage_right = Nothing
        Me.btnSearch.Iconimage_right_Selected = Nothing
        Me.btnSearch.Iconimage_Selected = Nothing
        Me.btnSearch.IconMarginLeft = 9
        Me.btnSearch.IconMarginRight = 0
        Me.btnSearch.IconRightVisible = True
        Me.btnSearch.IconRightZoom = 0R
        Me.btnSearch.IconVisible = True
        Me.btnSearch.IconZoom = 60.0R
        Me.btnSearch.IsTab = False
        Me.btnSearch.Location = New System.Drawing.Point(648, 12)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.White
        Me.btnSearch.OnHovercolor = System.Drawing.SystemColors.Control
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(139, 41)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.Black
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPrint
        '
        Me.btnPrint.Active = False
        Me.btnPrint.Activecolor = System.Drawing.Color.DodgerBlue
        Me.btnPrint.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.BorderRadius = 7
        Me.btnPrint.ButtonText = "Print"
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrint.Iconimage = Global.POSInvertorySystem.My.Resources.Resources.printer
        Me.btnPrint.Iconimage_right = Nothing
        Me.btnPrint.Iconimage_right_Selected = Nothing
        Me.btnPrint.Iconimage_Selected = Nothing
        Me.btnPrint.IconMarginLeft = 9
        Me.btnPrint.IconMarginRight = 0
        Me.btnPrint.IconRightVisible = True
        Me.btnPrint.IconRightZoom = 0R
        Me.btnPrint.IconVisible = True
        Me.btnPrint.IconZoom = 50.0R
        Me.btnPrint.IsTab = False
        Me.btnPrint.Location = New System.Drawing.Point(941, 12)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btnPrint.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.btnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrint.selected = False
        Me.btnPrint.Size = New System.Drawing.Size(139, 41)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrint.Textcolor = System.Drawing.Color.White
        Me.btnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 679)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmInventoryReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Report"
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgReport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuFlatButton
End Class
