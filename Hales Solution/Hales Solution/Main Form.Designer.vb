<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbKing = New System.Windows.Forms.RadioButton()
        Me.rdbQueen = New System.Windows.Forms.RadioButton()
        Me.rdbTwin = New System.Windows.Forms.RadioButton()
        Me.rdbFull = New System.Windows.Forms.RadioButton()
        Me.chkPickup = New System.Windows.Forms.CheckBox()
        Me.lblCostlabel = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbKing)
        Me.GroupBox1.Controls.Add(Me.rdbQueen)
        Me.GroupBox1.Controls.Add(Me.rdbTwin)
        Me.GroupBox1.Controls.Add(Me.rdbFull)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'rdbKing
        '
        Me.rdbKing.AutoSize = True
        Me.rdbKing.Location = New System.Drawing.Point(6, 88)
        Me.rdbKing.Name = "rdbKing"
        Me.rdbKing.Size = New System.Drawing.Size(46, 17)
        Me.rdbKing.TabIndex = 4
        Me.rdbKing.TabStop = True
        Me.rdbKing.Text = "&King"
        Me.rdbKing.UseVisualStyleBackColor = True
        '
        'rdbQueen
        '
        Me.rdbQueen.AutoSize = True
        Me.rdbQueen.Location = New System.Drawing.Point(6, 65)
        Me.rdbQueen.Name = "rdbQueen"
        Me.rdbQueen.Size = New System.Drawing.Size(57, 17)
        Me.rdbQueen.TabIndex = 5
        Me.rdbQueen.TabStop = True
        Me.rdbQueen.Text = "&Queen"
        Me.rdbQueen.UseVisualStyleBackColor = True
        '
        'rdbTwin
        '
        Me.rdbTwin.AutoSize = True
        Me.rdbTwin.Location = New System.Drawing.Point(6, 19)
        Me.rdbTwin.Name = "rdbTwin"
        Me.rdbTwin.Size = New System.Drawing.Size(48, 17)
        Me.rdbTwin.TabIndex = 2
        Me.rdbTwin.TabStop = True
        Me.rdbTwin.Text = "&Twin"
        Me.rdbTwin.UseVisualStyleBackColor = True
        '
        'rdbFull
        '
        Me.rdbFull.AutoSize = True
        Me.rdbFull.Location = New System.Drawing.Point(6, 42)
        Me.rdbFull.Name = "rdbFull"
        Me.rdbFull.Size = New System.Drawing.Size(41, 17)
        Me.rdbFull.TabIndex = 3
        Me.rdbFull.TabStop = True
        Me.rdbFull.Text = "&Full"
        Me.rdbFull.UseVisualStyleBackColor = True
        '
        'chkPickup
        '
        Me.chkPickup.AutoSize = True
        Me.chkPickup.Location = New System.Drawing.Point(158, 12)
        Me.chkPickup.Name = "chkPickup"
        Me.chkPickup.Size = New System.Drawing.Size(99, 17)
        Me.chkPickup.TabIndex = 1
        Me.chkPickup.Text = "&Pick up in store"
        Me.chkPickup.UseVisualStyleBackColor = True
        '
        'lblCostlabel
        '
        Me.lblCostlabel.AutoSize = True
        Me.lblCostlabel.Location = New System.Drawing.Point(155, 33)
        Me.lblCostlabel.Name = "lblCostlabel"
        Me.lblCostlabel.Size = New System.Drawing.Size(28, 13)
        Me.lblCostlabel.TabIndex = 2
        Me.lblCostlabel.Text = "&Cost"
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(170, 86)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(75, 23)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "&Display Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(170, 115)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost.Location = New System.Drawing.Point(157, 54)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(100, 23)
        Me.lblCost.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 157)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblCostlabel)
        Me.Controls.Add(Me.chkPickup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbTwin As RadioButton
    Friend WithEvents rdbFull As RadioButton
    Friend WithEvents rdbKing As RadioButton
    Friend WithEvents rdbQueen As RadioButton
    Friend WithEvents chkPickup As CheckBox
    Friend WithEvents lblCostlabel As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCost As Label
End Class
