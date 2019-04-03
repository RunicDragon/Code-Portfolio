' Name:         Gross Project
' Purpose:      Calculates an employee's weekly gross pay.
' Programmer:   William Eason on 3/31/2019
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_Enter(sender As Object, e As EventArgs) Handles txtHours.Enter
        txtHours.SelectAll()
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        lblGross.Text = String.Empty

        lblMessage.Text = ""
    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtRate_Enter(sender As Object, e As EventArgs) Handles txtRate.Enter
        txtRate.SelectAll()
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        lblGross.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblHours As Double
        Dim blnResult As Boolean
        Dim dblRate As Double
        Dim dblGross As Double
        Const dblBrate As Double = 10
        Const dblOT As Double = 1.5





        Double.TryParse(txtRate.Text, dblRate)
        Double.TryParse(txtHours.Text, dblHours)
        blnResult = Double.TryParse(txtHours.Text, dblHours)
        txtResult.Text = blnResult.ToString
        lblMessage.Text = ""



        If (blnResult = True) Then
            If (dblHours > 0) And (dblHours < 80) Then
                'If Condition is TRUE
                If chkOverTime.Checked = True Then

                    If dblHours > 40 Then

                        dblGross = dblHours * dblRate + ((dblHours - 40) * dblBrate * dblOT)
                        lblGross.Text = dblGross.ToString("C2")


                    Else
                        lblMessage.Text = "Did not work Over 40Hrs"
                    End If
                Else

                    blnResult = False
                    dblGross = dblHours * dblRate
                    lblGross.Text = dblGross.ToString("C2")

                End If
                lblMessage.Text = ""
            Else

                lblMessage.Text = "Must enter a number greater then 0"

            End If

        Else
            lblMessage.Text = "Must enter only number"
        End If

    End Sub

    Private Sub chkOverTime_CheckedChanged(sender As Object, e As EventArgs) Handles chkOverTime.CheckedChanged
   
        lblMessage.Text = ""
    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtResult_TextChanged_1(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub
End Class
