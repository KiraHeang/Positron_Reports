Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Positron_Reports.SQLGetData

Public Class frm_Purchase_Order_Report
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

    Private Sub btn_saleman_Click(sender As Object, e As EventArgs) Handles btn_saleman.Click
        Try
            F_Salespersons = ""
            Dim F As New frm_Find_Salesperson
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()

            If F_Salespersons <> "" Then
                cmb_saleman.Text = "✔ Selected"
                cmb_saleman.Tag = F_Salespersons
            Else
                cmb_saleman.Text = ""
                cmb_saleman.Tag = Nothing
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

    Private Sub btn_FVendor_Click(sender As Object, e As EventArgs) Handles btn_FVendor.Click
        Try
            F_Vendor = ""
            Dim F As New frm_Vendor
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Vendor <> "" Then
                txt_FVendor.Text = F_Vendor
                txt_FVendor.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_TVendor_Click(sender As Object, e As EventArgs) Handles btn_TVendor.Click
        Try
            F_Vendor = ""
            Dim F As New frm_Vendor
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Vendor <> "" Then
                txt_TVendor.Text = F_Vendor
                txt_TVendor.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btn_twhs_Click(sender As Object, e As EventArgs) Handles btn_twhs.Click
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
                txt_TItemCode.Text = F_Item
                txt_TItemCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RunReport()
        Try
            Read_CNN() ' Assumes this method sets rServerName, rDBName, etc.

            With crConnectionInfo
                .ServerName = rServerName
                .DatabaseName = rDBName
                .UserID = rDBUserID
                .Password = rDBPassword
                .IntegratedSecurity = False
            End With

            cryRpt.Load(Application.StartupPath & "\Reports\PURCHASE ORDER REPORT.rpt")
            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

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

            Dim FDate As Date = DateTime.Parse(dtp_FDate.Text)
            Dim TDate As Date = DateTime.Parse(dtp_TDate.Text)
            Dim FGCus As String = If(String.IsNullOrEmpty(txt_FGCus.Text), "", txt_FGCus.Text.Trim())
            Dim TGCus As String = If(String.IsNullOrEmpty(txt_TGCus.Text), "", txt_TGCus.Text.Trim())
            Dim FVen As String = If(String.IsNullOrEmpty(txt_FVendor.Text), "", txt_FVendor.Text.Trim())
            Dim TVen As String = If(String.IsNullOrEmpty(txt_TVendor.Text), "", txt_TVendor.Text.Trim())
            Dim SaleRap As String = If(cmb_saleman.Tag IsNot Nothing, cmb_saleman.Tag.ToString(), "")
            Dim FWhs As String = If(String.IsNullOrEmpty(txt_fwhs.Text), "", txt_fwhs.Text.Trim())
            Dim TWhs As String = If(String.IsNullOrEmpty(txt_twhs.Text), "", txt_twhs.Text.Trim())
            Dim FBrand As String = If(String.IsNullOrEmpty(txt_fbrand.Text), "", txt_fbrand.Text.Trim())
            Dim TBrand As String = If(String.IsNullOrEmpty(txt_tbrand.Text), "", txt_tbrand.Text.Trim())
            Dim FType As String = If(String.IsNullOrEmpty(txt_ftype.Text), "", txt_ftype.Text.Trim())
            Dim TType As String = If(String.IsNullOrEmpty(txt_ttype.Text), "", txt_ttype.Text.Trim())
            Dim FItem As String = If(String.IsNullOrEmpty(txt_FItemCode.Text), "", txt_FItemCode.Text.Trim())
            Dim TItem As String = If(String.IsNullOrEmpty(txt_TItemCode.Text), "", txt_TItemCode.Text.Trim())

            cryRpt.SetParameterValue("@FDate", FDate)
            cryRpt.SetParameterValue("@TDate", TDate)
            cryRpt.SetParameterValue("@FVGCus", FGCus)
            cryRpt.SetParameterValue("@TVGCus", TGCus)
            cryRpt.SetParameterValue("@FVen", FVen)
            cryRpt.SetParameterValue("@TVen", TVen)
            cryRpt.SetParameterValue("@SaleRap", SaleRap)
            cryRpt.SetParameterValue("@FWhs", FWhs)
            cryRpt.SetParameterValue("@TWhs", TWhs)
            cryRpt.SetParameterValue("@FBrand", FBrand)
            cryRpt.SetParameterValue("@TBrand", TBrand)
            cryRpt.SetParameterValue("@FType", FType)
            cryRpt.SetParameterValue("@TType", TType)
            cryRpt.SetParameterValue("@FItem", FItem)
            cryRpt.SetParameterValue("@TItem", TItem)

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

    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        RunReport()
    End Sub
End Class