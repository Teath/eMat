Public Class TKValik

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Var1.tkVtArv > 0 Then
            Dim oForm As TKPohi
            oForm = New TKPohi()
            oForm.Show()
            oForm = Nothing
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

    Private Sub TKValik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tkVtArv = 0
        tkVArv = 1
        tkAjaLim = False
        tkAegMin = 1
        tkAegSek = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Var1.tkVt1 = CheckBox1.Checked
        If Var1.tkVt1 = True Then
            Var1.tkVtArv = Var1.tkVtArv + 1
        Else
            Var1.tkVtArv = Var1.tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Var1.tkVt2 = CheckBox2.Checked
        If Var1.tkVt2 = True Then
            Var1.tkVtArv = Var1.tkVtArv + 1
        Else
            Var1.tkVtArv = Var1.tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Var1.tkVt3 = CheckBox3.Checked
        If Var1.tkVt3 = True Then
            Var1.tkVtArv = Var1.tkVtArv + 1
        Else
            Var1.tkVtArv = Var1.tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Var1.tkVt4 = CheckBox4.Checked
        If Var1.tkVt4 = True Then
            Var1.tkVtArv = Var1.tkVtArv + 1
        Else
            Var1.tkVtArv = Var1.tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Var1.tkVt5 = CheckBox5.Checked
        If Var1.tkVt5 = True Then
            Var1.tkVtArv = Var1.tkVtArv + 1
        Else
            Var1.tkVtArv = Var1.tkVtArv - 1
        End If
    End Sub


    Private Sub AegVal_ValueChanged(sender As Object, e As EventArgs) Handles AegVal.ValueChanged
        If AegVal.Value > 1 Then
            minut.Text = "minutit"
        Else
            minut.Text = "minut"
        End If
        tkAegMin = AegVal.Value
    End Sub

    Private Sub AegPiirm_CheckedChanged(sender As Object, e As EventArgs) Handles AegPiirm.CheckedChanged
        If AegPiirm.Checked = True Then
            tkAjaLim = False
        Else
            tkAjaLim = True
        End If
    End Sub

    Private Sub AegPiird_CheckedChanged(sender As Object, e As EventArgs) Handles AegPiird.CheckedChanged
        If AegPiird.Checked = True Then
            tkAjaLim = True
            AegVal.Enabled = True
        Else
            tkAjaLim = False
            AegVal.Enabled = False
        End If
    End Sub

    Private Sub vArvVal_ValueChanged(sender As Object, e As EventArgs) Handles vArvVal.ValueChanged
        tkVArv = vArvVal.Value
    End Sub
End Class