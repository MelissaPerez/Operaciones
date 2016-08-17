<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calor_Autor
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
        Me.Panel_calor_autor = New System.Windows.Forms.Panel()
        Me.Cmb_calor_autor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MostrarEcuacion_Autores = New System.Windows.Forms.Panel()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Panel_calor_autor.SuspendLayout()
        Me.Panel_MostrarEcuacion_Autores.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_calor_autor
        '
        Me.Panel_calor_autor.Controls.Add(Me.Cmb_calor_autor)
        Me.Panel_calor_autor.Controls.Add(Me.Label1)
        Me.Panel_calor_autor.Location = New System.Drawing.Point(22, 22)
        Me.Panel_calor_autor.Name = "Panel_calor_autor"
        Me.Panel_calor_autor.Size = New System.Drawing.Size(581, 63)
        Me.Panel_calor_autor.TabIndex = 3
        '
        'Cmb_calor_autor
        '
        Me.Cmb_calor_autor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_calor_autor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmb_calor_autor.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_calor_autor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmb_calor_autor.FormattingEnabled = True
        Me.Cmb_calor_autor.Items.AddRange(New Object() {"Choi - Okos (1986)"})
        Me.Cmb_calor_autor.Location = New System.Drawing.Point(84, 38)
        Me.Cmb_calor_autor.Name = "Cmb_calor_autor"
        Me.Cmb_calor_autor.Size = New System.Drawing.Size(304, 23)
        Me.Cmb_calor_autor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja el autor deseado"
        '
        'Panel_MostrarEcuacion_Autores
        '
        Me.Panel_MostrarEcuacion_Autores.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_MostrarEcuacion_Autores.Location = New System.Drawing.Point(23, 103)
        Me.Panel_MostrarEcuacion_Autores.Name = "Panel_MostrarEcuacion_Autores"
        Me.Panel_MostrarEcuacion_Autores.Size = New System.Drawing.Size(462, 271)
        Me.Panel_MostrarEcuacion_Autores.TabIndex = 4
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(13, 13)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(438, 245)
        Me.Foto_Ecuacion.TabIndex = 0
        Me.Foto_Ecuacion.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btnVolver.FlatAppearance.BorderSize = 2
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Olive
        Me.btnVolver.Location = New System.Drawing.Point(491, 345)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(112, 29)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Olive
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Ivory
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSiguiente.Location = New System.Drawing.Point(491, 273)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(112, 30)
        Me.btnSiguiente.TabIndex = 6
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'Calor_Autor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(632, 401)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel_MostrarEcuacion_Autores)
        Me.Controls.Add(Me.Panel_calor_autor)
        Me.Name = "Calor_Autor"
        Me.Text = "Calor_Autor"
        Me.Panel_calor_autor.ResumeLayout(False)
        Me.Panel_calor_autor.PerformLayout()
        Me.Panel_MostrarEcuacion_Autores.ResumeLayout(False)
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_calor_autor As Panel
    Friend WithEvents Cmb_calor_autor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_MostrarEcuacion_Autores As Panel
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSiguiente As Button
End Class
