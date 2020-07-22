Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strMasukanUser As String
        Dim dblNilai As Double
        strMasukanUser = InputBox("Masukkan sebuah nilai.", "Silahkan Merespon")
        dblNilai = CDbl(strMasukanUser)
    End Sub
End Class