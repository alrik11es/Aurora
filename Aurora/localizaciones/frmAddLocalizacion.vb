Imports Aurora.MySQLfunciones
Imports MySql.Data.MySqlClient

Public Class frmAddLocalizacion

    Private Sub btnCrearLocalizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnCrearLocalizacion.Click

        Dim query As String

        query = "INSERT INTO `localizacion` (`id`, `empresa`, `contacto`, `direccion`, `telefono`, `notas`, `correo`) " &
                "VALUES (NULL, '" & escape(txtEmpresa.Text) & "', '" & escape(txtNombre.Text) &
                "', '" & escape(txtDireccion.Text) & "', '" & escape(txtTelefono.Text) &
                "', '" & escape(txtNotas.Text) & "', '" & escape(txtCorreo.Text) & "');"

        'query = "INSERT INTO localizacion VALUES(default, '" & txtEmpresa.Text & "'," &
        '        "'" & txtNombre.Text & "','" & txtDireccion.Text & "'," &
        '        "'" & txtNotas.Text & "','" & txtCorreo.Text &
        '        "'" & txtTelefono.Text & "')"

        Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec(query)
        recordset.Close()

        If frmListaLocalizacion.Visible = True Then
            frmListaLocalizacion.carga()
        End If
        Me.Close()
    End Sub
End Class