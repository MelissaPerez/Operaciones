Public Class Ecuacion_Conductividad_TipoProducto
    Dim seleccion As String

    Sub New(ByVal image As String)
        Me.seleccion = image
        InitializeComponent()

        Foto_Ecuacion.Image = System.Drawing.Bitmap.FromFile("C:\Users\Ameli\Repositorios\Operaciones\Operaciones\Imagenes\" + seleccion + ".PNG")

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

        Dim humedad As Double = txtTHumedad.Text
        Dim conductividad As Double

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
                conductividad = 0.0645 e 0.0279 * humedad
            Case "Melón"
                conductividad = 0.172 + 0.0045 * humedad
            Case "Manzana"
                conductividad = 0.172 + 0.0045 * humedad
            Case "Pera"
                conductividad = 0.172 + 0.0045 * humedad
            Case "Carne molida"
                conductividad = 0.172 + 0.0045 * humedad
            Case "Surimi"
                conductividad = 0.172 + 0.0045 * humedad


        End Select


    End Sub
End Class