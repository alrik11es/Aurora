Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnEntrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec("SELECT * FROM tecnico WHERE usuario LIKE '" &
                                   escape(txtUsuario.Text) & "' AND password = '" & escape(txtPassword.Text) & "' ")

        'recordset.Read()

        'MsgBox(recordset.GetString(1))

        If recordset.HasRows Then
            frmPrincipal.menuItemVentana.Enabled = True
            frmPrincipal.menuItemConectar.Text = "Desconectar..."
            Me.Close()
        Else
            MsgBox("El usuario y/o la contraseña no existe", MsgBoxStyle.Information, "Error")
        End If

        recordset.Close()
    End Sub
End Class