<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.txtCodigo = New System.Windows.Forms.TextBox()
    	Me.inventario = New System.Windows.Forms.ListView()
    	Me.producto = New System.Windows.Forms.ColumnHeader()
    	Me.precio = New System.Windows.Forms.ColumnHeader()
    	Me.cantidad = New System.Windows.Forms.ColumnHeader()
    	Me.btn_buscar = New System.Windows.Forms.Button()
    	Me.label1 = New System.Windows.Forms.Label()
    	Me.SuspendLayout
    	'
    	'Label2
    	'
    	Me.Label2.AutoSize = true
    	Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label2.Location = New System.Drawing.Point(63, 71)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(28, 18)
    	Me.Label2.TabIndex = 7
    	Me.Label2.Text = "ID"
    	'
    	'txtCodigo
    	'
    	Me.txtCodigo.Location = New System.Drawing.Point(92, 72)
    	Me.txtCodigo.Name = "txtCodigo"
    	Me.txtCodigo.Size = New System.Drawing.Size(81, 20)
    	Me.txtCodigo.TabIndex = 8
    	'
    	'inventario
    	'
    	Me.inventario.BackColor = System.Drawing.SystemColors.InactiveBorder
    	Me.inventario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.producto, Me.precio, Me.cantidad})
    	Me.inventario.Location = New System.Drawing.Point(63, 156)
    	Me.inventario.Name = "inventario"
    	Me.inventario.Size = New System.Drawing.Size(688, 70)
    	Me.inventario.TabIndex = 9
    	Me.inventario.UseCompatibleStateImageBehavior = false
    	Me.inventario.View = System.Windows.Forms.View.Details
    	Me.inventario.Visible = false
    	'
    	'producto
    	'
    	Me.producto.Text = "PRODUCTO"
    	Me.producto.Width = 415
    	'
    	'precio
    	'
    	Me.precio.Text = "PRECIO UNITARIO"
    	Me.precio.Width = 110
    	'
    	'cantidad
    	'
    	Me.cantidad.Text = "CANTIDAD EN INVENTARIO"
    	Me.cantidad.Width = 159
    	'
    	'btn_buscar
    	'
    	Me.btn_buscar.Location = New System.Drawing.Point(179, 71)
    	Me.btn_buscar.Name = "btn_buscar"
    	Me.btn_buscar.Size = New System.Drawing.Size(114, 23)
    	Me.btn_buscar.TabIndex = 10
    	Me.btn_buscar.Text = "Buscar"
    	Me.btn_buscar.UseVisualStyleBackColor = true
    	'
    	'label1
    	'
    	Me.label1.AutoSize = true
    	Me.label1.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.label1.Location = New System.Drawing.Point(59, 25)
    	Me.label1.Name = "label1"
    	Me.label1.Size = New System.Drawing.Size(407, 18)
    	Me.label1.TabIndex = 11
    	Me.label1.Text = "INVETARIO DE PRODUCTOS POR BÚSQUEDA"
    	'
    	'ConsultaInventario
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
    	Me.ClientSize = New System.Drawing.Size(800, 316)
    	Me.Controls.Add(Me.label1)
    	Me.Controls.Add(Me.btn_buscar)
    	Me.Controls.Add(Me.inventario)
    	Me.Controls.Add(Me.txtCodigo)
    	Me.Controls.Add(Me.Label2)
    	Me.Name = "ConsultaInventario"
    	Me.Text = "INVENTARIO POR PRODUCTO"
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Friend label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents producto As ColumnHeader
    Friend WithEvents precio As ColumnHeader
    Friend WithEvents cantidad As ColumnHeader
    Friend WithEvents inventario As ListView
    
End Class
