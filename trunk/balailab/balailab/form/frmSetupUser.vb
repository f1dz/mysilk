Public Class frmSetupUser
    Dim oHp As New clsHelper
    Dim oInst As New clsInstalasi
    Dim oParam As New clsParam
    Dim oUser As New clsUser


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        If (Strings.Trim(Me.txtPassword1.Text) <> Strings.Trim(Me.txtPassword2.Text)) Then
            Interaction.MsgBox("Pasword tidak sama", MsgBoxStyle.Exclamation, Nothing)
        ElseIf (Strings.Trim(Me.txtKdPetugas.Text) <> "") Then
            Me.oUser.User = Me.txtKdPetugas.Text
            Me.oUser.NmUser = Me.txtNmPetugas.Text
            Me.oUser.KdInstalasi = Me.txtKdInstalasi.Text
            Me.oUser.Nip = Me.txtNIP.Text
            Me.oUser.Password = Me.txtPassword1.Text
            Me.oUser.Aktif = Me.CbAktif.CheckValue
            Me.oUser.Update()
            Me.oUser.DeleteAkses()
            For i As Integer = 0 To grid.Rows.Count - 1
                If grid.Item(3, i).Value = 1 Or grid.Item(3, i).Value Then
                    oUser.xMenu = grid.Item(0, i).Value
                    oUser.InsertAkses()
                End If
            Next

            Me.ClrScr()
            Me.txtKdPetugas.Clear()
            Interaction.MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, Nothing)
        End If
    End Sub

    Private Sub CariInstalasi()
        Dim sSQL As String = "SELECT fs_kd_instalasi,fs_nm_instalasi FROM TA_INSTALASI "
        Dim oFrmCari As New frmCari("Cari Instalasi", sSQL, "fs_nm_Instalasi", "Instalasi", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdInstalasi.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub CariUser()
        Dim sSQL As String = "SELECT fs_kd_user,fs_nm_user FROM TZ_USER "
        Dim oFrmCari As New frmCari("Cari User", sSQL, "fs_nm_user", "Nama Petugas", "", "")
        oFrmCari.ShowDialog()
        Me.txtKdPetugas.Text = oFrmCari.Kode
        Me.oHp.SendTab()
    End Sub

    Private Sub ClrScr()
        Me.txtNmPetugas.Clear()
        Me.txtNIP.Clear()
        Me.txtKdInstalasi.Clear()
        Me.txtNmInstalasi.Clear()
        Me.txtPassword2.Clear()
        Me.txtPassword1.Clear()
        Me.grid.Rows.Clear()
    End Sub

    Private Sub FillGrid()
        oUser.User = txtKdPetugas.Text
        For Each ctrl As DevComponents.DotNetBar.ButtonItem In frmMain.RibbonBarFO.Items
            grid.Rows.Add(ctrl.Name, frmMain.RibbonBarFO.Text, ctrl.Text, oUser.Akses(ctrl.Name))
        Next

        For Each ctrl As DevComponents.DotNetBar.ButtonItem In frmMain.RibbonBarBO.Items
            grid.Rows.Add(ctrl.Name, frmMain.RibbonBarBO.Text, ctrl.Text, oUser.Akses(ctrl.Name))
        Next

        For Each ctrl As DevComponents.DotNetBar.ButtonItem In frmMain.RibbonBarLaporan.Items
            grid.Rows.Add(ctrl.Name, frmMain.RibbonBarLaporan.Text, ctrl.Text, oUser.Akses(ctrl.Name))
        Next

        ' Master
        For Each ctrl As DevComponents.DotNetBar.ButtonItem In frmMain.RbnSetupMaster.Items
            grid.Rows.Add(ctrl.Name, frmMain.RbnSetupMaster.Text, ctrl.Text, oUser.Akses(ctrl.Name))
        Next

        ' Master
        For Each ctrl As DevComponents.DotNetBar.ButtonItem In frmMain.RbnControlPanel.Items
            grid.Rows.Add(ctrl.Name, frmMain.RbnControlPanel.Text, ctrl.Text, oUser.Akses(ctrl.Name))
        Next
    End Sub

    ' Cell Paint
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If ((e.ColumnIndex = 1) AndAlso (e.RowIndex <> -1)) Then
            Using gridBrush As Brush = New SolidBrush(Me.grid.GridColor)
                Using backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
                    Using gridLinePen As Pen = New Pen(gridBrush)
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
                        If ((e.RowIndex < (Me.grid.Rows.Count - 2)) AndAlso (Me.grid.Rows.Item((e.RowIndex + 1)).Cells.Item(e.ColumnIndex).Value.ToString <> e.Value.ToString)) Then
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, (e.CellBounds.Bottom - 1), (e.CellBounds.Right - 1), (e.CellBounds.Bottom - 1))
                        End If
                        e.Graphics.DrawLine(gridLinePen, (e.CellBounds.Right - 1), e.CellBounds.Top, (e.CellBounds.Right - 1), e.CellBounds.Bottom)
                        If ((Not e.Value Is Nothing) AndAlso (If(((e.RowIndex > 0) AndAlso (Me.grid.Rows.Item((e.RowIndex - 1)).Cells.Item(e.ColumnIndex).Value.ToString = e.Value.ToString)), 1, 0) = 0)) Then
                            e.Graphics.DrawString(Convert.ToString(e.Value), e.CellStyle.Font, Brushes.Black, CSng((e.CellBounds.X + 2)), CSng((e.CellBounds.Y + 5)), StringFormat.GenericDefault)
                        End If
                        e.Handled = True
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub txtKdInstalasi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdInstalasi.Validating
        If (Me.txtKdInstalasi.Text <> "") Then
            Me.oInst.vKodeInst = Me.txtKdInstalasi.Text
            Me.txtNmInstalasi.Text = Me.oInst.NamaInst
        Else
            Me.txtNmInstalasi.Clear()
        End If
    End Sub

    Private Sub txtKdPetugas_ButtonCustomClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtKdPetugas.ButtonCustomClick
        If sender.Name = "txtKdPetugas" Then
            Me.CariUser()
        ElseIf sender.Name = "txtKdInstalasi" Then
            Me.CariInstalasi()
        End If
    End Sub

    Private Sub txtKdPetugas_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKdPetugas.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                If sender.Name = "txtKdPetugas" Then
                    Me.CariUser()
                ElseIf sender.Name = "txtKdInstalasi" Then
                    Me.CariInstalasi()
                End If
                Exit Select
            Case Keys.Return
                Me.oHp.SendTab()
                Exit Select
        End Select
    End Sub

    Private Sub txtKdPetugas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKdPetugas.Validating
        If ((Strings.Trim(Me.txtKdPetugas.Text) <> "") And Me.oUser.isExist(Strings.Trim(Me.txtKdPetugas.Text))) Then
            Me.ClrScr()
            Me.oUser.vKode = Me.txtKdPetugas.Text
            Me.txtNmPetugas.Text = Me.oUser.NmUser
            Me.txtNIP.Text = Me.oUser.Nip
            Me.txtKdInstalasi.Text = Me.oUser.KdInstalasi
            Me.oInst.vKodeInst = Me.oUser.KdInstalasi
            Me.txtNmInstalasi.Text = Me.oInst.NamaInst
            Me.txtPassword1.Text = Me.oUser.Password
            Me.txtPassword2.Text = Me.oUser.Password
            Me.CbAktif.Checked = Me.oUser.Aktif
            Me.FillGrid()
        ElseIf (Strings.Trim(Me.txtKdPetugas.Text) <> "") Then
            Me.ClrScr()
        Else
            Me.ClrScr()
            Me.txtKdPetugas.Clear()
        End If
    End Sub

End Class