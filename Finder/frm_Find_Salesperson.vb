Imports System.Runtime.InteropServices
Imports Positron_Reports.SQLGetData

Public Class frm_Find_Salesperson
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
    Private Sub frm_Find_Salesperson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmb_FindBy.SelectedIndex = 0
            Data_GridView.ReadOnly = False

            ' Clear existing rows if any
            If Data_GridView.Rows.Count > 0 Then
                Data_GridView.Rows.Clear()
            End If

            ' Load data
            Dim V_TBL As DataTable = SQL_GetTable("select ROW_NUMBER() OVER (ORDER BY SlpCode) AS No, SlpCode, SlpName from OSLP Where SlpCode <> -1 Order By SlpCode")
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                       DR("SlpCode").ToString.Trim,
                                       DR("SlpName").ToString.Trim,
                                       False)
                Next
                V_TBL = Nothing
            End If

            ' Set ReadOnly = True for all columns except checkbox
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


    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        F_Salespersons = ""
        Me.Close()
    End Sub

    Private Sub btn_Select_Click(sender As Object, e As EventArgs) Handles btn_Select.Click
        Try
            If Data_GridView.RowCount = 0 Then Exit Sub

            Dim selectedCodes As New List(Of String)

            For Each row As DataGridViewRow In Data_GridView.Rows
                If Convert.ToBoolean(row.Cells("gc_check").Value) = True Then
                    selectedCodes.Add(row.Cells("gc_sales_code").Value.ToString().Trim())
                End If
            Next

            If selectedCodes.Count = 0 Then
                MessageBox.Show("Please check at least one salesperson.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Set global variable with comma-separated SlpCodes
            F_Salespersons = String.Join(",", selectedCodes)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Data_GridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_GridView.CellDoubleClick
        Try
            If Data_GridView.RowCount = 0 Then
                Exit Sub
            End If
            F_Salespersons = Data_GridView.CurrentRow.Cells("gc_sales_code").Value.ToString.Trim
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
                    v_SQL = "select ROW_NUMBER() OVER (ORDER BY SlpCode) AS No, SlpCode, SlpName from OSLP Where SlpCode <> -1 Order By SlpCode"
                Else
                    v_SQL = "select ROW_NUMBER() OVER (ORDER BY SlpCode) AS No,SlpCode,SlpName from OSLP Where SlpCode <> -1  LIKE '%" & txt_Filter.Text.Trim & "%' ORDER BY SlpCode"
                End If
            ElseIf cmb_FindBy.SelectedIndex = 1 Then
                If txt_Filter.Text = "" Then
                    v_SQL = "select ROW_NUMBER() OVER (ORDER BY SlpCode) AS No,SlpCode,SlpName from OSLP SlpCode <> -1 By SlpCode"
                Else
                    v_SQL = "select ROW_NUMBER() OVER (ORDER BY SlpCode) AS No,SlpCode,SlpName from OSLP WHERE  SlpCode <> -1 and SlpName LIKE '%" & txt_Filter.Text.Trim & "%' ORDER BY SlpCode"
                End If
            End If
            Dim V_TBL As DataTable = SQL_GetTable(v_SQL)
            If V_TBL IsNot Nothing Then
                For Each DR As DataRow In V_TBL.Rows
                    Data_GridView.Rows.Add(DR("No").ToString.Trim,
                                                DR("SlpCode").ToString.Trim,
                                                DR("SlpName").ToString.Trim,
                                                False)
                Next
                V_TBL = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Data_GridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_GridView.CellClick
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
    Private Sub btn_Cancel_Click_1(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        F_Salespersons = ""
        Me.Close()
    End Sub
End Class