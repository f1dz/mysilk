

Partial Public Class ctkDataset
    Partial Class ctkFPPSampleDataTable

        Private Sub ctkFPPSampleDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.fs_kd_regColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
