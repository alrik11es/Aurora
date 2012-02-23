Imports Aurora.MySQLfunciones
Imports MySql.Data.MySqlClient

Public Class frmListarEquipos

    Private Sub frmListarEquipos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carga()
    End Sub

    Public Sub carga()
        cargaListadoEquipos("SELECT * FROM equipo INNER JOIN localizacion ON equipo.localizacion = localizacion.id", "nombre", listadoEquipos)
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
        frmEditarEquipo.id = listadoEquipos.SelectedItems(0).Tag
        frmEditarEquipo.MdiParent = frmPrincipal
        frmEditarEquipo.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerToolStripMenuItem.Click
        frmVerEquipo.id = listadoEquipos.SelectedItems(0).Tag
        frmVerEquipo.MdiParent = frmPrincipal
        frmVerEquipo.Show()
    End Sub

    Private Sub listadoEquipos_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles listadoEquipos.MouseDoubleClick
        If listadoEquipos.SelectedItems.Count > 0 Then
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

                    Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec(query)
                    recordset.Close()
                Next
                carga()
            End If

        End If
    End Sub

End Class