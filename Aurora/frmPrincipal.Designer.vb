<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemConectar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarMySQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardwareToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TécnicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexiónMySQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirlocalizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecnicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem1, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(667, 24)
        Me.menu.TabIndex = 0
        Me.menu.Text = "msMenu"
        '
        'ArchivoToolStripMenuItem1
        '
        Me.ArchivoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemConectar, Me.ConfigurarMySQLToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem1.Name = "ArchivoToolStripMenuItem1"
        Me.ArchivoToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem1.Text = "&Archivo"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalizaciónToolStripMenuItem, Me.EquipoToolStripMenuItem, Me.TécnicoToolStripMenuItem, Me.IncidenciasToolStripMenuItem1})
        Me.VentanaToolStripMenuItem.Enabled = False
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VentanaToolStripMenuItem.Text = "&Ventana"
        '
        'IncidenciasToolStripMenuItem1
        '
        Me.IncidenciasToolStripMenuItem1.Name = "IncidenciasToolStripMenuItem1"
        Me.IncidenciasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.IncidenciasToolStripMenuItem1.Text = "I&ncidencias"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarToolStripMenuItem, Me.ConexiónMySQLToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.OpcionesToolStripMenuItem.Text = "&Ventana"
        '
        'IncidenciasToolStripMenuItem
        '
        Me.IncidenciasToolStripMenuItem.Name = "IncidenciasToolStripMenuItem"
        Me.IncidenciasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IncidenciasToolStripMenuItem.Text = "I&ncidencias"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'menuItemConectar
        '
        Me.menuItemConectar.Enabled = False
        Me.menuItemConectar.Image = Global.Aurora.My.Resources.Resources.connect
        Me.menuItemConectar.Name = "menuItemConectar"
        Me.menuItemConectar.Size = New System.Drawing.Size(172, 22)
        Me.menuItemConectar.Text = "&Conectar..."
        '
        'ConfigurarMySQLToolStripMenuItem
        '
        Me.ConfigurarMySQLToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.database_connect
        Me.ConfigurarMySQLToolStripMenuItem.Name = "ConfigurarMySQLToolStripMenuItem"
        Me.ConfigurarMySQLToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConfigurarMySQLToolStripMenuItem.Text = "Configurar MySQL"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.Aurora.My.Resources.Resources.door
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'LocalizaciónToolStripMenuItem
        '
        Me.LocalizaciónToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.map_magnify
        Me.LocalizaciónToolStripMenuItem.Name = "LocalizaciónToolStripMenuItem"
        Me.LocalizaciónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LocalizaciónToolStripMenuItem.Text = "&Localización"
        '
        'EquipoToolStripMenuItem
        '
        Me.EquipoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HardwareToolStripMenuItem1, Me.SoftwareToolStripMenuItem1, Me.ConfiguracionToolStripMenuItem})
        Me.EquipoToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.computer
        Me.EquipoToolStripMenuItem.Name = "EquipoToolStripMenuItem"
        Me.EquipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EquipoToolStripMenuItem.Text = "&Equipo"
        '
        'HardwareToolStripMenuItem1
        '
        Me.HardwareToolStripMenuItem1.Image = Global.Aurora.My.Resources.Resources.server
        Me.HardwareToolStripMenuItem1.Name = "HardwareToolStripMenuItem1"
        Me.HardwareToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.HardwareToolStripMenuItem1.Text = "&Hardware"
        '
        'SoftwareToolStripMenuItem1
        '
        Me.SoftwareToolStripMenuItem1.Image = Global.Aurora.My.Resources.Resources.application
        Me.SoftwareToolStripMenuItem1.Name = "SoftwareToolStripMenuItem1"
        Me.SoftwareToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.SoftwareToolStripMenuItem1.Text = "&Software"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.page_gear
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "&Configuracion"
        '
        'TécnicoToolStripMenuItem
        '
        Me.TécnicoToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.status_online
        Me.TécnicoToolStripMenuItem.Name = "TécnicoToolStripMenuItem"
        Me.TécnicoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TécnicoToolStripMenuItem.Text = "&Técnico"
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.help
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la ayuda"
        '
        'ConectarToolStripMenuItem
        '
        Me.ConectarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.connect
        Me.ConectarToolStripMenuItem.Name = "ConectarToolStripMenuItem"
        Me.ConectarToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ConectarToolStripMenuItem.Text = "C&onectar..."
        '
        'ConexiónMySQLToolStripMenuItem
        '
        Me.ConexiónMySQLToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.database_connect
        Me.ConexiónMySQLToolStripMenuItem.Name = "ConexiónMySQLToolStripMenuItem"
        Me.ConexiónMySQLToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ConexiónMySQLToolStripMenuItem.Text = "&Conexión MySQL"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.door
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AñadirlocalizaciónToolStripMenuItem
        '
        Me.AñadirlocalizaciónToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.map_magnify
        Me.AñadirlocalizaciónToolStripMenuItem.Name = "AñadirlocalizaciónToolStripMenuItem"
        Me.AñadirlocalizaciónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AñadirlocalizaciónToolStripMenuItem.Text = "&Localizaciones"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HardwareToolStripMenuItem, Me.SoftwareToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem})
        Me.EquiposToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.computer
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EquiposToolStripMenuItem.Text = "&Equipos"
        '
        'HardwareToolStripMenuItem
        '
        Me.HardwareToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server
        Me.HardwareToolStripMenuItem.Name = "HardwareToolStripMenuItem"
        Me.HardwareToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.HardwareToolStripMenuItem.Text = "&Hardware"
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.application
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SoftwareToolStripMenuItem.Text = "&Software"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.page_gear
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ConfiguracionesToolStripMenuItem.Text = "&Configuraciones"
        '
        'TecnicosToolStripMenuItem
        '
        Me.TecnicosToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.status_online
        Me.TecnicosToolStripMenuItem.Name = "TecnicosToolStripMenuItem"
        Me.TecnicosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TecnicosToolStripMenuItem.Text = "&Tecnicos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de Aurora"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 503)
        Me.Controls.Add(Me.menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menu
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aurora"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConexiónMySQLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirlocalizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TecnicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncidenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TécnicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemConectar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarMySQLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardwareToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncidenciasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
