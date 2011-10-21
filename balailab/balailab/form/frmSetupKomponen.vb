Public Class frmSetupKomponen
    Dim oTarif As New clsTarif

    Private Sub frmSetupKomponen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub

    Private Sub FillGrid()
        With oTarif.KompDS.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                GridKomp.Rows.Add(.Rows(i)("fs_kd_komponen"), .Rows(i)("fs_nm_komponen"))
            Next
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtKdKomp.Text) <> "" And Trim(txtNmKomp.Text) <> "" Then
            oTarif.KdKomponen = txtKdKomp.Text
            oTarif.NmKomponen = txtNmKomp.Text
            If oTarif.isExistKomponen(txtKdKomp.Text) Then
                oTarif.UpdateKomponen()
                MsgBox("Komponen tarif berhasil di edit", MsgBoxStyle.Information)
            Else
                oTarif.InsertKomponen()
                MsgBox("Komponen tarif berhasil dimasukkan", MsgBoxStyle.Information)
            End If
            txtKdKomp.Clear()
            txtNmKomp.Clear()
            GridKomp.Rows.Clear()
            FillGrid()
        Else
            MsgBox("Kode dan/atau Nama komponen kosong", MsgBoxStyle.Exclamation)
            txtKdKomp.Focus()
        End If
    End Sub

    Private Sub GridKomp_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridKomp.CellDoubleClick
        Dim r As Integer = GridKomp.CurrentRow.Index
        txtKdKomp.Text = GridKomp.Item(0, r).Value
        txtNmKomp.Text = GridKomp.Item(1, r).Value
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Hapus komponen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If oTarif.isUsedKomponen(Trim(txtKdKomp.Text)) Then
                MsgBox("Komponen masih dipakai di setup tarif" & vbCrLf & "Proses hapus dibatalkan", MsgBoxStyle.Exclamation)
            Else
                oTarif.KdKomponen = txtKdKomp.Text
                oTarif.DeleteKomponen()
            End If
            GridKomp.Rows.Clear()
            FillGrid()
            txtKdKomp.Clear()
            txtNmKomp.Clear()
        End If
    End Sub
End Class