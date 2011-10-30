Public Class frmCariRegister
    Dim oReg As New clsTrsRegistrasi
    Dim oBind As New BindingSource
    Public KodeReg As String

    Private Sub frmCariRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuery.Focus()

        grid.DataSource = oBind
        oBind.DataSource = oReg.Cari

        grid.Dock = DockStyle.Fill
        grid.RowHeadersWidth = 20
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.Columns(0).HeaderText = "Kode"
        grid.Columns(0).FillWeight = 45
        grid.Columns(0).MinimumWidth = 60
        grid.Columns(1).FillWeight = 45
        grid.Columns(1).MinimumWidth = 60
        grid.Columns(1).HeaderText = "Tanggal"
        grid.Columns(2).HeaderText = "Perujuk"
        'grid.Columns(2).FillWeight = 45
        grid.Columns(3).HeaderText = "Kota"
        grid.Columns(4).Visible = False

        ' Default Tanggal
        txtTgl1.Text = DateAdd(DateInterval.Day, -30, Today)
        txtTgl2.Text = Format(Today, "yyyy/MM/dd")
    End Sub

    Private Sub txtQuery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuery.KeyDown
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down
                grid.Focus()
        End Select

    End Sub

    Private Sub txtQuery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuery.TextChanged, txtTgl1.TextChanged, txtTgl2.TextChanged
        Dim state As String

        If cbView.Checked Then
            state = " "
        Else
            state = "AND fb_bayar = 0 "
        End If

        oBind.Filter = "fs_nm_rujukan LIKE '%" & txtQuery.Text & "%' " _
                     & "AND fd_tgl_reg >= '" & txtTgl1.Text & "' " _
                     & "AND fd_tgl_reg <= '" & txtTgl2.Text & "' " _
                     & state
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub grid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        KodeReg = grid.Item(0, i).Value
        Me.Close()
    End Sub

    Private Sub cbView_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbView.CheckedChanged, cbView2.CheckedChanged
        Dim state As String

        If cbView.Checked Then
            state = " "
        Else
            state = "AND fb_bayar = 0 "
        End If

        oBind.Filter = "fs_nm_rujukan LIKE '%" & txtQuery.Text & "%' " _
                     & "AND fd_tgl_reg >= '" & txtTgl1.Text & "' " _
                     & "AND fd_tgl_reg <= '" & txtTgl2.Text & "' " _
                     & state
    End Sub

    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim i As Integer = grid.CurrentRow.Index
                KodeReg = grid.Item(0, i).Value
                Me.Close()
            Case Keys.Escape
                KodeReg = ""
                Me.Close()
        End Select
    End Sub
End Class