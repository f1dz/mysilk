Public Class frmCariSample
    Dim oSample As New clsTrsSample
    Dim oBind As New BindingSource
    Public KodeSample As String
    Public KodeReg As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub New(ByRef vKodeReg As String)
        InitializeComponent()
        KodeReg = vKodeReg
    End Sub

    Private Sub frmCariSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuery.Focus()
        oSample.xKdReg = KodeReg
        grid.DataSource = oBind
        oBind.DataSource = oSample.CariByReg

        grid.RowHeadersWidth = 20
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.Columns(0).HeaderText = "Kode"
        grid.Columns(0).Width = 85
        grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grid.Columns(1).HeaderText = "Pasien"
        grid.Columns(2).HeaderText = "Sample"
        grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'grid.Columns(3).HeaderText = "Kota"

    End Sub

    Private Sub grid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        KodeSample = grid.Item(0, i).Value
        Me.Close()
    End Sub
End Class