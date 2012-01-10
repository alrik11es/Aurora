Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfigurarMySQLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarMySQLToolStripMenuItem.Click
        frmMysqlConnect.MdiParent = Me
        frmMysqlConnect.Show()
    End Sub
End Class
