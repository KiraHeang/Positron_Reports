Imports Positron_Reports.SQLGetData

Public Class frm_Purchase_Reports_Mgt
    Private Sub frm_Purchase_Reports_Mgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If v_UserType = "Administrator" Then
                btn_purchase_order_rp.Enabled = True
                btn_goods_receipt_rp.Enabled = True
                btn_ap_invoice_rp.Enabled = True
                btn_ap_credit_note_rp.Enabled = True
                btn_purchase_summary_rp.Enabled = True
                btn_good_receipt_summary_rp.Enabled = True
                btn_ap_cn_summary_rp.Enabled = True
                btn_ap_inv_summary_rp.Enabled = True
            Else
                btn_purchase_order_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT013'")
                btn_goods_receipt_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT014'")
                btn_ap_invoice_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT015'")
                btn_ap_credit_note_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT016'")

                btn_purchase_summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT020'")
                btn_good_receipt_summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT021'")
                btn_ap_inv_summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT022'")
                btn_ap_cn_summary_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT023'")
            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_purchase_order_rp_Click(sender As Object, e As EventArgs) Handles btn_purchase_order_rp.Click
        Dim F As New frm_Purchase_Order_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_goods_receipt_rp_Click(sender As Object, e As EventArgs) Handles btn_goods_receipt_rp.Click
        Dim F As New frm_Good_Receipt_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_ap_invoice_rp_Click(sender As Object, e As EventArgs) Handles btn_ap_invoice_rp.Click
        Dim F As New frm_AP_Invoice_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_ap_credit_note_rp_Click(sender As Object, e As EventArgs) Handles btn_ap_credit_note_rp.Click
        Dim F As New frm_AP_Credit_Note_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_purchase_summary_rp_Click(sender As Object, e As EventArgs) Handles btn_purchase_summary_rp.Click
        Dim F As New frm_Purchase_Order_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_good_receipt_summary_rp_Click(sender As Object, e As EventArgs) Handles btn_good_receipt_summary_rp.Click
        Dim F As New frm_Goods_Receipt_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_ap_inv_summary_rp_Click(sender As Object, e As EventArgs) Handles btn_ap_inv_summary_rp.Click
        Dim F As New frm_AP_Invoice_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_ap_cn_summary_rp_Click(sender As Object, e As EventArgs) Handles btn_ap_cn_summary_rp.Click
        Dim F As New frm_AP_Credit_Note_Summary_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub
End Class