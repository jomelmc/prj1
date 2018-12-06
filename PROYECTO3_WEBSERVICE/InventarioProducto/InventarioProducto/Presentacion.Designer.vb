'
' Created by SharpDevelop.
' User: jmcdonald
' Date: 12/06/2018
' Time: 01:19 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Presentacion
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"),System.Drawing.Image)
		Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pictureBox1.Location = New System.Drawing.Point(43, 69)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(138, 124)
		Me.pictureBox1.TabIndex = 25
		Me.pictureBox1.TabStop = false
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label4.Location = New System.Drawing.Point(189, 170)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(533, 23)
		Me.label4.TabIndex = 24
		Me.label4.Text = "Nombre: Jomel Mc Donald   Cédula: 3-740-1458   Grupo: 1LS-232"
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label3.Location = New System.Drawing.Point(189, 128)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(283, 23)
		Me.label3.TabIndex = 23
		Me.label3.Text = "Licenciatura en Desarollo de Software"
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label2.Location = New System.Drawing.Point(187, 103)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(665, 25)
		Me.label2.TabIndex = 22
		Me.label2.Text = "FACULTAD DE INGENIERÍA DE SISTEMAS COMPUTACIONALES"
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label1.Location = New System.Drawing.Point(187, 69)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(654, 34)
		Me.label1.TabIndex = 21
		Me.label1.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
		'
		'Presentacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(894, 262)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "Presentacion"
		Me.Text = "Form2"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Friend label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
