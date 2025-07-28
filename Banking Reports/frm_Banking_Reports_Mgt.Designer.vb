<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Banking_Reports_Mgt
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
        Me.btn_outgoing_payment_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_incoming_payment_rp = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_outgoing_payment_rp)
        Me.Panel2.Controls.Add(Me.btn_incoming_payment_rp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1314, 782)
        Me.Panel2.TabIndex = 6
        '
        'btn_outgoing_payment_rp
        '
        Me.btn_outgoing_payment_rp.Enabled = False
        Me.btn_outgoing_payment_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_outgoing_payment_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_outgoing_payment_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_outgoing_payment_rp.IconSize = 35
        Me.btn_outgoing_payment_rp.Location = New System.Drawing.Point(39, 168)
        Me.btn_outgoing_payment_rp.Name = "btn_outgoing_payment_rp"
        Me.btn_outgoing_payment_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_outgoing_payment_rp.TabIndex = 17
        Me.btn_outgoing_payment_rp.Text = "Outgoing Payment"
        Me.btn_outgoing_payment_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_outgoing_payment_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_outgoing_payment_rp.UseVisualStyleBackColor = True
        '
        'btn_incoming_payment_rp
        '
        Me.btn_incoming_payment_rp.Enabled = False
        Me.btn_incoming_payment_rp.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_incoming_payment_rp.IconColor = System.Drawing.Color.SeaGreen
        Me.btn_incoming_payment_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_incoming_payment_rp.IconSize = 35
        Me.btn_incoming_payment_rp.Location = New System.Drawing.Point(39, 36)
        Me.btn_incoming_payment_rp.Name = "btn_incoming_payment_rp"
        Me.btn_incoming_payment_rp.Size = New System.Drawing.Size(172, 105)
        Me.btn_incoming_payment_rp.TabIndex = 16
        Me.btn_incoming_payment_rp.Text = "Incoming Payment"
        Me.btn_incoming_payment_rp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_incoming_payment_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_incoming_payment_rp.UseVisualStyleBackColor = True
        '
        'frm_Banking_Reports_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_Banking_Reports_Mgt"
        Me.Text = "Banking Repots"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_outgoing_payment_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_incoming_payment_rp As FontAwesome.Sharp.IconButton
End Class
