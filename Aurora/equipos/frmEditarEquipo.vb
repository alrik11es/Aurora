Public Class frmEditarEquipo
    Public localizacion As Integer
    Public id As Integer

    Private Sub frmEditarEquipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM equipo WHERE id = " & id & ";")
        txtNombre.Text = recordset.Fields("nombre").Value
        txtNotas.Text = recordset.Fields("notas").Value
        slTipo.SelectedIndex = recordset.Fields("tipo").Value
        cbSOperativo.SelectedIndex = recordset.Fields("so").Value
        dtFecha.Text = recordset.Fields("fecha_instalacion").Value

        recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & localizacion)
        LinkLabel1.Text = recordset.Fields("empresa").Value
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim query As String

        query = "UPDATE `equipo` SET `nombre` = '" & escape(txtNombre.Text) & "', `notas` = '" & escape(txtNotas.Text) &
                "', `tipo` = '" & escape(slTipo.SelectedIndex) & "', `fecha_instalacion` = '" & escape(dtFecha.Text) &
                "', `localizacion` = '" & escape(localizacion) & "', `so` = '" & escape(cbSOperativo.SelectedIndex) & "' WHERE id = " & id & ";"

        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec(query)

        If frmEditarLocalizacion.Visible = True Then
            frmEditarLocalizacion.carga()
        End If
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmEditarLocalizacion.id = Me.localizacion
        frmEditarLocalizacion.MdiParent = frmPrincipal
        frmEditarLocalizacion.Show()
    End Sub
End Class