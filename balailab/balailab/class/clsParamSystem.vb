Public Class clsParamSystem
    Dim proses As New clsConn2
    Dim Table As New DataTable
    Dim sSQL As String
    Public Property NmDirektur As String
    Public Property NipDirektur As String

    Public Sub New()
        NmDirektur = getNmDirektur()
        NipDirektur = getNipDirektur()
    End Sub

    Private Function getNmDirektur() As String
        Table = proses.ExecuteQuery("SELECT * FROM TZ_PARAMETER_SISTEM WHERE fs_kd_parameter = 'nm_direktur' ")
        If Table.Rows.Count > 0 Then
            Return Table.Rows(0).Item("fs_value")
        Else
            Return ""
        End If
    End Function

    Private Function getNipDirektur() As String
        Table = proses.ExecuteQuery("SELECT * FROM TZ_PARAMETER_SISTEM WHERE fs_kd_parameter = 'nip_direktur' ")
        If Table.Rows.Count > 0 Then
            Return Table.Rows(0).Item("fs_value")
        Else
            Return ""
        End If
    End Function

    Private Sub CleanParam()
        sSQL = "DELETE TZ_PARAMETER_SISTEM "
        proses.ExecuteNonQuery(sSQL)
    End Sub

    Public Sub insert()
        Call CleanParam()
        sSQL = "INSERT INTO TZ_PARAMETER_SISTEM (fs_kd_parameter,fs_value) " & vbCrLf _
             & "VALUES " & vbCrLf _
             & " ('nm_direktur','" & NmDirektur & "') " & vbCrLf _
             & ",('nip_direktur','" & NipDirektur & "') " & vbCrLf
        proses.ExecuteNonQuery(sSQL)
    End Sub

End Class
