Imports DevComponents.DotNetBar
Public Class frmMain
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub DotNetBarManager_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        mnuTrsRegistrasi.Click, _
        mnuTrsKasir.Click, _
        mnuTrsUji.Click, _
        mnuEntryHasil.Click, _
        mnuCetakHasil.Click, _
        mnuNamaTarif.Click, _
        mnuKompTarif.Click

        Select Case sender.Name
            ' FO
            Case "mnuTrsRegistrasi"
                frmTrsRegistrasi.MdiParent = Me
                frmTrsRegistrasi.Show()
            Case "mnuTrsUji"
                frmTrsUji.MdiParent = Me
                frmTrsUji.Show()
            Case "mnuTrsKasir"
                frmTrsKasir.MdiParent = Me
                frmTrsKasir.Show()

                ' BO
            Case "mnuEntryHasil"
                frmEntryHasil.MdiParent = Me
                frmEntryHasil.Show()
            Case "mnuCetakHasil"
                frmCetakHasil.MdiParent = Me
                frmCetakHasil.Show()

                ' Setup Master
            Case "mnuNamaTarif"
                frmSetupTarif.MdiParent = Me
                frmSetupTarif.Show()
            Case "mnuKompTarif"
                frmSetupKomponen.MdiParent = Me
                frmSetupKomponen.Show()
        End Select

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oConn As New clsConn
        Dim oFrmLogin As New frmLogin
        oFrmLogin.ShowDialog()
        xUser.Text = "Petugas : " & (My.Settings.KdPetugas).ToLower & "@" & (My.Computer.Name).ToLower
        xServer.Text = oConn.DB_NAME & "@" & oConn.DB_SERVER
        xVersion.Text = "Ver : " & My.Application.Info.Version.ToString
        My.Settings.NmKomputer = My.Computer.Name
        My.Settings.AppPath = Application.StartupPath
        'Me.BackgroundImage. = My.Settings.AppPath & "background.jpg"
    End Sub

    Private Sub xTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xTimer.Tick
        xTglJam.Text = Format(Today, "yyyy-MM-dd") & " " & TimeOfDay
    End Sub


    Private Sub mnuTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTarif.Click

    End Sub

End Class
