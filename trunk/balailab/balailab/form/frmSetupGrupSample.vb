Public Class frmSetupGrupSample
    Dim oGrupSample As New clsMasterSample
    Dim oHp As New clsHelper

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        Me.oGrupSample.KdGrupSample = Me.txtKdGrupSample.Text
        Me.oGrupSample.NmGrupSample = Me.txtNmGrupSample.Text
        If ((Strings.Trim(Me.txtKdGrupSample.Text) <> "") And Me.oGrupSample.isExistGrupSample(Strings.Trim(Me.txtKdGrupSample.Text))) Then
            Me.oGrupSample.UpdateGrupSample()
        ElseIf (Strings.Trim(Me.txtKdGrupSample.Text) <> "") Then
            Me.oGrupSample.InsertGrupSample()
        End If
        Interaction.MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, Nothing)
        Me.ClrScr()
    End Sub

    Private Sub ClrScr()
        Me.txtKdGrupSample.Clear()
        Me.txtNmGrupSample.Clear()
    End Sub

    Private Sub Cari()
        Dim sSql As String = "SELECT * FROM TA_GRUP_SAMPLE "
        Dim oFrmCari As New frmCari("Cari Grup Sample", sSql, "fs_nm_grup_sample", "Grup Sample", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdGrupSample.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub txtKdGrupSample_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtKdGrupSample.ButtonCustomClick
        Me.Cari()
    End Sub

    Private Sub txtKdGrupSample_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKdGrupSample.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Me.Cari()
                Exit Select
            Case Keys.Return
                Me.oHp.SendTab()
                Exit Select
        End Select
    End Sub

    Private Sub txtKdGrupSample_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdGrupSample.Validating
        If ((Strings.Trim(Me.txtKdGrupSample.Text) <> "") And Me.oGrupSample.isExistGrupSample(Strings.Trim(Me.txtKdGrupSample.Text))) Then
            Me.oGrupSample.vKdGrupSample = Me.txtKdGrupSample.Text
            Me.txtNmGrupSample.Text = Me.oGrupSample.NmGrupSample
        End If
    End Sub
End Class