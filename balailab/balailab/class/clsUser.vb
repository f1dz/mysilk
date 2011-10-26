Imports System.Data.OleDb

Public Class clsUser
    Dim conn As New clsConn
    Dim oCmd As New OleDbCommand
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Dim oHelper As New clsHelper
    Public Property User As String
    Public Property NmUser As String
    Public Property Password As String
    Public Property Nip As String
    Public Property KdInstalasi As String
    Public Property Aktif As Boolean
    Public Property xMenu As String

    Public Function isAktif() As Boolean
        Dim Aktif As Boolean
        sSql = "SELECT * FROM TZ_USER" & vbCrLf _
             & "WHERE   fs_kd_user = '" & User & "' " & vbCrLf _
             & "        AND fb_aktif = 1 " & vbCrLf _
             & "        AND fs_pwd = '" & oHelper.crypt(Password) & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            If oCmd.ExecuteReader.HasRows Then
                Aktif = True
            Else
                Aktif = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
        Return Aktif
    End Function

    Public Function isExist(ByVal KdPetugas) As Boolean
        Dim Aktif As Boolean
        sSql = "SELECT * FROM TZ_USER" & vbCrLf _
             & "WHERE   fs_kd_user = '" & KdPetugas & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            If oCmd.ExecuteReader.HasRows Then
                Aktif = True
            Else
                Aktif = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
        Return Aktif
    End Function

    Public Sub Update()
        sSql = "UPDATE  TZ_USER " & vbCrLf _
             & "SET     fs_nm_user = '" & NmUser & "', " & vbCrLf _
             & "        fs_pwd = '" & oHelper.crypt(Password) & "', " & vbCrLf _
             & "        fs_nip = '" & Nip & "', " & vbCrLf _
             & "        fs_kd_instalasi = '" & KdInstalasi & "', " & vbCrLf _
             & "        fb_aktif = '" & Aktif & "' " & vbCrLf _
             & "WHERE   fs_kd_user = '" & User & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub Disable()
        sSql = "UPDATE  TZ_USER " & vbCrLf _
             & "SET     fb_aktif = '" & Aktif & "' " & vbCrLf _
             & "WHERE   fs_kd_user = '" & User & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub Insert()
        sSql = "INSERT  INTO TZ_USER " & vbCrLf _
             & "        (fs_kd_user " & vbCrLf _
             & "        ,fs_nm_user " & vbCrLf _
             & "        ,fs_pwd " & vbCrLf _
             & "        ,fs_kd_instalasi " & vbCrLf _
             & "        ,fs_nip " & vbCrLf _
             & "        ,fb_aktif) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & "        ('" & User & "' " & vbCrLf _
             & "        ,'" & NmUser & "' " & vbCrLf _
             & "        ,'" & oHelper.crypt(Password) & "' " & vbCrLf _
             & "        ,'" & KdInstalasi & "' " & vbCrLf _
             & "        ,'" & Nip & "' " & vbCrLf _
             & "        ," & Aktif & ") "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public WriteOnly Property vKode As String
        Set(ByVal value As String)
            sSql = "SELECT *    FROM TZ_USER " & vbCrLf _
                 & "WHERE       fs_kd_user = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    User = oDR("fs_kd_user")
                    NmUser = oDR("fs_nm_user")
                    Password = oHelper.crypt(oDR("fs_pwd"))
                    KdInstalasi = oDR("fs_kd_instalasi")
                    Nip = oDR("fs_nip")
                    Aktif = oDR("fb_aktif")
                Else
                    MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
                End If
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Function Akses(ByVal Menu As String) As Boolean
        Dim state As Boolean

        sSql = "SELECT *    FROM TZ_USER2 " & vbCrLf _
             & "WHERE       fs_menu = '" & Menu & "' " & vbCrLf _
             & "            AND fs_kd_user = '" & User & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDR = oCmd.ExecuteReader
            If oDR.HasRows Then
                state = True
            Else
                state = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return state
    End Function

    Public Sub InsertAkses()
        sSql = "INSERT INTO TZ_USER2 " & vbCrLf _
             & "VALUES ('" & User & "','" & xMenu & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DeleteAkses()
        sSql = "DELETE TZ_USER2 " & vbCrLf _
             & "WHERE fs_kd_user = '" & User & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
