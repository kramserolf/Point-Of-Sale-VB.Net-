<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.LBLUSERID = New System.Windows.Forms.Label()
        Me.BTNESCAPE = New System.Windows.Forms.Button()
        Me.BTNTENDER = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLTOTPRICE = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotalsales = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLSUBTOTAL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtgCart = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TXTITEMID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblvat = New System.Windows.Forms.Label()
        Me.LBLCHANGE = New System.Windows.Forms.Label()
        Me.LBLSUBTOT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTTENDERED = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLTRANSID = New System.Windows.Forms.Label()
        Me.Mnstrp_ShortCutMenu = New System.Windows.Forms.MenuStrip()
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TENDEREDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnaddQty = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.dtgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Mnstrp_ShortCutMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLUSERID
        '
        Me.LBLUSERID.AutoSize = True
        Me.LBLUSERID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSERID.Location = New System.Drawing.Point(532, 537)
        Me.LBLUSERID.Name = "LBLUSERID"
        Me.LBLUSERID.Size = New System.Drawing.Size(19, 20)
        Me.LBLUSERID.TabIndex = 33
        Me.LBLUSERID.Text = "2"
        '
        'BTNESCAPE
        '
        Me.BTNESCAPE.Enabled = False
        Me.BTNESCAPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNESCAPE.Location = New System.Drawing.Point(189, 641)
        Me.BTNESCAPE.Name = "BTNESCAPE"
        Me.BTNESCAPE.Size = New System.Drawing.Size(151, 56)
        Me.BTNESCAPE.TabIndex = 12
        Me.BTNESCAPE.Text = "ESC"
        Me.BTNESCAPE.UseVisualStyleBackColor = True
        '
        'BTNTENDER
        '
        Me.BTNTENDER.Enabled = False
        Me.BTNTENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTENDER.Location = New System.Drawing.Point(734, 640)
        Me.BTNTENDER.Name = "BTNTENDER"
        Me.BTNTENDER.Size = New System.Drawing.Size(151, 56)
        Me.BTNTENDER.TabIndex = 12
        Me.BTNTENDER.Text = "Tender Amount (F11)"
        Me.BTNTENDER.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Sales :"
        '
        'LBLTOTPRICE
        '
        Me.LBLTOTPRICE.AutoSize = True
        Me.LBLTOTPRICE.BackColor = System.Drawing.Color.DimGray
        Me.LBLTOTPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTPRICE.ForeColor = System.Drawing.Color.Cyan
        Me.LBLTOTPRICE.Location = New System.Drawing.Point(1115, 162)
        Me.LBLTOTPRICE.Name = "LBLTOTPRICE"
        Me.LBLTOTPRICE.Size = New System.Drawing.Size(84, 37)
        Me.LBLTOTPRICE.TabIndex = 7
        Me.LBLTOTPRICE.Text = "0.00"
        Me.LBLTOTPRICE.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbltotalsales)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(18, 331)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(322, 29)
        Me.FlowLayoutPanel1.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PHP"
        '
        'lbltotalsales
        '
        Me.lbltotalsales.AutoSize = True
        Me.lbltotalsales.BackColor = System.Drawing.Color.DimGray
        Me.lbltotalsales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsales.ForeColor = System.Drawing.Color.Cyan
        Me.lbltotalsales.Location = New System.Drawing.Point(218, 0)
        Me.lbltotalsales.Name = "lbltotalsales"
        Me.lbltotalsales.Size = New System.Drawing.Size(54, 25)
        Me.lbltotalsales.TabIndex = 10
        Me.lbltotalsales.Text = "0.00"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.LBLSUBTOTAL)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(657, 724)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(407, 28)
        Me.FlowLayoutPanel2.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PHP"
        '
        'LBLSUBTOTAL
        '
        Me.LBLSUBTOTAL.AutoSize = True
        Me.LBLSUBTOTAL.BackColor = System.Drawing.Color.DimGray
        Me.LBLSUBTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUBTOTAL.ForeColor = System.Drawing.Color.Cyan
        Me.LBLSUBTOTAL.Location = New System.Drawing.Point(320, 0)
        Me.LBLSUBTOTAL.Name = "LBLSUBTOTAL"
        Me.LBLSUBTOTAL.Size = New System.Drawing.Size(42, 25)
        Me.LBLSUBTOTAL.TabIndex = 7
        Me.LBLSUBTOTAL.Text = "0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(255, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total :"
        '
        'Timer1
        '
        '
        'dtgCart
        '
        Me.dtgCart.AllowUserToAddRows = False
        Me.dtgCart.AllowUserToDeleteRows = False
        Me.dtgCart.AllowUserToResizeColumns = False
        Me.dtgCart.AllowUserToResizeRows = False
        Me.dtgCart.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dtgCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dtgCart.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCart.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCart.GridColor = System.Drawing.SystemColors.Control
        Me.dtgCart.Location = New System.Drawing.Point(12, 192)
        Me.dtgCart.MultiSelect = False
        Me.dtgCart.Name = "dtgCart"
        Me.dtgCart.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgCart.RowHeadersVisible = False
        Me.dtgCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCart.Size = New System.Drawing.Size(939, 432)
        Me.dtgCart.TabIndex = 25
        '
        'Column6
        '
        Me.Column6.HeaderText = "Barcode"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 180
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 220
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 97
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 90
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Sub Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 99
        '
        'TXTITEMID
        '
        Me.TXTITEMID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTITEMID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTITEMID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTITEMID.Location = New System.Drawing.Point(982, 224)
        Me.TXTITEMID.Name = "TXTITEMID"
        Me.TXTITEMID.Size = New System.Drawing.Size(355, 26)
        Me.TXTITEMID.TabIndex = 24
        Me.TXTITEMID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Mnstrp_ShortCutMenu)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(982, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 365)
        Me.Panel1.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblvat)
        Me.GroupBox1.Controls.Add(Me.LBLCHANGE)
        Me.GroupBox1.Controls.Add(Me.LBLSUBTOT)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TXTTENDERED)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LBLTRANSID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'lblvat
        '
        Me.lblvat.AutoSize = True
        Me.lblvat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvat.Location = New System.Drawing.Point(277, 25)
        Me.lblvat.Name = "lblvat"
        Me.lblvat.Size = New System.Drawing.Size(49, 20)
        Me.lblvat.TabIndex = 16
        Me.lblvat.Text = "12 %"
        Me.lblvat.Visible = False
        '
        'LBLCHANGE
        '
        Me.LBLCHANGE.AutoSize = True
        Me.LBLCHANGE.BackColor = System.Drawing.Color.Transparent
        Me.LBLCHANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LBLCHANGE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLCHANGE.Location = New System.Drawing.Point(190, 227)
        Me.LBLCHANGE.Name = "LBLCHANGE"
        Me.LBLCHANGE.Size = New System.Drawing.Size(97, 46)
        Me.LBLCHANGE.TabIndex = 7
        Me.LBLCHANGE.Text = "0.00"
        Me.LBLCHANGE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLSUBTOT
        '
        Me.LBLSUBTOT.AutoSize = True
        Me.LBLSUBTOT.BackColor = System.Drawing.Color.Transparent
        Me.LBLSUBTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUBTOT.ForeColor = System.Drawing.Color.Black
        Me.LBLSUBTOT.Location = New System.Drawing.Point(175, 172)
        Me.LBLSUBTOT.Name = "LBLSUBTOT"
        Me.LBLSUBTOT.Size = New System.Drawing.Size(97, 46)
        Me.LBLSUBTOT.TabIndex = 7
        Me.LBLSUBTOT.Text = "0.00"
        Me.LBLSUBTOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label11.Location = New System.Drawing.Point(38, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 31)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "CHANGE:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(229, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Vat :"
        Me.Label17.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 31)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "TOTAL:"
        '
        'TXTTENDERED
        '
        Me.TXTTENDERED.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTENDERED.Location = New System.Drawing.Point(123, 102)
        Me.TXTTENDERED.Multiline = True
        Me.TXTTENDERED.Name = "TXTTENDERED"
        Me.TXTTENDERED.Size = New System.Drawing.Size(194, 34)
        Me.TXTTENDERED.TabIndex = 15
        Me.TXTTENDERED.Text = "0.00"
        Me.TXTTENDERED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 48)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tendered" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Amount :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Transaction # :"
        '
        'LBLTRANSID
        '
        Me.LBLTRANSID.AutoSize = True
        Me.LBLTRANSID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTRANSID.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBLTRANSID.Location = New System.Drawing.Point(163, 45)
        Me.LBLTRANSID.Name = "LBLTRANSID"
        Me.LBLTRANSID.Size = New System.Drawing.Size(75, 20)
        Me.LBLTRANSID.TabIndex = 26
        Me.LBLTRANSID.Text = "Trans Id"
        Me.LBLTRANSID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mnstrp_ShortCutMenu
        '
        Me.Mnstrp_ShortCutMenu.AutoSize = False
        Me.Mnstrp_ShortCutMenu.BackColor = System.Drawing.Color.Transparent
        Me.Mnstrp_ShortCutMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.Mnstrp_ShortCutMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Mnstrp_ShortCutMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TToolStripMenuItem, Me.VoidToolStripMenuItem, Me.TENDEREDToolStripMenuItem, Me.ESCToolStripMenuItem, Me.ADDToolStripMenuItem})
        Me.Mnstrp_ShortCutMenu.Location = New System.Drawing.Point(57, 33)
        Me.Mnstrp_ShortCutMenu.Name = "Mnstrp_ShortCutMenu"
        Me.Mnstrp_ShortCutMenu.Size = New System.Drawing.Size(22, 26)
        Me.Mnstrp_ShortCutMenu.TabIndex = 24
        Me.Mnstrp_ShortCutMenu.Text = "MenuStrip1"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.AutoSize = False
        Me.TToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(38, 62)
        Me.TToolStripMenuItem.Text = "Qty"
        '
        'VoidToolStripMenuItem
        '
        Me.VoidToolStripMenuItem.AutoSize = False
        Me.VoidToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VoidToolStripMenuItem.Name = "VoidToolStripMenuItem"
        Me.VoidToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.VoidToolStripMenuItem.Size = New System.Drawing.Size(43, 62)
        Me.VoidToolStripMenuItem.Text = "Void"
        '
        'TENDEREDToolStripMenuItem
        '
        Me.TENDEREDToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TENDEREDToolStripMenuItem.Name = "TENDEREDToolStripMenuItem"
        Me.TENDEREDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.TENDEREDToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.TENDEREDToolStripMenuItem.Text = "Tender Amount"
        '
        'ESCToolStripMenuItem
        '
        Me.ESCToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ESCToolStripMenuItem.Name = "ESCToolStripMenuItem"
        Me.ESCToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.ESCToolStripMenuItem.Text = "ESC"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ADDToolStripMenuItem.Text = "ToolStripMenuItem1"
        '
        'btnaddQty
        '
        Me.btnaddQty.Enabled = False
        Me.btnaddQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddQty.Location = New System.Drawing.Point(365, 641)
        Me.btnaddQty.Name = "btnaddQty"
        Me.btnaddQty.Size = New System.Drawing.Size(151, 56)
        Me.btnaddQty.TabIndex = 12
        Me.btnaddQty.Text = "Quantity (F3)"
        Me.btnaddQty.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Location = New System.Drawing.Point(549, 641)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(151, 56)
        Me.btnVoid.TabIndex = 12
        Me.btnVoid.Text = "Void (F8)"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Enabled = False
        Me.BTNSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.Location = New System.Drawing.Point(910, 639)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(151, 56)
        Me.BTNSAVE.TabIndex = 11
        Me.BTNSAVE.Text = "Print (Enter)"
        Me.BTNSAVE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(978, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Barcode :"
        '
        'BTNADD
        '
        Me.BTNADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNADD.Location = New System.Drawing.Point(494, 385)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(81, 26)
        Me.BTNADD.TabIndex = 29
        Me.BTNADD.Text = "Add"
        Me.BTNADD.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POSInvertorySystem.My.Resources.Resources.Nayun_s_Mini_Mart_logos_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(969, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(230, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 56)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Add Item (F5)"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1089, 115)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(148, 23)
        Me.lblDate.TabIndex = 37
        Me.lblDate.Text = "October 18,2021"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1064, 46)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(198, 58)
        Me.lblTime.TabIndex = 38
        Me.lblTime.Text = "8:31 PM"
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.Location = New System.Drawing.Point(1278, 7)
        Me.lblUname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(57, 17)
        Me.lblUname.TabIndex = 39
        Me.lblUname.Text = "Label2"
        Me.lblUname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1220, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cashier:"
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 725)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUname)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Controls.Add(Me.LBLTOTPRICE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.btnaddQty)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.dtgCart)
        Me.Controls.Add(Me.BTNESCAPE)
        Me.Controls.Add(Me.TXTITEMID)
        Me.Controls.Add(Me.BTNTENDER)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNADD)
        Me.Controls.Add(Me.LBLUSERID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.dtgCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Mnstrp_ShortCutMenu.ResumeLayout(False)
        Me.Mnstrp_ShortCutMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLUSERID As Label
    Friend WithEvents BTNESCAPE As Button
    Friend WithEvents BTNTENDER As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLTOTPRICE As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotalsales As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLSUBTOTAL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dtgCart As DataGridView
    Friend WithEvents TXTITEMID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnaddQty As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents Mnstrp_ShortCutMenu As MenuStrip
    Friend WithEvents VoidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TENDEREDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNADD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblvat As Label
    Friend WithEvents LBLCHANGE As Label
    Friend WithEvents LBLSUBTOT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTTENDERED As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLTRANSID As Label
    Friend WithEvents lblUname As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
