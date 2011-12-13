Imports System.Data.OleDb

Public Class clsEntryHasil
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim oCmd As New OleDbCommand
    Dim sSql As String
    Public Property KodeHasil As String
    Public Property KodeReg As String
    Public Property KodeInstalasi As String
    Public Property KodeSample As String
    Public Property TglHasil As String
    Public Property JamHasil As String
    Public Property KodePetugas As String
    Public Property Kesimpulan As String
    Public Property NoUrut As Integer
    Public Property KdJnsUji As String
    Public Property Hasil As String
    Public Property Merk As String
    Public Property Pengambil As String
    Public Property TglVoid As String
    Public Property JamVoid As String
    Public Property KodePetugasVoid As String
    Public Property TglVerif As String
    Public Property JamVerif As String
    Public Property KodePetugasVerif As String
    Public Property isLock As Boolean
    Public Property Permenkes As String
    Public Property ISO As String
    Public Property Ket As String
    Public Property NoSeri As String
    Public Property Cetak As Boolean
    Public Property NoInstalasi As String

    Public Function UjiPerInstDS() As DataSet
        sSql = "SELECT  dd.fs_nm_grup_jenis_uji , " & vbCrLf _
             & "        bb.fs_kd_jenis_uji , " & vbCrLf _
             & "        cc.fs_nm_jenis_uji , " & vbCrLf _
             & "        cc.fs_satuan , " & vbCrLf _
             & "        ISNULL(ee.fs_hasil,'') AS fs_hasil , " & vbCrLf _
             & "        cc.fs_standar, " & vbCrLf _
             & "        cc.fs_Metode, " & vbCrLf _
             & "        aa.fs_kd_sample " & vbCrLf _
             & "FROM    TA_TRS_UJI4 aa " & vbCrLf _
             & "INNER JOIN TA_TARIF4 bb ON aa.fs_kd_tarif = bb.fs_kd_tarif " & vbCrLf _
             & "INNER JOIN TA_JENIS_UJI cc ON bb.fs_kd_jenis_uji = cc.fs_kd_jenis_uji " & vbCrLf _
             & "INNER JOIN TA_GRUP_JENIS_UJI dd ON cc.fs_kd_grup_jenis_uji = dd.fs_kd_grup_jenis_uji " & vbCrLf _
             & "LEFT JOIN TA_TRS_HASIL2 ee ON ee.fs_kd_jenis_uji = cc.fs_kd_jenis_uji AND aa.fs_kd_sample = ee.fs_kd_sample " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KodeReg & "' " & vbCrLf _
             & "        AND aa.fs_kd_sample = '" & KodeSample & "' " & vbCrLf _
             & "        AND cc.fs_kd_instalasi = '" & KodeInstalasi & "' "
        Try
            oDS.Clear()
            If conn.oConn.State = ConnectionState.Closed Then
                conn.open()
            End If
            'conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS)
            If oDS.Tables(0).Rows.Count > 0 Then
                Return oDS
            Else
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
                Return oDS
                Exit Try
            End If
            conn.oConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return Nothing
    End Function

    Public Sub Save()
        sSql = "INSERT INTO TA_TRS_HASIL " & vbCrLf _
             & "            (fs_kd_trs  " & vbCrLf _
             & "            ,fd_tgl_trs " & vbCrLf _
             & "            ,fs_jam_trs " & vbCrLf _
             & "            ,fs_kd_petugas " & vbCrLf _
             & "            ,fs_kd_reg " & vbCrLf _
             & "            ,fs_kd_sample " & vbCrLf _
             & "            ,fs_kd_instalasi " & vbCrLf _
             & "            ,fs_merk " & vbCrLf _
             & "            ,fs_pengambil " & vbCrLf _
             & "            ,fs_kesimpulan " & vbCrLf _
             & "            ,fs_permenkes " & vbCrLf _
             & "            ,fs_iso " & vbCrLf _
             & "            ,fs_ket " & vbCrLf _
             & "            ,fs_no_seri " & vbCrLf _
             & "            ,fs_no_instalasi) " & vbCrLf _
             & "    VALUES " & vbCrLf _
             & "            ('" & KodeHasil & "' " & vbCrLf _
             & "            ,'" & TglHasil & "' " & vbCrLf _
             & "            ,'" & JamHasil & "' " & vbCrLf _
             & "            ,'" & KodePetugas & "' " & vbCrLf _
             & "            ,'" & KodeReg & "' " & vbCrLf _
             & "            ,'" & KodeSample & "' " & vbCrLf _
             & "            ,'" & KodeInstalasi & "' " & vbCrLf _
             & "            ,'" & Merk & "' " & vbCrLf _
             & "            ,'" & Pengambil & "' " & vbCrLf _
             & "            ,'" & Kesimpulan & "' " & vbCrLf _
             & "            ,'" & Permenkes & "' " & vbCrLf _
             & "            ,'" & ISO & "' " & vbCrLf _
             & "            ,'" & Ket & "' " & vbCrLf _
             & "            ,'" & NoSeri & "' " & vbCrLf _
             & "            ,'" & NoInstalasi & "') "
        Try
            If conn.oConn.State = ConnectionState.Closed Then
                conn.open()
            End If
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub
    Public Sub SaveDetil()
        sSql = "INSERT INTO TA_TRS_HASIL2 " & vbCrLf _
             & "            (fs_kd_trs " & vbCrLf _
             & "            ,fs_kd_sample " & vbCrLf _
             & "            ,fn_no_urut " & vbCrLf _
             & "            ,fs_kd_jenis_uji " & vbCrLf _
             & "            ,fs_hasil) " & vbCrLf _
             & "    VALUES " & vbCrLf _
             & "            ('" & KodeHasil & "' " & vbCrLf _
             & "            ,'" & KodeSample & "' " & vbCrLf _
             & "            ,'" & NoUrut & "' " & vbCrLf _
             & "            ,'" & KdJnsUji & "' " & vbCrLf _
             & "            ,'" & Hasil & "') "
        Try
            If conn.oConn.State = ConnectionState.Closed Then
                conn.open()
            End If
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub Delete()
        sSql = "DELETE TA_TRS_HASIL " & vbCrLf _
             & "WHERE   fs_kd_trs = '" & KodeHasil & "' "
        Try
            If conn.oConn.State = ConnectionState.Closed Then
                conn.open()
            End If
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub DeleteDetil()
        sSql = "DELETE TA_TRS_HASIL2 " & vbCrLf _
             & "WHERE   fs_kd_trs = '" & KodeHasil & "' "
        Try
            If conn.oConn.State = ConnectionState.Closed Then
                conn.open()
            End If
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Function isExist(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TRS_HASIL " & vbCrLf _
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

    Public WriteOnly Property vKode As String
        Set(ByVal value As String)
            sSql = "SELECT *    FROM TA_TRS_HASIL " & vbCrLf _
                 & "WHERE       fs_kd_trs = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                KodeHasil = oDR("fs_kd_trs")
                TglHasil = oDR("fd_tgl_trs")
                JamHasil = oDR("fs_jam_trs")
                KodePetugas = oDR("fs_kd_petugas")
                TglVoid = oDR("fd_tgl_void")
                JamVoid = oDR("fs_jam_void")
                KodePetugasVoid = oDR("fs_kd_petugas_void")
                KodeReg = oDR("fs_kd_reg")
                KodeInstalasi = oDR("fs_kd_instalasi")
                KodeSample = oDR("fs_kd_sample")
                Merk = oDR("fs_merk")
                Pengambil = oDR("fs_pengambil")
                Kesimpulan = oDR("fs_kesimpulan")
                TglVerif = oDR("fd_tgl_ver")
                JamVerif = oDR("fs_jam_ver")
                KodePetugasVerif = oDR("fs_kd_petugas_ver")
                isLock = oDR("fb_lock")
                Permenkes = oDR("fs_permenkes")
                ISO = oDR("fs_iso")
                Ket = oDR("fs_ket")
                NoSeri = oDR("fs_no_seri")
                Cetak = oDR("fb_cetak")
                NoInstalasi = oDR("fs_no_instalasi")
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Sub UpdateNomor()
        sSql = "UPDATE  TA_TRS_HASIL " & vbCrLf _
             & "   SET  fs_no_seri = '" & NoSeri & "' " & vbCrLf _
             & "        ,fs_iso = '" & ISO & "' " & vbCrLf _
             & "        ,fs_permenkes = '" & Permenkes & "' " & vbCrLf _
             & "        ,fs_ket = '" & Ket & "' " & vbCrLf _
             & "WHERE   fs_kd_trs = '" & KodeHasil & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub UpdateStatusCetak()
        sSql = "UPDATE  TA_TRS_HASIL " & vbCrLf _
             & "   SET  fb_cetak = '" & Cetak & "' " & vbCrLf _
             & "WHERE   fs_kd_trs = '" & KodeHasil & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Function CariHasilDS()
        Dim table As New DataTable
        sSql = "SELECT  aa.fs_kd_trs , " & vbCrLf _
             & "        bb.fd_tgl_reg , " & vbCrLf _
             & "        cc.fd_tgl_estimasi , " & vbCrLf _
             & "        aa.fs_kd_sample , " & vbCrLf _
             & "        ISNULL(ee.fs_nm_jenis_sample,'') fs_nm_jenis_sample, " & vbCrLf _
             & "        ISNULL(aa.fs_merk,'') fs_merk, " & vbCrLf _
             & "        ISNULL(ff.fs_nm_rujukan,'') fs_nm_rujukan " & vbCrLf _
             & "FROM    TA_TRS_HASIL aa " & vbCrLf _
             & "        INNER JOIN TA_TRS_REG bb ON aa.fs_kd_reg = bb.fs_kd_reg " & vbCrLf _
             & "        INNER JOIN TA_TRS_UJI cc ON bb.fs_kd_reg = cc.fs_kd_reg " & vbCrLf _
             & "        LEFT JOIN TA_TRS_SAMPLE dd ON aa.fs_kd_sample = dd.fs_kd_sample " & vbCrLf _
             & "        LEFT JOIN TA_JENIS_SAMPLE ee ON dd.fs_kd_jenis_sample = ee.fs_kd_jenis_sample " & vbCrLf _
             & "        LEFT JOIN TA_RUJUKAN ff ON ff.fs_kd_rujukan = bb.fs_kd_rujukan " & vbCrLf _
             & "ORDER BY aa.fs_kd_trs "
        Try
            conn.open()
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function
End Class
