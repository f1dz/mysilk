'Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmTrsKasir
    Dim oUser As New clsUser
    Dim oParam As New clsParam
    Dim oHelper As New clsHelper
    Dim oReg As New clsTrsRegistrasi
    Dim oUji As New clsTrsUji
    Dim oRjk As New clsPerujuk
    Dim oTrs As New clsTrsKasir

    Private Sub frmTrsKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKdBayar.TabStop = False
        txtKdReg.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub xTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xTimer.Tick
        If Trim(txtKdBayar.Text) = "" Then
            txtTglBayar.Text = Format(Today, "yyyy/MM/dd")
            txtJamBayar.Text = Format(TimeOfDay, "HH:mm:ss")
        End If
    End Sub

    Private Sub txtKdReg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKdReg.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Dim oFrmCariReg As New frmCariRegister
                oFrmCariReg.ShowDialog()
                txtKdReg.Text = oFrmCariReg.KodeReg
                If txtKdReg.Text <> "" Then
                    oHelper.SendTab()
                End If
            Case Keys.Enter
                oHelper.SendTab()
        End Select
    End Sub

    Private Sub txtKdReg_Validating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdReg.Validating
        If Trim(txtKdReg.Text) <> "" Then
            txtKdReg.Text = oParam.genKode("RG", txtKdReg.Text)

            ' Jika sudah ada pembayaran
            If oReg.isBayar(txtKdReg.Text) And txtKdBayar.Text = "" Then
                oTrs.vKodeReg = txtKdReg.Text
                If MsgBox("Sudah terjadi pembayaran atas Nomor Lab ini" & vbCrLf _
                          & "Dengan Nomor Transaksi Pembayaran " & oTrs.KdKasir, MsgBoxStyle.Exclamation) Then
                    txtKdReg.Clear()
                    txtKdReg.Focus()
                    Exit Sub
                End If
            Else
