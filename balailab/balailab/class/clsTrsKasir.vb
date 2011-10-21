Imports System.Data.OleDb

Public Class clsTrsKasir
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim oCmd As New OleDbCommand
    Dim sSql As String
    Public Property KdKasir As String
    Public Property TglTrs As String
    Public Property JamTrs As String
    Public Property KdPetugasTrs As String
    Public Property TglVoid As String
    Public Property JamVoid As String
    Public Property KdPetugasVoid As String
    Public Property KdReg As String
    Public Property JmlBayar As Double
    Public Property NmPetugas As String
    Public Property NmPetugasVoid As String
    Public Property KdRujukan As String
    Public Property NmRujukan As String
    Public Property AlmRujuk1 As String
    Public Property AlmRujuk2 As String
    Public Property KotaRujuk As String
    Public Property TelpRujuk As String

    Public Sub Save()
        sSql = "INSERT INTO TA_TRS_KASIR " & vbCrLf _
             & "            (fs_kd_trs " & vbCrLf _
             & "            ,fd_tgl_trs " & vbCrLf _
             & "            ,fs_jam_trs " & vbCrLf _
             & "            ,fs_kd_petugas " & vbCrLf _
             & "            ,fs_kd_reg " & vbCrLf _
             & "            ,fn_bayar) " & vbCrLf _
             & "    VALUES " & vbCrLf _
             & "            ('" & KdKasir & "' " & vbCrLf _
             & "            ,'" & TglTrs & "' " & vbCrLf _
             & "            ,'" & JamTrs & "' " & vbCrLf _
             & "            ,'" & KdPetugasTrs & "' " & vbCrLf _
             & "            ,'" & KdReg & "' " & vbCrLf _
             & "            ," & JmlBayar & ") "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub Update()
        sSql = "UPDATE TA_TRS_KASIR " & vbCrLf _
             & "    SET fd_tgl_trs = '" & TglTrs & "' " & vbCrLf _
             & "        ,fs_jam_trs = '" & JamTrs & "' " & vbCrLf _
             & "        ,fs_kd_petugas = '" & KdPetugasTrs & "' " & vbCrLf _
             & "        ,fs_kd_reg = '" & KdReg & "'  " & vbCrLf _
             & "        ,fn_bayar = " & JmlBayar & " " & vbCrLf _
             & "WHERE   fs_kd_trs = '" & KdKasir & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub UpdateRegBayar()
        sSql = "UPDATE TA_TRS_REG " & vbCrLf _
             & "SET fb_bayar = 1 " & vbCrLf _
             & "WHERE fs_kd_reg = '" & KdReg & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Function Cari() As DataTable
        Dim table As New DataTable
        sSql = "SELECT  aa.fs_kd_trs , " & vbCrLf _
             & "        aa.fd_tgl_trs, " & vbCrLf _
             & "        aa.fs_kd_reg, " & vbCrLf _
             & "        cc.fs_nm_rujukan, " & vbCrLf _
             & "        aa.fn_bayar " & vbCrLf _
             & "FROM    TA_TRS_KASIR aa " & vbCrLf _
             & "        INNER JOIN TA_TRS_REG bb ON aa.fs_kd_reg = bb.fs_kd_reg " & vbCrLf _
             & "        INNER JOIN TA_RUJUKAN cc ON bb.fs_kd_rujukan = cc.fs_kd_rujukan " & vbCrLf _
             & "WHERE   aa.fd_tgl_void = '3000-01-01'"

        Try
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    Public WriteOnly Property vKodeBayar As String
        Set(ByVal value As String)
            sSql = "SELECT  aa.* , " & vbCrLf _
                 & "        bb.fs_nm_user  AS fs_nm_petugas, " & vbCrLf _
                 & "        ISNULL(ee.fs_nm_user,'') AS fs_nm_petugas_void, " & vbCrLf _
                 & "        dd.* " & vbCrLf _
                 & "FROM    TA_TRS_KASIR aa " & vbCrLf _
                 & "LEFT JOIN TZ_USER bb ON fs_kd_petugas = bb.fs_kd_user " & vbCrLf _
                 & "LEFT JOIN TA_TRS_REG cc ON aa.fs_kd_reg = cc.fs_kd_reg " & vbCrLf _
                 & "LEFT JOIN TA_RUJUKAN dd ON cc.fs_kd_rujukan = dd.fs_kd_rujukan " & vbCrLf _
                 & "LEFT JOIN TZ_USER ee ON aa.fs_kd_petugas_void=ee.fs_kd_user " & vbCrLf _
                 & "WHERE   fs_kd_trs = '" & value & "'"
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                KdKasir = oDR("fs_kd_trs")
                TglTrs = oDR("fd_tgl_trs")
                JamTrs = oDR("fs_jam_trs")
                KdPetugasTrs = oDR("fs_kd_petugas")
                TglVoid = oDR("fd_tgl_void")
                JamVoid = oDR("fs_jam_void")
                KdPetugasVoid = oDR("fs_kd_petugas_void")
                KdReg = oDR("fs_kd_reg")
                JmlBayar = oDR("fn_bayar")
                NmPetugas = oDR("fs_nm_petugas")
                NmPetugasVoid = oDR("fs_nm_petugas_void")
                KdRujukan = oDR("fs_kd_rujukan")
                NmRujukan = oDR("fs_nm_rujukan")
                AlmRujuk1 = oDR("fs_alm_rujukan")
                AlmRujuk2 = oDR("fs_alm_rujukan2")
                TelpRujuk = oDR("fs_telpon")
                KotaRujuk = oDR("fs_kota")
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public WriteOnly Property vKodeReg As String
        Set(ByVal value As String)
            sSql = "SELECT TOP 1 * FROM TA_TRS_KASIR " & vbCrLf _
                 & "WHERE   fs_kd_reg = '" & value & "' " & vbCrLf _
                 & "        AND fd_tgl_void = '3000-01-01' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                KdKasir = oDR("fs_kd_trs")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            conn.close()
        End Set
    End Property

    Public Sub OpenReg()
        sSql = "UPDATE TA_TRS_REG " & vbCrLf _
             & "SET fb_bayar = 0 " & vbCrLf _
             & "WHERE fs_kd_reg = '" & KdReg & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub Void()
        sSql = "UPDATE TA_TRS_KASIR " & vbCrLf _
             & "SET     fd_tgl_void = '" & TglVoid & "' " & vbCrLf _
             & "        ,fs_jam_void = '" & JamVoid & "' " & vbCrLf _
             & "        ,fs_kd_petugas_void = '" & KdPetugasVoid & "' " & vbCrLf _
             & "WHERE   fs_kd_trs = '" & KdKasir & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Function isVoid(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT      *    " & vbCrLf _
             & "FROM        TA_TRS_KASIR " & vbCrLf _
             & "WHERE       fs_kd_trs = '" & Kode & "' " & vbCrLf _
             & "            AND fd_tgl_void <> '3000-01-01' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDR = oCmd.ExecuteReader
            If oDR.HasRows Then
                status = True
            Else
                status = False
            End If
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return status
    End Function

    Public Function isExist(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TRS_KASIR " & vbCrLf _
             & "WHERE       fs_kd_trs = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDR = oCmd.ExecuteReader
            If oDR.HasRows Then
                status = True
            Else
                status = False
            End If
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return status
    End Function
End Class
