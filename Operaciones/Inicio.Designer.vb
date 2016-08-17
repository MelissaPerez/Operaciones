<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.Btn_calor = New System.Windows.Forms.Button()
        Me.Btn_conductividad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Choi = New System.Windows.Forms.Button()
        Me.Btn_TipoProducto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_calor
        '
        Me.Btn_calor.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_calor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_calor.FlatAppearance.BorderSize = 2
        Me.Btn_calor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_calor.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_calor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_calor.Location = New System.Drawing.Point(72, 114)
        Me.Btn_calor.Name = "Btn_calor"
        Me.Btn_calor.Size = New System.Drawing.Size(157, 34)
        Me.Btn_calor.TabIndex = 0
        Me.Btn_calor.Text = "Calor específico"
        Me.Btn_calor.UseVisualStyleBackColor = False
        '
        'Btn_conductividad
        '
        Me.Btn_conductividad.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_conductividad.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_conductividad.FlatAppearance.BorderSize = 2
        Me.Btn_conductividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_conductividad.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_conductividad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_conductividad.Location = New System.Drawing.Point(248, 114)
        Me.Btn_conductividad.Name = "Btn_conductividad"
        Me.Btn_conductividad.Size = New System.Drawing.Size(136, 34)
        Me.Btn_conductividad.TabIndex = 1
        Me.Btn_conductividad.Text = "Conductividad"
        Me.Btn_conductividad.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(102, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Propiedades Térmicas"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Btn_Choi)
        Me.Panel1.Controls.Add(Me.Btn_TipoProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(15, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 166)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Location = New System.Drawing.Point(68, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Para componentes del alimento"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_Choi
        '
        Me.Btn_Choi.BackColor = System.Drawing.Color.Khaki
        Me.Btn_Choi.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Btn_Choi.FlatAppearance.BorderSize = 2
        Me.Btn_Choi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Btn_Choi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Btn_Choi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Choi.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Choi.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Btn_Choi.Location = New System.Drawing.Point(68, 119)
        Me.Btn_Choi.Name = "Btn_Choi"
        Me.Btn_Choi.Size = New System.Drawing.Size(293, 30)
        Me.Btn_Choi.TabIndex = 2
        Me.Btn_Choi.Text = "Choi - Okos: Temperatura - Composición"
        Me.Btn_Choi.UseVisualStyleBackColor = False
        '
        'Btn_TipoProducto
        '
        Me.Btn_TipoProducto.BackColor = System.Drawing.Color.Khaki
        Me.Btn_TipoProducto.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Btn_TipoProducto.FlatAppearance.BorderSize = 2
        Me.Btn_TipoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Btn_TipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TipoProducto.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_TipoProducto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Btn_TipoProducto.Location = New System.Drawing.Point(68, 47)
        Me.Btn_TipoProducto.Name = "Btn_TipoProducto"
        Me.Btn_TipoProducto.Size = New System.Drawing.Size(293, 30)
        Me.Btn_TipoProducto.TabIndex = 1
        Me.Btn_TipoProducto.Text = "Según tipo de producto"
        Me.Btn_TipoProducto.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(65, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Filtro de ecuaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(263, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Calculadora"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(436, 352)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_conductividad)
        Me.Controls.Add(Me.Btn_calor)
        Me.Name = "Inicio"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_calor As Button
    Friend WithEvents Btn_conductividad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Choi As Button
    Friend WithEvents Btn_TipoProducto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
