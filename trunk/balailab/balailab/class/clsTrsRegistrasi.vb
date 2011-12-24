Imports System.Data.OleDb
Public Class clsTrsRegistrasi
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim oCmd As New OleDbCommand
    Dim sSql As String
    Public Property Kode As String
    Public Property KdRujukan As String
    Public Property Tgl As String
    Public Property Jam As String
    Public Property KdPetugas As String
    Public Property TglVoid As String
    Public Property JamVoid As String
    Public Property KdPetugasVoid As String
    Public Property NmPetugas As String
    Public Property NmPetugasVoid As String
    Public Property NmRujukan As String
    Public Property KdSample As String
    Public Property NoMR As String
    Public Property NoUrut As Integer
    Public Property NmPelanggan As String

    Public Sub Save()
        sSql = "INSERT  INTO TA_TRS_REG " & vbCrLf _
             & "        (fs_kd_reg " & vbCrLf _
             & "        ,fd_tgl_reg " & vbCrLf _
             & "        ,fs_jam_reg " & vbCrLf _
             & "        ,fs_kd_petugas " & vbCrLf _
             & "        ,fs_kd_rujukan " & vbCrLf _
             & "        ,fs_nm_pelanggan) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & "        ('" & Kode & "' " & vbCrLf _
             & "        ,'" & Tgl & "' " & vbCrLf _
             & "        ,'" & Jam & "' " & vbCrLf _
             & "        ,'" & KdPetugas & "' " & vbCrLf _
             & "        ,'" & KdRujukan & "'" & vbCrLf _
             & "        ,'" & NmPelanggan & "')"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub SaveSample()
        sSql = "INSERT  INTO TA_TRS_REG2 " & vbCrLf _
             & "        (fs_kd_reg " & vbCrLf _
             & "        ,fn_urut " & vbCrLf _
             & "        ,fs_kd_sample " & vbCrLf _
             & "        ,fs_mr) " & vbCrLf _
             & "VALUES  " & vbCrLf _
             & "        ('" & Kode & "' " & vbCrLf _
             & "        ,'" & NoUrut & "' " & vbCrLf _
             & "        ,'" & KdSample & "' " & vbCrLf _
             & "        ,'" & NoMR & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            If KdSample <> "" Then
                oCmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub UpdateRegTrsSample()
        sSql = "UPDATE TA_TRS_SAMPLE  " & vbCrLf _
             & "SET fs_kd_reg = '" & Kode & "' " & vbCrLf _
             & "WHERE fs_kd_sample = '" & KdSample & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            If KdSample <> "" Then
                oCmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Function isExist(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TRS_REG " & vbCrLf _
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
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return status
    End Function

    Public Function isVoid(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT      *    " & vbCrLf _
             & "FROM        TA_TRS_REG " & vbCrLf _
             & "WHERE       fs_kd_reg = '" & Kode & "' " & vbCrLf _
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

    Public Function isBayar(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TRS_REG " & vbCrLf _
             & "WHERE       fs_kd_reg = '" & Kode & "' " & vbCrLf _
             & "            AND fb_bayar = 1 "
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
            sSql = "SELECT  aa.* , " & vbCrLf _
                 & "        ISNULL(bb.fs_nm_user,'') AS fs_nm_petugas, " & vbCrLf _
                 & "        ISNULL(cc.fs_nm_rujukan,'') AS fs_nm_rujukan, " & vbCrLf _
                 & "        ISNULL(dd.fs_nm_user,'') AS fs_nm_petugas_void " & vbCrLf _
                 & "FROM    TA_TRS_REG aa " & vbCrLf _
                 & "        LEFT JOIN TZ_USER bb ON aa.fs_kd_petugas = bb.fs_kd_user " & vbCrLf _
                 & "        LEFT JOIN TA_RUJUKAN cc ON aa.fs_kd_rujukan = cc.fs_kd_rujukan " & vbCrLf _
                 & "        LEFT JOIN TZ_USER dd ON aa.fs_kd_petugas_void = dd.fs_kd_user " & vbCrLf _
                 & "WHERE   fs_kd_reg = '" & value & "' "

            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    Tgl = oDR("fd_tgl_reg")
                    Jam = oDR("fs_jam_reg")
                    KdPetugas = oDR("fs_kd_petugas")
                    NmPetugas = oDR("fs_nm_petugas")
                    TglVoid = oDR("fd_tgl_void")
                    JamVoid = oDR("fs_jam_void")
                    KdPetugasVoid = oDR("fs_kd_petugas_void")
                    NmPetugasVoid = oDR("fs_nm_petugas_void")
                    KdRujukan = oDR("fs_kd_rujukan")
                    NmRujukan = oDR("fs_nm_rujukan")
                    NmPelanggan = oDR("fs_nm_pelanggan")
                Else
                    '
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            conn.close()
        End Set
    End Property

    Public Function SampleDS() As DataSet
        sSql = "SELECT  aa.*,ISNULL(cc.fs_nm_jenis_sample,' ') AS fs_nm_jenis_sample FROM TA_TRS_REG2 aa " & vbCrLf _
             & "        LEFT JOIN TA_TRS_SAMPLE bb ON aa.fs_kd_sample = bb.fs_kd_sample " & vbCrLf _
             & "        LEFT JOIN TA_JENIS_SAMPLE cc ON bb.fs_kd_jenis_sample = cc.fs_kd_jenis_sample " & vbCrLf _
             & "WHERE   aa.fs_kd_reg = '" & Kode & "' " & vbCrLf _
             & "ORDER   BY fn_urut "
        Try
            oDS.Clear()
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

    Public Sub DeleteSample()
        sSql = "DELETE TA_TRS_REG2 " & vbCrLf _
             & "WHERE fs_kd_reg = '" & Kode & "'"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
    End Sub

    Public Sub DeleteReg()
        sSql = "DELETE TA_TRS_REG " & vbCrLf _
             & "WHERE fs_kd_reg = '" & Kode & "' "
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
        sSql = "UPDATE  TA_TRS_REG " & vbCrLf _
             & "SET     fd_tgl_void = '" & TglVoid & "', " & vbCrLf _
             & "        fs_jam_void = '" & JamVoid & "' " & vbCrLf _
             & "WHERE   fs_kd_reg = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'Public Function JumlahSample() As Integer
    '    sSql = "SELECT  COUNT(fs_kd_sample) AS Jumlah " & vbCrLf _
    '         & "FROM    TA_TRS_REG2 " & vbCrLf _
    '         & "WHERE   fs_kd_reg = '" & Kode & "' "
    '    Try
    '        conn.open()
    '        oCmd.ExecuteReader()
    '    Catch ex As Exception

    '    End Try
    'End Function

    Public Sub CleanSample()
        sSql = "UPDATE  TA_TRS_SAMPLE " & vbCrLf _
             & "SET     fs_kd_reg = '' " & vbCrLf _
             & "WHERE   fs_kd_sample NOT IN ( SELECT    fs_kd_sample " & vbCrLf _
             & "                              FROM      TA_TRS_REG2 " & vbCrLf _
             & "                              WHERE     fs_kd_reg = '" & Kode & "' ) " & vbCrLf _
             & "AND fs_kd_reg = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public WriteOnly Property vKodeRegGetKdSample As String
        Set(ByVal value As String)
            sSql = "SELECT * FROM TA_TRS_REG2 " & vbCrLf _
                 & "WHERE fs_kd_reg ='" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                KdSample = oDR("fs_kd_sample")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            conn.close()
        End Set
    End Property

    Public Function Cari() As DataTable
        Dim table As New DataTable
        sSql = "SELECT  fs_kd_reg , " & vbCrLf _
             & "        fd_tgl_reg , " & vbCrLf _
             & "        CASE aa.fs_kd_rujukan " & vbCrLf _
             & "          WHEN 'UMUM' THEN ( SELECT TOP 1 " & vbCrLf _
             & "                                    yy.fs_nm_pasien " & vbCrLf _
             & "                             FROM   TA_TRS_REG2 xx " & vbCrLf _
             & "                                    INNER JOIN TC_MR yy ON xx.fs_mr = yy.fs_mr " & vbCrLf _
             & "                             WHERE xx.fs_kd_reg = aa.fs_kd_reg " & vbCrLf _
             & "                           ) " & vbCrLf _
             & "          ELSE fs_nm_rujukan " & vbCrLf _
             & "        END AS fs_nm_rujukan , " & vbCrLf _
             & "        CASE aa.fs_kd_rujukan " & vbCrLf _
             & "          WHEN 'UMUM' THEN ( SELECT TOP 1 " & vbCrLf _
             & "                                    yy.fs_kota " & vbCrLf _
             & "                             FROM   TA_TRS_REG2 xx " & vbCrLf _
             & "                                    INNER JOIN TC_MR yy ON xx.fs_mr = yy.fs_mr " & vbCrLf _
             & "                             WHERE xx.fs_kd_reg = aa.fs_kd_reg " & vbCrLf _
             & "                           ) " & vbCrLf _
             & "          ELSE fs_nm_rujukan " & vbCrLf _
             & "        END AS fs_kota , " & vbCrLf _
             & "        fb_bayar " & vbCrLf _
             & "FROM    TA_TRS_REG aa " & vbCrLf _
             & "        INNER JOIN TA_RUJUKAN bb ON aa.fs_kd_rujukan = bb.fs_kd_rujukan " & vbCrLf _
             & "WHERE   fd_tgl_void = '3000-01-01' " & vbCrLf _
             & "ORDER BY fs_nm_rujukan "
        Try
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    Public WriteOnly Property vKodeRegGetMR As String
        Set(ByVal value As String)
            sSql = "SELECT TOP 1 fs_mr FROM TA_TRS_REG2 " & vbCrLf _
                 & "WHERE fs_kd_reg = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                NoMR = oDR("fs_mr")
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Set
    End Property

    Public Function JumlahSample() As Integer
        Return Me.SampleDS.Tables(0).Rows.Count
    End Function
End Class
