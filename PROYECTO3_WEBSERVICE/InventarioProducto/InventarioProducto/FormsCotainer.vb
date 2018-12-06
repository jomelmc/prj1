Public Class FormsCotainer
    
    Sub ConsultarInventarioToolStripMenuItemClick(sender As Object, e As EventArgs)
    	Dim inventario As ConsultaInventario = New ConsultaInventario()
    	inventario.WindowState = FormWindowState.Maximized
        inventario.Show()
        inventario.MdiParent = Me
    End Sub
    
    Sub ConsultarNuevosPedidosToolStripMenuItemClick(sender As Object, e As EventArgs)
    	Dim reorden As ConsultarNuevosPedidos = New ConsultarNuevosPedidos()
    	reorden.WindowState = FormWindowState.Maximized
        reorden.Show()
        reorden.MdiParent = Me
    End Sub
    
    
    Sub PresentacionToolStripMenuItemClick(sender As Object, e As EventArgs)
    	Dim Datos As Presentacion = New Presentacion ()
    	Datos.WindowState =  FormWindowState.Maximized
    	Datos.Show()
    	Datos.MdiParent = Me
    End Sub
End Class
