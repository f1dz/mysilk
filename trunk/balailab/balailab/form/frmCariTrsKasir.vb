Public Class frmCariTrsKasir
    Dim oBind As New BindingSource
    Dim oKasir As New clsTrsKasir
    Public KodeTrs As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmCariTrsKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuery.Focus()

        grid.DataSource = oBind
        oBind.DataSource = oKasir.Cari

        grid.Dock = DockStyle.Fill
        grid.RowHeadersWidth = 20
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.Columns(0).HeaderText = "Kode"
        grid.Columns(0).FillWeight = 45
        grid.Columns(1).FillWeight = 45
        grid.Columns(1).HeaderText = "Tanggal"
        grid.Columns(2).HeaderText = "No. Lab"
        grid.Columns(2).FillWeight = 45
        grid.Columns(3).HeaderText = "Perujuk"
        'grid.Columns(3).FillWeight = 40
        grid.Columns(4).HeaderText = "Total"
        grid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grid.Columns(4).FillWeight = 50


        ' Default Tanggal
        txtTgl1.Text = DateAdd(DateInterval.Day, -30, Today)
        txtTgl2.Text = Format(Today, "yyyy/MM/dd")
    End Sub

    Private Sub txtQuery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuery.TextChanged, txtTgl1.TextChanged, txtTgl2.TextChanged
        oBind.Filter = "fs_nm_rujukan LIKE '%" & txtQuery.Text & "%' " _
                     & "AND fd_tgl_trs >= '" & txtTgl1.Text & "' " _
                     & "AND fd_tgl_trs <= '" & txtTgl2.Text & "' "
    End Sub

    Private Sub grid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        KodeTrs = grid.Item(0, i).Value
        Me.Close()
    End Sub
End Class