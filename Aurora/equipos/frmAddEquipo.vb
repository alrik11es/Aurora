Public Class frmAddEquipo
    Public localizacion As Integer

    Private Sub frmAddEquipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & localizacion)
        LinkLabel1.Text = recordset.Fields("empresa").Value
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim query As String

        query = "INSERT INTO `equipo` (`id`, `nombre`, `notas`, `tipo`, `fecha_instalacion`, `localizacion`, `so`) " &
                "VALUES (NULL, '" & escape(txtNombre.Text) & "', '" & escape(txtNotas.Text) &
                "', '" & escape(slTipo.SelectedIndex) & "', '" & escape(dtFecha.Text) & "', '" & escape(localizacion) & "', '" & escape(cbSOperativo.SelectedIndex) & "');"

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