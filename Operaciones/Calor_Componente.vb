Public Class Calor_Componente


    Dim visiblePanel = 0
    Dim seleccion As String

    Private Sub Panel_MostrarEcuacion_Componentes_Paint() Handles Panel_MostrarEcuacion_Componentes.Paint

        If visiblePanel = 0 Then
            Panel_MostrarEcuacion_Componentes.Visible = False
        Else
            Panel_MostrarEcuacion_Componentes.Visible = True
        End If

    End Sub

    Private Sub Cmb_calor_autor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_calor_componente.SelectedIndexChanged

        seleccion = Cmb_calor_componente.SelectedItem

        Foto_Ecuacion.Image = Inicio.GetImgResource(seleccion)
        visiblePanel = 1
        Me.Panel_MostrarEcuacion_Componentes_Paint()

    End Sub

    Public Function getSeleccion() Handles Cmb_calor_componente.SelectedIndexChanged
        Dim seleccion As String
        seleccion = Cmb_calor_componente.SelectedItem
        Return seleccion
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_calcular_calorcomp.Click
        Dim oForm As Ecuacion_CalorComponente
        oForm = New Ecuacion_CalorComponente(seleccion)
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_volver.Click
        Dim oForm As Inicio
        oForm = New Inicio()
        oForm.Show()
        Me.Hide()
    End Sub
End Class
