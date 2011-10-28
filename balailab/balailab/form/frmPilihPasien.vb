Public Class frmPilihPasien
    Dim oFrmCariTarif As New frmCariTarif
    Dim oTarif As New clsTarif
    Dim oReg As New clsTrsRegistrasi
    Dim oTrs As New clsTrsUji
    Public Qty As Integer

    Private Sub frmPilihPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oTarif.vKode = My.Settings.tmpKdTarif
        oReg.Kode = My.Settings.tmpKdReg
        txtKdTarif.Text = My.Settings.tmpKdTarif
        txtNmTarif.Text = oTarif.NmTarif

        Dim lvi As New ListViewItem
        Dim oMR As New clsMR

        With oReg.SampleDS.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                lvi = New ListViewItem
                oMR.vKode = .Rows(i)("fs_mr")
                lvi.Text = .Rows(i)("fs_kd_sample")
                lvi.SubItems.Add(oMR.xNama)
                lvi.SubItems.Add(.Rows(i)("fs_nm_jenis_sample"))
                lstSample.Items.Add(lvi)
                lstSample.Items(i).Checked = True
            Next
        End With

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Settings.tmpQtySample = lstSample.CheckedItems.Count
        oTrs.KdReg = My.Settings.tmpKdReg
        oTrs.KdTarif = txtKdTarif.Text

        oTrs.DeleteUji4() ' Bersih-bersih dulu data lama

        For i As Integer = 0 To lstSample.CheckedItems.Count - 1
            oTrs.KdSample = lstSample.CheckedItems.Item(i).Text
            oTrs.InsertUji4()
        Next

        Me.Close()
    End Sub

    Private Sub lstSample_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstSample.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                If lstSample.Items(0).Checked Then
                    For i As Integer = 0 To lstSample.Items.Count - 1
                        lstSample.Items(i).Checked = False
                    Next
                Else
                    For i As Integer = 0 To lstSample.Items.Count - 1
                        lstSample.Items(i).Checked = True
                    Next
                End If
        End Select
    End Sub
End Class