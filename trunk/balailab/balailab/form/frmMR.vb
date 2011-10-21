Public Class frmMR
    Public xKode As String
    Dim oHelper As New clsHelper

    Private Sub frmMR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oParam As New clsParam
        Dim oMR As New clsMR

        ' Fill COmbo Sex
        cbSex.DataSource = oParam.xCombo("TC_SEX").Tables(0)
        cbSex.DisplayMember = "fs_nm_sex"
        cbSex.ValueMember = "fs_kd_sex"

        ' Default load
        If Trim(xKode) <> "" Then
            txtNoMR.Text = xKode
            oMR.vKode = xKode
            txtNama.Text = oMR.xNama
            txtTglLahir.Text = oParam.tglYMDdp(oMR.xTglLahir)
            txtTempatLahir.Text = oMR.xTempatLahir
            txtAlm1.Text = oMR.xAlm1
            txtAlm2.Text = oMR.xAlm2
            txtKota.Text = oMR.xKota
            txtTelp.Text = oMR.xTelp
            cbSex.SelectedValue = oMR.xKdSex
        End If

        If Trim(txtNoMR.Text) <> "" Then
            ' Fill
        Else
            txtTglLahir.Value = Today.Date
        End If

        If sender.Name = "dgvSample" Then
            txtNama.Focus()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oParam As New clsParam
        Dim oMR As New clsMR
        oMR.xNama = txtNama.Text
        oMR.xAlm1 = txtAlm1.Text
        oMR.xAlm2 = txtAlm2.Text
        oMR.xKota = txtKota.Text
        oMR.xKdSex = cbSex.SelectedValue
        oMR.xTglLahir = oParam.tglYMD(txtTglLahir.Text)
        oMR.xTempatLahir = txtTempatLahir.Text
        oMR.xTelp = txtTelp.Text
        If Trim(txtNoMR.Text) <> "" Then
            oMR.xKode = xKode
            oMR.Update()
        Else
            oMR.xKode = oParam.getKode("MR")
            oMR.save()
            xKode = oMR.xKode
        End If
        Me.Close()
    End Sub

    Public Sub New(ByRef vKode As String)
        InitializeComponent()
        xKode = vKode
    End Sub

    Private Sub txtEntry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        txtNoMR.KeyDown, txtNama.KeyDown, txtTglLahir.KeyDown, txtTempatLahir.KeyDown, _
        txtAlm1.KeyDown, txtAlm2.KeyDown, txtKota.KeyDown, txtTelp.KeyDown, cbSex.KeyDown
        If e.KeyCode = Keys.Enter Then
            oHelper.SendTab()
        End If
    End Sub
End Class