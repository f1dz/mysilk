Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace balailab
    Public Class clsJenisUji
        ' Methods
        Public Sub Insert()
            Me.sSql = String.Concat(New String() { "INSERT INTO TA_JENIS_UJI " & ChrW(13) & ChrW(10) & "            (fs_kd_jenis_uji " & ChrW(13) & ChrW(10) & "            ,fs_nm_jenis_uji " & ChrW(13) & ChrW(10) & "            ,fs_kd_grup_jenis_uji " & ChrW(13) & ChrW(10) & "            ,fs_kd_instalasi " & ChrW(13) & ChrW(10) & "            ,fb_kualitatif " & ChrW(13) & ChrW(10) & "            ,fs_satuan_umur " & ChrW(13) & ChrW(10) & "            ,fs_satuan " & ChrW(13) & ChrW(10) & "            ,fs_standar " & ChrW(13) & ChrW(10) & "            ,fs_Metode) " & ChrW(13) & ChrW(10) & "    VALUES " & ChrW(13) & ChrW(10) & "            ('", Me.Kode, "' " & ChrW(13) & ChrW(10) & "            ,'", Me.Nama, "' " & ChrW(13) & ChrW(10) & "            ,'", Me.KdGrupUji, "' " & ChrW(13) & ChrW(10) & "            ,'", Me.KdInstalasi, "' " & ChrW(13) & ChrW(10) & "            ,'", Conversions.ToString(Me.Kualitatif), "' " & ChrW(13) & ChrW(10) & "            ,'", Me.SatUmur, "' " & ChrW(13) & ChrW(10) & "            ,'", Me.Satuan, "' " & ChrW(13) & ChrW(10) & "            ,'", Me.Standar, "' " & ChrW(13) & ChrW(10) & "            ,'", Me.Metode, "') " })
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
            Me.sSql = ("SELECT *    FROM TA_JENIS_UJI " & ChrW(13) & ChrW(10) & "WHERE       fs_kd_jenis_uji = '" & Kode & "' ")
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

        Public Sub Update()
            Me.sSql = String.Concat(New String() { "UPDATE  TA_JENIS_UJI " & ChrW(13) & ChrW(10) & "   SET  fs_nm_jenis_uji = '", Me.Nama, "' " & ChrW(13) & ChrW(10) & "        ,fs_kd_grup_jenis_uji = '", Me.KdGrupUji, "' " & ChrW(13) & ChrW(10) & "        ,fs_kd_instalasi = '", Me.KdInstalasi, "' " & ChrW(13) & ChrW(10) & "        ,fb_kualitatif = '", Conversions.ToString(Me.Kualitatif), "' " & ChrW(13) & ChrW(10) & "        ,fs_satuan_umur = '", Me.SatUmur, "' " & ChrW(13) & ChrW(10) & "        ,fs_satuan = '", Me.Satuan, "' " & ChrW(13) & ChrW(10) & "        ,fs_standar = '", Me.Standar, "' " & ChrW(13) & ChrW(10) & "        ,fs_Metode = '", Me.Metode, "' " & ChrW(13) & ChrW(10) & "WHERE   fs_kd_jenis_uji = '", Me.Kode, "' " })
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
        Public Property KdGrupUji As String
            <DebuggerNonUserCode> _
            Get
                Return Me._KdGrupUji
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._KdGrupUji = AutoPropertyValue
            End Set
        End Property

        Public Property KdInstalasi As String
            <DebuggerNonUserCode> _
            Get
                Return Me._KdInstalasi
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._KdInstalasi = AutoPropertyValue
            End Set
        End Property

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

        Public Property Kualitatif As Boolean
            <DebuggerNonUserCode> _
            Get
                Return Me._Kualitatif
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As Boolean)
                Me._Kualitatif = AutoPropertyValue
            End Set
        End Property

        Public Property Metode As String
            <DebuggerNonUserCode> _
            Get
                Return Me._Metode
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._Metode = AutoPropertyValue
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

        Public Property NmGrupUji As String
            <DebuggerNonUserCode> _
            Get
                Return Me._NmGrupUji
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._NmGrupUji = AutoPropertyValue
            End Set
        End Property

        Public Property NmInstalasi As String
            <DebuggerNonUserCode> _
            Get
                Return Me._NmInstalasi
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._NmInstalasi = AutoPropertyValue
            End Set
        End Property

        Public Property Satuan As String
            <DebuggerNonUserCode> _
            Get
                Return Me._Satuan
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._Satuan = AutoPropertyValue
            End Set
        End Property

        Public Property SatUmur As String
            <DebuggerNonUserCode> _
            Get
                Return Me._SatUmur
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._SatUmur = AutoPropertyValue
            End Set
        End Property

        Public Property Standar As String
            <DebuggerNonUserCode> _
            Get
                Return Me._Standar
            End Get
            <DebuggerNonUserCode> _
            Set(ByVal AutoPropertyValue As String)
                Me._Standar = AutoPropertyValue
            End Set
        End Property

        Public WriteOnly Property vKode As String
            Set(ByVal value As String)
                Me.sSql = ("SELECT  aa.*, " & ChrW(13) & ChrW(10) & "        ISNULL(bb.fs_nm_grup_jenis_uji,'') AS fs_nm_grup_jenis_uji, " & ChrW(13) & ChrW(10) & "        ISNULL(cc.fs_nm_instalasi,'') AS fs_nm_instalasi " & ChrW(13) & ChrW(10) & "FROM    TA_JENIS_UJI aa " & ChrW(13) & ChrW(10) & "        LEFT JOIN TA_GRUP_JENIS_UJI bb ON aa.fs_kd_grup_jenis_uji = bb.fs_kd_grup_jenis_uji " & ChrW(13) & ChrW(10) & "        LEFT JOIN TA_INSTALASI cc ON aa.fs_kd_instalasi = cc.fs_kd_instalasi " & ChrW(13) & ChrW(10) & "WHERE   fs_kd_jenis_uji = '" & value & "' ")
                Try 
                    Me.conn.open
                    Me.oCmd = New OleDbCommand(Me.sSql, Me.conn.oConn)
                    Me.oDR = Me.oCmd.ExecuteReader
                    Me.oDR.Read
                    Me.Kode = Conversions.ToString(Me.oDR.Item("fs_kd_jenis_uji"))
                    Me.Nama = Conversions.ToString(Me.oDR.Item("fs_nm_jenis_uji"))
                    Me.KdGrupUji = Conversions.ToString(Me.oDR.Item("fs_kd_grup_jenis_uji"))
                    Me.NmGrupUji = Conversions.ToString(Me.oDR.Item("fs_nm_grup_jenis_uji"))
                    Me.KdInstalasi = Conversions.ToString(Me.oDR.Item("fs_kd_instalasi"))
                    Me.NmInstalasi = Conversions.ToString(Me.oDR.Item("fs_nm_instalasi"))
                    Me.Kualitatif = Conversions.ToBoolean(Me.oDR.Item("fb_kualitatif"))
                    Me.SatUmur = Conversions.ToString(Me.oDR.Item("fs_satuan_umur"))
                    Me.Satuan = Conversions.ToString(Me.oDR.Item("fs_satuan"))
                    Me.Standar = Conversions.ToString(Me.oDR.Item("fs_standar"))
                    Me.Metode = Conversions.ToString(Me.oDR.Item("fs_metode"))
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
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _KdGrupUji As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _KdInstalasi As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _Kode As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _Kualitatif As Boolean
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _Metode As String
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _Nama As String
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _NmGrupUji As String
        <CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)> _
        Private _NmInstalasi As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _Satuan As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _SatUmur As String
        <DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated> _
        Private _Standar As String
        Private conn As clsConn = New clsConn
        Private oCmd As OleDbCommand = New OleDbCommand
        Private oDA As OleDbDataAdapter = New OleDbDataAdapter
        Private oDR As OleDbDataReader
        Private oDS As DataSet = New DataSet
        Private sSql As String
    End Class
End Namespace

