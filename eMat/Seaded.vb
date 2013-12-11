Public Class Seaded

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As Form1
        oForm = New Form1()
        oForm.Show()
        oForm = Nothing
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Var1.s_skip = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Var1.s_showAnswer = CheckBox2.Checked
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Var1.s_stats = CheckBox3.Checked
    End Sub

    Private Sub Seaded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = Var1.s_skip
        CheckBox2.Checked = Var1.s_showAnswer
        CheckBox3.Checked = Var1.s_stats
    End Sub
End Class