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
    	Me.resultado = New System.Windows.Forms.Label()
    	Me.signo_igual = New System.Windows.Forms.Label()
    	Me.btn_borrar = New System.Windows.Forms.Button()
    	Me.btn_borrar_todo = New System.Windows.Forms.Button()
    	Me.btn_resolver = New System.Windows.Forms.Button()
    	Me.btn_siguiente = New System.Windows.Forms.Button()
    	Me.ganar = New System.Windows.Forms.Label()
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
    	Me.txt_Indice.Location = New System.Drawing.Point(496, 155)
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
    	'resultado
    	'
    	Me.resultado.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.resultado.Location = New System.Drawing.Point(496, 123)
    	Me.resultado.Name = "resultado"
    	Me.resultado.Size = New System.Drawing.Size(40, 29)
    	Me.resultado.TabIndex = 13
    	Me.resultado.Visible = false
    	'
    	'signo_igual
    	'
    	Me.signo_igual.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.signo_igual.Location = New System.Drawing.Point(470, 123)
    	Me.signo_igual.Name = "signo_igual"
    	Me.signo_igual.Size = New System.Drawing.Size(24, 23)
    	Me.signo_igual.TabIndex = 14
    	Me.signo_igual.Text = "="
    	Me.signo_igual.Visible = false
    	'
    	'btn_borrar
    	'
    	Me.btn_borrar.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btn_borrar.Location = New System.Drawing.Point(577, 200)
    	Me.btn_borrar.Name = "btn_borrar"
    	Me.btn_borrar.Size = New System.Drawing.Size(80, 23)
    	Me.btn_borrar.TabIndex = 15
    	Me.btn_borrar.Text = "Borrar"
    	Me.btn_borrar.UseVisualStyleBackColor = true
    	Me.btn_borrar.Visible = false
    	AddHandler Me.btn_borrar.Click, AddressOf Me.Btn_borrarClick
    	'
    	'btn_borrar_todo
    	'
    	Me.btn_borrar_todo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btn_borrar_todo.Location = New System.Drawing.Point(577, 231)
    	Me.btn_borrar_todo.Name = "btn_borrar_todo"
    	Me.btn_borrar_todo.Size = New System.Drawing.Size(80, 23)
    	Me.btn_borrar_todo.TabIndex = 16
    	Me.btn_borrar_todo.Text = "Borrar todo"
    	Me.btn_borrar_todo.UseVisualStyleBackColor = true
    	Me.btn_borrar_todo.Visible = false
    	AddHandler Me.btn_borrar_todo.Click, AddressOf Me.Btn_borrar_todoClick
    	'
    	'btn_resolver
    	'
    	Me.btn_resolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btn_resolver.Location = New System.Drawing.Point(496, 200)
    	Me.btn_resolver.Name = "btn_resolver"
    	Me.btn_resolver.Size = New System.Drawing.Size(75, 54)
    	Me.btn_resolver.TabIndex = 17
    	Me.btn_resolver.Text = "Resolver"
    	Me.btn_resolver.UseVisualStyleBackColor = true
    	Me.btn_resolver.Visible = false
    	AddHandler Me.btn_resolver.Click, AddressOf Me.Btn_resolverClick
    	'
    	'btn_siguiente
    	'
    	Me.btn_siguiente.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.btn_siguiente.Location = New System.Drawing.Point(496, 260)
    	Me.btn_siguiente.Name = "btn_siguiente"
    	Me.btn_siguiente.Size = New System.Drawing.Size(161, 36)
    	Me.btn_siguiente.TabIndex = 18
    	Me.btn_siguiente.Text = "Siguiente >"
    	Me.btn_siguiente.UseVisualStyleBackColor = true
    	Me.btn_siguiente.Visible = false
    	'
    	'ganar
    	'
    	Me.ganar.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.ganar.Location = New System.Drawing.Point(558, 123)
    	Me.ganar.Name = "ganar"
    	Me.ganar.Size = New System.Drawing.Size(141, 46)
    	Me.ganar.TabIndex = 19
    	'
    	'Form1
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(742, 333)
    	Me.Controls.Add(Me.ganar)
    	Me.Controls.Add(Me.btn_siguiente)
    	Me.Controls.Add(Me.btn_resolver)
    	Me.Controls.Add(Me.btn_borrar_todo)
    	Me.Controls.Add(Me.btn_borrar)
    	Me.Controls.Add(Me.signo_igual)
    	Me.Controls.Add(Me.resultado)
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
    Private ganar As System.Windows.Forms.Label
    Private btn_siguiente As System.Windows.Forms.Button
    Private btn_resolver As System.Windows.Forms.Button
    Private btn_borrar_todo As System.Windows.Forms.Button
    Private btn_borrar As System.Windows.Forms.Button
    Private signo_igual As System.Windows.Forms.Label
    Private resultado As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label

    Friend WithEvents btn_Inicio As Button
    Friend WithEvents txt_Indice As TextBox
End Class
