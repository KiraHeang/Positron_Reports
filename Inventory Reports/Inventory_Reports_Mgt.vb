Imports Positron_Reports.SQLGetData
Public Class Inventory_Reports_Mgt
    Private Sub Inventory_Reports_Mgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If v_UserType = "Administrator" Then
                btn_stock_movement_rp.Enabled = True
                btn_stock_adjustment_rp.Enabled = True
                btn_stock_on_hand_rp.Enabled = True
                bnt_stock_transfer_rp.Enabled = True
                btn_stock_transfer_for_sale.Enabled = True


            Else
                btn_stock_movement_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT007'")
                btn_stock_adjustment_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT008'")
                btn_stock_on_hand_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT009'")
                bnt_stock_transfer_rp.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT010'")
                btn_stock_transfer_for_sale.Enabled = SQL_GetField_SC("SELECT Access_Level FROM z_Report_User_Permission WHERE Users_ID='" & v_UserID & "' AND Function_ID='RPT011'")

            End If
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_stock_movement_rp_Click(sender As Object, e As EventArgs) Handles btn_stock_movement_rp.Click
        Dim F As New frm_Stock_Movenment_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_stock_adjustment_rp_Click(sender As Object, e As EventArgs) Handles btn_stock_adjustment_rp.Click
        Dim F As New frm_JNY_Stock_Adjustment_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_stock_on_hand_rp_Click(sender As Object, e As EventArgs) Handles btn_stock_on_hand_rp.Click
        Dim F As New frm_JNY_Stock_On_Hand_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub bnt_stock_transfer_rp_Click(sender As Object, e As EventArgs) Handles bnt_stock_transfer_rp.Click
        Dim F As New frm_JNY_Stock_Transfer_for_Sale_Report
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub

    Private Sub btn_stock_transfer_for_sale_Click(sender As Object, e As EventArgs) Handles btn_stock_transfer_for_sale.Click
        Dim F As New frm_JNY_Stock_Transfer_For_Sale
        F.FormBorderStyle = FormBorderStyle.None
        F.Show()
    End Sub
End Class