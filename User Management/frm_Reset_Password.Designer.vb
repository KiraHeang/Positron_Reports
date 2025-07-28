<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reset_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reset_Password))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.cb_UseDefaultPassword = New System.Windows.Forms.CheckBox()
        Me.txt_ConfirmPass = New System.Windows.Forms.TextBox()
        Me.txt_NewPass = New System.Windows.Forms.TextBox()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_UserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TitleBar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_MD.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_TitleBar
        '
        Me.Panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel_TitleBar.Controls.Add(Me.btn_Exit)
        Me.Panel_TitleBar.Controls.Add(Me.Label4)
        Me.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TitleBar.Location = New System.Drawing.Point(1, 1)
        Me.Panel_TitleBar.Name = "Panel_TitleBar"
        Me.Panel_TitleBar.Size = New System.Drawing.Size(428, 35)
        Me.Panel_TitleBar.TabIndex = 0
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btn_Exit.IconColor = System.Drawing.SystemColors.Window
        Me.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Exit.IconSize = 27
        Me.btn_Exit.Location = New System.Drawing.Point(392, 4)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_Exit.TabIndex = 22
        Me.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(21, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reset Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_OK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(428, 50)
        Me.Panel2.TabIndex = 2
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(278, 15)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(53, 15)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_MD.Controls.Add(Me.cb_UseDefaultPassword)
        Me.Panel_MD.Controls.Add(Me.txt_ConfirmPass)
        Me.Panel_MD.Controls.Add(Me.txt_NewPass)
        Me.Panel_MD.Controls.Add(Me.txt_UserName)
        Me.Panel_MD.Controls.Add(Me.Label6)
        Me.Panel_MD.Controls.Add(Me.Label2)
        Me.Panel_MD.Controls.Add(Me.Label3)
        Me.Panel_MD.Controls.Add(Me.txt_UserID)
        Me.Panel_MD.Controls.Add(Me.Label1)
        Me.Panel_MD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MD.Location = New System.Drawing.Point(1, 36)
        Me.Panel_MD.Name = "Panel_MD"
        Me.Panel_MD.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD.Size = New System.Drawing.Size(428, 199)
        Me.Panel_MD.TabIndex = 1
        '
        'cb_UseDefaultPassword
        '
        Me.cb_UseDefaultPassword.AutoSize = True
        Me.cb_UseDefaultPassword.Location = New System.Drawing.Point(153, 85)
        Me.cb_UseDefaultPassword.Name = "cb_UseDefaultPassword"
        Me.cb_UseDefaultPassword.Size = New System.Drawing.Size(128, 17)
        Me.cb_UseDefaultPassword.TabIndex = 144
        Me.cb_UseDefaultPassword.Text = "Use default password"
        Me.cb_UseDefaultPassword.UseVisualStyleBackColor = True
        '
        'txt_ConfirmPass
        '
        Me.txt_ConfirmPass.Location = New System.Drawing.Point(153, 138)
        Me.txt_ConfirmPass.MaxLength = 60
        Me.txt_ConfirmPass.Name = "txt_ConfirmPass"
        Me.txt_ConfirmPass.Size = New System.Drawing.Size(200, 20)
        Me.txt_ConfirmPass.TabIndex = 1
        '
        'txt_NewPass
        '
        Me.txt_NewPass.Location = New System.Drawing.Point(153, 110)
        Me.txt_NewPass.MaxLength = 60
        Me.txt_NewPass.Name = "txt_NewPass"
        Me.txt_NewPass.Size = New System.Drawing.Size(200, 20)
        Me.txt_NewPass.TabIndex = 0
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(153, 28)
        Me.txt_UserName.MaxLength = 60
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.ReadOnly = True
        Me.txt_UserName.Size = New System.Drawing.Size(200, 20)
        Me.txt_UserName.TabIndex = 3
        Me.txt_UserName.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Confirm Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "New Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "User Name :"
        '
        'txt_UserID
        '
        Me.txt_UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_UserID.Location = New System.Drawing.Point(153, 56)
        Me.txt_UserID.MaxLength = 10
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.ReadOnly = True
        Me.txt_UserID.Size = New System.Drawing.Size(200, 20)
        Me.txt_UserID.TabIndex = 1
        Me.txt_UserID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "User ID :"
        '
        'frm_Reset_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 286)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Reset_Password"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reset Password"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_MD.ResumeLayout(False)
        Me.Panel_MD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_OK As Button
    Friend WithEvents Panel_MD As Panel
    Friend WithEvents txt_ConfirmPass As TextBox
    Friend WithEvents txt_NewPass As TextBox
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_UserID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_UseDefaultPassword As CheckBox
End Class
