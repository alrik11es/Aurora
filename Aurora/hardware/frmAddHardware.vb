Imports MySql.Data.MySqlClient

Public Class frmAddHardware
    Dim equipo As Integer

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim query As String

        query = "INSERT INTO `hardware` (`id`, `nombre`, `notas`, `tipo`, `fecha_instalacion`, `localizacion`, `so`) " &
                "VALUES (NULL, '" & escape(txtNombre.Text) & "', '" & escape(txtNotas.Text) &
                "', '" & escape(slTipo.SelectedIndex) & "', '" & escape(dtFecha.Text) & "', '" & escape(equipo) & "');"

        Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec(query)
        recordset.Close()

        If frmEditarLocalizacion.Visible = True Then
            frmEditarLocalizacion.carga()
        End If
        Me.Close()
    End Sub
End Class