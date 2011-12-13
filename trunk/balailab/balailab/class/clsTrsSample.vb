Imports System.Data.OleDb
Public Class clsTrsSample
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oCmd As New OleDbCommand
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Public Property xKode As String
    Public Property xKdReg As String
    Public Property xKdMR As String
    Public Property xKdBentuk As String
    Public Property xBentukLain As String
    Public Property xQty As Double
    Public Property xSatQty As String
    Public Property xSuhu As Double
    Public Property xSatSuhu As String
    Public Property xKdWadah As String
    Public Property xWadahLain As String
    Public Property xKdBahanWadah As String
    Public Property xBahanWadahLain As String
    Public Property xKdTutup As String
    Public Property xTutupLain As String
    Public Property xKet As String
    Public Property xNmWadah As String
    Public Property xNmBahanWadah As String
    Public Property xNmTutup As String
    Public Property xNmBentuk As String
    Public Property xKetDetil As String
    Public Property xKdJenisSample As String
    Public Property xNmJenisSample As String
    Public Property xMerk As String
    Public Property xNmPengambil As String

    ' Combo dataset
    Public Function xSample(ByVal xTable As String) As DataSet
        sSql = "SELECT * FROM " & xTable
        Try
            oCmd.Connection = conn.oConn
            oCmd.CommandText = sSql
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return oDS
    End Function

    ' Masukkan data
    Public Sub Save()
        sSql = "INSERT  INTO TA_TRS_SAMPLE" _
             & "        (fs_kd_sample " _
             & "        ,fs_kd_reg " _
             & "        ,fs_kd_bentuk_sample " _
             & "        ,fs_bentuk_lainnya " _
             & "        ,fn_qty " _
             & "        ,fs_sat_qty " _
             & "        ,fn_suhu " _
             & "        ,fs_sat_suhu " _
             & "        ,fs_kd_wadah_sample " _
             & "        ,fs_wadah_lainnya " _
             & "        ,fs_kd_bahan_wadah " _
             & "        ,fs_bahan_wadah_lainnya " _
             & "        ,fs_kd_tutup_sample " _
             & "        ,fs_tutup_sample_lainnya" _
             & "        ,fs_ket_wadah " _
             & "        ,fs_kd_jenis_sample " _
             & "        ,fs_merk " _
             & "        ,fs_pengambil) " _
             & "    VALUES " _
             & "        ('" & xKode & "'" _
             & "        ,'" & xKdReg & "'" _
             & "        ,'" & xKdBentuk & "'" _
             & "        ,'" & xBentukLain & "'" _
             & "        ,'" & xQty & "'" _
             & "        ,'" & xSatQty & "'" _
             & "        ,'" & xSuhu & "'" _
             & "        ,'" & xSatSuhu & "'" _
             & "        ,'" & xKdWadah & "'" _
             & "        ,'" & xWadahLain & "'" _
             & "        ,'" & xKdBahanWadah & "'" _
             & "        ,'" & xBahanWadahLain & "'" _
             & "        ,'" & xKdTutup & "'" _
             & "        ,'" & xTutupLain & "'" _
             & "        ,'" & xKet & "'" _
             & "        ,'" & xKdJenisSample & "'" _
             & "        ,'" & xMerk & "'" _
             & "        ,'" & xNmPengambil & "')"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.close()
    End Sub

    Public WriteOnly Property vKode As String
        Set(ByVal value As String)
            sSql = "SELECT  aa.* , " & vbCrLf _
                 & "        isnull(gg.fs_mr,'') AS fs_mr, " & vbCrLf _
                 & "    CASE aa.fs_kd_bentuk_sample " & vbCrLf _
                 & "        WHEN '999' THEN aa.fs_bentuk_lainnya " & vbCrLf _
                 & "        ELSE ISNULL(bb.fs_nm_bentuk_sample, '') " & vbCrLf _
                 & "    END AS fs_nm_bentuk_sample , " & vbCrLf _
                 & "    CASE aa.fs_kd_wadah_sample " & vbCrLf _
                 & "        WHEN '999' THEN aa.fs_wadah_lainnya " & vbCrLf _
                 & "        ELSE ISNULL(cc.fs_nm_wadah_sample, '') " & vbCrLf _
                 & "    END AS fs_nm_wadah_sample , " & vbCrLf _
                 & "    CASE aa.fs_kd_bahan_wadah " & vbCrLf _
                 & "        WHEN '999' THEN aa.fs_bahan_wadah_lainnya " & vbCrLf _
                 & "        ELSE ISNULL(dd.fs_nm_bahan_wadah, '') " & vbCrLf _
                 & "    END AS fs_nm_bahan_wadah , " & vbCrLf _
                 & "    CASE aa.fs_kd_tutup_sample " & vbCrLf _
                 & "        WHEN '999' THEN aa.fs_tutup_sample_lainnya " & vbCrLf _
                 & "        ELSE ISNULL(ee.fs_nm_tutup_sample, '') " & vbCrLf _
                 & "    END AS fs_nm_tutup_sample, " & vbCrLf _
                 & "    ISNULL(ff.fs_kd_jenis_sample,'') AS fs_kd_jenis_sample, " & vbCrLf _
                 & "    ISNULL(ff.fs_nm_jenis_sample,'') AS fs_nm_jenis_sample " & vbCrLf _
                 & "FROM    TA_TRS_SAMPLE aa " & vbCrLf _
                 & "    LEFT JOIN TA_BENTUK_SAMPLE bb ON aa.fs_kd_bentuk_sample = bb.fs_kd_bentuk_sample " & vbCrLf _
                 & "    LEFT JOIN TA_WADAH_SAMPLE cc ON aa.fs_kd_wadah_sample = cc.fs_kd_wadah_sample " & vbCrLf _
                 & "    LEFT JOIN TA_BAHAN_WADAH dd ON aa.fs_kd_bahan_wadah = dd.fs_kd_bahan_wadah " & vbCrLf _
                 & "    LEFT JOIN TA_TUTUP_SAMPLE ee ON aa.fs_kd_tutup_sample = ee.fs_kd_tutup_sample " & vbCrLf _
                 & "    LEFT JOIN TA_JENIS_SAMPLE ff ON aa.fs_kd_jenis_sample = ff.fs_kd_jenis_sample " & vbCrLf _
                 & "    LEFT JOIN TA_TRS_REG2 gg ON aa.fs_kd_sample = gg.fs_kd_sample " & vbCrLf _
                 & "WHERE aa.fs_kd_sample = '" & value & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                xKode = oDR("fs_kd_sample")
                xKdReg = oDR("fs_kd_reg")
                xKdMR = oDR("fs_mr")
                xKdBentuk = oDR("fs_kd_bentuk_sample")
                xBentukLain = oDR("fs_bentuk_lainnya")
                xQty = oDR("fn_qty")
                xSatQty = oDR("fs_sat_qty")
                xSuhu = oDR("fn_suhu")
                xSatSuhu = oDR("fs_sat_suhu")
                xKdWadah = oDR("fs_kd_wadah_sample")
                xWadahLain = oDR("fs_wadah_lainnya")
                xKdBahanWadah = oDR("fs_kd_bahan_wadah")
                xBahanWadahLain = oDR("fs_bahan_wadah_lainnya")
                xKdTutup = oDR("fs_kd_tutup_sample")
                xTutupLain = oDR("fs_tutup_sample_lainnya")
                xKet = oDR("fs_ket_wadah")
                xNmBentuk = oDR("fs_nm_bentuk_sample")
                xNmWadah = oDR("fs_nm_wadah_sample")
                xNmBahanWadah = oDR("fs_nm_bahan_wadah")
                xNmTutup = oDR("fs_nm_tutup_sample")
                xKetDetil = xNmBentuk & ", " _
                            & xQty & " " & xSatQty & ", " _
                            & xSuhu & " " & xSatSuhu & ", " _
                            & xNmWadah & ", " _
                            & xNmBahanWadah & ", " _
                            & xNmTutup
                xKdJenisSample = oDR("fs_kd_jenis_sample")
                xNmJenisSample = oDR("fs_nm_jenis_sample")
                xMerk = oDR("fs_merk")
                xNmPengambil = oDR("fs_pengambil")
                oDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            conn.close()
        End Set
    End Property

    Public Sub Update()
        sSql = "UPDATE  TA_TRS_SAMPLE " & vbCrLf _
             & "SET     fs_kd_bentuk_sample = '" & xKdBentuk & "' " & vbCrLf _
             & "        ,fs_bentuk_lainnya = '" & xBentukLain & "' " & vbCrLf _
             & "        ,fn_qty = '" & xQty & "' " & vbCrLf _
             & "        ,fs_sat_qty = '" & xSatQty & "' " & vbCrLf _
             & "        ,fs_kd_wadah_sample = '" & xKdWadah & "' " & vbCrLf _
             & "        ,fs_wadah_lainnya = '" & xWadahLain & "' " & vbCrLf _
             & "        ,fs_kd_bahan_wadah = '" & xKdBahanWadah & "' " & vbCrLf _
             & "        ,fs_bahan_wadah_lainnya = '" & xBahanWadahLain & "' " & vbCrLf _
             & "        ,fs_kd_tutup_sample = '" & xKdTutup & "' " & vbCrLf _
             & "        ,fs_tutup_sample_lainnya = '" & xTutupLain & "' " & vbCrLf _
             & "        ,fn_suhu = '" & xSuhu & "' " & vbCrLf _
             & "        ,fs_sat_suhu = '" & xSatSuhu & "' " & vbCrLf _
             & "        ,fs_ket_wadah = '" & xKet & "' " & vbCrLf _
             & "        ,fs_kd_jenis_sample = '" & xKdJenisSample & "' " & vbCrLf _
             & "        ,fs_merk = '" & xMerk & "' " & vbCrLf _
             & "        ,fs_pengambil = '" & xNmPengambil & "' " & vbCrLf _
             & "WHERE   fs_kd_sample = '" & xKode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    'Public WriteOnly Property vKodeBentuk As String
    '    Set(ByVal value As String)
    '        sSql = "SELECT * FROM TA_BENTUK_SAMPLE " & vbCrLf _
    '             & "WHERE fs_kd_bentuk_sample = '" & value & "'"
    '        Try
    '            conn.open()
    '            oCmd = New OleDbCommand(sSql, conn.oConn)
    '            oDR = oCmd.ExecuteReader
    '            oDR.Read()
    '            Bentuk = oDR("fs_nm_bentuk_sample")
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '        End Try
    '    End Set
    'End Property

    Public Function CariData() As DataTable
        Dim table As New DataTable
        sSql = "SELECT fs_kd_jenis_sample, fs_nm_jenis_sample FROM TA_JENIS_SAMPLE "

        Try
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    Public WriteOnly Property vKodeJenis As String
        Set(ByVal value As String)
            sSql = "SELECT * FROM TA_JENIS_SAMPLE " & vbCrLf _
                 & "WHERE fs_kd_jenis_sample = '" & value & "'"
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                xNmJenisSample = oDR("fs_nm_jenis_sample")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Function JmlSampleDS() As DataSet
        sSql = "SELECT  aa.fs_kd_jenis_sample , " & vbCrLf _
             & "        bb.fs_nm_jenis_sample , " & vbCrLf _
             & "        COUNT(aa.fs_kd_jenis_sample) AS sub_total " & vbCrLf _
             & "FROM    TA_TRS_SAMPLE aa " & vbCrLf _
             & "INNER JOIN TA_JENIS_SAMPLE bb ON aa.fs_kd_jenis_sample = bb.fs_kd_jenis_sample " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & xKdReg & "' " & vbCrLf _
             & "GROUP BY aa.fs_kd_jenis_sample,bb.fs_nm_jenis_sample " & vbCrLf _
             & "ORDER BY fs_nm_jenis_sample "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS)
            If oDS.Tables(0).Rows.Count > 0 Then
                Return oDS
            Else
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
        Return Nothing
    End Function

    Public Function isSampleInReg(ByVal KodeSample As String, ByVal KodeReg As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT  * " & vbCrLf _
             & "FROM    TA_TRS_REG2 " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KodeReg & "' " & vbCrLf _
             & "        AND fs_kd_sample = '" & KodeSample & "' "
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

    Public Function CariByReg() As DataTable
        Dim table As New DataTable
        sSql = "SELECT  aa.fs_kd_sample,  " & vbCrLf _
             & "        ISNULL(dd.fs_nm_pasien,'') AS fs_nm_pasien, " & vbCrLf _
             & "        ISNULL(bb.fs_nm_jenis_sample,'') AS fs_nm_jenis_sample " & vbCrLf _
             & "FROM    TA_TRS_SAMPLE aa " & vbCrLf _
             & "        LEFT JOIN TA_JENIS_SAMPLE bb ON aa.fs_kd_jenis_sample = bb.fs_kd_jenis_sample " & vbCrLf _
             & "        LEFT JOIN TA_TRS_REG2 cc ON aa.fs_kd_sample = cc.fs_kd_sample " & vbCrLf _
             & "        LEFT JOIN TC_MR dd ON cc.fs_mr = dd.fs_mr " & vbCrLf _
             & "WHERE   aa.fs_kd_reg = '" & xKdReg & "' "
        Try
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function
End Class
