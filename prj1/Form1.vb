Public Class Form1
	Dim vtxt_Operacion(6) As TextBox
	Dim vbtn_Random (3) As Button
	Dim vbtn_Operador(3) As Button
	Dim txt_Operacion As TextBox
    Dim btn_Operador As Button
    Dim btn_Random As Button
    Dim current_Operator
    Dim counter As Integer
    Dim counter_btn_press = 0
    Dim random_temp
    Dim v_operador (3)
    Dim i As Integer
    Dim id_random As Integer
    Dim random_anterior (3)
    Dim indic As Integer
    Dim numeros_presionados(3)
    Dim ram As New System.Random()
    Dim op_ram As New System.Random()
    Dim num_ram As New System.Random()
    Dim numero_resultado
    Dim operador_resultado
    Dim result (6)
    Dim resultado_pantalla = 0
    Dim resultado_parcial
    Dim count_rep = 0
    Dim indict = 0
    Dim indict_op = 0
    Dim ind = 1
    Private Sub btn_Inicio_Click(sender As Object, e As EventArgs) Handles btn_Inicio.Click
        btn_Inicio.Visible= "True"
        txt_Indice.Text = "0"
        txt_Indice.Visible = "True"
		signo_igual.Visible = "True"
        resultado.Visible = "True"
        btn_Inicio.Location = New Point(200, 250)
        btn_Inicio.Height = 65
        btn_Inicio.Width = 175
        btn_borrar.Visible = "True"
        btn_borrar_todo.Visible = "True"
        btn_siguiente.Visible = "True"
        btn_resolver.Visible = "True"
        btn_Inicio.Enabled = "False"
        resultado_parcial = New OperacionMatematica()
        
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
        Dim it = 0
        For i=0 To 3
        	random_temp = ram.Next(1, 10)
        	
    		Do While (it > 0 And it < 5)

    			If (random_temp = random_anterior(it-1))
    				count_rep = count_rep + 1
    			End If
    			
    			If ((it = 4) And (count_rep > 0)) Then
    				random_temp = ram.Next(1, 10)
    				it = 0
    				count_rep = 0
    			End If    			
    			it = it + 1
    		Loop
    		it = 1
        	random_anterior(i) = random_temp
        	btn_Random = New Button()
            btn_Random.Size = New Size(40, 20)
            btn_Random.Location = New Point(200 + i * (btn_Random.Width + 5), 200)
            btn_Random.Text = random_temp
            
            'IDENTIFICADOR DE NUMEROS RANDOMS
            Select Case id_random
            	Case 0
            		btn_Random.Tag = "1"
            	Case 1
            		btn_Random.Tag = "2"
            	Case 2
            		btn_Random.Tag = "3"
            	Case 3
            		btn_Random.Tag = "4"
            End Select
            
            Controls.Add(btn_Random)
            vbtn_Random(i) = btn_Random
            AddHandler btn_Random.Click, AddressOf btn_Random_Click
            
            'OPERADORES
            btn_Operador = New Button()
            btn_Operador.Size = New Size(40, 20)
            
            Select Case i
            	Case 0
            		btn_Operador.Text = "+"
            		btn_Operador.Tag = "1"
            	Case 1
            		btn_Operador.Text = "-"
            		btn_Operador.Tag = "2"
            	Case 2
            		btn_Operador.Text = "*"
            		btn_Operador.Tag = "3"
            	Case 3
            		btn_Operador.Text = "/"
            		btn_Operador.Tag = "4"
            End Select
            
            v_operador (i) = btn_Operador.Text       
           	btn_Operador.Location = New Point(200 + i * (btn_Operador.Width + 5), 225)
            Controls.Add(btn_Operador)
            vbtn_Operador(i) = btn_Operador
            AddHandler btn_Operador.Click, AddressOf btn_Operador_Click

        Next
        
        count_rep = 0
        For indic=0 To 3
        	random_anterior(indic) = 0
        Next
        
        'SE GENERA LA SOLUCIÓN
        Dim ind = 1
        Do While (ind < 8)
        	If (ind > 1) Then
        		ind = ind + 1
        	End If
        	numero_resultado = Val(num_ram.Next(1, 4))
        	operador_resultado = Val(op_ram.Next(1, 4))
	    	
	    	'GENERA UN RAMDOM PARA ESCOGER UN NÚMERO
	    	Do While (indict > 0 And indict < 5)
			
				If (random_temp = random_anterior(indict-1))
					count_rep = count_rep + 1
				End If
				
				If ((it = 4) And (count_rep > 0)) Then
					numero_resultado = num_ram.Next(1, 5)
					indict = 0
					count_rep = 0
				End If    			
				indict = indict + 1
			Loop
			indict = 1
			count_rep = 0
			
			'GENERA UN RAMDOM PARA ESCOGER UN OPERADOR
	    	Do While (indict_op > 0 And indict_op < 5)
			
				If (random_temp = random_anterior(indict_op -1))
					count_rep = count_rep + 1
				End If
				
				If ((it = 4) And (count_rep > 0)) Then
					operador_resultado = num_ram.Next(1, 5)
					indict_op = 0
					count_rep = 0
				End If    			
				indict_op = indict_op + 1
			Loop
			indict_op = 1
	    	count_rep = 0
	    	
	    	'ESCOGE EL PRIMER NÚMERO
	    	indic = 0
    		If (ind = 1) Then
	    		Do While (indic <= 3)
	        		
	        		If (numero_resultado = Val(vbtn_Random(indic).Tag)) Then
	        			count_rep = count_rep + 1
	        		End If
	        		
	        		If (count_rep > 0) Then
	        			result(ind-1) = vbtn_Random(indic).Text
	        			indic = 4
	        		End If
	        		indic = indic + 1
	    		Loop
	    		count_rep = 0
	    		resultado_pantalla = result(ind-1)
	    
    		
    		ElseIf (ind = 3) Then

    			'ESCOGE EL PRIMER OPERADOR
    			For indic=0 To 3
    				If (operador_resultado = Val(vbtn_Operador(indic).Tag)) Then
	    				count_rep = count_rep + 1
	    			End If
	    			
	    			If (count_rep > 0) Then
	        			result(ind-2) = vbtn_Operador(indic).Text
	        		End If
    			Next
    			count_rep = 0
    			
    			'ESCOGE EL SEGUNDO NÚMERO
	    		For indic=0 To 3
	        		
	        		If (numero_resultado = Val(vbtn_Random(indic).Tag)) Then
	        			count_rep = count_rep + 1
	        		End If
	        		
	        		If (count_rep > 0) Then
	        			result(ind-1) = vbtn_Random(indic).Text
	        		End If
	        	Next
	        	count_rep = 0
	        	
	        	'RESUELVE LA PRIMERA OPERACION
    			resultado_pantalla = resultado_parcial.ResolverOperacion(Val(result(ind-3)), result(ind-2), Val(result(ind-1)))
    			
        	'RESUELVE LAS OPERACIONES SIEMPRE QUE LAS ANTERIORES NO HAYAN RESULTADO EN DECIMAL
    		ElseIf(ind > 3 And (((resultado_pantalla * 100) Mod 100) = 0)) Then
    			
    			If (ind <= 7) Then 
	    			'ESCOGE NÚMERO
	    			For indic=0 To 3
			        	If (numero_resultado = Val(vbtn_Random(indic).Tag)) Then
		        			count_rep = count_rep + 1
		        		End If
		        		
		        		If (count_rep > 0) Then
		        			result(ind-1) = vbtn_Random(indic).Text
		        		End If
	    			Next
	    			count_rep = 0
	    			
	    			'ESCOGE OPERADOR
	    			For indic=0 To 2
		    			If (operador_resultado = Val(vbtn_Operador(indic).Tag)) Then
		    				count_rep = count_rep + 1
		    			End If
		    			
		    			If (count_rep > 0) Then
		        			result(ind-2) = vbtn_Operador(indic).Text
		        		End If
	    			Next
	    			count_rep = 0
	    			
	    			'REALIZA OPERACION
	    			resultado_pantalla = resultado_parcial.ResolverOperacion(Val(resultado_pantalla), result(ind-2), Val(result (ind-1)))
	    			
	    		'REINICIA LA OPERACIÓN SIN RESULTA EN DECIMAL
        		Elseif (((resultado_pantalla * 100) Mod 100) > 0)
        			ind = 0
        		End If
        		
        	End If 
        	resultado.Text = resultado_pantalla
        	ind = ind + 1
        Loop
        ind=0
        
        If ((Val(txt_Indice.Text) = Val(resultado.Text)) And (Val(txt_Indice.Text) <> 0)) Then
        	ganar.Text = "GANASTE!"
        ElseIf (counter > 5 And ((Val(txt_Indice.Text) <> Val(resultado.Text)) And (Val(txt_Indice.Text) <>0)))
        	ganar.Text = "PERDISTE!"
        End If
        
    End Sub
    
    
    'CLICK A OPERADOR
    Private Sub btn_Operador_Click(sender As Object, e As EventArgs)
    	
    	If (counter > 1 And counter <= 6) Then
    		counter = counter + 1
    	Else
    		If (counter = 0) Then
    			counter = counter + 1
    		End If
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
        
        'HABILITA LOS RANDOM
        For ind=0 To 3
        	vbtn_Random(ind).Enabled="true"
        Next
        
        
        'DESHABILITA LOS NUMERO YA UTILIZADOS
   
         For ind=0 To 3
        	For indic=1 To vbtn_Random.Length
        		
        		If (vbtn_Random(indic-1).Text = numeros_presionados(ind)) Then
        			vbtn_Random(indic-1).Enabled = "false"        			
        		End If
        		
        	Next
         Next
       
	End Sub
	
	
	'CLICK A RANDOM    
	Private Sub btn_Random_Click(sender As Object, e As EventArgs)
		
		Dim RealizarOperacion As New OperacionMatematica()
		Dim ind As Integer
        Dim btn_Temp As Button
        btn_Temp = CType(sender, Button)
        
        'ALMACENA LOS NÚMEROS PRESIONADOS
        counter_btn_press = counter_btn_press + 1
        numeros_presionados(counter_btn_press -1) = btn_Temp.Text
        
        'AUMENTA EL MOSTRADOR 
        If (counter > 0 And counter <= 6) Then
			counter = counter + 1	
        End If
        
        'MUESTRA LOS OPERADORES EN LA BARRA DE OPERACION
        vtxt_Operacion(counter).Text = Val(btn_Temp.Text)
		
		'DESHABILITA LOS NUMEROS        
        For ind=0 To 3
        	vbtn_Random(ind).Enabled="false"
        Next
        
        'HABILITA LOS OPERADORES
        For ind=0 To 3
        	vbtn_Operador(ind).Enabled="true"
        Next
        
        'REALIZA OPERACION
        If (counter = 0) Then
			
			'MUESTRA EL PRIMER VALOR EN LA CELDA DE RESULTADO
			txt_Indice.Text = Val(vtxt_Operacion(counter).Text)
		
		Elseif (counter > 2) Then
			
			'REALIZA LA OPERACION DESPUES DE LA PRIMERA 
			txt_Indice.Text = RealizarOperacion.ResolverOperacion(Val((txt_Indice.Text)), current_Operator, Val(vtxt_Operacion(counter).Text))
        	
		ElseIf (counter = 2) Then
			
			'REALIZA LA PRIMERA OPERACION
			txt_Indice.Text = RealizarOperacion.ResolverOperacion(Val(vtxt_Operacion(counter-2).Text), current_Operator, Val(vtxt_Operacion(counter).Text))
        	 
		End If
		
        
        'AUMENTA EL CONTADOR DESPUÉS DEL PRIMER CASO
        If (counter = 0) Then
			counter = 1
        End If
        
    End Sub
    
    
    Sub Btn_borrarClick(sender As Object, e As EventArgs)
    	
    	'VOVLER AL ESTADO DESPUÉS DE PRESIONADO UN OPERADOR
    	If ((counter Mod 2) = 0) Then
	    	
    		'DESHABILITA LOS OPERADORES
	        For ind=0 To 3
	        	vbtn_Operador(ind).Enabled="false"
	        Next
	        
	        'HABILITA LOS RANDOM
	        For ind=0 To 3
	        	vbtn_Random(ind).Enabled="true"
	        Next
	        
	       'DESHABILITA LOS NUMEROS YA UTILIZADOS
	    	For ind=0 To 3
	        	For indic=1 To vbtn_Random.Length
	        		
	        		If (vbtn_Random(indic-1).Text = numeros_presionados(ind)) Then
	        			vbtn_Random(indic-1).Enabled = "false"        			
	        		End If
	        		
	        	Next
	    	Next
	    	
	    'VOLVER AL ESTADO DESPUÉS DE PRESIONADO UN NUMERO
    	Else
    		'DESHABILITA LOS NUMEROS        
	        For ind=0 To 3
	        	vbtn_Random(ind).Enabled="false"
	        Next
	        
	        'HABILITA LOS OPERADORES
	        For ind=0 To 3
	        	vbtn_Operador(ind).Enabled="true"
	        Next
	        
    	End If
    	
    	vtxt_Operacion(counter).Text = ""
    	If (counter > 0 And counter <= 7) Then
    		counter = counter - 1
    	End If
    End Sub
    
    
    Sub Btn_borrar_todoClick(sender As Object, e As EventArgs)
    	
    	'LIMPIA LOS CAMPOS
    	For i=1 To vtxt_Operacion.Length
    		vtxt_Operacion(i-1).Text = ""
    	Next
    	
    	'DESHABILITA LOS OPERADORES
        For ind=0 To 3
        	vbtn_Operador(ind).Enabled="false"
        Next
        
        'HABILITA LOS RANDOM
        For ind=0 To 3
        	vbtn_Random(ind).Enabled="true"
        Next
        
        'LIMPIA LA LISTA DE NUMEROS PRESIONADOS
        For ind=1 To numeros_presionados.Length
        	numeros_presionados(ind - 1) = ""
        Next
        
	
	counter = 0
	txt_Indice.Text = 0
	counter_btn_press = 0
	
    End Sub
    
    Sub Btn_resolverClick(sender As Object, e As EventArgs)
    	
    	For i=1 To vtxt_Operacion.Length
    		vtxt_Operacion(i-1).Text = result (i-1)
    		txt_Indice.Text = resultado_pantalla
    	Next
    	
    End Sub

End Class

Public Class OperacionMatematica
	
	Function ResolverOperacion (numero1, operador, numero2) As Double
		
		Dim result As Double
		
	   Select Case operador
    		Case "+"
    			result = numero1 + numero2
    		Case "-"
    			result = numero1 - numero2
    		Case "*"
    			result = numero1 * numero2
    		Case "/"
    			result = numero1 / numero2
	   End Select
	   
	   Return result
	   
	End Function
		
End Class
