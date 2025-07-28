<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Business_Partner_Mgt
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
        Me.btn_business_partner_reports = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_business_partner_reports)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 782)
        Me.Panel2.TabIndex = 6
        '
        'btn_business_partner_reports
        '
        Me.btn_business_partner_reports.Enabled = False
        Me.btn_business_partner_reports.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_business_partner_reports.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_business_partner_reports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_business_partner_reports.IconSize = 35
        Me.btn_business_partner_reports.Location = New System.Drawing.Point(39, 36)
        Me.btn_business_partner_reports.Name = "btn_business_partner_reports"
        Me.btn_business_partner_reports.Size = New System.Drawing.Size(172, 105)
        Me.btn_business_partner_reports.TabIndex = 16
        Me.btn_business_partner_reports.Text = "Business Partner Report"
        Me.btn_business_partner_reports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_business_partner_reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_business_partner_reports.UseVisualStyleBackColor = True
        '
        'frm_Business_Partner_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_Business_Partner_Mgt"
        Me.Text = "frm_Business_Partner_Mgt"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_business_partner_reports As FontAwesome.Sharp.IconButton
End Class
