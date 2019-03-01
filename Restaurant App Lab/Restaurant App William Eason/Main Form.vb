' Copyright (c) 2019 Union County College. All Rights Reserved.
' CST-130-051 Visual Basic
'
' Name:               Restaurant App
' Purpose:            Calculate the Tip and Sales Tax
' Programmer:         William Eason on 2/13/2019

Option Explicit On 'Must define a Variable
Option Infer Off 'Must Define a datatype for given variable
'Follow strict datatype conversion rules

Public Class FrmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblAmount As Double
        Dim dblTaxAmount As Double
        Dim dblTipRate As Double
        Dim dblTipAmount As Double
        Const dblSalesTax As Double = 0.06625

        Double.TryParse(txtAmount.Text, dblAmount)
        Double.TryParse(txtTipRate.Text, dblTipRate)
        dblTaxAmount = dblAmount * dblSalesTax
        dblTipAmount = dblAmount * dblTipRate / 100
        lblTaxAmount.Text = dblTaxAmount.ToString("c2")
        lblTipAmount.Text = (dblAmount * dblTipRate / 100).ToString("c2")
        lblTotalDue.Text = (dblAmount + dblTaxAmount + dblTipAmount).ToString("c2")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = 0
        txtDate.Text = ""
        txtTipRate.Text = 0
        lblTipAmount.Text = 0
        lblTaxAmount.Text = 0
        lblTotalDue.Text = 0
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub txtTipRate_TextChanged(sender As Object, e As EventArgs) Handles txtTipRate.TextChanged

    End Sub
End Class
