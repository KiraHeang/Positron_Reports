Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_Find_Customer
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

    Private Sub frm_Find_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_FindBy.SelectedIndex = 0

            Dim V_TBL As DataTable = SQL_GetTable("select ROW_NUMBER() OVER (ORDER BY CardCode) AS No,CardCode,CardName from OCRD Order By CardCode")
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                           DR("CardCode").ToString.Trim,
                                           DR("CardName").ToString.Trim)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        F_Salespersons = ""
        Me.Close()
    End Sub

    Private Sub txt_Filter_TextChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
        If txt_Filter.Text.Trim = "" Then
            btn_find.PerformClick()
        End If
    End Sub

    Private Sub Data_GridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_GridView.CellDoubleClick
        Try
            If Data_GridView.RowCount = 0 Then
                Exit Sub
            End If
            F_Customers = Data_GridView.CurrentRow.Cells("gc_cus_code").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Select_Click(sender As Object, e As EventArgs) Handles btn_Select.Click
        Try
            If Data_GridView.RowCount = 0 Then
                Exit Sub
            End If
            F_Customers = Data_GridView.CurrentRow.Cells("gc_cus_code").Value.ToString.Trim
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
                    v_SQL = "select ROW_NUMBER() OVER (ORDER BY CardCode) AS No,CardCode,CardName from OCRD Order By CardCode"
                Else
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY CardCode) AS No, CardCode, CardName FROM OCRD WHERE CardCode LIKE '%" & txt_Filter.Text.Trim & "%' ORDER BY CardCode"
                End If
            ElseIf cmb_FindBy.SelectedIndex = 1 Then
                If txt_Filter.Text = "" Then
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY CardCode) AS No, CardCode, CardName FROM OCRD ORDER BY CardCode"
                Else
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY CardCode) AS No, CardCode, CardName FROM OCRD WHERE CardName LIKE '%" & txt_Filter.Text.Trim & "%' ORDER BY CardCode"
                End If
            End If
            Dim V_TBL As DataTable = SQL_GetTable(v_SQL)
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                           DR("CardCode").ToString.Trim,
                                           DR("CardName").ToString.Trim)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class