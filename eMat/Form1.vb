Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm2 As Form2
        oForm2 = New Form2()
        oForm2.Show()
        oForm2 = Nothing
        Me.Close()
    End Sub
End Class
