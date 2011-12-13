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
                'Dim sSql As String
                'sSql = "SELECT  aa.fs_kd_trs , " & vbCrLf _
                '     & "        aa.fs_kd_reg, " & vbCrLf _
                '     & "        cc.fs_nm_pasien " & vbCrLf _
                '     & "FROM    TA_TRS_HASIL aa " & vbCrLf _
                '     & "INNER JOIN TA_TRS_REG2 bb ON aa.fs_kd_sample = bb.fs_kd_sample " & vbCrLf _
                '     & "INNER JOIN TC_MR cc ON cc.fs_mr = bb.fs_mr " & vbCrLf _
                '     & "WHERE   aa.fd_tgl_trs BETWEEN '" & Format(DateAdd(DateInterval.Day, -30, Today), "yyyy-MM-dd") & "' AND '" & Format(Today, "yyyy-MM-dd") & "' "
                'Dim oFrmCari As New frmCari("Cari Hasil", sSql, "fs_nm_pasien", "Kode Reg.", "Pasien", "")
                'oFrmCari.ShowDialog()
                'txtKdHasil.Text = oFrmCari.Kode
                'oHelper.SendTab()
                CariHasil()
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
                    oHasil.vKode = txtKdHasil.Text

                    If oHasil.Cetak Then
                        If MsgBox("Hasil sudah pernah dicetak dengan Nomor Seri " & oHasil.NoSeri & vbCrLf & _
                                  "Lanjutkan Cetak? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            txtKdHasil.Focus()
                            ClrScr()
                            Exit Sub
                        End If
                    End If

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
        txtPermenkes.Text = oHasil.Permenkes
        txtISO.Text = oHasil.ISO
        txtKet.Text = oHasil.Ket
        txtNoSeri.Text = oHasil.NoSeri
        oInst.vKodeInst = txtKdInstalasi.Text
        txtNmInstalasi.Text = oInst.NamaInst
        TxtNoInstalasi.Text = oHasil.NoInstalasi

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
        'grid.DataSource = oHasil.UjiPerInstDS.Tables(0)

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

    Private Sub ClrScr()
        grid.DataSource = Nothing
        grid.Rows.Clear()
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
        txtNoSeri.Clear()
        txtISO.Clear()
        TxtNoInstalasi.Clear()
        txtPermenkes.Clear()
        txtKet.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        ' Cetaaaaaaak
        If Trim(txtKdHasil.Text) <> "" Then
            oHasil.NoSeri = txtNoSeri.Text
            oHasil.Permenkes = txtPermenkes.Text
            oHasil.ISO = txtISO.Text
            oHasil.Ket = txtKet.Text
            oHasil.UpdateNomor()
            If MsgBox("Cetak Hasil ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CetakHasil()
                ClrScr()
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
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        oHasil.vKode = txtKdHasil.Text
        oSample.vKode = txtKdSample.Text
        oMR.vKode = oSample.xKdMR
        oInst.vKodeInst = txtKdInstalasi.Text
        oReg.vKode = txtKdReg.Text
        oXcl.Visible = False
        With oHasil.UjiPerInstDS.Tables(0)
            oXcl.Workbooks.Add(My.Settings.AppPath & "\templates\BBLK_HS-.xlt")
            With oXcl.Cells
                .Replace("#NoSeri#", oHasil.NoSeri)
                .Replace("#NamaMR#", oMR.xNama & " - " & oSample.xKdMR)
                .Replace("#Alamat#", oMR.xAlm1 & " " & oMR.xAlm2)
                .Replace("#Kota#", oMR.xKota)
                .Replace("#Telp#", oMR.xTelp)
                .Replace("#NamaRujuk#", oReg.NmRujukan)
                .Replace("#NoReg#", txtKdReg.Text)
                .Replace("#Instalasi#", oHasil.NoInstalasi)
                .Replace("#NoSample#", txtKdSample.Text)
                .Replace("#Sample#", oSample.xNmJenisSample)
                .Replace("#Qty#", oSample.xQty & " " & oSample.xSatQty)
                .Replace("#Pengambil#", txtPengambil.Text)
                .Replace("#TglReg#", oParam.tglDMY(oReg.Tgl))
                .Replace("#TglUji#", txtTglHasil.Text)
                .Replace("#Kesimpulan#", txtKesimpulan.Text)
                .Replace("#Permenkes#", txtPermenkes.Text)
                Dim xISO As String
                If Trim(txtISO.Text) = "" Then
                    xISO = ""
                Else
                    xISO = "*) " & txtISO.Text
                End If
                .Replace("#ISO#", xISO)
                .Replace("#Ket#", txtKet.Text)
                .Replace("#Waktu#", Format(Today, "dd-MM-yyyy"))
                .Replace("#NamaInstalasi#", oInst.NamaInst)
                .Replace("#NamaKepInstalasi#", oInst.NamaKepInst)
                .Replace("#Nip#", oInst.NipKepInst)
            End With

            Dim xGroup As String = ""
            Dim xRow As Integer = 13
            For i As Integer = 1 To .Rows.Count - 1
                'Dim filter As New C1.Win.C1FlexGrid.ConditionFilter
                With oXcl
                    If grid.Item(0, i).Value <> xGroup Then
                        xRow += 1
                        .Cells(xRow, 2).Value = UCase(grid.Item(0, i).Value)
                        .Cells(xRow, 2).Font.FontStyle = "Bold"
                        oXcl.Rows(xRow + 1).insert()

                        xGroup = grid.Item(0, i).Value
                        Dim n As Integer = 1
                        For j As Integer = 0 To grid.Rows.Count - 1
                            If xGroup = grid.Item(0, j).Value Then
                                'xRow += 1

                                .Cells(xRow + 1, 1).value = n
                                .Cells(xRow + 1, 2).Value = grid.Item(2, j).Value
                                .Cells(xRow + 1, 4).Value = grid.Item(3, j).Value
                                .Cells(xRow + 1, 5).Value = grid.Item(4, j).Value
                                .Cells(xRow + 1, 6).Value = Replace(grid.Item(5, j).Value, vbCrLf, "")
                                .Cells(xRow + 1, 8).Value = Replace(grid.Item(6, j).Value, vbCrLf, "")
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
        oHasil.Cetak = 1
        oHasil.UpdateStatusCetak()
        oXcl.ActiveWorkbook.PrintOutEx()
        oXcl.ActiveWorkbook.Close(False)
        oXcl = Nothing
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

    Private Sub btnEditHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHasil.Click
        oHasil.vKode = txtKdHasil.Text
        If Trim(txtKdHasil.Text) <> "" And oHasil.isExist(txtKdHasil.Text) And oHasil.Cetak Then
            If MsgBox("Hasil sudah pernah dicetak dengan Nomor seri " & txtNoSeri.Text & vbCrLf & _
                      "Lanjutkan edit hasil ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                oHasil.Cetak = 0
                oHasil.UpdateStatusCetak()
            End If
        End If
    End Sub

    Private Sub CariHasil()
        Dim oFrmCari As New frmCariHasil
        oFrmCari.ShowDialog()
        txtKdHasil.Text = oFrmCari.Kode
        oHelper.SendTab()
    End Sub
End Class