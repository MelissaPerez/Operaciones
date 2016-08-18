Public Class Calor_Autor

    Dim seleccion As String
    Dim visiblePanel = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim oForm As Inicio
        oForm = New Inicio()
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim oForm As Ecuacion_ChoiOkos
        oForm = New Ecuacion_ChoiOkos(seleccion)
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel_MostrarEcuacion_Autores_Paint() Handles Panel_MostrarEcuacion_Autores.Paint
        If visiblePanel = 0 Then
            Panel_MostrarEcuacion_Autores.Visible = False
        Else
            Panel_MostrarEcuacion_Autores.Visible = True
        End If

    End Sub

    Private Sub Cmb_calor_autor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_calor_autor.SelectedIndexChanged
        seleccion = Cmb_calor_autor.SelectedItem

        If seleccion = "Choi - Okos (1986)" Then
             Foto_Ecuacion.Image = Inicio.GetImgResource(seleccion)
            visiblePanel = 1
            Me.Panel_MostrarEcuacion_Autores_Paint()
        End If
    End Sub


End Class