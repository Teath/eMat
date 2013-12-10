Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Var1.vtArv > 0 Then
            Dim oForm3 As Form3
            oForm3 = New Form3()
            oForm3.Show()
            oForm3 = Nothing
            Me.Close()
        Else
            MsgBox("Vali vähemalt üks võrranditüüp!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm As Form1
        oForm = New Form1()
        oForm.Show()
        oForm = Nothing
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Var1.vtArv = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Var1.vt1 = CheckBox1.Checked
        If Var1.vt1 = True Then
            Var1.vtArv = Var1.vtArv + 1
        Else
            Var1.vtArv = Var1.vtArv - 1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Var1.vt2 = CheckBox2.Checked
        If Var1.vt2 = True Then
            Var1.vtArv = Var1.vtArv + 1
        Else
            Var1.vtArv = Var1.vtArv - 1
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Var1.vt3 = CheckBox3.Checked
        If Var1.vt3 = True Then
            Var1.vtArv = Var1.vtArv + 1
        Else
            Var1.vtArv = Var1.vtArv - 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Var1.vt4 = CheckBox4.Checked
        If Var1.vt4 = True Then
            Var1.vtArv = Var1.vtArv + 1
        Else
            Var1.vtArv = Var1.vtArv - 1
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Var1.vt5 = CheckBox5.Checked
        If Var1.vt5 = True Then
            Var1.vtArv = Var1.vtArv + 1
        Else
            Var1.vtArv = Var1.vtArv - 1
        End If
    End Sub
End Class