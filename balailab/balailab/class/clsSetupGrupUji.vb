Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace balailab
    Public Class clsSetupGrupUji
        ' Methods
        Public Sub InsertGrupUji()
            Me.sSql = String.Concat(New String() { "INSERT INTO TA_GRUP_JENIS_UJI " & ChrW(13) & ChrW(10) & "        (fs_kd_grup_jenis_uji " & ChrW(13) & ChrW(10) & "        ,fs_nm_grup_jenis_uji) " & ChrW(13) & ChrW(10) & "VALUES " & ChrW(13) & ChrW(10) & "        ('", Me.Kode, "' " & ChrW(13) & ChrW(10) & "        ,'", Me.Nama, "') " })
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

        Public Function isExist(ByVal Kode As String) As Boolean
            Dim status As Boolean
            Me.sSql = ("SELECT *    FROM TA_GRUP_JENIS_UJI " & ChrW(13) & ChrW(10) & "WHERE       fs_kd_grup_jenis_uji = '" & Kode & "' ")
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

        Public Sub UpdateGrupUji()
            Me.sSql = String.Concat(New String() { "UPDATE  TA_GRUP_JENIS_UJI " & ChrW(13) & ChrW(10) & "SET     fs_nm_grup_jenis_uji = '", Me.Nama, "' " & ChrW(13) & ChrW(10) & "WHERE   fs_kd_grup_jenis_uji = '", Me.Kode, "' " })
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
        Public Property Kode As String
            <DebuggerNonUserCode> _
            Get
                Return Me._Kode
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._Kode = AutoPropertyValue
            End Set
        End Property

        Public Property Nama As String
            <DebuggerNonUserCode> _
            Get
                Return Me._Nama
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._Nama = AutoPropertyValue
            End Set
        End Property

        Public WriteOnly Property vKode As String
            Set(ByVal value As String)
                Me.sSql = ("SELECT * FROM TA_GRUP_JENIS_UJI " & ChrW(13) & ChrW(10) & "WHERE fs_kd_grup_jenis_uji = '" & value & "' ")
                Try 
                    Me.conn.open
                    Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                    Me.oDR = Me.oCmd.ExecuteReader
                    Me.oDR.Read
                    Me.Kode = Conversions.ToString(Me.oDR.Item("fs_kd_grup_jenis_uji"))
                    Me.Nama = Conversions.ToString(Me.oDR.Item("fs_nm_grup_jenis_uji"))
                    Me.conn.close
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim ex As Exception = exception1
                    Interaction.MsgBox(("Error : " & ex.Message), MsgBoxStyle.Exclamation, Nothing)
                    ProjectData.ClearProjectError
                End Try
            End Set
        End Property


        ' Fields
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _Kode As String
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _Nama As String
        Private conn As clsConn = New clsConn
        Private oCmd As OleDbCommand = New OleDbCommand
        Private oDA As OleDbDataAdapter = New OleDbDataAdapter
        Private oDR As OleDbDataReader
        Private oDS As DataSet = New DataSet
        Private sSql As String
    End Class
End Namespace

