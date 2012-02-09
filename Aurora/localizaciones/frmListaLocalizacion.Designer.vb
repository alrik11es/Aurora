<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaLocalizacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaLocalizacion))
        Me.listaLocalizaciones = New System.Windows.Forms.ListView()
        Me.ctMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnAddEquipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Iconos = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ctMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaLocalizaciones
        '
        Me.listaLocalizaciones.ContextMenuStrip = Me.ctMenu
        Me.listaLocalizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listaLocalizaciones.HideSelection = False
        Me.listaLocalizaciones.Location = New System.Drawing.Point(0, 25)
        Me.listaLocalizaciones.MultiSelect = False
        Me.listaLocalizaciones.Name = "listaLocalizaciones"
        Me.listaLocalizaciones.Size = New System.Drawing.Size(526, 421)
        Me.listaLocalizaciones.SmallImageList = Me.Iconos
        Me.listaLocalizaciones.TabIndex = 4
        Me.listaLocalizaciones.UseCompatibleStateImageBehavior = False
        Me.listaLocalizaciones.View = System.Windows.Forms.View.List
        '
        'ctMenu
        '
        Me.ctMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnEditar, Me.mnBorrar, Me.ToolStripSeparator1, Me.mnAddEquipo})
        Me.ctMenu.Name = "ctMenu"
        Me.ctMenu.Size = New System.Drawing.Size(157, 98)
        '
        'mnEditar
        '
        Me.mnEditar.Image = Global.Aurora.My.Resources.Resources.map_edit
        Me.mnEditar.Name = "mnEditar"
        Me.mnEditar.Size = New System.Drawing.Size(156, 22)
        Me.mnEditar.Text = "Editar"
        '
        'mnBorrar
        '
        Me.mnBorrar.Image = Global.Aurora.My.Resources.Resources.map_delete
        Me.mnBorrar.Name = "mnBorrar"
        Me.mnBorrar.Size = New System.Drawing.Size(156, 22)
        Me.mnBorrar.Text = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'mnAddEquipo
        '
        Me.mnAddEquipo.Image = Global.Aurora.My.Resources.Resources.server_add
        Me.mnAddEquipo.Name = "mnAddEquipo"
        Me.mnAddEquipo.Size = New System.Drawing.Size(156, 22)
        Me.mnAddEquipo.Text = "Agregar equipo"
        '
        'Iconos
        '
        Me.Iconos.ImageStream = CType(resources.GetObject("Iconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Iconos.TransparentColor = System.Drawing.Color.Transparent
        Me.Iconos.Images.SetKeyName(0, "user_suit.ico")
        Me.Iconos.Images.SetKeyName(1, "user_gray.ico")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(526, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Aurora.My.Resources.Resources.map_add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Añadir localización"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Aurora.My.Resources.Resources.map_edit
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Editar localización"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Aurora.My.Resources.Resources.map_delete
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Borrar localización"
        '
        'frmListaLocalizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 446)
        Me.Controls.Add(Me.listaLocalizaciones)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaLocalizacion"
        Me.Text = "Localizaciones"
        Me.ctMenu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listaLocalizaciones As System.Windows.Forms.ListView
    Friend WithEvents Iconos As System.Windows.Forms.ImageList
    Friend WithEvents ctMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnAddEquipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
End Class
