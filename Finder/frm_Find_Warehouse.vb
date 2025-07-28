Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_Find_Warehouse
    ' Drag Form
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

    Private Sub frm_Find_Warehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_FindBy.SelectedIndex = 0
            Data_GridView.ReadOnly = False

            ' Clear existing rows if any
            If Data_GridView.Rows.Count > 0 Then
                Data_GridView.Rows.Clear()
            End If

            Dim V_TBL As DataTable = SQL_GetTable("SELECT ROW_NUMBER() OVER (ORDER BY WhsCode) AS No, WhsCode, WhsName FROM OWHS ORDER BY WhsCode")
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                           DR("WhsCode").ToString.Trim,
                                           DR("WhsName").ToString.Trim)
                Next
            End If

            For i As Integer = 0 To Data_GridView.Columns.Count - 1
                If Data_GridView.Columns(i).Name = "gc_check" Then
                    Data_GridView.Columns(i).ReadOnly = False
                    Data_GridView.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                Else
                    Data_GridView.Columns(i).ReadOnly = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        F_Warehouse = ""
        Me.Close()
    End Sub

    Private Sub btn_FindNow_Click(sender As Object, e As EventArgs) Handles btn_FindNow.Click
        Try
            If Data_GridView.RowCount > 0 Then
                Data_GridView.Rows.Clear()
            End If

            Dim v_SQL As String = ""
            Dim filterText As String = txt_Filter.Text.Trim.Replace("'", "''").ToLower()

            If cmb_FindBy.SelectedIndex = 0 Then ' Warehouse Code
                If filterText = "" Then
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY WhsCode) AS No, WhsCode, WhsName FROM OWHS ORDER BY WhsCode"
                Else
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY WhsCode) AS No, WhsCode, WhsName FROM OWHS WHERE WhsCode LIKE '%" & filterText & "%' ORDER BY WhsCode"
                End If
            ElseIf cmb_FindBy.SelectedIndex = 1 Then ' Warehouse Name
                If filterText = "" Then
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY WhsCode) AS No, WhsCode, WhsName FROM OWHS ORDER BY WhsCode"
                Else
                    v_SQL = "SELECT ROW_NUMBER() OVER (ORDER BY WhsCode) AS No, WhsCode, WhsName FROM OWHS WHERE WhsName LIKE '%" & filterText & "%' ORDER BY WhsCode"
                End If
            End If

            Dim V_TBL As DataTable = SQL_GetTable(v_SQL)
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                           DR("WhsCode").ToString.Trim,
                                           DR("WhsName").ToString.Trim)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_Filter_TextChanged(sender As Object, e As EventArgs) Handles txt_Filter.TextChanged
        If txt_Filter.Text.Trim = "" Then
            btn_FindNow.PerformClick()
        End If
    End Sub

    Private Sub Data_GridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_GridView.CellDoubleClick
        Try
            If Data_GridView.RowCount = 0 Then Exit Sub
            F_Warehouse = Data_GridView.CurrentRow.Cells("gc_whs_code").Value.ToString.Trim
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Select_Click(sender As Object, e As EventArgs) Handles btn_Select.Click
        Try
            If Data_GridView.RowCount = 0 Then Exit Sub

            Dim selectedCodes As New List(Of String)

            For Each row As DataGridViewRow In Data_GridView.Rows
                If Convert.ToBoolean(row.Cells("gc_check").Value) = True Then
                    selectedCodes.Add(row.Cells("gc_whs_code").Value.ToString().Trim())
                End If
            Next

            If selectedCodes.Count = 0 Then
                MessageBox.Show("Please check at least one warehouse.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Set global variable with comma-separated warehouse codes
            F_Warehouse = String.Join(",", selectedCodes)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Data_GridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_GridView.CellClick
        Try
            ' Check if header row clicked
            If e.RowIndex = -1 AndAlso e.ColumnIndex >= 0 Then
                If Data_GridView.Columns(e.ColumnIndex).Name = "gc_check" Then
                    ' Toggle all checkboxes
                    Dim allChecked As Boolean = Data_GridView.Rows.Cast(Of DataGridViewRow).All(Function(r) Convert.ToBoolean(r.Cells("gc_check").Value) = True)

                    For Each row As DataGridViewRow In Data_GridView.Rows
                        row.Cells("gc_check").Value = Not allChecked
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class