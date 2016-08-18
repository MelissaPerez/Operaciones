<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calor_Componente
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
        Me.Btn_volver = New System.Windows.Forms.Button()
        Me.Panel_MostrarEcuacion_Componentes = New System.Windows.Forms.Panel()
        Me.Btn_calcular_calorcomp = New System.Windows.Forms.Button()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.Panel_calor_autor = New System.Windows.Forms.Panel()
        Me.Cmb_calor_componente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MostrarEcuacion_Componentes.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_calor_autor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_volver
        '
        Me.Btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.Btn_volver.FlatAppearance.BorderSize = 2
        Me.Btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_volver.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_volver.ForeColor = System.Drawing.Color.Olive
        Me.Btn_volver.Location = New System.Drawing.Point(57, 186)
        Me.Btn_volver.Name = "Btn_volver"
        Me.Btn_volver.Size = New System.Drawing.Size(91, 30)
        Me.Btn_volver.TabIndex = 8
        Me.Btn_volver.Text = "Volver"
        Me.Btn_volver.UseVisualStyleBackColor = True
        '
        'Panel_MostrarEcuacion_Componentes
        '
        Me.Panel_MostrarEcuacion_Componentes.Controls.Add(Me.Btn_calcular_calorcomp)
        Me.Panel_MostrarEcuacion_Componentes.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_MostrarEcuacion_Componentes.Location = New System.Drawing.Point(19, 91)
        Me.Panel_MostrarEcuacion_Componentes.Name = "Panel_MostrarEcuacion_Componentes"
        Me.Panel_MostrarEcuacion_Componentes.Size = New System.Drawing.Size(546, 75)
        Me.Panel_MostrarEcuacion_Componentes.TabIndex = 7
        '
        'Btn_calcular_calorcomp
        '
        Me.Btn_calcular_calorcomp.BackColor = System.Drawing.Color.Olive
        Me.Btn_calcular_calorcomp.FlatAppearance.BorderColor = System.Drawing.Color.Ivory
        Me.Btn_calcular_calorcomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_calcular_calorcomp.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_calcular_calorcomp.ForeColor = System.Drawing.Color.White
        Me.Btn_calcular_calorcomp.Location = New System.Drawing.Point(422, 24)
        Me.Btn_calcular_calorcomp.Name = "Btn_calcular_calorcomp"
        Me.Btn_calcular_calorcomp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_calcular_calorcomp.Size = New System.Drawing.Size(91, 33)
        Me.Btn_calcular_calorcomp.TabIndex = 9
        Me.Btn_calcular_calorcomp.Text = "Siguiente"
        Me.Btn_calcular_calorcomp.UseVisualStyleBackColor = False
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(38, 12)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(356, 45)
        Me.Foto_Ecuacion.TabIndex = 0
        Me.Foto_Ecuacion.TabStop = False
        '
        'Panel_calor_autor
        '
        Me.Panel_calor_autor.Controls.Add(Me.Cmb_calor_componente)
        Me.Panel_calor_autor.Controls.Add(Me.Label1)
        Me.Panel_calor_autor.Location = New System.Drawing.Point(18, 10)
        Me.Panel_calor_autor.Name = "Panel_calor_autor"
        Me.Panel_calor_autor.Size = New System.Drawing.Size(547, 63)
        Me.Panel_calor_autor.TabIndex = 6
        '
        'Cmb_calor_componente
        '
        Me.Cmb_calor_componente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_calor_componente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmb_calor_componente.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_calor_componente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmb_calor_componente.FormattingEnabled = True
        Me.Cmb_calor_componente.Items.AddRange(New Object() {"Agua (-40°C a 0°C)", "Agua (0°C a 150°C)", "Carbohidratos", "Proteína", "Lípidos", "Cenizas", "Hielo"})
        Me.Cmb_calor_componente.Location = New System.Drawing.Point(77, 39)
        Me.Cmb_calor_componente.Name = "Cmb_calor_componente"
        Me.Cmb_calor_componente.Size = New System.Drawing.Size(304, 23)
        Me.Cmb_calor_componente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja el componente deseado"
        '
        'Calor_Componente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(577, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_volver)
        Me.Controls.Add(Me.Panel_MostrarEcuacion_Componentes)
        Me.Controls.Add(Me.Panel_calor_autor)
        Me.Name = "Calor_Componente"
        Me.Text = "Calor_componente"
        Me.Panel_MostrarEcuacion_Componentes.ResumeLayout(False)
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_calor_autor.ResumeLayout(False)
        Me.Panel_calor_autor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_volver As Button
    Friend WithEvents Panel_MostrarEcuacion_Componentes As Panel
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents Panel_calor_autor As Panel
    Friend WithEvents Cmb_calor_componente As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_calcular_calorcomp As Button
End Class
