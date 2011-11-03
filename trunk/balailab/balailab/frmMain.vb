Imports DevComponents.DotNetBar
Public Class frmMain
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim oUser As New clsUser

    Private Sub DotNetBarManager_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        mnuTrsRegistrasi.Click, _
        mnuTrsKasir.Click, _
        mnuTrsUji.Click, _
        mnuEntryHasil.Click, _
        mnuCetakHasil.Click, _
        mnuNamaTarif.Click, _
        mnuKompTarif.Click, _
        mnuParamKomp.Click, _
        mnuGrupUji.Click, _
        mnuJenisUji.Click, _
        mnuSetupUser.Click, _
        mnuGrupSample.Click, _
        mnuJenisSample.Click, _
        mnuLapKasir.Click

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

                ' Laporan
            Case "mnuLapKasir"
                frmLaporanKasir.MdiParent = Me
                frmLaporanKasir.Show()

                ' Setup Master
            Case "mnuNamaTarif"
                frmSetupTarif.MdiParent = Me
                frmSetupTarif.Show()
            Case "mnuKompTarif"
                frmSetupKomponen.MdiParent = Me
                frmSetupKomponen.Show()
            Case "mnuGrupSample"
                frmSetupGrupSample.MdiParent = Me
                frmSetupGrupSample.Show()
            Case "mnuJenisSample"
                frmSetupJenisSample.MdiParent = Me
                frmSetupJenisSample.Show()

                ' Parameter
            Case "mnuParamKomp"
                frmParamKomp.MdiParent = Me
                frmParamKomp.Show()
            Case "mnuSetupUser"
                frmSetupUser.MdiParent = Me
                frmSetupUser.Show()

                ' Uji
            Case "mnuGrupUji"
                frmSetupGrupJenisUji.MdiParent = Me
                frmSetupGrupJenisUji.Show()
            Case "mnuJenisUji"
                frmSetupJenisUji.MdiParent = Me
                frmSetupJenisUji.Show()
        End Select

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oConn As New clsConn
        Dim oFrmLogin As New frmLogin
        My.Settings.SuksesLogin = False

        For i As Integer = 1 To 3
            If My.Settings.SuksesLogin = False Then
                oFrmLogin.ShowDialog()
                oFrmLogin.txtUser.Focus()
            End If

            If My.Settings.SuksesLogin = False And i = 3 Then
                MsgBox("3 kali gagal login, Aplikasi shutdown", MsgBoxStyle.Critical)
                Application.Exit()
            End If
        Next

        xUser.Text = "Petugas : " & (My.Settings.KdPetugas).ToLower & "@" & (My.Computer.Name).ToLower
        xServer.Text = oConn.DB_NAME & "@" & oConn.DB_SERVER
        xVersion.Text = "Ver : " & My.Application.Info.Version.ToString
        My.Settings.NmKomputer = My.Computer.Name
        My.Settings.AppPath = Application.StartupPath
        'Me.BackgroundImage. = My.Settings.AppPath & "background.jpg"
        UserAkses()
    End Sub

    Private Sub xTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xTimer.Tick
        xTglJam.Text = Format(Today, "yyyy-MM-dd") & " " & Format(TimeOfDay, "HH:mm:ss")
    End Sub

    Private Sub UserAkses()
        oUser.User = My.Settings.KdPetugas
        For Each ctrl As DevComponents.DotNetBar.ButtonItem In Me.RibbonBarFO.Items
            ctrl.Enabled = oUser.Akses(ctrl.Name)
        Next

        For Each ctrl As DevComponents.DotNetBar.ButtonItem In Me.RibbonBarBO.Items
            ctrl.Enabled = oUser.Akses(ctrl.Name)
        Next

        For Each ctrl As DevComponents.DotNetBar.ButtonItem In Me.RibbonBarLaporan.Items
            ctrl.Enabled = oUser.Akses(ctrl.Name)
        Next

        ' Master
        For Each ctrl As DevComponents.DotNetBar.ButtonItem In Me.RbnSetupMaster.Items
            ctrl.Enabled = oUser.Akses(ctrl.Name)
        Next

        ' Master
        For Each ctrl As DevComponents.DotNetBar.ButtonItem In Me.RbnControlPanel.Items
            ctrl.Enabled = oUser.Akses(ctrl.Name)
        Next
    End Sub

End Class
