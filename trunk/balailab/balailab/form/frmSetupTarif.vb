Public Class frmSetupTarif
    Dim oHp As New clsHelper
    Dim oTarif As New clsTarif
    Dim oUji As New clsTrsUji

    Private Sub frmSetupTarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub txtKdTarif_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKdTarif.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Dim sSql As String
                sSql = "SELECT * from TA_TARIF"
                Dim oFrmCari As New frmCari("Cari Tarif", sSql, "fs_nm_tarif", "Nama Tarif", "", "")
                oFrmCari.ShowDialog()
                If oFrmCari.Kode <> "" Then
                    txtKdTarif.Text = oFrmCari.Kode
                    oHp.SendTab()
                End If
            Case Keys.Enter
                oHp.SendTab()
        End Select
    End Sub

    Private Sub Fill()
        oTarif.vKode = Trim(txtKdTarif.Text)
        txtNmTarif.Text = oTarif.NmTarif
        oTarif.Kode = txtKdTarif.Text
        With oTarif.KompByTarifDS.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                GridKomp.Rows.Add(.Rows(i)("fs_kd_komponen"), .Rows(i)("fs_nm_komponen"), .Rows(i)("fn_nilai"))
            Next
        End With

        With oTarif.JenisUjiByTarifDS.Tables(0)
            For j As Integer = 0 To .Rows.Count - 1
                GridUji.Rows.Add(.Rows(j)("fs_kd_jenis_uji"), .Rows(j)("fs_nm_jenis_uji"))
            Next
        End With
    End Sub

    Private Sub ClrScr()
        GridKomp.Rows.Clear()
        GridUji.Rows.Clear()
        txtNmTarif.Clear()
    End Sub

    Private Sub txtKdTarif_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdTarif.Validating
        oHp.SendTab()
        ClrScr()
        If oTarif.isExist(txtKdTarif.Text) Then
            Fill()
        End If
    End Sub

    Private Sub GridKomp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridKomp.KeyDown
        Dim i As Integer = GridKomp.CurrentRow.Index
        Dim col As Integer = GridKomp.CurrentCell.ColumnIndex
        Select Case e.KeyCode
            Case Keys.F12
                If col = 0 Then
                    Dim sSql As String
                    sSql = "SELECT * FROM TA_KOMPONEN "
                    Dim oFrmCari As New frmCari("Cari Jenis Uji", sSql, "fs_nm_komponen", "Komponen", "", "")
                    oFrmCari.ShowDialog()
                    GridKomp.Item(col, i).Value = oFrmCari.Kode
                    oHp.SendTab()
                End If
        End Select
    End Sub

    Private Sub GridKomp_Validating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles GridKomp.CellValidating
        Dim i As Integer = GridKomp.CurrentRow.Index
        Dim col As Integer = GridKomp.CurrentCell.ColumnIndex
        If GridKomp.Item(0, i).Value <> "" Then
            oTarif.vKodeKomp = GridKomp.Item(0, i).Value
            GridKomp.Item(1, i).Value = oTarif.NmKomponen
        End If
    End Sub

    Private Sub GridUji_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles GridUji.CellValidating
        Dim i As Integer = GridUji.CurrentRow.Index
        Dim col As Integer = GridUji.CurrentCell.ColumnIndex
        If GridUji.Item(0, i).Value <> "" Then
            oTarif.vKodeUji = GridUji.Item(0, i).Value
            GridUji.Item(1, i).Value = oTarif.NmUji
        End If
    End Sub

    Private Sub GridUji_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridUji.KeyDown
        Dim i As Integer = GridUji.CurrentRow.Index
        Dim col As Integer = GridUji.CurrentCell.ColumnIndex
        If e.KeyCode = Keys.F12 And col = 0 Then
            Dim sSql As String
            sSql = "SELECT  fs_kd_jenis_uji , " & vbCrLf _
                 & "        fs_nm_jenis_uji , " & vbCrLf _
                 & "        ISNULL(bb.fs_nm_grup_jenis_uji, '') AS fs_nm_grup_jenis_uji " & vbCrLf _
                 & "FROM    TA_JENIS_UJI aa " & vbCrLf _
                 & "LEFT JOIN TA_GRUP_JENIS_UJI bb ON aa.fs_kd_grup_jenis_uji = bb.fs_kd_grup_jenis_uji "
            Dim oFrmcari As New frmCari("Cari Jenis Uji", sSql, "fs_nm_jenis_uji", "Pengujian", "Grup uji", "")
            oFrmcari.grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            oFrmcari.grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            oFrmcari.ShowDialog()
            'GridUji.Item(col, i).Value = oFrmcari.Kode
            oTarif.vKodeUji = oFrmcari.Kode
            oHp.SendTab()
            If GridUji.Item(col, i).Value = "" Then
                GridUji.Rows.Add(oFrmcari.Kode, oTarif.NmUji)
            Else
                GridUji.Item(col, i).Value = oTarif.KdUji
                GridUji.Item(1, i).Value = oTarif.NmUji
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        oTarif.Kode = Trim(txtKdTarif.Text)
        oTarif.NmTarif = txtNmTarif.Text
        If Trim(txtKdTarif.Text) <> "" Then
            If oTarif.isExist(txtKdTarif.Text) Then
                oTarif.UpdateTarif()
                oTarif.DeleteKompByTarif()
                oTarif.DeleteUjiByTarif()
            Else
                oTarif.InsertTarif()
            End If

            ' insert Komponen
            For i As Integer = 0 To GridKomp.Rows.Count - 1
                If GridKomp.Item(0, i).Value <> "" Then
                    oTarif.KdKomponen = GridKomp.Item(0, i).Value
                    oTarif.NilaiKomponen = GridKomp.Item(2, i).Value
                    oTarif.Urut = i + 1
                    oTarif.InsertTarifKomp()
                End If
            Next

            ' Insert Uji
            For i As Integer = 0 To GridUji.Rows.Count - 1
                If GridUji.Item(0, i).Value <> "" Then
                    oTarif.KdUji = GridUji.Item(0, i).Value
                    oTarif.Urut = i + 1
                    oTarif.InsertTarifUji()
                End If
            Next
            MsgBox("Tarif berhasil disimpan", MsgBoxStyle.Information)
            ClrScr()
            txtKdTarif.Clear()
        Else
            MsgBox("Kode tarif kosong", MsgBoxStyle.Exclamation)
            txtKdTarif.Focus()
            txtKdTarif.Border.BorderColor = Color.Red
        End If
    End Sub
End Class