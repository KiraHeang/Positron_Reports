<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_User_Permission_Mgt
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_User_Permission_Mgt))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel_MD2 = New System.Windows.Forms.Panel()
        Me.dg_Functions = New System.Windows.Forms.DataGridView()
        Me.txt_User_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MD1 = New System.Windows.Forms.Panel()
        Me.txt_User_Name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Function_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Function_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Function_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Access_Level = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel_TitleBar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_MD2.SuspendLayout()
        CType(Me.dg_Functions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MD1.SuspendLayout()
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
        Me.Panel_TitleBar.Size = New System.Drawing.Size(782, 35)
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
        Me.btn_Exit.Location = New System.Drawing.Point(746, 2)
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
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User Permission Mgt"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 510)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 50)
        Me.Panel2.TabIndex = 2
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(697, 15)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(10, 15)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel_MD2
        '
        Me.Panel_MD2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_MD2.Controls.Add(Me.dg_Functions)
        Me.Panel_MD2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MD2.Location = New System.Drawing.Point(1, 93)
        Me.Panel_MD2.Name = "Panel_MD2"
        Me.Panel_MD2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD2.Size = New System.Drawing.Size(782, 417)
        Me.Panel_MD2.TabIndex = 3
        '
        'dg_Functions
        '
        Me.dg_Functions.AllowUserToAddRows = False
        Me.dg_Functions.AllowUserToDeleteRows = False
        Me.dg_Functions.AllowUserToResizeRows = False
        Me.dg_Functions.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Functions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_Functions.ColumnHeadersHeight = 40
        Me.dg_Functions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_Functions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Function_ID, Me.Function_Name, Me.Function_Type, Me.Access_Level})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_Functions.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Functions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Functions.EnableHeadersVisualStyles = False
        Me.dg_Functions.Location = New System.Drawing.Point(10, 10)
        Me.dg_Functions.Name = "dg_Functions"
        Me.dg_Functions.RowHeadersVisible = False
        Me.dg_Functions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Functions.Size = New System.Drawing.Size(762, 397)
        Me.dg_Functions.TabIndex = 1
        '
        'txt_User_ID
        '
        Me.txt_User_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_User_ID.Location = New System.Drawing.Point(85, 17)
        Me.txt_User_ID.MaxLength = 10
        Me.txt_User_ID.Name = "txt_User_ID"
        Me.txt_User_ID.ReadOnly = True
        Me.txt_User_ID.Size = New System.Drawing.Size(150, 20)
        Me.txt_User_ID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "User ID :"
        '
        'Panel_MD1
        '
        Me.Panel_MD1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_MD1.Controls.Add(Me.txt_User_Name)
        Me.Panel_MD1.Controls.Add(Me.Label8)
        Me.Panel_MD1.Controls.Add(Me.txt_User_ID)
        Me.Panel_MD1.Controls.Add(Me.Label1)
        Me.Panel_MD1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_MD1.Location = New System.Drawing.Point(1, 36)
        Me.Panel_MD1.Name = "Panel_MD1"
        Me.Panel_MD1.Size = New System.Drawing.Size(782, 57)
        Me.Panel_MD1.TabIndex = 4
        '
        'txt_User_Name
        '
        Me.txt_User_Name.Location = New System.Drawing.Point(328, 17)
        Me.txt_User_Name.MaxLength = 60
        Me.txt_User_Name.Name = "txt_User_Name"
        Me.txt_User_Name.ReadOnly = True
        Me.txt_User_Name.Size = New System.Drawing.Size(422, 20)
        Me.txt_User_Name.TabIndex = 131
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(256, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "User Name :"
        '
        'Function_ID
        '
        Me.Function_ID.HeaderText = "Function_ID"
        Me.Function_ID.MinimumWidth = 100
        Me.Function_ID.Name = "Function_ID"
        Me.Function_ID.ReadOnly = True
        '
        'Function_Name
        '
        Me.Function_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Function_Name.HeaderText = "Function_Name"
        Me.Function_Name.MinimumWidth = 200
        Me.Function_Name.Name = "Function_Name"
        Me.Function_Name.ReadOnly = True
        '
        'Function_Type
        '
        Me.Function_Type.HeaderText = "Function_Type"
        Me.Function_Type.MinimumWidth = 120
        Me.Function_Type.Name = "Function_Type"
        Me.Function_Type.ReadOnly = True
        Me.Function_Type.Width = 120
        '
        'Access_Level
        '
        Me.Access_Level.FalseValue = "0"
        Me.Access_Level.HeaderText = "Access_Level"
        Me.Access_Level.MinimumWidth = 100
        Me.Access_Level.Name = "Access_Level"
        Me.Access_Level.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Access_Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Access_Level.TrueValue = "1"
        '
        'frm_User_Permission_Mgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel_MD2)
        Me.Controls.Add(Me.Panel_MD1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_User_Permission_Mgt"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Permission Mgt"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_MD2.ResumeLayout(False)
        CType(Me.dg_Functions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MD1.ResumeLayout(False)
        Me.Panel_MD1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents Panel_MD2 As Panel
    Friend WithEvents txt_User_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_MD1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_User_Name As TextBox
    Friend WithEvents dg_Functions As DataGridView
    Friend WithEvents Function_ID As DataGridViewTextBoxColumn
    Friend WithEvents Function_Name As DataGridViewTextBoxColumn
    Friend WithEvents Function_Type As DataGridViewTextBoxColumn
    Friend WithEvents Access_Level As DataGridViewCheckBoxColumn
End Class
