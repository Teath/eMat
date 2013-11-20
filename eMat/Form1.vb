Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm2 As Form2
        oForm2 = New Form2()
        oForm2.Show()
        oForm2 = Nothing
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm2 As Seaded
        oForm2 = New Seaded()
        oForm2.Show()
        oForm2 = Nothing
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim oForm2 As Info
        oForm2 = New Info()
        oForm2.Show()
        oForm2 = Nothing
    End Sub
End Class
