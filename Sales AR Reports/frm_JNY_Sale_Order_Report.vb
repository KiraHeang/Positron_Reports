Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_JNY_Sale_Order_Report
    Dim cryRpt As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table
    Public F_Type_Code As String = ""
    Public F_Warehouse As String = ""

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

    Private Sub btn_Preview_Click(sender As Object, e As EventArgs) Handles btn_Preview.Click
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
            cryRpt.Load(Application.StartupPath & "\Reports\JNY SALE ORDER EEPORT.rpt")

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
            Dim FDate As String = dtp_FDate.Text
            Dim TDate As String = dtp_TDate.Text

            ' Set parameters to report
            cryRpt.SetParameterValue("FDate", FDate)
            cryRpt.SetParameterValue("TDate", TDate)


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
End Class