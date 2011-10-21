
Public Class frmTrsSample
    'Dim oTrs As New clsTrsSample
    Public DS As New DataSet
    Public xKode As String
    Dim oBind As New BindingSource

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        'Dim i As Integer
        'For i = 0 To oTrs.getBentukSample.Tables(0).Rows.Count - 1
        '    MsgBox(oTrs.getBentukSample.Tables(0).Rows(i)("fs_kd_bentuk_sample"))
        'Next

    End Sub

    Private Sub frmTrsSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' List Jenis Sample
        Dim oJenis As New clsTrsSample
        Me.grid.DataSource = oBind
        oBind.DataSource = oJenis.CariData

        grid.Dock = DockStyle.Fill
        grid.RowHeadersWidth = 10
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.Columns(0).HeaderText = "Kode"
        grid.Columns(0).FillWeight = 40
        grid.Columns(1).HeaderText = "Jenis Sample"

        ' Combo Bentuk Sample
        Dim oBentuk As New clsTrsSample
        cbBentukSample.DataSource = oBentuk.xSample("TA_BENTUK_SAMPLE").Tables(0)
        cbBentukSample.DisplayMember = "fs_nm_bentuk_sample"
        cbBentukSample.ValueMember = "fs_kd_bentuk_sample"

        ' Combo Wadah Sample
        Dim oWadah As New clsTrsSample
        cbWadahSample.DataSource = oWadah.xSample("TA_WADAH_SAMPLE").Tables(0)
        cbWadahSample.DisplayMember = "fs_nm_wadah_sample"
        cbWadahSample.ValueMember = "fs_kd_wadah_sample"

        ' Combo Bahan Wadah
        Dim oBahanWadah As New clsTrsSample
        cbBahanWadah.DataSource = oBahanWadah.xSample("TA_BAHAN_WADAH").Tables(0)
        cbBahanWadah.DisplayMember = "fs_nm_bahan_wadah"
        cbBahanWadah.ValueMember = "fs_kd_bahan_wadah"

        ' Combo Tutup Wadah
        Dim oTutupSample As New clsTrsSample
        cbTutupSample.DataSource = oTutupSample.xSample("TA_TUTUP_SAMPLE").Tables(0)
        cbTutupSample.ValueMember = "fs_kd_tutup_sample"
        cbTutupSample.DisplayMember = "fs_nm_tutup_sample"

        ' Jika Kode terisi
        If Trim(xKode) <> "" Then
            Dim oSample As New clsTrsSample
            txtKdSample.Text = xKode
            oSample.vKode = xKode
            cbBentukSample.SelectedValue = oSample.xKdBentuk
            txtBentukSampleLain.Text = oSample.xBentukLain
            txtJumlah.Text = oSample.xQty
            txtJumlahSatuan.Text = oSample.xSatQty
            txtSuhu.Text = oSample.xSuhu
            txtSuhuSatuan.Text = oSample.xSatSuhu
            cbWadahSample.SelectedValue = oSample.xKdWadah
            txtWadahSampleLain.Text = oSample.xWadahLain
            cbBahanWadah.SelectedValue = oSample.xKdBahanWadah
            txtBahanWadahLain.Text = oSample.xBahanWadahLain
            cbTutupSample.SelectedValue = oSample.xKdTutup
            txtTutupSampleLain.Text = oSample.xTutupLain
            txtKetSample.Text = oSample.xKet
            txtKdJenisSample.Text = oSample.xKdJenisSample
            txtNmJenisSample.Text = oSample.xNmJenisSample
        End If
    End Sub

    Private Sub cbBentukSample_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        cbBentukSample.SelectedIndexChanged, _
        cbWadahSample.SelectedIndexChanged, _
        cbTutupSample.SelectedIndexChanged, _
        cbBahanWadah.SelectedIndexChanged
        Dim cb As ComboBox
        cb = CType(sender, ComboBox)
        Select Case cb.Name
            Case "cbBentukSample"
                If cbBentukSample.SelectedValue.ToString = "999" Then
                    txtBentukSampleLain.Enabled = True
                Else
                    txtBentukSampleLain.Enabled = False
                End If
            Case "cbWadahSample"
                If cbWadahSample.SelectedValue.ToString = "999" Then
                    txtWadahSampleLain.Enabled = True
                Else
                    txtWadahSampleLain.Enabled = False
                End If
                'Case "cbTutupSample"
                '    If cbTutupSample.SelectedValue.ToString = "999" Then
                '        txtTutupSampleLain.ReadOnly = False
                '    Else
                '        txtTutupSampleLain.ReadOnly = True
                '    End If
            Case "cbBahanWadah"
                If cbBahanWadah.SelectedValue.ToString = "999" Then
                    txtBahanWadahLain.Enabled = True
                Else
                    txtBahanWadahLain.Enabled = False
                End If
        End Select

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oKode As New clsParam
        Dim oTrs As New clsTrsSample
        oTrs.xKdBentuk = cbBentukSample.SelectedValue
        oTrs.xBentukLain = txtBentukSampleLain.Text
        oTrs.xQty = txtJumlah.Text
        oTrs.xSatQty = txtJumlahSatuan.Text
        oTrs.xSuhu = txtSuhu.Text
        oTrs.xSatSuhu = txtSuhuSatuan.Text
        oTrs.xKdWadah = cbWadahSample.SelectedValue
        oTrs.xWadahLain = txtWadahSampleLain.Text
        oTrs.xKdBahanWadah = cbBahanWadah.SelectedValue
        oTrs.xBahanWadahLain = txtBahanWadahLain.Text
        oTrs.xKdTutup = cbTutupSample.SelectedValue
        oTrs.xTutupLain = txtTutupSampleLain.Text
        oTrs.xKet = txtKetSample.Text
        oTrs.xKdJenisSample = txtKdJenisSample.Text

        Dim xLanjut As Boolean = True
        If Trim(txtKdJenisSample.Text) = "" Then
            MsgBox("Kode Jenis Sample belum terisi" & vbCrLf & "Doble Klik pada jenis sample", MsgBoxStyle.Exclamation)
            grid.Focus()
            xLanjut = False
        Else
            If Trim(xKode) <> "" Then
                oTrs.xKode = xKode
                oTrs.Update()
            Else
                oTrs.xKode = oKode.getKode("SM")
                oTrs.Save()
            End If
        End If
        If xLanjut = True Then
            xKode = oTrs.xKode
            Me.Close()
        End If
    End Sub

    Public Sub New(ByRef vKode As String)
        InitializeComponent()
        xKode = vKode
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        oBind.Filter = "fs_nm_jenis_sample LIKE '%" & txtCari.Text & "%' " _
             & "OR fs_kd_jenis_sample LIKE '%" & txtCari.Text & "%' "
    End Sub

    Private Sub grid_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        txtKdJenisSample.Text = grid.Item(0, i).Value
    End Sub

    Private Sub txtKdJenisSample_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdJenisSample.TextChanged
        Dim oJns As New clsTrsSample
        oJns.vKodeJenis = txtKdJenisSample.Text
        txtNmJenisSample.Text = oJns.xNmJenisSample
    End Sub
End Class