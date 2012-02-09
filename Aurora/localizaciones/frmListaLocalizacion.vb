Imports System.Data.SqlClient

Public Class frmListaLocalizacion

    Public Sub carga()
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion")

        Dim tabla As DataTable = New DataTable("Prueba")
        Dim adaptador As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()

        listaLocalizaciones.Clear()
        Dim id As Integer
        Do Until recordset.EOF

            id = recordset.Fields("id").Value
            Dim item As ListViewItem = New ListViewItem()
            item.Tag = id
            item.Text = recordset.Fields("empresa").Value

            If id Mod 2 = 0 Then
                item.ImageIndex = 0
            Else
                item.ImageIndex = 1
            End If

            listaLocalizaciones.Items.Add(item)

            recordset.MoveNext()
        Loop
    End Sub

    Private Sub frmListaLocalizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carga()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        frmAddLocalizacion.MdiParent = frmPrincipal
        frmAddLocalizacion.Show()
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles mnBorrar.Click, ToolStripButton3.Click
        Dim query As String
        If listaLocalizaciones.SelectedItems.Count > 0 Then
            query = "DELETE FROM `localizacion` WHERE id = " & listaLocalizaciones.SelectedItems(0).Tag & ";"
            Dim confirmacion As Integer = MsgBox("¿Realmente quiere eliminar el elemento seleccionado?", MsgBoxStyle.OkCancel)
            If confirmacion = vbOK Then
                frmPrincipal.conexion.exec(query)
                carga()
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles mnEditar.Click, ToolStripButton2.Click
        If listaLocalizaciones.SelectedItems.Count > 0 Then
            frmEditarLocalizacion.id = listaLocalizaciones.SelectedItems(0).Tag
            frmEditarLocalizacion.MdiParent = frmPrincipal
            frmEditarLocalizacion.Show()
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles listaLocalizaciones.MouseDoubleClick
        If listaLocalizaciones.SelectedItems.Count > 0 Then
            frmEditarLocalizacion.id = listaLocalizaciones.SelectedItems(0).Tag
            frmEditarLocalizacion.MdiParent = frmPrincipal
            frmEditarLocalizacion.Show()
        End If
    End Sub

    Private Sub ctMenu_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ctMenu.Opening
        If listaLocalizaciones.SelectedItems.Count > 0 Then
            For i = 0 To ctMenu.Items.Count - 1
                ctMenu.Items(i).Enabled = True
            Next
        Else
            For i = 0 To ctMenu.Items.Count - 1
                ctMenu.Items(i).Enabled = False
            Next
        End If
    End Sub
End Class