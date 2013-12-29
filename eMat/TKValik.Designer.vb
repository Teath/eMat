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
        Me.vArvVal = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AegPiirm = New System.Windows.Forms.RadioButton()
        Me.AegPiird = New System.Windows.Forms.RadioButton()
        Me.AegVal = New System.Windows.Forms.NumericUpDown()
        Me.minut = New System.Windows.Forms.Label()
        CType(Me.vArvVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AegVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vali võrranditüübid:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Vali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(75, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Tagasi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(31, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "ax²+bx+c = d"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(31, 84)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "ax²+bx+c = 0"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(31, 107)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "x²+bx+c = 0"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(31, 130)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox4.TabIndex = 7
        Me.CheckBox4.Text = "ax²+bx = 0"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(31, 153)
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
        Me.Label2.Location = New System.Drawing.Point(28, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tunnikontrolli seaded"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Võrrandite arv:"
        '
        'vArvVal
        '
        Me.vArvVal.Location = New System.Drawing.Point(112, 180)
        Me.vArvVal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vArvVal.Name = "vArvVal"
        Me.vArvVal.Size = New System.Drawing.Size(45, 20)
        Me.vArvVal.TabIndex = 11
        Me.vArvVal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Ajalimiit:"
        '
        'AegPiirm
        '
        Me.AegPiirm.AutoSize = True
        Me.AegPiirm.Checked = True
        Me.AegPiirm.Location = New System.Drawing.Point(31, 227)
        Me.AegPiirm.Name = "AegPiirm"
        Me.AegPiirm.Size = New System.Drawing.Size(68, 17)
        Me.AegPiirm.TabIndex = 13
        Me.AegPiirm.TabStop = True
        Me.AegPiirm.Text = "Piiramatu"
        Me.AegPiirm.UseVisualStyleBackColor = True
        '
        'AegPiird
        '
        Me.AegPiird.AutoSize = True
        Me.AegPiird.Location = New System.Drawing.Point(31, 250)
        Me.AegPiird.Name = "AegPiird"
        Me.AegPiird.Size = New System.Drawing.Size(63, 17)
        Me.AegPiird.TabIndex = 14
        Me.AegPiird.Text = "Piiratud:"
        Me.AegPiird.UseVisualStyleBackColor = True
        '
        'AegVal
        '
        Me.AegVal.Enabled = False
        Me.AegVal.Location = New System.Drawing.Point(100, 250)
        Me.AegVal.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.AegVal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AegVal.Name = "AegVal"
        Me.AegVal.Size = New System.Drawing.Size(44, 20)
        Me.AegVal.TabIndex = 15
        Me.AegVal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'minut
        '
        Me.minut.AutoSize = True
        Me.minut.Location = New System.Drawing.Point(150, 252)
        Me.minut.Name = "minut"
        Me.minut.Size = New System.Drawing.Size(32, 13)
        Me.minut.TabIndex = 16
        Me.minut.Text = "minut"
        '
        'TKValik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 374)
        Me.Controls.Add(Me.minut)
        Me.Controls.Add(Me.AegVal)
        Me.Controls.Add(Me.AegPiird)
        Me.Controls.Add(Me.AegPiirm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.vArvVal)
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
        CType(Me.vArvVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AegVal, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents vArvVal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AegPiirm As System.Windows.Forms.RadioButton
    Friend WithEvents AegPiird As System.Windows.Forms.RadioButton
    Friend WithEvents AegVal As System.Windows.Forms.NumericUpDown
    Friend WithEvents minut As System.Windows.Forms.Label
End Class
