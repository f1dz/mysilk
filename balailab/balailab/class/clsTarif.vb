Imports System.Data.OleDb

Public Class clsTarif
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oCmd As New OleDbCommand
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Public Property Kode As String
    Public Property NmTarif As String
    Public Property NilaiTarif As Double
    Public Property KdKomponen As String
    Public Property NilaiKomponen As Double
    Public Property NmKomponen As String
    Public Property KdUji As String
    Public Property NmUji As String
    Public Property KdGrupUji As String
    Public Property NmGrupUji As String
    Public Property KdInstalasi As String
    Public Property NmInstalasi As String
    Public Property Kualitatif As Boolean
    Public Property Satuan As String
    Public Property Standar As String
    Public Property Urut As Integer

    Public WriteOnly Property vKode As String
        Set(ByVal value As String)
            sSql = "SELECT  aa.* , " & vbCrLf _
                 & "        ISNULL(SUM(bb.fn_nilai), 0) AS fn_nilai " & vbCrLf _
                 & "FROM    TA_TARIF aa " & vbCrLf _
                 & "        LEFT JOIN TA_TARIF3 bb ON aa.fs_kd_tarif = bb.fs_kd_tarif " & vbCrLf _
                 & "WHERE   aa.fs_kd_tarif = '" & value & "' " & vbCrLf _
                 & "GROUP BY aa.fs_kd_tarif , " & vbCrLf _
                 & "        aa.fs_nm_tarif "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    NmTarif = oDR("fs_nm_tarif")
                    NilaiTarif = oDR("fn_nilai")
                End If
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Function Cari() As DataTable
        Dim table As New DataTable
        sSql = "SELECT  aa.* , " & vbCrLf _
             & "        ISNULL(SUM(bb.fn_nilai), 0) AS fn_nilai " & vbCrLf _
             & "FROM    TA_TARIF aa " & vbCrLf _
             & "        LEFT JOIN TA_TARIF3 bb ON aa.fs_kd_tarif = bb.fs_kd_tarif " & vbCrLf _
             & "GROUP BY aa.fs_kd_tarif , " & vbCrLf _
             & "        aa.fs_nm_tarif " & vbCrLf _
             & "ORDER BY aa.fs_nm_tarif "
        Try
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    Public Function KompByTarifDS() As DataSet
        sSql = "SELECT  aa.* , " & vbCrLf _
             & "        bb.fs_nm_komponen " & vbCrLf _
             & "FROM    TA_TARIF3 aa " & vbCrLf _
             & "        INNER JOIN TA_KOMPONEN bb ON aa.fs_kd_komponen = bb.fs_kd_komponen " & vbCrLf _
             & "WHERE   fs_kd_tarif = '" & Kode & "' " & vbCrLf _
             & "ORDER BY fn_no_urut "

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

    Public Function KompDS() As DataSet
        sSql = "SELECT  * FROM TA_KOMPONEN " & vbCrLf _
             & "ORDER BY 1 "
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

    Public Function JenisUjiByTarifDS() As DataSet
        sSql = "SELECT  aa.* , " & vbCrLf _
             & "        bb.fs_kd_jenis_uji, " & vbCrLf _
             & "        fs_nm_jenis_uji " & vbCrLf _
             & "FROM    TA_TARIF4 aa " & vbCrLf _
             & "        INNER JOIN TA_JENIS_UJI bb ON aa.fs_kd_jenis_uji = bb.fs_kd_jenis_uji " & vbCrLf _
             & "WHERE   aa.fs_kd_tarif = '" & Kode & "' "

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

    Public Function isExist(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TARIF " & vbCrLf _
             & "WHERE       fs_kd_tarif = '" & Kode & "' "
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

    Public WriteOnly Property vKodeKomp As String
        Set(ByVal value As String)
            sSql = "SELECT * FROM TA_KOMPONEN " & vbCrLf _
                 & "WHERE fs_kd_komponen = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    KdKomponen = oDR("fs_kd_komponen")
                    NmKomponen = oDR("fs_nm_komponen")
                End If
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public WriteOnly Property vKodeUji As String
        Set(ByVal value As String)
            sSql = "SELECT  fs_kd_jenis_uji , " & vbCrLf _
                 & "        fs_nm_jenis_uji , " & vbCrLf _
                 & "        aa.fs_kd_grup_jenis_uji , " & vbCrLf _
                 & "        ISNULL(bb.fs_nm_grup_jenis_uji, '') AS fs_nm_grup_jenis_uji , " & vbCrLf _
                 & "        aa.fs_kd_instalasi , " & vbCrLf _
                 & "        ISNULL(cc.fs_nm_instalasi, '') AS fs_nm_instalasi , " & vbCrLf _
                 & "        fb_kualitatif, " & vbCrLf _
                 & "        fs_satuan, " & vbCrLf _
                 & "        fs_standar " & vbCrLf _
                 & "FROM    TA_JENIS_UJI aa " & vbCrLf _
                 & "        LEFT JOIN TA_GRUP_JENIS_UJI bb ON aa.fs_kd_grup_jenis_uji = bb.fs_kd_grup_jenis_uji " & vbCrLf _
                 & "        LEFT JOIN TA_INSTALASI cc ON aa.fs_kd_instalasi = cc.fs_kd_instalasi " & vbCrLf _
                 & "WHERE	fs_kd_jenis_uji = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    KdUji = oDR("fs_kd_jenis_uji")
                    NmUji = oDR("fs_nm_jenis_uji")
                    KdGrupUji = oDR("fs_kd_grup_jenis_uji")
                    NmGrupUji = oDR("fs_nm_grup_jenis_uji")
                    KdInstalasi = oDR("fs_kd_instalasi")
                    NmInstalasi = oDR("fs_nm_instalasi")
                    Kualitatif = oDR("fb_kualitatif")
                    Satuan = oDR("fs_satuan")
                    Standar = oDR("fs_standar")
                End If
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Sub DeleteUjiByTarif()
        sSql = "DELETE  TA_TARIF4 " & vbCrLf _
             & "WHERE   fs_kd_tarif = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub DeleteKompByTarif()
        sSql = "DELETE  TA_TARIF3 " & vbCrLf _
             & "WHERE   fs_kd_tarif = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub DeleteKomponen()
        sSql = "DELETE  TA_KOMPONEN " & vbCrLf _
             & "WHERE   fs_kd_komponen = '" & KdKomponen & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub UpdateTarif()
        sSql = "UPDATE  TA_TARIF " & vbCrLf _
             & "SET     fs_nm_tarif = '" & NmTarif & "' " & vbCrLf _
             & "WHERE   fs_kd_tarif = '" & Kode & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub InsertTarif()
        sSql = "INSERT INTO TA_TARIF " & vbCrLf _
             & "        (fs_kd_tarif " & vbCrLf _
             & "        ,fs_nm_tarif) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & "        ('" & Kode & "' " & vbCrLf _
             & "        ,'" & NmTarif & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub InsertTarifKomp()
        sSql = "INSERT INTO TA_TARIF3 " & vbCrLf _
             & "            (fs_kd_tarif " & vbCrLf _
             & "            ,fs_kd_tipe_tarif " & vbCrLf _
             & "            ,fs_kd_komponen " & vbCrLf _
             & "            ,fn_nilai " & vbCrLf _
             & "            ,fn_no_urut) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & "            ('" & Kode & "' " & vbCrLf _
             & "            ,'' " & vbCrLf _
             & "            ,'" & KdKomponen & "' " & vbCrLf _
             & "            ," & NilaiKomponen & " " & vbCrLf _
             & "            ," & Urut & " )"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub InsertTarifUji()
        sSql = "INSERT INTO TA_TARIF4 " & vbCrLf _
             & "        (fs_kd_tarif " & vbCrLf _
             & "        ,fs_kd_jenis_uji " & vbCrLf _
             & "        ,fn_no_urut) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & "        ('" & Kode & "' " & vbCrLf _
             & "        ,'" & KdUji & "' " & vbCrLf _
             & "        ," & Urut & ") "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub InsertKomponen()
        sSql = "INSERT INTO TA_KOMPONEN " & vbCrLf _
             & "VALUES  " & vbCrLf _
             & "    ('" & KdKomponen & "' " & vbCrLf _
             & "    ,'" & NmKomponen & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub UpdateKomponen()
        sSql = "UPDATE  TA_KOMPONEN " & vbCrLf _
             & "SET     fs_nm_komponen = '" & NmKomponen & "' " & vbCrLf _
             & "WHERE   fs_kd_komponen = '" & KdKomponen & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Function isExistKomponen(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_KOMPONEN " & vbCrLf _
             & "WHERE       fs_kd_komponen = '" & Kode & "' "
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

    Public Function isUsedKomponen(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_TARIF3 " & vbCrLf _
             & "WHERE       fs_kd_komponen = '" & Kode & "' "
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
