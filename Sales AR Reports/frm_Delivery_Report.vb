Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_Delivery_Report
    Dim cryRpt As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table


    ' P/Invoke declarations for window dragging
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
    'Public Sub RunReport()

    '    Try
    '            Read_CNN()
    '            ' Set runtime connection info (NOT ODBC)
    '            With crConnectionInfo
    '                .ServerName = rServerName           ' Example: "HEANGKIRA"
    '                .DatabaseName = rDBName             ' Example: "TRADAT"
    '                .UserID = rDBUserID                 ' Example: "sa"
    '                .Password = rDBPassword             ' Example: "kira23"
    '                .IntegratedSecurity = False
    '            End With
    '        ' Load Crystal Report (should NOT use ODBC)
    '        cryRpt.Load(Application.StartupPath & "\Reports\DELIVERY REPOER.rpt")
    '        ' Apply connection info to all tables in report
    '        CrTables = cryRpt.Database.Tables
    '            For Each CrTable In CrTables
    '                crtableLogoninfo = CrTable.LogOnInfo
    '                crtableLogoninfo.ConnectionInfo = crConnectionInfo
    '                CrTable.ApplyLogOnInfo(crtableLogoninfo)
    '            Next
    '            ' Apply connection info to subreports (if any)
    '            For Each section As Section In cryRpt.ReportDefinition.Sections
    '                For Each obj As ReportObject In section.ReportObjects
    '                    If TypeOf obj Is SubreportObject Then
    '                        Dim subRptObj As SubreportObject = CType(obj, SubreportObject)
    '                        Dim subRptDoc As ReportDocument = subRptObj.OpenSubreport(subRptObj.SubreportName)
    '                        For Each subTable As Table In subRptDoc.Database.Tables
    '                            Dim subLogonInfo As TableLogOnInfo = subTable.LogOnInfo
    '                            subLogonInfo.ConnectionInfo = crConnectionInfo
    '                            subTable.ApplyLogOnInfo(subLogonInfo)
    '                        Next
    '                    End If
    '                Next
    '            Next

    '            ' Set parameter values
    '            Dim FDate As Date = DateTime.Parse(dtp_FDate.Text)
    '        Dim TDate As Date = DateTime.Parse(dtp_TDate.Text)
    '        Dim FGCus As String = If(String.IsNullOrEmpty(txt_FGCus.Text), "", txt_FGCus.Text.Trim())
    '        Dim TGCus As String = If(String.IsNullOrEmpty(txt_TGCus.Text), "", txt_TGCus.Text.Trim())
    '        Dim FCus As String = If(String.IsNullOrEmpty(txt_FCus.Text), "", txt_FCus.Text.Trim())
    '        Dim TCus As String = If(String.IsNullOrEmpty(txt_TCus.Text), "", txt_TCus.Text.Trim())
    '        Dim FItem As String = If(String.IsNullOrEmpty(txt_FItemCode.Text), "", txt_FItemCode.Text.Trim())
    '        Dim TItem As String = If(String.IsNullOrEmpty(txt_TtemCode.Text), "", txt_TtemCode.Text.Trim())
    '        Dim SaleRap As String = If(cmb_saleman.Tag IsNot Nothing, cmb_saleman.Tag.ToString(), "")
    '        Dim Whs As String = If(cmb_select_whs.Tag IsNot Nothing, cmb_select_whs.Tag.ToString(), "")
    '        Dim Brand As String = If(cmb_brand.Tag IsNot Nothing, cmb_brand.Tag.ToString(), "")
    '        Dim Type As String = If(cmb_select_type.Tag IsNot Nothing, cmb_select_type.Tag.ToString(), "")

    '        cryRpt.SetParameterValue("@FDate", FDate)
    '        cryRpt.SetParameterValue("@TDate", TDate)
    '        cryRpt.SetParameterValue("@FGCus", FGCus)
    '        cryRpt.SetParameterValue("@TGCus", TGCus)
    '        cryRpt.SetParameterValue("@FCus", FCus)
    '        cryRpt.SetParameterValue("@TCus", TCus)
    '        cryRpt.SetParameterValue("@FItem", FItem)
    '        cryRpt.SetParameterValue("@TItem", TItem)
    '        cryRpt.SetParameterValue("@SaleRap", SaleRap)
    '        'cryRpt.SetParameterValue("@Whs", Whs)
    '        cryRpt.SetParameterValue("@Whs", "WH001")
    '        cryRpt.SetParameterValue("@Brand", Brand)
    '        cryRpt.SetParameterValue("@Type", "T-001")

    '        ' Show the report
    '        Dim F As New frm_Reports_Viewer()
    '        F.Crystal_Report_Viewer.ReportSource = cryRpt
    '        F.Crystal_Report_Viewer.Refresh()
    '        F.FormBorderStyle = FormBorderStyle.None
    '        F.WindowState = FormWindowState.Normal
    '        F.ShowDialog()

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        ' Clean up resources
    '        cryRpt.Close()
    '        cryRpt.Dispose()
    '    End Try
    'End Sub
    Public Sub RunReport()

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
                cryRpt.Load(Application.StartupPath & "\Reports\DELIVERY REPOER.rpt")
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

                ' Set parameter values
                Dim FDate As Date = DateTime.Parse(dtp_FDate.Text)
            Dim TDate As Date = DateTime.Parse(dtp_TDate.Text)
            Dim FGCus As String = If(String.IsNullOrEmpty(txt_FGCus.Text), "", txt_FGCus.Text.Trim())
            Dim TGCus As String = If(String.IsNullOrEmpty(txt_TGCus.Text), "", txt_TGCus.Text.Trim())
            Dim FCus As String = If(String.IsNullOrEmpty(txt_FCus.Text), "", txt_FCus.Text.Trim())
            Dim TCus As String = If(String.IsNullOrEmpty(txt_TCus.Text), "", txt_TCus.Text.Trim())
            Dim FItem As String = If(String.IsNullOrEmpty(txt_FItemCode.Text), "", txt_FItemCode.Text.Trim())
            Dim TItem As String = If(String.IsNullOrEmpty(txt_TtemCode.Text), "", txt_TtemCode.Text.Trim())
            Dim SaleRap As String = If(cmb_saleman.Tag IsNot Nothing, cmb_saleman.Tag.ToString(), "")
            Dim Whs As String = If(cmb_select_whs.Tag IsNot Nothing, cmb_select_whs.Tag.ToString(), "")
            Dim Brand As String = If(cmb_brand.Tag IsNot Nothing, cmb_brand.Tag.ToString(), "")
            Dim Type As String = If(cmb_select_type.Tag IsNot Nothing, cmb_select_type.Tag.ToString(), "")

            cryRpt.SetParameterValue("FDate", FDate)
            cryRpt.SetParameterValue("TDate", TDate)
            cryRpt.SetParameterValue("FGCus", FGCus)
            cryRpt.SetParameterValue("TGCus", TGCus)
            cryRpt.SetParameterValue("FCus", FCus)
            cryRpt.SetParameterValue("TCus", TCus)
            cryRpt.SetParameterValue("FItem", FItem)
            cryRpt.SetParameterValue("TItem", TItem)
            cryRpt.SetParameterValue("SaleRap", SaleRap)
            cryRpt.SetParameterValue("Whs", Whs)
            cryRpt.SetParameterValue("Brand", Brand)
            cryRpt.SetParameterValue("Type", Type)
            cryRpt.Refresh()

            ' Show the report
            Dim F As New frm_Reports_Viewer()
            F.Crystal_Report_Viewer.ReportSource = cryRpt
            F.Crystal_Report_Viewer.Refresh()
            F.FormBorderStyle = FormBorderStyle.None
            F.WindowState = FormWindowState.Normal
            F.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cryRpt.Close()
            cryRpt.Dispose()
        End Try
    End Sub
    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
        RunReport()
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

    Private Sub frm_Delivery_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_saleman.Text = ""
        cmb_brand.Text = ""
        cmb_select_type.Text = ""
        cmb_select_whs.Text = ""
        cmb_select_whs.Tag = Nothing
        cmb_select_type.Tag = Nothing
        cmb_brand.Tag = Nothing
        cmb_saleman.Tag = Nothing
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



    Private Sub btn_brand_Click(sender As Object, e As EventArgs) Handles btn_brand.Click
        Try
            F_Brand_Code = ""
            Dim F As New frm_Brand_List
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Brand_Code <> "" Then
                cmb_brand.Text = "✔ Selected"
                cmb_brand.Tag = F_Brand_Code
            Else
                cmb_brand.Text = ""
                cmb_brand.Tag = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_select_whs_Click(sender As Object, e As EventArgs) Handles btn_select_whs.Click
        Try
            F_Warehouse = ""
            Dim F As New frm_Find_Warehouse
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Warehouse <> "" Then
                cmb_select_whs.Text = "✔ Selected"
                cmb_select_whs.Tag = F_Warehouse
            Else
                cmb_select_whs.Text = ""
                cmb_select_whs.Tag = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_select_type_Click(sender As Object, e As EventArgs) Handles btn_select_type.Click
        Try
            F_TypeCode = ""
            Dim F As New frm_Type_List
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_TypeCode <> "" Then
                cmb_select_type.Text = "✔ Selected"
                cmb_select_type.Tag = F_TypeCode
            Else
                cmb_select_type.Text = ""
                cmb_select_type.Tag = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class