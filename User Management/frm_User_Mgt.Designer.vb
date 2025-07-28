<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_User_Mgt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_User_Mgt))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_UserID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btn_Export = New FontAwesome.Sharp.IconButton()
        Me.btn_New = New FontAwesome.Sharp.IconButton()
        Me.btn_Query = New FontAwesome.Sharp.IconButton()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.dg_User = New System.Windows.Forms.DataGridView()
        Me.User_ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.User_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.User_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Job_Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.User_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResetPassword = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Permission = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.PanelHeader.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        CType(Me.dg_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.txt_UserName)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Controls.Add(Me.txt_UserID)
        Me.PanelHeader.Controls.Add(Me.Label4)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(5, 5)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1334, 80)
        Me.PanelHeader.TabIndex = 2
        '
        'txt_UserName
        '
        Me.txt_UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_UserName.Location = New System.Drawing.Point(448, 31)
        Me.txt_UserName.MaxLength = 15
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(300, 20)
        Me.txt_UserName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(376, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "User Name :"
        '
        'txt_UserID
        '
        Me.txt_UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_UserID.Location = New System.Drawing.Point(128, 31)
        Me.txt_UserID.MaxLength = 15
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Size = New System.Drawing.Size(150, 20)
        Me.txt_UserID.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "User ID :"
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.PanelButton.Controls.Add(Me.btn_Export)
        Me.PanelButton.Controls.Add(Me.btn_New)
        Me.PanelButton.Controls.Add(Me.btn_Query)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(5, 85)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Padding = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.PanelButton.Size = New System.Drawing.Size(1334, 40)
        Me.PanelButton.TabIndex = 3
        '
        'btn_Export
        '
        Me.btn_Export.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Export.FlatAppearance.BorderSize = 0
        Me.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Export.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Export.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Export.IconChar = FontAwesome.Sharp.IconChar.FileText
        Me.btn_Export.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Export.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Export.IconSize = 25
        Me.btn_Export.Location = New System.Drawing.Point(914, 5)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(130, 30)
        Me.btn_Export.TabIndex = 0
        Me.btn_Export.Text = "Exports"
        Me.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Export.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_New.FlatAppearance.BorderSize = 0
        Me.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_New.IconChar = FontAwesome.Sharp.IconChar.FileText
        Me.btn_New.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_New.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_New.IconSize = 25
        Me.btn_New.Location = New System.Drawing.Point(1044, 5)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(130, 30)
        Me.btn_New.TabIndex = 5
        Me.btn_New.Text = "New"
        Me.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Query
        '
        Me.btn_Query.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Query.FlatAppearance.BorderSize = 0
        Me.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Query.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Query.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_Query.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Query.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Query.IconSize = 25
        Me.btn_Query.Location = New System.Drawing.Point(1174, 5)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(130, 30)
        Me.btn_Query.TabIndex = 4
        Me.btn_Query.Text = "Query"
        Me.btn_Query.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Query.UseVisualStyleBackColor = True
        '
        'PanelFooter
        '
        Me.PanelFooter.Controls.Add(Me.dg_User)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFooter.Location = New System.Drawing.Point(5, 125)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelFooter.Size = New System.Drawing.Size(1334, 599)
        Me.PanelFooter.TabIndex = 4
        '
        'dg_User
        '
        Me.dg_User.AllowUserToAddRows = False
        Me.dg_User.AllowUserToDeleteRows = False
        Me.dg_User.AllowUserToResizeRows = False
        Me.dg_User.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_User.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_User.ColumnHeadersHeight = 40
        Me.dg_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_User.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User_ID, Me.User_Name, Me.User_Type, Me.Department, Me.Job_Title, Me.User_Status, Me.ResetPassword, Me.Permission})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_User.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg_User.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_User.EnableHeadersVisualStyles = False
        Me.dg_User.Location = New System.Drawing.Point(10, 10)
        Me.dg_User.Name = "dg_User"
        Me.dg_User.ReadOnly = True
        Me.dg_User.RowHeadersVisible = False
        Me.dg_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_User.Size = New System.Drawing.Size(1314, 579)
        Me.dg_User.TabIndex = 0
        '
        'User_ID
        '
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.User_ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.User_ID.HeaderText = "User ID"
        Me.User_ID.Name = "User_ID"
        Me.User_ID.ReadOnly = True
        Me.User_ID.Width = 150
        '
        'User_Name
        '
        Me.User_Name.HeaderText = "User Name"
        Me.User_Name.Name = "User_Name"
        Me.User_Name.ReadOnly = True
        Me.User_Name.Width = 250
        '
        'User_Type
        '
        Me.User_Type.HeaderText = "User Type"
        Me.User_Type.Name = "User_Type"
        Me.User_Type.ReadOnly = True
        Me.User_Type.Width = 150
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.Width = 200
        '
        'Job_Title
        '
        Me.Job_Title.HeaderText = "Job Title"
        Me.Job_Title.Name = "Job_Title"
        Me.Job_Title.ReadOnly = True
        Me.Job_Title.Width = 150
        '
        'User_Status
        '
        Me.User_Status.HeaderText = "Status"
        Me.User_Status.Name = "User_Status"
        Me.User_Status.ReadOnly = True
        Me.User_Status.Width = 150
        '
        'ResetPassword
        '
        Me.ResetPassword.HeaderText = "Reset Password"
        Me.ResetPassword.Name = "ResetPassword"
        Me.ResetPassword.ReadOnly = True
        Me.ResetPassword.Width = 120
        '
        'Permission
        '
        Me.Permission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Permission.DefaultCellStyle = DataGridViewCellStyle3
        Me.Permission.HeaderText = "Permission"
        Me.Permission.Name = "Permission"
        Me.Permission.ReadOnly = True
        '
        'frm_User_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_User_Mgt"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "User Mgt"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        CType(Me.dg_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_UserID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btn_Export As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Query As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents dg_User As DataGridView
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents btn_New As FontAwesome.Sharp.IconButton
    Friend WithEvents User_ID As DataGridViewLinkColumn
    Friend WithEvents User_Name As DataGridViewTextBoxColumn
    Friend WithEvents User_Type As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Job_Title As DataGridViewTextBoxColumn
    Friend WithEvents User_Status As DataGridViewTextBoxColumn
    Friend WithEvents ResetPassword As DataGridViewLinkColumn
    Friend WithEvents Permission As DataGridViewLinkColumn
End Class
