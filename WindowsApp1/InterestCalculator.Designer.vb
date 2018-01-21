<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFutureValue = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBronze = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.listRequiredInvestment = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbYears = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Future Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Period"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Requied Investment"
        '
        'txtFutureValue
        '
        Me.txtFutureValue.Location = New System.Drawing.Point(161, 54)
        Me.txtFutureValue.Name = "txtFutureValue"
        Me.txtFutureValue.Size = New System.Drawing.Size(100, 31)
        Me.txtFutureValue.TabIndex = 4
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(161, 138)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 31)
        Me.txtInterestRate.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBronze)
        Me.GroupBox1.Controls.Add(Me.radSilver)
        Me.GroupBox1.Controls.Add(Me.radGold)
        Me.GroupBox1.Location = New System.Drawing.Point(271, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 213)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'radBronze
        '
        Me.radBronze.AutoSize = True
        Me.radBronze.Location = New System.Drawing.Point(41, 152)
        Me.radBronze.Name = "radBronze"
        Me.radBronze.Size = New System.Drawing.Size(111, 29)
        Me.radBronze.TabIndex = 9
        Me.radBronze.TabStop = True
        Me.radBronze.Text = "Bronze"
        Me.radBronze.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(41, 105)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(97, 29)
        Me.radSilver.TabIndex = 8
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(41, 60)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(88, 29)
        Me.radGold.TabIndex = 7
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'listRequiredInvestment
        '
        Me.listRequiredInvestment.FormattingEnabled = True
        Me.listRequiredInvestment.ItemHeight = 25
        Me.listRequiredInvestment.Location = New System.Drawing.Point(25, 342)
        Me.listRequiredInvestment.Name = "listRequiredInvestment"
        Me.listRequiredInvestment.Size = New System.Drawing.Size(479, 254)
        Me.listRequiredInvestment.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(19, 680)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 51)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(192, 680)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(147, 51)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Clear Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(365, 680)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 51)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbYears
        '
        Me.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYears.FormattingEnabled = True
        Me.cmbYears.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.cmbYears.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.cmbYears.Location = New System.Drawing.Point(116, 215)
        Me.cmbYears.Name = "cmbYears"
        Me.cmbYears.Size = New System.Drawing.Size(121, 33)
        Me.cmbYears.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 834)
        Me.Controls.Add(Me.cmbYears)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.listRequiredInvestment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtFutureValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Present Value Calculator 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFutureValue As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBronze As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents listRequiredInvestment As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbYears As ComboBox
End Class
