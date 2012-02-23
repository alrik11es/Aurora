Public Class frmPrincipal
    Public conexion As MySQLConexion

    Private Sub connect()
        Dim conn As MySQLConexion = New MySQLConexion()
        If conn.exist() Then
            conexion = conn
            conexion.connect()
            Me.menuItemConectar.Enabled = True
            frmLogin.MdiParent = Me
            frmLogin.Show()
        End If
        'PRUEBAS MARTA frmUsuarios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfigurarMySQLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarMySQLToolStripMenuItem.Click
        frmMysqlConnect.MdiParent = Me
        frmMysqlConnect.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub menuItemConectar_Click(sender As System.Object, e As System.EventArgs) Handles menuItemConectar.Click

        If menuItemConectar.Text <> "Desconectar" Then
            connect()
        Else
            menuItemConectar.Text = "&Conectar..."
            menuItemVentana.Enabled = False
        End If
        
    End Sub

    Private Sub LocalizaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LocalizaciónToolStripMenuItem.Click
        frmListaLocalizacion.MdiParent = Me
        frmListaLocalizacion.Show()
    End Sub

    Private Sub AñadirEquipoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmAddEquipo.MdiParent = Me
        frmAddEquipo.Show()
    End Sub

    Private Sub EquipoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EquipoToolStripMenuItem.Click
        frmListarEquipos.MdiParent = Me
        frmListarEquipos.Show()
    End Sub

    Private Sub TécnicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TécnicoToolStripMenuItem.Click
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub
End Class
