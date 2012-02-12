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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabEquipo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tabHardware = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tabConfig = New System.Windows.Forms.TabPage()
        Me.tabSoft = New System.Windows.Forms.TabPage()
        Me.tabIncidencias = New System.Windows.Forms.TabPage()
        Me.imgListHardware = New System.Windows.Forms.ImageList(Me.components)
        Me.imgListConfig = New System.Windows.Forms.ImageList(Me.components)
        Me.imgListSoft = New System.Windows.Forms.ImageList(Me.components)
        Me.imgListIncidencias = New System.Windows.Forms.ImageList(Me.components)
        Me.lblSO = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabEquipo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHardware.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabEquipo)
        Me.TabControl1.Controls.Add(Me.tabHardware)
        Me.TabControl1.Controls.Add(Me.tabConfig)
        Me.TabControl1.Controls.Add(Me.tabSoft)
        Me.TabControl1.Controls.Add(Me.tabIncidencias)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 427)
        Me.TabControl1.TabIndex = 4
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Grafica de incidencias:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(9, 266)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 100)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(9, 146)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ReadOnly = True
        Me.txtNotas.Size = New System.Drawing.Size(486, 99)
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
        'tabHardware
        '
        Me.tabHardware.Controls.Add(Me.ListView1)
        Me.tabHardware.Location = New System.Drawing.Point(4, 22)
        Me.tabHardware.Name = "tabHardware"
        Me.tabHardware.Size = New System.Drawing.Size(515, 401)
        Me.tabHardware.TabIndex = 2
        Me.tabHardware.Text = "Hardware"
        Me.tabHardware.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(515, 401)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'tabConfig
        '
        Me.tabConfig.Location = New System.Drawing.Point(4, 22)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.Size = New System.Drawing.Size(515, 401)
        Me.tabConfig.TabIndex = 3
        Me.tabConfig.Text = "Configuraciones"
        Me.tabConfig.UseVisualStyleBackColor = True
        '
        'tabSoft
        '
        Me.tabSoft.Location = New System.Drawing.Point(4, 22)
        Me.tabSoft.Name = "tabSoft"
        Me.tabSoft.Size = New System.Drawing.Size(515, 401)
        Me.tabSoft.TabIndex = 4
        Me.tabSoft.Text = "Software"
        Me.tabSoft.UseVisualStyleBackColor = True
        '
        'tabIncidencias
        '
        Me.tabIncidencias.Location = New System.Drawing.Point(4, 22)
        Me.tabIncidencias.Name = "tabIncidencias"
        Me.tabIncidencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIncidencias.Size = New System.Drawing.Size(515, 401)
        Me.tabIncidencias.TabIndex = 0
        Me.tabIncidencias.Text = "Incidencias"
        Me.tabIncidencias.UseVisualStyleBackColor = True
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
        'lblSO
        '
        Me.lblSO.AutoSize = True
        Me.lblSO.Location = New System.Drawing.Point(6, 89)
        Me.lblSO.Name = "lblSO"
        Me.lblSO.Size = New System.Drawing.Size(81, 13)
        Me.lblSO.TabIndex = 13
        Me.lblSO.Text = "Tipo de equipo:"
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
        Me.TabControl1.ResumeLayout(False)
        Me.tabEquipo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHardware.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabEquipo As System.Windows.Forms.TabPage
    Friend WithEvents tabHardware As System.Windows.Forms.TabPage
    Friend WithEvents tabConfig As System.Windows.Forms.TabPage
    Friend WithEvents tabSoft As System.Windows.Forms.TabPage
    Friend WithEvents tabIncidencias As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgListHardware As System.Windows.Forms.ImageList
    Friend WithEvents imgListConfig As System.Windows.Forms.ImageList
    Friend WithEvents imgListSoft As System.Windows.Forms.ImageList
    Friend WithEvents imgListIncidencias As System.Windows.Forms.ImageList
    Friend WithEvents lblSO As System.Windows.Forms.Label
End Class
