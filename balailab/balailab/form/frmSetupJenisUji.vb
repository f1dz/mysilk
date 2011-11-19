Public Class frmSetupJenisUji
    Private oHp As New clsHelper
    Private oJenisUji As New clsJenisUji

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
        If (Strings.Trim(Me.txtKdJenisUji.Text) <> "") Then
            Me.oJenisUji.Kode = Me.txtKdJenisUji.Text
            Me.oJenisUji.Nama = Me.txtNmJenisUji.Text
            Me.oJenisUji.Kualitatif = Convert.ToBoolean(Me.txtKdMetode.Text)
            Me.oJenisUji.KdInstalasi = Me.txtKdInstalasi.Text
            Me.oJenisUji.KdGrupUji = Me.txtKdGrupUji.Text
            Me.oJenisUji.Satuan = Me.txtSatHasil.Text
            Me.oJenisUji.SatUmur = Me.txtSatUmur.Text
            Me.oJenisUji.Standar = Me.txtStandar.Text
            Me.oJenisUji.Metode = Me.txtMetode.Text
            If Me.oJenisUji.isExist(Me.txtKdJenisUji.Text) Then
                Me.oJenisUji.Update()
            Else
                Me.oJenisUji.Insert()
            End If
            Interaction.MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, Nothing)
            Me.ClrScr()
        End If
    End Sub

    Private Sub CariGrupUji()
        Dim sSQL As String = "SELECT * FROM TA_GRUP_JENIS_UJI "
        Dim oFrmCari As New frmCari("Cari Grup Jenis Uji", sSQL, "fs_nm_grup_jenis_uji", "Grup Jenis Uji", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdGrupUji.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub CariInstalasi()
        Dim sSQL As String = "SELECT fs_kd_instalasi,fs_nm_instalasi FROM TA_INSTALASI "
        Dim oFrmCari As New frmCari("Cari Instalasi", sSQL, "fs_nm_instalasi", "Instalasi", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdInstalasi.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub CariJenisUji()
        Dim sSQL As String = "SELECT fs_kd_jenis_uji,fs_nm_jenis_uji FROM TA_JENIS_UJI "
        Dim oFrmCari As New frmCari("Cari Jenis Uji", sSQL, "fs_nm_jenis_uji", "Jenis Uji", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdJenisUji.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub CariMetodeHasil()
        Dim sSQL As String = "SELECT '0' AS fs_kd_metode, 'Kuantitatif' AS fs_nm_metode " & vbCrLf & "UNION ALL " & vbCrLf & "SELECT '1' AS fs_kd_metode, 'Kualitatif' AS fs_nm_metode "
        Dim oFrmCari As New frmCari("Cari Metode Hasil", sSQL, "fs_nm_metode", "Metode Hasil", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdMetode.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub CariSatUmur()
        Dim sSQL As String = "SELECT 'Tahun' AS fs_kd_satuan, 'Tahun' AS fs_nm_satuan " & ChrW(13) & ChrW(10) & "UNION ALL " & ChrW(13) & ChrW(10) & "SELECT 'Bulan' AS fs_kd_satuan, 'Bulan' AS fs_nm_satuan "
        Dim oFrmCari As New frmCari("Cari Satuan Umur", sSQL, "fs_nm_satuan", "Satuan umur", "", "")
        oFrmCari.ShowDialog()
        Me.txtSatUmur.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Public Sub ClrScr()
        Me.txtKdJenisUji.Clear()
        Me.txtNmJenisUji.Clear()
        Me.txtKdInstalasi.Clear()
        Me.txtNmInstalasi.Clear()
        Me.txtKdGrupUji.Clear()
        Me.txtNmGrupUji.Clear()
        Me.txtKdMetode.Clear()
        Me.txtNmMetode.Clear()
        Me.txtSatHasil.Clear()
        Me.txtSatUmur.Clear()
        Me.txtStandar.Clear()
        Me.txtMetode.Clear()
    End Sub

    Private Sub Fill()
        Me.oJenisUji.vKode = Me.txtKdJenisUji.Text
        Me.txtNmJenisUji.Text = Me.oJenisUji.Nama
        Me.txtKdGrupUji.Text = Me.oJenisUji.KdGrupUji
        Me.txtNmGrupUji.Text = Me.oJenisUji.NmGrupUji
        Me.txtKdInstalasi.Text = Me.oJenisUji.KdInstalasi
        Me.txtNmInstalasi.Text = Me.oJenisUji.NmInstalasi
        If Not Me.oJenisUji.Kualitatif Then
            Me.txtKdMetode.Text = Convert.ToString(0)
            Me.txtNmMetode.Text = "Kuantitatif"
        ElseIf Me.oJenisUji.Kualitatif Then
            Me.txtKdMetode.Text = Convert.ToString(1)
            Me.txtNmMetode.Text = "Kualitatif"
        End If
        Me.txtSatHasil.Text = Me.oJenisUji.Satuan
        Me.txtSatUmur.Text = Me.oJenisUji.SatUmur
        Me.txtStandar.Text = Me.oJenisUji.Standar
        Me.txtMetode.Text = Me.oJenisUji.Metode
    End Sub

    Private Sub txt_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles _
        txtKdJenisUji.ButtonCustomClick, txtKdGrupUji.ButtonCustomClick, txtKdInstalasi.ButtonCustomClick, _
        txtKdMetode.ButtonCustomClick, txtSatUmur.ButtonCustomClick
        If sender.Name = "txtKdJenisUji" Then
            Me.CariJenisUji()
        ElseIf sender.Name = "txtKdGrupUji" Then
            Me.CariGrupUji()
        ElseIf sender.Name = "txtKdInstalasi" Then
            Me.CariInstalasi()
        ElseIf sender.Name = "txtKdMetode" Then
            Me.CariMetodeHasil()
        ElseIf sender.Name = "txtSatUmur" Then
            Me.CariSatUmur()
        End If
    End Sub

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _
        txtKdJenisUji.KeyDown, txtKdGrupUji.KeyDown, txtKdInstalasi.KeyDown, _
        txtKdMetode.KeyDown, txtSatUmur.KeyDown
        If (e.KeyCode = Keys.F12) Then
            If sender.Name = "txtKdJenisUji" Then
                Me.CariJenisUji()
            ElseIf sender.Name = "txtKdGrupUji" Then
                Me.CariGrupUji()
            ElseIf sender.Name = "txtKdInstalasi" Then
                Me.CariInstalasi()
            ElseIf sender.Name = "txtKdMetode" Then
                Me.CariMetodeHasil()
            ElseIf sender.Name = "txtSatUmur" Then
                Me.CariSatUmur()
            End If
        End If
    End Sub

    Private Sub txt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _
        txtKdJenisUji.Validating, txtKdGrupUji.Validating, txtKdInstalasi.Validating, _
        txtKdMetode.Validating, txtSatUmur.Validating
        If sender.Name = "txtKdJenisUji" Then
            If ((Strings.Trim(Me.txtKdJenisUji.Text) <> "") And Me.oJenisUji.isExist(Strings.Trim(Me.txtKdJenisUji.Text))) Then
                Me.Fill()
            End If
        ElseIf sender.Name = "txtKdGrupUji" Then
            Dim oGrupUji As New clsSetupGrupUji
            If ((Me.txtKdGrupUji.Text <> "") And oGrupUji.isExist(Me.txtKdGrupUji.Text)) Then
                oGrupUji.vKode = Me.txtKdGrupUji.Text
                Me.txtNmGrupUji.Text = oGrupUji.Nama
            End If
        ElseIf sender.Name = "txtKdInstalasi" Then
            Dim oInst As New clsInstalasi
            If ((Me.txtKdInstalasi.Text <> "") And oInst.isExist(Me.txtKdInstalasi.Text)) Then
                oInst.vKodeInst = Me.txtKdInstalasi.Text
                Me.txtNmInstalasi.Text = oInst.NamaInst
            End If
        ElseIf sender.Name = "txtKdMetode" Then
            If ((Me.txtKdMetode.Text <> "") And (Me.txtKdMetode.Text = "0")) Then
                Me.txtNmMetode.Text = "Kuantitatif"
            ElseIf (Me.txtKdMetode.Text = "1") Then
                Me.txtNmMetode.Text = "Kualitatif"
            End If
        End If
    End Sub
End Class