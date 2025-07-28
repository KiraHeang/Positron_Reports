<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lb_UserLogIn = New System.Windows.Forms.Label()
        Me.Context_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_ChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_LogOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.lbFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Image_List = New System.Windows.Forms.ImageList(Me.components)
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_Buniess_Partner_Reports = New FontAwesome.Sharp.IconButton()
        Me.btn_banking_rp = New FontAwesome.Sharp.IconButton()
        Me.btn_Inventory_Report = New FontAwesome.Sharp.IconButton()
        Me.btn_Sale_Reports = New FontAwesome.Sharp.IconButton()
        Me.btn_Purchase_Reports = New FontAwesome.Sharp.IconButton()
        Me.btn_SystemMgt = New FontAwesome.Sharp.IconButton()
        Me.btn_UserMgt = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_Footer = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Tool_StripDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_StripVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelTitleBar.SuspendLayout()
        Me.Context_MenuStrip.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_Footer.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.lb_UserLogIn)
        Me.PanelTitleBar.Controls.Add(Me.IconPictureBox1)
        Me.PanelTitleBar.Controls.Add(Me.btn_Exit)
        Me.PanelTitleBar.Controls.Add(Me.btn_Maximize)
        Me.PanelTitleBar.Controls.Add(Me.btn_Minimize)
        Me.PanelTitleBar.Controls.Add(Me.lbFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(221, 1)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1062, 60)
        Me.PanelTitleBar.TabIndex = 2
        '
        'lb_UserLogIn
        '
        Me.lb_UserLogIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_UserLogIn.ContextMenuStrip = Me.Context_MenuStrip
        Me.lb_UserLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(100, Byte))
        Me.lb_UserLogIn.ForeColor = System.Drawing.SystemColors.Window
        Me.lb_UserLogIn.Location = New System.Drawing.Point(639, 21)
        Me.lb_UserLogIn.Name = "lb_UserLogIn"
        Me.lb_UserLogIn.Size = New System.Drawing.Size(300, 17)
        Me.lb_UserLogIn.TabIndex = 19
        Me.lb_UserLogIn.Text = "User ID : "
        Me.lb_UserLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Context_MenuStrip
        '
        Me.Context_MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Context_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ChangePassword, Me.btn_LogOff})
        Me.Context_MenuStrip.Name = "ContextMenuStrip1"
        Me.Context_MenuStrip.Size = New System.Drawing.Size(204, 56)
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.Image = CType(resources.GetObject("btn_ChangePassword.Image"), System.Drawing.Image)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(203, 26)
        Me.btn_ChangePassword.Text = "Change Password"
        '
        'btn_LogOff
        '
        Me.btn_LogOff.Image = CType(resources.GetObject("btn_LogOff.Image"), System.Drawing.Image)
        Me.btn_LogOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_LogOff.Name = "btn_LogOff"
        Me.btn_LogOff.Size = New System.Drawing.Size(203, 26)
        Me.btn_LogOff.Text = "Log Off"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.IconPictureBox1.ContextMenuStrip = Me.Context_MenuStrip
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.Window
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 25
        Me.IconPictureBox1.Location = New System.Drawing.Point(608, 18)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox1.TabIndex = 18
        Me.IconPictureBox1.TabStop = False
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
        Me.btn_Exit.Location = New System.Drawing.Point(1022, 11)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_Exit.TabIndex = 17
        Me.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Maximize
        '
        Me.btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximize.FlatAppearance.BorderSize = 0
        Me.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Maximize.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Maximize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btn_Maximize.IconColor = System.Drawing.SystemColors.Window
        Me.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Maximize.IconSize = 27
        Me.btn_Maximize.Location = New System.Drawing.Point(986, 11)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Size = New System.Drawing.Size(30, 30)
        Me.btn_Maximize.TabIndex = 16
        Me.btn_Maximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Maximize.UseVisualStyleBackColor = True
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.FlatAppearance.BorderSize = 0
        Me.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimize.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Minimize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btn_Minimize.IconColor = System.Drawing.SystemColors.Window
        Me.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Minimize.IconSize = 27
        Me.btn_Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Minimize.Location = New System.Drawing.Point(950, 11)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(30, 30)
        Me.btn_Minimize.TabIndex = 4
        Me.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Minimize.UseVisualStyleBackColor = True
        '
        'lbFormTitle
        '
        Me.lbFormTitle.AutoSize = True
        Me.lbFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbFormTitle.Location = New System.Drawing.Point(52, 22)
        Me.lbFormTitle.Name = "lbFormTitle"
        Me.lbFormTitle.Size = New System.Drawing.Size(48, 16)
        Me.lbFormTitle.TabIndex = 15
        Me.lbFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(14, 16)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 14
        Me.IconCurrentForm.TabStop = False
        '
        'Image_List
        '
        Me.Image_List.ImageStream = CType(resources.GetObject("Image_List.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image_List.TransparentColor = System.Drawing.Color.Transparent
        Me.Image_List.Images.SetKeyName(0, "btnMinimize.png")
        Me.Image_List.Images.SetKeyName(1, "btnMaximize.png")
        Me.Image_List.Images.SetKeyName(2, "btnExit.png")
        '
        'imgHome
        '
        Me.imgHome.BackgroundImage = CType(resources.GetObject("imgHome.BackgroundImage"), System.Drawing.Image)
        Me.imgHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgHome.InitialImage = CType(resources.GetObject("imgHome.InitialImage"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(48, 29)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(100, 100)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 13
        Me.imgHome.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_Buniess_Partner_Reports)
        Me.PanelMenu.Controls.Add(Me.btn_banking_rp)
        Me.PanelMenu.Controls.Add(Me.btn_Inventory_Report)
        Me.PanelMenu.Controls.Add(Me.btn_Sale_Reports)
        Me.PanelMenu.Controls.Add(Me.btn_Purchase_Reports)
        Me.PanelMenu.Controls.Add(Me.btn_SystemMgt)
        Me.PanelMenu.Controls.Add(Me.btn_UserMgt)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(1, 1)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 704)
        Me.PanelMenu.TabIndex = 1
        '
        'btn_Buniess_Partner_Reports
        '
        Me.btn_Buniess_Partner_Reports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Buniess_Partner_Reports.FlatAppearance.BorderSize = 0
        Me.btn_Buniess_Partner_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Buniess_Partner_Reports.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buniess_Partner_Reports.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Buniess_Partner_Reports.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btn_Buniess_Partner_Reports.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Buniess_Partner_Reports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Buniess_Partner_Reports.IconSize = 25
        Me.btn_Buniess_Partner_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buniess_Partner_Reports.Location = New System.Drawing.Point(0, 390)
        Me.btn_Buniess_Partner_Reports.Name = "btn_Buniess_Partner_Reports"
        Me.btn_Buniess_Partner_Reports.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_Buniess_Partner_Reports.Size = New System.Drawing.Size(220, 60)
        Me.btn_Buniess_Partner_Reports.TabIndex = 13
        Me.btn_Buniess_Partner_Reports.Text = "Business Partner"
        Me.btn_Buniess_Partner_Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buniess_Partner_Reports.UseVisualStyleBackColor = True
        '
        'btn_banking_rp
        '
        Me.btn_banking_rp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_banking_rp.FlatAppearance.BorderSize = 0
        Me.btn_banking_rp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_banking_rp.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_banking_rp.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_banking_rp.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btn_banking_rp.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_banking_rp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_banking_rp.IconSize = 25
        Me.btn_banking_rp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_banking_rp.Location = New System.Drawing.Point(0, 330)
        Me.btn_banking_rp.Name = "btn_banking_rp"
        Me.btn_banking_rp.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_banking_rp.Size = New System.Drawing.Size(220, 60)
        Me.btn_banking_rp.TabIndex = 12
        Me.btn_banking_rp.Text = "Banking"
        Me.btn_banking_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_banking_rp.UseVisualStyleBackColor = True
        '
        'btn_Inventory_Report
        '
        Me.btn_Inventory_Report.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Inventory_Report.FlatAppearance.BorderSize = 0
        Me.btn_Inventory_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Inventory_Report.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Inventory_Report.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Inventory_Report.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btn_Inventory_Report.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Inventory_Report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Inventory_Report.IconSize = 25
        Me.btn_Inventory_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Inventory_Report.Location = New System.Drawing.Point(0, 270)
        Me.btn_Inventory_Report.Name = "btn_Inventory_Report"
        Me.btn_Inventory_Report.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_Inventory_Report.Size = New System.Drawing.Size(220, 60)
        Me.btn_Inventory_Report.TabIndex = 11
        Me.btn_Inventory_Report.Text = "Inventory"
        Me.btn_Inventory_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Inventory_Report.UseVisualStyleBackColor = True
        '
        'btn_Sale_Reports
        '
        Me.btn_Sale_Reports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Sale_Reports.FlatAppearance.BorderSize = 0
        Me.btn_Sale_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Sale_Reports.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sale_Reports.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Sale_Reports.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btn_Sale_Reports.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Sale_Reports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Sale_Reports.IconSize = 25
        Me.btn_Sale_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Sale_Reports.Location = New System.Drawing.Point(0, 210)
        Me.btn_Sale_Reports.Name = "btn_Sale_Reports"
        Me.btn_Sale_Reports.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_Sale_Reports.Size = New System.Drawing.Size(220, 60)
        Me.btn_Sale_Reports.TabIndex = 3
        Me.btn_Sale_Reports.Text = "Sales - A/R"
        Me.btn_Sale_Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Sale_Reports.UseVisualStyleBackColor = True
        '
        'btn_Purchase_Reports
        '
        Me.btn_Purchase_Reports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Purchase_Reports.FlatAppearance.BorderSize = 0
        Me.btn_Purchase_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Purchase_Reports.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Purchase_Reports.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Purchase_Reports.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btn_Purchase_Reports.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Purchase_Reports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Purchase_Reports.IconSize = 25
        Me.btn_Purchase_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Purchase_Reports.Location = New System.Drawing.Point(0, 150)
        Me.btn_Purchase_Reports.Name = "btn_Purchase_Reports"
        Me.btn_Purchase_Reports.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_Purchase_Reports.Size = New System.Drawing.Size(220, 60)
        Me.btn_Purchase_Reports.TabIndex = 8
        Me.btn_Purchase_Reports.Text = "Purchase - AP"
        Me.btn_Purchase_Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Purchase_Reports.UseVisualStyleBackColor = True
        '
        'btn_SystemMgt
        '
        Me.btn_SystemMgt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_SystemMgt.FlatAppearance.BorderSize = 0
        Me.btn_SystemMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SystemMgt.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SystemMgt.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_SystemMgt.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.btn_SystemMgt.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_SystemMgt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_SystemMgt.IconSize = 25
        Me.btn_SystemMgt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SystemMgt.Location = New System.Drawing.Point(0, 584)
        Me.btn_SystemMgt.Name = "btn_SystemMgt"
        Me.btn_SystemMgt.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_SystemMgt.Size = New System.Drawing.Size(220, 60)
        Me.btn_SystemMgt.TabIndex = 10
        Me.btn_SystemMgt.Text = "System Setting"
        Me.btn_SystemMgt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_SystemMgt.UseVisualStyleBackColor = True
        '
        'btn_UserMgt
        '
        Me.btn_UserMgt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_UserMgt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_UserMgt.FlatAppearance.BorderSize = 0
        Me.btn_UserMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UserMgt.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UserMgt.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_UserMgt.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btn_UserMgt.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_UserMgt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_UserMgt.IconSize = 25
        Me.btn_UserMgt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_UserMgt.Location = New System.Drawing.Point(0, 644)
        Me.btn_UserMgt.Name = "btn_UserMgt"
        Me.btn_UserMgt.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_UserMgt.Size = New System.Drawing.Size(220, 60)
        Me.btn_UserMgt.TabIndex = 9
        Me.btn_UserMgt.Text = "User Management"
        Me.btn_UserMgt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_UserMgt.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.imgHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 150)
        Me.Panel1.TabIndex = 5
        '
        'Panel_Footer
        '
        Me.Panel_Footer.Controls.Add(Me.StatusStrip1)
        Me.Panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Footer.Location = New System.Drawing.Point(1, 705)
        Me.Panel_Footer.Name = "Panel_Footer"
        Me.Panel_Footer.Size = New System.Drawing.Size(1282, 23)
        Me.Panel_Footer.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_StripDB, Me.Tool_StripVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1282, 23)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Tool_StripDB
        '
        Me.Tool_StripDB.BackColor = System.Drawing.SystemColors.Control
        Me.Tool_StripDB.ForeColor = System.Drawing.SystemColors.Window
        Me.Tool_StripDB.Name = "Tool_StripDB"
        Me.Tool_StripDB.Size = New System.Drawing.Size(61, 18)
        Me.Tool_StripDB.Text = "Database: "
        '
        'Tool_StripVersion
        '
        Me.Tool_StripVersion.BackColor = System.Drawing.SystemColors.Control
        Me.Tool_StripVersion.ForeColor = System.Drawing.SystemColors.Window
        Me.Tool_StripVersion.Name = "Tool_StripVersion"
        Me.Tool_StripVersion.Size = New System.Drawing.Size(81, 18)
        Me.Tool_StripVersion.Text = "Version 1.0.0.1"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.SystemColors.Window
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(221, 61)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1062, 644)
        Me.PanelDesktop.TabIndex = 3
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1284, 729)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel_Footer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Positron Multiverse Co., Ltd"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        Me.Context_MenuStrip.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Footer.ResumeLayout(False)
        Me.Panel_Footer.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel_Footer As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents Image_List As ImageList
    Friend WithEvents btn_Sale_Reports As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Tool_StripDB As ToolStripStatusLabel
    Friend WithEvents Tool_StripVersion As ToolStripStatusLabel
    Friend WithEvents btn_SystemMgt As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_UserMgt As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Purchase_Reports As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents lb_UserLogIn As Label
    Friend WithEvents Context_MenuStrip As ContextMenuStrip
    Friend WithEvents btn_ChangePassword As ToolStripMenuItem
    Friend WithEvents btn_LogOff As ToolStripMenuItem
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btn_Inventory_Report As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_banking_rp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Buniess_Partner_Reports As FontAwesome.Sharp.IconButton
End Class
