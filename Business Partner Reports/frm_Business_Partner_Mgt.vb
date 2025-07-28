Imports Positron_Reports.SQLGetData
Public Class frm_Business_Partner_Mgt
    Private Sub frm_Business_Partner_Mgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If v_UserType = "Administrator" Then
                btn_business_partner_reports.Enabled = True

            Else
                btn_business_partner_reports.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT019'")

            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class