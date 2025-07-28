Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_Credit_Note_Report
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
End Class