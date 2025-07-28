<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Stock_Movenment_Report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Stock_Movenment_Report))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.btn_find = New FontAwesome.Sharp.IconButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_whs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_TDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Preview = New System.Windows.Forms.Button()
        Me.dtp_FDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dg_Items = New System.Windows.Forms.DataGridView()
        Me.Image_List = New System.Windows.Forms.ImageList(Me.components)
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.Panel_MD.SuspendLayout()
        Me.Panel_TitleBar.SuspendLayout()
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel_MD.Controls.Add(Me.btn_find)
        Me.Panel_MD.Controls.Add(Me.Label7)
        Me.Panel_MD.Controls.Add(Me.txt_whs)
        Me.Panel_MD.Controls.Add(Me.Label6)
        Me.Panel_MD.Controls.Add(Me.Label5)
        Me.Panel_MD.Controls.Add(Me.Label3)
        Me.Panel_MD.Controls.Add(Me.dtp_TDate)
        Me.Panel_MD.Controls.Add(Me.Label2)
        Me.Panel_MD.Controls.Add(Me.btn_Preview)
        Me.Panel_MD.Controls.Add(Me.dtp_FDate)
        Me.Panel_MD.Controls.Add(Me.Label1)
        Me.Panel_MD.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_MD.Location = New System.Drawing.Point(0, 41)
        Me.Panel_MD.Name = "Panel_MD"
        Me.Panel_MD.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD.Size = New System.Drawing.Size(1106, 254)
        Me.Panel_MD.TabIndex = 11
        '
        'btn_find
        '
        Me.btn_find.BackColor = System.Drawing.Color.Transparent
        Me.btn_find.FlatAppearance.BorderSize = 0
        Me.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find.ForeColor = System.Drawing.Color.Black
        Me.btn_find.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_find.IconColor = System.Drawing.SystemColors.MenuText
        Me.btn_find.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_find.IconSize = 23
        Me.btn_find.Location = New System.Drawing.Point(407, 70)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(27, 19)
        Me.btn_find.TabIndex = 150
        Me.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_find.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(497, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 21)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = ":"
        '
        'txt_whs
        '
        Me.txt_whs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whs.Location = New System.Drawing.Point(207, 67)
        Me.txt_whs.Name = "txt_whs"
        Me.txt_whs.Size = New System.Drawing.Size(228, 24)
        Me.txt_whs.TabIndex = 148
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 21)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 21)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "WHREHOUSE"
        '
        'dtp_TDate
        '
        Me.dtp_TDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_TDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_TDate.Location = New System.Drawing.Point(517, 31)
        Me.dtp_TDate.Name = "dtp_TDate"
        Me.dtp_TDate.Size = New System.Drawing.Size(228, 26)
        Me.dtp_TDate.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "TO "
        '
        'btn_Preview
        '
        Me.btn_Preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Preview.AutoSize = True
        Me.btn_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Preview.Location = New System.Drawing.Point(883, 22)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(156, 49)
        Me.btn_Preview.TabIndex = 142
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = False
        '
        'dtp_FDate
        '
        Me.dtp_FDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_FDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FDate.Location = New System.Drawing.Point(207, 31)
        Me.dtp_FDate.Name = "dtp_FDate"
        Me.dtp_FDate.Size = New System.Drawing.Size(228, 26)
        Me.dtp_FDate.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "FROM DATE "
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
        Me.Panel_TitleBar.Size = New System.Drawing.Size(1106, 41)
        Me.Panel_TitleBar.TabIndex = 9
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
        Me.btn_Maximize.Location = New System.Drawing.Point(1032, 4)
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
        Me.btn_Minimize.Location = New System.Drawing.Point(995, 4)
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
        Me.btn_Exit.Location = New System.Drawing.Point(1068, 4)
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
        Me.dg_Items.Location = New System.Drawing.Point(0, 0)
        Me.dg_Items.Name = "dg_Items"
        Me.dg_Items.ReadOnly = True
        Me.dg_Items.RowHeadersVisible = False
        Me.dg_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Items.Size = New System.Drawing.Size(1106, 212)
        Me.dg_Items.TabIndex = 10
        '
        'Image_List
        '
        Me.Image_List.ImageStream = CType(resources.GetObject("Image_List.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image_List.TransparentColor = System.Drawing.Color.Transparent
        Me.Image_List.Images.SetKeyName(0, "ieframe_111.ico")
        Me.Image_List.Images.SetKeyName(1, "SHELL32_1.ico")
        '
        'dtg
        '
        Me.dtg.AllowUserToAddRows = False
        Me.dtg.AllowUserToDeleteRows = False
        Me.dtg.AllowUserToResizeRows = False
        Me.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtg.ColumnHeadersHeight = 30
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.EnableHeadersVisualStyles = False
        Me.dtg.Location = New System.Drawing.Point(0, 0)
        Me.dtg.Name = "dtg"
        Me.dtg.ReadOnly = True
        Me.dtg.RowHeadersVisible = False
        Me.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg.Size = New System.Drawing.Size(1106, 212)
        Me.dtg.TabIndex = 12
        '
        'frm_Stock_Movenment_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 212)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Controls.Add(Me.dg_Items)
        Me.Controls.Add(Me.dtg)
        Me.Name = "frm_Stock_Movenment_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Stock_Movenment_Report"
        Me.Panel_MD.ResumeLayout(False)
        Me.Panel_MD.PerformLayout()
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_MD As Panel
    Friend WithEvents btn_Preview As Button
    Friend WithEvents dtp_FDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents dg_Items As DataGridView
    Friend WithEvents Image_List As ImageList
    Friend WithEvents dtg As DataGridView
    Friend WithEvents dtp_TDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_whs As TextBox
    Friend WithEvents btn_find As FontAwesome.Sharp.IconButton
End Class
