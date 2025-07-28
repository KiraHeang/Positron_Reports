<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reports_Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reports_Viewer))
        Me.Panel_TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.Crystal_Report_Viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Panel_TitleBar.SuspendLayout()
        Me.Panel_MD.SuspendLayout()
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
        Me.Panel_TitleBar.Location = New System.Drawing.Point(1, 1)
        Me.Panel_TitleBar.Name = "Panel_TitleBar"
        Me.Panel_TitleBar.Size = New System.Drawing.Size(1006, 35)
        Me.Panel_TitleBar.TabIndex = 3
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
        Me.btn_Exit.Location = New System.Drawing.Point(965, 0)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(30, 35)
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
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reports Viewer"
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_MD.Controls.Add(Me.Crystal_Report_Viewer)
        Me.Panel_MD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MD.Location = New System.Drawing.Point(1, 36)
        Me.Panel_MD.Name = "Panel_MD"
        Me.Panel_MD.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD.Size = New System.Drawing.Size(1006, 692)
        Me.Panel_MD.TabIndex = 6
        '
        'Crystal_Report_Viewer
        '
        Me.Crystal_Report_Viewer.ActiveViewIndex = -1
        Me.Crystal_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crystal_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crystal_Report_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crystal_Report_Viewer.Location = New System.Drawing.Point(10, 10)
        Me.Crystal_Report_Viewer.Name = "Crystal_Report_Viewer"
        Me.Crystal_Report_Viewer.Size = New System.Drawing.Size(986, 672)
        Me.Crystal_Report_Viewer.TabIndex = 0
        Me.Crystal_Report_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.btn_Maximize.Location = New System.Drawing.Point(929, 0)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Size = New System.Drawing.Size(30, 35)
        Me.btn_Maximize.TabIndex = 24
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
        Me.btn_Minimize.Location = New System.Drawing.Point(893, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(30, 35)
        Me.btn_Minimize.TabIndex = 23
        Me.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Minimize.UseVisualStyleBackColor = True
        '
        'frm_Reports_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Reports_Viewer"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports Viewer"
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.Panel_MD.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_MD As Panel
    Friend WithEvents Crystal_Report_Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
End Class
