Public Class frmParamKomp
    Private oHp As New clsHelper
    Private oInst As New clsInstalasi
    Private oParam As New clsParam


    Private Sub frmParamKomp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtKdCurKomp.Text = My.Computer.Name
    End Sub

    Private Sub txtKdKomp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdKomp.Validating
        If (Me.txtKdKomp.Text <> "") Then
            Me.txtKdInstalasi.Text = Me.oParam.getDefault(Me.txtKdKomp.Text, "def_instalasi")
            If (Me.txtKdInstalasi.Text <> "") Then
                Me.oInst.vKodeInst = Me.txtKdInstalasi.Text
                Me.txtNmInstalasi.Text = Me.oInst.NamaInst
            End If
        End If
    End Sub

    Private Sub txtKdKomp_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _
        txtKdKomp.KeyDown, txtKdInstalasi.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                If sender.Name = "txtKdKomp" Then
                    Dim sSQL As String = "SELECT DISTINCT fs_kd_komp,fs_kd_komp FROM TZ_PARAMETER_KOMP"
                    Dim oFrmCari As New frmCari("Cari Komputer", sSQL, "fs_kd_komp", "Komputer", "", "")
                    oFrmCari.ShowDialog()
                    Me.txtKdKomp.Text = oFrmCari.Kode
                    Me.oHp.SendTab()
                ElseIf sender.Name = "txtKdInstalasi" Then
                    Dim sSql As String = "SELECT fs_kd_instalasi,fs_nm_instalasi FROM TA_INSTALASI "
                    Dim oFrmCari As New frmCari("Cari Instalasi", sSql, "fs_nm_instalasi", "Instalasi", "", "")
                    oFrmCari.ShowDialog()
                    Me.txtKdInstalasi.Text = oFrmCari.Kode
                    Me.oHp.SendTab()
                End If
                Exit Select
            Case Keys.F11
                If sender.Name = "txtKdKomp" Then
                    Me.txtKdKomp.Text = Me.txtKdCurKomp.Text
                    Me.oHp.SendTab()
                End If
                Exit Select
            Case Keys.Return
                Me.oHp.SendTab()
                Exit Select
        End Select
    End Sub

    Private Sub txtKdInstalasi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdInstalasi.Validating
        If txtKdInstalasi.Text <> "" Then
            Me.oInst.vKodeInst = txtKdInstalasi.Text
            Me.txtNmInstalasi.Text = Me.oInst.NamaInst
        End If
    End Sub

    Private Sub ClrScr()
        Me.txtKdKomp.Clear()
        Me.txtKdInstalasi.Clear()
        Me.txtNmInstalasi.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        If (Strings.Trim(Me.txtKdKomp.Text) <> "") Then
            Me.oParam.KdKomp = Me.txtKdKomp.Text
            Me.oParam.DelParamKomp()
            Me.oParam.KdParam = "def_instalasi"
            Me.oParam.ValueParam = Me.txtKdInstalasi.Text
            Me.oParam.InsertParam()
            Interaction.MsgBox("Parameter berhasil tersimpan", MsgBoxStyle.Information, Nothing)
            Me.ClrScr()
        Else
            Interaction.MsgBox("Kode Komputer kosong", MsgBoxStyle.Exclamation, Nothing)
        End If
    End Sub
End Class