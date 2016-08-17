Public Class Ecuacion_ChoiOkos

    Dim seleccion As String

    Sub New(ByVal image As String)
        Me.seleccion = image
        InitializeComponent()

        If seleccion = "Choi - Okos (1986)" Then
            Foto_Ecuacion.Image = System.Drawing.Bitmap.FromFile("C:\Users\Ameli\Repositorios\Operaciones\Operaciones\Imagenes\ChoiOkos.PNG")
        End If

    End Sub

    Private Sub Btn_calcular_ecuacion_Click(sender As Object, e As EventArgs) Handles Btn_calcular_ecuacion.Click
        'Variables UI
        Dim temperatura As Double
        Dim carbohidratos As Double
        Dim proteina As Double
        Dim grasa As Double
        Dim ceniza As Double
        Dim humedad As Double
        Dim fibra As Double

        'Variables calculo
        Dim fraccionCarbohidratos As Double
        Dim fracciongrasa As Double
        Dim fraccionproteina As Double
        Dim fraccioncenizas As Double
        Dim fraccionfibra As Double
        Dim fraccionhumedad As Double
        Dim resultado As Double

        'Validación: que las entradas de fracciones de componente no estén vacias
        If String.IsNullOrEmpty(Me.txtTemperatura.Text) Or
            String.IsNullOrEmpty(Me.txtCarbohidratos.Text) Or
            String.IsNullOrEmpty(Me.txtProteina.Text) Or
            String.IsNullOrEmpty(Me.txtGrasa.Text) Or
            String.IsNullOrEmpty(Me.txtCeniza.Text) Or
            String.IsNullOrEmpty(Me.txtHumedad.Text) Or
            String.IsNullOrEmpty(Me.txtFibra.Text) Then
            Dim msg = "¡Por favor llene todos los campos. Si hay valores nulos escriba el numero: 0!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical

            'Validación: que las entradas de fracciones de componente no sean menores que cero
        ElseIf Convert.ToDouble(Me.txtCarbohidratos.Text) < 0 Or
            Convert.ToDouble(Me.txtProteina.Text) < 0 Or
            Convert.ToDouble(Me.txtGrasa.Text) < 0 Or
            Convert.ToDouble(Me.txtCeniza.Text) < 0 Or
            Convert.ToDouble(Me.txtFibra.Text) < 0 Or
            Convert.ToDouble(Me.txtHumedad.Text) < 0 Then

            Dim msg = "¡Las fracciones deben ser mayores a 0 y menores o iguales a 1!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical

            'Validación: que la suma de las fracciones no sea mayor a 1

        ElseIf Convert.ToDouble(Me.txtCarbohidratos.Text) + Convert.ToDouble(Me.txtProteina.Text) + Convert.ToDouble(Me.txtGrasa.Text) + Convert.ToDouble(Me.txtCeniza.Text) + Convert.ToDouble(Me.txtFibra.Text) < 0 Or +Convert.ToDouble(Me.txtHumedad.Text) > 1 Then

            Dim msg = "¡La suma de las fracciones debe ser mayor a 0 e igual a 1!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical

            ''''''Cálculo: 

        Else
            'Se calcula el calor específico de cada componente es funcion solamente de la temperatura
            temperatura = Me.txtTemperatura.Text
            humedad = 4.1762 - (9.0864 * (10 ^ -5) * temperatura) + (5.4731 * (10 ^ -6) * temperatura ^ 2)
            carbohidratos = 1.5488 + (1.9625 * (10 ^ -3) * temperatura) - (5.9399 * (10 ^ -6) * temperatura ^ 2)
            proteina = 2.0082 + (1.2089 * (10 ^ -3) * temperatura) - (1.3129 * (10 ^ -6) * temperatura ^ 2)
            grasa = 1.9842 + (1.4733 * (10 ^ -3) * temperatura) - (4.8008 * (10 ^ -6) * temperatura ^ 2)
            ceniza = 1.0926 + (1.8896 * (10 ^ -3) * temperatura) - (3.6817 * (10 ^ -6) * temperatura ^ 2)
            fibra = 1.8459 + (1.8306 * (10 ^ -3) * temperatura) - (4.6509 * (10 ^ -6) * temperatura ^ 2)

            'Se extraen los valores de los campos de entrada de las fracciones por componente 
            fraccionCarbohidratos = Me.txtCarbohidratos.Text
            fraccionproteina = Me.txtProteina.Text
            fracciongrasa = Me.txtGrasa.Text
            fraccioncenizas = Me.txtCeniza.Text
            fraccionhumedad = Me.txtHumedad.Text
            fraccionfibra = Me.txtFibra.Text

            'Se calcula el calor especifico por la fraccion de cada componente
            humedad = humedad * fraccionhumedad
            carbohidratos = carbohidratos * fraccionCarbohidratos
            proteina = proteina * fraccionproteina
            grasa = grasa * fracciongrasa
            fibra = fibra * fraccionfibra
            ceniza = ceniza * fraccioncenizas

            'Se calcula la suma de las fracciones de cada calor específico
            resultado = (humedad + carbohidratos + proteina + grasa + fibra + ceniza) * 1000

            'Se arregla el formato del resultado para tener 4 decimales
            txtResultado.Text = Format(resultado, "0.0000")

        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim oForm As Inicio
        oForm = New Inicio()
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        'si el susuario escoge calcular calor específico por tipo de producto, los valores de las
        'composiciones son predeterminadas

        If seleccion = "Leche de coco" Or
                seleccion = "Carne de res" Or
                seleccion = "Pechuga de pollo" Or
                seleccion = "Manzana con piel" Or
                seleccion = "Banano" Or
                seleccion = "Mango" Then

            Me.txtCarbohidratos.Enabled = False
            Me.txtProteina.Enabled = False
            Me.txtGrasa.Enabled = False
            Me.txtCeniza.Enabled = False
            Me.txtHumedad.Enabled = False
            Me.txtFibra.Enabled = False

        End If


        If seleccion = "Leche de coco" Then
            Me.txtCarbohidratos.Text = 0.012
            Me.txtProteina.Text = 0.021
            Me.txtGrasa.Text = 0.217
            Me.txtCeniza.Text = 0.008
            Me.txtHumedad.Text = 0.72
            Me.txtFibra.Text = 0.022
        End If
        If seleccion = "Carne de res" Then
            Me.txtCarbohidratos.Text = 0.0
            Me.txtProteina.Text = 0.207
            Me.txtGrasa.Text = 0.023
            Me.txtCeniza.Text = 0.01
            Me.txtHumedad.Text = 0.76
            Me.txtFibra.Text = 0.0
        End If
        If seleccion = "Pechuga de pollo" Then
            Me.txtCarbohidratos.Text = 0.0
            Me.txtProteina.Text = 0.223
            Me.txtGrasa.Text = 0.018
            Me.txtCeniza.Text = 0.011
            Me.txtHumedad.Text = 0.729
            Me.txtFibra.Text = 0.0
        End If
        If seleccion = "Manzana con piel" Then
            Me.txtCarbohidratos.Text = 0.135
            Me.txtProteina.Text = 0.003
            Me.txtGrasa.Text = 0.002
            Me.txtCeniza.Text = 0.002
            Me.txtHumedad.Text = 0.833
            Me.txtFibra.Text = 0.024
        End If
        If seleccion = "Banano" Then
            Me.txtCarbohidratos.Text = 0.192
            Me.txtProteina.Text = 0.013
            Me.txtGrasa.Text = 0.008
            Me.txtCeniza.Text = 0.008
            Me.txtHumedad.Text = 0.752
            Me.txtFibra.Text = 0.026
        End If
        If seleccion = "Mango" Then
            Me.txtCarbohidratos.Text = 0.18
            Me.txtProteina.Text = 0.008
            Me.txtGrasa.Text = 0.004
            Me.txtCeniza.Text = 0.008
            Me.txtHumedad.Text = 0.784
            Me.txtFibra.Text = 0.016
        End If
    End Sub
End Class