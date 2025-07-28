Imports System.Runtime.InteropServices
Imports ClosedXML.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Positron_Reports.SQLGetData
Public Class frm_Stock_Movenment_Report
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
    Public Sub RunReport()
        Try
            ' Load connection info from config or global
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
            cryRpt.Load(Application.StartupPath & "\Reports\STOCK MOVEMENT REPORT.rpt")
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
            ' Set parameters
            cryRpt.SetParameterValue("FDate", dtp_FDate.Text)
            cryRpt.SetParameterValue("TDate", dtp_TDate.Text)
            cryRpt.SetParameterValue("Warehouse", txt_whs.Text)

            ' Show the report
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

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        Try
            F_Warehouse = ""
            Dim F As New frm_Find_Warehouse
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
            If F_Warehouse <> "" Then
                txt_whs.Text = F_Warehouse
                txt_whs.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Exports_Click(sender As Object, e As EventArgs) 
        Try
            Dim tbl_Export As New DataTable()

            ' Build the SQL Command
            Using conn As New SqlClient.SqlConnection(Read_CNN)
                Using cmd As New SqlClient.SqlCommand("UPS_RPT_STOCK_MOVEMENT_REPORT", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@FDate", dtp_FDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@TDate", dtp_TDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@Warehouse", txt_whs.Text.Trim())

                    Using da As New SqlClient.SqlDataAdapter(cmd)
                        da.Fill(tbl_Export)
                    End Using
                End Using
            End Using

            ' Export to Excel
            If tbl_Export IsNot Nothing AndAlso tbl_Export.Rows.Count > 0 Then
                Using sfd As New SaveFileDialog() With {
                    .Filter = "Excel Workbook|*.xlsx",
                    .FileName = "Stock_Movement_Report"
                }
                    If sfd.ShowDialog = DialogResult.OK Then
                        Try
                            Using workbook As New XLWorkbook()
                                workbook.Worksheets.Add(tbl_Export, "Stock Movement")
                                workbook.SaveAs(sfd.FileName)
                            End Using
                            MessageBox.Show("Export successful!", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            WriteError(ex.Message)
                            MessageBox.Show("Error during export: " & ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End Using
            Else
                MessageBox.Show("No data found for export.", V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class