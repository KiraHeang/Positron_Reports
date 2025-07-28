<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_LogIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LogIN))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_LogIn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txt_UserID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblForgotPassword = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.btn_Exit)
        Me.Panel1.Controls.Add(Me.btn_LogIn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblForgotPassword)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(334, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 40, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(319, 359)
        Me.Panel1.TabIndex = 1
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Exit.BackgroundImage = CType(resources.GetObject("btn_Exit.BackgroundImage"), System.Drawing.Image)
        Me.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Location = New System.Drawing.Point(60, 243)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(200, 30)
        Me.btn_Exit.TabIndex = 13
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_LogIn
        '
        Me.btn_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_LogIn.BackColor = System.Drawing.Color.Transparent
        Me.btn_LogIn.BackgroundImage = CType(resources.GetObject("btn_LogIn.BackgroundImage"), System.Drawing.Image)
        Me.btn_LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_LogIn.FlatAppearance.BorderSize = 0
        Me.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LogIn.Location = New System.Drawing.Point(60, 207)
        Me.btn_LogIn.Name = "btn_LogIn"
        Me.btn_LogIn.Size = New System.Drawing.Size(200, 30)
        Me.btn_LogIn.TabIndex = 12
        Me.btn_LogIn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.lblPassword)
        Me.Panel3.Controls.Add(Me.txt_Password)
        Me.Panel3.Location = New System.Drawing.Point(60, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 30)
        Me.Panel3.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPassword.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblPassword.Location = New System.Drawing.Point(36, 8)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(139, 14)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txt_Password
        '
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Password.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(39, 7)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_Password.Size = New System.Drawing.Size(154, 15)
        Me.txt_Password.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.txt_UserID)
        Me.Panel2.Location = New System.Drawing.Point(60, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 30)
        Me.Panel2.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblUsername.Location = New System.Drawing.Point(36, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(157, 12)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'txt_UserID
        '
        Me.txt_UserID.BackColor = System.Drawing.SystemColors.Window
        Me.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_UserID.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UserID.Location = New System.Drawing.Point(39, 9)
        Me.txt_UserID.MaxLength = 15
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Size = New System.Drawing.Size(154, 12)
        Me.txt_UserID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "L O G I N"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblForgotPassword.AutoSize = True
        Me.lblForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPassword.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblForgotPassword.Location = New System.Drawing.Point(150, 171)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(110, 12)
        Me.lblForgotPassword.TabIndex = 10
        Me.lblForgotPassword.Text = "Forgot Password"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(653, 359)
        Me.Panel4.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(9, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "JNY Add On SAP B1 Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(77, 127)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(158, 122)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'frm_LogIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(655, 361)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_LogIN"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log IN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPassword As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents txt_UserID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblForgotPassword As Label
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_LogIn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
End Class
