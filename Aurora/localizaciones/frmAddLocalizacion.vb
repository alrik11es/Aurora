Public Class frmAddLocalizacion

    Private Sub btnCrearLocalizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnCrearLocalizacion.Click

        Dim query As String

        query = "INSERT INTO localizacion VALUES(default, '" & txtEmpresa.Text & "'," &
                "'" & txtNombre.Text & "','" & txtDireccion.Text & "'," &
                "'" & txtNotas.Text & "','" & txtCorreo.Text & "')"

        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec(query)

    End Sub
End Class