<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Purchase_Reports_Mgt
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
        Me.btn_ap_cn_summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_ap_inv_summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_good_receipt_summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_purchase_summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_ap_credit_note_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_ap_invoice_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_goods_receipt_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_purchase_order_rp = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_ap_cn_summary_rp)
        Me.Panel2.Controls.Add(Me.btn_ap_inv_summary_rp)
        Me.Panel2.Controls.Add(Me.btn_good_receipt_summary_rp)
        Me.Panel2.Controls.Add(Me.btn_purchase_summary_rp)
        Me.Panel2.Controls.Add(Me.btn_ap_credit_note_rp)
        Me.Panel2.Controls.Add(Me.btn_ap_invoice_rp)
        Me.Panel2.Controls.Add(Me.btn_goods_receipt_rp)
        Me.Panel2.Controls.Add(Me.btn_purchase_order_rp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 782)
        Me.Panel2.TabIndex = 5
        '
        'btn_ap_cn_summary_rp
        '
        Me.btn_ap_cn_summary_rp.Enabled = False
        Me.btn_ap_cn_summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_ap_cn_summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_ap_cn_summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ap_cn_summary_rp.IconSize = 35
        Me.btn_ap_cn_summary_rp.Location = New System.Drawing.Point(251, 429)
        Me.btn_ap_cn_summary_rp.Name = "btn_ap_cn_summary_rp"
        Me.btn_ap_cn_summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_ap_cn_summary_rp.TabIndex = 24
        Me.btn_ap_cn_summary_rp.Text = "AP CREDIT NOTE SUMMARY REPORT"
        Me.btn_ap_cn_summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ap_cn_summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ap_cn_summary_rp.UseVisualStyleBackColor = True
        '
        'btn_ap_inv_summary_rp
        '
        Me.btn_ap_inv_summary_rp.Enabled = False
        Me.btn_ap_inv_summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_ap_inv_summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_ap_inv_summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ap_inv_summary_rp.IconSize = 35
        Me.btn_ap_inv_summary_rp.Location = New System.Drawing.Point(251, 301)
        Me.btn_ap_inv_summary_rp.Name = "btn_ap_inv_summary_rp"
        Me.btn_ap_inv_summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_ap_inv_summary_rp.TabIndex = 23
        Me.btn_ap_inv_summary_rp.Text = "AP Invoice Summary Report"
        Me.btn_ap_inv_summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ap_inv_summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ap_inv_summary_rp.UseVisualStyleBackColor = True
        '
        'btn_good_receipt_summary_rp
        '
        Me.btn_good_receipt_summary_rp.Enabled = False
        Me.btn_good_receipt_summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_good_receipt_summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_good_receipt_summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_good_receipt_summary_rp.IconSize = 35
        Me.btn_good_receipt_summary_rp.Location = New System.Drawing.Point(251, 168)
        Me.btn_good_receipt_summary_rp.Name = "btn_good_receipt_summary_rp"
        Me.btn_good_receipt_summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_good_receipt_summary_rp.TabIndex = 22
        Me.btn_good_receipt_summary_rp.Text = "Goods Receipt Summary Report"
        Me.btn_good_receipt_summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_good_receipt_summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_good_receipt_summary_rp.UseVisualStyleBackColor = True
        '
        'btn_purchase_summary_rp
        '
        Me.btn_purchase_summary_rp.Enabled = False
        Me.btn_purchase_summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_purchase_summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_purchase_summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_purchase_summary_rp.IconSize = 35
        Me.btn_purchase_summary_rp.Location = New System.Drawing.Point(251, 36)
        Me.btn_purchase_summary_rp.Name = "btn_purchase_summary_rp"
        Me.btn_purchase_summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_purchase_summary_rp.TabIndex = 21
        Me.btn_purchase_summary_rp.Text = "Purchase Order Summary Report"
        Me.btn_purchase_summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_purchase_summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_purchase_summary_rp.UseVisualStyleBackColor = True
        '
        'btn_ap_credit_note_rp
        '
        Me.btn_ap_credit_note_rp.Enabled = False
        Me.btn_ap_credit_note_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_ap_credit_note_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_ap_credit_note_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ap_credit_note_rp.IconSize = 35
        Me.btn_ap_credit_note_rp.Location = New System.Drawing.Point(39, 429)
        Me.btn_ap_credit_note_rp.Name = "btn_ap_credit_note_rp"
        Me.btn_ap_credit_note_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_ap_credit_note_rp.TabIndex = 20
        Me.btn_ap_credit_note_rp.Text = "AP CREDIT NOTE REPORT"
        Me.btn_ap_credit_note_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ap_credit_note_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ap_credit_note_rp.UseVisualStyleBackColor = True
        '
        'btn_ap_invoice_rp
        '
        Me.btn_ap_invoice_rp.Enabled = False
        Me.btn_ap_invoice_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_ap_invoice_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_ap_invoice_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ap_invoice_rp.IconSize = 35
        Me.btn_ap_invoice_rp.Location = New System.Drawing.Point(39, 301)
        Me.btn_ap_invoice_rp.Name = "btn_ap_invoice_rp"
        Me.btn_ap_invoice_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_ap_invoice_rp.TabIndex = 18
        Me.btn_ap_invoice_rp.Text = "AP Invoice Report"
        Me.btn_ap_invoice_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ap_invoice_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ap_invoice_rp.UseVisualStyleBackColor = True
        '
        'btn_goods_receipt_rp
        '
        Me.btn_goods_receipt_rp.Enabled = False
        Me.btn_goods_receipt_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_goods_receipt_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_goods_receipt_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_goods_receipt_rp.IconSize = 35
        Me.btn_goods_receipt_rp.Location = New System.Drawing.Point(39, 168)
        Me.btn_goods_receipt_rp.Name = "btn_goods_receipt_rp"
        Me.btn_goods_receipt_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_goods_receipt_rp.TabIndex = 17
        Me.btn_goods_receipt_rp.Text = "Goods Receipt Report"
        Me.btn_goods_receipt_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_goods_receipt_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_goods_receipt_rp.UseVisualStyleBackColor = True
        '
        'btn_purchase_order_rp
        '
        Me.btn_purchase_order_rp.Enabled = False
        Me.btn_purchase_order_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_purchase_order_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_purchase_order_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_purchase_order_rp.IconSize = 35
        Me.btn_purchase_order_rp.Location = New System.Drawing.Point(39, 36)
        Me.btn_purchase_order_rp.Name = "btn_purchase_order_rp"
        Me.btn_purchase_order_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_purchase_order_rp.TabIndex = 16
        Me.btn_purchase_order_rp.Text = "Purchase Order Report"
        Me.btn_purchase_order_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_purchase_order_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_purchase_order_rp.UseVisualStyleBackColor = True
        '
        'frm_Purchase_Reports_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_Purchase_Reports_Mgt"
        Me.Text = "Purchase AP Reports"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_ap_credit_note_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ap_invoice_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_goods_receipt_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_purchase_order_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ap_cn_summary_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ap_inv_summary_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_good_receipt_summary_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_purchase_summary_rp As FontAwesome.Sharp.IconButton
End Class
