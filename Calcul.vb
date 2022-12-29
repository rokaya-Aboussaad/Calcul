Imports System.Linq.Expressions
Imports System.Net.Security

Public Class FrmMaCalculatrice
    Dim Memo As Double
    Dim Op As String


    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Ecrire_Resultat("0")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Ecrire_Resultat("1")
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Ecrire_Resultat("2")
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Ecrire_Resultat("3")
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Ecrire_Resultat("4")
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Ecrire_Resultat("5")
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Ecrire_Resultat("6")
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Ecrire_Resultat("7")
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Ecrire_Resultat("8")
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Ecrire_Resultat("9")
    End Sub

    Private Sub Ecrire_Resultat(ByVal Valeur)
        If TxtResultat.Text = "0" Then
            TxtResultat.Text = Valeur
        Else
            TxtResultat.Text = TxtResultat.Text + Valeur
        End If
    End Sub

    Private Sub BtnPoint_Click(sender As Object, e As EventArgs) Handles BtnPoint.Click
        TxtResultat.Text = TxtResultat.Text + "."
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        Memo = "0"
        TxtResultat.Text = "0"
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Memo = TxtResultat.Text
        TxtResultat.Text = "0"
        Op = "+"
    End Sub

    Private Sub BtnMoins_Click(sender As Object, e As EventArgs) Handles BtnMoins.Click
        Memo = TxtResultat.Text
        TxtResultat.Text = "0"
        Op = "-"
    End Sub

    Private Sub BtnDiviion_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        Memo = TxtResultat.Text
        TxtResultat.Text = "0"
        Op = "/"
    End Sub

    Private Sub BtnMultiplication_Click(sender As Object, e As EventArgs) Handles BtnMultiplication.Click
        Memo = TxtResultat.Text
        TxtResultat.Text = "0"
        Op = "*"
    End Sub

    Private Sub Btn1SurX_Click(sender As Object, e As EventArgs) Handles Btn1SurX.Click
        Memo = TxtResultat.Text
        If TxtResultat.Text = "0" Then
            TxtResultat.Text = "Désolé... Nous ne pouvons pas diviser par zéro"
        Else
            TxtResultat.Text = 1 / Memo
        End If
    End Sub

    Private Sub BtnXAuCarre_Click(sender As Object, e As EventArgs) Handles BtnXAuCarre.Click
        Memo = TxtResultat.Text
        TxtResultat.Text = Memo * Memo
    End Sub

    Private Sub BtnRacineNieme_Click(sender As Object, e As EventArgs) Handles BtnRacineNieme.Click
        Memo = TxtResultat.Text
        TxtResultat.Text = Memo ^ (1 / 2)
    End Sub

    Private Sub BtnPourcentage_Click(sender As Object, e As EventArgs) Handles BtnPourcentage.Click
        Memo = TxtResultat.Text
    End Sub

    Private Sub BtnEgal_Click(sender As Object, e As EventArgs) Handles BtnEgal.Click
        If Op = "+" Then
            TxtResultat.Text = Memo + TxtResultat.Text

        End If

        If Op = "-" Then
            TxtResultat.Text = Memo - TxtResultat.Text
        End If

        If Op = "*" Then
            TxtResultat.Text = Memo * TxtResultat.Text
        End If

        If Op = "/" Then
            If TxtResultat.Text = 0 Then
                TxtResultat.Text = "Désolé... Nous ne pouvons pas diviser par zéro"
            Else
                TxtResultat.Text = Memo / TxtResultat.Text
            End If
        End If

    End Sub

    Private Sub BtnEfface_Click(sender As Object, e As EventArgs) Handles BtnEfface.Click
        TxtResultat.Text = TxtResultat.Text.Substring(0, TxtResultat.Text.Length - 1)
    End Sub

    Private Sub BtnPlusMoins_Click(sender As Object, e As EventArgs) Handles BtnPlusMoins.Click
        If TxtResultat.Text <> 0 Then
            TxtResultat.Text = TxtResultat.Text * (-1)
        End If
    End Sub

    Private Sub BtnCE_Click(sender As Object, e As EventArgs) Handles BtnCE.Click
        TxtResultat.Text = Memo
        Memo = "0"
    End Sub

End Class
