Public Class frmSetupGrupJenisUji
    Dim oGrupUji As New clsSetupGrupUji
    Dim oHp As New clsHelper

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        If ((Strings.Trim(Me.txtKdGrupUji.Text) <> "") And (Strings.Trim(Me.txtNmGrupUji.Text) <> "")) Then
            Me.oGrupUji.Kode = Me.txtKdGrupUji.Text
            Me.oGrupUji.Nama = Me.txtNmGrupUji.Text
            If Me.oGrupUji.isExist(Strings.Trim(Me.txtKdGrupUji.Text)) Then
                Me.oGrupUji.UpdateGrupUji()
            Else
                Me.oGrupUji.InsertGrupUji()
            End If
            Interaction.MsgBox("Grup uji berhasil disimpan", MsgBoxStyle.Information, Nothing)
            Me.txtKdGrupUji.Clear()
            Me.txtNmGrupUji.Clear()
        Else
            Interaction.MsgBox("Data masih kosong" & ChrW(13) & ChrW(10) & "Proses simpan dibatalkan", MsgBoxStyle.Exclamation, Nothing)
        End If
    End Sub

    Private Sub Cari()
        Dim sSQL As String = "SELECT * FROM TA_GRUP_JENIS_UJI "
        Dim oFrmCari As New frmCari("Cari Grup Jenis Uji", sSQL, "fs_nm_grup_jenis_uji", "Grup Jenis Uji", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdGrupUji.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub txtKdGrupUji_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtKdGrupUji.ButtonCustomClick
        Me.Cari()
    End Sub

    Private Sub txtKdGrupUji_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKdGrupUji.KeyDown
        If (e.KeyCode = Keys.F12) Then
            Me.Cari()
        End If
    End Sub

    Private Sub txtKdGrupUji_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdGrupUji.Validating
        If ((Strings.Trim(Me.txtKdGrupUji.Text) <> "") And Me.oGrupUji.isExist(Me.txtKdGrupUji.Text)) Then
            Me.oGrupUji.vKode = Me.txtKdGrupUji.Text
            Me.txtNmGrupUji.Text = Me.oGrupUji.Nama
        End If
    End Sub
End Class