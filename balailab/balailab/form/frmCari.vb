Imports System.Data.OleDb

Public Class frmCari
    Dim conn As New clsConn
    Dim oCmd As New OleDbCommand
    Dim oDA As New OleDbDataAdapter
    Dim oDS As New DataSet
    Dim oDR As OleDbDataReader
    Dim oBind As New BindingSource
    Public Property Kode As String
    Public Property sSQL As String
    Public Property Title As String
    Public Property FilterColumn As String
    Public Property Col1 As String
    Public Property Col2 As String
    Public Property Col3 As String

    Public Sub New(ByRef vTitle As String, ByRef vSQL As String, ByRef vFilterCol As String, ByRef vCol1 As String, ByRef vCol2 As String, ByRef vCol3 As String)
        InitializeComponent()
        'Kode = vKode
        sSQL = vSQL
        Title = vTitle
        FilterColumn = vFilterCol
        Col1 = vCol1
        Col2 = vCol2
        Col3 = vCol3
    End Sub

    Public Function DataSet() As DataSet
        Try
            oDS.Clear()
            conn.open()
            oCmd = New OleDbCommand(sSQL, conn.oConn)
            oDA.SelectCommand = oCmd
            oDA.Fill(oDS)
            If oDS.Tables(0).Rows.Count > 0 Then
                Return oDS
            Else
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
                Return oDS
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        conn.close()
        Return Nothing
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuery.Focus()
        Me.TitleText = "Cari " & Title
        With DataSet()
            If .Tables(0).Rows.Count > 0 Then
                grid.DataSource = oBind
                oBind.DataSource = .Tables(0)

                grid.RowHeadersWidth = 20
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                grid.Columns(0).HeaderText = "Kode"
                grid.Columns(0).FillWeight = 45
                grid.Columns(0).MinimumWidth = 60
                grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                grid.Columns(1).FillWeight = 45
                grid.Columns(1).MinimumWidth = 60
                grid.Columns(1).HeaderText = Col1
                'grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                If Col2 <> "" Then
                    grid.Columns(2).FillWeight = 45
                    grid.Columns(2).MinimumWidth = 60
                    grid.Columns(2).HeaderText = Col2
                    'grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
                If Col3 <> "" Then
                    grid.Columns(3).FillWeight = 45
                    grid.Columns(3).MinimumWidth = 60
                    grid.Columns(3).HeaderText = Col3
                End If
            Else
                btnOK.Enabled = False
            End If

        End With

    End Sub

    Private Sub grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = grid.CurrentRow.Index
        Kode = grid.Item(0, i).Value
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim i As Integer = grid.CurrentRow.Index
        Kode = grid.Item(0, i).Value
        Me.Close()
    End Sub

    Private Sub txtQuery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuery.KeyDown
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

    Private Sub txtQuery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuery.TextChanged
        oBind.Filter = FilterColumn & " LIKE '%" & txtQuery.Text & "%'"
    End Sub

    Private Sub grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim i As Integer = grid.CurrentRow.Index
                Kode = grid.Item(0, i).Value
                Me.Close()
        End Select
    End Sub
End Class