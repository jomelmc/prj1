Public Class ConsultarNuevosPedidos
    Dim prod As PedidoProd.WebService2SoapClient = New PedidoProd.WebService2SoapClient()
    Dim regiProd As PedidoProd.inventarioProductos = New PedidoProd.inventarioProductos()
    Dim lista As ListViewItem

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            lv_productos.Visible = True
            lv_productos.Items.Clear()

            'ENVIA EL CODIGO AL METODO QUE TRAE LA INFO DEL PRODUCTO
            regiProd = prod.PointReorder(txtCodProd.Text)
            lista = New ListViewItem("*" & regiProd.Description)
            lista.SubItems.Add("*" & regiProd.CantExistence)
            lista.SubItems.Add("*" & regiProd.CantReOrden)
            'ENVIA EL CODIGO AL METODO QUE HACE EL CALCULO PARA EL PEDIDO
            regiProd = prod.CantPedir(txtCodProd.Text)
            lista.SubItems.Add("*" & regiProd.CantPedir)

            'VALIDA SI BD NO TRAE DATOS
            If lista.ToString <> "ListViewItem: {*}" Then
                lv_productos.Items.Add(lista) ' MUESTRA LA CONSULTA 
            Else
                MsgBox("La cantidad de existencia de código producto: " & txtCodProd.Text & " es mayor al punto de reorden.")
            End If
            Borrar()

        Catch ex As Exception
            MsgBox("Producto no encontrado" & ex.ToString())
        End Try
    End Sub
    'BORRA CONTENIDO DEL TEXTVIEW txtCodProd
    Public Function Borrar()
        txtCodProd.Text = ""
    End Function
End Class