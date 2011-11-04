Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmTrsUji
    Dim oParam As New clsParam
    Dim oRjk As New clsPerujuk
    Dim oReg As New clsTrsRegistrasi
    Dim oTarif As New clsTarif
    Dim oTrs As New clsTrsUji
    Dim oUser As New clsUser
    Dim oMR As New clsMR

    Private Sub frmTrsUji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTglEstimasi.Text = Format(Today, "yyyy/MM/dd")
    End Sub

    Private Sub xTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xTimer.Tick
        'If Trim(txtKdReg.Text) = "" Then
        txtJamUji.Text = Format(TimeOfDay, "HH:mm:ss")
        txtTglUji.Text = Format(Today, "yyyy/MM/dd")
        'End If
    End Sub

    Private Sub txtKdReg_Validating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdReg.Validating

        ' jika kode tdk kosong
        If Trim(txtKdReg.Text) <> "" Then
            txtKdReg.Text = oParam.genKode("RG", txtKdReg.Text)

            ' Jika Kode Tidak Valid
            If oReg.isExist(txtKdReg.Text) = False Then
                MsgBox("Kode " & txtKdReg.Text & " salah atau tidak ditemukan", MsgBoxStyle.Exclamation)
                txtKdReg.Focus()

                ' Jika Void
            ElseIf oReg.isVoid(txtKdReg.Text) Then
                oReg.vKode = txtKdReg.Text
                MsgBox(txtKdReg.Text & " sudah di void" & vbNewLine _
                       & "Oleh " & oReg.KdPetugasVoid & vbNewLine _
                       & "Pada " & oReg.TglVoid & " " & oReg.JamVoid, MsgBoxStyle.Exclamation)
                txtKdReg.Focus()

                ' Jika Exist dan Valid
            ElseIf oReg.isExist(txtKdReg.Text) Then
                My.Settings.tmpKdReg = txtKdReg.Text
                oReg.vKode = txtKdReg.Text
                oRjk.vKode = oReg.KdRujukan
                oTrs.KdReg = txtKdReg.Text

                If oReg.KdRujukan = "UMUM" Then
                    oReg.vKodeRegGetMR = txtKdReg.Text
                    oMR.vKode = oReg.NoMR
                    txtNmRujuk.Text = oMR.xNama
                    txtAlmRujuk1.Text = oMR.xAlm1
                    txtAlmRujuk2.Text = oMR.xAlm2
                    txtKotaRujuk.Text = oMR.xKota
                Else
                    txtNmRujuk.Text = oRjk.NamaPerujuk
                    txtAlmRujuk1.Text = oRjk.Alm1
                    txtAlmRujuk2.Text = oRjk.Alm2
                    txtKotaRujuk.Text = oRjk.Kota
                End If

                'txtTglEstimasi.MinDate = Format(Today, "yyyy/MM/dd")
                ' Isi Grid
                grid.Rows.Clear()
                With oTrs.TarifDS.Tables(0)
                    For i As Integer = 0 To .Rows.Count - 1
                        grid.Rows.Add(.Rows(i)("fs_kd_tarif"), _
                                      .Rows(i)("fs_nm_tarif"), _
                                      .Rows(i)("fn_qty"), _
                                      .Rows(i)("fn_sub_total"))
                    Next
                End With

            End If
        Else
            'MsgBox("Nomor Lab tidak boleh kosong", MsgBoxStyle.Exclamation)
            'txtKdReg.Focus()
            clrScr()
        End If
    End Sub

    Private Sub lstSample_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstSample.KeyDown
        'Dim oList As System.Windows.Forms.ListView.ListViewItemCollection
        Select Case e.KeyCode
            Case Keys.F12
                'lstSample.Items(0).Checked = True
                For i As Integer = 0 To lstSample.Items.Count - 1
                    If lstSample.Items(0).Checked Then
                        lstSample.Items(i).Checked = False
                    Else
                        lstSample.Items(i).Checked = True
                    End If
                Next
        End Select
    End Sub

    Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim col As Integer = grid.CurrentCell.ColumnIndex
        Dim r As Integer = grid.CurrentCell.RowIndex
        If col = 0 Then
            Dim oFrmCariTarif As New frmCariTarif
            oFrmCariTarif.ShowDialog()

            Dim KdTarif As String = My.Settings.tmpKdTarif
            oTarif.vKode = KdTarif

            grid.Rows.Add(KdTarif, oTarif.NmTarif, My.Settings.tmpQtySample, oTarif.NilaiTarif * My.Settings.tmpQtySample)
        End If
    End Sub

    Private Sub grid_Event(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Dim i As Integer
        Dim col As Integer

        col = grid.CurrentCell.ColumnIndex
        i = grid.CurrentCell.RowIndex
        ' Jika Kode Sample Kosong
        If oReg.isExist(txtKdReg.Text) Then
            Select Case e.KeyCode
                Case Keys.F12
                    Select Case col
                        Case 0 ' Kolom Kode Tarif
                            Dim oFrmCariTarif As New frmCariTarif
                            oFrmCariTarif.ShowDialog()

                            Dim KdTarif As String = My.Settings.tmpKdTarif
                            oTarif.vKode = KdTarif

                            grid.Rows.Add(KdTarif, oTarif.NmTarif, My.Settings.tmpQtySample, oTarif.NilaiTarif * My.Settings.tmpQtySample)
                    End Select
                Case Keys.Delete
                    grid.Rows.Remove(grid.CurrentRow)
            End Select
        Else
            MsgBox("Nomor Lab Kosong atau salah", MsgBoxStyle.Exclamation)
            txtKdReg.Focus()
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        oTrs.KdReg = txtKdReg.Text
        oTrs.TglVoid = Format(Today, "yyyy-MM-dd")
        oTrs.JamVoid = TimeOfDay
        oTrs.KdPetugasVoid = My.Settings.KdPetugas

        If oTrs.isAktif(txtKdReg.Text) Then
            oTrs.VoidUji()
        Else
            MsgBox("Void dibatalkan")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        oTrs.KdReg = txtKdReg.Text
        oTrs.JamUji = txtJamUji.Text
        oTrs.TglUji = oParam.tglYMD(txtTglUji.Text)
        oTrs.TglEstimasi = oParam.tglYMD(txtTglEstimasi.Text)
        oTrs.KdPetugas = My.Settings.KdPetugas

        ' Hitung Total
        Dim Total As Double
        For i As Integer = 0 To grid.RowCount - 1
            Total += grid.Rows(i).Cells(3).Value
        Next

        ' Insert Header ke TA_TRS_UJI
        oTrs.Total = Total
        oTrs.DeleteUji()
        oTrs.InsertUji()
        oTrs.DeleteUji2()
        oTrs.DeleteUji3()

        ' Insert Tarif Ke TA_TRS_UJI2 & TA_TRS_UJI3
        For i As Integer = 0 To grid.RowCount - 1
            If grid.Item(0, i).Value <> "" Then
                oTarif.vKode = grid.Item(0, i).Value
                oTrs.KdTarif = grid.Item(0, i).Value
                oTrs.Qty = grid.Item(2, i).Value
                oTrs.NilaiTarif = oTarif.NilaiTarif
                oTrs.SubTotal = grid.Item(3, i).Value

                ' Lakukan Insert
                oTrs.InsertUji2()
                oTrs.InsertUji3()
            End If
        Next
        oTrs.CleanTrs()
        If MsgBox("Cetak Formulir Permohonan Pengujian ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CetakFPP()
        End If
        clrScr()
    End Sub

    Private Sub grid_Validate(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles grid.RowStateChanged
        ' Hitung Total
        Dim Total As Double
        For i As Integer = 0 To grid.RowCount - 1
            Total += grid.Rows(i).Cells(3).Value
        Next
        txtTotal.Text = Total
    End Sub

    Private Sub CetakFPP()
        Dim oXcl As New Excel.Application
        Dim oSample As New clsTrsSample
        Dim xRow As Integer
        Dim oReg As New clsTrsRegistrasi
        Dim xPasien As String = ""
        Dim oBooks As Object = oXcl.Workbooks
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        oUser.vKode = My.Settings.KdPetugas
        oReg.vKode = txtKdReg.Text
        oRjk.vKode = oReg.KdRujukan
        oTrs.KdReg = txtKdReg.Text
        oSample.xKdReg = txtKdReg.Text

        Dim oMR As New clsMR
        oReg.Kode = txtKdReg.Text
        With oReg.SampleDS.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                oMR.vKode = .Rows(i)("fs_mr")
                xPasien = oMR.xNama
            Next
        End With

        oXcl.Workbooks.Add(My.Settings.AppPath & "\templates\BBLK_FPP-.xlt")
        With oXcl.Cells
            .Replace("#NoLab#", txtKdReg.Text)
            .Replace("#Waktu#", txtTglUji.Text)
            '.Replace("#NamaReg#", oReg.NmRujukan)
            '.Replace("#AlmReg1#", oRjk.Alm1)
            '.Replace("#AlmReg2#", oRjk.Alm2)
            '.Replace("#KotaReg#", oRjk.Kota)
            '.Replace("#TeleponReg#", oRjk.Telpon)
            .Replace("#Angka#", "Rp. " & txtTotal.Text)
            .Replace("#TglEst#", txtTglEstimasi.Text)
            .Replace("#Petugas#", oReg.NmPetugas)
            '.Replace("#Pelanggan#", oReg.NmRujukan)


            If oReg.KdRujukan = "UMUM" Then
                .Replace("#NamaReg#", oMR.xNama)
                .Replace("#AlmReg1#", oMR.xAlm1)
                .Replace("#AlmReg2#", oMR.xAlm2)
                .Replace("#KotaReg#", oMR.xKota)
                .Replace("#TeleponReg#", oMR.xTelp)
                oXcl.Cells.Replace("#Pelanggan#", xPasien)
            Else
                .Replace("#NamaReg#", oReg.NmRujukan)
                .Replace("#AlmReg1#", oRjk.Alm1)
                .Replace("#AlmReg2#", oRjk.Alm2)
                .Replace("#KotaReg#", oRjk.Kota)
                .Replace("#TeleponReg#", oRjk.Telpon)
                .Replace("#Pelanggan#", oRjk.NamaPerujuk)
            End If

            With oTrs.TarifDS.Tables(0)
                For i As Integer = 0 To .Rows.Count - 1
                    oXcl.Cells(16 + i, 4).value = i + 1 & ". " & .Rows(i)("fs_nm_tarif")
                    If i > 0 And i < .Rows.Count - 1 Then
                        oXcl.Rows(17 + i).insert()
                    End If
                    xRow = 17 + i
                Next

            End With

            With oSample.JmlSampleDS.Tables(0)

                If oTrs.TarifDS.Tables(0).Rows.Count < 3 Then
                    If .Rows.Count < 2 Then
                        For i As Integer = 0 To .Rows.Count - 1
                            oXcl.Cells(18 + i, 4).value = "- " & .Rows(i)("fs_nm_jenis_sample") & " = " & .Rows(i)("sub_total")
                        Next
                    Else
                        For i As Integer = 0 To .Rows.Count - 1
                            If i > 1 Then
                                oXcl.Rows(xRow + 1 + i).insert()
                            End If
                            oXcl.Cells(xRow + 1 + i, 4).value = "- " & .Rows(i)("fs_nm_jenis_sample") & " = " & .Rows(i)("sub_total")
                        Next
                    End If
                Else
                    For i As Integer = 0 To .Rows.Count - 1
                        If i > 1 Then
                            oXcl.Rows(xRow + i).insert()
                        End If
                        oXcl.Cells(xRow + i, 4).value = "- " & .Rows(i)("fs_nm_jenis_sample") & " = " & .Rows(i)("sub_total")
                    Next
                End If
            End With
        End With

        oXcl.ActiveWorkbook.PrintOutEx()
        oXcl.ActiveWorkbook.Close(False)
        oXcl.Workbooks.Close()
        oXcl = Nothing

    End Sub

    Private Sub txtKdReg_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKdReg.KeyDown
        Dim oHelper As New clsHelper
        Select Case e.KeyCode
            Case Keys.Enter
                oHelper.SendTab()
            Case Keys.F12
                Dim oFrmCariReg As New frmCariRegister
                oFrmCariReg.ShowDialog()
                txtKdReg.Text = oFrmCariReg.KodeReg
                If txtKdReg.Text <> "" Then
                    oHelper.SendTab()
                End If
        End Select
    End Sub

    Private Sub clrScr()
        txtNmRujuk.Text = ""
        txtAlmRujuk1.Text = ""
        txtAlmRujuk2.Text = ""
        txtKotaRujuk.Text = ""
        txtKdReg.Text = ""
        grid.Rows.Clear()

    End Sub

    Private Sub txtTgl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTglUji.KeyDown, txtJamUji.KeyDown
        If e.KeyCode = Keys.F11 Then
            xTimer.Stop()
        ElseIf e.KeyCode = Keys.F12 Then
            xTimer.Start()
        End If
    End Sub
End Class