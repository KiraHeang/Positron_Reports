Imports Positron_Reports.SQLGetData
Imports System.Data.SqlClient
Imports System.IO
Imports ClosedXML.Excel

Public Class frm_User_Mgt

    Private Sub frm_User_Mgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tbl_User As DataTable = SQL_GetTable("SELECT * FROM fn_Report_SY_USER() ORDER BY USERS_ID")
            If tbl_User IsNot Nothing Then
                For Each DR As DataRow In tbl_User.Rows
                    dg_User.Rows.Add(DR("USERS_ID"),
                                     DR("U_NAME"),
                                     DR("U_TYPE"),
                                     DR("EMP_DEPT"),
                                     DR("EMP_TITLE"),
                                     DR("IS_ACTIVE"),
                                     "Reset Password",
                                     "Assign Permisson")
                Next
                tbl_User = Nothing
            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click
        Try
            If dg_User.RowCount > 0 Then
                dg_User.Rows.Clear()
            End If
            Dim v_SQL As String = ""
            If txt_UserID.Text = "" And txt_UserName.Text = "" Then
                v_SQL = "SELECT * FROM fn_Report_SY_USER() ORDER BY [USERS_ID]"
            ElseIf txt_UserID.Text <> "" Then
                v_SQL = "SELECT * FROM fn_Report_SY_USER() WHERE [fn_SY_USER] like '%" & txt_UserID.Text & "%' ORDER BY [USERS_ID]"
            ElseIf txt_UserName.Text <> "" Then
                v_SQL = "SELECT * FROM fn_Report_SY_USER() WHERE [U_NAME] like '%" & txt_UserName.Text & "%' ORDER BY [USERS_ID]"
            End If
            Dim tbl_User As DataTable = SQL_GetTable(v_SQL)
            If tbl_User IsNot Nothing Then
                For Each DR As DataRow In tbl_User.Rows
                    dg_User.Rows.Add(DR("USERS_ID"),
                                     DR("U_NAME"),
                                     DR("U_TYPE"),
                                     DR("EMP_DEPT"),
                                     DR("EMP_TITLE"),
                                     DR("IS_ACTIVE"),
                                     "Reset Password",
                                     "Assign Permisson")
                Next
                tbl_User = Nothing
            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        Try
            Dim F As New frm_User_New
            F.FormBorderStyle = FormBorderStyle.None
            F.Show()
            btn_Query.PerformClick()
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False
        Try
            Dim tbl_User = SQL_GetTable("SELECT * FROM fn_Report_SY_USER() ORDER BY [USERS_ID]")
            If tbl_User IsNot Nothing Then
                If tbl_User.Rows.Count > 0 Then
                    Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx", .FileName = "User List"}
                        If sfd.ShowDialog = DialogResult.OK Then
                            Try
                                Using v_workbook As XLWorkbook = New XLWorkbook()
                                    v_workbook.Worksheets.Add(tbl_User, "USERS")
                                    v_workbook.SaveAs(sfd.FileName)
                                End Using
                                MessageBox.Show("Export data to excel file successful.", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Catch ex As Exception
                                WriteError(ex.Message)
                                MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End Using
                    tbl_User = Nothing
                End If
            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        Me.Enabled = True
    End Sub


    Private Sub dg_User_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_User.CellContentClick
        Try
            If (e.ColumnIndex = 0) Then
                Dim F As New frm_User_Edit
                F.FormBorderStyle = FormBorderStyle.None
                F.txt_UserID.Text = dg_User.CurrentRow.Cells("User_ID").Value
                F.cmb_UserStatus.SelectedItem = dg_User.CurrentRow.Cells("User_Status").Value.ToString.Trim
                F.txt_UserName.Text = dg_User.CurrentRow.Cells("User_Name").Value.ToString.Trim
                F.cmb_UserType.SelectedItem = dg_User.CurrentRow.Cells("User_Type").Value.ToString.Trim
                F.txt_Dept.Text = dg_User.CurrentRow.Cells("Department").Value.ToString.Trim
                F.txt_JobTitle.Text = dg_User.CurrentRow.Cells("Job_Title").Value.ToString.Trim
                F.ShowDialog()
                btn_Query.PerformClick()
            ElseIf (e.ColumnIndex = 6) Then
                Dim F As New frm_Reset_Password
                F.FormBorderStyle = FormBorderStyle.None
                F.txt_UserID.Text = dg_User.CurrentRow.Cells("User_ID").Value
                F.txt_UserName.Text = dg_User.CurrentRow.Cells("User_Name").Value.ToString.Trim
                F.ShowDialog()
            ElseIf (e.ColumnIndex = 7) Then
                Dim F As New frm_User_Permission_Mgt
                F.FormBorderStyle = FormBorderStyle.None
                F.txt_User_ID.Text = dg_User.CurrentRow.Cells("User_ID").Value
                F.txt_User_Name.Text = dg_User.CurrentRow.Cells("User_Name").Value.ToString.Trim
                F.ShowDialog()
            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class