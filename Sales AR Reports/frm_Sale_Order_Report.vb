Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_Sale_Order_Report
    Dim cryRpt As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_Maximize_Click(sender As Object, e As EventArgs) Handles btn_Maximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
    Private Sub btn_FCus_Click(sender As Object, e As EventArgs) Handles btn_FCus.Click
        Try
            F_Customers = ""
            Dim F As New frm_Find_Customer
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Customers <> "" Then
                txt_FCus.Text = F_Customers
                txt_FCus.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_TCus_Click(sender As Object, e As EventArgs) Handles btn_TCus.Click
        Try
            F_Customers = ""
            Dim F As New frm_Find_Customer
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Customers <> "" Then
                txt_TCus.Text = F_Customers
                txt_TCus.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_FGCus_Click(sender As Object, e As EventArgs) Handles btn_FGCus.Click
        Try
            F_CusGroupCode = ""
            Dim F As New frm_Find_Customer_Group_Master_Data_
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_CusGroupCode <> "" Then
                txt_FGCus.Text = F_CusGroupCode
                txt_FGCus.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_TGCus_Click(sender As Object, e As EventArgs) Handles btn_TGCus.Click
        Try
            F_CusGroupCode = ""
            Dim F As New frm_Find_Customer_Group_Master_Data_
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_CusGroupCode <> "" Then
                txt_TGCus.Text = F_CusGroupCode
                txt_TGCus.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_fbrand_Click(sender As Object, e As EventArgs) Handles btn_fbrand.Click
        Try
            F_Brand_Code = ""
            Dim F As New frm_Brand_List
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Brand_Code <> "" Then
                txt_fbrand.Text = F_Brand_Code
                txt_fbrand.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_tbrand_Click(sender As Object, e As EventArgs) Handles btn_tbrand.Click
        Try
            F_Brand_Code = ""
            Dim F As New frm_Brand_List
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Brand_Code <> "" Then
                txt_tbrand.Text = F_Brand_Code
                txt_tbrand.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_ftype_Click(sender As Object, e As EventArgs) Handles btn_ftype.Click
        Try
            F_TypeCode = ""
            Dim F As New frm_Type_List
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_TypeCode <> "" Then
                txt_ftype.Text = F_TypeCode
                txt_ftype.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_ttype_Click(sender As Object, e As EventArgs) Handles btn_ttype.Click
        Try
            F_TypeCode = ""
            Dim F As New frm_Type_List
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_TypeCode <> "" Then
                txt_ttype.Text = F_TypeCode
                txt_ttype.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_FItem_Click(sender As Object, e As EventArgs) Handles btn_FItem.Click
        Try
            F_Item = ""
            Dim F As New frm_Items
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Item <> "" Then
                txt_FItemCode.Text = F_Item
                txt_FItemCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_TItem_Click(sender As Object, e As EventArgs) Handles btn_TItem.Click
        Try
            F_Item = ""
            Dim F As New frm_Items
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Item <> "" Then
                txt_TtemCode.Text = F_Item
                txt_TtemCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        Try

            Read_CNN()
            ' Set runtime connection info (NOT ODBC)
            With crConnectionInfo
                .ServerName = rServerName           ' Example: "HEANGKIRA"
                .DatabaseName = rDBName             ' Example: "TRADAT"
                .UserID = rDBUserID                 ' Example: "sa"
                .Password = rDBPassword             ' Example: "kira23"
                .IntegratedSecurity = False
            End With
            ' Load Crystal Report (should NOT use ODBC)
            cryRpt.Load(Application.StartupPath & "\Reports\Sale Order Report.rpt")
            ' Apply connection info to all tables in report
            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            ' Apply connection info to subreports (if any)
            For Each section As Section In cryRpt.ReportDefinition.Sections
                For Each obj As ReportObject In section.ReportObjects
                    If TypeOf obj Is SubreportObject Then
                        Dim subRptObj As SubreportObject = CType(obj, SubreportObject)
                        Dim subRptDoc As ReportDocument = subRptObj.OpenSubreport(subRptObj.SubreportName)
                        For Each subTable As Table In subRptDoc.Database.Tables
                            Dim subLogonInfo As TableLogOnInfo = subTable.LogOnInfo
                            subLogonInfo.ConnectionInfo = crConnectionInfo
                            subTable.ApplyLogOnInfo(subLogonInfo)
                        Next
                    End If
                Next
            Next

            Dim SaleRap As String = If(cmb_saleman.Tag IsNot Nothing, cmb_saleman.Tag.ToString(), "")

            cryRpt.SetParameterValue("@FDate", dtp_FDate.Value)
            cryRpt.SetParameterValue("@TDate", dtp_TDate.Value)
            cryRpt.SetParameterValue("@FGCus", txt_FGCus.Text.Trim())
            cryRpt.SetParameterValue("@TGCus", txt_TGCus.Text.Trim())
            cryRpt.SetParameterValue("@FCus", txt_FCus.Text.Trim())
            cryRpt.SetParameterValue("@TCus", txt_TCus.Text.Trim())
            cryRpt.SetParameterValue("@SaleRap", SaleRap)
            cryRpt.SetParameterValue("@FWhs", txt_fwhs.Text.Trim())
            cryRpt.SetParameterValue("@TWhs", txt_twhs.Text.Trim())
            cryRpt.SetParameterValue("@FBrand", txt_fbrand.Text.Trim())
            cryRpt.SetParameterValue("@TBrand", txt_tbrand.Text.Trim())
            cryRpt.SetParameterValue("@FType", txt_ftype.Text.Trim())
            cryRpt.SetParameterValue("@TType", txt_ttype.Text.Trim())
            cryRpt.SetParameterValue("@FItem", txt_FItemCode.Text.Trim())
            cryRpt.SetParameterValue("@TItem", txt_TtemCode.Text.Trim())


            Dim F As New frm_Reports_Viewer()
            F.Crystal_Report_Viewer.ReportSource = cryRpt
            F.Crystal_Report_Viewer.Refresh()
            F.FormBorderStyle = FormBorderStyle.None
            F.WindowState = FormWindowState.Normal
            F.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_fwhs_Click(sender As Object, e As EventArgs) Handles btn_fwhs.Click
        Try
            F_Warehouse = ""
            Dim F As New frm_Find_Warehouse
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Warehouse <> "" Then
                txt_fwhs.Text = F_Warehouse
                txt_fwhs.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_twhs_Click_1(sender As Object, e As EventArgs) Handles btn_twhs.Click
        Try
            F_Warehouse = ""
            Dim F As New frm_Find_Warehouse
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Warehouse <> "" Then
                txt_twhs.Text = F_Warehouse
                txt_twhs.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmb_saleman_CheckedChanged(sender As Object, e As EventArgs) Handles cmb_saleman.CheckedChanged
        Try
            If cmb_saleman.Checked Then
                ' Checkbox is checked: reflect selection state
                If cmb_saleman.Tag IsNot Nothing AndAlso cmb_saleman.Tag.ToString() <> "" Then
                    cmb_saleman.Text = "✔ Selected"  ' Hide specific SlpCode values
                Else
                    cmb_saleman.Text = "✔ All Selected"  ' Empty Tag indicates ALL
                End If
            Else
                ' Checkbox is unchecked: clear selection
                cmb_saleman.Text = "No Selection"
                cmb_saleman.Tag = ""  ' Treat as ALL in report
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_saleman_Click(sender As Object, e As EventArgs) Handles btn_saleman.Click
        Try
            F_Salespersons = ""
            Dim F As New frm_Find_Salesperson
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()

            If F_Salespersons = "ALL" Then
                cmb_saleman.Text = "✔ All Selected"
                cmb_saleman.Tag = ""  ' Empty string for all sales representatives
                cmb_saleman.Checked = True  ' Set checkbox state to checked
            ElseIf F_Salespersons <> "" Then
                cmb_saleman.Text = "✔ Selected"  ' Hide specific SlpCode values
                cmb_saleman.Tag = F_Salespersons  ' Store comma-separated SlpCode values
                cmb_saleman.Checked = True  ' Set checkbox state to checked
            Else
                cmb_saleman.Text = "No Selection"
                cmb_saleman.Tag = ""  ' Empty string for no selection (treat as ALL)
                cmb_saleman.Checked = False  ' Uncheck if no selection
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class