Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Data.OleDb

Namespace balailab
    Public Class clsReport
        ' Methods
        Public Sub New()
            Me.rptKasirDS = Me.LapKasir
        End Sub

        Public Function LapKasir() As DataSet
            Me.sSQL = "SELECT aa.*,cc.fs_nm_rujukan FROM TA_TRS_KASIR aa " & ChrW(13) & ChrW(10) & "        INNER JOIN TA_TRS_REG bb ON aa.fs_kd_reg = bb.fs_kd_reg " & ChrW(13) & ChrW(10) & "        INNER JOIN TA_RUJUKAN cc ON bb.fs_kd_rujukan = cc.fs_kd_rujukan " & ChrW(13) & ChrW(10) & "        INNER JOIN TZ_USER dd ON aa.fs_kd_petugas = dd.fs_kd_user "
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSQL, Me.conn.oConn)
                Me.oDA.SelectCommand = Me.oCmd
                Me.oDA.Fill(Me.oDS)
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, Nothing)
                ProjectData.ClearProjectError
            End Try
            Return Nothing
        End Function


        ' Fields
        Private conn As clsConn = New clsConn
        Private oCmd As OleDbCommand = New OleDbCommand
        Private oDA As OleDbDataAdapter = New OleDbDataAdapter
        Private oDR As OleDbDataReader
        Private oDS As DataSet = New DataSet
        Public rptKasirDS As DataSet
        Private sSQL As String
    End Class
End Namespace

