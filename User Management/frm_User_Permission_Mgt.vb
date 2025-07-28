Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_User_Permission_Mgt
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


    Private Sub frm_User_Permission_Mgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tbl_Function As DataTable = SQL_GetTable("SELECT * FROM z_Report_Function_Permission ORDER BY Function_Type, Function_ID")
            If tbl_Function IsNot Nothing Then
                If tbl_Function.Rows.Count > 0 Then
                    For Each DR As DataRow In tbl_Function.Rows
                        dg_Functions.Rows.Add(DR("Function_ID").ToString.Trim,
                                              DR("Function_Name").ToString.Trim,
                                              DR("Function_Type").ToString.Trim,
                                              0)
                    Next
                End If
                tbl_Function = Nothing
            End If

            Dim tbl_User_Permission As DataTable = SQL_GetTable("SELECT Function_ID,Access_Level FROM SY_USER_PERMISSION WHERE Users_ID='" & txt_User_ID.Text.Trim & "'")
            If tbl_User_Permission IsNot Nothing Then
                If tbl_User_Permission.Rows.Count > 0 Then
                    For Each GDR As DataGridViewRow In dg_Functions.Rows
                        If tbl_User_Permission.Select("Function_ID ='" & GDR.Cells("Function_ID").Value.ToString.Trim & "'").Count > 0 Then
                            Dim filteredRows = tbl_User_Permission.Select("Function_ID ='" & GDR.Cells("Function_ID").Value.ToString.Trim & "'").CopyToDataTable()
                            If filteredRows.Rows.Count > 0 Then
                                GDR.Cells("Access_Level").Value = CInt(filteredRows.Rows(0)("Access_Level").ToString.Trim)
                            End If
                        End If
                    Next
                    tbl_User_Permission = Nothing
                End If
            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            If dg_Functions.RowCount = 0 Then
                Exit Sub
            End If
            For Each GDR As DataGridViewRow In dg_Functions.Rows
                Using (SQLCNN)
                    Dim sqlComm As New SqlCommand()
                    sqlComm.Connection = SQLCNN
                    sqlComm.CommandText = "sp_User_Permission"
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.Parameters.AddWithValue("@Users_ID", txt_User_ID.Text.Trim)
                    sqlComm.Parameters.AddWithValue("@Function_ID", GDR.Cells("Function_ID").Value.ToString.Trim)
                    sqlComm.Parameters.AddWithValue("@Access_Level", CInt(GDR.Cells("Access_Level").Value.ToString.Trim))
                    If SQLCNN.State <> ConnectionState.Closed Then SQLCNN.Close()
                    SQLCNN.ConnectionString = Read_CNN()
                    SQLCNN.Open()
                    sqlComm.ExecuteNonQuery()
                End Using
            Next
            Me.Close()
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class