Public Class clsCetak
    Dim proses As New clsConn2
    Dim sSQL As String

    Function TblSample(ByVal Kdreg) As DataTable
        sSQL = "SELECT  aa.* , " & vbCrLf _
             & "        dd.fs_nm_pasien , " & vbCrLf _
             & "        CAST(fn_qty AS VARCHAR) + ' ' + fs_sat_qty AS fs_jumlah," & vbCrLf _
             & "        CASE bb.fs_kd_bentuk_sample " & vbCrLf _
             & "            WHEN '999' THEN bb.fs_bentuk_lainnya " & vbCrLf _
             & "            ELSE ISNULL(ee.fs_nm_bentuk_sample, '') " & vbCrLf _
             & "        END AS fs_nm_bentuk_sample , " & vbCrLf _
             & "        CASE bb.fs_kd_wadah_sample " & vbCrLf _
             & "            WHEN '999' THEN bb.fs_wadah_lainnya " & vbCrLf _
             & "            ELSE ISNULL(ff.fs_nm_wadah_sample, '') " & vbCrLf _
             & "        END AS fs_nm_wadah_sample , " & vbCrLf _
             & "        CASE bb.fs_kd_bahan_wadah " & vbCrLf _
             & "            WHEN '999' THEN bb.fs_bahan_wadah_lainnya " & vbCrLf _
             & "            ELSE ISNULL(gg.fs_nm_bahan_wadah, '') " & vbCrLf _
             & "        END AS fs_nm_bahan_wadah , " & vbCrLf _
             & "        CASE bb.fs_kd_tutup_sample " & vbCrLf _
             & "            WHEN '999' THEN bb.fs_tutup_sample_lainnya " & vbCrLf _
             & "            ELSE ISNULL(hh.fs_nm_tutup_sample, '') " & vbCrLf _
             & "        END AS fs_nm_tutup_sample , " & vbCrLf _
             & "        ISNULL(cc.fs_kd_jenis_sample, '') AS fs_kd_jenis_sample , " & vbCrLf _
             & "        ISNULL(cc.fs_nm_jenis_sample, '') AS fs_nm_jenis_sample, " & vbCrLf _
             & "        bb.fs_ket_wadah " & vbCrLf _
             & "FROM    TA_TRS_REG2 aa " & vbCrLf _
             & "        LEFT JOIN TA_TRS_SAMPLE bb ON aa.fs_kd_sample = bb.fs_kd_sample " & vbCrLf _
             & "        LEFT JOIN TA_JENIS_SAMPLE cc ON bb.fs_kd_jenis_sample = cc.fs_kd_jenis_sample " & vbCrLf _
             & "        LEFT JOIN TC_MR dd ON dd.fs_mr = aa.fs_mr " & vbCrLf _
             & "        LEFT JOIN TA_BENTUK_SAMPLE ee ON ee.fs_kd_bentuk_sample = bb.fs_kd_bentuk_sample " & vbCrLf _
             & "        LEFT JOIN TA_WADAH_SAMPLE ff ON ff.fs_kd_wadah_sample = bb.fs_kd_wadah_sample " & vbCrLf _
             & "        LEFT JOIN TA_BAHAN_WADAH gg ON gg.fs_kd_bahan_wadah = bb.fs_kd_bahan_wadah " & vbCrLf _
             & "        LEFT JOIN TA_TUTUP_SAMPLE hh ON hh.fs_kd_tutup_sample = bb.fs_kd_tutup_sample " & vbCrLf _
             & "WHERE   aa.fs_kd_reg = '" & Kdreg & "' " & vbCrLf _
             & "ORDER BY fn_urut "
        Return proses.ExecuteQuery(sSQL)
    End Function

    Function TblFPPSample(ByVal KdReg) As DataTable
        sSQL = "SELECT  aa.fs_kd_jenis_sample , " & vbCrLf _
             & "        bb.fs_nm_jenis_sample , " & vbCrLf _
             & "        COUNT(aa.fs_kd_jenis_sample) AS sub_total " & vbCrLf _
             & "FROM    TA_TRS_SAMPLE aa " & vbCrLf _
             & "INNER   JOIN TA_JENIS_SAMPLE bb ON aa.fs_kd_jenis_sample = bb.fs_kd_jenis_sample " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' " & vbCrLf _
             & "GROUP BY aa.fs_kd_jenis_sample,bb.fs_nm_jenis_sample " & vbCrLf _
             & "ORDER BY fs_nm_jenis_sample "
        Return proses.ExecuteQuery(sSQL)
    End Function

    Function TblFPPTarif(ByVal KdReg) As DataTable
        sSQL = "SELECT  aa.* , " & vbCrLf _
             & "        bb.fs_nm_tarif " & vbCrLf _
             & "FROM    TA_TRS_UJI2 aa " & vbCrLf _
             & "        LEFT JOIN TA_TARIF bb ON aa.fs_kd_tarif = bb.fs_kd_tarif " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & KdReg & "' "
        Return proses.ExecuteQuery(sSQL)
    End Function

    Function TblFPP(ByVal KdReg) As DataTable
        sSQL = "SELECT  ISNULL(dd.fs_nm_jenis_sample,'') AS fs_nm_jenis_sample , " & vbCrLf _
             & "        ISNULL(ee.fs_nm_tarif,'') AS fs_nm_tarif , " & vbCrLf _
             & "        COUNT(aa.fs_kd_sample) AS fn_qty, " & vbCrLf _
             & "        SUM(fn_nilai) AS fn_nilai " & vbCrLf _
             & "FROM    TA_TRS_UJI4 aa " & vbCrLf _
             & "        LEFT JOIN TA_TARIF2 bb ON aa.fs_kd_tarif = bb.fs_kd_tarif " & vbCrLf _
             & "        LEFT JOIN TA_TRS_SAMPLE cc ON aa.fs_kd_sample = cc.fs_kd_sample " & vbCrLf _
             & "        LEFT JOIN TA_JENIS_SAMPLE dd ON cc.fs_kd_jenis_sample = dd.fs_kd_jenis_sample " & vbCrLf _
             & "        LEFT JOIN TA_TARIF ee ON bb.fs_kd_tarif = ee.fs_kd_tarif " & vbCrLf _
             & "WHERE   aa.fs_kd_reg = '" & KdReg & "' " & vbCrLf _
             & "GROUP BY dd.fs_nm_jenis_sample , " & vbCrLf _
             & "        ee.fs_nm_tarif " & vbCrLf _
             & "ORDER BY dd.fs_nm_jenis_sample "
        Return proses.ExecuteQuery(sSQL)
    End Function
End Class
