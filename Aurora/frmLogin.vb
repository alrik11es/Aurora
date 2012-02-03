Public Class frmLogin

    Private Sub btnEntrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM tecnico WHERE usuario LIKE '" &
                                   txtUsuario.Text & "' AND password = '" & txtPassword.Text & "' ")

        If Not recordset.EOF Then
            frmPrincipal.menuItemVentana.Enabled = True
            frmPrincipal.menuItemConectar.Text = "Desconectar..."
            Me.Close()
        Else
            MsgBox("El usuario y/o la contraseña no existe", MsgBoxStyle.Information, "Error")
        End If
    End Sub
End Class