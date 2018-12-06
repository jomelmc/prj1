
Public Class ConsultaInventario
	Dim producto As ConsultaProducto.ProductoSoapClient = New ConsultaProducto.ProductoSoapClient()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim inventario As Producto.inventarioProductos = New Producto.inventarioProductos()
        Dim lista As ListViewItem
        Try
            inventario = producto.Consulta(txtCodigo.Text)

            inventario.Visible = True
            inventario.Items.Clear()

            lista = New ListViewItem("*" & inventario.Description)
            lista.SubItems.Add("*" & inventario.SalePrice)
            lista.SubItems.Add("*" & inventario.CantExistence)
            inventario.Items.Add(lista) ' MUESTRA LA CONSULTA 

            Borrar()
        Catch ex As Exception
            MsgBox("Producto no encontrado")
        End Try
    End Sub
    'BORRA EL TEXTO DEL TEXTVIEW txtCodProd
    Public Function Borrar()
        txtCodigo.Text = ""
    End Function
End Class