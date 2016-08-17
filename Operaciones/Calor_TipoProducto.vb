Public Class Calor_TipoProducto
    Dim seleccion As String
    Dim continuar = 1

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel_TipoProducto.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As Inicio
        oForm = New Inicio()
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoProducto.SelectedIndexChanged
        seleccion = cmbTipoProducto.SelectedItem
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If seleccion = "" Then
            Dim msg = "¡Por favor escoja una opción!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical


        ElseIf continuar = 1 Then

            Dim oForm As Ecuacion_ChoiOkos
            oForm = New Ecuacion_ChoiOkos(seleccion)
            oForm.Show()
            Me.Hide()
        End If
    End Sub
End Class