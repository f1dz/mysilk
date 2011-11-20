Public Class frmSetupPerujuk
    Dim oRjk As New clsPerujuk
    Public Kode As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oParam As New clsParam
        oRjk.KodePerujuk = txtKode.Text
        oRjk.NamaPerujuk = txtNama.Text
        oRjk.Telpon = txtTelpon.Text
        oRjk.Alm1 = txtAlm1.Text
        oRjk.Alm2 = txtAlm2.Text
        oRjk.Kota = txtKota.Text
        oRjk.Kolektif = CbKolektif.CheckState
        If oRjk.isExist(Trim(txtKode.Text)) Then
            oRjk.Update()
        Else
            oRjk.Save()
        End If
        Kode = oRjk.KodePerujuk
        Me.Close()
    End Sub
    Public Sub New(ByRef vKode As String)
        InitializeComponent()
        Kode = vKode
    End Sub

    Private Sub frmSetupPerujuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Trim(Kode) <> "" Then
            txtKode.Text = Kode
            oRjk.vKode = Kode
            txtNama.Text = oRjk.NamaPerujuk
            txtTelpon.Text = oRjk.Telpon
            txtAlm1.Text = oRjk.Alm1
            txtAlm2.Text = oRjk.Alm2
            txtKota.Text = oRjk.Kota
            CbKolektif.Checked = oRjk.Kolektif
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class