Imports System.Data.OleDb

Public Class clsTrsUji
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oCmd As New OleDbCommand
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Public Property KdReg As String
    Public Property KdTarif As String
    Public Property KdSample As String
    Public Property TglUji As String
    Public Property JamUji As String
    Public Property KdPetugas As String
    Public Property Total As Double
    Public Property KdPetugasVoid As String
    Public Property TglVoid As String
    Public Property JamVoid As String
    Public Property Qty As Integer
    Public Property SubTotal As Double
    Public Property KdKomponen As String
    Public Property NilaiKomponen As Double
    Public Property NilaiTarif As Double
    Public Property NoUrut As Integer
    Public Property TglEstimasi As String
    Public Property NmPetugas As String
    Public Property NmPetugasVoid As String
    Public Property Metode As String

    ' Berisi Header Transaksi Uji
    Public Sub InsertUji()
        sSql = "INSERT INTO TA_TRS_UJI " & vbCrLf _
             & "            (fs_kd_reg " & vbCrLf _
             & "            ,fd_tgl_uji " & vbCrLf _
             & "            ,fs_jam_uji " & vbCrLf _
             & "            ,fs_kd_petugas " & vbCrLf _
             & "            ,fn_total " & vbCrLf _
             & "            ,fd_tgl_estimasi " & vbCrLf _
             & "            ,fs_metode) " & vbCrLf _
             & "VALUES  " & vbCrLf _
             & "            ('" & KdReg & "' " & vbCrLf _
             & "            ,'" & TglUji & "' " & vbCrLf _
             & "            ,'" & JamUji & "' " & vbCrLf _
             & "            ,'" & KdPetugas & "' " & vbCrLf _
             & "            ," & Total & " " & vbCrLf _
             & "            ,'" & TglEstimasi & "' " & vbCrLf _
             & "            ,'" & Metode & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Masukkan Header Tarif
    Public Sub InsertUji2()
        sSql = "INSERT INTO TA_TRS_UJI2 " & vbCrLf _
             & "            (fs_kd_reg " & vbCrLf _
             & "            ,fs_kd_tarif " & vbCrLf _
             & "            ,fn_qty " & vbCrLf _
             & "            ,fn_tarif " & vbCrLf _
             & "            ,fn_sub_total) " & vbCrLf _
             & "VALUES  " & vbCrLf _
             & "            ('" & KdReg & "' " & vbCrLf _
             & "            ,'" & KdTarif & "' " & vbCrLf _
             & "            ," & Qty & " " & vbCrLf _
             & "            ," & NilaiTarif & " " & vbCrLf _
             & "            ," & SubTotal & ") "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Masukkan Komponen Tarif
    Public Sub InsertUji3()
        sSql = "INSERT INTO TA_TRS_UJI3 " & vbCrLf _
             & "            (fs_kd_reg " & vbCrLf _
             & "            ,fs_kd_tarif " & vbCrLf _
             & "            ,fs_kd_komponen " & vbCrLf _
             & "            ,fn_qty " & vbCrLf _
             & "            ,fn_nilai " & vbCrLf _
             & "            ,fn_sub_total " & vbCrLf _
             & "            ,fn_urut) " & vbCrLf _
             & "SELECT      '" & KdReg & "' " & vbCrLf _
             & "            ,'" & KdTarif & "'  " & vbCrLf _
             & "            ,fs_kd_komponen " & vbCrLf _
             & "            ," & Qty & " " & vbCrLf _
             & "            ,fn_nilai " & vbCrLf _
             & "            ,fn_nilai * " & Qty & " " & vbCrLf _
             & "            ,fn_no_urut " & vbCrLf _
             & "FROM        TA_TARIF3 " & vbCrLf _
             & "WHERE fs_kd_tarif = '" & KdTarif & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Masukkan ke Tabel TA_TRS_UJI4
    Public Sub InsertUji4()
        sSql = "INSERT INTO TA_TRS_UJI4 " & vbCrLf _
             & "            (fs_kd_reg " & vbCrLf _
             & "            ,fs_kd_tarif " & vbCrLf _
             & "            ,fs_kd_sample) " & vbCrLf _
             & "VALUES  " & vbCrLf _
             & "            ('" & KdReg & "' " & vbCrLf _
             & "            ,'" & KdTarif & "' " & vbCrLf _
             & "            ,'" & KdSample & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Hapus Tabel TA_TRS_UJI berdasarkan KdReg
    Public Sub DeleteUji()
        sSql = "DELETE  TA_TRS_UJI " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Hapus Tabel TA_TRS_UJI2 berdasarkan KdReg & Kode Tarif
    Public Sub DeleteUji2()
        sSql = "DELETE  TA_TRS_UJI2 " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' " '& vbCrLf _
        '& "        AND fs_kd_tarif = '" & KdTarif & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Hapus Tabel TA_TRS_UJI3 berdasarkan KdReg & Kode Tarif
    Public Sub DeleteUji3()
        sSql = "DELETE  TA_TRS_UJI3 " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' " ' & vbCrLf _
        '& "        AND fs_kd_tarif = '" & KdTarif & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Hapus Tabel TA_TRS_UJI4 berdasarkan KdReg & KdTarif
    Public Sub DeleteUji4()
        sSql = "DELETE  TA_TRS_UJI4 " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' " & vbCrLf _
             & "        AND fs_kd_tarif = '" & KdTarif & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    ' Batalkan Transaksi berdasarkan Kode Reg
    Public Sub VoidUji()
        sSql = "UPDATE  TA_TRS_UJI " & vbCrLf _
             & "SET     fd_tgl_void = '" & TglVoid & "' " & vbCrLf _
             & "        ,fs_jam_void = '" & JamVoid & "' " & vbCrLf _
             & "        ,fs_kd_petugas_void = '" & KdPetugasVoid & "' " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Function isAktif(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TRS_UJI " & vbCrLf _
             & "WHERE       fs_kd_reg = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDR = oCmd.ExecuteReader
            If oDR.HasRows Then
                status = True
            Else
                status = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
        Return status
    End Function

    Public Function TarifDS() As DataSet
        sSql = "SELECT  aa.* , " & vbCrLf _
             & "        bb.fs_nm_tarif " & vbCrLf _
             & "FROM    TA_TRS_UJI2 aa " & vbCrLf _
             & "        LEFT JOIN TA_TARIF bb ON aa.fs_kd_tarif = bb.fs_kd_tarif " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' "
        Try
            oDS.Clear()
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
        Return oDS
    End Function

    ' Clean Un Used tarif
    Public Sub CleanTrs()
        sSql = "DELETE  TA_TRS_UJI4 " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' " & vbCrLf _
             & "        AND fs_kd_tarif NOT IN (SELECT fs_kd_tarif  " & vbCrLf _
             & "                                FROM TA_TRS_UJI2  " & vbCrLf _
             & "                                WHERE  fs_kd_reg = '" & KdReg & "' ) "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public WriteOnly Property vKodeReg As String
        Set(ByVal value As String)
            sSql = "SELECT  aa.* , " & vbCrLf _
                 & "        ISNULL(bb.fs_nm_user,'') AS fs_nm_petugas , " & vbCrLf _
                 & "        ISNULL(cc.fs_nm_user,'') AS fs_nm_petugas_void " & vbCrLf _
                 & "FROM    TA_TRS_UJI aa " & vbCrLf _
                 & "        LEFT JOIN TZ_USER bb ON bb.fs_kd_user = aa.fs_kd_petugas " & vbCrLf _
                 & "        LEFT JOIN TZ_USER cc ON cc.fs_kd_user = aa.fs_kd_petugas_void  " & vbCrLf _
                 & "WHERE   fs_kd_reg = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    KdReg = oDR("fs_kd_reg")
                    TglUji = oDR("fd_tgl_uji")
                    JamUji = oDR("fs_jam_uji")
                    KdPetugas = oDR("fs_kd_petugas")
                    KdPetugasVoid = oDR("fs_kd_petugas_void")
                    NmPetugas = oDR("fs_nm_petugas")
                    NmPetugasVoid = oDR("fs_nm_petugas_void")
                    TglVoid = oDR("fd_tgl_void")
                    JamVoid = oDR("fs_jam_void")
                    Total = oDR("fn_total")
                    TglEstimasi = oDR("fd_tgl_estimasi")
                    Metode = oDR("fs_metode")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.close()
        End Set
    End Property

    ' Clean Un Used tarif
    'Public Sub CleanAfterInsert()
    '    sSql = "DELETE  TA_TRS_UJI4 " & vbCrLf _
    '         & "WHERE   fs_kd_reg = '" & KdReg & "' " & vbCrLf _
    '         & "        AND fs_kd_tarif = '" & KdTarif & "' "
    '    Try
    '        conn.open()
    '        oCmd = New OleDbCommand(sSql, conn.oConn)
    '        oCmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    '    conn.close()
    'End Sub
End Class
