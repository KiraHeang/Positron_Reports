<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_JNY_Sale_Order_Report
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
        Me.Panel_MD = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.Panel_MD.SuspendLayout()
        Me.Panel_TitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_MD
        '
        Me.Panel_MD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel_MD.Controls.Add(Me.Label14)
        Me.Panel_MD.Controls.Add(Me.dtp_TDate)
        Me.Panel_MD.Controls.Add(Me.Label2)
        Me.Panel_MD.Controls.Add(Me.btn_Preview)
        Me.Panel_MD.Controls.Add(Me.dtp_FDate)
        Me.Panel_MD.Controls.Add(Me.Label1)
        Me.Panel_MD.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_MD.Location = New System.Drawing.Point(0, 41)
        Me.Panel_MD.Name = "Panel_MD"
        Me.Panel_MD.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_MD.Size = New System.Drawing.Size(1078, 167)
        Me.Panel_MD.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(204, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 21)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = ":"
        '
        'dtp_TDate
        '
        Me.dtp_TDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_TDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_TDate.Location = New System.Drawing.Point(517, 45)
        Me.dtp_TDate.Name = "dtp_TDate"
        Me.dtp_TDate.Size = New System.Drawing.Size(223, 23)
        Me.dtp_TDate.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(475, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "TO :"
        '
        'btn_Preview
        '
        Me.btn_Preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Preview.AutoSize = True
        Me.btn_Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Preview.Location = New System.Drawing.Point(906, 26)
        Me.btn_Preview.Name = "btn_Preview"
        Me.btn_Preview.Size = New System.Drawing.Size(164, 42)
        Me.btn_Preview.TabIndex = 142
        Me.btn_Preview.Text = "Preview"
        Me.btn_Preview.UseVisualStyleBackColor = False
        '
        'dtp_FDate
        '
        Me.dtp_FDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.CustomFormat = "dd/ MMM/ yyyy"
        Me.dtp_FDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FDate.Location = New System.Drawing.Point(224, 44)
        Me.dtp_FDate.Name = "dtp_FDate"
        Me.dtp_FDate.Size = New System.Drawing.Size(222, 23)
        Me.dtp_FDate.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 107
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
        Me.Panel_TitleBar.TabIndex = 14
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
        Me.Label4.Size = New System.Drawing.Size(174, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "JNY Sales Order Report"
        '
        'frm_JNY_Sale_Order_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 206)
        Me.Controls.Add(Me.Panel_MD)
        Me.Controls.Add(Me.Panel_TitleBar)
        Me.Name = "frm_JNY_Sale_Order_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_JNY_Sale_Order_Report"
        Me.Panel_MD.ResumeLayout(False)
        Me.Panel_MD.PerformLayout()
        Me.Panel_TitleBar.ResumeLayout(False)
        Me.Panel_TitleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_MD As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_TDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Preview As Button
    Friend WithEvents dtp_FDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_TitleBar As Panel
    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
End Class
