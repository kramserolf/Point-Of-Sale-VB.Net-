<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransEdit
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LBLUNITPRICE = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTITEM = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LBLPRICE = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTPTRANSTDATE = New System.Windows.Forms.DateTimePicker()
        Me.TXTQTY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTDESC = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTCATEGORY = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTTRANSNUM = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLMSG = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.LBLITEMID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TXTITEM)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DTPTRANSTDATE)
        Me.Panel1.Controls.Add(Me.TXTQTY)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTDESC)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TXTCATEGORY)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TXTTRANSNUM)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LBLITEMID)
        Me.Panel1.Location = New System.Drawing.Point(15, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 370)
        Me.Panel1.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Unit Price:"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.LBLUNITPRICE)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(131, 240)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(451, 31)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'LBLUNITPRICE
        '
        Me.LBLUNITPRICE.AutoSize = True
        Me.LBLUNITPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUNITPRICE.Location = New System.Drawing.Point(3, 0)
        Me.LBLUNITPRICE.Name = "LBLUNITPRICE"
        Me.LBLUNITPRICE.Size = New System.Drawing.Size(73, 31)
        Me.LBLUNITPRICE.TabIndex = 14
        Me.LBLUNITPRICE.Text = "PHP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(82, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "PHP"
        '
        'TXTITEM
        '
        Me.TXTITEM.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXTITEM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTITEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTITEM.Location = New System.Drawing.Point(131, 102)
        Me.TXTITEM.Name = "TXTITEM"
        Me.TXTITEM.ReadOnly = True
        Me.TXTITEM.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TXTITEM.Size = New System.Drawing.Size(494, 40)
        Me.TXTITEM.TabIndex = 7
        Me.TXTITEM.Text = "None"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LBLPRICE)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(378, 290)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(260, 31)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'LBLPRICE
        '
        Me.LBLPRICE.AutoSize = True
        Me.LBLPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPRICE.Location = New System.Drawing.Point(3, 0)
        Me.LBLPRICE.Name = "LBLPRICE"
        Me.LBLPRICE.Size = New System.Drawing.Size(73, 31)
        Me.LBLPRICE.TabIndex = 14
        Me.LBLPRICE.Text = "PHP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PHP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Quantity:"
        '
        'DTPTRANSTDATE
        '
        Me.DTPTRANSTDATE.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTRANSTDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTRANSTDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTRANSTDATE.Location = New System.Drawing.Point(507, 20)
        Me.DTPTRANSTDATE.Name = "DTPTRANSTDATE"
        Me.DTPTRANSTDATE.Size = New System.Drawing.Size(168, 22)
        Me.DTPTRANSTDATE.TabIndex = 11
        '
        'TXTQTY
        '
        Me.TXTQTY.BackColor = System.Drawing.Color.Silver
        Me.TXTQTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQTY.Location = New System.Drawing.Point(131, 293)
        Me.TXTQTY.Name = "TXTQTY"
        Me.TXTQTY.Size = New System.Drawing.Size(120, 31)
        Me.TXTQTY.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Transaction Date:"
        '
        'TXTDESC
        '
        Me.TXTDESC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXTDESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDESC.Location = New System.Drawing.Point(131, 194)
        Me.TXTDESC.Name = "TXTDESC"
        Me.TXTDESC.ReadOnly = True
        Me.TXTDESC.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TXTDESC.Size = New System.Drawing.Size(494, 40)
        Me.TXTDESC.TabIndex = 7
        Me.TXTDESC.Text = "None"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Item:"
        '
        'TXTCATEGORY
        '
        Me.TXTCATEGORY.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXTCATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTCATEGORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATEGORY.Location = New System.Drawing.Point(131, 148)
        Me.TXTCATEGORY.Name = "TXTCATEGORY"
        Me.TXTCATEGORY.ReadOnly = True
        Me.TXTCATEGORY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TXTCATEGORY.Size = New System.Drawing.Size(494, 40)
        Me.TXTCATEGORY.TabIndex = 7
        Me.TXTCATEGORY.Text = "None"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Category:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction #:"
        '
        'TXTTRANSNUM
        '
        Me.TXTTRANSNUM.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXTTRANSNUM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTTRANSNUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTRANSNUM.Location = New System.Drawing.Point(131, 56)
        Me.TXTTRANSNUM.Name = "TXTTRANSNUM"
        Me.TXTTRANSNUM.ReadOnly = True
        Me.TXTTRANSNUM.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TXTTRANSNUM.Size = New System.Drawing.Size(494, 40)
        Me.TXTTRANSNUM.TabIndex = 7
        Me.TXTTRANSNUM.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(273, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total Price:"
        '
        'LBLMSG
        '
        Me.LBLMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMSG.Location = New System.Drawing.Point(12, 9)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(679, 21)
        Me.LBLMSG.TabIndex = 37
        Me.LBLMSG.Text = "Label11"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(579, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 35)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.Location = New System.Drawing.Point(458, 403)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(115, 35)
        Me.BTNSAVE.TabIndex = 36
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = True
        '
        'LBLITEMID
        '
        Me.LBLITEMID.AutoSize = True
        Me.LBLITEMID.Location = New System.Drawing.Point(585, 27)
        Me.LBLITEMID.Name = "LBLITEMID"
        Me.LBLITEMID.Size = New System.Drawing.Size(13, 13)
        Me.LBLITEMID.TabIndex = 39
        Me.LBLITEMID.Text = "0"
        '
        'frmTransEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LBLMSG)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Name = "frmTransEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents LBLUNITPRICE As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTITEM As RichTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LBLPRICE As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DTPTRANSTDATE As DateTimePicker
    Friend WithEvents TXTQTY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTDESC As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTCATEGORY As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTTRANSNUM As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLMSG As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents LBLITEMID As Label
End Class
