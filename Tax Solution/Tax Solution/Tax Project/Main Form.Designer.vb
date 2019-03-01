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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPropVal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblPropTaxTotal = New System.Windows.Forms.Label()
        Me.txtPropVal = New System.Windows.Forms.TextBox()
        Me.lblTotPropTaxlabel = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(123, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(48, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(262, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Property Tax Calculator"
        '
        'lblPropVal
        '
        Me.lblPropVal.AutoSize = True
        Me.lblPropVal.Location = New System.Drawing.Point(9, 194)
        Me.lblPropVal.Name = "lblPropVal"
        Me.lblPropVal.Size = New System.Drawing.Size(91, 13)
        Me.lblPropVal.TabIndex = 1
        Me.lblPropVal.Text = "Property &Value ($)"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 281)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(91, 27)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Caculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblPropTaxTotal
        '
        Me.lblPropTaxTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPropTaxTotal.Location = New System.Drawing.Point(123, 235)
        Me.lblPropTaxTotal.Name = "lblPropTaxTotal"
        Me.lblPropTaxTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblPropTaxTotal.TabIndex = 4
        Me.lblPropTaxTotal.Text = "0"
        Me.lblPropTaxTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPropVal
        '
        Me.txtPropVal.Location = New System.Drawing.Point(123, 187)
        Me.txtPropVal.Name = "txtPropVal"
        Me.txtPropVal.Size = New System.Drawing.Size(100, 20)
        Me.txtPropVal.TabIndex = 2
        Me.txtPropVal.Text = "0"
        Me.txtPropVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotPropTaxlabel
        '
        Me.lblTotPropTaxlabel.AutoSize = True
        Me.lblTotPropTaxlabel.Location = New System.Drawing.Point(9, 239)
        Me.lblTotPropTaxlabel.Name = "lblTotPropTaxlabel"
        Me.lblTotPropTaxlabel.Size = New System.Drawing.Size(82, 13)
        Me.lblTotPropTaxlabel.TabIndex = 3
        Me.lblTotPropTaxlabel.Text = "Property Tax ($)"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 281)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 27)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 323)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPropVal)
        Me.Controls.Add(Me.lblPropTaxTotal)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotPropTaxlabel)
        Me.Controls.Add(Me.lblPropVal)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "Property Tax Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPropVal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblPropTaxTotal As Label
    Friend WithEvents txtPropVal As TextBox
    Friend WithEvents lblTotPropTaxlabel As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
