Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex > 0 And ListBox1.SelectedIndex < 7 Then
            Var1.vTyyp = ListBox1.SelectedIndex
            Dim oForm3 As Form3
            oForm3 = New Form3()
            oForm3.Show()
            oForm3 = Nothing
            Me.Close()
        End If
    End Sub
End Class