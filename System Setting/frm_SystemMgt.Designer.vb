<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SystemMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SystemMgt))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Database = New FontAwesome.Sharp.IconButton()
        Me.btn_VersionUpload = New FontAwesome.Sharp.IconButton()
        Me.Image_List = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_Database)
        Me.Panel2.Controls.Add(Me.btn_VersionUpload)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1308, 776)
        Me.Panel2.TabIndex = 1
        '
        'btn_Database
        '
        Me.btn_Database.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Database.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btn_Database.IconColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_Database.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Database.IconSize = 40
        Me.btn_Database.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Database.Location = New System.Drawing.Point(35, 35)
        Me.btn_Database.Name = "btn_Database"
        Me.btn_Database.Size = New System.Drawing.Size(109, 75)
        Me.btn_Database.TabIndex = 14
        Me.btn_Database.Text = "Database"
        Me.btn_Database.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Database.UseVisualStyleBackColor = True
        '
        'btn_VersionUpload
        '
        Me.btn_VersionUpload.Enabled = False
        Me.btn_VersionUpload.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VersionUpload.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btn_VersionUpload.IconColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_VersionUpload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_VersionUpload.IconSize = 40
        Me.btn_VersionUpload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_VersionUpload.Location = New System.Drawing.Point(185, 35)
        Me.btn_VersionUpload.Name = "btn_VersionUpload"
        Me.btn_VersionUpload.Size = New System.Drawing.Size(113, 75)
        Me.btn_VersionUpload.TabIndex = 12
        Me.btn_VersionUpload.Text = "Version Update"
        Me.btn_VersionUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_VersionUpload.UseVisualStyleBackColor = True
        '
        'Image_List
        '
        Me.Image_List.ImageStream = CType(resources.GetObject("Image_List.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image_List.TransparentColor = System.Drawing.Color.Transparent
        Me.Image_List.Images.SetKeyName(0, "eLabel.ico")
        Me.Image_List.Images.SetKeyName(1, "company.png")
        '
        'frm_SystemMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1314, 782)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_SystemMgt"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "System Setting"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Image_List As ImageList
    Friend WithEvents btn_VersionUpload As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Database As FontAwesome.Sharp.IconButton
End Class
