Public Class frmParamSystem
    Dim oParam As New clsParamSystem

    Private Sub frmParamSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNmDirektur.Text = oParam.NmDirektur
        txtNipDirektur.Text = oParam.NipDirektur
    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class