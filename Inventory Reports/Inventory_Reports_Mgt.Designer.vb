<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Reports_Mgt
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bnt_stock_transfer_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_stock_transfer_for_sale = New FontAwesome.Sharp.IconButton()
        Me.btn_stock_on_hand_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_stock_adjustment_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_stock_movement_rp = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.bnt_stock_transfer_rp)
        Me.Panel2.Controls.Add(Me.btn_stock_transfer_for_sale)
        Me.Panel2.Controls.Add(Me.btn_stock_on_hand_rp)
        Me.Panel2.Controls.Add(Me.btn_stock_adjustment_rp)
        Me.Panel2.Controls.Add(Me.btn_stock_movement_rp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 782)
        Me.Panel2.TabIndex = 4
        '
        'bnt_stock_transfer_rp
        '
        Me.bnt_stock_transfer_rp.Enabled = False
        Me.bnt_stock_transfer_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.bnt_stock_transfer_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.bnt_stock_transfer_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnt_stock_transfer_rp.IconSize = 35
        Me.bnt_stock_transfer_rp.Location = New System.Drawing.Point(275, 36)
        Me.bnt_stock_transfer_rp.Name = "bnt_stock_transfer_rp"
        Me.bnt_stock_transfer_rp.Size = New System.Drawing.Size(172, 105)
        Me.bnt_stock_transfer_rp.TabIndex = 20
        Me.bnt_stock_transfer_rp.Text = "JNY Stock Tranfer For Sale"
        Me.bnt_stock_transfer_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bnt_stock_transfer_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bnt_stock_transfer_rp.UseVisualStyleBackColor = True
        '
        'btn_stock_transfer_for_sale
        '
        Me.btn_stock_transfer_for_sale.Enabled = False
        Me.btn_stock_transfer_for_sale.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_stock_transfer_for_sale.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_stock_transfer_for_sale.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stock_transfer_for_sale.IconSize = 35
        Me.btn_stock_transfer_for_sale.Location = New System.Drawing.Point(275, 169)
        Me.btn_stock_transfer_for_sale.Name = "btn_stock_transfer_for_sale"
        Me.btn_stock_transfer_for_sale.Size = New System.Drawing.Size(172, 105)
        Me.btn_stock_transfer_for_sale.TabIndex = 19
        Me.btn_stock_transfer_for_sale.Text = "JNY Stock Transfer For Sale"
        Me.btn_stock_transfer_for_sale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stock_transfer_for_sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stock_transfer_for_sale.UseVisualStyleBackColor = True
        '
        'btn_stock_on_hand_rp
        '
        Me.btn_stock_on_hand_rp.Enabled = False
        Me.btn_stock_on_hand_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_stock_on_hand_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_stock_on_hand_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stock_on_hand_rp.IconSize = 35
        Me.btn_stock_on_hand_rp.Location = New System.Drawing.Point(39, 301)
        Me.btn_stock_on_hand_rp.Name = "btn_stock_on_hand_rp"
        Me.btn_stock_on_hand_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_stock_on_hand_rp.TabIndex = 18
        Me.btn_stock_on_hand_rp.Text = "JNY Stock On Hand Report"
        Me.btn_stock_on_hand_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stock_on_hand_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stock_on_hand_rp.UseVisualStyleBackColor = True
        '
        'btn_stock_adjustment_rp
        '
        Me.btn_stock_adjustment_rp.Enabled = False
        Me.btn_stock_adjustment_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_stock_adjustment_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_stock_adjustment_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stock_adjustment_rp.IconSize = 35
        Me.btn_stock_adjustment_rp.Location = New System.Drawing.Point(39, 168)
        Me.btn_stock_adjustment_rp.Name = "btn_stock_adjustment_rp"
        Me.btn_stock_adjustment_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_stock_adjustment_rp.TabIndex = 17
        Me.btn_stock_adjustment_rp.Text = "JNY Stock Adjustment Report"
        Me.btn_stock_adjustment_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stock_adjustment_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stock_adjustment_rp.UseVisualStyleBackColor = True
        '
        'btn_stock_movement_rp
        '
        Me.btn_stock_movement_rp.Enabled = False
        Me.btn_stock_movement_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_stock_movement_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_stock_movement_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_stock_movement_rp.IconSize = 35
        Me.btn_stock_movement_rp.Location = New System.Drawing.Point(39, 36)
        Me.btn_stock_movement_rp.Name = "btn_stock_movement_rp"
        Me.btn_stock_movement_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_stock_movement_rp.TabIndex = 16
        Me.btn_stock_movement_rp.Text = "Stock Movement Report"
        Me.btn_stock_movement_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stock_movement_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_stock_movement_rp.UseVisualStyleBackColor = True
        '
        'Inventory_Reports_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Inventory_Reports_Mgt"
        Me.Text = "Inventory Reports"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents bnt_stock_transfer_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_stock_transfer_for_sale As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_stock_on_hand_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_stock_adjustment_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_stock_movement_rp As FontAwesome.Sharp.IconButton
End Class
