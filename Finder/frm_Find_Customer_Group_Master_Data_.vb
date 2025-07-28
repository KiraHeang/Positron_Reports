Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_Find_Customer_Group_Master_Data_
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
        F_CusGroupCode = ""
        Me.Close()
    End Sub
    Private Sub frm_Find_Customer_Group_Master_Data__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_FindBy.SelectedIndex = 0
            Dim V_TBL As DataTable = SQL_GetTable("Select ROW_NUMBER() OVER (ORDER BY GroupCode) AS No, GroupCode,GroupName from OCRG Order By GroupCode")
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                                DR("GroupCode").ToString.Trim,
                                                DR("GroupName").ToString.Trim)
                Next
                V_TBL = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        F_CusGroupCode = ""
        Me.Close()
    End Sub
    Private Sub Data_GridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_GridView.CellDoubleClick

        Try
            If Data_GridView.RowCount = 0 Then
                Exit Sub
            End If
            F_CusGroupCode = Data_GridView.CurrentRow.Cells("gc_gpcus_code").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_Select_Click_1(sender As Object, e As EventArgs) Handles btn_Select.Click
        Try
            If Data_GridView.RowCount = 0 Then
                Exit Sub
            End If
            F_CusGroupCode = Data_GridView.CurrentRow.Cells("gc_gpcus_code").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        Try
            If Data_GridView.RowCount > 0 Then
                Data_GridView.Rows.Clear()
            End If
            Dim v_SQL As String = ""
            If cmb_FindBy.SelectedIndex = 0 Then
                If txt_Filter.Text = "" Then
                    v_SQL = "Select ROW_NUMBER() OVER (ORDER BY GroupCode) AS No, GroupCode,GroupName from OCRG Order By GroupCode"
                Else
                    v_SQL = "Select ROW_NUMBER() OVER (ORDER BY GroupCode) AS No, GroupCode,GroupName from OCRG WHERE GroupName LIKE '%" & txt_Filter.Text.Trim & "%' ORDER BY GroupCode"
                End If
            ElseIf cmb_FindBy.SelectedIndex = 1 Then
                If txt_Filter.Text = "" Then
                    v_SQL = "Select ROW_NUMBER() OVER (ORDER BY GroupCode) AS No, GroupCode,GroupName from OCRG Order By GroupCode"
                Else
                    v_SQL = "Select ROW_NUMBER() OVER (ORDER BY GroupCode) AS No, GroupCode,GroupName from OCRG WHERE GroupName LIKE '%" & txt_Filter.Text.Trim & "%' ORDER BY GroupCode"
                End If
            End If
            Dim V_TBL As DataTable = SQL_GetTable(v_SQL)
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                                DR("GroupCode").ToString.Trim,
                                                DR("GroupName").ToString.Trim)
                Next
                V_TBL = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txt_Filter_TextChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
        If txt_Filter.Text.Trim = "" Then
            btn_find.PerformClick()
        End If
    End Sub

    Private Sub btn_Cancel_Click_1(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class