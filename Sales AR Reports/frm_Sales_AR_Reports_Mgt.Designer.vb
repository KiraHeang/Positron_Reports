<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Sales_AR_Reports_Mgt
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
        Me.btn_credit_note_summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_AR_Invoice_Summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_delivery_summary_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_Sales_Order_Summary_Report = New FontAwesome.Sharp.IconButton()
        Me.btn_jny_order_report = New FontAwesome.Sharp.IconButton()
        Me.btn_ar_credit_meo = New FontAwesome.Sharp.IconButton()
        Me.btn_ar_invoice_report = New FontAwesome.Sharp.IconButton()
        Me.btn_delivery_report = New FontAwesome.Sharp.IconButton()
        Me.btn_sales_order_report = New FontAwesome.Sharp.IconButton()
        Me.btn_outstanding_report = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_credit_note_summary_rp)
        Me.Panel2.Controls.Add(Me.btn_AR_Invoice_Summary_rp)
        Me.Panel2.Controls.Add(Me.btn_delivery_summary_rp)
        Me.Panel2.Controls.Add(Me.btn_Sales_Order_Summary_Report)
        Me.Panel2.Controls.Add(Me.btn_jny_order_report)
        Me.Panel2.Controls.Add(Me.btn_ar_credit_meo)
        Me.Panel2.Controls.Add(Me.btn_ar_invoice_report)
        Me.Panel2.Controls.Add(Me.btn_delivery_report)
        Me.Panel2.Controls.Add(Me.btn_sales_order_report)
        Me.Panel2.Controls.Add(Me.btn_outstanding_report)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 782)
        Me.Panel2.TabIndex = 3
        '
        'btn_credit_note_summary_rp
        '
        Me.btn_credit_note_summary_rp.Enabled = False
        Me.btn_credit_note_summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_credit_note_summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_credit_note_summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_credit_note_summary_rp.IconSize = 35
        Me.btn_credit_note_summary_rp.Location = New System.Drawing.Point(240, 550)
        Me.btn_credit_note_summary_rp.Name = "btn_credit_note_summary_rp"
        Me.btn_credit_note_summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_credit_note_summary_rp.TabIndex = 25
        Me.btn_credit_note_summary_rp.Text = "AR Credit Meo Summary Report"
        Me.btn_credit_note_summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_credit_note_summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_credit_note_summary_rp.UseVisualStyleBackColor = True
        '
        'btn_AR_Invoice_Summary_rp
        '
        Me.btn_AR_Invoice_Summary_rp.Enabled = False
        Me.btn_AR_Invoice_Summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_AR_Invoice_Summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_AR_Invoice_Summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_AR_Invoice_Summary_rp.IconSize = 35
        Me.btn_AR_Invoice_Summary_rp.Location = New System.Drawing.Point(240, 417)
        Me.btn_AR_Invoice_Summary_rp.Name = "btn_AR_Invoice_Summary_rp"
        Me.btn_AR_Invoice_Summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_AR_Invoice_Summary_rp.TabIndex = 24
        Me.btn_AR_Invoice_Summary_rp.Text = "AR Invoice Summary Report"
        Me.btn_AR_Invoice_Summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_AR_Invoice_Summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_AR_Invoice_Summary_rp.UseVisualStyleBackColor = True
        '
        'btn_delivery_summary_rp
        '
        Me.btn_delivery_summary_rp.Enabled = False
        Me.btn_delivery_summary_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_delivery_summary_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_delivery_summary_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_delivery_summary_rp.IconSize = 35
        Me.btn_delivery_summary_rp.Location = New System.Drawing.Point(240, 287)
        Me.btn_delivery_summary_rp.Name = "btn_delivery_summary_rp"
        Me.btn_delivery_summary_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_delivery_summary_rp.TabIndex = 23
        Me.btn_delivery_summary_rp.Text = "Delivery Summary Report"
        Me.btn_delivery_summary_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delivery_summary_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_delivery_summary_rp.UseVisualStyleBackColor = True
        '
        'btn_Sales_Order_Summary_Report
        '
        Me.btn_Sales_Order_Summary_Report.Enabled = False
        Me.btn_Sales_Order_Summary_Report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_Sales_Order_Summary_Report.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_Sales_Order_Summary_Report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Sales_Order_Summary_Report.IconSize = 35
        Me.btn_Sales_Order_Summary_Report.Location = New System.Drawing.Point(240, 154)
        Me.btn_Sales_Order_Summary_Report.Name = "btn_Sales_Order_Summary_Report"
        Me.btn_Sales_Order_Summary_Report.Size = New System.Drawing.Size(172, 105)
        Me.btn_Sales_Order_Summary_Report.TabIndex = 22
        Me.btn_Sales_Order_Summary_Report.Text = "Sales Oder Summary Report"
        Me.btn_Sales_Order_Summary_Report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Sales_Order_Summary_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Sales_Order_Summary_Report.UseVisualStyleBackColor = True
        '
        'btn_jny_order_report
        '
        Me.btn_jny_order_report.Enabled = False
        Me.btn_jny_order_report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_jny_order_report.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_jny_order_report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_jny_order_report.IconSize = 35
        Me.btn_jny_order_report.Location = New System.Drawing.Point(240, 22)
        Me.btn_jny_order_report.Name = "btn_jny_order_report"
        Me.btn_jny_order_report.Size = New System.Drawing.Size(172, 105)
        Me.btn_jny_order_report.TabIndex = 21
        Me.btn_jny_order_report.Text = "JNY Sales Order Report"
        Me.btn_jny_order_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_jny_order_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_jny_order_report.UseVisualStyleBackColor = True
        '
        'btn_ar_credit_meo
        '
        Me.btn_ar_credit_meo.Enabled = False
        Me.btn_ar_credit_meo.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_ar_credit_meo.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_ar_credit_meo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ar_credit_meo.IconSize = 35
        Me.btn_ar_credit_meo.Location = New System.Drawing.Point(31, 550)
        Me.btn_ar_credit_meo.Name = "btn_ar_credit_meo"
        Me.btn_ar_credit_meo.Size = New System.Drawing.Size(172, 105)
        Me.btn_ar_credit_meo.TabIndex = 20
        Me.btn_ar_credit_meo.Text = "AR Credit Meo Report"
        Me.btn_ar_credit_meo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ar_credit_meo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ar_credit_meo.UseVisualStyleBackColor = True
        '
        'btn_ar_invoice_report
        '
        Me.btn_ar_invoice_report.Enabled = False
        Me.btn_ar_invoice_report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_ar_invoice_report.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_ar_invoice_report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ar_invoice_report.IconSize = 35
        Me.btn_ar_invoice_report.Location = New System.Drawing.Point(31, 417)
        Me.btn_ar_invoice_report.Name = "btn_ar_invoice_report"
        Me.btn_ar_invoice_report.Size = New System.Drawing.Size(172, 105)
        Me.btn_ar_invoice_report.TabIndex = 19
        Me.btn_ar_invoice_report.Text = "AR Invoice Report"
        Me.btn_ar_invoice_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ar_invoice_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_ar_invoice_report.UseVisualStyleBackColor = True
        '
        'btn_delivery_report
        '
        Me.btn_delivery_report.Enabled = False
        Me.btn_delivery_report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_delivery_report.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_delivery_report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_delivery_report.IconSize = 35
        Me.btn_delivery_report.Location = New System.Drawing.Point(31, 287)
        Me.btn_delivery_report.Name = "btn_delivery_report"
        Me.btn_delivery_report.Size = New System.Drawing.Size(172, 105)
        Me.btn_delivery_report.TabIndex = 18
        Me.btn_delivery_report.Text = "Delivery Report"
        Me.btn_delivery_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delivery_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_delivery_report.UseVisualStyleBackColor = True
        '
        'btn_sales_order_report
        '
        Me.btn_sales_order_report.Enabled = False
        Me.btn_sales_order_report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_sales_order_report.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_sales_order_report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sales_order_report.IconSize = 35
        Me.btn_sales_order_report.Location = New System.Drawing.Point(31, 154)
        Me.btn_sales_order_report.Name = "btn_sales_order_report"
        Me.btn_sales_order_report.Size = New System.Drawing.Size(172, 105)
        Me.btn_sales_order_report.TabIndex = 17
        Me.btn_sales_order_report.Text = "Sales Oder Report"
        Me.btn_sales_order_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_sales_order_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_sales_order_report.UseVisualStyleBackColor = True
        '
        'btn_outstanding_report
        '
        Me.btn_outstanding_report.Enabled = False
        Me.btn_outstanding_report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_outstanding_report.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_outstanding_report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_outstanding_report.IconSize = 35
        Me.btn_outstanding_report.Location = New System.Drawing.Point(31, 22)
        Me.btn_outstanding_report.Name = "btn_outstanding_report"
        Me.btn_outstanding_report.Size = New System.Drawing.Size(172, 105)
        Me.btn_outstanding_report.TabIndex = 16
        Me.btn_outstanding_report.Text = "Outstanding Report"
        Me.btn_outstanding_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_outstanding_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_outstanding_report.UseVisualStyleBackColor = True
        '
        'frm_Sales_AR_Reports_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_Sales_AR_Reports_Mgt"
        Me.Text = "Sales AR Reports"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_outstanding_report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sales_order_report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delivery_report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ar_credit_meo As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_ar_invoice_report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_jny_order_report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Sales_Order_Summary_Report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delivery_summary_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_AR_Invoice_Summary_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_credit_note_summary_rp As FontAwesome.Sharp.IconButton
End Class
