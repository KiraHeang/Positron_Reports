Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_User_New
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

    Private Sub frm_User_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_UserStatus.SelectedIndex = 0
            cmb_UserType.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(Err.Description, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            If txt_UserID.Text = "" Then
                MessageBox.Show("Please input user id first.", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If txt_UserName.Text = "" Then
                MessageBox.Show("Please input user name first.", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using (SQLCNN)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = SQLCNN
                sqlComm.CommandText = "sp_SY_USER"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("@USERS_ID", txt_UserID.Text.Trim)
                sqlComm.Parameters.AddWithValue("@U_NAME", txt_UserName.Text.Trim)
                sqlComm.Parameters.AddWithValue("@U_TYPE", cmb_UserType.SelectedItem.ToString)
                sqlComm.Parameters.AddWithValue("@EMP_DEPT", txt_Dept.Text.Trim)
                sqlComm.Parameters.AddWithValue("@EMP_TITLE", txt_JobTitle.Text.Trim)
                If cmb_UserStatus.SelectedItem.ToString = "Active" Then
                    sqlComm.Parameters.AddWithValue("@IS_ACTIVE", 1)
                Else
                    sqlComm.Parameters.AddWithValue("@IS_ACTIVE", 0)
                End If
                sqlComm.Parameters.AddWithValue("@ADD_USER", v_UserID)
                sqlComm.Parameters.AddWithValue("@EVENT", 0)
                If SQLCNN.State <> ConnectionState.Closed Then SQLCNN.Close()
                SQLCNN.ConnectionString = Read_CNN()
                SQLCNN.Open()
                sqlComm.ExecuteNonQuery()
            End Using
            Me.Close()
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class