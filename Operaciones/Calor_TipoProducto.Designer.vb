<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calor_TipoProducto
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
        Me.Panel_MostrarEcuacion = New System.Windows.Forms.Panel()
        Me.Foto_Ecuacion = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel_TipoProducto = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_MostrarEcuacion.SuspendLayout()
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TipoProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_MostrarEcuacion
        '
        Me.Panel_MostrarEcuacion.Controls.Add(Me.Foto_Ecuacion)
        Me.Panel_MostrarEcuacion.Location = New System.Drawing.Point(22, 95)
        Me.Panel_MostrarEcuacion.Name = "Panel_MostrarEcuacion"
        Me.Panel_MostrarEcuacion.Size = New System.Drawing.Size(580, 194)
        Me.Panel_MostrarEcuacion.TabIndex = 3
        '
        'Foto_Ecuacion
        '
        Me.Foto_Ecuacion.Location = New System.Drawing.Point(31, 19)
        Me.Foto_Ecuacion.Name = "Foto_Ecuacion"
        Me.Foto_Ecuacion.Size = New System.Drawing.Size(512, 154)
        Me.Foto_Ecuacion.TabIndex = 0
        Me.Foto_Ecuacion.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escoja el tipo de producto"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Panel_TipoProducto
        '
        Me.Panel_TipoProducto.Controls.Add(Me.ComboBox1)
        Me.Panel_TipoProducto.Controls.Add(Me.Label1)
        Me.Panel_TipoProducto.Location = New System.Drawing.Point(22, 21)
        Me.Panel_TipoProducto.Name = "Panel_TipoProducto"
        Me.Panel_TipoProducto.Size = New System.Drawing.Size(581, 68)
        Me.Panel_TipoProducto.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Calor_TipoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel_MostrarEcuacion)
        Me.Controls.Add(Me.Panel_TipoProducto)
        Me.Name = "Calor_TipoProducto"
        Me.Text = "CalorEspecifico"
        Me.Panel_MostrarEcuacion.ResumeLayout(False)
        CType(Me.Foto_Ecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TipoProducto.ResumeLayout(False)
        Me.Panel_TipoProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_MostrarEcuacion As Panel
    Friend WithEvents Foto_Ecuacion As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel_TipoProducto As Panel
    Friend WithEvents Button1 As Button
End Class
