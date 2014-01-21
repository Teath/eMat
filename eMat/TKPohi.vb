Imports eMat.Var1

Public Class TKPohi

    Private Function updateStats()
        Label5.Text = tkOige
        Label7.Text = tkVale
    End Function

    Public Function genType1()
        Randomize()
        Dim x1 As Integer = CInt(Int((5 * Rnd()) + 2))
        Dim x2 As Decimal
        Dim ran1 As Integer = CInt(Int((10 * Rnd()) + 2))
        Dim ran2 As Integer = CInt(Int((10 * Rnd()) + 2))
        Dim ran3 As Integer = CInt(Int((30 * Rnd()) + 2))
        Dim rls As Integer = (ran1 * x1 ^ 2 + ran2 * x1 - ran3) * (-1)
        If rls > 0 Then
            Label2.Text = ran1.ToString() + "x² + " + ran2.ToString() + "x + " + rls.ToString() + " = " + ran3.ToString()
        Else
            Label2.Text = ran1.ToString() + "x² + " + ran2.ToString + "x - " + (rls * -1).ToString() + " = " + ran3.ToString()
        End If
        x2 = (-ran2 - Math.Sqrt(ran2 ^ 2 - 4 * ran1 * (rls - ran3))) / (2 * ran1)
        Label23.Text = x1.ToString + ", " + (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
        vx1 = x1.ToString
        vx2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
    End Function

    Public Function genType2()
        Randomize()
        Dim x1 As Integer = CInt(Int((5 * Rnd()) + 2))
        Dim x2 As Decimal
        Dim ran1 As Integer = CInt(Int((10 * Rnd()) + 2))
        Dim ran2 As Integer = CInt(Int((10 * Rnd()) + 2))
        Dim rls As Integer = (ran1 * x1 ^ 2 + ran2 * x1) * (-1)
        If rls > 0 Then
            Label2.Text = ran1.ToString() + "x² + " + ran2.ToString() + "x + " + rls.ToString() + " = 0"
        Else
            Label2.Text = ran1.ToString() + "x² + " + ran2.ToString + "x - " + (rls * -1).ToString() + " = 0"
        End If
        x2 = (-ran2 - Math.Sqrt(ran2 ^ 2 - 4 * ran1 * rls)) / (2 * ran1)
        Label23.Text = x1.ToString + ", " + (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
        vx1 = x1.ToString
        vx2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
    End Function

    Public Function genType3()
        Randomize()
        Dim x1 As Integer = CInt(Int((7 * Rnd()) + 2))
        Dim x2 As Decimal
        Dim ran2 As Integer = CInt(Int((50 * Rnd()) + 2))
        Dim rls As Integer = (x1 ^ 2 + ran2 * x1) * (-1)
        If rls > 0 Then
            Label2.Text = "x² + " + ran2.ToString() + "x + " + rls.ToString() + " = 0"
        Else
            Label2.Text = "x² + " + ran2.ToString + "x - " + (rls * -1).ToString() + " = 0"
        End If
        x2 = (-ran2 - Math.Sqrt(ran2 ^ 2 - 4 * rls)) / 2
        Label23.Text = x1.ToString + ", " + (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
        vx1 = x1.ToString
        vx2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
    End Function

    Public Function genType4()
        Randomize()
        Dim x1 As Decimal
        Dim x2 As Decimal
        Dim ran1 As Integer = CInt(Int((40 * Rnd()) + 2))
        Dim ran2 As Integer = CInt(Int((40 * Rnd()) + 2))
        Label2.Text = ran1.ToString() + "x² - " + ran2.ToString() + "x = 0"
        x1 = ran2 / ran1
        x2 = 0
        Label23.Text = (Math.Round(x1, 3, MidpointRounding.AwayFromZero)).ToString + ", " + (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
        vx1 = (Math.Round(x1, 3, MidpointRounding.AwayFromZero)).ToString
        vx2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
    End Function

    Public Function genType5()
        Randomize()
        Dim x1 As Decimal
        Dim x2 As Decimal
        Dim ran1 As Integer = CInt(Int((12 * Rnd()) + 2)) ' a
        Dim ran2 As Integer = CInt(Int((14 * Rnd()) + 2)) ' x
        Dim c As Integer = ran1 * ran2 ^ 2
        Label2.Text = ran1.ToString() + "x² - " + c.ToString() + " = 0"
        x1 = ran2
        x2 = -ran2
        Label23.Text = x1.ToString + ", " + x2.ToString
        vx1 = x1.ToString
        vx2 = x2.ToString
    End Function

    Public Function genHandler()
        Randomize()
        Dim genNum As Integer = CInt(Int((5 * Rnd()) + 1))
        If genNum = 1 And tkVt1 = True Then
            genType1()
        ElseIf genNum = 2 And tkVt2 = True Then
            genType2()
        ElseIf genNum = 3 And tkVt3 = True Then
            genType3()
        ElseIf genNum = 4 And tkVt4 = True Then
            genType4()
        ElseIf genNum = 5 And tkVt5 = True Then
            genType5()
        Else
            Threading.Thread.Sleep(10)
            genHandler()
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button1.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        If tkAjaLim Then
            Timer1.Enabled = True
        End If
        tkVArv = tkVArv - 1
        LblVJ.Text = tkVArv
        If tkVArv = 0 Then
            Button1.Text = "Valmis"
        End If
        genHandler()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tkVArv = tkVArv - 1
        If tkVArv = 0 Then
            Button1.Text = "Valmis"
        End If
        Label15.Text = vx1
        Label17.Text = vx2
        Label21.Text = TextBox1.Text
        Label22.Text = TextBox2.Text
        Label25.Text = Label2.Text
        If TextBox1.Text = vx1 And TextBox2.Text = vx2 Then
            tkOige = tkOige + 1
        ElseIf TextBox1.Text = vx2 And TextBox2.Text = vx1 Then
            tkOige = tkOige + 1
        ElseIf TextBox1.Text = "debug on" Then
            Label23.Visible = True
            Label21.Text = ""
            Label22.Text = ""
            Label25.Text = ""
        ElseIf TextBox1.Text = "debug off" Then
            Label23.Visible = False
            Label21.Text = ""
            Label22.Text = ""
            Label25.Text = ""
        ElseIf TextBox1.Text = "win" Then
            tkOige = tkOige + 5
            Label21.Text = vx1
            Label22.Text = vx2
        ElseIf TextBox1.Text = "boo" Then
            tkVale = tkVale + 5
            Label21.Text = ""
            Label22.Text = ""
            Label25.Text = ""
        Else
            tkVale = tkVale + 1
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        updateStats()
        If tkVArv >= 0 Then
            genHandler()
        End If
        If tkVArv < 0 Then
            tkVArv = 0
            finish()
        End If
        LblVJ.Text = tkVArv
    End Sub

    Private Sub TKPohi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tkEelVas = False Then
            Label24.Visible = False
            Label25.Visible = False
            Label12.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label30.Visible = False
            Label31.Visible = False
        End If
        If tkCanc = True Then
            Button2.Enabled = True
        End If
        If tkAegMin < 10 Then
            LblAegMin.Text = "0" & tkAegMin
        Else
            LblAegMin.Text = tkAegMin
        End If
        If tkAjaLim = False Then
            LblAegMin.Text = "--"
            LblAegSek.Text = "--"
        End If
        LblVJ.Text = tkVArv
        updateStats()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm As TKValik
        oForm = New TKValik()
        oForm.Show()
        oForm = Nothing
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Label15.Text = vx1
        Label17.Text = vx2
        Label21.Text = ""
        Label22.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label25.Text = Label2.Text
        genHandler()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        vx1 = ""
        vx2 = ""
        Dim oForm4 As Form4
        oForm4 = New Form4()
        oForm4.Show()
        oForm4 = Nothing
    End Sub

    Private Function finish()
        Button1.Enabled = False
        Timer1.Enabled = False
        MsgBox("Tulemus: " & Math.Round((tkOige / (tkOige + tkVale + tkVArv) * 100), 1, MidpointRounding.AwayFromZero).ToString & "%")
        Button2.Enabled = True
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tkAegMin > 0 Then
            If tkAegSek > 0 Then
                tkAegSek = tkAegSek - 1
            Else
                tkAegSek = 59
                tkAegMin = tkAegMin - 1
            End If
        Else
            If tkAegSek > 0 Then
                tkAegSek = tkAegSek - 1
            Else
                finish()
            End If
        End If
        If tkAegMin < 10 Then
            LblAegMin.Text = "0" & tkAegMin
        Else
            LblAegMin.Text = tkAegMin
        End If
        If tkAegSek < 10 Then
            LblAegSek.Text = "0" & tkAegSek
        Else
            LblAegSek.Text = tkAegSek
        End If
        If tkAegMin = 0 And tkAegSek < 30 Then
            LblAegMin.ForeColor = Color.Red
            LblAegSek.ForeColor = Color.Red
        End If
    End Sub
End Class
