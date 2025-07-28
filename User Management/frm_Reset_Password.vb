Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData
Imports System.Data.SqlClient

Public Class frm_Reset_Password
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_Reset_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub cb_UseDefaultPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_UseDefaultPassword.CheckedChanged
        Try
            If cb_UseDefaultPassword.CheckState = 1 Then
                txt_NewPass.Text = "Pass" & txt_UserID.Text.Trim
                txt_ConfirmPass.Text = "Pass" & txt_UserID.Text.Trim
            Else
                txt_NewPass.Text = ""
                txt_ConfirmPass.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Try
            If txt_NewPass.Text.Trim = txt_ConfirmPass.Text.Trim Then
                Dim v_Exc As Boolean = SQL_ExecuteNonQuery("UPDATE _SY_USER SET U_PWD='" & txt_NewPass.Text.Trim & "' WHERE USERS_ID = '" & txt_UserID.Text.Trim & "'")
                Me.Close()
            Else
                MessageBox.Show("Please verify new password and confirm password again!", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class