<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ipbox = New System.Windows.Forms.TextBox()
        Me.portabox = New System.Windows.Forms.TextBox()
        Me.chiavebox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nickbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxricevi = New System.Windows.Forms.RichTextBox()
        Me.boxinvia = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Suono = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(903, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Connetti"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1013, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Disconnetti"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ipbox
        '
        Me.ipbox.Location = New System.Drawing.Point(51, 15)
        Me.ipbox.Name = "ipbox"
        Me.ipbox.Size = New System.Drawing.Size(135, 22)
        Me.ipbox.TabIndex = 2
        Me.ipbox.Text = "127.0.0.1"
        '
        'portabox
        '
        Me.portabox.Location = New System.Drawing.Point(243, 15)
        Me.portabox.Name = "portabox"
        Me.portabox.Size = New System.Drawing.Size(78, 22)
        Me.portabox.TabIndex = 3
        Me.portabox.Text = "32568"
        '
        'chiavebox
        '
        Me.chiavebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chiavebox.Location = New System.Drawing.Point(627, 15)
        Me.chiavebox.Name = "chiavebox"
        Me.chiavebox.Size = New System.Drawing.Size(197, 21)
        Me.chiavebox.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(830, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 28)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Genera"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Porta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Chiave AES:"
        '
        'nickbox
        '
        Me.nickbox.Location = New System.Drawing.Point(370, 15)
        Me.nickbox.Name = "nickbox"
        Me.nickbox.Size = New System.Drawing.Size(167, 22)
        Me.nickbox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nick:"
        '
        'boxricevi
        '
        Me.boxricevi.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxricevi.Location = New System.Drawing.Point(6, 21)
        Me.boxricevi.Name = "boxricevi"
        Me.boxricevi.ReadOnly = True
        Me.boxricevi.Size = New System.Drawing.Size(1103, 370)
        Me.boxricevi.TabIndex = 11
        Me.boxricevi.Text = ""
        '
        'boxinvia
        '
        Me.boxinvia.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxinvia.Location = New System.Drawing.Point(6, 397)
        Me.boxinvia.Name = "boxinvia"
        Me.boxinvia.Size = New System.Drawing.Size(1029, 26)
        Me.boxinvia.TabIndex = 12
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1041, 397)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 26)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Invia"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.boxinvia)
        Me.GroupBox1.Controls.Add(Me.boxricevi)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1115, 435)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chat"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.BabilonaChat___Reloaded.My.Resources.Resources.paypal
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(912, 494)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 36)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BabilonaChat___Reloaded.My.Resources.Resources.gplv3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1022, 494)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 36)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Suono
        '
        Me.Suono.AutoSize = True
        Me.Suono.Checked = True
        Me.Suono.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Suono.Location = New System.Drawing.Point(17, 501)
        Me.Suono.Name = "Suono"
        Me.Suono.Size = New System.Drawing.Size(143, 21)
        Me.Suono.TabIndex = 17
        Me.Suono.Text = "Suono messaggio"
        Me.Suono.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(166, 501)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 21)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Blink icona"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1139, 534)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Suono)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ipbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.portabox)
        Me.Controls.Add(Me.nickbox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chiavebox)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Babilonia Chat - Reloaded "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ipbox As System.Windows.Forms.TextBox
    Friend WithEvents portabox As System.Windows.Forms.TextBox
    Friend WithEvents chiavebox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nickbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxricevi As System.Windows.Forms.RichTextBox
    Friend WithEvents boxinvia As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Suono As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
