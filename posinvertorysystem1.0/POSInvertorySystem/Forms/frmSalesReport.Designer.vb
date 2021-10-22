<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReport))
        Me.dgReport = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReset = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnView = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'dgReport
        '
        Me.dgReport.AllowUserToAddRows = False
        Me.dgReport.AllowUserToDeleteRows = False
        Me.dgReport.AllowUserToResizeColumns = False
        Me.dgReport.AllowUserToResizeRows = False
        Me.dgReport.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReport.Location = New System.Drawing.Point(16, 68)
        Me.dgReport.Margin = New System.Windows.Forms.Padding(4)
        Me.dgReport.Name = "dgReport"
        Me.dgReport.ReadOnly = True
        Me.dgReport.RowHeadersVisible = False
        Me.dgReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgReport.Size = New System.Drawing.Size(1060, 540)
        Me.dgReport.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(105, 18)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(463, 34)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search:"
        '
        'dtFrom
        '
        Me.dtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(89, 12)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(207, 34)
        Me.dtFrom.TabIndex = 3
        Me.dtFrom.Value = New Date(2021, 10, 20, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(319, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To:"
        '
        'dtTo
        '
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(368, 12)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(207, 34)
        Me.dtTo.TabIndex = 5
        Me.dtTo.Value = New Date(2021, 10, 20, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.dtFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtTo)
        Me.Panel1.Location = New System.Drawing.Point(16, 615)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 55)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(636, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label4"
        '
        'btnReset
        '
        Me.btnReset.Active = False
        Me.btnReset.Activecolor = System.Drawing.Color.DodgerBlue
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.BorderRadius = 7
        Me.btnReset.ButtonText = "Reset"
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.DisabledColor = System.Drawing.Color.Gray
        Me.btnReset.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReset.Iconimage = Global.POSInvertorySystem.My.Resources.Resources.reset
        Me.btnReset.Iconimage_right = Nothing
        Me.btnReset.Iconimage_right_Selected = Nothing
        Me.btnReset.Iconimage_Selected = Nothing
        Me.btnReset.IconMarginLeft = 9
        Me.btnReset.IconMarginRight = 0
        Me.btnReset.IconRightVisible = True
        Me.btnReset.IconRightZoom = 0R
        Me.btnReset.IconVisible = True
        Me.btnReset.IconZoom = 50.0R
        Me.btnReset.IsTab = False
        Me.btnReset.Location = New System.Drawing.Point(903, 7)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Normalcolor = System.Drawing.Color.White
        Me.btnReset.OnHovercolor = System.Drawing.SystemColors.Control
        Me.btnReset.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnReset.selected = False
        Me.btnReset.Size = New System.Drawing.Size(139, 41)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReset.Textcolor = System.Drawing.Color.Black
        Me.btnReset.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnSearch.Enabled = False
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
        Me.btnSearch.Location = New System.Drawing.Point(752, 7)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.White
        Me.btnSearch.OnHovercolor = System.Drawing.SystemColors.Control
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(139, 41)
        Me.btnSearch.TabIndex = 15
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
        Me.btnPrint.Location = New System.Drawing.Point(905, 15)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btnPrint.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.btnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrint.selected = False
        Me.btnPrint.Size = New System.Drawing.Size(139, 41)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrint.Textcolor = System.Drawing.Color.White
        Me.btnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnView
        '
        Me.btnView.Active = False
        Me.btnView.Activecolor = System.Drawing.Color.DodgerBlue
        Me.btnView.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnView.BorderRadius = 7
        Me.btnView.ButtonText = "View"
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.DisabledColor = System.Drawing.Color.Gray
        Me.btnView.Iconcolor = System.Drawing.Color.Transparent
        Me.btnView.Iconimage = Global.POSInvertorySystem.My.Resources.Resources.view
        Me.btnView.Iconimage_right = Nothing
        Me.btnView.Iconimage_right_Selected = Nothing
        Me.btnView.Iconimage_Selected = Nothing
        Me.btnView.IconMarginLeft = 9
        Me.btnView.IconMarginRight = 0
        Me.btnView.IconRightVisible = True
        Me.btnView.IconRightZoom = 0R
        Me.btnView.IconVisible = True
        Me.btnView.IconZoom = 60.0R
        Me.btnView.IsTab = False
        Me.btnView.Location = New System.Drawing.Point(757, 15)
        Me.btnView.Margin = New System.Windows.Forms.Padding(5)
        Me.btnView.Name = "btnView"
        Me.btnView.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.btnView.OnHovercolor = System.Drawing.Color.SteelBlue
        Me.btnView.OnHoverTextColor = System.Drawing.Color.White
        Me.btnView.selected = False
        Me.btnView.Size = New System.Drawing.Size(139, 41)
        Me.btnView.TabIndex = 13
        Me.btnView.Text = "View"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnView.Textcolor = System.Drawing.Color.White
        Me.btnView.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 679)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub

    Friend WithEvents dgReport As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnView As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnReset As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label4 As Label
End Class
