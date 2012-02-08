Public Class frmAddLocalizacion

    Private Sub btnCrearLocalizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnCrearLocalizacion.Click

        Dim query As String

        query = "INSERT INTO `localizacion` (`id`, `empresa`, `contacto`, `direccion`, `telefono`, `notas`, `correo`) " &
                "VALUES (NULL, '" & txtEmpresa.Text & "', '" & txtNombre.Text & "', '" & txtDireccion.Text & "', '" & txtTelefono.Text & "', '" & txtNotas.Text & "', '" & txtCorreo.Text & "');"

        'query = "INSERT INTO localizacion VALUES(default, '" & txtEmpresa.Text & "'," &
        '        "'" & txtNombre.Text & "','" & txtDireccion.Text & "'," &
        '        "'" & txtNotas.Text & "','" & txtCorreo.Text &
        '        "'" & txtTelefono.Text & "')"

        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec(query)

        frmListaLocalizacion.Close()
        frmListaLocalizacion.MdiParent = frmPrincipal
        frmListaLocalizacion.Show()
        Me.Close()
    End Sub
End Class