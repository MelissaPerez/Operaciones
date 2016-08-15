Public Class Ecuacion_CalorComponente

    Dim tipoEcuacion As Integer
    Dim seleccion As String

    Sub New(ByVal image As String)
        Me.seleccion = image
        InitializeComponent()

        Foto_Ecuacion.Image = System.Drawing.Bitmap.FromFile("C:\Users\Ameli\Documents\Visual Studio 2015\Projects\Operaciones\Operaciones\Imagenes\" + seleccion + ".PNG")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_calcular_ecuacion.Click

        'Note: validacion aun no funciona bien

        Dim temperatura As Double = Me.temp.Text
        Dim resultado As Double
        Dim continuar As Boolean = True

        If seleccion = "Agua (-40°C a 0°C)" & (temperatura > 0 Or temperatura < -40) Then
            Dim msg = "¡Esta ecuación funciona para temperpaturas entre -40°C y 0°C!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical
            continuar = False

        End If

        If seleccion = "Agua (0°C a 150°C)" & (temperatura < 0 Or temperatura > 150) Then
            Dim msg = "¡Esta ecuación funciona para temperpaturas entre 0°C y 150°C!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical
            continuar = False
        End If

        If temperatura > 150 Or temperatura < -40 Then
            Dim msg = "¡Esta ecuación funciona para temperpaturas entre -40°C y 150°C!"
            MsgBox(msg)
            Dim style = MsgBoxStyle.Critical
            continuar = False

        End If

        If continuar = True Then

            Select Case Me.seleccion

                Case "Agua (-40°C a  0°C)"
                    resultado = 4081.7 - 5.3062 * temperatura + 0.99516 * temperatura ^ 2
                    Me.txtResultado.Text = Format(resultado, "0.0000")
                Case "Agua (  0°C   a 150°C)"
                    resultado = 4176.2 - 0.0909 * temperatura + 5.4731 * (10 ^ -3) * temperatura ^ 2
                    Me.txtResultado.Text = Format(resultado, "0.0000")
                Case "Carbohidratos"
                    resultado = 1548.8 + 1.9625 * temperatura - 1.3129 * (10 ^ -3) * temperatura ^ 2
                    Me.txtResultado.Text = Format(resultado, "0.0000")
                Case "Proteína"
                    resultado = 2008.2 + 1.2089 * temperatura - 1.3129 * (10 ^ -3) * temperatura ^ 2
                    Me.txtResultado.Text = Format(resultado, "0.0000")
                Case "Lípidos"
                    resultado = 1984.2 + 1.4373 * temperatura - 4.8008 * (10 ^ -3) * temperatura ^ 2
                    Me.txtResultado.Text = Format(resultado, "0.0000")
                Case "Cenizas"
                    resultado = 1092.6 + 1.8896 * temperatura - 3.6817 * (10 ^ -3) * temperatura ^ 2
                    Me.txtResultado.Text = Format(resultado, "0.0000")
                Case "Hielo"
                    resultado = 2062.3 + 6.0769
                    Me.txtResultado.Text = Format(resultado, "0.0000")


            End Select
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oForm As Calor_Componente
        oForm = New Calor_Componente
        oForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class