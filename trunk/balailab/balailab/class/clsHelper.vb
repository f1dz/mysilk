Public Class clsHelper
    Public Sub SendTab()
        SendKeys.Send("{TAB}")
    End Sub

    Public Sub curDateDP()
        'Return Today.TimeOfDay
    End Sub

    Public Function crypt(ByVal text As String)
        Dim str As String
        Dim i As Integer
        str = Nothing
        For i = 1 To Len(text)
            If Asc(Mid$(text, i, 1)) < 128 Then
                str = CType(Asc(Mid$(text, i, 1)) + 128, String)
            ElseIf Asc(Mid$(text, i, 1)) > 128 Then
                str = CType(Asc(Mid$(text, i, 1)) - 128, String)
            End If
            Mid$(text, i, 1) = Chr(CType(str, Integer))
        Next i
        Return text
    End Function

    Function AngkaToHuruf(ByVal n As Double) As String
        Dim satuan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima", _
        "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}

        Select Case n
            Case 0 To 11
                AngkaToHuruf = " " + satuan(Fix(n))
            Case 12 To 19
                AngkaToHuruf = AngkaToHuruf(n Mod 10) + " Belas"
            Case 20 To 99
                AngkaToHuruf = AngkaToHuruf(Fix(n / 10)) + " Puluh" + _
                AngkaToHuruf(n Mod 10)
            Case 100 To 199
                AngkaToHuruf = " Seratus" + AngkaToHuruf(n - 100)
            Case 200 To 999
                AngkaToHuruf = AngkaToHuruf(Fix(n / 100)) + " Ratus" + _
                AngkaToHuruf(n Mod 100)
            Case 1000 To 1999
                AngkaToHuruf = " Seribu" + AngkaToHuruf(n - 1000)
            Case 2000 To 999999
                AngkaToHuruf = AngkaToHuruf(Fix(n / 1000)) + " Ribu" + _
                AngkaToHuruf(n Mod 1000)
            Case 1000000 To 999999999
                AngkaToHuruf = AngkaToHuruf(Fix(n / 1000000)) + " Juta" + _
                AngkaToHuruf(n Mod 1000000)
            Case 1000000000 To 999999999999
                AngkaToHuruf = AngkaToHuruf(Fix(n / 1000000000)) + " Milyar" + _
                AngkaToHuruf(n Mod 1000000000)
            Case Else
                AngkaToHuruf = AngkaToHuruf(Fix(n / 1000000000000)) + " Trilyun" + _
                AngkaToHuruf(n Mod 1000000000000)
        End Select
    End Function
End Class
