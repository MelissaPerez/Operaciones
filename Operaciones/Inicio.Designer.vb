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
        Me.Btn_Autores = New System.Windows.Forms.Button()
        Me.Btn_TipoProducto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_calor
        '
        Me.Btn_calor.Location = New System.Drawing.Point(43, 98)
        Me.Btn_calor.Name = "Btn_calor"
        Me.Btn_calor.Size = New System.Drawing.Size(125, 32)
        Me.Btn_calor.TabIndex = 0
        Me.Btn_calor.Text = "Calor específico"
        Me.Btn_calor.UseVisualStyleBackColor = True
        '
        'Btn_conductividad
        '
        Me.Btn_conductividad.Location = New System.Drawing.Point(265, 98)
        Me.Btn_conductividad.Name = "Btn_conductividad"
        Me.Btn_conductividad.Size = New System.Drawing.Size(87, 32)
        Me.Btn_conductividad.TabIndex = 1
        Me.Btn_conductividad.Text = "Conductividad"
        Me.Btn_conductividad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INICIO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Btn_Autores)
        Me.Panel1.Controls.Add(Me.Btn_TipoProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(15, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 154)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Por componentes del alimento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_Autores
        '
        Me.Btn_Autores.Location = New System.Drawing.Point(91, 78)
        Me.Btn_Autores.Name = "Btn_Autores"
        Me.Btn_Autores.Size = New System.Drawing.Size(200, 25)
        Me.Btn_Autores.TabIndex = 2
        Me.Btn_Autores.Text = "Por autores"
        Me.Btn_Autores.UseVisualStyleBackColor = True
        '
        'Btn_TipoProducto
        '
        Me.Btn_TipoProducto.Location = New System.Drawing.Point(91, 47)
        Me.Btn_TipoProducto.Name = "Btn_TipoProducto"
        Me.Btn_TipoProducto.Size = New System.Drawing.Size(200, 25)
        Me.Btn_TipoProducto.TabIndex = 1
        Me.Btn_TipoProducto.Text = "Por tipo de producto"
        Me.Btn_TipoProducto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Filtro de ecuaciones"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 340)
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
    Friend WithEvents Btn_Autores As Button
    Friend WithEvents Btn_TipoProducto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
