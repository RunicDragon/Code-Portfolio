<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtTipRate = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblTipRate = New System.Windows.Forms.Label()
        Me.lblTipAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTDLabel = New System.Windows.Forms.Label()
        Me.lblTxAmlbl = New System.Windows.Forms.Label()
        Me.lblTpAmLabel = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Restaurant_App_William_Eason.My.Resources.Resources.GRRR
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(91, 83)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(165, 24)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(106, 20)
        Me.txtDate.TabIndex = 1
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(120, 27)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(30, 13)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "&Date"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(95, 113)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(106, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTipRate
        '
        Me.txtTipRate.Location = New System.Drawing.Point(95, 142)
        Me.txtTipRate.Name = "txtTipRate"
        Me.txtTipRate.Size = New System.Drawing.Size(106, 20)
        Me.txtTipRate.TabIndex = 5
        Me.txtTipRate.Text = "15"
        Me.txtTipRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(25, 113)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(64, 13)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "&Amount   ($)"
        '
        'lblTipRate
        '
        Me.lblTipRate.AutoSize = True
        Me.lblTipRate.Location = New System.Drawing.Point(25, 142)
        Me.lblTipRate.Name = "lblTipRate"
        Me.lblTipRate.Size = New System.Drawing.Size(65, 13)
        Me.lblTipRate.TabIndex = 4
        Me.lblTipRate.Text = "&Tip Rate (%)"
        '
        'lblTipAmount
        '
        Me.lblTipAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipAmount.Location = New System.Drawing.Point(94, 181)
        Me.lblTipAmount.Name = "lblTipAmount"
        Me.lblTipAmount.Size = New System.Drawing.Size(107, 27)
        Me.lblTipAmount.TabIndex = 7
        Me.lblTipAmount.Text = "0"
        Me.lblTipAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxAmount.Location = New System.Drawing.Point(94, 220)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(107, 27)
        Me.lblTaxAmount.TabIndex = 9
        Me.lblTaxAmount.Text = "0"
        Me.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(94, 259)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(107, 27)
        Me.lblTotalDue.TabIndex = 11
        Me.lblTotalDue.Text = "0"
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTDLabel
        '
        Me.lblTDLabel.AutoSize = True
        Me.lblTDLabel.Location = New System.Drawing.Point(22, 260)
        Me.lblTDLabel.Name = "lblTDLabel"
        Me.lblTDLabel.Size = New System.Drawing.Size(54, 13)
        Me.lblTDLabel.TabIndex = 10
        Me.lblTDLabel.Text = "Total Due"
        '
        'lblTxAmlbl
        '
        Me.lblTxAmlbl.AutoSize = True
        Me.lblTxAmlbl.Location = New System.Drawing.Point(22, 220)
        Me.lblTxAmlbl.Name = "lblTxAmlbl"
        Me.lblTxAmlbl.Size = New System.Drawing.Size(64, 13)
        Me.lblTxAmlbl.TabIndex = 8
        Me.lblTxAmlbl.Text = "Tax Amount"
        '
        'lblTpAmLabel
        '
        Me.lblTpAmLabel.AutoSize = True
        Me.lblTpAmLabel.Location = New System.Drawing.Point(22, 182)
        Me.lblTpAmLabel.Name = "lblTpAmLabel"
        Me.lblTpAmLabel.Size = New System.Drawing.Size(61, 13)
        Me.lblTpAmLabel.TabIndex = 6
        Me.lblTpAmLabel.Text = "Tip Amount"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 319)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(91, 35)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(112, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 35)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Cl&ear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 366)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTpAmLabel)
        Me.Controls.Add(Me.lblTxAmlbl)
        Me.Controls.Add(Me.lblTDLabel)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblTipAmount)
        Me.Controls.Add(Me.lblTipRate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtTipRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "FrmMain"
        Me.Text = "Restaurant Calculator"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lbldate As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtTipRate As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblTipRate As Label
    Friend WithEvents lblTipAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblTDLabel As Label
    Friend WithEvents lblTxAmlbl As Label
    Friend WithEvents lblTpAmLabel As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
