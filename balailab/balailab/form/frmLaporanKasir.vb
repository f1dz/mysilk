Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource
Public Class frmLaporanKasir
    Dim oUser As New clsUser
    Dim oParam As New clsParam
    'Private Function rptLapKasir1() As Object
    '    Throw New NotImplementedException
    'End Function

    Private Sub LoadReport()
        Dim xPetugas As String = ""
        Dim rpt As New rptLapKasir
        Dim con As New clsConn
        Dim com As New OleDbCommand
        Dim adapt As New OleDbDataAdapter
        Dim ds As New LapDataset
        Dim rptdocument As New ReportDocument
        'Dim tgl1 As String = Format(TxtTgl1.Value, "dd-MM-yyyy")
        'Dim tgl2 As String = Format(TxtTgl2.Value, "dd-MM-yyyy")
        If (Strings.Trim(Me.txtKdPetugas.Text) = "") Then
            xPetugas = " "
        Else
            xPetugas = ("AND aa.fs_kd_petugas = '" & Strings.Trim(Me.txtKdPetugas.Text) & "' ")
        End If
        con.open()
        com = New OleDbCommand("SELECT  aa.*,cc.fs_nm_rujukan FROM TA_TRS_KASIR aa " & ChrW(13) & ChrW(10) & "        INNER JOIN TA_TRS_REG bb ON aa.fs_kd_reg = bb.fs_kd_reg " & ChrW(13) & ChrW(10) & "        INNER JOIN TA_RUJUKAN cc ON bb.fs_kd_rujukan = cc.fs_kd_rujukan " & ChrW(13) & ChrW(10) & "        INNER JOIN TZ_USER dd ON aa.fs_kd_petugas = dd.fs_kd_user " & ChrW(13) & ChrW(10) & "WHERE   aa.fd_tgl_void = '3000-01-01' " & ChrW(13) & ChrW(10) & "        AND aa.fd_tgl_trs BETWEEN '" & "2011-01-01" & "' AND '" & "2011-12-30" & "'  " & xPetugas, con.oConn)
        adapt.SelectCommand = com
        adapt.Fill(ds, "LapKasir")
        rpt.SetDataSource(ds.Tables("LapKasir"))
        'rpt.SetDataSource(ds)
        Me.oUser.vKode = My.Settings.KdPetugas
        rpt.SetParameterValue("Tgl1", TxtTgl1.Text)
        rpt.SetParameterValue("Tgl2", TxtTgl2.Text)
        rpt.SetParameterValue("Petugas", oUser.NmUser)
        'rpt.PrintOptions.PrinterName 
        rpt.PrintToPrinter(1, False, 0, 0)
        'Me.crViewer.ReportSource = rpt
        'Me.crViewer.Refresh()
        'con.close()
        'Me.crViewer.ShowRefreshButton = False
    End Sub


    Private Sub crViewer_ReportRefresh(ByVal source As Object, ByVal e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles crViewer.ReportRefresh
        LoadReport()
    End Sub

    Private Sub frmLaporanKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadReport()
    End Sub

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        LoadReport()
    End Sub
End Class