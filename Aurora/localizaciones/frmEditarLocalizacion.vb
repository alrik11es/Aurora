Imports Aurora.MySQL

Public Class frmEditarLocalizacion
    Public id As Integer

    Public Sub carga()
        cargaListadoEquipos("SELECT * FROM equipo WHERE localizacion = " & id, "nombre", listadoEquipos)
    End Sub

    Private Sub frmEditarLocalizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & id & ";")
        txtEmpresa.Text = recordset.Fields("empresa").Value
        txtCorreo.Text = recordset.Fields("correo").Value
        txtDireccion.Text = recordset.Fields("direccion").Value
        txtNombre.Text = recordset.Fields("empresa").Value
        txtNotas.Text = recordset.Fields("notas").Value
        txtTelefono.Text = recordset.Fields("telefono").Value
        carga()
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

    Private Sub btnAddEquipo_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEquipo.Click
        frmAddEquipo.localizacion = Me.id
        frmAddEquipo.MdiParent = frmPrincipal
        frmAddEquipo.Show()
    End Sub

    Private Sub ctMenu_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ctMenu.Opening
        If listadoEquipos.SelectedItems.Count > 0 Then
            For i = 0 To ctMenu.Items.Count - 1
                ctMenu.Items(i).Enabled = True
            Next
        Else
            For i = 0 To ctMenu.Items.Count - 1
                ctMenu.Items(i).Enabled = False
            Next
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        frmEditarEquipo.localizacion = Me.id
        frmEditarEquipo.id = listadoEquipos.SelectedItems(0).Tag
        frmEditarEquipo.MdiParent = frmPrincipal
        frmEditarEquipo.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerToolStripMenuItem.Click
        frmVerEquipo.localizacion = Me.id
        frmVerEquipo.id = listadoEquipos.SelectedItems(0).Tag
        frmVerEquipo.MdiParent = frmPrincipal
        frmVerEquipo.Show()
    End Sub

    Private Sub listadoEquipos_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles listadoEquipos.MouseDoubleClick
        If listadoEquipos.SelectedItems.Count > 0 Then
            frmVerEquipo.localizacion = Me.id
            frmVerEquipo.id = listadoEquipos.SelectedItems(0).Tag
            frmVerEquipo.MdiParent = frmPrincipal
            frmVerEquipo.Show()
        End If
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        Dim query As String
        If listadoEquipos.SelectedItems.Count > 0 Then
            Dim confirmacion As Integer = MsgBox("¿Realmente quiere eliminar los objetos seleccionados?", MsgBoxStyle.OkCancel)
            If confirmacion = vbOK Then
                For Each item As ListViewItem In listadoEquipos.SelectedItems
                    query = "DELETE FROM `equipo` WHERE id = " & item.Tag & ";"

                    frmPrincipal.conexion.exec(query)
                Next
                carga()
            End If

        End If
    End Sub
End Class