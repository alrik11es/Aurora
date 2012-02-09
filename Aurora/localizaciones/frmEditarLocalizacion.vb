Imports Aurora.MySQL

Public Class frmEditarLocalizacion
    Public id As Integer

    Private Sub frmEditarLocalizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & id & ";")
        txtEmpresa.Text = recordset.Fields("empresa").Value
        txtCorreo.Text = recordset.Fields("correo").Value
        txtDireccion.Text = recordset.Fields("direccion").Value
        txtNombre.Text = recordset.Fields("empresa").Value
        txtNotas.Text = recordset.Fields("notas").Value
        txtTelefono.Text = recordset.Fields("telefono").Value
    End Sub

    Private Sub frmEditarLocalizacion_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        id = vbNull
    End Sub

    Private Sub btnEditarLocalizacion_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarLocalizacion.Click
        Dim query As String

        query = "UPDATE localizacion SET empresa = '" & escape(txtEmpresa.Text) & "', contacto = '" & escape(txtNombre.Text) & "'," &
                " direccion = '" & escape(txtDireccion.Text) & "', telefono = '" & escape(txtTelefono.Text) & "', notas = '" & escape(txtNotas.Text) & "'," &
                " correo = '" & escape(txtCorreo.Text) & "' WHERE id = " & id & ";"

        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec(query)

        If frmListaLocalizacion.Visible = True Then
            frmListaLocalizacion.carga()
        End If

        Dim confirmacion As Integer = MsgBox("¿Desea cerrar esta ventana?", MsgBoxStyle.OkCancel)
        If confirmacion = vbOK Then
            Me.Close()
        End If

    End Sub
End Class