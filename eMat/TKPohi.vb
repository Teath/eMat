Imports eMat.Var1

Public Class TKPohi

    Private Function updateStats()
        Label5.Text = Var1.tkOige
        Label7.Text = Var1.tkVale
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
        Var1.x1 = x1.ToString
        Var1.x2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
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
        Var1.x1 = x1.ToString
        Var1.x2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
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
        Var1.x1 = x1.ToString
        Var1.x2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
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
        Var1.x1 = (Math.Round(x1, 3, MidpointRounding.AwayFromZero)).ToString
        Var1.x2 = (Math.Round(x2, 3, MidpointRounding.AwayFromZero)).ToString
    End Function

    Public Function genType5()
        Randomize()
        Dim x1 As Integer
        Dim x2 As Integer
        Dim ran1 As Integer = CInt(Int((12 * Rnd()) + 2)) ' a
        Dim ran2 As Integer = CInt(Int((14 * Rnd()) + 2)) ' x
        Dim c As Integer = ran1 * ran2 ^ 2
        Label2.Text = ran1.ToString() + "x² - " + c.ToString() + " = 0"
        x1 = ran2
        x2 = -ran2
        Label23.Text = x1.ToString + ", " + x2.ToString
        Var1.x1 = x1.ToString
        Var1.x2 = x2.ToString
    End Function

    Public Function genHandler()
        Randomize()
        Dim genNum As Integer = CInt(Int((4 * Rnd()) + 1))
        If genNum = 1 And Var1.tkVt1 = True Then
            genType1()
        ElseIf genNum = 2 And Var1.tkVt2 = True Then
            genType2()
        ElseIf genNum = 3 And Var1.tkVt3 = True Then
            genType3()
        ElseIf genNum = 4 And Var1.tkVt4 = True Then
            genType4()
        ElseIf genNum = 5 And Var1.tkVt5 = True Then
            genType5()
        Else
            genHandler()
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button1.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Timer1.Enabled = True
        genHandler()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tkVArv = tkVArv - 1
        If tkVArv = 0 Then
            Button1.Text = "Valmis"
        End If
        If TextBox1.Text = Var1.x1 And TextBox2.Text = Var1.x2 Then
            Var1.tkOige = Var1.tkOige + 1
        ElseIf TextBox1.Text = Var1.x2 And TextBox2.Text = Var1.x1 Then
            Var1.tkOige = Var1.tkOige + 1
        ElseIf TextBox1.Text = "debug on" Then
            Label23.Visible = True
        ElseIf TextBox1.Text = "debug off" Then
            Label23.Visible = False
        ElseIf TextBox1.Text = "win" Then
            Var1.tkOige = Var1.tkOige + 5
        ElseIf TextBox1.Text = "boo" Then
            Var1.tkVale = Var1.tkVale + 5
        Else
            Var1.tkVale = Var1.tkVale + 1
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        updateStats()
        If tkVArv < 0 Then
            finish()
        Else
            genHandler()
        End If
    End Sub

    Private Sub TKPohi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tkOige = 0
        tkVale = 0
        If tkAegMin < 10 Then
            LabAegMin.Text = "0" & tkAegMin
        Else
            LabAegMin.Text = tkAegMin
        End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Var1.x1 = ""
        Var1.x2 = ""
        Dim oForm4 As Form4
        oForm4 = New Form4()
        oForm4.Show()
        oForm4 = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tkAegSek = 0 Then
            If tkAegMin > 0 Then
                tkAegMin = tkAegMin - 1
                tkAegSek = 59
                If tkAegMin < 10 Then
                    LabAegMin.Text = "0" & tkAegMin
                Else
                    LabAegMin.Text = tkAegMin
                End If
                If tkAegSek < 10 Then
                    LabAegSek.Text = "0" & tkAegSek
                Else
                    LabAegSek.Text = tkAegSek
                End If
            Else
                finish()
            End If
        Else
            tkAegSek = tkAegSek - 1
            If tkAegSek < 10 Then
                LabAegSek.Text = "0" & tkAegSek
            Else
                LabAegSek.Text = tkAegSek
            End If
        End If
    End Sub

    Private Function finish()
        Timer1.Enabled = False
        Button1.Enabled = False
        Label2.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        MsgBox("Tulemus: " & Math.Round((tkOige / (tkOige + tkVale) * 100), 1, MidpointRounding.AwayFromZero).ToString & "%")
    End Function
End Class
