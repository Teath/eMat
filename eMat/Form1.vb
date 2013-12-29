Imports System.Text.RegularExpressions
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Var1.firstLoad = True Then
            Var1.firstLoad = False
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim req As New System.Net.WebClient
        Dim newVer
        Try
            newVer = req.DownloadString("https://raw.github.com/Teath/eMat/master/version.txt")
        Catch ex As Exception
            End
        End Try
        Dim cleanNewVer = Regex.Match(newVer, "(v[0-9]+\.[0-9]+\.[0-9]+)").ToString
        If cleanNewVer <> Var1.version Then
            MsgBox("Uuem versioon on saadaval! Laadige alla siit: http://teath.net/emat")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As TKValik
        oForm = New TKValik()
        oForm.Show()
        oForm = Nothing
        Me.Close()
    End Sub
End Class
