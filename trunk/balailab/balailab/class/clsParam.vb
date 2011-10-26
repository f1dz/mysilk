Imports System.Data.OleDb
Public Class clsParam
    Dim conn As New clsConn
    Dim oCmd As New OleDbCommand
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim sSql As String
    Dim m_Kode As String
    Dim xKode As String
    Public Property KdKomp As String
    Public Property KdParam As String
    Public Property ValueParam As String

    Public Function getKode(ByVal xPref As String)
        sSql = "SELECT fs_value FROM TZ_PARAMETER " _
             & "WHERE FS_KD_PARAMETER ='" & xPref & "'"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDR = oCmd.ExecuteReader
            While oDR.Read
                m_Kode = oDR("fs_value")
            End While

            Dim x0 As New String("0", 8 - m_Kode.Length)
            For i As Integer = 1 To 8
                If m_Kode.Length = i Then
                    xKode = xPref & x0 & m_Kode
                End If
            Next

            sSql = "UPDATE TZ_PARAMETER SET fs_value='" & Convert.ToInt32(m_Kode) + 1 & "' " _
                 & "WHERE fs_kd_parameter = '" & xPref & "'"
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return xKode
    End Function

    Public Function genKode(ByVal xPrefix As String, ByVal xVal As String)
        'Dim m_Kode As String
        If IsNumeric(xVal) And xPrefix.Length = 2 Then
            Dim x0 As New String("0", 8 - xVal.Length)
            For i As Integer = 1 To 8
                If xVal.Length = i Then
                    xKode = xPrefix & x0 & xVal
                End If
            Next
        ElseIf xVal.Length = 10 Then
            xKode = xVal
        End If
        Return xKode
    End Function

    Public Function tglYMD(ByVal tgl As String)
        '01-01-3000 ke 3000-01-01 
        'tgl = tgl.Replace("/", "-")
        Return tgl.Substring(6, 4) & "-" & tgl.Substring(3, 2) & "-" & tgl.Substring(0, 2)
    End Function

    Public Function tglDMY(ByVal tgl As String)
        ' 3000-01-01 ke 01-01-3000
        Return tgl.Substring(8, 2) & "-" & tgl.Substring(5, 2) & "-" & tgl.Substring(0, 4)
    End Function

    Public Function tglDMYdp(ByVal tgl As String)
        ' 3000-01-01 ke 01-01-3000
        Return tgl.Substring(8, 2) & "/" & tgl.Substring(5, 2) & "/" & tgl.Substring(0, 4)
        'Return tgl.Replace("-", "/")
    End Function

    Public Function tglYMDdp(ByVal tgl As String)
        '01-01-3000 ke 3000-01-01 
        Return tgl.Replace("-", "/")
        'Return tgl.Substring(6, 4) & "/" & tgl.Substring(3, 2) & "/" & tgl.Substring(0, 2)
    End Function

    Public Function CurDateTime()
        sSql = "SELECT CURRENT_TIMESTAMP"
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS)
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return oDS.Tables(0).Rows(0)(0)
    End Function

    Public Function CurDate()
        Return Left(CurDateTime().ToString, 10)
    End Function

    Public Function CurTime()
        Return Right(CurDateTime().ToString, 8)
    End Function

    ' Combo dataset
    Public Function xCombo(ByVal xTable As String) As DataSet
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

    ' Get Def Kode Param
    Public Function getDefault(ByVal KodeKomp As String, ByVal KodeParam As String) As String
        Dim value As String
        sSql = "SELECT TOP 1 * FROM TZ_PARAMETER_KOMP " & vbCrLf _
             & "WHERE   fs_kd_komp = '" & KodeKomp & "' " & vbCrLf _
             & "        AND fs_kd_param = '" & KodeParam & "' "
        conn.open()
        oCmd = New OleDbCommand(sSql, conn.oConn)
        oDR = oCmd.ExecuteReader
        oDR.Read()
        If oDR.HasRows Then
            value = oDR("fs_value")
        Else
            value = ""
        End If
        conn.close()
        Return value
    End Function

    Public Sub DelParamKomp()
        sSql = "DELETE TZ_PARAMETER_KOMP " & vbCrLf _
             & "WHERE fs_kd_komp = '" & KdKomp & "' "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub InsertParam()
        sSql = "INSERT INTO TZ_PARAMETER_KOMP (fs_kd_komp,fs_kd_param,fs_value)" & vbCrLf _
             & "VALUES " & vbCrLf _
             & "        ('" & KdKomp & "' " & vbCrLf _
             & "        ,'" & KdParam & "' " & vbCrLf _
             & "        ,'" & ValueParam & "') "
        Try
            conn.open()
            oCmd = New OleDbCommand(sSql, conn.oConn)
            oCmd.ExecuteNonQuery()
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Function BitToBool(ByVal bit As Integer) As Boolean
        Dim state As Boolean

        If bit = 0 Then
            state = False
        Else
            bit = 1
        End If
        Return state
    End Function

    Public Function BoolToBit(ByVal bool As Boolean) As Integer
        Dim state As Integer

        If bool = True Then
            state = 1
        Else
            state = 0
        End If
        Return state
    End Function

End Class