Lanjut:
                oUji.KdReg = txtKdReg.Text
                oReg.vKode = txtKdReg.Text
                oRjk.vKode = oReg.KdRujukan

                ' Fill Perujuk
                txtNmRujuk.Text = oRjk.NamaPerujuk
                txtAlmRujuk1.Text = oRjk.Alm1
                txtAlmRujuk2.Text = oRjk.Alm2
                txtKotaRujuk.Text = oRjk.Kota

                ' Fill Grid
                grid.Rows.Clear()
                txtTotal.Text = 0
                txtBayar.Text = 0
                txtKembali.Text = 0
                With oUji.TarifDS.Tables(0)
                    For i As Integer = 0 To .Rows.Count - 1
                        grid.Rows.Add(.Rows(i)("fs_kd_tarif"), _
                                      .Rows(i)("fs_nm_tarif"), _
                                      .Rows(i)("fn_qty"), _
                                      .Rows(i)("fn_sub_total"))
                        txtTotal.Text += .Rows(i)("fn_sub_total")
                    Next
                End With
            End If
        End If
    End Sub

    Private Sub txtBayar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.ValueChanged
        txtKembali.Text = Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text)
    End Sub

    Private Sub txtBayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBayar.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                txtBayar.Text = txtTotal.Text
        End Select
        If txtBayar.Value < txtTotal.Value Then
            txtBayar.BackgroundStyle.BackColor = Color.Red
        Else
            txtBayar.BackgroundStyle.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtBayar.Value < txtTotal.Value Then
            MsgBox("Nilai pembayaran yang dimasukkan kurang" _
                   & vbCrLf & "Cek kembali pembayaran", MsgBoxStyle.Exclamation)
            txtBayar.Focus()
            txtBayar.FocusHighlightColor = Color.Red
        Else
            oTrs.KdReg = txtKdReg.Text
            oTrs.TglTrs = oParam.tglYMD(txtTglBayar.Text)
            oTrs.JamTrs = txtJamBayar.Text
            oTrs.JmlBayar = txtTotal.Text
            oTrs.KdPetugasTrs = My.Settings.KdPetugas

            If Trim(txtKdBayar.Text) = "" Then
                oTrs.KdKasir = oParam.getKode("KS")
                oTrs.Save()
                oTrs.UpdateRegBayar()
                'clrScr()
                txtKdReg.Focus()
            Else
                oTrs.KdKasir = txtKdBayar.Text
                oTrs.Update()
                oTrs.UpdateRegBayar()
                'clrScr()
                txtKdReg.Focus()
                txtKdReg.ReadOnly = False
            End If
            txtKdBayarNew.Text = oTrs.KdKasir

            ' Cetak
            If MsgBox("Cetak Kwitansi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CetakKW_CR()
            End If
            clrScr()
        End If

    End Sub

    Private Sub clrScr()
        txtKdBayar.Clear()
        txtKdReg.Clear()
        txtNmRujuk.Clear()
        txtAlmRujuk1.Clear()
        txtAlmRujuk2.Clear()
        txtKotaRujuk.Clear()
        grid.Rows.Clear()
        txtTotal.Text = 0
        txtBayar.Text = 0
        txtKembali.Text = 0
        'txtKdBayar.Focus()
    End Sub

    Private Sub txtKdBayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKdBayar.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Dim oFrmCariTrs As New frmCariTrsKasir
                oFrmCariTrs.ShowDialog()
                txtKdBayar.Text = oFrmCariTrs.KodeTrs
                oHelper.SendTab()
            Case Keys.Enter
                oHelper.SendTab()
        End Select
    End Sub

    Private Sub txtKdBayar_Validating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdBayar.Validating
        ' Jika Tidak Kosong
        If Trim(txtKdBayar.Text) <> "" Then
            txtKdBayar.Text = oParam.genKode("KS", txtKdBayar.Text)

            ' Jika Kode Trs Valid dan exist
            If oTrs.isExist(txtKdBayar.Text) = False Then
                MsgBox("Nomor Transaksi Pembayaran tidak ditemukan" & vbCrLf & _
                       "Tekan tombol F12 untuk melakukan pencarian", MsgBoxStyle.Information)
                txtKdBayar.Focus()
                Exit Sub
            End If

            oTrs.vKodeBayar = txtKdBayar.Text

            ' Jika sudah Void
            If oTrs.isVoid(txtKdBayar.Text) Then
                MsgBox("Transaksi sudah di batalkan " & vbCrLf & _
                       "Oleh " & oTrs.NmPetugasVoid & vbCrLf & _
                       "Pada " & oTrs.TglVoid & " " & oTrs.JamVoid, MsgBoxStyle.Information)
                txtKdBayar.Focus()
                Exit Sub
            End If
            txtKdReg.Text = oTrs.KdReg
            txtKdReg.ReadOnly = True
            oHelper.SendTab()
        Else
            clrScr()
            txtKdReg.ReadOnly = False
        End If
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        If MsgBox("Batalkan Transaksi ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            oTrs.TglVoid = Format(Today, "yyyy-MM-dd")
            oTrs.JamVoid = TimeOfDay
            oTrs.KdPetugasVoid = My.Settings.KdPetugas
            oTrs.Void()
            oTrs.OpenReg()
            clrScr()
            txtKdReg.Focus()
        End If
    End Sub

    Private Sub CetakKW_CR()
        Dim TblKwitansi As New DataTable
        Dim oCetak As New clsCetak
        Dim rpt As New ctkKwitansi

        oUser.vKode = My.Settings.KdPetugas
        oCetak.KodeReg = txtKdReg.Text
        oReg.vKode = txtKdReg.Text

        TblKwitansi = oCetak.TblKwitansi
        rpt.SetDataSource(TblKwitansi)
        rpt.SetParameterValue("KdReg", txtKdReg.Text & "/" & txtKdBayar.Text)
        rpt.SetParameterValue("NmPetugas", oUser.NmUser)
        rpt.SetParameterValue("NmPelanggan", oReg.NmPelanggan)
        rpt.SetParameterValue("JmlBayar", txtBayar.Value)
        rpt.SetParameterValue("Terbilang", oHelper.AngkaToHuruf(txtBayar.Value))
        rpt.PrintToPrinter(1, True, 0, 0)
    End Sub

#Region "Cetak Lama"
    'Private Sub CetakKW()
    '    Dim oXcl As New Excel.Application
    '    Dim oBooks As Object = oXcl.Workbooks
    '    Dim xNama As String = ""
    '    Dim oMR As New clsMR
    '    Dim oReg As New clsTrsRegistrasi
    '    Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
    '    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    '    oXcl.Workbooks.Add(My.Settings.AppPath & "\templates\BBLK_KW-.xlt")

    '    oTrs.vKodeBayar = txtKdBayarNew.Text

    '    If oTrs.KdRujukan = "UMUM" Then
    '        oReg.Kode = oTrs.KdReg
    '        With oReg.SampleDS.Tables(0)
    '            For i As Integer = 0 To .Rows.Count - 1
    '                oMR.vKode = .Rows(i)("fs_mr")
    '                xNama = oMR.xNama
    '            Next
    '        End With
    '    Else
    '        xNama = oTrs.NmRujukan
    '    End If

    '    With oXcl.Cells
    '        .Replace("#NoLab#", oTrs.KdReg)
    '        .Replace("#NamaReg#", xNama)
    '        .Replace("#Huruf#", LTrim(oHelper.AngkaToHuruf(oTrs.JmlBayar)) & " Rupiah")
    '        .Replace("#Angka#", oTrs.JmlBayar)
    '        .Replace("#Waktu#", oParam.tglDMY(oTrs.TglTrs))
    '        .Replace("#Petugas#", oTrs.NmPetugas)
    '        oXcl.Cells(12, 7).value = oTrs.JmlBayar
    '    End With
    '    oXcl.ActiveWorkbook.PrintOutEx()
    '    oXcl.ActiveWorkbook.Close(False)
    '    oXcl.Workbooks.Close()
    '    oXcl = Nothing
    'End Sub
#End Region

    Private Sub txtKdBayar_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdBayar.Validating

    End Sub

End Class