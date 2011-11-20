Imports Excel = Microsoft.Office.Interop.Excel
Imports DevComponents.DotNetBar

Public Class frmTrsRegistrasi
    Dim tmpDataSample As New DataSet
    'Dim tmpRetrive As My.Settings.myTmpSample
    Dim tmpSample As New DataTable
    Dim oHelper As New clsHelper
    Dim oUser As New clsUser

    Private Sub frmTrsRegistrasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTglReg.Value = Today.Date
        txtKdRujuk.Text = "UMUM"
        'txtJamReg.Text = Today.
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oReg As New clsTrsRegistrasi
        Dim oParam As New clsParam

        For i As Integer = 0 To dgvSample.RowCount - 1
            If dgvSample.Item(0, i).Value <> "" Or dgvSample.RowCount = 1 Then
                If dgvSample.Item(1, i).Value = "" Then
                    MsgBox("Data belum terisi dengan lengkap" & vbCrLf & "Cek Sample dan Nomor MR", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Next

        oReg.KdRujukan = Trim(txtKdRujuk.Text)
        oReg.Tgl = oParam.tglYMD(txtTglReg.Text)
        oReg.Jam = txtJamReg.Text
        oReg.KdPetugas = My.Settings.KdPetugas
        If Trim(txtKdReg.Text) = "" Then
            oReg.Kode = oParam.getKode("RG")
            oReg.Save()
        ElseIf oReg.isExist(txtKdReg.Text) Then
            oReg.Kode = txtKdReg.Text
            oReg.DeleteReg()
            oReg.Save()
        Else
            Me.Dispose()
        End If

        ' Update No Reg di TRS Sample
        oReg.DeleteSample() ' Delete sample lama
        For i As Integer = 0 To dgvSample.Rows.Count - 1
            With dgvSample
                oReg.KdSample = .Item(0, i).Value
                oReg.NoMR = .Item(1, i).Value
                oReg.NoUrut = i + 1
                oReg.SaveSample()
                oReg.UpdateRegTrsSample()
            End With
        Next
        oReg.CleanSample()
        txtKdRegNew.Text = oReg.Kode
        txtKdReg.Clear()
        If MsgBox("Cetak Penerimaan Sample ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            CetakSample()
        End If
        ClrScr()
        txtKdReg.Focus()
    End Sub

    'Data Grid Event
    Private Sub dgvSample_event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSample.KeyDown
        Dim i As Integer
        Dim col As Integer
        'Dim frmMR As frmMR
        col = dgvSample.CurrentCell.ColumnIndex
        i = dgvSample.CurrentCell.RowIndex
        Select Case e.KeyCode
            Case Keys.F12
                Select Case col
                    Case 0 ' Sample
                        Dim smKode As String
                        smKode = dgvSample.CurrentCell.Value
                        Dim oFrmTrsSample As New frmTrsSample(smKode)
                        oFrmTrsSample.ShowDialog()
                        If oFrmTrsSample.xKode <> "" And oFrmTrsSample.xKode <> smKode Then
                            dgvSample.Rows.Add(oFrmTrsSample.xKode, "", "")
                        End If
                    Case 1 ' MR
                        Dim sSQL As String
                        Dim oMR As New clsMR
                        Dim oSample As New clsTrsSample
                        sSQL = "SELECT fs_mr,fs_nm_pasien,fs_alm_pasien + ' ' + fs_alm_pasien2,fs_kota FROM TC_MR"
                        Dim oFrmCari As New frmCari("Cari MR", sSQL, "fs_nm_pasien", "Nama Pasien", "Alamat", "Kota")
                        oFrmCari.grid.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        oFrmCari.grid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                        oFrmCari.ShowDialog()
                        dgvSample.CurrentCell.Value = oFrmCari.Kode
                        oMR.vKode = oFrmCari.Kode
                        oSample.vKode = dgvSample.Item(0, dgvSample.CurrentRow.Index).Value
                        dgvSample.Item(2, dgvSample.CurrentRow.Index).Value = _
                            oMR.xNama & " | " & oSample.xKetDetil
                    Case 2
                        '
                End Select
            Case Keys.F11
                Select Case col
                    Case 1
                        Dim mrKode As String = ""
                        'mrKode = dgvSample.CurrentCell.Value
                        Dim oFrmMR As New frmMR(mrKode)
                        Dim oMR As New clsMR
                        Dim oSample As New clsTrsSample
                        oFrmMR.ShowDialog()
                        dgvSample.CurrentCell.Value = oFrmMR.xKode
                        oMR.vKode = oFrmMR.xKode
                        oSample.vKode = dgvSample.Item(0, dgvSample.CurrentRow.Index).Value
                        dgvSample.Item(2, dgvSample.CurrentRow.Index).Value = _
                            oMR.xNama & " | " & oSample.xKetDetil
                End Select
            Case Keys.F5
                With dgvSample
                    Dim oSample As New clsTrsSample
                    Dim oMR As New clsMR
                    .CurrentCell.Value = .Item(1, .CurrentRow.Index - 1).Value
                    oSample.vKode = .Item(0, .CurrentRow.Index).Value
                    oMR.vKode = .CurrentCell.Value
                    .Item(2, dgvSample.CurrentRow.Index).Value = _
                        oMR.xNama & " | " & oSample.xKetDetil
                End With
        End Select
    End Sub

    Private Sub txtKdRujuk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKdRujuk.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Dim frmCariPerujuk As New frmCariPerujuk
                frmCariPerujuk.ShowDialog()
                txtKdRujuk.Text = frmCariPerujuk.Kode
                oHelper.SendTab()
            Case Keys.F11
                Dim KodeRujuk As String
                KodeRujuk = txtKdRujuk.Text
                Dim oFrmSetupPerujuk As New frmSetupPerujuk(KodeRujuk)
                oFrmSetupPerujuk.ShowDialog()
                txtKdRujuk.Text = oFrmSetupPerujuk.Kode
                oHelper.SendTab()

                ' Jika return nya kosong
                If Trim(txtKdRujuk.Text) <> "" Then
                    Dim oRjk As New clsPerujuk
                    oRjk.vKode = Trim(txtKdRujuk.Text)
                    txtNmRujuk.Text = oRjk.NamaPerujuk
                    txtAlmRujuk1.Text = oRjk.Alm1
                    txtAlmRujuk2.Text = oRjk.Alm2
                    txtKotaRujuk.Text = oRjk.Kota
                End If
        End Select
    End Sub

    Private Sub txtKdRujuk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdRujuk.Validating
        Dim oRjk As New clsPerujuk
        oRjk.vKode = Trim(txtKdRujuk.Text)
        If oRjk.isExist(Trim(txtKdRujuk.Text)) <> True Then
            'MsgBox("Kode Perujuk tidak ditemukan", MsgBoxStyle.Exclamation)
            txtKdRujuk.Focus()
        Else
            txtNmRujuk.Text = oRjk.NamaPerujuk
            txtAlmRujuk1.Text = oRjk.Alm1
            txtAlmRujuk2.Text = oRjk.Alm2
            txtKotaRujuk.Text = oRjk.Kota
        End If
    End Sub

    Private Sub allObj_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        txtKdReg.KeyDown, _
        txtKdRujuk.KeyDown, _
        txtTglReg.KeyDown, _
        txtJamReg.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                oHelper.SendTab()
            Case Keys.F12
                If sender.name = "txtKdReg" Then
                    Dim oFrmCariReg As New frmCariRegister
                    oFrmCariReg.ShowDialog()
                    txtKdReg.Text = oFrmCariReg.KodeReg
                    If txtKdReg.Text <> "" Then
                        oHelper.SendTab()
                    End If
                End If
        End Select
    End Sub


    Private Sub txtKdReg_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdReg.Validating
        Dim oParam As New clsParam
        Dim oReg As New clsTrsRegistrasi
        Dim oSample As New clsTrsSample
        Dim oMR As New clsMR
        'MsgBox(oParam.genKode("RG", txtKdReg.Text))
        If Trim(txtKdReg.Text) <> "" Then
            txtKdReg.Text = oParam.genKode("RG", txtKdReg.Text)
            If oReg.isExist(txtKdReg.Text) = False Then
                MsgBox("Kode " & txtKdReg.Text & " salah atau tidak ditemukan", MsgBoxStyle.Exclamation)
                txtKdReg.Focus()
            ElseIf oReg.isVoid(txtKdReg.Text) Then
                oReg.vKode = txtKdReg.Text
                MsgBox(txtKdReg.Text & " sudah di void" & vbNewLine _
                       & "Oleh " & oReg.KdPetugasVoid & vbNewLine _
                       & "Pada " & oReg.TglVoid & " " & oReg.JamVoid, MsgBoxStyle.Exclamation)
                txtKdReg.Focus()
            ElseIf oReg.isExist(txtKdReg.Text) Then
                oReg.vKode = txtKdReg.Text
                txtKdRujuk.Text = oReg.KdRujukan
                txtTglReg.Text = oParam.tglYMDdp(oReg.Tgl)
                txtJamReg.Text = oReg.Jam
                oReg.Kode = txtKdReg.Text

                'Clear Grid sebelum diisi
                dgvSample.Rows.Clear()
                'If oReg.SampleDS.Tables(0).Columns.Count <> 0 Then
                With oReg.SampleDS.Tables(0)
                    For i As Integer = 0 To .Rows.Count - 1
                        oMR.vKode = .Rows(i)("fs_mr")
                        oSample.vKode = .Rows(i)("fs_kd_sample")
                        dgvSample.Rows.Add(.Rows(i)("fs_kd_sample"), _
                                           .Rows(i)("fs_mr"), _
                        oMR.xNama & " | " & oSample.xKetDetil)
                    Next
                End With
                'End If

            End If
        ElseIf Trim(txtKdReg.Text) = "" Then
            'Else
            txtKdRujuk.Text = "UMUM"
            txtTglReg.Text = oParam.CurDate
            txtJamReg.Text = oParam.CurTime
            dgvSample.Rows.Clear()
        End If
    End Sub

    'Public Sub clear()

    'End Sub

    Private Sub xTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xTimer.Tick
        If Trim(txtKdReg.Text) = "" Then
            txtTglReg.Text = Format(Today, "yyyy/MM/dd")
            txtJamReg.Text = Format(TimeOfDay, "HH:mm:ss")
        End If
    End Sub

#Region "Cetak Lama"

    'Private Sub CetakSample()
    '    Dim oXcl As New Excel.Application
    '    Dim oReg As New clsTrsRegistrasi
    '    Dim oSample As New clsTrsSample
    '    Dim oRjk As New clsPerujuk

    '    oReg.Kode = txtKdRegNew.Text
    '    oReg.vKode = oReg.Kode
    '    oUser.vKode = My.Settings.KdPetugas
    '    oRjk.vKode = oReg.KdRujukan
    '    oXcl.Visible = False
    '    With oReg.SampleDS.Tables(0)
    '        For i As Integer = 0 To .Rows.Count - 1
    '            oSample.vKode = .Rows(i)("fs_kd_sample")
    '            oXcl.Workbooks.Add("C:\BBLK\templates\BBLK_FPC-.xlt")
    '            With oXcl.Cells
    '                .Replace("#KodeSample#", oSample.xKode)
    '                .Replace("#Tanggal#", "'" & oReg.Tgl)
    '                .Replace("#Bentuk#", oSample.xNmBentuk)
    '                .Replace("#Qty#", oSample.xQty)
    '                .Replace("#SatQty#", oSample.xSatQty)
    '                .Replace("#Wadah#", oSample.xNmWadah)
    '                .Replace("#BahanWadah#", oSample.xNmBahanWadah)
    '                .Replace("#Tutup#", oSample.xNmTutup)
    '                .Replace("#Suhu#", oSample.xSuhu)
    '                .Replace("#SatSuhu#", oSample.xSatSuhu)
    '                .Replace("#Ket#", oSample.xKet)
    '                .Replace("#Petugas#", oUser.NmUser)
    '                .Replace("#Pelanggan#", oRjk.NamaPerujuk)
    '            End With
    '            oXcl.ActiveWorkbook.PrintOutEx()
    '            oXcl.ActiveWorkbook.Close(False)
    '        Next
    '    End With
    '    oXcl = Nothing
    'End Sub
#End Region

    Private Sub CetakSample()
        Dim oXcl As New Excel.Application
        Dim oReg As New clsTrsRegistrasi
        Dim oSample As New clsTrsSample
        Dim oRjk As New clsPerujuk
        Dim oMR As New clsMR
        Dim xPasien As String = ""
        'oXcl.Visible = True
        'oXcl.UserControl = True
        'Dim oBooks As Object = oXcl.Workbooks
        'Dim ci As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("en-US")
        'oBooks.GetType().InvokeMember("Add", Reflection.BindingFlags.InvokeMethod, Nothing, oBooks, Nothing, ci)

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        oReg.Kode = txtKdRegNew.Text
        oReg.vKode = oReg.Kode
        oUser.vKode = My.Settings.KdPetugas
        oRjk.vKode = oReg.KdRujukan
        oXcl.Visible = False
        With oReg.SampleDS.Tables(0)
            oXcl.Workbooks.Add(My.Settings.AppPath & "\templates\BBLK_FPC-.xlt")
            'System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

            oXcl.Cells.Replace("#KdReg#", oReg.Kode)
            If .Rows.Count > 1 Then
                oXcl.Cells.Replace("#KodeSample#", "'" & .Rows(0)("fs_kd_sample") & " - " & .Rows(.Rows.Count - 1)("fs_kd_sample"))
            Else
                oXcl.Cells.Replace("#KodeSample#", "'" & .Rows(0)("fs_kd_sample"))

            End If
            oXcl.Cells.Replace("#Tgl#", "'" & oReg.Tgl)
            For i As Integer = 0 To .Rows.Count - 1
                oSample.vKode = .Rows(i)("fs_kd_sample")
                With oXcl
                    .Cells(10 + i, 1).value = i + 1
                    .Cells(10 + i, 2).value = oSample.xKode
                    oMR.vKode = oSample.xKdMR
                    .Cells(10 + i, 3).value = oMR.xNama
                    .Cells(10 + i, 4).value = oSample.xNmBentuk
                    .Cells(10 + i, 5).value = oSample.xQty & " " & oSample.xSatQty
                    .Cells(10 + i, 6).value = oSample.xNmWadah
                    .Cells(10 + i, 7).value = oSample.xNmBahanWadah
                    .Cells(10 + i, 8).value = oSample.xNmTutup
                    '.Cells(10 + i, 9).value = oSample.xSuhu & " " & oSample.xSatSuhu
                    .Cells(10 + i, 9).value = oSample.xNmJenisSample
                    xPasien = oMR.xNama
                End With
            Next
        End With
        oXcl.Cells.Replace("#Petugas#", oUser.NmUser)

        'If oReg.KdRujukan = "UMUM" Then
        '    oXcl.Cells.Replace("#Pelanggan#", xPasien)
        'Else
        '    oXcl.Cells.Replace("#Pelanggan#", oRjk.NamaPerujuk)
        'End If

        If oRjk.Kolektif = 0 Then
            oXcl.Cells.Replace("#Pelanggan#", xPasien)
        Else
            oXcl.Cells.Replace("#Pelanggan#", oRjk.NamaPerujuk)
        End If

        oXcl.ActiveWorkbook.PrintOutEx()
        oXcl.ActiveWorkbook.Close(False)
        oXcl = Nothing
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Dim oReg As New clsTrsRegistrasi
        Dim oParam As New clsParam
        If MsgBox("Batalkan transaksi ?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
            oReg.Kode = txtKdReg.Text
            oReg.TglVoid = oParam.tglYMD(txtTglReg.Text)
            oReg.JamVoid = txtJamReg.Text
            oReg.Void()
            txtKdReg.Clear()
            dgvSample.Rows.Clear()
            txtTglReg.Text = Today
        End If
    End Sub

    Private Sub ClrScr()
        txtKdReg.Clear()
        txtKdRujuk.Clear()
        txtNmRujuk.Clear()
        txtAlmRujuk1.Clear()
        txtAlmRujuk2.Clear()
        txtKotaRujuk.Clear()
        dgvSample.Rows.Clear()
    End Sub

    Private Sub dgvSample_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSample.CellDoubleClick
        Dim i As Integer = dgvSample.CurrentRow.Index
        Dim col As Integer = dgvSample.CurrentCell.ColumnIndex

        'kodeSample = dgvSample.Item(0, i).Value
        'kodeMR = dgvSample.Item(1, i).Value

        If e.ColumnIndex = 0 Then
            Dim smKode As String
            smKode = dgvSample.CurrentCell.Value
            Dim oFrmTrsSample As New frmTrsSample(smKode)
            oFrmTrsSample.ShowDialog()
            If oFrmTrsSample.xKode <> "" And oFrmTrsSample.xKode <> smKode Then
                dgvSample.Rows.Add(oFrmTrsSample.xKode, "", "")
            End If

        ElseIf e.ColumnIndex = 1 Then
            Dim sSQL As String
            Dim oMR As New clsMR
            Dim oSample As New clsTrsSample
            sSQL = "SELECT fs_mr,fs_nm_pasien,fs_alm_pasien + ' ' + fs_alm_pasien2,fs_kota FROM TC_MR"
            Dim oFrmCari As New frmCari("Cari MR", sSQL, "fs_nm_pasien", "Nama Pasien", "Alamat", "Kota")
            oFrmCari.grid.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            oFrmCari.grid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            oFrmCari.ShowDialog()
            dgvSample.CurrentCell.Value = oFrmCari.Kode
            oMR.vKode = oFrmCari.Kode
            oSample.vKode = dgvSample.Item(0, dgvSample.CurrentRow.Index).Value
            dgvSample.Item(2, dgvSample.CurrentRow.Index).Value = _
                oMR.xNama & " | " & oSample.xKetDetil
        End If
    End Sub
End Class