Imports C1.Win.C1FlexGrid
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmCetakHasil
    Dim oHasil As New clsEntryHasil
    Dim oHelper As New clsHelper
    Dim oParam As New clsParam
    Dim KodeHasil As String

    Private Sub frmCetakHasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim group As C1FlexGrid.ControlCollection


    End Sub

    Private Sub txtKdHasil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKdHasil.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                oHelper.SendTab()
            Case Keys.F12
                Dim sSql As String
                sSql = "SELECT  aa.fs_kd_trs , " & vbCrLf _
                     & "        aa.fs_kd_reg, " & vbCrLf _
                     & "        cc.fs_nm_pasien " & vbCrLf _
                     & "FROM    TA_TRS_HASIL aa " & vbCrLf _
                     & "INNER JOIN TA_TRS_REG2 bb ON aa.fs_kd_sample = bb.fs_kd_sample " & vbCrLf _
                     & "INNER JOIN TC_MR cc ON cc.fs_mr = bb.fs_mr " & vbCrLf _
                     & "WHERE   aa.fd_tgl_trs BETWEEN '" & Format(DateAdd(DateInterval.Day, -30, Today), "yyyy-MM-dd") & "' AND '" & Format(Today, "yyyy-MM-dd") & "' "
                Dim oFrmCari As New frmCari("Cari Hasil", sSql, "fs_nm_pasien", "Kode Reg.", "Pasien", "")
                oFrmCari.ShowDialog()
                txtKdHasil.Text = oFrmCari.Kode
                oHelper.SendTab()
        End Select
    End Sub

    Private Sub txtKdHasil_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdHasil.Validating
        Select Case sender.Name
            Case "txtKdHasil"

                If txtKdHasil.Text = "" Then
                    ClrScr()
                    Exit Sub
                End If

                txtKdHasil.Text = oParam.genKode("HS", txtKdHasil.Text)
                If oHasil.isExist(txtKdHasil.Text) And Trim(txtKdHasil.Text) <> "" Then
                    KodeHasil = txtKdHasil.Text
                    FillGrid()
                    oHelper.SendTab()
                Else
                    MsgBox("Kode hasil tidak ditemukan", MsgBoxStyle.Exclamation)
                    txtKdHasil.Focus()
                End If
        End Select
    End Sub

    Private Sub FillGrid()
        Dim oSample As New clsTrsSample
        Dim oInst As New clsInstalasi
        Dim oMR As New clsMR
        oHasil.vKode = KodeHasil

        ' Fill Text
        txtKdReg.Text = oHasil.KodeReg
        txtKdSample.Text = oHasil.KodeSample
        txtKdInstalasi.Text = oHasil.KodeInstalasi
        txtTglHasil.Text = oParam.tglYMDdp(oHasil.TglHasil)
        txtMerk.Text = oHasil.Merk
        txtPengambil.Text = oHasil.Pengambil
        txtKesimpulan.Text = oHasil.Kesimpulan

        oInst.vKodeInst = txtKdInstalasi.Text
        txtNmInstalasi.Text = oInst.NamaInst

        oSample.vKode = txtKdSample.Text
        txtJnsBahan.Text = oSample.xNmJenisSample
        txtKemasan.Text = oSample.xNmBahanWadah
        txtJumlah.Text = oSample.xQty & " " & oSample.xSatQty

        oMR.vKode = oSample.xKdMR
        txtNama.Text = oMR.xNama
        txtAlm1.Text = oMR.xAlm1
        txtAlm2.Text = oMR.xAlm2
        txtKota.Text = oMR.xKota
        txtTelp.Text = oMR.xTelp

        grid.Dock = DockStyle.Fill
        grid.Tree.Style = TreeStyleFlags.Simple
        grid.Tree.Column = 0
        grid.Tree.Show(1)
        grid.AutoSizeCols()
        grid.AllowMerging = AllowMergingEnum.Nodes
        grid.DataSource = oHasil.UjiPerInstDS.Tables(0)

        With grid
            .Cols(1).Caption = "Grup Uji"
            .Cols(2).Caption = "Kode"
            .Cols(3).Caption = "Pengujian"
            .Cols(4).Caption = "Satuan"
            .Cols(5).Caption = "Hasil"
            .Cols(6).Caption = "Nilai Normal"
            .Cols(7).Caption = "Metode"
            .Cols(8).Caption = "Sample"
            .Cols(8).Visible = False
        End With
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
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        ' Cetaaaaaaak
        If Trim(txtKdHasil.Text) <> "" Then
            If MsgBox("Cetak Hasil ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CetakHasil()
            End If
        End If
    End Sub

    Private Sub CetakHasil()
        Dim oXcl As New Excel.Application
        Dim oReg As New clsTrsRegistrasi
        Dim oSample As New clsTrsSample
        Dim oRjk As New clsPerujuk
        Dim oHasil As New clsEntryHasil
        Dim oMR As New clsMR
        Dim oInst As New clsInstalasi
        Dim oBooks As Object = oXcl.Workbooks
        Dim ci As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("en-US")
        oBooks.GetType().InvokeMember("Add", Reflection.BindingFlags.InvokeMethod, Nothing, oBooks, Nothing, ci)

        oHasil.vKode = txtKdHasil.Text
        oSample.vKode = txtKdSample.Text
        oMR.vKode = oSample.xKdMR
        oInst.vKodeInst = txtKdInstalasi.Text
        oReg.vKode = txtKdReg.Text
        oXcl.Visible = False
        With oHasil.UjiPerInstDS.Tables(0)
            oXcl.Workbooks.Add(My.Settings.AppPath & "\templates\BBLK_HS-.xlt")
            With oXcl.Cells
                .Replace("#NamaMR#", oMR.xNama & " - " & oSample.xKdMR)
                .Replace("#Alamat#", oMR.xAlm1 & " " & oMR.xAlm2)
                .Replace("#Kota#", oMR.xKota)
                .Replace("#Telp#", oMR.xTelp)
                .Replace("#NamaRujuk#", oReg.NmRujukan)
                .Replace("#NoReg#", txtKdReg.Text)
                .Replace("#Instalasi#", oInst.NamaInst)
                .Replace("#NoSample#", txtKdSample.Text)
                .Replace("#Sample#", oSample.xNmJenisSample)
                .Replace("#Qty#", oSample.xQty & " " & oSample.xSatQty)
                .Replace("#Pengambil#", txtPengambil.Text)
                .Replace("#TglReg#", oParam.tglDMY(oReg.Tgl))
                .Replace("#TglUji#", txtTglHasil.Text)
                .Replace("#Kesimpulan#", txtKesimpulan.Text)
                .Replace("#Waktu#", Format(Today, "dd-MM-yyyy"))
                .Replace("#NamaInstalasi#", oInst.NamaInst)
                .Replace("#NamaKepInstalasi#", oInst.NamaKepInst)
                .Replace("#Nip#", oInst.NipKepInst)
            End With

            Dim xGroup As String = ""
            Dim xRow As Integer = 13
            For i As Integer = 1 To .Rows.Count
                Dim filter As New C1.Win.C1FlexGrid.ConditionFilter
                With oXcl
                    If grid(i, 1) <> xGroup Then
                        xRow += 1
                        .Cells(xRow, 2).Value = UCase(grid(i, 1))
                        .Cells(xRow, 2).Font.FontStyle = "Bold"
                        oXcl.Rows(xRow + 1).insert()

                        xGroup = grid(i, 1)
                        Dim n As Integer = 1
                        For j As Integer = 1 To grid.Rows.Count - 1
                            If xGroup = grid(j, 1) Then
                                'xRow += 1

                                .Cells(xRow + 1, 1).value = n
                                .Cells(xRow + 1, 2).Value = grid(j, 3)
                                .Cells(xRow + 1, 4).Value = grid(j, 4)
                                .Cells(xRow + 1, 5).Value = grid(j, 5)
                                .Cells(xRow + 1, 6).Value = Replace(grid(j, 6), vbCrLf, "")
                                .Cells(xRow + 1, 8).Value = Replace(grid(j, 7), vbCrLf, "")
                                .Cells(xRow + 1, 2).Font.FontStyle = ""
                                'xRow = 14 + j
                                xRow += 1
                                oXcl.Rows(xRow + 1).insert()
                                n += 1
                            End If
                        Next

                    End If

                End With
            Next

        End With
        oXcl.ActiveWorkbook.PrintOutEx()
        oXcl.ActiveWorkbook.Close(False)
        oXcl = Nothing
    End Sub
End Class