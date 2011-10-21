Imports System.Data.OleDb

Public Class clsInstalasi
    Dim conn As New clsConn
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim oCmd As New OleDbCommand
    Dim sSql As String
    Public Property KodeInst As String
    Public Property NamaInst As String
    Public Property KodeKepInst As String
    Public Property NamaKepInst As String
    Public Property NipKepInst As String

    Public WriteOnly Property vKodeInst As String
        Set(ByVal value As String)
            sSql = "SELECT  aa.*, " & vbCrLf _
                 & "        bb.fs_nm_user AS fs_nm_kep_inst, " & vbCrLf _
                 & "        fs_nip " & vbCrLf _
                 & "FROM    TA_INSTALASI aa " & vbCrLf _
                 & "        LEFT JOIN TZ_USER bb ON aa.fs_kd_kep_inst = bb.fs_kd_user " & vbCrLf _
                 & "WHERE   aa.fs_kd_instalasi = '" & value & "' "
            Try
                conn.open()
                oCmd = New OleDbCommand(sSql, conn.oConn)
                oDR = oCmd.ExecuteReader
                oDR.Read()
                If oDR.HasRows Then
                    KodeInst = oDR("fs_kd_instalasi")
                    NamaInst = oDR("fs_nm_instalasi")
                    KodeKepInst = oDR("fs_kd_kep_inst")
                    NamaKepInst = oDR("fs_nm_kep_inst")
                    NipKepInst = oDR("fs_nip")
                End If
                conn.close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End Set
    End Property

    Public Function isExist(ByVal Kode As String) As Boolean
        Dim status As Boolean
        sSql = "SELECT *    FROM TA_INSTALASI " & vbCrLf _
             & "WHERE       fs_kd_instalasi = '" & Kode & "' "
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
