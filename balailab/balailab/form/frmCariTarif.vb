Public Class frmCariTarif
    Dim oBind As New BindingSource
    Dim oTarif As New clsTarif
    Public Kode As String
    Public NmTarif As String
    Public NilaiTarif As Double

    Private Sub frmCariTarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuery.Focus()

        grid.DataSource = oBind
        oBind.DataSource = oTarif.Cari

        grid.Dock = DockStyle.Fill
        grid.RowHeadersWidth = 30
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.Columns(0).HeaderText = "Kode"
        grid.Columns(0).FillWeight = 40
        grid.Columns(1).HeaderText = "Nama Tarif"
        grid.Columns(2).HeaderText = "Tarif"
        grid.Columns(2).FillWeight = 40
        grid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtQuery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuery.TextChanged
        oBind.Filter = "fs_nm_tarif LIKE '%" & txtQuery.Text & "%' " _
                     & "OR fs_kd_tarif LIKE '%" & txtQuery.Text & "%' "
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        Dim oFrmPilihSample As New frmPilihPasien
        Dim oFrmTrsUji As New frmTrsUji
        Dim oReg As New clsTrsRegistrasi
        Dim oUji As New clsTrsUji

        oReg.Kode = My.Settings.tmpKdReg
        oReg.vKodeRegGetKdSample = My.Settings.tmpKdReg
        My.Settings.tmpKdTarif = grid.Item(0, i).Value
        Me.Dispose()

        If oReg.JumlahSample > 1 Then
            oFrmPilihSample.ShowDialog()
        Else
            My.Settings.tmpQtySample = 1
            oUji.KdReg = My.Settings.tmpKdReg
            oUji.KdTarif = My.Settings.tmpKdTarif
            oUji.KdSample = oReg.KdSample
            oUji.InsertUji4()
        End If
    End Sub
End Class