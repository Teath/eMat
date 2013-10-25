Public Class Form3

    Private Function updateStats()
        Label5.Text = Var1.oige
        Label7.Text = Var1.vale
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
        Dim ran1 As Integer = CInt(Int((40 * Rnd()) + 1))
        Dim ran2 As Integer = CInt(Int((40 * Rnd()) + 1))
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
        Dim ran2 As Integer = CInt(Int((100 * Rnd()) + 2))
        Label2.Text = "x² - " + ran2.ToString() + "x = 0"
        x1 = ran2
        x2 = 0
        Label23.Text = x1.ToString + ", " + x2.ToString
        Var1.x1 = x1.ToString
        Var1.x2 = x2.ToString
    End Function

    Public Function genTypeRan()
        Randomize()
        Dim genNum As Integer = CInt(Int((4 * Rnd()) + 1))
        If genNum = 1 Then
            genType1()
        ElseIf genNum = 2 Then
            genType2()
        ElseIf genNum = 3 Then
            genType3()
        ElseIf genNum = 4 Then
            genType4()
        ElseIf genNum = 5 Then
            genType5()
        End If
    End Function

    Private Function genHandler()
        If Var1.vTyyp = 1 Then
            TextBox2.Enabled = True
            Label8.Text = "ax²+bx+c=d"
            genType1()
        ElseIf Var1.vTyyp = 2 Then
            TextBox2.Enabled = True
            Label8.Text = "ax²+bx+c=0"
            genType2()
        ElseIf Var1.vTyyp = 3 Then
            TextBox2.Enabled = True
            Label8.Text = "x²+bx+c=0"
            genType3()
        ElseIf Var1.vTyyp = 4 Then
            TextBox2.Enabled = True
            Label8.Text = "ax²+bx=0"
            genType4()
        ElseIf Var1.vTyyp = 5 Then
            TextBox2.Enabled = True
            Label8.Text = "x²+bx=0"
            genType5()
        ElseIf Var1.vTyyp = 6 Then
            TextBox2.Enabled = True
            Label8.Text = "Ruutvõrrandid"
            genTypeRan()
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button1.Enabled = True
        Button5.Enabled = True
        TextBox1.Enabled = True
        genHandler()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label15.Text = Var1.x1
        Label17.Text = Var1.x2
        Label21.Text = TextBox1.Text
        Label22.Text = TextBox2.Text
        If TextBox1.Text = Var1.x1 And TextBox2.Text = Var1.x2 Then
            Var1.oige = Var1.oige + 1
        ElseIf TextBox1.Text = Var1.x2 And TextBox2.Text = Var1.x1 Then
            Var1.oige = Var1.oige + 1
        ElseIf TextBox1.Text = "debug on" Then
            Label23.Visible = True
            Label21.Text = ""
            Label22.Text = ""
        ElseIf TextBox1.Text = "debug off" Then
            Label23.Visible = False
            Label21.Text = ""
            Label22.Text = ""
        ElseIf TextBox1.Text = "win" Then
            Var1.oige = Var1.oige + 5
        ElseIf TextBox1.Text = "boo" Then
            Var1.vale = Var1.vale + 5
        Else
            Var1.vale = Var1.vale + 1
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        updateStats()
        genHandler()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateStats()
        Me.KeyPreview = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Var1.oige = 0
        Var1.vale = 0
        updateStats()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm2 As Form2
        oForm2 = New Form2()
        oForm2.Show()
        oForm2 = Nothing
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label15.Text = Var1.x1
        Label17.Text = Var1.x2
        Label21.Text = ""
        Label22.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        genHandler()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Var1.x1 = ""
        Var1.x2 = ""
        Dim oForm4 As Form4
        oForm4 = New Form4()
        oForm4.Show()
        oForm4 = Nothing
    End Sub


End Class
