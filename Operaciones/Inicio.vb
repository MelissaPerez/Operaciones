Public Class Inicio

    Dim botonCalor = 0
    Dim seleccion As String

    Public Shared Function GetImgResource(Name) As Object
        Select Case Name
            Case "Hielo"
                Return My.Resources.Hielo
            Case "Agua (-40°C a 0°C)"
                Return My.Resources.Agua400
            Case "Agua (0°C a 150°C)"
                Return My.Resources.Agua0150
            Case "Apio"
                Return My.Resources.Apio
            Case "Carbohidratos"
                Return My.Resources.Carbohidratos
            Case "Carne molida"
                Return My.Resources.CarneMolida
            Case "Carnes (fraccion agua)"
                Return My.Resources.CarnesFa
            Case "Carnes (fraccion agua, temperatura)"
                Return My.Resources.CarnesFaT
            Case "Cenizas"
                Return My.Resources.Cenizas
            Case "Lípidos"
                Return My.Resources.Lipidos
            Case "Manzana"
                Return My.Resources.Manzana
            Case "Pan blanco"
                Return My.Resources.PanBlanco
            Case "Papaya"
                Return My.Resources.Papaya
            Case "Pera"
                Return My.Resources.Pera
            Case "Zumo de frutas (fraccion agua)"
                Return My.Resources.ZumoFrutasFa
            Case "Zumo de frutas (fraccion agua, temperatura, temp. congelacion)"
                Return My.Resources.ZumoFrutasFaTTc
            Case "Melón"
                Return My.Resources.Melon
            Case "Uva pasa"
                Return My.Resources.UvaPasa
            Case "Zanahoria"
                Return My.Resources.Zanahoria
            Case "Surimi"
                Return My.Resources.Surimi
            Case "Perejil"
                Return My.Resources.Perejil
            Case "Proteína"
                Return My.Resources.Proteina
            Case "Remolacha"
                Return My.Resources.Remolacha


        End Select
    End Function

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
