﻿Imports DevComponents.DotNetBar
Public Class frmMain
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
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
        mnuLapKasir.Click, _
        mnuParamSystem.Click

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
                'frmLaporanKasir.MdiParent = Me
                frmLaporanKasir.ShowDialog()

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
            Case "mnuParamSystem"
                frmParamSystem.MdiParent = Me
                frmParamSystem.Show()

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
        My.Settings.CancelLogin = False
        Me.Hide()

        For i As Integer = 1 To 3

            If My.Settings.CancelLogin Then
                Application.Exit()
                Exit For
            End If

            If My.Settings.SuksesLogin = False Then
                oFrmLogin.ShowDialog()
                oFrmLogin.txtUser.Focus()
            End If

            If My.Settings.SuksesLogin = False And i = 3 Then
                MsgBox("3 kali gagal login, Aplikasi shutdown", MsgBoxStyle.Critical)
                Application.Exit()
            End If
        Next

        Me.Show()
        xUser.Text = "Petugas : " & (My.Settings.KdPetugas).ToLower & "@" & (My.Computer.Name).ToLower
        xServer.Text = oConn.DB_NAME & "@" & oConn.DB_SERVER
        xVersion.Text = "Ver : " & My.Application.Info.Version.ToString
        My.Settings.NmKomputer = My.Computer.Name
        My.Settings.AppPath = Application.StartupPath
        'Me.BackgroundImage. = My.Settings.AppPath & "background.jpg"
        UserAkses()

        ' Paint BG color
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Color.White

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

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

    ' Windows
    Private Sub AddButtonsToMyChildren()
        ' If there are child forms in the parent form, add Button controls to them.
        Dim x As Integer
        For x = 0 To (Me.MdiChildren.Length) - 1
            ' Create a temporary Button control to add to the child form.
            Dim tempButton As New Button()
            ' Set the location and text of the Button control.
            tempButton.Location = New Point(10, 10)
            tempButton.Text = "OK"
            ' Create a temporary instance of a child form (Form 2 in this case).
            Dim tempChild As Form = CType(Me.MdiChildren(x), Form)
            ' Add the Button control to the control collection of the form.
            tempChild.Controls.Add(tempButton)
        Next x
    End Sub 'AddButtonsToMyChildren


    Private Sub btnWindows_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox(Me.MdiChildren.Length)
        'MsgBox(Me.ActiveMdiChild.Name & " " & Me.MdiChildren(0).Text)
        If Me.MdiChildren.Length > 0 Then

            'For i As Integer = 0 To Me.MdiChildren.Length - 1
            '    Dim btn As New ButtonItem
            '    btn.Name = Me.MdiChildren(i).Name
            '    btn.Text = Me.MdiChildren(i).Text
            '    btnWindows.SubItems.Add(btn)
            'Next
            'Dim win As New MdiWindowListItem
            'MsgBox()
        End If
    End Sub

End Class
