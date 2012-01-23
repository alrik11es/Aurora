Public Class frmLogin

    Private Sub btnEntrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        frmPrincipal.conexion.exec("SELECT * FROM usuario WHERE nombre LIKE '" &
                                   txtUsuario.Text & "' AND password = '" & txtPassword.Text & "' ")
    End Sub
End Class