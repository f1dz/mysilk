'Imports System.Data.OleDb

Public Class frmEntryHasil
    Dim oHasil As New clsEntryHasil
    Dim oHelper As New clsHelper
    Dim oReg As New clsTrsRegistrasi
    Dim oParam As New clsParam
    Dim oSample As New clsTrsSample
    Dim oMR As New clsMR
    Dim oInst As New clsInstalasi

    Private Sub frmEntryHasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' default
        txtKdInstalasi.Text = oParam.getDefault(My.Settings.NmKomputer, "def_instalasi")
        If Trim(txtKdInstalasi.Text) <> "" Then
            oInst.vKodeInst = txtKdInstalasi.Text
            txtNmInstalasi.Text = oInst.NamaInst
        End If
    End Sub

#Region "Cell Painting"
    'e.g. Vertically merge the same cells of the fourth column  
    Private Sub grid_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles grid.CellPainting

        If e.ColumnIndex = 0 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.grid.GridColor),
                backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell  
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)  
                    'If next row cell has different content, only draw bottom border line of current cell  
                    If e.RowIndex < grid.Rows.Count - 2 AndAlso grid.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell  
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells  
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso grid.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If
    End Sub
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtKdReg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        txtKdReg.KeyDown, _
        txtKdSample.KeyDown, _
        txtKdInstalasi.KeyDown, _
        txtTglHasil.KeyDown, _
        txtJamHasil.KeyDown, _
        txtKdHasil.KeyDown
        Select Case e.KeyCode
            ' Cariii
            Case Keys.F12
                Select Case sender.Name
                    Case "txtKdReg"
                        Dim oFrmCariReg As New frmCariRegister
                        oFrmCariReg.ShowDialog()
                        txtKdReg.Text = oFrmCariReg.KodeReg
                        oHelper.SendTab()
                    Case "txtKdSample"
                        If Trim(txtKdReg.Text) <> "" Then
                            Dim oFrmCariSample As New frmCariSample(txtKdReg.Text)
                            oFrmCariSample.ShowDialog()
                            If oFrmCariSample.KodeSample <> "" Then
                                txtKdSample.Text = oFrmCariSample.KodeSample
                                oHelper.SendTab()
                            End If
                        End If
                    Case "txtKdInstalasi"
                        Dim Title As String = "Instalasi"
                        Dim sSql As String
                        sSql = "SELECT  fs_kd_instalasi , " & vbCrLf _
                             & "        fs_nm_instalasi " & vbCrLf _
                             & "FROM    TA_INSTALASI  " & vbCrLf _
                             & "ORDER BY fs_nm_instalasi "
                        Dim oFrmCari As New frmCari(Title, sSql, "fs_nm_instalasi", "Nama Instalasi", "", "")
                        oFrmCari.ShowDialog()
                        If oFrmCari.Kode <> "" Then
                            txtKdInstalasi.Text = oFrmCari.Kode
                            oHelper.SendTab()
                        End If
                    Case "txtKdHasil"
                        Dim sSql As String
                        sSql = "SELECT  aa.fs_kd_trs , " & vbCrLf _
                             & "        aa.fs_kd_reg, " & vbCrLf _
                             & "        cc.fs_nm_pasien " & vbCrLf _
                             & "FROM    TA_TRS_HASIL aa " & vbCrLf _
                             & "INNER JOIN TA_TRS_REG2 bb ON aa.fs_kd_sample = bb.fs_kd_sample " & vbCrLf _
                             & "INNER JOIN TC_MR cc ON cc.fs_mr = bb.fs_mr " & vbCrLf _
                             & "WHERE   aa.fd_tgl_trs BETWEEN '" & Format(DateAdd(DateInterval.Day, -30, Today), "yyyy-MM-dd") & "' AND '" & Format(Today, "yyyy-MM-dd") & "' " & vbCrLf _
                             & "        AND fb_cetak = 0 "
                        Dim oFrmCari As New frmCari("Cari Hasil", sSql, "fs_nm_pasien", "Kode Reg.", "Pasien", "")
                        oFrmCari.ShowDialog()
                        txtKdHasil.Text = oFrmCari.Kode
                        oHelper.SendTab()
                End Select
            Case Keys.Enter
                Select Case sender.Name
                    Case "txtKdHasil"
                        oHelper.SendTab()
                        If Trim(txtKdHasil.Text) = "" Then
                            txtKdReg.ReadOnly = False
                            txtKdInstalasi.ReadOnly = False
                            txtKdSample.ReadOnly = False
                            ClrScr()
                        End If
                    Case "txtKdReg"
                        oHelper.SendTab()
                        If Trim(txtKdReg.Text) = "" Then
                            ClrScr()
                        End If
                    Case "txtKdSample"
                        oHelper.SendTab()
                    Case "txtKdInstalasi"
                        oHelper.SendTab()
                    Case "txtTglHasil"
                        oHelper.SendTab()
                    Case "txtJamHasil"
                        oHelper.SendTab()
                End Select
        End Select
    End Sub

    Private Sub FillGrid()
        oHasil.KodeReg = txtKdReg.Text
        oHasil.KodeSample = txtKdSample.Text
        oHasil.KodeInstalasi = txtKdInstalasi.Text
        With oHasil.UjiPerInstDS
            If .Tables(0).Rows.Count > 0 Then
                grid.DataSource = .Tables(0)


        With grid
            .Dock = DockStyle.Fill
            .RowHeadersWidth = 20
            .Columns(0).HeaderText = "Grup Uji"
            .Columns(0).ReadOnly = True
            .Columns(0).Name = "KodeGrupUji"
            .Columns(1).HeaderText = "Kode Uji"
            .Columns(1).ReadOnly = True
            .Columns(1).Name = "KodeUji"
                    .Columns(1).Width = 60
                    .Columns(1).Visible = False
            .Columns(2).HeaderText = "Pengujian"
            .Columns(2).ReadOnly = True
            .Columns(2).Name = "NamaUji"
            .Columns(2).MinimumWidth = 200
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).HeaderText = "Satuan"
            .Columns(3).ReadOnly = True
            .Columns(3).Name = "Satuan"
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(4).HeaderText = "Hasil"
            .Columns(4).Name = "Hasil"
            .Columns(4).MinimumWidth = 100
                    .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(5).HeaderText = "Standar"
            .Columns(5).ReadOnly = True
            .Columns(5).Name = "Standar"
            .Columns(5).Width = 140
            .Columns(5).ToolTipText = .Columns(5).Selected.ToString
            .Columns(6).HeaderText = "Metode"
            .Columns(6).ReadOnly = True
            .Columns(6).Name = "Metode"
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(7).Name = "KodeSample"
            .Columns(7).Visible = False
        End With
            End If
        End With
    End Sub

    Private Sub txt_Validating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txtKdReg.Validating, txtKdSample.Validating, txtKdInstalasi.Validating
        Select Case sender.Name
            Case "txtKdReg"
                If Trim(txtKdReg.Text) = "" Then
                    Exit Sub
                End If

                txtKdReg.Text = oParam.genKode("RG", txtKdReg.Text)
                ' Validasi Kode Reg
                If oReg.isExist(txtKdReg.Text) = False Then
                    MsgBox("Nomor Lab tidak ditemukan", MsgBoxStyle.Exclamation)
                    txtKdReg.Focus()
                End If

            Case "txtKdSample"
                If Trim(txtKdSample.Text) = "" Then
                    Exit Sub
                End If

                txtKdSample.Text = oParam.genKode("SM", txtKdSample.Text)

                If oSample.isSampleInReg(txtKdSample.Text, txtKdReg.Text) Then
                    oSample.vKode = txtKdSample.Text
                    oMR.vKode = oSample.xKdMR

                    txtJnsBahan.Text = oSample.xNmJenisSample
                    txtKemasan.Text = oSample.xNmWadah
                    txtMerk.Text = oSample.xMerk
                    txtPengambil.Text = oSample.xNmPengambil
                    txtJumlah.Text = oSample.xQty & " " & oSample.xSatQty

                    txtNama.Text = oMR.xNama
                    txtAlm1.Text = oMR.xAlm1
                    txtAlm2.Text = oMR.xAlm2
                    txtKota.Text = oMR.xKota
                    txtTelp.Text = oMR.xTelp

                    ' Fill Grid
                    FillGrid()

                Else
                    MsgBox("Sample " & txtKdSample.Text & " bukan milik Nomor Lab " & txtKdReg.Text & vbCrLf _
                           & "Atau Nomor Lab kosong, periksa kembali kelengkapan data", MsgBoxStyle.Information)
                    txtKdSample.Focus()
                End If
            Case "txtKdInstalasi"
                If oInst.isExist(txtKdInstalasi.Text) Then
                    oInst.vKodeInst = txtKdInstalasi.Text
                    txtNmInstalasi.Text = oInst.NamaInst
                    FillGrid()
                Else
                    MsgBox("Kode Instalasi tidak ditemukan", MsgBoxStyle.Exclamation)
                    txtKdInstalasi.Focus()
                    Exit Sub
                End If
        End Select

    End Sub

    Private Sub xTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xTimer.Tick
        If Trim(txtKdHasil.Text) = "" Then
            txtJamHasil.Text = Format(TimeOfDay, "HH:mm:ss")
            txtTglHasil.Text = Format(Today, "yyyy/MM/dd")
        End If

    End Sub

    Private Sub ClrScr()
        grid.DataSource = Nothing
        txtKdSample.Clear()
        txtJnsBahan.Clear()
        txtKemasan.Clear()
        txtMerk.Clear()
        txtJumlah.Clear()
        txtPengambil.Clear()
        txtNama.Clear()
        txtAlm1.Clear()
        txtAlm2.Clear()
        txtKota.Clear()
        txtTelp.Clear()
        txtKdReg.Clear()
        txtKdHasil.Clear()
        txtKesimpulan.Clear()
        txtPermenkes.Clear()
        txtISO.Clear()
        txtKet.Clear()
        txtNoInstalasi.Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Jika ada haisl yg belum terisi
        For i As Integer = 0 To grid.RowCount - 1
            If IsDBNull(grid.Item("Hasil", i).Value) Or Trim(grid.Item("Hasil", i).Value.ToString) = "" Then
                If MsgBox("Ada hasil yang belum terisi, lanjut simpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Exit For
                End If
            End If
        Next

        oHasil.KodeReg = txtKdReg.Text
        oHasil.KodeSample = txtKdSample.Text
        oHasil.TglHasil = oParam.tglYMD(txtTglHasil.Text)
        oHasil.JamHasil = txtJamHasil.Text
        oHasil.KodeInstalasi = txtKdInstalasi.Text
        oHasil.Merk = txtMerk.Text
        oHasil.Pengambil = txtPengambil.Text
        oHasil.Kesimpulan = txtKesimpulan.Text
        oHasil.KodePetugas = My.Settings.KdPetugas
        'oHasil.Permenkes = txtPermenkes.Text ' -> Dipindah ke cetak hasil
        'oHasil.ISO = txtISO.Text ' -> Dipindah ke cetak hasil
        oHasil.Ket = txtKet.Text
        oHasil.NoInstalasi = txtNoInstalasi.Text

        ' Jika Kode Hasil Kosong -> TRS Baru
        If Trim(txtKdHasil.Text) = "" Then
            If Trim(txtKdReg.Text) = "" Or Trim(txtKdSample.Text) = "" Then
                Exit Sub
            End If
            oHasil.KodeHasil = oParam.getKode("HS")
            oHasil.Save()

            ' Jika Kode Hasil Terisi -> Update TRS
        Else
            oHasil.KodeHasil = txtKdHasil.Text
            oHasil.Delete()
            oHasil.Save()
        End If

        ' Simpan Detil
        oHasil.DeleteDetil()
        For i As Integer = 0 To grid.RowCount - 1
            oHasil.NoUrut = i + 1
            oHasil.KdJnsUji = grid.Item("KodeUji", i).Value
            oHasil.Hasil = grid.Item("Hasil", i).Value.ToString
            oHasil.SaveDetil()
        Next
        MsgBox("Entry hasil berhasil disimpan", MsgBoxStyle.Information)
        txtKdHasilNew.Text = oHasil.KodeHasil
        ClrScr()
    End Sub

    Private Sub txt_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _
        txtKdSample.Validating, txtKdReg.Validating, txtKdInstalasi.Validating, txtKdHasil.Validating
        Select Case sender.Name
            Case "txtKdHasil"
                If Trim(txtKdHasil.Text) <> "" Then
                    txtKdHasil.Text = oParam.genKode("HS", txtKdHasil.Text)
                    If Not oHasil.isExist(txtKdHasil.Text) Then
                        MsgBox("Nomor Hasil Lab tidak ditemukan", MsgBoxStyle.Exclamation)
                        txtKdHasil.Focus()
                        Exit Sub
                    Else
                        oHasil.vKode = txtKdHasil.Text
                        If oHasil.Cetak Then
                            MsgBox("Hasil sudah pernah dicetak dengan Nomor Seri " & oHasil.NoSeri & vbCrLf & _
                                      "Proses edit hasil dibatalkan" & vbCrLf & _
                                      "Hubungi bagian Cetak Hasil", MsgBoxStyle.Exclamation)
                            txtKdHasil.Focus()
                            ClrScr()
                            Exit Sub
                        End If

                        txtKdReg.Text = oHasil.KodeReg
                        txtKdSample.Text = oHasil.KodeSample
                        txtTglHasil.Text = oParam.tglYMDdp(oHasil.TglHasil)
                        txtJamHasil.Text = oHasil.JamHasil
                        txtMerk.Text = oHasil.Merk
                        txtPengambil.Text = oHasil.Pengambil
                        txtKesimpulan.Text = oHasil.Kesimpulan
                        txtKdInstalasi.Text = oHasil.KodeInstalasi
                        txtPermenkes.Text = oHasil.Permenkes
                        txtISO.Text = oHasil.ISO
                        txtKet.Text = oHasil.Ket
                        txtNoInstalasi.Text = oHasil.NoInstalasi
                        FillGrid()
                        txtKdReg.ReadOnly = True
                        txtKdSample.ReadOnly = True
                        txtKdInstalasi.ReadOnly = True
                        oHelper.SendTab()
                        oHelper.SendTab()
                    End If
                End If
        End Select
    End Sub
End Class