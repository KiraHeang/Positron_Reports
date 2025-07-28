<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Find
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Find))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Data_GridView = New System.Windows.Forms.DataGridView()
        Me.gc_Customer_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gc_Customer_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gc_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_FindBy = New System.Windows.Forms.ComboBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Select = New System.Windows.Forms.Button()
        Me.btn_FindNow = New System.Windows.Forms.Button()
        Me.txt_Filter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_TitleBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Data_GridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_TitleBar.Size = New System.Drawing.Size(682, 35)
        Me.Panel_TitleBar.TabIndex = 6
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
        Me.btn_Exit.Location = New System.Drawing.Point(644, 4)
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
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Finder TEMP"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Data_GridView)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmb_FindBy)
        Me.Panel1.Controls.Add(Me.btn_Cancel)
        Me.Panel1.Controls.Add(Me.btn_Select)
        Me.Panel1.Controls.Add(Me.btn_FindNow)
        Me.Panel1.Controls.Add(Me.txt_Filter)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 324)
        Me.Panel1.TabIndex = 9
        '
        'Data_GridView
        '
        Me.Data_GridView.AllowUserToAddRows = False
        Me.Data_GridView.AllowUserToDeleteRows = False
        Me.Data_GridView.AllowUserToResizeRows = False
        Me.Data_GridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Data_GridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data_GridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Data_GridView.ColumnHeadersHeight = 40
        Me.Data_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Data_GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gc_Customer_Number, Me.gc_Customer_Name, Me.gc_Status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data_GridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Data_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Data_GridView.EnableHeadersVisualStyles = False
        Me.Data_GridView.Location = New System.Drawing.Point(17, 93)
        Me.Data_GridView.Name = "Data_GridView"
        Me.Data_GridView.RowHeadersVisible = False
        Me.Data_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_GridView.Size = New System.Drawing.Size(643, 168)
        Me.Data_GridView.TabIndex = 3
        Me.Data_GridView.TabStop = False
        '
        'gc_Customer_Number
        '
        Me.gc_Customer_Number.HeaderText = "Customer Number"
        Me.gc_Customer_Number.Name = "gc_Customer_Number"
        Me.gc_Customer_Number.ReadOnly = True
        Me.gc_Customer_Number.Width = 150
        '
        'gc_Customer_Name
        '
        Me.gc_Customer_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gc_Customer_Name.HeaderText = "Customer Name"
        Me.gc_Customer_Name.Name = "gc_Customer_Name"
        Me.gc_Customer_Name.ReadOnly = True
        '
        'gc_Status
        '
        Me.gc_Status.HeaderText = "Status"
        Me.gc_Status.Name = "gc_Status"
        Me.gc_Status.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Find By"
        '
        'cmb_FindBy
        '
        Me.cmb_FindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FindBy.FormattingEnabled = True
        Me.cmb_FindBy.Items.AddRange(New Object() {"Customer Number", "Customer Name"})
        Me.cmb_FindBy.Location = New System.Drawing.Point(86, 23)
        Me.cmb_FindBy.Name = "cmb_FindBy"
        Me.cmb_FindBy.Size = New System.Drawing.Size(121, 21)
        Me.cmb_FindBy.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(585, 276)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 5
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Select
        '
        Me.btn_Select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Select.Location = New System.Drawing.Point(504, 276)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(75, 23)
        Me.btn_Select.TabIndex = 4
        Me.btn_Select.Text = "Select"
        Me.btn_Select.UseVisualStyleBackColor = True
        '
        'btn_FindNow
        '
        Me.btn_FindNow.ImageIndex = 0
        Me.btn_FindNow.Location = New System.Drawing.Point(335, 48)
        Me.btn_FindNow.Name = "btn_FindNow"
        Me.btn_FindNow.Size = New System.Drawing.Size(100, 23)
        Me.btn_FindNow.TabIndex = 2
        Me.btn_FindNow.TabStop = False
        Me.btn_FindNow.Text = "Find Now"
        Me.btn_FindNow.UseVisualStyleBackColor = True
        '
        'txt_Filter
        '
        Me.txt_Filter.Location = New System.Drawing.Point(86, 50)
        Me.txt_Filter.MaxLength = 15
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(243, 20)
        Me.txt_Filter.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filter : "
        '
        'frm_Find_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Find_Customer"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finder TEMP"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Data_GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Data_GridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_FindBy As ComboBox
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Select As Button
    Friend WithEvents btn_FindNow As Button
    Friend WithEvents txt_Filter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gc_Customer_Number As DataGridViewTextBoxColumn
    Friend WithEvents gc_Customer_Name As DataGridViewTextBoxColumn
    Friend WithEvents gc_Status As DataGridViewTextBoxColumn
End Class
