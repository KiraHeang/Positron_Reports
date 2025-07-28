Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Positron_Reports.RGBColors
Imports Positron_Reports.SQLGetData
Imports System.Data.SqlClient

Public Class frm_Main
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = customColor
            currentBtn.Font = New Font(currentBtn.Font, FontStyle.Bold)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = Color.White
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = RGBColors.Disable_Button
            currentBtn.Font = New Font(currentBtn.Font, FontStyle.Regular)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.White
        lbFormTitle.Text = "Home"
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lbFormTitle.Text = childForm.Text
    End Sub
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If System.IO.File.Exists(FileINI) = False Then
                Write_CNN(".", "sa", "123456", "LIVED")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        '/// CHECK DB CONNECTION
        Try
            If SQLCNN.State <> ConnectionState.Closed Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            SQLCNN.Open()
            Tool_StripDB.Text = "DB [ " & SQLCNN.Database & " ]"
            Tool_StripVersion.Text = "Version " & Application.ProductVersion
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            WriteError(ex.Message)
            Exit Sub
        End Try
        '/// END

        Try
            Dim F As New frm_LogIN
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If v_LoginStatus = False Then
                Me.Close()
            End If

            ' User permission
            If v_UserType = "Administrator" Then
                btn_SystemMgt.Visible = True
                btn_UserMgt.Visible = True
            Else
                btn_SystemMgt.Visible = False
                btn_UserMgt.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btn_Maximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub btn_SystemMgt_Click(sender As Object, e As EventArgs) Handles btn_SystemMgt.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New frm_SystemMgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_UserMgt_Click(sender As Object, e As EventArgs) Handles btn_UserMgt.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New frm_User_Mgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click
        Try
            Dim F As New frm_Reset_Password
            F.FormBorderStyle = FormBorderStyle.None
            F.txt_UserID.Text = v_UserID
            F.txt_UserName.Text = v_UserName
            F.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_LogOff_Click(sender As Object, e As EventArgs) Handles btn_LogOff.Click
        Try
            'Me.Opacity = 0
            Dim F_LogIN As New frm_LogIN
            F_LogIN.FormBorderStyle = FormBorderStyle.None
            F_LogIN.ShowDialog()

            ' User permission
            If v_UserType = "Administrator" Then
                btn_SystemMgt.Visible = True
                btn_UserMgt.Visible = True
            Else
                btn_SystemMgt.Visible = False
                btn_UserMgt.Visible = False
            End If
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
            End If
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btn_Sale_Reports_Click(sender As Object, e As EventArgs) Handles btn_Sale_Reports.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New frm_Sales_AR_Reports_Mgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_banking_rp_Click(sender As Object, e As EventArgs) Handles btn_banking_rp.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New frm_Banking_Reports_Mgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Inventory_Report_Click(sender As Object, e As EventArgs) Handles btn_Inventory_Report.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New Inventory_Reports_Mgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Purchase_Reports_Click(sender As Object, e As EventArgs) Handles btn_Purchase_Reports.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New frm_Purchase_Reports_Mgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Buniess_Partner_Repo_Click(sender As Object, e As EventArgs) Handles btn_Buniess_Partner_Reports.Click
        Try
            ActivateButton(sender, RGBColors.BKColor1)
            OpenChildForm(New frm_Business_Partner_Mgt)
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
