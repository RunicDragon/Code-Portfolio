' Copyright (c) 2019 Union County College. All Rights Reserved.
' CST-130-051 Visual Basic
' Name:         State Capitals
' Purpose:      Displays capital of the selected state.
' Programmer:   William Eason on 3/31/2019

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If rdbNJ.Checked = True Then
            lblCapital.Text = "Trenton"
        End If
        If rdbNY.Checked = True Then
            lblCapital.Text = "Albany"
        End If
        If rdbVA.Checked = True Then
            lblCapital.Text = "Richmond"
        End If
        If rdbWA.Checked = True Then
            lblCapital.Text = "Olympia"
        End If
        If rdbCA.Checked = True Then
            lblCapital.Text = "Sacramento"
        End If
    End Sub

    Private Sub rdbNJ_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNJ.CheckedChanged
        lblCapital.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub rdbNY_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNY.CheckedChanged
        lblCapital.Text = ""
    End Sub

    Private Sub rdbVA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVA.CheckedChanged
        lblCapital.Text = ""
    End Sub

    Private Sub rdbWA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWA.CheckedChanged
        lblCapital.Text = ""
    End Sub

    Private Sub rdbCA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCA.CheckedChanged
        lblCapital.Text = ""
    End Sub
End Class
