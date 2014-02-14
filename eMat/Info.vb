Public Class Info

    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = version
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class