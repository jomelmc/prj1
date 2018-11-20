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
    	Me.btn_Inicio = New System.Windows.Forms.Button()
    	Me.txt_Indice = New System.Windows.Forms.TextBox()
    	Me.label4 = New System.Windows.Forms.Label()
    	Me.label3 = New System.Windows.Forms.Label()
    	Me.label2 = New System.Windows.Forms.Label()
    	Me.label1 = New System.Windows.Forms.Label()
    	Me.label5 = New System.Windows.Forms.Label()
    	Me.SuspendLayout
    	'
    	'btn_Inicio
    	'
    	Me.btn_Inicio.Font = New System.Drawing.Font("Montserrat", 36!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btn_Inicio.Location = New System.Drawing.Point(287, 125)
    	Me.btn_Inicio.Name = "btn_Inicio"
    	Me.btn_Inicio.Size = New System.Drawing.Size(171, 66)
    	Me.btn_Inicio.TabIndex = 0
    	Me.btn_Inicio.Text = "Inicio"
    	Me.btn_Inicio.UseVisualStyleBackColor = true
    	'
    	'txt_Indice
    	'
    	Me.txt_Indice.Location = New System.Drawing.Point(496, 125)
    	Me.txt_Indice.Name = "txt_Indice"
    	Me.txt_Indice.ReadOnly = true
    	Me.txt_Indice.Size = New System.Drawing.Size(40, 20)
    	Me.txt_Indice.TabIndex = 1
    	Me.txt_Indice.Visible = false
    	'
    	'label4
    	'
    	Me.label4.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label4.Location = New System.Drawing.Point(160, 69)
    	Me.label4.Name = "label4"
    	Me.label4.Size = New System.Drawing.Size(396, 23)
    	Me.label4.TabIndex = 11
    	Me.label4.Text = "Nombre: Jomel Mc Donald   Cédula: 3-740-1458   Grupo: 1LS-232"
    	'
    	'label3
    	'
    	Me.label3.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label3.Location = New System.Drawing.Point(242, 46)
    	Me.label3.Name = "label3"
    	Me.label3.Size = New System.Drawing.Size(237, 23)
    	Me.label3.TabIndex = 10
    	Me.label3.Text = "Licenciatura en Desarollo de Software"
    	'
    	'label2
    	'
    	Me.label2.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label2.Location = New System.Drawing.Point(218, 31)
    	Me.label2.Name = "label2"
    	Me.label2.Size = New System.Drawing.Size(298, 23)
    	Me.label2.TabIndex = 9
    	Me.label2.Text = "FACULTAD DE INGENIERÍA DE SISTEMAS COMPUTACIONALES"
    	'
    	'label1
    	'
    	Me.label1.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label1.Location = New System.Drawing.Point(172, 13)
    	Me.label1.Name = "label1"
    	Me.label1.Size = New System.Drawing.Size(383, 23)
    	Me.label1.TabIndex = 8
    	Me.label1.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
    	'
    	'label5
    	'
    	Me.label5.Font = New System.Drawing.Font("Montserrat", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label5.Location = New System.Drawing.Point(464, 122)
    	Me.label5.Name = "label5"
    	Me.label5.Size = New System.Drawing.Size(30, 30)
    	Me.label5.TabIndex = 12
    	Me.label5.Text = "="
    	Me.label5.Visible = false
    	'
    	'Form1
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(753, 262)
    	Me.Controls.Add(Me.label5)
    	Me.Controls.Add(Me.label4)
    	Me.Controls.Add(Me.label3)
    	Me.Controls.Add(Me.label2)
    	Me.Controls.Add(Me.label1)
    	Me.Controls.Add(Me.txt_Indice)
    	Me.Controls.Add(Me.btn_Inicio)
    	Me.Name = "Form1"
    	Me.Text = "Form1"
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Private label5 As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label

    Friend WithEvents btn_Inicio As Button
    Friend WithEvents txt_Indice As TextBox
End Class
