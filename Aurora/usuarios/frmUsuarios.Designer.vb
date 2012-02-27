<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.usr = New System.Windows.Forms.DataGridView()
        Me.usuarios = New System.Windows.Forms.DataGridView()
        CType(Me.usr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usr
        '
        Me.usr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usr.Location = New System.Drawing.Point(0, 0)
        Me.usr.Name = "usr"
        Me.usr.Size = New System.Drawing.Size(470, 360)
        Me.usr.TabIndex = 6
        '
        'usuarios
        '
        Me.usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usuarios.Location = New System.Drawing.Point(0, 0)
        Me.usuarios.Name = "usuarios"
        Me.usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usuarios.Size = New System.Drawing.Size(565, 384)
        Me.usuarios.TabIndex = 0
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(565, 384)
        Me.Controls.Add(Me.usuarios)
        Me.Name = "frmUsuarios"
        Me.Text = "Técnicos"
        CType(Me.usr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usr As System.Windows.Forms.DataGridView
    Friend WithEvents usuarios As System.Windows.Forms.DataGridView
End Class
