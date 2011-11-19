Public Class frmSetupJenisSample
    Private oHP As New clsHelper
    Private oSample As New clsMasterSample

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        Me.oSample.KdJnsSample = Me.txtKdJnsSample.Text
        Me.oSample.NmJnsSample = Me.txtNmJnsSample.Text
        Me.oSample.KdGrupSample = Me.txtKdJnsSample.Text
        If (((Strings.Trim(Me.txtKdJnsSample.Text) <> "") And Me.oSample.isExistJnsSample(Strings.Trim(Me.txtKdJnsSample.Text))) And Me.oSample.isExistGrupSample(Me.txtKdGrupSample.Text)) Then
            Me.oSample.UpdateJenisSample()
        ElseIf (((Strings.Trim(Me.txtKdJnsSample.Text) <> "") And Not Me.oSample.isExistJnsSample(Strings.Trim(Me.txtKdJnsSample.Text))) And Me.oSample.isExistGrupSample(Me.txtKdGrupSample.Text)) Then
            Me.oSample.InsertJenisSample()
        Else
            Interaction.MsgBox("Data gagal disimpan, periksa kembali kelengkapan Data", MsgBoxStyle.Exclamation, Nothing)
            Return
        End If
        Interaction.MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, Nothing)
        Me.ClrScr()
        Me.txtKdJnsSample.Clear()
    End Sub

    Private Sub CariGrup()
        Dim sSql As String = "SELECT * FROM TA_GRUP_SAMPLE "
        Dim oFrmCari As New frmCari("Cari Grup Sample", sSql, "fs_nm_grup_sample", "Grup Sample", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdGrupSample.Text = oFrmCari.Kode
        Me.oHP.SendTab()
    End Sub

    Private Sub CariSample()
        Dim sSQL As String = "SELECT  aa.fs_kd_jenis_sample , " & ChrW(13) & ChrW(10) & "        aa.fs_nm_jenis_sample, " & ChrW(13) & ChrW(10) & "        bb.fs_nm_grup_sample " & ChrW(13) & ChrW(10) & "FROM    TA_JENIS_SAMPLE aa " & ChrW(13) & ChrW(10) & "        LEFT JOIN TA_GRUP_SAMPLE bb ON aa.fs_kd_grup_sample = bb.fs_kd_grup_sample "
        Dim oFrmCari As New frmCari("Cari Jenis Sample", sSQL, "fs_nm_jenis_sample", "Jenis Sample", "Grup Sample", "")
        oFrmCari.ShowDialog()
        Me.txtKdJnsSample.Text = oFrmCari.Kode
        Me.oHP.SendTab()
    End Sub

    Private Sub ClrScr()
        Me.txtNmJnsSample.Clear()
        Me.txtKdGrupSample.Clear()
        Me.txtNmGrupSample.Clear()
    End Sub

    Private Sub txtKdGrupSample_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdGrupSample.Validating
        If ((Me.txtKdGrupSample.Text <> "") And Me.oSample.isExistGrupSample(Me.txtKdGrupSample.Text)) Then
            Me.oSample.vKdGrupSample = Me.txtKdGrupSample.Text
            Me.txtNmGrupSample.Text = Me.oSample.NmGrupSample
        End If
    End Sub

    Private Sub txtKdJnsSample_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtKdGrupSample.ButtonCustomClick, txtKdJnsSample.ButtonCustomClick
        If sender.Name = "txtKdJnsSample" Then
            Me.CariSample()
        ElseIf sender.Name = "txtKdGrupSample" Then
            Me.CariGrup()
        End If
    End Sub

    Private Sub txtKdJnsSample_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKdGrupSample.KeyDown, txtKdJnsSample.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                If sender.Name = "txtKdJnsSample" Then
                    Me.CariSample()
                ElseIf sender.Name = "txtKdGrupSample" Then
                    Me.CariGrup()
                End If
                Exit Select
            Case Keys.Return
                Me.oHP.SendTab()
                Exit Select
        End Select
    End Sub

    Private Sub txtKdJnsSample_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdJnsSample.Validating
        If ((Strings.Trim(Me.txtKdJnsSample.Text) <> "") And Me.oSample.isExistJnsSample(Strings.Trim(Me.txtKdJnsSample.Text))) Then
            Me.oSample.vKdJnsSample = Me.txtKdJnsSample.Text
            Me.txtNmJnsSample.Text = Me.oSample.NmJnsSample
            Me.txtKdGrupSample.Text = Me.oSample.KdGrupSample
            Me.txtNmGrupSample.Text = Me.oSample.NmGrupSample
        ElseIf (Strings.Trim(Me.txtKdJnsSample.Text) = "") Then
            Me.ClrScr()
        End If
    End Sub
End Class