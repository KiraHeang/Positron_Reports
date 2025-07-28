Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_Outstdaning_Report

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

    'Public Sub RunReport()
    '    Try
    '        Read_CNN()
    '        With crConnectionInfo
    '            .ServerName = rServerName           ' Example: "HEANGKIRA"
    '            .DatabaseName = rDBName             ' Example: "TRADAT"
    '            .UserID = rDBUserID                 ' Example: "sa"
    '            .Password = rDBPassword             ' Example: "kira23"
    '            .IntegratedSecurity = False
    '        End With
    '        ' Load Crystal Report (should NOT use ODBC)
    '        cryRpt.Load(Application.StartupPath & "\Reports\OUTSTANDING REPORT.rpt")
    '        ' Apply connection info to all tables in report
    '        CrTables = cryRpt.Database.Tables
    '        For Each CrTable In CrTables
    '            crtableLogoninfo = CrTable.LogOnInfo
    '            crtableLogoninfo.ConnectionInfo = crConnectionInfo
    '            CrTable.ApplyLogOnInfo(crtableLogoninfo)
    '        Next
    '        ' Apply connection info to subreports (if any)
    '        For Each section As Section In cryRpt.ReportDefinition.Sections
    '            For Each obj As ReportObject In section.ReportObjects
    '                If TypeOf obj Is SubreportObject Then
    '                    Dim subRptObj As SubreportObject = CType(obj, SubreportObject)
    '                    Dim subRptDoc As ReportDocument = subRptObj.OpenSubreport(subRptObj.SubreportName)

    '                    For Each subTable As Table In subRptDoc.Database.Tables
    '                        Dim subLogonInfo As TableLogOnInfo = subTable.LogOnInfo
    '                        subLogonInfo.ConnectionInfo = crConnectionInfo
    '                        subTable.ApplyLogOnInfo(subLogonInfo)
    '                    Next
    '                End If
    '            Next
    '        Next
    '        ' Set parameters
    '        cryRpt.SetParameterValue("TDate", dtp_FDate.Text)
    '        cryRpt.SetParameterValue("FCus", txt_FCus.Text)
    '        cryRpt.SetParameterValue("TCus", txt_TCus.Text)
    '        cryRpt.SetParameterValue("SaleRap", btn_saleman)

    '        ' Show the report
    '        Dim F As New frm_Reports_Viewer()
    '        F.Crystal_Report_Viewer.ReportSource = cryRpt
    '        F.Crystal_Report_Viewer.Refresh()
    '        F.FormBorderStyle = FormBorderStyle.None
    '        F.WindowState = FormWindowState.Normal
    '        F.ShowDialog()

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Public Sub RunReport()
        Try
            Read_CNN()

            ' Set up the connection info
            With crConnectionInfo
                .ServerName = rServerName
                .DatabaseName = rDBName
                .UserID = rDBUserID
                .Password = rDBPassword
                .IntegratedSecurity = False
            End With

            ' Load Crystal Report
            cryRpt.Load(Application.StartupPath & "\Reports\OUTSTANDING REPORT.rpt")

            ' Apply connection info to all main report tables
            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            ' Apply connection info to subreport tables
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

            ' Prepare and validate parameters
            Dim TDate As Date = DateTime.Parse(dtp_FDate.Text) ' Convert to Date
            Dim FCus As String = txt_FCus.Text.Trim()
            Dim TCus As String = txt_TCus.Text.Trim()
            Dim SaleRap As String = If(cmb_saleman.Tag IsNot Nothing, cmb_saleman.Tag.ToString(), "") ' Handle null case

            ' Set parameters to report
            cryRpt.SetParameterValue("@TDate", TDate)
            cryRpt.SetParameterValue("@FCus", FCus)
            cryRpt.SetParameterValue("@TCus", TCus)
            cryRpt.SetParameterValue("@SaleRap", SaleRap)

            ' Show the report in viewer
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
End Class