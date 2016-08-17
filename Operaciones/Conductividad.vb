Public Class Conductividad
    Dim visiblePanel = 0
    Dim seleccion As String

    Private Sub Panel_MostrarEcuacion_Conductividad_Paint() Handles Panel_MostrarEcuacion_Conductividad.Paint
        If visiblePanel = 0 Then
            Panel_MostrarEcuacion_Conductividad.Visible = False
        Else
            Panel_MostrarEcuacion_Conductividad.Visible = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConductividad.SelectedIndexChanged
        seleccion = cmbConductividad.SelectedItem
        Foto_Ecuacion.Image = System.Drawing.Bitmap.FromFile("C:\Users\Ameli\Repositorios\Operaciones\Operaciones\Imagenes\" + seleccion + ".PNG")
        visiblePanel = 1
        Me.Panel_MostrarEcuacion_Conductividad_Paint()

        If seleccion = "Remolacha" Or
            seleccion = "Zanahoria" Or
            seleccion = "Perejil" Or
            seleccion = "Apio" Or
            seleccion = "Manzana" Or
            seleccion = "Papaya" Then

            lblImagenConductividad.Text = "Xbh: Contenido de humedad en base húmeda"

        ElseIf seleccion = "Surimi" Or seleccion = "Carne molida" Or seleccion = "Pan blanco" Or seleccion = "Pasta de trigo" Then
            lblImagenConductividad.Text = "Xbh: Contenido de humedad en base húmeda" & Chr(13) & "T: Temperatura del producto (°C)"

        ElseIf seleccion = "Carnes (fraccion agua, temperatura)" Then
            lblImagenConductividad.Text = "Xw: Fracción másica de agua (g agua/ g producto)" & Chr(13) & "T: Temperatura del producto (°C)"

        ElseIf seleccion = "Carnes (fraccion agua)" Or seleccion = "Zumo de frutas (fraccion agua)" Or seleccion = "Papa (fraccion de agua)" Then
            lblImagenConductividad.Text = "Xw: Fracción másica de agua (g agua/ g producto)"

        ElseIf seleccion = "Zumo de frutas (fraccion agua, temperatura, temp. congelacion)" Then
            lblImagenConductividad.Text = "Xw: Fracción másica de agua (g agua/ g producto)" & Chr(13) & "T: Temperatura del producto (°C)" & Chr(13) & "TCong: Temperatura de congelación del producto (°C)"

        ElseIf seleccion = "Pera" Or seleccion = "Papa (base seca)" Then
            lblImagenConductividad.Text = "Xbs: Contenido de humedad en base seca"

        ElseIf seleccion = "Papa (base seca, rango temperatura)" Then
            lblImagenConductividad.Text = "Xbs: Contenido de humedad en base seca" & Chr(13) & "T: Temperatura del producto (°C)"

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim oForm As Inicio
        oForm = New Inicio()
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim oForm As Ecuacion_Conductividad_TipoProducto
        oForm = New Ecuacion_Conductividad_TipoProducto(seleccion)
        oForm.Show()
        Me.Hide()
    End Sub


End Class