﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ecuacion_Conductividad_TipoProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel_foto_ecuacion = New System.Windows.Forms.Panel()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.x = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_ecuacion_param = New System.Windows.Forms.Panel()
        Me.txtTempCongelacion = New System.Windows.Forms.TextBox()
        Me.lblTempCongelacion = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.Btn_calcular_ecuacion = New System.Windows.Forms.Button()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.txtHumedad = New System.Windows.Forms.TextBox()
        Me.Panel_foto_ecuacion.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.x.SuspendLayout()
        Me.Panel_ecuacion_param.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(549, 212)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(549, 175)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Panel_foto_ecuacion
        '
        Me.Panel_foto_ecuacion.Controls.Add(Me.lblObservaciones)
        Me.Panel_foto_ecuacion.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_foto_ecuacion.Location = New System.Drawing.Point(12, 12)
        Me.Panel_foto_ecuacion.Name = "Panel_foto_ecuacion"
        Me.Panel_foto_ecuacion.Size = New System.Drawing.Size(612, 82)
        Me.Panel_foto_ecuacion.TabIndex = 13
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(10, 77)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(10, 13)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "-"
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(13, 3)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(581, 71)
        Me.Foto_Ecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Foto_Ecuacion.TabIndex = 7
        Me.Foto_Ecuacion.TabStop = False
        '
        'x
        '
        Me.x.Controls.Add(Me.Label2)
        Me.x.Controls.Add(Me.txtResultado)
        Me.x.Controls.Add(Me.Label3)
        Me.x.Location = New System.Drawing.Point(12, 225)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(514, 30)
        Me.x.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "W/m*K"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(101, 3)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado"
        '
        'Panel_ecuacion_param
        '
        Me.Panel_ecuacion_param.Controls.Add(Me.txtTempCongelacion)
        Me.Panel_ecuacion_param.Controls.Add(Me.lblTempCongelacion)
        Me.Panel_ecuacion_param.Controls.Add(Me.txtTemperatura)
        Me.Panel_ecuacion_param.Controls.Add(Me.lblTemperatura)
        Me.Panel_ecuacion_param.Controls.Add(Me.Btn_calcular_ecuacion)
        Me.Panel_ecuacion_param.Controls.Add(Me.lblParametro)
        Me.Panel_ecuacion_param.Controls.Add(Me.txtHumedad)
        Me.Panel_ecuacion_param.Location = New System.Drawing.Point(12, 105)
        Me.Panel_ecuacion_param.Name = "Panel_ecuacion_param"
        Me.Panel_ecuacion_param.Size = New System.Drawing.Size(514, 114)
        Me.Panel_ecuacion_param.TabIndex = 11
        '
        'txtTempCongelacion
        '
        Me.txtTempCongelacion.Location = New System.Drawing.Point(249, 77)
        Me.txtTempCongelacion.Name = "txtTempCongelacion"
        Me.txtTempCongelacion.Size = New System.Drawing.Size(100, 20)
        Me.txtTempCongelacion.TabIndex = 12
        '
        'lblTempCongelacion
        '
        Me.lblTempCongelacion.AutoSize = True
        Me.lblTempCongelacion.Location = New System.Drawing.Point(61, 80)
        Me.lblTempCongelacion.Name = "lblTempCongelacion"
        Me.lblTempCongelacion.Size = New System.Drawing.Size(163, 13)
        Me.lblTempCongelacion.TabIndex = 11
        Me.lblTempCongelacion.Text = "Temperatura de congelación (°C)"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(249, 46)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(100, 20)
        Me.txtTemperatura.TabIndex = 10
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Location = New System.Drawing.Point(137, 49)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(87, 13)
        Me.lblTemperatura.TabIndex = 9
        Me.lblTemperatura.Text = "Temperatura (°C)"
        '
        'Btn_calcular_ecuacion
        '
        Me.Btn_calcular_ecuacion.Location = New System.Drawing.Point(401, 13)
        Me.Btn_calcular_ecuacion.Name = "Btn_calcular_ecuacion"
        Me.Btn_calcular_ecuacion.Size = New System.Drawing.Size(75, 23)
        Me.Btn_calcular_ecuacion.TabIndex = 8
        Me.Btn_calcular_ecuacion.Text = "Calcular"
        Me.Btn_calcular_ecuacion.UseVisualStyleBackColor = True
        '
        'lblParametro
        '
        Me.lblParametro.AutoSize = True
        Me.lblParametro.Location = New System.Drawing.Point(22, 16)
        Me.lblParametro.Name = "lblParametro"
        Me.lblParametro.Size = New System.Drawing.Size(202, 13)
        Me.lblParametro.TabIndex = 1
        Me.lblParametro.Text = "Contenido de humedad (Kg/Kg producto)"
        Me.lblParametro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtHumedad
        '
        Me.txtHumedad.Location = New System.Drawing.Point(249, 13)
        Me.txtHumedad.Name = "txtHumedad"
        Me.txtHumedad.Size = New System.Drawing.Size(100, 20)
        Me.txtHumedad.TabIndex = 3
        '
        'Ecuacion_Conductividad_TipoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 267)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel_foto_ecuacion)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.Panel_ecuacion_param)
        Me.Name = "Ecuacion_Conductividad_TipoProducto"
        Me.Text = "Ecuacion_Conductividad_TipoProducto"
        Me.Panel_foto_ecuacion.ResumeLayout(False)
        Me.Panel_foto_ecuacion.PerformLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.x.ResumeLayout(False)
        Me.x.PerformLayout()
        Me.Panel_ecuacion_param.ResumeLayout(False)
        Me.Panel_ecuacion_param.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel_foto_ecuacion As Panel
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents x As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_ecuacion_param As Panel
    Friend WithEvents Btn_calcular_ecuacion As Button
    Friend WithEvents lblParametro As Label
    Friend WithEvents txtHumedad As TextBox
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents txtTempCongelacion As TextBox
    Friend WithEvents lblTempCongelacion As Label
End Class