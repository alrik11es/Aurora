Public Class frmLogin

    Private Sub btnEntrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM usuario WHERE nombre LIKE '" &
                                   txtUsuario.Text & "' AND password = '" & txtPassword.Text & "' ")

        If recordset.GetRows <> 0 Then
            frmPrincipal.menuItemVentana.Enabled = True
            frmPrincipal.menuItemVentana.Text = "Desconectar"
            Me.Close()
        End If
    End Sub
End Class