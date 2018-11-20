Public Class Form1
	Dim vtxt_Operacion(6) As TextBox
	Dim vbtn_Random (3) As Button
	Dim vbtn_Operador(3) As Button
	Dim txt_Operacion As TextBox
    Dim btn_Operador As Button
    Dim btn_Random As Button
    Dim current_Operator
    Dim counter As Integer
    Dim i As Integer
    Dim numeros_presionados As Array
    Private Sub btn_Inicio_Click(sender As Object, e As EventArgs) Handles btn_Inicio.Click
        btn_Inicio.Visible="false"
        txt_Indice.Text = "0"
        txt_Indice.Visible = "True"
        label5.Visible = "True"
        'PANEL PARA INGRESAR OPERACION
        For i = 0 To 6
            txt_Operacion = New TextBox()
            txt_Operacion.Size = New Size(40, 20)
            txt_Operacion.Location = New Point(150 + i * (txt_Operacion.Width + 5), 125)
            txt_Operacion.ReadOnly = true
            Controls.Add(txt_Operacion)
            vtxt_Operacion(i) = txt_Operacion
        Next
        'NUMEROS ALEATORIOS
        For i=0 To 3
        	Dim rnd As System.Random = New System.Random()
        	btn_Random = New Button()
            btn_Random.Size = New Size(40, 20)
            btn_Random.Location = New Point(200 + i * (btn_Random.Width + 5), 200)
            btn_Random.Text = rnd.Next(1, 10)
            Controls.Add(btn_Random)
            vbtn_Random(i) = btn_Random
            AddHandler btn_Random.Click, AddressOf btn_Random_Click
            
            'OPERADORES
            btn_Operador = New Button()
            btn_Operador.Size = New Size(40, 20)
            
            Select Case i
            	Case 0
            		btn_Operador.Text = "+"
            	Case 1
            		btn_Operador.Text = "-"
            	Case 2
            		btn_Operador.Text = "*"
            	Case 3
            		btn_Operador.Text = "/"
           	End Select
           	
           	btn_Operador.Location = New Point(200 + i * (btn_Operador.Width + 5), 225)
            Controls.Add(btn_Operador)
            vbtn_Operador(i) = btn_Operador
            AddHandler btn_Operador.Click, AddressOf btn_Operador_Click
            
        Next
        
    End Sub
    
    'CLICK A OPERADOR
    Private Sub btn_Operador_Click(sender As Object, e As EventArgs)
    	
    	'AUMENTA EL MOSTRADOR
   	 	If (counter > 1 And counter <= 6) Then
    			counter = counter + 1
   	 	End If
    	
    	Dim ind As Integer
        Dim btn_Temp_op As Button
        btn_Temp_op = CType(sender, Button)
        
        current_Operator = btn_Temp_op.Text
        
        'MUESTRA LOS OPERADORES EN LA BARRA DE OPERACION
        vtxt_Operacion(counter).Text = btn_Temp_op.Text
        
        'DESHABILITA LOS OPERADORES
        For ind=0 To 3
        	vbtn_Operador(ind).Enabled="false"
        Next
        
        
        'DESHABILITA LOS NUMERO YA UTILIZADOS
        numeros_presionados(counter-1) = Val(vtxt_Operacion(counter-1).Text)
   
        For ind=0 To numeros_presionados.Length
        	
        	For i=0 To vbtn_Random.Length
        		If (vbtn_Random(i).Text = numeros_presionados(ind).Text) Then
        			vbtn_Random(i).Enabled = "true"
        		End If
        	Next
        	
        Next
        
        
        'HABILITA LOS RANDOM
        For ind=0 To 3
        	vbtn_Random(ind).Enabled="true"
        Next
        
	End Sub
	
	
	'CLICK A RANDOM    
	Private Sub btn_Random_Click(sender As Object, e As EventArgs)
		
		Dim ind As Integer
        Dim btn_Temp As Button
        btn_Temp = CType(sender, Button)
        
        'AUMENTA EL MOSTRADOR 
        If (counter > 0 And counter <= 6) Then
			counter = counter + 1	
        End If
        
        'MUESTRA LOS OPERADORES EN LA BARRA DE OPERACION
        vtxt_Operacion(counter).Text = Val(btn_Temp.Text)
		
		'DESHABILITA LOS OPERADORES        
        For ind=0 To 3
        	vbtn_Random(ind).Enabled="false"
        Next
        
        'HABILITA LOS NUMEROS
        For ind=0 To 3
        	vbtn_Operador(ind).Enabled="true"
        Next
        
        'REALIZA OPERACION
        If (counter = 0) Then
			
			'MUESTRA EL PRIMER VALOR EN LA CELDA DE RESULTADO
			txt_Indice.Text = Val(vtxt_Operacion(counter).Text)
		
		Elseif (counter > 2) Then
			
			'REALIZA LA OPERACION DESPUES DE LA PRIMERA 
        	Select Case current_Operator
        		Case "+"
        			txt_Indice.Text = Val(txt_Indice.Text) + Val (vtxt_Operacion(counter).Text)
        		Case "-"
        			txt_Indice.Text = Val(txt_Indice.Text) - Val (vtxt_Operacion(counter).Text)
        		Case "*"
        			txt_Indice.Text = Val(txt_Indice.Text) * Val (vtxt_Operacion(counter).Text)
        		Case "/"
        			txt_Indice.Text = Val(txt_Indice.Text) / Val (vtxt_Operacion(counter).Text)
        	End Select
        	
		ElseIf (counter = 2) Then
			
			'REALIZA LA PRIMERA OPERACION			
        	 Select Case current_Operator
        		Case "+"
        			txt_Indice.Text = Val(vtxt_Operacion(counter-2).Text) + Val (vtxt_Operacion(counter).Text)
        		Case "-"
        			txt_Indice.Text = Val(vtxt_Operacion(counter-2).Text) - Val (vtxt_Operacion(counter).Text)
        		Case "*"
        			txt_Indice.Text = Val(vtxt_Operacion(counter-2).Text) * Val (vtxt_Operacion(counter).Text)
        		Case "/"
        			txt_Indice.Text = Val(vtxt_Operacion(counter-2).Text) / Val (vtxt_Operacion(counter).Text)
        	 End Select

        	 
		End If
		
        
        'AUMENTA EL CONTADOR DESPUÉS DEL PRIMER CASO
        If (counter = 0) Then
			counter = 1
        End If
        
    End Sub
    
End Class
