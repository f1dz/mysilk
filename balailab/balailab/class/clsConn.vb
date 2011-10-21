Imports System.Data.OleDb
Imports Microsoft.Win32
Imports System.IO
Public Class clsConn
    Const DB_USER As String = "HospitalX"
    Const DB_PASS As String = "intersoftindo"
    Public DB_SERVER As String = getServer()
    Public DB_NAME As String = getDB()
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oCmd As New OleDbCommand

    Public xConnStr As String = "PROVIDER=SQLOLEDB.1;" _
         & "Data Source=" & DB_SERVER & ";" _
         & "Initial Catalog=" & DB_NAME & ";" _
         & "User ID=" & DB_USER & ";" _
         & "Password=" & DB_PASS & ";"
    Public oConn As New OleDbConnection(xConnStr)

    Public Function getServer() As String
        Dim regKey As RegistryKey
        Dim xKeyVal As String
        regKey = Registry.CurrentUser.OpenSubKey("Software\Balailab", True)
        xKeyVal = regKey.GetValue("server", True)
        regKey.Close()
        Return xKeyVal
    End Function

    Public Function getDB() As String
        Dim regKey As RegistryKey
        Dim xKeyVal As String
        regKey = Registry.CurrentUser.OpenSubKey("Software\Balailab", True)
        xKeyVal = regKey.GetValue("database", True)
        regKey.Close()
        Return xKeyVal
    End Function
    Public Sub open()
        If oConn.State = ConnectionState.Closed Then
            oConn.Open()
        End If
    End Sub

    Public Sub close()
        oConn.Close()
    End Sub

    Public Function get_conn()
        Return oConn
    End Function
End Class
