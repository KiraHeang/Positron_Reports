<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Outstdaning_Report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Outstdaning_Report))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_saleman = New FontAwesome.Sharp.IconButton()
        Me.cmb_saleman = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_FDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_TCus = New FontAwesome.Sharp.IconButton()
        Me.txt_TCus = New System.Windows.Forms.TextBox()
        Me.btn_FCus = New FontAwesome.Sharp.IconButton()
        Me.txt_FCus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.dg_Items = New System.Windows.Forms.DataGridView()
        Me.Image_List = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel_TitleBar.SuspendLayout()
        Me.Panel_MD.SuspendLayout()
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel_TitleBar.Size = New System.Drawing.Size(1160, 41)
        Me.Panel_TitleBar.TabIndex = 3
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
        Me.btn_Maximize.Location = New System.Drawing.Point(1086, 4)
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
        Me.btn_Minimize.Location = New System.Drawing.Point(1049, 4)
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
        Me.btn_Exit.Location = New System.Drawing.Point(1122, 4)
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
        Me.Label4.Location = New System.Drawing.Point(21, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Outstanding Report"
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_MD.Controls.Add(Me.Label17)
        Me.Panel_MD.Controls.Add(Me.btn_saleman)
        Me.Panel_MD.Controls.Add(Me.cmb_saleman)
        Me.Panel_MD.Controls.Add(Me.Label8)
        Me.Panel_MD.Controls.Add(Me.Label14)
        Me.Panel_MD.Controls.Add(Me.dtp_FDate)
        Me.Panel_MD.Controls.Add(Me.Label2)
        Me.Panel_MD.Controls.Add(Me.Label16)
        Me.Panel_MD.Controls.Add(Me.btn_TCus)
        Me.Panel_MD.Controls.Add(Me.txt_TCus)
        Me.Panel_MD.Controls.Add(Me.btn_FCus)
        Me.Panel_MD.Controls.Add(Me.txt_FCus)
        Me.Panel_MD.Controls.Add(Me.Label7)
        Me.Panel_MD.Controls.Add(Me.Label6)
        Me.Panel_MD.Controls.Add(Me.btn_Preview)
        Me.Panel_MD.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_MD.Location = New System.Drawing.Point(0, 41)
        Me.Panel_MD.Name = "Panel_MD"
        Me.Panel_MD.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD.Size = New System.Drawing.Size(1160, 195)
        Me.Panel_MD.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(223, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 21)
        Me.Label17.TabIndex = 207
        Me.Label17.Text = ":"
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
        Me.btn_saleman.Location = New System.Drawing.Point(332, 120)
        Me.btn_saleman.Name = "btn_saleman"
        Me.btn_saleman.Size = New System.Drawing.Size(42, 19)
        Me.btn_saleman.TabIndex = 206
        Me.btn_saleman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_saleman.UseVisualStyleBackColor = False
        '
        'cmb_saleman
        '
        Me.cmb_saleman.AutoSize = True
        Me.cmb_saleman.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_saleman.Location = New System.Drawing.Point(243, 121)
        Me.cmb_saleman.Name = "cmb_saleman"
        Me.cmb_saleman.Size = New System.Drawing.Size(15, 14)
        Me.cmb_saleman.TabIndex = 205
        Me.cmb_saleman.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 204
        Me.Label8.Text = "SALEMAN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(223, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 21)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = ":"
        '
        'dtp_FDate
        '
        Me.dtp_FDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_FDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FDate.Location = New System.Drawing.Point(243, 25)
        Me.dtp_FDate.Name = "dtp_FDate"
        Me.dtp_FDate.Size = New System.Drawing.Size(222, 23)
        Me.dtp_FDate.TabIndex = 202
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "FROM DATE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(223, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 21)
        Me.Label16.TabIndex = 200
        Me.Label16.Text = ":"
        '
        'btn_TCus
        '
        Me.btn_TCus.BackColor = System.Drawing.Color.Transparent
        Me.btn_TCus.FlatAppearance.BorderSize = 0
        Me.btn_TCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TCus.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TCus.ForeColor = System.Drawing.Color.Black
        Me.btn_TCus.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_TCus.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_TCus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_TCus.IconSize = 23
        Me.btn_TCus.Location = New System.Drawing.Point(730, 77)
        Me.btn_TCus.Name = "btn_TCus"
        Me.btn_TCus.Size = New System.Drawing.Size(27, 19)
        Me.btn_TCus.TabIndex = 198
        Me.btn_TCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TCus.UseVisualStyleBackColor = False
        '
        'txt_TCus
        '
        Me.txt_TCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TCus.Location = New System.Drawing.Point(536, 75)
        Me.txt_TCus.Name = "txt_TCus"
        Me.txt_TCus.Size = New System.Drawing.Size(223, 24)
        Me.txt_TCus.TabIndex = 199
        '
        'btn_FCus
        '
        Me.btn_FCus.BackColor = System.Drawing.Color.Transparent
        Me.btn_FCus.FlatAppearance.BorderSize = 0
        Me.btn_FCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FCus.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FCus.ForeColor = System.Drawing.Color.Black
        Me.btn_FCus.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_FCus.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_FCus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_FCus.IconSize = 23
        Me.btn_FCus.Location = New System.Drawing.Point(436, 75)
        Me.btn_FCus.Name = "btn_FCus"
        Me.btn_FCus.Size = New System.Drawing.Size(27, 19)
        Me.btn_FCus.TabIndex = 196
        Me.btn_FCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FCus.UseVisualStyleBackColor = False
        '
        'txt_FCus
        '
        Me.txt_FCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FCus.Location = New System.Drawing.Point(242, 73)
        Me.txt_FCus.Name = "txt_FCus"
        Me.txt_FCus.Size = New System.Drawing.Size(223, 24)
        Me.txt_FCus.TabIndex = 197
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(494, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "TO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 16)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "FROM CUSTOMER"
        '
        'btn_Preview
        '
        Me.btn_Preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Preview.AutoSize = True
        Me.btn_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Preview.Location = New System.Drawing.Point(938, 25)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(150, 48)
        Me.btn_Preview.TabIndex = 142
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = False
        '
        'dg_Items
        '
        Me.dg_Items.AllowUserToAddRows = False
        Me.dg_Items.AllowUserToDeleteRows = False
        Me.dg_Items.AllowUserToResizeRows = False
        Me.dg_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Items.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_Items.ColumnHeadersHeight = 30
        Me.dg_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_Items.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Items.EnableHeadersVisualStyles = False
        Me.dg_Items.Location = New System.Drawing.Point(0, 41)
        Me.dg_Items.Name = "dg_Items"
        Me.dg_Items.ReadOnly = True
        Me.dg_Items.RowHeadersVisible = False
        Me.dg_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Items.Size = New System.Drawing.Size(1160, 195)
        Me.dg_Items.TabIndex = 6
        '
        'Image_List
        '
        Me.Image_List.ImageStream = CType(resources.GetObject("Image_List.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image_List.TransparentColor = System.Drawing.Color.Transparent
        Me.Image_List.Images.SetKeyName(0, "ieframe_111.ico")
        Me.Image_List.Images.SetKeyName(1, "SHELL32_1.ico")
        '
        'frm_Outstdaning_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 236)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.dg_Items)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Name = "frm_Outstdaning_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Outstdaning_Report"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.Panel_MD.ResumeLayout(False)
        Me.Panel_MD.PerformLayout()
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_MD As Panel
    Friend WithEvents btn_Preview As Button
    Friend WithEvents dg_Items As DataGridView
    Friend WithEvents Image_List As ImageList
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_TCus As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_TCus As TextBox
    Friend WithEvents btn_FCus As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_FCus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_FDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_saleman As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_saleman As CheckBox
    Friend WithEvents Label8 As Label
End Class
