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
            seleccion = "Papaya" Or
            seleccion = "Carne molida" Or
            seleccion = "Surimi" Then

            lblImagenConductividad.Text = "Xbh: Contenido de humedad en base húmeda"
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