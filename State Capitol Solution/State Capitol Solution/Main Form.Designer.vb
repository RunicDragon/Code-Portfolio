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
        Me.rdbNJ = New System.Windows.Forms.RadioButton()
        Me.rdbNY = New System.Windows.Forms.RadioButton()
        Me.rdbVA = New System.Windows.Forms.RadioButton()
        Me.rdbWA = New System.Windows.Forms.RadioButton()
        Me.rdbCA = New System.Windows.Forms.RadioButton()
        Me.lblStates = New System.Windows.Forms.Label()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbNJ
        '
        Me.rdbNJ.AutoSize = True
        Me.rdbNJ.Location = New System.Drawing.Point(0, 11)
        Me.rdbNJ.Name = "rdbNJ"
        Me.rdbNJ.Size = New System.Drawing.Size(80, 17)
        Me.rdbNJ.TabIndex = 0
        Me.rdbNJ.TabStop = True
        Me.rdbNJ.Text = "New Jersey"
        Me.rdbNJ.UseVisualStyleBackColor = True
        '
        'rdbNY
        '
        Me.rdbNY.AutoSize = True
        Me.rdbNY.Location = New System.Drawing.Point(0, 34)
        Me.rdbNY.Name = "rdbNY"
        Me.rdbNY.Size = New System.Drawing.Size(72, 17)
        Me.rdbNY.TabIndex = 1
        Me.rdbNY.TabStop = True
        Me.rdbNY.Text = "New York"
        Me.rdbNY.UseVisualStyleBackColor = True
        '
        'rdbVA
        '
        Me.rdbVA.AutoSize = True
        Me.rdbVA.Location = New System.Drawing.Point(0, 57)
        Me.rdbVA.Name = "rdbVA"
        Me.rdbVA.Size = New System.Drawing.Size(59, 17)
        Me.rdbVA.TabIndex = 2
        Me.rdbVA.TabStop = True
        Me.rdbVA.Text = "Virginia"
        Me.rdbVA.UseVisualStyleBackColor = True
        '
        'rdbWA
        '
        Me.rdbWA.AutoSize = True
        Me.rdbWA.Location = New System.Drawing.Point(0, 80)
        Me.rdbWA.Name = "rdbWA"
        Me.rdbWA.Size = New System.Drawing.Size(82, 17)
        Me.rdbWA.TabIndex = 3
        Me.rdbWA.TabStop = True
        Me.rdbWA.Text = "Washington"
        Me.rdbWA.UseVisualStyleBackColor = True
        '
        'rdbCA
        '
        Me.rdbCA.AutoSize = True
        Me.rdbCA.Location = New System.Drawing.Point(0, 103)
        Me.rdbCA.Name = "rdbCA"
        Me.rdbCA.Size = New System.Drawing.Size(68, 17)
        Me.rdbCA.TabIndex = 4
        Me.rdbCA.TabStop = True
        Me.rdbCA.Text = "California"
        Me.rdbCA.UseVisualStyleBackColor = True
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.Location = New System.Drawing.Point(6, 0)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(75, 13)
        Me.lblStates.TabIndex = 5
        Me.lblStates.Text = "Select A State"
        '
        'lblCapital
        '
        Me.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCapital.Location = New System.Drawing.Point(139, 90)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(115, 19)
        Me.lblCapital.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(139, 55)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(115, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "&Display Capital"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbCA)
        Me.GroupBox1.Controls.Add(Me.rdbWA)
        Me.GroupBox1.Controls.Add(Me.rdbVA)
        Me.GroupBox1.Controls.Add(Me.rdbNY)
        Me.GroupBox1.Controls.Add(Me.lblStates)
        Me.GroupBox1.Controls.Add(Me.rdbNJ)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 140)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 219)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblCapital)
        Me.Name = "frmMain"
        Me.Text = "State Capitals"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdbNJ As RadioButton
    Friend WithEvents rdbNY As RadioButton
    Friend WithEvents rdbVA As RadioButton
    Friend WithEvents rdbWA As RadioButton
    Friend WithEvents rdbCA As RadioButton
    Friend WithEvents lblStates As Label
    Friend WithEvents lblCapital As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
