Public Class TKValik

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tkVtArv > 0 Then
            Dim oForm3 As TKPohi
            oForm3 = New TKPohi()
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

    Private Sub TKValik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tkVtArv = 0
        tkVt1 = False
        tkVt2 = False
        tkVt3 = False
        tkVt4 = False
        tkVt5 = False
        tkOige = 0
        tkVale = 0
        tkVArv = 1
        tkAjaLim = False
        tkAegMin = 1
        tkAegSek = 0
        tkCanc = False
        tkEelVas = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        tkVt1 = CheckBox1.Checked
        If tkVt1 = True Then
            tkVtArv = tkVtArv + 1
        Else
            tkVtArv = tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        tkVt2 = CheckBox2.Checked
        If tkVt2 = True Then
            tkVtArv = tkVtArv + 1
        Else
            tkVtArv = tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        tkVt3 = CheckBox3.Checked
        If tkVt3 = True Then
            tkVtArv = tkVtArv + 1
        Else
            tkVtArv = tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        tkVt4 = CheckBox4.Checked
        If tkVt4 = True Then
            tkVtArv = tkVtArv + 1
        Else
            tkVtArv = tkVtArv - 1
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        tkVt5 = CheckBox5.Checked
        If tkVt5 = True Then
            tkVtArv = tkVtArv + 1
        Else
            tkVtArv = tkVtArv - 1
        End If
    End Sub

    Private Sub VArvNum_ValueChanged(sender As Object, e As EventArgs) Handles VArvNum.ValueChanged
        tkVArv = VArvNum.Value
    End Sub

    Private Sub AjaLimOff_CheckedChanged(sender As Object, e As EventArgs) Handles AjaLimOff.CheckedChanged
        If AjaLimOff.Checked Then
            tkAjaLim = False
        Else
            tkAjaLim = True
        End If
    End Sub

    Private Sub AjaLimOn_CheckedChanged(sender As Object, e As EventArgs) Handles AjaLimOn.CheckedChanged
        tkAjaLim = AjaLimOn.Checked
        AjaLimNum.Enabled = AjaLimOn.Checked
    End Sub

    Private Sub AjaLimNum_ValueChanged(sender As Object, e As EventArgs) Handles AjaLimNum.ValueChanged
        tkAegMin = AjaLimNum.Value
        If AjaLimNum.Value > 1 Then
            LblMinut.Text = "minutit"
        Else
            LblMinut.Text = "minut"
        End If
    End Sub

    Private Sub CancOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles CancOnOff.CheckedChanged
        tkCanc = CancOnOff.Checked
    End Sub

    Private Sub EelVasOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles EelVasOnOff.CheckedChanged
        tkEelVas = EelVasOnOff.Checked
    End Sub
End Class