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
        Dim temperatura As Double = Me.txtTemperatura.Text
        Dim carbohidratos As Double
        Dim proteina As Double
        Dim grasa As Double
        Dim ceniza As Double
        Dim humedad As Double
        Dim fibra As Double
        Dim fraccionCarbohidratos As Double
        Dim fracciongrasa As Double
        Dim fraccionproteina As Double
        Dim fraccioncenizas As Double
        Dim fraccionfibra As Double
        Dim fraccionhumedad As Double
        Dim resultado As Double


        humedad = 4.1762 - (9.0864 * (10 ^ -5) * temperatura) + (5.4731 * (10 ^ -6) * temperatura ^ 2)
        carbohidratos = 1.5488 + (1.9625 * (10 ^ -3) * temperatura) - (5.9399 * (10 ^ -6) * temperatura ^ 2)
        proteina = 2.0082 + (1.2089 * (10 ^ -3) * temperatura) - (1.3129 * (10 ^ -6) * temperatura ^ 2)
        grasa = 1.9842 + (1.4733 * (10 ^ -3) * temperatura) - (4.8008 * (10 ^ -6) * temperatura ^ 2)
        ceniza = 1.0926 + (1.8896 * (10 ^ -3) * temperatura) - (3.6817 * (10 ^ -6) * temperatura ^ 2)
        fibra = 1.8459 + (1.8306 * (10 ^ -3) * temperatura) - (4.6509 * (10 ^ -6) * temperatura ^ 2)

        fraccionCarbohidratos = Me.txtCarbohidratos.Text
        fraccionproteina = Me.txtProteina.Text
        fracciongrasa = Me.txtGrasa.Text
        fraccioncenizas = Me.txtCeniza.Text
        fraccionhumedad = Me.txtHumedad.Text
        fraccionfibra = Me.txtFibra.Text

        humedad = humedad * fraccionhumedad
        carbohidratos = carbohidratos * fraccionCarbohidratos
        proteina = proteina * fraccionproteina
        grasa = grasa * fracciongrasa
        fibra = fibra * fraccionfibra
        ceniza = ceniza * fraccioncenizas

        resultado = humedad + carbohidratos + proteina + grasa + fibra + ceniza

        txtResultado.Text = resultado

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim oForm As Calor_Autor
        oForm = New Calor_Autor()
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class