Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_Database
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

    Private Sub frm_Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Read_CNN()
            txt_Server.Text = rServerName
            txt_LoginID.Text = rDBUserID
            txt_Password.Text = rDBPassword
            txt_Database.Text = rDBName
        Catch ex As Exception
            MessageBox.Show(Err.Description, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            Write_CNN(Me.txt_Server.Text, Me.txt_LoginID.Text, Me.txt_Password.Text, Me.txt_Database.Text)
        Catch ex As Exception
            MessageBox.Show(Err.Description, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            SQLCNN.Open()
            If SQLCNN.State = ConnectionState.Open Then
                MessageBox.Show("Connection Successful !", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                SQLCNN.Close()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
End Class