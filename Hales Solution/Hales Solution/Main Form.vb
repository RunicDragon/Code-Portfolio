' Copyright (c) 2019 Union County College. All Rights Reserved.
' CST-130-051 Visual Basic
' Name:         Gross Project
' Purpose:      Calculates an employee's weekly gross pay.
' Programmer:   William Eason on 3/31/2019
Option Explicit On

Public Class frmMain
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCostlabel.Click

    End Sub

    Private Sub lblCost_Click(sender As Object, e As EventArgs) Handles lblCost.Click

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim dblTwin As Double = 39.99
        Dim dblFull As Double = 49.99
        Dim dblQueen As Double = 59.99
        Dim dblKing As Double = 69.99
        Const dblFee As Double = 5.0

        If chkPickup.Checked = True Then
            If rdbTwin.Checked Then
                lblCost.Text = dblTwin + dblFee
            End If
            If rdbFull.Checked Then
                lblCost.Text = dblFull + dblFee
            End If
            If rdbQueen.Checked Then
                lblCost.Text = dblQueen + dblFee
            End If
            If rdbKing.Checked Then
                lblCost.Text = dblKing + dblFee
            End If
        Else
            If rdbTwin.Checked Then
                lblCost.Text = dblTwin
            End If
            If rdbFull.Checked Then
                lblCost.Text = dblFull
            End If
            If rdbQueen.Checked Then
                lblCost.Text = dblQueen
            End If
            If rdbKing.Checked Then
                lblCost.Text = dblKing
            End If


        End If


    End Sub

    Private Sub rdbTwin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTwin.CheckedChanged
        lblCost.Text = ""
    End Sub

    Private Sub rdbQueen_CheckedChanged(sender As Object, e As EventArgs) Handles rdbQueen.CheckedChanged
        lblCost.Text = ""
    End Sub

    Private Sub rdbKing_CheckedChanged(sender As Object, e As EventArgs) Handles rdbKing.CheckedChanged
        lblCost.Text = ""
    End Sub

    Private Sub rdbFull_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFull.CheckedChanged
        lblCost.Text = ""
    End Sub

    Private Sub chkPickup_CheckedChanged(sender As Object, e As EventArgs) Handles chkPickup.CheckedChanged
        lblCost.Text = ""
    End Sub
End Class
