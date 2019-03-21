<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.txtScores = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Location = New System.Drawing.Point(24, 50)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(40, 13)
        Me.lblScores.TabIndex = 0
        Me.lblScores.Text = "&Scores"
        '
        'txtScores
        '
        Me.txtScores.Location = New System.Drawing.Point(27, 66)
        Me.txtScores.Name = "txtScores"
        Me.txtScores.Size = New System.Drawing.Size(100, 20)
        Me.txtScores.TabIndex = 1
        Me.txtScores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(52, 194)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(169, 50)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(169, 109)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(44, 13)
        Me.lblCounter.TabIndex = 6
        Me.lblCounter.Text = "Counter"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(24, 109)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(47, 13)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.Text = "Average"
        '
        'txtCounter
        '
        Me.txtCounter.Location = New System.Drawing.Point(172, 125)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.ReadOnly = True
        Me.txtCounter.Size = New System.Drawing.Size(100, 20)
        Me.txtCounter.TabIndex = 7
        Me.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(27, 125)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 5
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(172, 66)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(172, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtCounter)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtScores)
        Me.Controls.Add(Me.lblScores)
        Me.Name = "frmMain"
        Me.Text = "Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScores As Label
    Friend WithEvents txtScores As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents txtCounter As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnExit As Button
End Class
