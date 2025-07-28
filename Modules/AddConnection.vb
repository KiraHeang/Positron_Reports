Imports Microsoft.Win32
Imports System.Data.SqlClient


Module AddConnection
    Public V_ProjectName As String = "Positron_Reports"
    Public FileINI = Application.StartupPath + "\Settings.ini"
    Public rServerName, rDBUserID, rDBPassword, rDBName As String

    '########## Finding ##############
    Public v_Find_Store As String = Nothing
    Public v_Find_StoreName As String = Nothing

    '########## Connection ##########
    Public SQLCNN As New SqlConnection
    Private Section = "Settings"
    Private ServerName = "ServerName"
    Private DBUser = "DBUserID"
    Private DBPassword = "DBPassword"
    Private DBName = "DBName"

    '########## LOG IN ##############
    Public v_LoginStatus As Boolean = False
    Public v_UserID As String = ""
    Public v_UserName As String = ""
    Public v_UserType As String = ""
    Public v_LastUserLogin As String = ""


    '***********************SQLCNN***************************
    Public Function Write_CNN(ByVal pServerName As String, ByVal pDBUserID As String, ByVal pDBPassword As String, ByVal pDBName As String) As Boolean
        Try
            WriteIni(FileINI, Section, ServerName, Encryption(pServerName))
            WriteIni(FileINI, Section, DBUser, Encryption(pDBUserID))
            WriteIni(FileINI, Section, DBPassword, Encryption(pDBPassword))
            WriteIni(FileINI, Section, DBName, Encryption(pDBName))
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function Read_CNN() As String
        Try
            rServerName = Decryption(ReadIni(FileINI, Section, ServerName, ""))
            rDBUserID = Decryption(ReadIni(FileINI, Section, DBUser, ""))
            rDBPassword = Decryption(ReadIni(FileINI, Section, DBPassword, ""))
            rDBName = Decryption(ReadIni(FileINI, Section, DBName, ""))
            Return "Data Source=" & rServerName & ";Initial Catalog=" & rDBName & ";Persist Security Info=True;User ID=" & rDBUserID & ";Password=" & rDBPassword
            'Return V_CNNstring
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    '*********************** User Last Login ***************************
    Public Function WriteLastLogin(ByVal LastUserLogin As String) As Boolean
        Try
            WriteIni(FileINI, Section, V_LastUserLogin, Encryption(LastUserLogin))
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function ReadLastLogin() As String
        Try
            Dim rLastUserLogin As String = Decryption(ReadIni(FileINI, Section, v_LastUserLogin, ""))
            Return rLastUserLogin
        Catch ex As Exception
            MessageBox.Show(ex.Message, V_ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
        Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
        ByVal lpKeyName As String, ByVal lpString As String,
        ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
        Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
        ByVal lpKeyName As String, ByVal lpDefault As String,
        ByVal lpReturnedString As String, ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32

    Public Sub WriteIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function


    Public Function Encryption(ByVal StrConnection As String) As String
        Dim i As Integer
        Dim st As String = ""
        For i = 1 To Len(StrConnection)
            st = st & Chr(Asc(Mid(StrConnection, i, 1)) + 130)
        Next
        Encryption = st
    End Function

    Public Function Decryption(ByVal StrEncriptConnection As String) As String
        Dim i As Integer
        Dim st As String = ""
        For i = 1 To Len(StrEncriptConnection)
            st = st & Chr(Asc(Mid(StrEncriptConnection, i, 1)) - 130)
        Next
        Decryption = st
    End Function

End Module
