<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_User_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_User_Edit))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_UserStatus = New System.Windows.Forms.ComboBox()
        Me.cmb_UserType = New System.Windows.Forms.ComboBox()
        Me.txt_JobTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_UserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Image_List = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_Dept = New System.Windows.Forms.TextBox()
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
        Me.Panel_TitleBar.Size = New System.Drawing.Size(658, 35)
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
        Me.btn_Exit.Location = New System.Drawing.Point(622, 2)
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
        Me.Label4.Text = "Modify User Info"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(658, 50)
        Me.Panel2.TabIndex = 3
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(504, 15)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(132, 15)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_MD.Controls.Add(Me.txt_Dept)
        Me.Panel_MD.Controls.Add(Me.Label5)
        Me.Panel_MD.Controls.Add(Me.cmb_UserStatus)
        Me.Panel_MD.Controls.Add(Me.cmb_UserType)
        Me.Panel_MD.Controls.Add(Me.txt_JobTitle)
        Me.Panel_MD.Controls.Add(Me.Label7)
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
        Me.Panel_MD.Size = New System.Drawing.Size(658, 238)
        Me.Panel_MD.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "User Status :"
        '
        'cmb_UserStatus
        '
        Me.cmb_UserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UserStatus.FormattingEnabled = True
        Me.cmb_UserStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmb_UserStatus.Location = New System.Drawing.Point(132, 60)
        Me.cmb_UserStatus.Name = "cmb_UserStatus"
        Me.cmb_UserStatus.Size = New System.Drawing.Size(150, 21)
        Me.cmb_UserStatus.TabIndex = 2
        '
        'cmb_UserType
        '
        Me.cmb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UserType.FormattingEnabled = True
        Me.cmb_UserType.Items.AddRange(New Object() {"User", "Administrator"})
        Me.cmb_UserType.Location = New System.Drawing.Point(132, 122)
        Me.cmb_UserType.Name = "cmb_UserType"
        Me.cmb_UserType.Size = New System.Drawing.Size(447, 21)
        Me.cmb_UserType.TabIndex = 4
        '
        'txt_JobTitle
        '
        Me.txt_JobTitle.Location = New System.Drawing.Point(132, 183)
        Me.txt_JobTitle.MaxLength = 60
        Me.txt_JobTitle.Name = "txt_JobTitle"
        Me.txt_JobTitle.Size = New System.Drawing.Size(447, 20)
        Me.txt_JobTitle.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Job Title :"
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(132, 94)
        Me.txt_UserName.MaxLength = 60
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(447, 20)
        Me.txt_UserName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Department :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "User Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "User Name :"
        '
        'txt_UserID
        '
        Me.txt_UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_UserID.Location = New System.Drawing.Point(132, 32)
        Me.txt_UserID.MaxLength = 10
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.ReadOnly = True
        Me.txt_UserID.Size = New System.Drawing.Size(150, 20)
        Me.txt_UserID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "User ID :"
        '
        'Image_List
        '
        Me.Image_List.ImageStream = CType(resources.GetObject("Image_List.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image_List.TransparentColor = System.Drawing.Color.Transparent
        Me.Image_List.Images.SetKeyName(0, "ieframe_31048.ico")
        '
        'txt_Dept
        '
        Me.txt_Dept.Location = New System.Drawing.Point(132, 151)
        Me.txt_Dept.MaxLength = 60
        Me.txt_Dept.Name = "txt_Dept"
        Me.txt_Dept.Size = New System.Drawing.Size(447, 20)
        Me.txt_Dept.TabIndex = 153
        '
        'frm_User_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 325)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_User_Edit"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Edit"
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
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_UserStatus As ComboBox
    Friend WithEvents cmb_UserType As ComboBox
    Friend WithEvents txt_JobTitle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_UserID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Image_List As ImageList
    Friend WithEvents txt_Dept As TextBox
End Class
