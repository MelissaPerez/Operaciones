<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ecuacion_ChoiOkos
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
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.x = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_ecuacion_param = New System.Windows.Forms.Panel()
        Me.Btn_calcular_ecuacion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFibra = New System.Windows.Forms.TextBox()
        Me.txtHumedad = New System.Windows.Forms.TextBox()
        Me.txtCeniza = New System.Windows.Forms.TextBox()
        Me.txtGrasa = New System.Windows.Forms.TextBox()
        Me.txtProteina = New System.Windows.Forms.TextBox()
        Me.txtCarbohidratos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel_foto_ecuacion.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.x.SuspendLayout()
        Me.Panel_ecuacion_param.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 2
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Olive
        Me.btnSalir.Location = New System.Drawing.Point(444, 564)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 30)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btnVolver.FlatAppearance.BorderSize = 2
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Olive
        Me.btnVolver.Location = New System.Drawing.Point(21, 564)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 30)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Panel_foto_ecuacion
        '
        Me.Panel_foto_ecuacion.AutoSize = True
        Me.Panel_foto_ecuacion.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_foto_ecuacion.Location = New System.Drawing.Point(12, -1)
        Me.Panel_foto_ecuacion.Name = "Panel_foto_ecuacion"
        Me.Panel_foto_ecuacion.Size = New System.Drawing.Size(526, 221)
        Me.Panel_foto_ecuacion.TabIndex = 13
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(9, 3)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(514, 215)
        Me.Foto_Ecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Foto_Ecuacion.TabIndex = 7
        Me.Foto_Ecuacion.TabStop = False
        '
        'x
        '
        Me.x.Controls.Add(Me.Label2)
        Me.x.Controls.Add(Me.txtResultado)
        Me.x.Controls.Add(Me.Label3)
        Me.x.Location = New System.Drawing.Point(12, 512)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(504, 39)
        Me.x.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(329, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "J/Kg"
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtResultado.Location = New System.Drawing.Point(224, 13)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 23)
        Me.txtResultado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(138, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado"
        '
        'Panel_ecuacion_param
        '
        Me.Panel_ecuacion_param.Controls.Add(Me.Btn_calcular_ecuacion)
        Me.Panel_ecuacion_param.Controls.Add(Me.Label11)
        Me.Panel_ecuacion_param.Controls.Add(Me.Label1)
        Me.Panel_ecuacion_param.Controls.Add(Me.txtTemperatura)
        Me.Panel_ecuacion_param.Location = New System.Drawing.Point(12, 373)
        Me.Panel_ecuacion_param.Name = "Panel_ecuacion_param"
        Me.Panel_ecuacion_param.Size = New System.Drawing.Size(504, 120)
        Me.Panel_ecuacion_param.TabIndex = 11
        '
        'Btn_calcular_ecuacion
        '
        Me.Btn_calcular_ecuacion.BackColor = System.Drawing.Color.Olive
        Me.Btn_calcular_ecuacion.FlatAppearance.BorderSize = 2
        Me.Btn_calcular_ecuacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_calcular_ecuacion.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_calcular_ecuacion.ForeColor = System.Drawing.Color.White
        Me.Btn_calcular_ecuacion.Location = New System.Drawing.Point(224, 71)
        Me.Btn_calcular_ecuacion.Name = "Btn_calcular_ecuacion"
        Me.Btn_calcular_ecuacion.Size = New System.Drawing.Size(92, 30)
        Me.Btn_calcular_ecuacion.TabIndex = 8
        Me.Btn_calcular_ecuacion.Text = "Calcular"
        Me.Btn_calcular_ecuacion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Temperatura (°C)"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTemperatura.Location = New System.Drawing.Point(143, 16)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(100, 23)
        Me.txtTemperatura.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.txtFibra)
        Me.Panel1.Controls.Add(Me.txtHumedad)
        Me.Panel1.Controls.Add(Me.txtCeniza)
        Me.Panel1.Controls.Add(Me.txtGrasa)
        Me.Panel1.Controls.Add(Me.txtProteina)
        Me.Panel1.Controls.Add(Me.txtCarbohidratos)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 144)
        Me.Panel1.TabIndex = 15
        Me.Panel1.TabStop = True
        '
        'txtFibra
        '
        Me.txtFibra.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFibra.Location = New System.Drawing.Point(387, 103)
        Me.txtFibra.Name = "txtFibra"
        Me.txtFibra.Size = New System.Drawing.Size(100, 23)
        Me.txtFibra.TabIndex = 12
        '
        'txtHumedad
        '
        Me.txtHumedad.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHumedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtHumedad.Location = New System.Drawing.Point(387, 77)
        Me.txtHumedad.Name = "txtHumedad"
        Me.txtHumedad.Size = New System.Drawing.Size(100, 23)
        Me.txtHumedad.TabIndex = 11
        '
        'txtCeniza
        '
        Me.txtCeniza.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCeniza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCeniza.Location = New System.Drawing.Point(387, 47)
        Me.txtCeniza.Name = "txtCeniza"
        Me.txtCeniza.Size = New System.Drawing.Size(100, 23)
        Me.txtCeniza.TabIndex = 10
        '
        'txtGrasa
        '
        Me.txtGrasa.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrasa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGrasa.Location = New System.Drawing.Point(143, 106)
        Me.txtGrasa.Name = "txtGrasa"
        Me.txtGrasa.Size = New System.Drawing.Size(100, 23)
        Me.txtGrasa.TabIndex = 9
        '
        'txtProteina
        '
        Me.txtProteina.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProteina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtProteina.Location = New System.Drawing.Point(143, 77)
        Me.txtProteina.Name = "txtProteina"
        Me.txtProteina.Size = New System.Drawing.Size(100, 23)
        Me.txtProteina.TabIndex = 8
        '
        'txtCarbohidratos
        '
        Me.txtCarbohidratos.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarbohidratos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCarbohidratos.Location = New System.Drawing.Point(143, 47)
        Me.txtCarbohidratos.Name = "txtCarbohidratos"
        Me.txtCarbohidratos.Size = New System.Drawing.Size(100, 23)
        Me.txtCarbohidratos.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(308, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fibra"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(308, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Humedad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(309, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Ceniza"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(84, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Grasa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(67, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Proteína"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(31, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Carbohidratos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fracciones de componentes (g/100g producto)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Olive
        Me.Label12.Location = New System.Drawing.Point(23, 496)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(493, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "_________________________________________________________________________________" &
    ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(340, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "*Ingresar decimales con coma "
        '
        'Ecuacion_ChoiOkos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(545, 606)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel_foto_ecuacion)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.Panel_ecuacion_param)
        Me.Controls.Add(Me.Label12)
        Me.Name = "Ecuacion_ChoiOkos"
        Me.Text = "Ecuacion_ChoiOkos"
        Me.Panel_foto_ecuacion.ResumeLayout(False)
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.x.ResumeLayout(False)
        Me.x.PerformLayout()
        Me.Panel_ecuacion_param.ResumeLayout(False)
        Me.Panel_ecuacion_param.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel_foto_ecuacion As Panel
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents x As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_ecuacion_param As Panel
    Friend WithEvents Btn_calcular_ecuacion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtFibra As TextBox
    Friend WithEvents txtHumedad As TextBox
    Friend WithEvents txtCeniza As TextBox
    Friend WithEvents txtGrasa As TextBox
    Friend WithEvents txtProteina As TextBox
    Friend WithEvents txtCarbohidratos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
