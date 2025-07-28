Imports Positron_Reports.SQLGetData

Public Class frm_SystemMgt
    Private Sub frm_SystemMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ComProfile_Click(sender As Object, e As EventArgs)
        'Dim F As New frm_CompanyPro
        'F.FormBorderStyle = FormBorderStyle.None
        'F.ShowDialog()
    End Sub

    Private Sub btn_Classroom_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btn_Reason_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btn_VersionUpload_Click(sender As Object, e As EventArgs) Handles btn_VersionUpload.Click
        'Try
        '    Dim F As New frm_NewVersionUpload
        '    F.FormBorderStyle = FormBorderStyle.None
        '    F.ShowDialog()
        'Catch ex As Exception
        '    WriteError(ex.Message)
        '    MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btn_DocumentNo_Click(sender As Object, e As EventArgs)
        'Try
        '    Dim F As New frm_DocumentNo
        '    F.FormBorderStyle = FormBorderStyle.None
        '    F.ShowDialog()
        'Catch ex As Exception
        '    WriteError(ex.Message)
        '    MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btn_Database_Click(sender As Object, e As EventArgs) Handles btn_Database.Click
        Try
            Dim F As New frm_Database
            F.FormBorderStyle = FormBorderStyle.None
            F.ShowDialog()
        Catch ex As Exception
            WriteError(ex.Message)
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Monthly_Revenue_Click(sender As Object, e As EventArgs)
        'try
        '    dim f as new frm_monthlyrevenue
        '    f.formborderstyle = formborderstyle.none
        '    f.showdialog()
        'catch ex as exception
        '    writeerror(ex.message)
        '    messagebox.show(ex.message, v_projectname, messageboxbuttons.ok, messageboxicon.error)
        'end try
    End Sub
End Class