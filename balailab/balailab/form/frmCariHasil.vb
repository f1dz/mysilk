Public Class frmCariHasil

    Public Kode As String
    Private oBind As New BindingSource
    Private oHasil As New clsEntryHasil

    Private Sub frmCariHasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtQuery.Focus()
        Me.grid.DataSource = Me.oBind
        Me.oBind.DataSource = oHasil.CariHasilDS
        Me.grid.Dock = DockStyle.Fill
        Me.grid.RowHeadersWidth = 20
        Me.grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.Columns.Item(0).HeaderText = "Kode"
        Me.grid.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.grid.Columns.Item(0).MinimumWidth = 60
        Me.grid.Columns.Item(1).HeaderText = "Tgl Reg"
        Me.grid.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.grid.Columns.Item(1).MinimumWidth = 60
        Me.grid.Columns.Item(2).HeaderText = "Tgl Est"
        Me.grid.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.grid.Columns.Item(2).MinimumWidth = 60
        Me.grid.Columns.Item(3).HeaderText = "Sample"
        Me.grid.Columns.Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.grid.Columns.Item(3).MinimumWidth = 60
        Me.grid.Columns.Item(4).HeaderText = "Jenis Sample"
        Me.grid.Columns.Item(4).MinimumWidth = 60
        Me.grid.Columns.Item(5).HeaderText = "Merk"
        Me.grid.Columns.Item(5).MinimumWidth = 60
        Me.grid.Columns.Item(6).HeaderText = "Rujukan"
        Me.grid.Columns.Item(6).MinimumWidth = 60
        Me.TglReg2.Text = Strings.Format(DateAndTime.Today, "yyyy/MM/dd")
        Me.TglEst2.Text = Strings.Format(DateAndTime.Today, "yyyy/MM/dd")
    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        Dim i As Integer = Me.grid.CurrentRow.Index
        Me.Kode = Convert.ToString(Me.grid.Item(0, i).Value)
        Me.Close()
    End Sub

    Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = Me.grid.CurrentRow.Index
        Me.Kode = Convert.ToString(Me.grid.Item(0, i).Value)
        Me.Close()
    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles grid.KeyDown
        Select Case e.KeyCode
            Case Keys.Return
                Dim i As Integer = Me.grid.CurrentRow.Index
                Me.Kode = Convert.ToString(Me.grid.Item(0, i).Value)
                Me.Close()
                Exit Select
            Case Keys.Escape
                Me.Kode = ""
                Me.Close()
                Exit Select
        End Select
    End Sub

    Private Sub txtQuery_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Return
                Me.grid.Focus()
                Exit Select
        End Select
    End Sub

    Private Sub txtQuery_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.oBind.Filter = String.Concat(New String() {"fs_nm_rujukan LIKE '%", Me.txtQuery.Text, "%' AND fd_tgl_reg >= '", Me.TglReg1.Text, "' AND fd_tgl_reg <= '", Me.TglReg2.Text, "' AND fd_tgl_estimasi >= '", Me.TglEst1.Text, "' AND fd_tgl_estimasi <= '", Me.TglEst2.Text, "' "})
    End Sub
End Class