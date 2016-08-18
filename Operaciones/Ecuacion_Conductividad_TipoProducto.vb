Public Class Ecuacion_Conductividad_TipoProducto
    'Variable que indica el producto que fue escogido
    Dim seleccion As String

    'Constructor, necesario para inicialicar la vista de la imagen
    Sub New(ByVal image As String)
        Me.seleccion = image
        InitializeComponent()

        'Inicializar textos y labels no visibles hasta escoger variable indicada
        lblTemperatura.Visible = False
        txtTemperatura.Visible = False
        lblTempCongelacion.Visible = False
        txtTempCongelacion.Visible = False

        'Ruta de la imagen
        Foto_Ecuacion.Image = Inicio.GetImgResource(seleccion)

    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim oForm As Conductividad
        oForm = New Conductividad
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Btn_calcular_ecuacion_Click(sender As Object, e As EventArgs) Handles Btn_calcular_ecuacion.Click

        'Variables UI(interfaz de usuario)
        Dim humedad As Double
        Dim hBaseSeca As Double
        Dim temperatura As Double = 0
        Dim temperaturaCongelacion As Double = 0

        'Variables calculadas
        Dim conductividad As Double

        'Variable switch: Si =1 permite el cálculo de la conductancia, si =0 es porque se debe corregir algún valor de entrada 
        Dim continuar = 1

        'Validación: Si el campo de ingreso de humedad está vacío, avisa
        If String.IsNullOrEmpty(Me.txtHumedad.Text) Then
            If seleccion <> "Pan blanco" Then
                Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                MsgBox(msg)
                Dim style = MsgBoxStyle.Critical
                continuar = 0
            End If
        End If
        If seleccion = "Pan blanco" Then
            If String.IsNullOrEmpty(Me.txtTemperatura.Text) Then
                Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                MsgBox(msg)
                Dim style = MsgBoxStyle.Critical
                continuar = 0
            End If
        End If
        If seleccion <> "Pan blanco" Then
            If String.IsNullOrEmpty(Me.txtHumedad.Text) Then
                continuar = 0

            ElseIf Me.txtHumedad.Text < 0 Then
                Dim msg = "¡Ingrese fracciones mayores o iguales a 0 !"
                MsgBox(msg)
                Dim style = MsgBoxStyle.Critical
                continuar = 0


            ElseIf txtHumedad.Text > 1 Then
                Dim msg = "¡Ingrese fracciones menores o iguales a 1 !"
                    MsgBox(msg)
                    Dim style = MsgBoxStyle.Critical
                    continuar = 0
                End If
            End If

        'Validación: Si el parámetro =1 se han validado valores incorrectos en el ingreso 
        If continuar = 1 Then

            'Leer el valor de temperatura ingresado por el usuario
            If seleccion <> "Pan blanco" Then
                humedad = txtHumedad.Text
            End If


            'Realizar cálculo de conductancia para cada producto según escogencia del usuario
            Select Case Me.seleccion

                Case "Remolacha"
                    conductividad = 0.103 + 0.0051 * humedad
                Case "Zanahoria"
                    conductividad = 0.172 + 0.0045 * humedad
                Case "Perejil"
                    conductividad = 0.16 + 0.0043 * humedad
                Case "Apio"
                    conductividad = 0.135 + 0.0051 * humedad
                Case "Papaya"
                    conductividad = 0.0645 * Math.Exp(0.0279) * humedad
                Case "Melón"
                    conductividad = 0.206 * Math.Log(humedad) + 0.1215
                Case "Manzana"
                    conductividad = 0.49 - 0.443 * Math.Exp(-0.206) * humedad
                Case "Pera"
                    hBaseSeca = txtHumedad.Text
                    conductividad = 0.4875 - (0.0566 / hBaseSeca) + 0.0227 * Math.Log(hBaseSeca)
                Case "Carne molida"
                    'Validación: Si el valor ingresado de temperatura es nulo o está vacio, avisa
                    If String.IsNullOrEmpty(Me.txtTemperatura.Text) Then
                        Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                        MsgBox(msg)
                        Dim style = MsgBoxStyle.Critical
                        continuar = 0
                    End If

                    If continuar = 1 Then
                        temperatura = txtTemperatura.Text
                        conductividad = 0.049 + 0.0034 * humedad + 0.00237 * temperatura
                    End If
                Case "Surimi"
                    If String.IsNullOrEmpty(Me.txtTemperatura.Text) Then
                        Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                        MsgBox(msg)
                        Dim style = MsgBoxStyle.Critical
                        continuar = 0
                    End If
                    If continuar = 1 Then
                        conductividad = 1.33 - 4.82 * (10 ^ -3) * temperatura + (5 * 10 ^ -5) * (temperatura ^ 2) - 2.45 * (10 ^ -2) * humedad + 1.7 * (10 ^ -4) * humedad ^ 2 + 2.4 * (10 ^ -5) * temperatura * humedad
                    End If
                Case "Uva pasa"
                    conductividad = 0.069 + 0.404 * humedad
                Case "Zumo de frutas (fraccion agua)"
                    conductividad = 2.44 * humedad + 0.26 * (1 - humedad)

                Case "Zumo de frutas (fraccion agua, temperatura, temp. congelacion)"
                    If String.IsNullOrEmpty(Me.txtTemperatura.Text) Or
                        String.IsNullOrEmpty(Me.txtTempCongelacion.Text) Then
                        Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                        MsgBox(msg)
                        Dim style = MsgBoxStyle.Critical
                        continuar = 0
                    End If

                    If continuar = 1 Then
                        temperatura = txtTemperatura.Text
                        temperaturaCongelacion = txtTempCongelacion.Text
                        conductividad = 1.745 * humedad * (1 - (temperaturaCongelacion / temperatura)) + 0.233
                    End If

                Case "Carnes (fraccion agua)"
                    conductividad = 0.08 + 0.52 * humedad

                Case "Carnes (fraccion agua, temperatura)"
                    If String.IsNullOrEmpty(Me.txtTemperatura.Text) Then
                        Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                        MsgBox(msg)
                        Dim style = MsgBoxStyle.Critical
                        continuar = 0
                    End If

                    If continuar = 1 Then
                        temperatura = txtTemperatura.Text
                        conductividad = -0.28 + 1.9 * humedad - 0.0092 * temperatura
                    End If

                Case "Pan blanco"

                    If String.IsNullOrEmpty(Me.txtTemperatura.Text) Then

                        Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
                        MsgBox(msg)
                        Dim style = MsgBoxStyle.Critical
                        continuar = 0
                    End If
                    If continuar = 1 Then
                        'convertir °C en K para la ecuación
                        temperatura = (txtTemperatura.Text + 273)
                        'Calcular humedad en funcion de temperatura
                        humedad = 41.53 * (10 ^ (-0.0189 * temperatura))

                        txtHumedad.Text = Format(humedad, "0.0000")
                        txtTempCongelacion.Text = Format(225 * (10 ^ (-0.0095 * temperatura)), "0.0000")
                        conductividad = 0.6792 - 0.0551 * humedad + 0.002 * txtTempCongelacion.Text + 0.0009 * (humedad ^ 2) - 0.000024 * humedad * txtTempCongelacion.Text
                    End If

            End Select

            'Formateo del resultado para mostrar 4 decimales
            Me.txtResultado.Text = Format(conductividad, "0.0000")

        End If

    End Sub

    Private Sub Panel_ecuacion_param_Paint(sender As Object, e As PaintEventArgs) Handles Panel_ecuacion_param.Paint

        Dim temperatura As Double = 0
        Dim temperaturaCongelacion As Double = 0

        'Validación: Se mostrarán solo las variables necesarias a introducir por el usuario, según el producto

        Select Case Me.seleccion
            Case "Uva pasa"
                lblParametro.Text = "Fracción másica de agua(g agua/g producto)"
            Case "Surimi"
                lblTemperatura.Visible = True
                txtTemperatura.Visible = True
            Case "Carne molida"

                lblTemperatura.Visible = True
                txtTemperatura.Visible = True
            Case "Zumo de frutas (fraccion agua)"
                lblParametro.Text = "Fracción másica de agua (g agua/g producto)"
            Case "Zumo de frutas (fraccion agua, temperatura, temp. congelacion)"
                lblParametro.Text = "Fracción másica de agua (g agua/g producto)"
                lblTemperatura.Visible = True
                txtTemperatura.Visible = True
                lblTempCongelacion.Visible = True
                txtTempCongelacion.Visible = True
            Case "Pera"
                lblParametro.Text = "Fracción de humedad en base seca"

            Case "Carnes (fraccion agua)"
                lblParametro.Text = "Fracción másica de agua (g agua/g producto)"
            Case "Carnes (fraccion agua, temperatura)"
                lblParametro.Text = "Fracción másica de agua (g agua/g producto)"
                lblTemperatura.Visible = True
                txtTemperatura.Visible = True
            Case "Pan blanco"
                lblParametro.Text = "Fracción de humedad en base húmeda"

                lblTemperatura.Visible = True
                txtTemperatura.Visible = True
                txtHumedad.Enabled = False
                lblTempCongelacion.Visible = True
                lblTempCongelacion.Text = "Densidad"
                txtTempCongelacion.Enabled = False
                txtTempCongelacion.Visible = True


        End Select
    End Sub

    Private Sub txtHumedad_TextChanged(sender As Object, e As EventArgs) Handles txtHumedad.TextChanged

    End Sub

    Private Sub txtTemperatura_TextChanged(sender As Object, e As EventArgs) Handles txtTemperatura.TextChanged

    End Sub

    Private Sub txtTempCongelacion_TextChanged(sender As Object, e As EventArgs) Handles txtTempCongelacion.TextChanged

    End Sub
End Class