Public Class frmPrincipal
    Public conexion As MySQLConexion

    Private Sub SalirToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfigurarMySQLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarMySQLToolStripMenuItem.Click
        frmMysqlConnect.MdiParent = Me
        frmMysqlConnect.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim conn As MySQLConexion = New MySQLConexion()
        If conn.exist() Then
            conexion = conn
            conexion.connect()
            Me.menuItemConectar.Enabled = True
            frmLogin.MdiParent = Me
            frmLogin.Show()
        End If

    End Sub

    Private Sub menuItemConectar_Click(sender As System.Object, e As System.EventArgs) Handles menuItemConectar.Click

        If menuItemConectar.Text <> "Desconectar" Then
            conexion = New MySQLConexion()
            frmLogin.MdiParent = Me
            frmLogin.Show()
        Else

        End If
        
    End Sub

    Private Sub LocalizaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LocalizaciónToolStripMenuItem.Click
        frmListaLocalizacion.MdiParent = Me
        frmListaLocalizacion.Show()
    End Sub
End Class
