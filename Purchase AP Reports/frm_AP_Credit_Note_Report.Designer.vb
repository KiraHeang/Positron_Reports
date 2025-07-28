<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AP_Credit_Note_Report
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
        Me.btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_ttype = New FontAwesome.Sharp.IconButton()
        Me.txt_ttype = New System.Windows.Forms.TextBox()
        Me.btn_ftype = New FontAwesome.Sharp.IconButton()
        Me.txt_ftype = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btn_tbrand = New FontAwesome.Sharp.IconButton()
        Me.txt_tbrand = New System.Windows.Forms.TextBox()
        Me.btn_fbrand = New FontAwesome.Sharp.IconButton()
        Me.txt_fbrand = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_twhs = New FontAwesome.Sharp.IconButton()
        Me.txt_twhs = New System.Windows.Forms.TextBox()
        Me.btn_fwhs = New FontAwesome.Sharp.IconButton()
        Me.txt_fwhs = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_saleman = New FontAwesome.Sharp.IconButton()
        Me.cmb_saleman = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_TItem = New FontAwesome.Sharp.IconButton()
        Me.txt_TItemCode = New System.Windows.Forms.TextBox()
        Me.btn_FItem = New FontAwesome.Sharp.IconButton()
        Me.txt_FItemCode = New System.Windows.Forms.TextBox()
        Me.btn_TVendor = New FontAwesome.Sharp.IconButton()
        Me.txt_TVendor = New System.Windows.Forms.TextBox()
        Me.btn_TGCus = New FontAwesome.Sharp.IconButton()
        Me.txt_TGCus = New System.Windows.Forms.TextBox()
        Me.btn_FVendor = New FontAwesome.Sharp.IconButton()
        Me.txt_FVendor = New System.Windows.Forms.TextBox()
        Me.btn_FGCus = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_FGCus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_TDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_FDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TitleBar.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_Maximize.Location = New System.Drawing.Point(1004, 4)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Size = New System.Drawing.Size(30, 30)
        Me.btn_Maximize.TabIndex = 28
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
        Me.btn_Minimize.Location = New System.Drawing.Point(967, 4)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(30, 30)
        Me.btn_Minimize.TabIndex = 27
        Me.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Minimize.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Remove
        Me.btn_Exit.IconColor = System.Drawing.SystemColors.Window
        Me.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Exit.IconSize = 27
        Me.btn_Exit.Location = New System.Drawing.Point(1040, 4)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(30, 30)
        Me.btn_Exit.TabIndex = 22
        Me.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(6, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "AP Credit Note Report"
        '
        'btn_Preview
        '
        Me.btn_Preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Preview.AutoSize = True
        Me.btn_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Preview.Location = New System.Drawing.Point(907, 65)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(164, 42)
        Me.btn_Preview.TabIndex = 314
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = False
        '
        'Panel_TitleBar
        '
        Me.Panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel_TitleBar.Controls.Add(Me.btn_Maximize)
        Me.Panel_TitleBar.Controls.Add(Me.btn_Minimize)
        Me.Panel_TitleBar.Controls.Add(Me.btn_Exit)
        Me.Panel_TitleBar.Controls.Add(Me.Label4)
        Me.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TitleBar.Name = "Panel_TitleBar"
        Me.Panel_TitleBar.Size = New System.Drawing.Size(1078, 41)
        Me.Panel_TitleBar.TabIndex = 310
        '
        'btn_ttype
        '
        Me.btn_ttype.BackColor = System.Drawing.Color.Transparent
        Me.btn_ttype.FlatAppearance.BorderSize = 0
        Me.btn_ttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ttype.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ttype.ForeColor = System.Drawing.Color.Black
        Me.btn_ttype.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_ttype.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_ttype.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ttype.IconSize = 23
        Me.btn_ttype.Location = New System.Drawing.Point(713, 259)
        Me.btn_ttype.Name = "btn_ttype"
        Me.btn_ttype.Size = New System.Drawing.Size(27, 19)
        Me.btn_ttype.TabIndex = 412
        Me.btn_ttype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ttype.UseVisualStyleBackColor = False
        '
        'txt_ttype
        '
        Me.txt_ttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ttype.Location = New System.Drawing.Point(519, 257)
        Me.txt_ttype.Name = "txt_ttype"
        Me.txt_ttype.Size = New System.Drawing.Size(223, 24)
        Me.txt_ttype.TabIndex = 413
        '
        'btn_ftype
        '
        Me.btn_ftype.BackColor = System.Drawing.Color.Transparent
        Me.btn_ftype.FlatAppearance.BorderSize = 0
        Me.btn_ftype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ftype.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ftype.ForeColor = System.Drawing.Color.Black
        Me.btn_ftype.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_ftype.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_ftype.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_ftype.IconSize = 23
        Me.btn_ftype.Location = New System.Drawing.Point(419, 257)
        Me.btn_ftype.Name = "btn_ftype"
        Me.btn_ftype.Size = New System.Drawing.Size(27, 19)
        Me.btn_ftype.TabIndex = 410
        Me.btn_ftype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ftype.UseVisualStyleBackColor = False
        '
        'txt_ftype
        '
        Me.txt_ftype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ftype.Location = New System.Drawing.Point(225, 255)
        Me.txt_ftype.Name = "txt_ftype"
        Me.txt_ftype.Size = New System.Drawing.Size(223, 24)
        Me.txt_ftype.TabIndex = 411
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(477, 260)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 16)
        Me.Label24.TabIndex = 409
        Me.Label24.Text = "TO :"
        '
        'btn_tbrand
        '
        Me.btn_tbrand.BackColor = System.Drawing.Color.Transparent
        Me.btn_tbrand.FlatAppearance.BorderSize = 0
        Me.btn_tbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tbrand.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tbrand.ForeColor = System.Drawing.Color.Black
        Me.btn_tbrand.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_tbrand.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_tbrand.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_tbrand.IconSize = 23
        Me.btn_tbrand.Location = New System.Drawing.Point(713, 221)
        Me.btn_tbrand.Name = "btn_tbrand"
        Me.btn_tbrand.Size = New System.Drawing.Size(27, 19)
        Me.btn_tbrand.TabIndex = 407
        Me.btn_tbrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_tbrand.UseVisualStyleBackColor = False
        '
        'txt_tbrand
        '
        Me.txt_tbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tbrand.Location = New System.Drawing.Point(519, 219)
        Me.txt_tbrand.Name = "txt_tbrand"
        Me.txt_tbrand.Size = New System.Drawing.Size(223, 24)
        Me.txt_tbrand.TabIndex = 408
        '
        'btn_fbrand
        '
        Me.btn_fbrand.BackColor = System.Drawing.Color.Transparent
        Me.btn_fbrand.FlatAppearance.BorderSize = 0
        Me.btn_fbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fbrand.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fbrand.ForeColor = System.Drawing.Color.Black
        Me.btn_fbrand.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_fbrand.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_fbrand.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_fbrand.IconSize = 23
        Me.btn_fbrand.Location = New System.Drawing.Point(419, 219)
        Me.btn_fbrand.Name = "btn_fbrand"
        Me.btn_fbrand.Size = New System.Drawing.Size(27, 19)
        Me.btn_fbrand.TabIndex = 405
        Me.btn_fbrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_fbrand.UseVisualStyleBackColor = False
        '
        'txt_fbrand
        '
        Me.txt_fbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fbrand.Location = New System.Drawing.Point(225, 217)
        Me.txt_fbrand.Name = "txt_fbrand"
        Me.txt_fbrand.Size = New System.Drawing.Size(223, 24)
        Me.txt_fbrand.TabIndex = 406
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(477, 222)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 16)
        Me.Label23.TabIndex = 404
        Me.Label23.Text = "TO :"
        '
        'btn_twhs
        '
        Me.btn_twhs.BackColor = System.Drawing.Color.Transparent
        Me.btn_twhs.FlatAppearance.BorderSize = 0
        Me.btn_twhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_twhs.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_twhs.ForeColor = System.Drawing.Color.Black
        Me.btn_twhs.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_twhs.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_twhs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_twhs.IconSize = 23
        Me.btn_twhs.Location = New System.Drawing.Point(713, 188)
        Me.btn_twhs.Name = "btn_twhs"
        Me.btn_twhs.Size = New System.Drawing.Size(27, 19)
        Me.btn_twhs.TabIndex = 402
        Me.btn_twhs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_twhs.UseVisualStyleBackColor = False
        '
        'txt_twhs
        '
        Me.txt_twhs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_twhs.Location = New System.Drawing.Point(519, 186)
        Me.txt_twhs.Name = "txt_twhs"
        Me.txt_twhs.Size = New System.Drawing.Size(223, 24)
        Me.txt_twhs.TabIndex = 403
        '
        'btn_fwhs
        '
        Me.btn_fwhs.BackColor = System.Drawing.Color.Transparent
        Me.btn_fwhs.FlatAppearance.BorderSize = 0
        Me.btn_fwhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fwhs.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fwhs.ForeColor = System.Drawing.Color.Black
        Me.btn_fwhs.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_fwhs.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_fwhs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_fwhs.IconSize = 23
        Me.btn_fwhs.Location = New System.Drawing.Point(419, 186)
        Me.btn_fwhs.Name = "btn_fwhs"
        Me.btn_fwhs.Size = New System.Drawing.Size(27, 19)
        Me.btn_fwhs.TabIndex = 400
        Me.btn_fwhs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_fwhs.UseVisualStyleBackColor = False
        '
        'txt_fwhs
        '
        Me.txt_fwhs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fwhs.Location = New System.Drawing.Point(225, 184)
        Me.txt_fwhs.Name = "txt_fwhs"
        Me.txt_fwhs.Size = New System.Drawing.Size(223, 24)
        Me.txt_fwhs.TabIndex = 401
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(477, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 16)
        Me.Label22.TabIndex = 399
        Me.Label22.Text = "TO :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(206, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 21)
        Me.Label21.TabIndex = 398
        Me.Label21.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(206, 252)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 21)
        Me.Label20.TabIndex = 397
        Me.Label20.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(206, 221)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 21)
        Me.Label19.TabIndex = 396
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(206, 187)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 21)
        Me.Label18.TabIndex = 395
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(206, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 21)
        Me.Label17.TabIndex = 394
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(206, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 21)
        Me.Label16.TabIndex = 393
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(206, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 21)
        Me.Label15.TabIndex = 392
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(206, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 21)
        Me.Label14.TabIndex = 391
        Me.Label14.Text = ":"
        '
        'btn_saleman
        '
        Me.btn_saleman.BackColor = System.Drawing.Color.Transparent
        Me.btn_saleman.FlatAppearance.BorderSize = 0
        Me.btn_saleman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saleman.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saleman.ForeColor = System.Drawing.Color.Black
        Me.btn_saleman.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btn_saleman.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_saleman.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_saleman.IconSize = 23
        Me.btn_saleman.Location = New System.Drawing.Point(336, 157)
        Me.btn_saleman.Name = "btn_saleman"
        Me.btn_saleman.Size = New System.Drawing.Size(27, 19)
        Me.btn_saleman.TabIndex = 390
        Me.btn_saleman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_saleman.UseVisualStyleBackColor = False
        '
        'cmb_saleman
        '
        Me.cmb_saleman.AutoSize = True
        Me.cmb_saleman.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_saleman.Location = New System.Drawing.Point(226, 160)
        Me.cmb_saleman.Name = "cmb_saleman"
        Me.cmb_saleman.Size = New System.Drawing.Size(15, 14)
        Me.cmb_saleman.TabIndex = 389
        Me.cmb_saleman.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(477, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 388
        Me.Label13.Text = "TO :"
        '
        'btn_TItem
        '
        Me.btn_TItem.BackColor = System.Drawing.Color.Transparent
        Me.btn_TItem.FlatAppearance.BorderSize = 0
        Me.btn_TItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TItem.ForeColor = System.Drawing.Color.Black
        Me.btn_TItem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_TItem.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_TItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_TItem.IconSize = 23
        Me.btn_TItem.Location = New System.Drawing.Point(713, 289)
        Me.btn_TItem.Name = "btn_TItem"
        Me.btn_TItem.Size = New System.Drawing.Size(27, 19)
        Me.btn_TItem.TabIndex = 386
        Me.btn_TItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TItem.UseVisualStyleBackColor = False
        '
        'txt_TItemCode
        '
        Me.txt_TItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TItemCode.Location = New System.Drawing.Point(519, 287)
        Me.txt_TItemCode.Name = "txt_TItemCode"
        Me.txt_TItemCode.Size = New System.Drawing.Size(223, 24)
        Me.txt_TItemCode.TabIndex = 387
        '
        'btn_FItem
        '
        Me.btn_FItem.BackColor = System.Drawing.Color.Transparent
        Me.btn_FItem.FlatAppearance.BorderSize = 0
        Me.btn_FItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FItem.ForeColor = System.Drawing.Color.Black
        Me.btn_FItem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_FItem.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_FItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_FItem.IconSize = 23
        Me.btn_FItem.Location = New System.Drawing.Point(420, 289)
        Me.btn_FItem.Name = "btn_FItem"
        Me.btn_FItem.Size = New System.Drawing.Size(27, 19)
        Me.btn_FItem.TabIndex = 384
        Me.btn_FItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FItem.UseVisualStyleBackColor = False
        '
        'txt_FItemCode
        '
        Me.txt_FItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FItemCode.Location = New System.Drawing.Point(226, 287)
        Me.txt_FItemCode.Name = "txt_FItemCode"
        Me.txt_FItemCode.Size = New System.Drawing.Size(223, 24)
        Me.txt_FItemCode.TabIndex = 385
        '
        'btn_TVendor
        '
        Me.btn_TVendor.BackColor = System.Drawing.Color.Transparent
        Me.btn_TVendor.FlatAppearance.BorderSize = 0
        Me.btn_TVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TVendor.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TVendor.ForeColor = System.Drawing.Color.Black
        Me.btn_TVendor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_TVendor.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_TVendor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_TVendor.IconSize = 23
        Me.btn_TVendor.Location = New System.Drawing.Point(713, 125)
        Me.btn_TVendor.Name = "btn_TVendor"
        Me.btn_TVendor.Size = New System.Drawing.Size(27, 19)
        Me.btn_TVendor.TabIndex = 382
        Me.btn_TVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TVendor.UseVisualStyleBackColor = False
        '
        'txt_TVendor
        '
        Me.txt_TVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TVendor.Location = New System.Drawing.Point(519, 123)
        Me.txt_TVendor.Name = "txt_TVendor"
        Me.txt_TVendor.Size = New System.Drawing.Size(223, 24)
        Me.txt_TVendor.TabIndex = 383
        '
        'btn_TGCus
        '
        Me.btn_TGCus.BackColor = System.Drawing.Color.Transparent
        Me.btn_TGCus.FlatAppearance.BorderSize = 0
        Me.btn_TGCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TGCus.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TGCus.ForeColor = System.Drawing.Color.Black
        Me.btn_TGCus.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_TGCus.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_TGCus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_TGCus.IconSize = 23
        Me.btn_TGCus.Location = New System.Drawing.Point(713, 90)
        Me.btn_TGCus.Name = "btn_TGCus"
        Me.btn_TGCus.Size = New System.Drawing.Size(27, 19)
        Me.btn_TGCus.TabIndex = 380
        Me.btn_TGCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TGCus.UseVisualStyleBackColor = False
        '
        'txt_TGCus
        '
        Me.txt_TGCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TGCus.Location = New System.Drawing.Point(519, 88)
        Me.txt_TGCus.Name = "txt_TGCus"
        Me.txt_TGCus.Size = New System.Drawing.Size(223, 24)
        Me.txt_TGCus.TabIndex = 381
        '
        'btn_FVendor
        '
        Me.btn_FVendor.BackColor = System.Drawing.Color.Transparent
        Me.btn_FVendor.FlatAppearance.BorderSize = 0
        Me.btn_FVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FVendor.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FVendor.ForeColor = System.Drawing.Color.Black
        Me.btn_FVendor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_FVendor.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_FVendor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_FVendor.IconSize = 23
        Me.btn_FVendor.Location = New System.Drawing.Point(419, 123)
        Me.btn_FVendor.Name = "btn_FVendor"
        Me.btn_FVendor.Size = New System.Drawing.Size(27, 19)
        Me.btn_FVendor.TabIndex = 378
        Me.btn_FVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FVendor.UseVisualStyleBackColor = False
        '
        'txt_FVendor
        '
        Me.txt_FVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FVendor.Location = New System.Drawing.Point(225, 121)
        Me.txt_FVendor.Name = "txt_FVendor"
        Me.txt_FVendor.Size = New System.Drawing.Size(223, 24)
        Me.txt_FVendor.TabIndex = 379
        '
        'btn_FGCus
        '
        Me.btn_FGCus.BackColor = System.Drawing.Color.Transparent
        Me.btn_FGCus.FlatAppearance.BorderSize = 0
        Me.btn_FGCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FGCus.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FGCus.ForeColor = System.Drawing.Color.Black
        Me.btn_FGCus.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_FGCus.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_FGCus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_FGCus.IconSize = 23
        Me.btn_FGCus.Location = New System.Drawing.Point(419, 90)
        Me.btn_FGCus.Name = "btn_FGCus"
        Me.btn_FGCus.Size = New System.Drawing.Size(27, 19)
        Me.btn_FGCus.TabIndex = 363
        Me.btn_FGCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FGCus.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(136, 16)
        Me.Label12.TabIndex = 377
        Me.Label12.Text = "FROM ITEM CODE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 376
        Me.Label11.Text = "FROM TYPE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 375
        Me.Label10.Text = "FROM BRAND"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 374
        Me.Label9.Text = "FROM WAREHOUSE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 373
        Me.Label8.Text = "BUYER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(477, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 372
        Me.Label7.Text = "TO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 371
        Me.Label6.Text = "FROM VENDOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 370
        Me.Label5.Text = "TO :"
        '
        'txt_FGCus
        '
        Me.txt_FGCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FGCus.Location = New System.Drawing.Point(225, 88)
        Me.txt_FGCus.Name = "txt_FGCus"
        Me.txt_FGCus.Size = New System.Drawing.Size(223, 24)
        Me.txt_FGCus.TabIndex = 369
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 16)
        Me.Label3.TabIndex = 368
        Me.Label3.Text = "FROM CUSTOMER GROUP "
        '
        'dtp_TDate
        '
        Me.dtp_TDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_TDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_TDate.Location = New System.Drawing.Point(519, 57)
        Me.dtp_TDate.Name = "dtp_TDate"
        Me.dtp_TDate.Size = New System.Drawing.Size(223, 23)
        Me.dtp_TDate.TabIndex = 367
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(477, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 366
        Me.Label2.Text = "TO :"
        '
        'dtp_FDate
        '
        Me.dtp_FDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_FDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FDate.Location = New System.Drawing.Point(226, 56)
        Me.dtp_FDate.Name = "dtp_FDate"
        Me.dtp_FDate.Size = New System.Drawing.Size(222, 23)
        Me.dtp_FDate.TabIndex = 365
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 364
        Me.Label1.Text = "FROM DATE"
        '
        'frm_AP_Credit_Note_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 327)
        Me.Controls.Add(Me.btn_ttype)
        Me.Controls.Add(Me.txt_ttype)
        Me.Controls.Add(Me.btn_ftype)
        Me.Controls.Add(Me.txt_ftype)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btn_tbrand)
        Me.Controls.Add(Me.txt_tbrand)
        Me.Controls.Add(Me.btn_fbrand)
        Me.Controls.Add(Me.txt_fbrand)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btn_twhs)
        Me.Controls.Add(Me.txt_twhs)
        Me.Controls.Add(Me.btn_fwhs)
        Me.Controls.Add(Me.txt_fwhs)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_saleman)
        Me.Controls.Add(Me.cmb_saleman)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_TItem)
        Me.Controls.Add(Me.txt_TItemCode)
        Me.Controls.Add(Me.btn_FItem)
        Me.Controls.Add(Me.txt_FItemCode)
        Me.Controls.Add(Me.btn_TVendor)
        Me.Controls.Add(Me.txt_TVendor)
        Me.Controls.Add(Me.btn_TGCus)
        Me.Controls.Add(Me.txt_TGCus)
        Me.Controls.Add(Me.btn_FVendor)
        Me.Controls.Add(Me.txt_FVendor)
        Me.Controls.Add(Me.btn_FGCus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_FGCus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_TDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_FDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Preview)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Name = "frm_AP_Credit_Note_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_AP_Credit_Note_Report"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Preview As Button
    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_ttype As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_ttype As TextBox
    Friend WithEvents btn_ftype As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_ftype As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btn_tbrand As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_tbrand As TextBox
    Friend WithEvents btn_fbrand As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_fbrand As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btn_twhs As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_twhs As TextBox
    Friend WithEvents btn_fwhs As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_fwhs As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_saleman As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_saleman As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_TItem As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_TItemCode As TextBox
    Friend WithEvents btn_FItem As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_FItemCode As TextBox
    Friend WithEvents btn_TVendor As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_TVendor As TextBox
    Friend WithEvents btn_TGCus As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_TGCus As TextBox
    Friend WithEvents btn_FVendor As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_FVendor As TextBox
    Friend WithEvents btn_FGCus As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_FGCus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_TDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_FDate As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
