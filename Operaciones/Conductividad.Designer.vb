<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conductividad
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel_MostrarEcuacion_Conductividad = New System.Windows.Forms.Panel()
        Me.lblImagenConductividad = New System.Windows.Forms.Label()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.Panel_TipoProducto = New System.Windows.Forms.Panel()
        Me.cmbConductividad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Panel_MostrarEcuacion_Conductividad.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TipoProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btnVolver.FlatAppearance.BorderSize = 2
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Olive
        Me.btnVolver.Location = New System.Drawing.Point(61, 286)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 31)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Panel_MostrarEcuacion_Conductividad
        '
        Me.Panel_MostrarEcuacion_Conductividad.Controls.Add(Me.lblImagenConductividad)
        Me.Panel_MostrarEcuacion_Conductividad.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_MostrarEcuacion_Conductividad.Location = New System.Drawing.Point(22, 89)
        Me.Panel_MostrarEcuacion_Conductividad.Name = "Panel_MostrarEcuacion_Conductividad"
        Me.Panel_MostrarEcuacion_Conductividad.Size = New System.Drawing.Size(580, 191)
        Me.Panel_MostrarEcuacion_Conductividad.TabIndex = 6
        '
        'lblImagenConductividad
        '
        Me.lblImagenConductividad.AutoSize = True
        Me.lblImagenConductividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblImagenConductividad.Location = New System.Drawing.Point(36, 133)
        Me.lblImagenConductividad.Name = "lblImagenConductividad"
        Me.lblImagenConductividad.Size = New System.Drawing.Size(10, 13)
        Me.lblImagenConductividad.TabIndex = 1
        Me.lblImagenConductividad.Text = "-"
        Me.lblImagenConductividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(17, 3)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(548, 127)
        Me.Foto_Ecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Foto_Ecuacion.TabIndex = 0
        Me.Foto_Ecuacion.TabStop = False
        '
        'Panel_TipoProducto
        '
        Me.Panel_TipoProducto.Controls.Add(Me.cmbConductividad)
        Me.Panel_TipoProducto.Controls.Add(Me.Label1)
        Me.Panel_TipoProducto.Location = New System.Drawing.Point(22, 15)
        Me.Panel_TipoProducto.Name = "Panel_TipoProducto"
        Me.Panel_TipoProducto.Size = New System.Drawing.Size(581, 68)
        Me.Panel_TipoProducto.TabIndex = 5
        '
        'cmbConductividad
        '
        Me.cmbConductividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConductividad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbConductividad.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConductividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbConductividad.FormattingEnabled = True
        Me.cmbConductividad.Items.AddRange(New Object() {"Remolacha", "Zanahoria", "Perejil", "Apio", "Uva pasa", "Papaya", "Melón", "Manzana", "Pera", "Zumo de frutas (fraccion agua)", "Zumo de frutas (fraccion agua, temperatura, temp. congelacion)", "Carne molida", "Carnes (fraccion agua)", "Carnes (fraccion agua, temperatura)", "Surimi", "Pan blanco"})
        Me.cmbConductividad.Location = New System.Drawing.Point(99, 42)
        Me.cmbConductividad.Name = "cmbConductividad"
        Me.cmbConductividad.Size = New System.Drawing.Size(304, 23)
        Me.cmbConductividad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja el tipo de producto"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Olive
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Constantia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSiguiente.Location = New System.Drawing.Point(473, 287)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(97, 28)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'Conductividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(625, 329)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel_MostrarEcuacion_Conductividad)
        Me.Controls.Add(Me.Panel_TipoProducto)
        Me.Name = "Conductividad"
        Me.Text = "Conductividad"
        Me.Panel_MostrarEcuacion_Conductividad.ResumeLayout(False)
        Me.Panel_MostrarEcuacion_Conductividad.PerformLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TipoProducto.ResumeLayout(False)
        Me.Panel_TipoProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel_MostrarEcuacion_Conductividad As Panel
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents Panel_TipoProducto As Panel
    Friend WithEvents cmbConductividad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblImagenConductividad As Label
    Friend WithEvents btnSiguiente As Button
End Class
