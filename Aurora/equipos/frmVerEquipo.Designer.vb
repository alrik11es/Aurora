<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerEquipo))
        Me.ctMenuHardware = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgListHardware = New System.Windows.Forms.ImageList(Me.components)
        Me.imgListConfig = New System.Windows.Forms.ImageList(Me.components)
        Me.imgListSoft = New System.Windows.Forms.ImageList(Me.components)
        Me.imgListIncidencias = New System.Windows.Forms.ImageList(Me.components)
        Me.tabConfig = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dataGridMisc = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataGridUP = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConnectIP = New System.Windows.Forms.Button()
        Me.dataGridIp = New System.Windows.Forms.DataGridView()
        Me.tabHardware = New System.Windows.Forms.TabPage()
        Me.dgHardware = New System.Windows.Forms.DataGridView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tabEquipo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSO = New System.Windows.Forms.Label()
        Me.btnEditarEquipo = New System.Windows.Forms.Button()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ctMenuHardware.SuspendLayout()
        Me.tabConfig.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dataGridMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataGridUP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridIp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHardware.SuspendLayout()
        CType(Me.dgHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEquipo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctMenuHardware
        '
        Me.ctMenuHardware.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirToolStripMenuItem, Me.VerToolStripMenuItem, Me.EditarToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.ctMenuHardware.Name = "ContextMenuStrip1"
        Me.ctMenuHardware.Size = New System.Drawing.Size(117, 92)
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.drive_add
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.drive_magnify
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.drive_edit
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.drive_delete
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'imgListHardware
        '
        Me.imgListHardware.ImageStream = CType(resources.GetObject("imgListHardware.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListHardware.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListHardware.Images.SetKeyName(0, "server.png")
        Me.imgListHardware.Images.SetKeyName(1, "computer.png")
        Me.imgListHardware.Images.SetKeyName(2, "printer.png")
        Me.imgListHardware.Images.SetKeyName(3, "router.png")
        Me.imgListHardware.Images.SetKeyName(4, "switch_icon.png")
        Me.imgListHardware.Images.SetKeyName(5, "image.png")
        '
        'imgListConfig
        '
        Me.imgListConfig.ImageStream = CType(resources.GetObject("imgListConfig.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListConfig.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListConfig.Images.SetKeyName(0, "server.png")
        Me.imgListConfig.Images.SetKeyName(1, "computer.png")
        Me.imgListConfig.Images.SetKeyName(2, "printer.png")
        Me.imgListConfig.Images.SetKeyName(3, "router.png")
        Me.imgListConfig.Images.SetKeyName(4, "switch_icon.png")
        Me.imgListConfig.Images.SetKeyName(5, "image.png")
        '
        'imgListSoft
        '
        Me.imgListSoft.ImageStream = CType(resources.GetObject("imgListSoft.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListSoft.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListSoft.Images.SetKeyName(0, "server.png")
        Me.imgListSoft.Images.SetKeyName(1, "computer.png")
        Me.imgListSoft.Images.SetKeyName(2, "printer.png")
        Me.imgListSoft.Images.SetKeyName(3, "router.png")
        Me.imgListSoft.Images.SetKeyName(4, "switch_icon.png")
        Me.imgListSoft.Images.SetKeyName(5, "image.png")
        '
        'imgListIncidencias
        '
        Me.imgListIncidencias.ImageStream = CType(resources.GetObject("imgListIncidencias.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListIncidencias.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListIncidencias.Images.SetKeyName(0, "server.png")
        Me.imgListIncidencias.Images.SetKeyName(1, "computer.png")
        Me.imgListIncidencias.Images.SetKeyName(2, "printer.png")
        Me.imgListIncidencias.Images.SetKeyName(3, "router.png")
        Me.imgListIncidencias.Images.SetKeyName(4, "switch_icon.png")
        Me.imgListIncidencias.Images.SetKeyName(5, "image.png")
        '
        'tabConfig
        '
        Me.tabConfig.Controls.Add(Me.GroupBox4)
        Me.tabConfig.Controls.Add(Me.GroupBox3)
        Me.tabConfig.Controls.Add(Me.GroupBox2)
        Me.tabConfig.Location = New System.Drawing.Point(4, 22)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.Size = New System.Drawing.Size(515, 401)
        Me.tabConfig.TabIndex = 3
        Me.tabConfig.Text = "Configuraciones"
        Me.tabConfig.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dataGridMisc)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 230)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(498, 163)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Miscelánea"
        '
        'dataGridMisc
        '
        Me.dataGridMisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridMisc.Location = New System.Drawing.Point(6, 19)
        Me.dataGridMisc.Name = "dataGridMisc"
        Me.dataGridMisc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridMisc.Size = New System.Drawing.Size(487, 138)
        Me.dataGridMisc.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataGridUP)
        Me.GroupBox3.Location = New System.Drawing.Point(218, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 216)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de usuarios y contraseñas"
        '
        'dataGridUP
        '
        Me.dataGridUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridUP.Location = New System.Drawing.Point(6, 19)
        Me.dataGridUP.Name = "dataGridUP"
        Me.dataGridUP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridUP.Size = New System.Drawing.Size(277, 190)
        Me.dataGridUP.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConnectIP)
        Me.GroupBox2.Controls.Add(Me.dataGridIp)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 216)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de IP's"
        '
        'btnConnectIP
        '
        Me.btnConnectIP.Location = New System.Drawing.Point(50, 186)
        Me.btnConnectIP.Name = "btnConnectIP"
        Me.btnConnectIP.Size = New System.Drawing.Size(102, 23)
        Me.btnConnectIP.TabIndex = 3
        Me.btnConnectIP.Text = "Conectar con IP"
        Me.btnConnectIP.UseVisualStyleBackColor = True
        '
        'dataGridIp
        '
        Me.dataGridIp.AllowUserToResizeRows = False
        Me.dataGridIp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridIp.Location = New System.Drawing.Point(6, 19)
        Me.dataGridIp.Name = "dataGridIp"
        Me.dataGridIp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridIp.Size = New System.Drawing.Size(192, 161)
        Me.dataGridIp.TabIndex = 2
        '
        'tabHardware
        '
        Me.tabHardware.Controls.Add(Me.dgHardware)
        Me.tabHardware.Controls.Add(Me.ListView1)
        Me.tabHardware.Location = New System.Drawing.Point(4, 22)
        Me.tabHardware.Name = "tabHardware"
        Me.tabHardware.Size = New System.Drawing.Size(515, 401)
        Me.tabHardware.TabIndex = 2
        Me.tabHardware.Text = "Hardware"
        Me.tabHardware.UseVisualStyleBackColor = True
        '
        'dgHardware
        '
        Me.dgHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgHardware.Location = New System.Drawing.Point(0, 0)
        Me.dgHardware.Name = "dgHardware"
        Me.dgHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgHardware.Size = New System.Drawing.Size(515, 401)
        Me.dgHardware.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.ContextMenuStrip = Me.ctMenuHardware
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(515, 401)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'tabEquipo
        '
        Me.tabEquipo.Controls.Add(Me.GroupBox1)
        Me.tabEquipo.Location = New System.Drawing.Point(4, 22)
        Me.tabEquipo.Name = "tabEquipo"
        Me.tabEquipo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEquipo.Size = New System.Drawing.Size(515, 401)
        Me.tabEquipo.TabIndex = 1
        Me.tabEquipo.Text = "Equipo"
        Me.tabEquipo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSO)
        Me.GroupBox1.Controls.Add(Me.btnEditarEquipo)
        Me.GroupBox1.Controls.Add(Me.txtNotas)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 378)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del equipo"
        '
        'lblSO
        '
        Me.lblSO.AutoSize = True
        Me.lblSO.Location = New System.Drawing.Point(6, 89)
        Me.lblSO.Name = "lblSO"
        Me.lblSO.Size = New System.Drawing.Size(94, 13)
        Me.lblSO.TabIndex = 13
        Me.lblSO.Text = "Sistema operativo:"
        '
        'btnEditarEquipo
        '
        Me.btnEditarEquipo.Location = New System.Drawing.Point(420, 15)
        Me.btnEditarEquipo.Name = "btnEditarEquipo"
        Me.btnEditarEquipo.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarEquipo.TabIndex = 11
        Me.btnEditarEquipo.Text = "Editar"
        Me.btnEditarEquipo.UseVisualStyleBackColor = True
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(9, 146)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ReadOnly = True
        Me.txtNotas.Size = New System.Drawing.Size(486, 226)
        Me.txtNotas.TabIndex = 10
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LinkLabel1.Location = New System.Drawing.Point(95, 25)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Perteneciente a"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(7, 105)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(53, 13)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Instalado:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 71)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(81, 13)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "Tipo de equipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Notas:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 52)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre equipo:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabEquipo)
        Me.TabControl1.Controls.Add(Me.tabHardware)
        Me.TabControl1.Controls.Add(Me.tabConfig)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 427)
        Me.TabControl1.TabIndex = 4
        '
        'frmVerEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 427)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerEquipo"
        Me.Text = "Equipo: NOMBRE"
        Me.ctMenuHardware.ResumeLayout(False)
        Me.tabConfig.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dataGridMisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataGridUP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dataGridIp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHardware.ResumeLayout(False)
        CType(Me.dgHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEquipo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgListHardware As System.Windows.Forms.ImageList
    Friend WithEvents imgListConfig As System.Windows.Forms.ImageList
    Friend WithEvents imgListSoft As System.Windows.Forms.ImageList
    Friend WithEvents imgListIncidencias As System.Windows.Forms.ImageList
    Friend WithEvents ctMenuHardware As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabConfig As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridMisc As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridUP As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnectIP As System.Windows.Forms.Button
    Friend WithEvents dataGridIp As System.Windows.Forms.DataGridView
    Friend WithEvents tabHardware As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents tabEquipo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSO As System.Windows.Forms.Label
    Friend WithEvents btnEditarEquipo As System.Windows.Forms.Button
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents dgHardware As System.Windows.Forms.DataGridView
End Class
