Imports System.Data.OleDb
Public Class clsMR
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oCmd As New OleDbCommand
    Dim oParam As New clsParam
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Public Property xKode As String
    Public Property xNama As String
    Public Property xAlm1 As String
    Public Property xAlm2 As String
    Public Property xKota As String
    Public Property xTelp As String
    Public Property xTglLahir As String
    Public Property xTempatLahir As String
    Public Property xKodePos As Integer
    Public Property xKelurahan As String
    Public Property xKdSex As String
    Public Property xNmSex As String
    Public Sub save()
        sSql = "INSERT INTO TC_MR " _
             & "(fs_mr " _
             & ",fs_nm_pasien " _
             & ",fs_alm_pasien " _
             & ",fs_alm_pasien2 " _
             & ",fs_kota " _
             & ",fs_sex " _
             & ",fd_tgl_lahir " _
             & ",fs_tempat_lahir " _
             & ",fs_telpon) " _
             & "VALUES " _
             & "('" & xKode & "'" _
             & ",'" & xNama & "'" _
             & ",'" & xAlm1 & "'" _
             & ",'" & xAlm2 & "'" _
             & ",'" & xKota & "'" _
             & ",'" & xKdSex & "'" _
             & ",'" & xTglLahir & "'" _
             & ",'" & xTempatLahir & "'" _
             & ",'" & xTelp & "')"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public WriteOnly Property vKode As String
        Set(ByVal value As String)
            sSql = "SELECT  aa.* ," _
                 & "        ISNULL(fs_nm_sex, '') fs_nm_sex " _
                 & "FROM    TC_MR aa " _
                 & "LEFT JOIN tc_sex bb ON aa.fs_sex = bb.fs_kd_sex " _
                 & "WHERE fs_mr = '" & value & "'"
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                xNama = oDR("fs_nm_pasien")
                xAlm1 = oDR("fs_alm_pasien")
                xAlm2 = oDR("fs_alm_pasien2")
                xKota = oDR("fs_kota")
                xTelp = oDR("fs_telpon")
                xTglLahir = oDR("fd_tgl_lahir")
                xTempatLahir = oDR("fs_tempat_lahir")
                xKdSex = oDR("fs_sex")
                xNmSex = oDR("fs_nm_sex")
                oDR.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            conn.close()
        End Set
    End Property

    Public Sub Update()
        sSql = "UPDATE  TC_MR " & vbCrLf _
             & "SET     fs_nm_pasien = '" & xNama & "' " & vbCrLf _
             & "        ,fs_alm_pasien = '" & xAlm1 & "' " & vbCrLf _
             & "        ,fs_alm_pasien2 = '" & xAlm2 & "' " & vbCrLf _
             & "        ,fs_kota = '" & xKota & "' " & vbCrLf _
             & "        ,fs_sex = '" & xKdSex & "' " & vbCrLf _
             & "        ,fd_tgl_lahir ='" & xTglLahir & "' " & vbCrLf _
             & "        ,fs_tempat_lahir ='" & xTempatLahir & "' " & vbCrLf _
             & "        ,fs_telpon = '" & xTelp & "' " & vbCrLf _
             & "WHERE   fs_mr = '" & xKode & "'"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
