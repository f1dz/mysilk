Imports System.Data.OleDb

Public Class clsPerujuk
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oCmd As New OleDbCommand
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Public Property KodePerujuk As String
    Public Property NamaPerujuk As String
    Public Property Telpon As String
    Public Property Alm1 As String
    Public Property Alm2 As String
    Public Property Kota As String

    Public Sub Save()
        sSql = "INSERT INTO TA_RUJUKAN " & vbCrLf _
             & "    (fs_kd_rujukan " & vbCrLf _
             & "    ,fs_nm_rujukan " & vbCrLf _
             & "    ,fs_telpon " & vbCrLf _
             & "    ,fs_alm_rujukan " & vbCrLf _
             & "    ,fs_alm_rujukan2 " & vbCrLf _
             & "    ,fs_kota) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & "    ('" & KodePerujuk & "' " & vbCrLf _
             & "    ,'" & NamaPerujuk & "' " & vbCrLf _
             & "    ,'" & Telpon & "' " & vbCrLf _
             & "    ,'" & Alm1 & "' " & vbCrLf _
             & "    ,'" & Alm2 & "' " & vbCrLf _
             & "    ,'" & Kota & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub Update()
        sSql = "UPDATE  TA_RUJUKAN " & vbCrLf _
             & "SET     fs_nm_rujukan = '" & NamaPerujuk & "' ," & vbCrLf _
             & "        fs_telpon = '" & Telpon & "' , " & vbCrLf _
             & "        fs_alm_rujukan = '" & Alm1 & "' , " & vbCrLf _
             & "        fs_alm_rujukan2 = '" & Alm2 & "' , " & vbCrLf _
             & "        fs_kota = '" & Kota & "' " & vbCrLf _
             & "WHERE   fs_kd_rujukan = '" & KodePerujuk & "'"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public WriteOnly Property vKode As String
        Set(ByVal value As String)
            sSql = "SELECT * FROM TA_RUJUKAN " & vbCrLf _
                 & "WHERE fs_kd_rujukan = '" & value & "'"
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    NamaPerujuk = oDR("fs_nm_rujukan")
                    Telpon = oDR("fs_telpon")
                    Alm1 = oDR("fs_alm_rujukan")
                    Alm2 = oDR("fs_alm_rujukan2")
                    Kota = oDR("fs_kota")
                Else
                    MsgBox("Kode perujuk  " & value & " tidak ditemukan", MsgBoxStyle.Exclamation)
                End If
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Function isExist(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_RUJUKAN " & vbCrLf _
             & "WHERE       fs_kd_rujukan = '" & Kode & "' "
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

    Public Function DS() As DataSet
        sSql = "SELECT fs_kd_rujukan,fs_nm_rujukan FROM TA_RUJUKAN " & vbCrLf _
             & "ORDER BY 1 "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS, "TA_RUJUKAN")
            If oDS.Tables("TA_RUJUKAN").Rows.Count = 0 Then
                MsgBox("Data tidak ditemukan")
            Else
                Return oDS
            End If
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return oDS
    End Function

    Public Function CariData() As DataTable
        Dim table As New DataTable
        sSql = "SELECT fs_kd_rujukan, fs_nm_rujukan FROM TA_RUJUKAN "

        Try
            oDA = New OleDbDataAdapter(sSql, conn.oConn)
            oDA.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function
End Class
