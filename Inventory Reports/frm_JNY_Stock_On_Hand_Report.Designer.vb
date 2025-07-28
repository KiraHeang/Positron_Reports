<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_JNY_Stock_On_Hand_Report
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_TItem = New FontAwesome.Sharp.IconButton()
        Me.txt_TtemCode = New System.Windows.Forms.TextBox()
        Me.btn_FItem = New FontAwesome.Sharp.IconButton()
        Me.txt_FItemCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_TDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.dtp_FDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_whs = New FontAwesome.Sharp.IconButton()
        Me.cmb_whs = New System.Windows.Forms.CheckBox()
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
        Me.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark
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
        Me.Label4.Size = New System.Drawing.Size(341, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "JNY STOCK ADJUSTMENT REPORT FOR SALE"
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
        Me.btn_ttype.Location = New System.Drawing.Point(708, 207)
        Me.btn_ttype.Name = "btn_ttype"
        Me.btn_ttype.Size = New System.Drawing.Size(27, 19)
        Me.btn_ttype.TabIndex = 343
        Me.btn_ttype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ttype.UseVisualStyleBackColor = False
        '
        'txt_ttype
        '
        Me.txt_ttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ttype.Location = New System.Drawing.Point(514, 205)
        Me.txt_ttype.Name = "txt_ttype"
        Me.txt_ttype.Size = New System.Drawing.Size(223, 24)
        Me.txt_ttype.TabIndex = 344
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
        Me.btn_ftype.Location = New System.Drawing.Point(414, 205)
        Me.btn_ftype.Name = "btn_ftype"
        Me.btn_ftype.Size = New System.Drawing.Size(27, 19)
        Me.btn_ftype.TabIndex = 341
        Me.btn_ftype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ftype.UseVisualStyleBackColor = False
        '
        'txt_ftype
        '
        Me.txt_ftype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ftype.Location = New System.Drawing.Point(220, 203)
        Me.txt_ftype.Name = "txt_ftype"
        Me.txt_ftype.Size = New System.Drawing.Size(223, 24)
        Me.txt_ftype.TabIndex = 342
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(472, 208)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 16)
        Me.Label24.TabIndex = 340
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
        Me.btn_tbrand.Location = New System.Drawing.Point(708, 163)
        Me.btn_tbrand.Name = "btn_tbrand"
        Me.btn_tbrand.Size = New System.Drawing.Size(27, 19)
        Me.btn_tbrand.TabIndex = 338
        Me.btn_tbrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_tbrand.UseVisualStyleBackColor = False
        '
        'txt_tbrand
        '
        Me.txt_tbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tbrand.Location = New System.Drawing.Point(514, 161)
        Me.txt_tbrand.Name = "txt_tbrand"
        Me.txt_tbrand.Size = New System.Drawing.Size(223, 24)
        Me.txt_tbrand.TabIndex = 339
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
        Me.btn_fbrand.Location = New System.Drawing.Point(414, 161)
        Me.btn_fbrand.Name = "btn_fbrand"
        Me.btn_fbrand.Size = New System.Drawing.Size(27, 19)
        Me.btn_fbrand.TabIndex = 336
        Me.btn_fbrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_fbrand.UseVisualStyleBackColor = False
        '
        'txt_fbrand
        '
        Me.txt_fbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fbrand.Location = New System.Drawing.Point(220, 159)
        Me.txt_fbrand.Name = "txt_fbrand"
        Me.txt_fbrand.Size = New System.Drawing.Size(223, 24)
        Me.txt_fbrand.TabIndex = 337
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(472, 164)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 16)
        Me.Label23.TabIndex = 335
        Me.Label23.Text = "TO :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(200, 256)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 21)
        Me.Label21.TabIndex = 329
        Me.Label21.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(201, 206)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 21)
        Me.Label20.TabIndex = 328
        Me.Label20.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(201, 161)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 21)
        Me.Label19.TabIndex = 327
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(200, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 21)
        Me.Label18.TabIndex = 326
        Me.Label18.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(200, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 21)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(471, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 324
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
        Me.btn_TItem.Location = New System.Drawing.Point(707, 255)
        Me.btn_TItem.Name = "btn_TItem"
        Me.btn_TItem.Size = New System.Drawing.Size(27, 19)
        Me.btn_TItem.TabIndex = 322
        Me.btn_TItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TItem.UseVisualStyleBackColor = False
        '
        'txt_TtemCode
        '
        Me.txt_TtemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TtemCode.Location = New System.Drawing.Point(513, 253)
        Me.txt_TtemCode.Name = "txt_TtemCode"
        Me.txt_TtemCode.Size = New System.Drawing.Size(223, 24)
        Me.txt_TtemCode.TabIndex = 323
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
        Me.btn_FItem.Location = New System.Drawing.Point(414, 255)
        Me.btn_FItem.Name = "btn_FItem"
        Me.btn_FItem.Size = New System.Drawing.Size(27, 19)
        Me.btn_FItem.TabIndex = 320
        Me.btn_FItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FItem.UseVisualStyleBackColor = False
        '
        'txt_FItemCode
        '
        Me.txt_FItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FItemCode.Location = New System.Drawing.Point(220, 253)
        Me.txt_FItemCode.Name = "txt_FItemCode"
        Me.txt_FItemCode.Size = New System.Drawing.Size(223, 24)
        Me.txt_FItemCode.TabIndex = 321
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(136, 16)
        Me.Label12.TabIndex = 319
        Me.Label12.Text = "FROM ITEM CODE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 318
        Me.Label11.Text = "FROM TYPE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 317
        Me.Label10.Text = "FROM BRAND"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 316
        Me.Label9.Text = "FROM WAREHOUSE"
        '
        'dtp_TDate
        '
        Me.dtp_TDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_TDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_TDate.Location = New System.Drawing.Point(513, 73)
        Me.dtp_TDate.Name = "dtp_TDate"
        Me.dtp_TDate.Size = New System.Drawing.Size(223, 23)
        Me.dtp_TDate.TabIndex = 315
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(471, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 314
        Me.Label2.Text = "TO :"
        '
        'btn_Preview
        '
        Me.btn_Preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Preview.AutoSize = True
        Me.btn_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Preview.Location = New System.Drawing.Point(907, 82)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(164, 42)
        Me.btn_Preview.TabIndex = 313
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = False
        '
        'dtp_FDate
        '
        Me.dtp_FDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_FDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FDate.Location = New System.Drawing.Point(220, 72)
        Me.dtp_FDate.Name = "dtp_FDate"
        Me.dtp_FDate.Size = New System.Drawing.Size(222, 23)
        Me.dtp_FDate.TabIndex = 312
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 311
        Me.Label1.Text = "FROM DATE"
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
        'btn_whs
        '
        Me.btn_whs.BackColor = System.Drawing.Color.Transparent
        Me.btn_whs.FlatAppearance.BorderSize = 0
        Me.btn_whs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_whs.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_whs.ForeColor = System.Drawing.Color.Black
        Me.btn_whs.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btn_whs.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_whs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_whs.IconSize = 23
        Me.btn_whs.Location = New System.Drawing.Point(248, 118)
        Me.btn_whs.Name = "btn_whs"
        Me.btn_whs.Size = New System.Drawing.Size(27, 19)
        Me.btn_whs.TabIndex = 346
        Me.btn_whs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_whs.UseVisualStyleBackColor = False
        '
        'cmb_whs
        '
        Me.cmb_whs.AutoSize = True
        Me.cmb_whs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_whs.Location = New System.Drawing.Point(219, 121)
        Me.cmb_whs.Name = "cmb_whs"
        Me.cmb_whs.Size = New System.Drawing.Size(15, 14)
        Me.cmb_whs.TabIndex = 345
        Me.cmb_whs.UseVisualStyleBackColor = True
        '
        'frm_JNY_Stock_On_Hand_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 301)
        Me.Controls.Add(Me.btn_whs)
        Me.Controls.Add(Me.cmb_whs)
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
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_TItem)
        Me.Controls.Add(Me.txt_TtemCode)
        Me.Controls.Add(Me.btn_FItem)
        Me.Controls.Add(Me.txt_FItemCode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtp_TDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Preview)
        Me.Controls.Add(Me.dtp_FDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Name = "frm_JNY_Stock_On_Hand_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_JNY_Stock_On_Hand_Report"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_TItem As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_TtemCode As TextBox
    Friend WithEvents btn_FItem As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_FItemCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp_TDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Preview As Button
    Friend WithEvents dtp_FDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_whs As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_whs As CheckBox
End Class
