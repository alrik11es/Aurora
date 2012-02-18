<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MiControlUsuario1 = New Aurora.MiControlUsuario()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MiControlUsuario1
        '
        Me.MiControlUsuario1.Email = ""
        Me.MiControlUsuario1.Location = New System.Drawing.Point(0, 0)
        Me.MiControlUsuario1.Name = "MiControlUsuario1"
        Me.MiControlUsuario1.Password = ""
        Me.MiControlUsuario1.Size = New System.Drawing.Size(460, 338)
        Me.MiControlUsuario1.TabIndex = 0
        Me.MiControlUsuario1.Telefono = ""
        Me.MiControlUsuario1.usuario = ""
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(60, 344)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(308, 344)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 23)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Editar Usuario"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmEditarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 399)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MiControlUsuario1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditarUsuario"
        Me.Text = "Editar Usuario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MiControlUsuario1 As Aurora.MiControlUsuario
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
