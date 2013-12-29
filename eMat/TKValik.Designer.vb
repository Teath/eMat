<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TKValik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TKValik))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AjaLimOff = New System.Windows.Forms.RadioButton()
        Me.AjaLimOn = New System.Windows.Forms.RadioButton()
        Me.AjaLimNum = New System.Windows.Forms.NumericUpDown()
        Me.VArvNum = New System.Windows.Forms.NumericUpDown()
        Me.LblMinut = New System.Windows.Forms.Label()
        Me.CancOnOff = New System.Windows.Forms.CheckBox()
        Me.EelVasOnOff = New System.Windows.Forms.CheckBox()
        CType(Me.AjaLimNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VArvNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vali võrranditüübid:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Alusta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(74, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Tagasi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(33, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "ax²+bx+c = d"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(33, 81)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "ax²+bx+c = 0"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(33, 104)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "x²+bx+c = 0"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(33, 127)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox4.TabIndex = 7
        Me.CheckBox4.Text = "ax²+bx = 0"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(33, 150)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox5.TabIndex = 8
        Me.CheckBox5.Text = "ax²+ c = 0"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tunnikontrolli seaded"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Võrrandite arv:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ajalimiit:"
        '
        'AjaLimOff
        '
        Me.AjaLimOff.AutoSize = True
        Me.AjaLimOff.Checked = True
        Me.AjaLimOff.Location = New System.Drawing.Point(30, 221)
        Me.AjaLimOff.Name = "AjaLimOff"
        Me.AjaLimOff.Size = New System.Drawing.Size(68, 17)
        Me.AjaLimOff.TabIndex = 12
        Me.AjaLimOff.TabStop = True
        Me.AjaLimOff.Text = "Piiramatu"
        Me.AjaLimOff.UseVisualStyleBackColor = True
        '
        'AjaLimOn
        '
        Me.AjaLimOn.AutoSize = True
        Me.AjaLimOn.Location = New System.Drawing.Point(30, 244)
        Me.AjaLimOn.Name = "AjaLimOn"
        Me.AjaLimOn.Size = New System.Drawing.Size(63, 17)
        Me.AjaLimOn.TabIndex = 13
        Me.AjaLimOn.Text = "Piiratud:"
        Me.AjaLimOn.UseVisualStyleBackColor = True
        '
        'AjaLimNum
        '
        Me.AjaLimNum.Enabled = False
        Me.AjaLimNum.Location = New System.Drawing.Point(99, 244)
        Me.AjaLimNum.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.AjaLimNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AjaLimNum.Name = "AjaLimNum"
        Me.AjaLimNum.Size = New System.Drawing.Size(40, 20)
        Me.AjaLimNum.TabIndex = 14
        Me.AjaLimNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VArvNum
        '
        Me.VArvNum.Location = New System.Drawing.Point(109, 177)
        Me.VArvNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.VArvNum.Name = "VArvNum"
        Me.VArvNum.Size = New System.Drawing.Size(42, 20)
        Me.VArvNum.TabIndex = 15
        Me.VArvNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblMinut
        '
        Me.LblMinut.AutoSize = True
        Me.LblMinut.Location = New System.Drawing.Point(145, 246)
        Me.LblMinut.Name = "LblMinut"
        Me.LblMinut.Size = New System.Drawing.Size(32, 13)
        Me.LblMinut.TabIndex = 16
        Me.LblMinut.Text = "minut"
        '
        'CancOnOff
        '
        Me.CancOnOff.AutoSize = True
        Me.CancOnOff.Location = New System.Drawing.Point(30, 283)
        Me.CancOnOff.Name = "CancOnOff"
        Me.CancOnOff.Size = New System.Drawing.Size(128, 17)
        Me.CancOnOff.TabIndex = 17
        Me.CancOnOff.Text = "Katkestamine lubatud"
        Me.CancOnOff.UseVisualStyleBackColor = True
        '
        'EelVasOnOff
        '
        Me.EelVasOnOff.AutoSize = True
        Me.EelVasOnOff.Location = New System.Drawing.Point(30, 306)
        Me.EelVasOnOff.Name = "EelVasOnOff"
        Me.EelVasOnOff.Size = New System.Drawing.Size(123, 17)
        Me.EelVasOnOff.TabIndex = 18
        Me.EelVasOnOff.Text = "Näita eelmist vastust"
        Me.EelVasOnOff.UseVisualStyleBackColor = True
        '
        'TKValik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 405)
        Me.Controls.Add(Me.EelVasOnOff)
        Me.Controls.Add(Me.CancOnOff)
        Me.Controls.Add(Me.LblMinut)
        Me.Controls.Add(Me.VArvNum)
        Me.Controls.Add(Me.AjaLimNum)
        Me.Controls.Add(Me.AjaLimOn)
        Me.Controls.Add(Me.AjaLimOff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TKValik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eMat - Vali võrrand"
        CType(Me.AjaLimNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VArvNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AjaLimOff As System.Windows.Forms.RadioButton
    Friend WithEvents AjaLimOn As System.Windows.Forms.RadioButton
    Friend WithEvents AjaLimNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents VArvNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblMinut As System.Windows.Forms.Label
    Friend WithEvents CancOnOff As System.Windows.Forms.CheckBox
    Friend WithEvents EelVasOnOff As System.Windows.Forms.CheckBox
End Class
