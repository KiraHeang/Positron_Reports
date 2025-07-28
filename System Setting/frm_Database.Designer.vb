<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Database))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.txt_LoginID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Database = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Server = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TitleBar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_MD.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_TitleBar
        '
        Me.Panel_TitleBar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel_TitleBar.Controls.Add(Me.btn_Exit)
        Me.Panel_TitleBar.Controls.Add(Me.Label4)
        Me.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TitleBar.Location = New System.Drawing.Point(1, 1)
        Me.Panel_TitleBar.Name = "Panel_TitleBar"
        Me.Panel_TitleBar.Size = New System.Drawing.Size(450, 35)
        Me.Panel_TitleBar.TabIndex = 1
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
        Me.btn_Exit.Location = New System.Drawing.Point(420, 2)
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
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Database Setup"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 234)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 50)
        Me.Panel2.TabIndex = 3
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(288, 15)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(207, 15)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel_MD.Controls.Add(Me.txt_LoginID)
        Me.Panel_MD.Controls.Add(Me.Label6)
        Me.Panel_MD.Controls.Add(Me.txt_Database)
        Me.Panel_MD.Controls.Add(Me.Label2)
        Me.Panel_MD.Controls.Add(Me.txt_Password)
        Me.Panel_MD.Controls.Add(Me.Label3)
        Me.Panel_MD.Controls.Add(Me.txt_Server)
        Me.Panel_MD.Controls.Add(Me.Label1)
        Me.Panel_MD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MD.Location = New System.Drawing.Point(1, 36)
        Me.Panel_MD.Name = "Panel_MD"
        Me.Panel_MD.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD.Size = New System.Drawing.Size(450, 198)
        Me.Panel_MD.TabIndex = 4
        '
        'txt_LoginID
        '
        Me.txt_LoginID.Location = New System.Drawing.Point(163, 54)
        Me.txt_LoginID.MaxLength = 60
        Me.txt_LoginID.Name = "txt_LoginID"
        Me.txt_LoginID.Size = New System.Drawing.Size(200, 20)
        Me.txt_LoginID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Database"
        '
        'txt_Database
        '
        Me.txt_Database.Location = New System.Drawing.Point(163, 132)
        Me.txt_Database.MaxLength = 60
        Me.txt_Database.Name = "txt_Database"
        Me.txt_Database.Size = New System.Drawing.Size(200, 20)
        Me.txt_Database.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Password"
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(163, 80)
        Me.txt_Password.MaxLength = 100
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_Password.Size = New System.Drawing.Size(200, 20)
        Me.txt_Password.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Login ID"
        '
        'txt_Server
        '
        Me.txt_Server.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Server.Location = New System.Drawing.Point(163, 28)
        Me.txt_Server.MaxLength = 40
        Me.txt_Server.Name = "txt_Server"
        Me.txt_Server.Size = New System.Drawing.Size(200, 20)
        Me.txt_Server.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Server"
        '
        'frm_Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 285)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Database"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Setup"
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
    Friend WithEvents btn_Save As Button
    Friend WithEvents Panel_MD As Panel
    Friend WithEvents txt_LoginID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Database As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Server As TextBox
    Friend WithEvents Label1 As Label
End Class
