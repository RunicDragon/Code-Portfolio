' Name:         Tax Project
' Purpose:      Calculate the Property Tax Based on the value
' Programmer:   William Eason on 2/15/2019


Public Class frmMain
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblPropTaxTotal.Text = (txtPropVal.Text * 0.0135)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPropVal.Text = 0
        lblPropTaxTotal.Text = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblPropTaxTotal_Click(sender As Object, e As EventArgs) Handles lblPropTaxTotal.Click

    End Sub
End Class