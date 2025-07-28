Imports Positron_Reports.SQLGetData

Public Class frm_Sales_AR_Reports_Mgt
    Private Sub btn_outstanding_repor_Click(sender As Object, e As EventArgs) Handles btn_outstanding_report.Click
        Dim F As New frm_Outstdaning_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub frm_Sales_AR_Reports_Mgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If v_UserType = "Administrator" Then
                btn_outstanding_report.Enabled = True
                btn_ar_credit_meo.Enabled = True
                btn_ar_invoice_report.Enabled = True
                btn_delivery_report.Enabled = True
                btn_jny_order_report.Enabled = True
                btn_sales_order_report.Enabled = True

                btn_Sales_Order_Summary_Report.Enabled = True
                btn_delivery_summary_rp.Enabled = True
                btn_AR_Invoice_Summary_rp.Enabled = True
                btn_credit_note_summary_rp.Enabled = True

            Else
                btn_outstanding_report.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT001'")
                btn_ar_credit_meo.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT004'")
                btn_ar_invoice_report.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT005'")
                btn_delivery_report.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT003'")
                btn_jny_order_report.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT006'")
                btn_sales_order_report.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT002'")

                btn_Sales_Order_Summary_Report.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT024'")
                btn_delivery_summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT025'")
                btn_AR_Invoice_Summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT026'")
                btn_credit_note_summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT027'")

            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_delivery_report_Click(sender As Object, e As EventArgs) Handles btn_delivery_report.Click
        Dim F As New frm_Delivery_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_sales_order_report_Click(sender As Object, e As EventArgs) Handles btn_sales_order_report.Click
        Dim F As New frm_Sale_Order_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_Sales_Order_Summary_Report_Click(sender As Object, e As EventArgs) Handles btn_Sales_Order_Summary_Report.Click
        Dim F As New frm_Sales_Order_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_delivery_summary_rp_Click(sender As Object, e As EventArgs) Handles btn_delivery_summary_rp.Click
        Dim F As New frm_Delivery_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_AR_Invoice_Summary_rp_Click(sender As Object, e As EventArgs) Handles btn_AR_Invoice_Summary_rp.Click
        Dim F As New frm_AR_Invoice_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_jny_order_report_Click(sender As Object, e As EventArgs) Handles btn_jny_order_report.Click
        Dim F As New frm_JNY_Sale_Order_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_ar_credit_meo_Click(sender As Object, e As EventArgs) Handles btn_ar_credit_meo.Click
        Dim F As New frm_Credit_Note_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_credit_note_summary_rp_Click(sender As Object, e As EventArgs) Handles btn_credit_note_summary_rp.Click
        Dim F As New frm_AP_Credit_Note_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_ar_invoice_report_Click(sender As Object, e As EventArgs) Handles btn_ar_invoice_report.Click
        Dim F As New frm_AR_Invoice_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub
End Class