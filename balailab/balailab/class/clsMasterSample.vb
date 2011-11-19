Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace balailab
    Public Class clsMasterSample
        ' Methods
        Public Sub InsertGrupSample()
            Me.sSql = String.Concat(New String() { "INSERT INTO TA_GRUP_SAMPLE " & ChrW(13) & ChrW(10) & "VALUES ('", Me.KdGrupSample, "','", Me.NmGrupSample, "') " })
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                Me.oCmd.ExecuteNonQuery
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub InsertJenisSample()
            Me.sSql = String.Concat(New String() { "INSERT INTO TA_JENIS_SAMPLE " & ChrW(13) & ChrW(10) & "VALUES ('", Me.KdJnsSample, "','", Me.NmJnsSample, "','", Me.KdGrupSample, "') " })
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                Me.oCmd.ExecuteNonQuery
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Function isExistGrupSample(ByVal Kode As String) As Boolean
            Dim status As Boolean
            Me.sSql = ("SELECT *    FROM TA_GRUP_SAMPLE " & ChrW(13) & ChrW(10) & "WHERE       fs_kd_grup_sample = '" & Kode & "' ")
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                Me.oDR = Me.oCmd.ExecuteReader
                If Me.oDR.HasRows Then
                    status = True
                Else
                    status = False
                End If
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                ProjectData.ClearProjectError
            End Try
            Return status
        End Function

        Public Function isExistJnsSample(ByVal Kode As String) As Boolean
            Dim status As Boolean
            Me.sSql = ("SELECT *    FROM TA_JENIS_SAMPLE " & ChrW(13) & ChrW(10) & "WHERE       fs_kd_jenis_sample = '" & Kode & "' ")
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                Me.oDR = Me.oCmd.ExecuteReader
                If Me.oDR.HasRows Then
                    status = True
                Else
                    status = False
                End If
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                ProjectData.ClearProjectError
            End Try
            Return status
        End Function

        Public Sub UpdateGrupSample()
            Me.sSql = String.Concat(New String() { "UPDATE TA_GRUP_SAMPLE " & ChrW(13) & ChrW(10) & "SET fs_nm_grup_sample = '", Me.NmGrupSample, "' " & ChrW(13) & ChrW(10) & "WHERE fs_kd_grup_sample = '", Me.KdGrupSample, "' " })
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                Me.oCmd.ExecuteNonQuery
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub UpdateJenisSample()
            Me.sSql = String.Concat(New String() { "UPDATE  TA_JENIS_SAMPLE " & ChrW(13) & ChrW(10) & "SET     fs_nm_jenis_sample = '", Me.NmJnsSample, "' " & ChrW(13) & ChrW(10) & "        ,fs_kd_grup_sample = '", Me.KdGrupSample, "' " & ChrW(13) & ChrW(10) & "WHERE   fs_kd_jenis_sample = '", Me.KdJnsSample, "' " })
            Try 
                Me.conn.open
                Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                Me.oCmd.ExecuteNonQuery
                Me.conn.close
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub


        ' Properties
        Public Property KdGrupSample As String
            <DebuggerNonUserCode> _
            Get
                Return Me._KdGrupSample
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._KdGrupSample = AutoPropertyValue
            End Set
        End Property

        Public Property KdJnsSample As String
            <DebuggerNonUserCode> _
            Get
                Return Me._KdJnsSample
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._KdJnsSample = AutoPropertyValue
            End Set
        End Property

        Public Property NmGrupSample As String
            <DebuggerNonUserCode> _
            Get
                Return Me._NmGrupSample
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._NmGrupSample = AutoPropertyValue
            End Set
        End Property

        Public Property NmJnsSample As String
            <DebuggerNonUserCode> _
            Get
                Return Me._NmJnsSample
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._NmJnsSample = AutoPropertyValue
            End Set
        End Property

        Public WriteOnly Property vKdGrupSample As String
            Set(ByVal value As String)
                Me.sSql = ("SELECT * FROM TA_GRUP_SAMPLE " & ChrW(13) & ChrW(10) & "WHERE    fs_kd_grup_sample = '" & value & "' ")
                Try 
                    Me.conn.open
                    Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                    Me.oDR = Me.oCmd.ExecuteReader
                    If Me.oDR.HasRows Then
                        Me.oDR.Read
                        Me.KdGrupSample = Conversions.ToString(Me.oDR.Item("fs_kd_grup_sample"))
                        Me.NmGrupSample = Conversions.ToString(Me.oDR.Item("fs_nm_grup_sample"))
                    End If
                    Me.conn.close
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim ex As Exception = exception1
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                    ProjectData.ClearProjectError
                End Try
            End Set
        End Property

        Public WriteOnly Property vKdJnsSample As String
            Set(ByVal value As String)
                Me.sSql = ("SELECT  aa.* , " & ChrW(13) & ChrW(10) & "        bb.fs_nm_grup_sample " & ChrW(13) & ChrW(10) & "FROM    TA_JENIS_SAMPLE aa " & ChrW(13) & ChrW(10) & "        LEFT JOIN TA_GRUP_SAMPLE bb ON aa.fs_kd_grup_sample = bb.fs_kd_grup_sample " & ChrW(13) & ChrW(10) & "WHERE   fs_kd_jenis_sample = '" & value & "' ")
                Try 
                    Me.conn.open
                    Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                    Me.oDR = Me.oCmd.ExecuteReader
                    If Me.oDR.HasRows Then
                        Me.oDR.Read
                        Me.KdJnsSample = Conversions.ToString(Me.oDR.Item("fs_kd_jenis_sample"))
                        Me.NmJnsSample = Conversions.ToString(Me.oDR.Item("fs_nm_jenis_sample"))
                        Me.KdGrupSample = Conversions.ToString(Me.oDR.Item("fs_kd_grup_sample"))
                        Me.NmGrupSample = Conversions.ToString(Me.oDR.Item("fs_nm_grup_sample"))
                    End If
                    Me.conn.close
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim ex As Exception = exception1
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Nothing)
                    ProjectData.ClearProjectError
                End Try
            End Set
        End Property


        ' Fields
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _KdGrupSample As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _KdJnsSample As String
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _NmGrupSample As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _NmJnsSample As String
        Private conn As clsConn = New clsConn
        Private oCmd As OleDbCommand = New OleDbCommand
        Private oDA As OleDbDataAdapter = New OleDbDataAdapter
        Private oDR As OleDbDataReader
        Private oDS As DataSet = New DataSet
        Private sSql As String
    End Class
End Namespace

