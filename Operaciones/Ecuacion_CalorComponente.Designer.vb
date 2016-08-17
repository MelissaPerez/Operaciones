<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ecuacion_CalorComponente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Panel_ecuacion_param = New System.Windows.Forms.Panel()
        Me.Btn_calcular_ecuacion = New System.Windows.Forms.Button()
        Me.x = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.Panel_foto_ecuacion = New System.Windows.Forms.Panel()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel_ecuacion_param.SuspendLayout()
        Me.x.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_foto_ecuacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblParametro
        '
        Me.lblParametro.AutoSize = True
        Me.lblParametro.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParametro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblParametro.Location = New System.Drawing.Point(22, 16)
        Me.lblParametro.Name = "lblParametro"
        Me.lblParametro.Size = New System.Drawing.Size(115, 17)
        Me.lblParametro.TabIndex = 1
        Me.lblParametro.Text = "Temperatura (°C)"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTemperatura.Location = New System.Drawing.Point(147, 16)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(100, 24)
        Me.txtTemperatura.TabIndex = 3
        '
        'Panel_ecuacion_param
        '
        Me.Panel_ecuacion_param.Controls.Add(Me.Btn_calcular_ecuacion)
        Me.Panel_ecuacion_param.Controls.Add(Me.lblParametro)
        Me.Panel_ecuacion_param.Controls.Add(Me.txtTemperatura)
        Me.Panel_ecuacion_param.Location = New System.Drawing.Point(12, 107)
        Me.Panel_ecuacion_param.Name = "Panel_ecuacion_param"
        Me.Panel_ecuacion_param.Size = New System.Drawing.Size(385, 59)
        Me.Panel_ecuacion_param.TabIndex = 5
        '
        'Btn_calcular_ecuacion
        '
        Me.Btn_calcular_ecuacion.BackColor = System.Drawing.Color.Olive
        Me.Btn_calcular_ecuacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_calcular_ecuacion.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_calcular_ecuacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_calcular_ecuacion.Location = New System.Drawing.Point(285, 13)
        Me.Btn_calcular_ecuacion.Name = "Btn_calcular_ecuacion"
        Me.Btn_calcular_ecuacion.Size = New System.Drawing.Size(75, 26)
        Me.Btn_calcular_ecuacion.TabIndex = 8
        Me.Btn_calcular_ecuacion.Text = "Calcular"
        Me.Btn_calcular_ecuacion.UseVisualStyleBackColor = False
        '
        'x
        '
        Me.x.Controls.Add(Me.Label2)
        Me.x.Controls.Add(Me.txtResultado)
        Me.x.Controls.Add(Me.Label3)
        Me.x.Location = New System.Drawing.Point(12, 185)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(385, 54)
        Me.x.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(282, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "J/Kg"
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtResultado.Location = New System.Drawing.Point(147, 19)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 24)
        Me.txtResultado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(67, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado"
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btnVolver.FlatAppearance.BorderSize = 2
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Olive
        Me.btnVolver.Location = New System.Drawing.Point(61, 264)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 33)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(13, 12)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(361, 51)
        Me.Foto_Ecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Foto_Ecuacion.TabIndex = 7
        Me.Foto_Ecuacion.TabStop = False
        '
        'Panel_foto_ecuacion
        '
        Me.Panel_foto_ecuacion.Controls.Add(Me.lblObservaciones)
        Me.Panel_foto_ecuacion.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_foto_ecuacion.Location = New System.Drawing.Point(12, 12)
        Me.Panel_foto_ecuacion.Name = "Panel_foto_ecuacion"
        Me.Panel_foto_ecuacion.Size = New System.Drawing.Size(589, 76)
        Me.Panel_foto_ecuacion.TabIndex = 8
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(403, 28)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(10, 13)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "-"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btnSalir.FlatAppearance.BorderSize = 2
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Olive
        Me.btnSalir.Location = New System.Drawing.Point(471, 265)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 32)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Ecuacion_CalorComponente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(613, 309)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel_foto_ecuacion)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.Panel_ecuacion_param)
        Me.Name = "Ecuacion_CalorComponente"
        Me.Text = "Ecuacion"
        Me.Panel_ecuacion_param.ResumeLayout(False)
        Me.Panel_ecuacion_param.PerformLayout()
        Me.x.ResumeLayout(False)
        Me.x.PerformLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_foto_ecuacion.ResumeLayout(False)
        Me.Panel_foto_ecuacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblParametro As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Panel_ecuacion_param As Panel
    Friend WithEvents x As Panel
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents Btn_calcular_ecuacion As Button
    Friend WithEvents Panel_foto_ecuacion As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblObservaciones As Label
End Class
