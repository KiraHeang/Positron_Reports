Imports System.Data.SqlClient
Imports Positron_Reports.SQLGetData
Imports Positron_Reports.frm_Main

Public Class frm_LogIN

    Dim v_S As String = "ADMIN"
    Dim v_P As String = "ADMIN"
    Dim TBL As DataTable = Nothing

    Private Sub frm_LogIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            v_LoginStatus = False
            v_UserID = ""
            v_UserName = ""
            v_UserType = ""
            txt_UserID.Text = ReadLastLogin()

            txt_UserID.Text = v_S
            txt_Password.Text = v_P
            btn_LogIn.Focus()
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        'YOU CODE HERE
        MsgBox("Please contact the System Administrator.", vbInformation, "Forgot Password")
    End Sub


    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click
        txt_UserID.Select()
        lblUsername.Visible = False
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txt_UserID.GotFocus
        txt_UserID.Select()
        lblUsername.Visible = False
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txt_UserID.LostFocus
        If txt_UserID.Text = "" Then
            lblUsername.Visible = True
        Else
            lblUsername.Visible = False
        End If
    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click
        txt_Password.Select()
        lblPassword.Visible = False
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txt_Password.GotFocus
        txt_Password.Select()
        lblPassword.Visible = False
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txt_Password.LostFocus
        If txt_Password.Text = "" Then
            lblPassword.Visible = True
            txt_UserID.Select()
        Else
            lblPassword.Visible = False
            txt_UserID.Select()
        End If
    End Sub

    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        frm_Main.lb_UserLogIn.Text = v_UserName
        If txt_UserID.Text <> "" And txt_Password.Text <> "" Then   ' ### LOG IN Checking
            Try
                TBL = SQL_GetTable("SELECT * FROM fn_Report_SY_USER() WHERE USERS_ID='" & txt_UserID.Text & "' AND U_PWD='" & txt_Password.Text & "'")
                If TBL.Rows.Count > 0 Then
                    If TBL.Rows(0)("IS_ACTIVE").ToString.Trim = "Inactive" Then
                        MessageBox.Show("Your account is inactivated !", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    v_UserID = txt_UserID.Text
                    v_UserName = TBL.Rows(0)("U_NAME").ToString.Trim
                    frm_Main.lb_UserLogIn.Text = v_UserName
                    v_UserType = TBL.Rows(0)("U_TYPE").ToString.Trim
                    v_LoginStatus = True
                    WriteLastLogin(v_UserID)
                    Me.Close()
                ElseIf TBL.Rows.Count <= 0 Then
                    If txt_UserID.Text = v_S And txt_Password.Text = v_P Then   '### LOG IN with user ADMIN
                        v_UserID = v_S
                        v_UserName = txt_UserID.Text.Trim
                        v_UserType = "Administrator"
                        v_LoginStatus = True
                        frm_Main.lb_UserLogIn.Text = v_UserName
                        WriteLastLogin(v_UserID)
                        Me.Close()
                    Else
                        v_LoginStatus = False
                        v_UserID = ""
                        v_UserName = ""
                        v_UserType = ""
                        MessageBox.Show("Invalid input User or Password !", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txt_Password.Text = ""
                        Me.txt_Password.Focus()
                    End If
                End If
                TBL = Nothing
            Catch ex As Exception
                WriteError(ex.Message)
                MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please Enter Username and Password !", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frm_LogIN_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_LogIn.PerformClick()
        End If
    End Sub
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        V_LogInStatus = False
        Application.Exit()
    End Sub


End Class