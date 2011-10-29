﻿Public Class frmLogin
    Dim oHelper As New clsHelper
    Dim oUser As New clsUser
    Dim oFrmMain As New frmMain

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim User As String = Trim(txtUser.Text)
        Dim Pass As String = Trim(txtPassword.Text)
        oUser.User = User
        oUser.Password = Pass

        'For i As Integer = 1 To 3
        '    If oUser.isAktif Then
        '        My.Settings.KdPetugas = User
        '        Exit For
        '        Me.Close()
        '    Else
        '        MsgBox("Login gagal, periksa Username & Password", MsgBoxStyle.Information)
        '        If i = 3 Then
        '            MsgBox("Gagal login 3 kali, Application shutdown", MsgBoxStyle.Critical)
        '            Application.Exit()
        '        End If
        '    End If
        'Next

        If oUser.isAktif Then
            My.Settings.KdPetugas = User
            Me.Close()
        Else
            MsgBox("Login gagal, periksa Username & Password", MsgBoxStyle.Information)
            Application.Exit()
        End If


    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Focus()
        'txtUser.Text = "ADMIN"
        'txtPassword.Text = "1"
    End Sub

    Private Sub txtUser_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown, txtUser.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If sender.Name = "txtUser" Then
                    oHelper.SendTab()
                ElseIf sender.Name = "txtPassword" Then
                    btnLogin.PerformClick()
                End If
        End Select
    End Sub

    Private Sub txtUser_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.Validating
        If Trim(txtUser.Text) <> "" Then
            oUser.vKode = Trim(txtUser.Text)
            txtNmUser.Text = oUser.NmUser
        End If
    End Sub

End Class