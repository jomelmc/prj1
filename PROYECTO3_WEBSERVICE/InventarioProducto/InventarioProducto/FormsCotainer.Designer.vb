<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormsCotainer
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
    	Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    	Me.presentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.consultarInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.consultarNuevosPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.MenuStrip1.SuspendLayout
    	Me.SuspendLayout
    	'
    	'MenuStrip1
    	'
    	Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.presentacionToolStripMenuItem, Me.consultarInventarioToolStripMenuItem, Me.consultarNuevosPedidosToolStripMenuItem})
    	Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    	Me.MenuStrip1.Name = "MenuStrip1"
    	Me.MenuStrip1.Size = New System.Drawing.Size(893, 24)
    	Me.MenuStrip1.TabIndex = 1
    	'
    	'presentacionToolStripMenuItem
    	'
    	Me.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem"
    	Me.presentacionToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
    	Me.presentacionToolStripMenuItem.Text = "Presentacion"
    	AddHandler Me.presentacionToolStripMenuItem.Click, AddressOf Me.PresentacionToolStripMenuItemClick
    	'
    	'consultarInventarioToolStripMenuItem
    	'
    	Me.consultarInventarioToolStripMenuItem.Name = "consultarInventarioToolStripMenuItem"
    	Me.consultarInventarioToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
    	Me.consultarInventarioToolStripMenuItem.Text = "Consultar inventario"
    	AddHandler Me.consultarInventarioToolStripMenuItem.Click, AddressOf Me.ConsultarInventarioToolStripMenuItemClick
    	'
    	'consultarNuevosPedidosToolStripMenuItem
    	'
    	Me.consultarNuevosPedidosToolStripMenuItem.Name = "consultarNuevosPedidosToolStripMenuItem"
    	Me.consultarNuevosPedidosToolStripMenuItem.Size = New System.Drawing.Size(156, 20)
    	Me.consultarNuevosPedidosToolStripMenuItem.Text = "Consultar nuevos pedidos"
    	AddHandler Me.consultarNuevosPedidosToolStripMenuItem.Click, AddressOf Me.ConsultarNuevosPedidosToolStripMenuItemClick
    	'
    	'Form1
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
    	Me.ClientSize = New System.Drawing.Size(893, 270)
    	Me.Controls.Add(Me.MenuStrip1)
    	Me.IsMdiContainer = true
    	Me.MainMenuStrip = Me.MenuStrip1
    	Me.Name = "Form1"
    	Me.Text = "PROYECTO FINAL DS8 - INVENTARIO DE DISTRIBUIDORA"
    	AddHandler Load, AddressOf Me.Form1Load
    	Me.MenuStrip1.ResumeLayout(false)
    	Me.MenuStrip1.PerformLayout
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Private presentacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private consultarNuevosPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private consultarInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    
    
    Sub Form1Load(sender As Object, e As EventArgs)
		Dim Datos As Presentacion = New Presentacion ()
    	Datos.WindowState =  FormWindowState.Maximized
    	Datos.Show()
    	Datos.MdiParent = Me    	
    End Sub
End Class
