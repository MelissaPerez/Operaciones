Public Class Inicio

    Dim botonCalor = 0
    Dim seleccion As String

    Private Sub Panel1_Paint() Handles Panel1.Paint
        'Se retiran parametros "sender" y "e" para permitir validación del panel
        'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        If botonCalor = 0 Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_calor.Click
        botonCalor = 1
        Me.Panel1_Paint()

    End Sub

    Private Sub Btn_conductividad_Click(sender As Object, e As EventArgs) Handles Btn_conductividad.Click
        Dim oForm As Conductividad
        oForm = New Conductividad()
        oForm.Show()
        Me.Hide()
    End Sub



    Private Sub Btn_TipoProducto_Click(sender As Object, e As EventArgs) Handles Btn_TipoProducto.Click
        Dim oForm As Calor_TipoProducto
        oForm = New Calor_TipoProducto()
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Autores_Click(sender As Object, e As EventArgs) Handles Btn_Choi.Click
        Dim oForm As Ecuacion_ChoiOkos
        oForm = New Ecuacion_ChoiOkos("Choi - Okos (1986)")
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As Calor_Componente
        oForm = New Calor_Componente()
        oForm.Show()
        Me.Hide()
    End Sub
End Class
