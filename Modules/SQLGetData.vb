
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO


Public Class SQLGetData

    Public Shared Function SQL_GetTable(ByVal SqlString As String) As DataTable
        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            SQLCNN.Open()

            Dim CMD As New SqlCommand
            With CMD
                .Connection = SQLCNN
                .CommandTimeout = 0
                .CommandType = CommandType.Text
                .CommandText = SqlString
            End With
            Dim DAP As New SqlDataAdapter
            DAP.SelectCommand = CMD
            Dim ds As New DataSet
            DAP.Fill(ds)
            Dim Table As New DataTable
            Table = ds.Tables(0)
            SQLCNN.Close()
            Return Table
        Catch ex As Exception
            MessageBox.Show(ex.ToString & vbNewLine & ex.StackTrace, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Shared Function SQL_GetField(ByVal ST_SQL As String) As String
        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            SQLCNN.Open()
            Dim CMD As SqlCommand
            Dim DTReader As SqlDataReader
            CMD = New SqlCommand(ST_SQL, SQLCNN)
            DTReader = CMD.ExecuteReader()
            DTReader.Read()

            If DTReader.HasRows = True Then
                Return DTReader(0)
                DTReader.Close()
                SQLCNN.Close()
                Exit Function
            End If
            DTReader.Close()
            SQLCNN.Close()
            Return ""
        Catch ex As Exception
            WriteError(Err.Description)
            MessageBox.Show(ex.ToString & vbNewLine & ex.StackTrace, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Public Shared Function GetImageField(ByVal sqlst As String) As Image
        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            Dim DBCommand As SqlCommand
            SQLCNN.Open()
            DBCommand = New SqlCommand(sqlst, SQLCNN)
            Dim b() As Byte
            b = DBCommand.ExecuteScalar()
            If b IsNot Nothing Then
                If (b.Length > 0) Then
                    Dim stream As New MemoryStream(b, True)
                    stream.Write(b, 0, b.Length)
                    Return New Bitmap(stream)
                    stream.Close()
                End If
            End If
            SQLCNN.Close()
            Return Nothing
        Catch ex As Exception
            WriteError(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function SQL_GetField_SC(ByVal ST_SQL As String) As Boolean
        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            Dim CMD As SqlCommand
            Dim DTReader As SqlDataReader

            SQLCNN.Open()
            CMD = New SqlCommand(ST_SQL, SQLCNN)
            DTReader = CMD.ExecuteReader()
            DTReader.Read()
            If DTReader.HasRows = True Then
                Return DTReader(0)
                DTReader.Close()
                SQLCNN.Close()
            End If
            DTReader.Close()
            SQLCNN.Close()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.ToString & vbNewLine & ex.StackTrace, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function SQL_GetField_Num(ByVal ST_SQL As String) As Integer
        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            Dim CMD As SqlCommand
            Dim DTReader As SqlDataReader

            SQLCNN.Open()
            CMD = New SqlCommand(ST_SQL, SQLCNN)
            DTReader = CMD.ExecuteReader()
            DTReader.Read()

            If DTReader.HasRows = True Then
                Return DTReader(0)
                DTReader.Close()
                SQLCNN.Close()
                Exit Function
            End If
            DTReader.Close()
            SQLCNN.Close()
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.ToString & vbNewLine & ex.StackTrace, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Shared Function SQL_ExecuteNonQuery(ByVal ST_SQL As String) As Boolean
        Try
            If SQLCNN.State = ConnectionState.Open Then SQLCNN.Close()
            SQLCNN.ConnectionString = Read_CNN()
            SQLCNN.Open()
            Dim CMD As New SqlCommand(ST_SQL, SQLCNN)
            CMD.CommandTimeout = 0
            CMD.ExecuteNonQuery()
            SQLCNN.Close()
            Return True
        Catch ex As Exception
            WriteError(Err.Description)
            Return False
        End Try
    End Function

    Shared Sub WriteError(ByVal ST_Error As String)
        Try
            Dim ws As New StreamWriter(Application.StartupPath + "\LOG.txt", True, System.Text.Encoding.Default)
            ws.WriteLine("")
            ws.WriteLine("")
            ws.WriteLine("----------------------------------------------")
            ws.WriteLine(Format(Now(), "dd-MM-yyyy HH:mm:ss"))
            ws.WriteLine(ST_Error)
            ws.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Shared Function NumToDate(ByVal fNum As String) As Date
        Dim ndate As New Windows.Forms.DateTimePicker
        Dim yr As Integer = CInt(Val(fNum.Substring(0, 4)))
        Dim mt As Integer = CInt(Val(fNum.Substring(4, 2)))
        Dim dy As Integer = CInt(Val(fNum.Substring(6, 2)))
        ndate.Value = DateSerial(yr, mt, dy)
        Return ndate.Value
    End Function




End Class
