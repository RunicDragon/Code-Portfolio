' Copyright (c) 2019 Union County College. All Rights Reserved.
' CST-130-051 Visual Basic
'
' Name: Grade Average Calculator
' Purpose: Average scores and display counter for each entered score
' Programmed by: William Eason on 3/6/2019


Option Explicit On 'Must define a Variable
Option Infer Off 'Must Define a datatype for given variable
Option Strict On 'Follow strict datatype conversion rules

Public Class frmMain

    Private dblTotal As Double



    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Static dblTotal As Double
        Dim dblScore As Double
        Static dblCounter As Double
        Dim dblAverage As Double

        Double.TryParse(txtScores.Text, dblScore)

        'Change Title 
        Me.Text = Now.Date.ToShortDateString


        'Sum The Scores
        dblTotal = dblTotal + dblScore

        'Find the number of scores
        dblCounter = dblCounter + 1

        'Show Total Score
        txtTotal.Text = dblTotal.ToString("n0")

        'Show Total count 
        txtCounter.Text = dblCounter.ToString("n0")

        'Calculate Average
        dblAverage = dblTotal / dblCounter

        'Display Average
        txtAverage.Text = dblAverage.ToString("n0")

        'Focus back on scores text box
        txtScores.Focus()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtScores_TextChanged(sender As Object, e As EventArgs) Handles txtScores.TextChanged
        txtCounter.Text = String.Empty
        txtTotal.Text = String.Empty
        txtAverage.Text = String.Empty
    End Sub

    Private Sub txtScores_Enter(sender As Object, e As EventArgs) Handles txtScores.Enter
        txtScores.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
