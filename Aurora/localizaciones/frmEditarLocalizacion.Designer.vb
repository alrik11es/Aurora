<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarLocalizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarLocalizacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnEditarLocalizacion = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listadoEquipos = New System.Windows.Forms.ListView()
        Me.ctMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAddEquipo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ctMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNotas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la localización"
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(10, 92)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(323, 74)
        Me.txtNotas.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empresa:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(142, 49)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(191, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(142, 23)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(191, 20)
        Me.txtEmpresa.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(344, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 103)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de contacto"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(141, 75)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(191, 20)
        Me.txtCorreo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre contacto:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(141, 49)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(141, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(191, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnEditarLocalizacion
        '
        Me.btnEditarLocalizacion.Location = New System.Drawing.Point(578, 303)
        Me.btnEditarLocalizacion.Name = "btnEditarLocalizacion"
        Me.btnEditarLocalizacion.Size = New System.Drawing.Size(104, 23)
        Me.btnEditarLocalizacion.TabIndex = 5
        Me.btnEditarLocalizacion.Text = "Editar localización"
        Me.btnEditarLocalizacion.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listadoEquipos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 285)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Equipos en localización"
        '
        'listadoEquipos
        '
        Me.listadoEquipos.ContextMenuStrip = Me.ctMenu
        Me.listadoEquipos.HideSelection = False
        Me.listadoEquipos.Location = New System.Drawing.Point(6, 19)
        Me.listadoEquipos.Name = "listadoEquipos"
        Me.listadoEquipos.Size = New System.Drawing.Size(313, 260)
        Me.listadoEquipos.SmallImageList = Me.imgList
        Me.listadoEquipos.TabIndex = 0
        Me.listadoEquipos.UseCompatibleStateImageBehavior = False
        Me.listadoEquipos.View = System.Windows.Forms.View.List
        '
        'ctMenu
        '
        Me.ctMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.EditarToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.ctMenu.Name = "ContextMenuStrip1"
        Me.ctMenu.Size = New System.Drawing.Size(107, 70)
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server_edit
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server_delete
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "server.png")
        Me.imgList.Images.SetKeyName(1, "computer.png")
        Me.imgList.Images.SetKeyName(2, "printer.png")
        Me.imgList.Images.SetKeyName(3, "router.png")
        Me.imgList.Images.SetKeyName(4, "switch_icon.png")
        Me.imgList.Images.SetKeyName(5, "image.png")
        '
        'btnAddEquipo
        '
        Me.btnAddEquipo.Location = New System.Drawing.Point(12, 303)
        Me.btnAddEquipo.Name = "btnAddEquipo"
        Me.btnAddEquipo.Size = New System.Drawing.Size(104, 23)
        Me.btnAddEquipo.TabIndex = 7
        Me.btnAddEquipo.Text = "Añadir equipo"
        Me.btnAddEquipo.UseVisualStyleBackColor = True
        '
        'frmEditarLocalizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 339)
        Me.Controls.Add(Me.btnAddEquipo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnEditarLocalizacion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditarLocalizacion"
        Me.Text = "Ver y editar localización"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ctMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnEditarLocalizacion As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents listadoEquipos As System.Windows.Forms.ListView
    Friend WithEvents btnAddEquipo As System.Windows.Forms.Button
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents ctMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
