Public Class frmCariPerujuk
    Dim oRjk As New clsPerujuk
    Dim oHelper As New clsHelper
    Public Kode As String
    Dim oBind As New BindingSource

    'Dim WithEvents oBind As Binding

    Private Sub frmCariPerujuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuery.Focus()

        Me.grid.DataSource = oBind
        oBind.DataSource = oRjk.CariData

        grid.Dock = DockStyle.Fill
        grid.RowHeadersWidth = 30
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.Columns(0).HeaderText = "Kode"
        grid.Columns(0).FillWeight = 40
        grid.Columns(1).HeaderText = "Nama Rujukan"

    End Sub


    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        Kode = grid.Item(0, i).Value
        Me.Close()
    End Sub

    Private Sub txtQuery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuery.TextChanged
        oBind.Filter = "fs_nm_rujukan LIKE '%" & txtQuery.Text & "%' " _
                     & "OR fs_kd_rujukan LIKE '%" & txtQuery.Text & "%' "
    End Sub

    Private Sub txtQuery_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuery.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim i As Integer = grid.CurrentRow.Index
                Kode = grid.Item(0, i).Value
                Me.Close()
            Case Keys.Up, Keys.Down

                'oHelper.SendTab()
                grid.Focus()
        End Select
    End Sub

    Private Sub grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim i As Integer = grid.CurrentRow.Index
                Kode = grid.Item(0, i).Value
                Me.Close()
        End Select
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim i As Integer = grid.CurrentRow.Index
        Kode = grid.Item(0, i).Value
        Me.Close()
    End Sub
End Class