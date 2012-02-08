Imports System.Data.SqlClient

Public Class frmListaLocalizacion

    Public Sub carga()
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion")

        Dim tabla As DataTable = New DataTable("Prueba")
        Dim adaptador As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
        'Dim setter As DataSet = New DataSet()
        ListView1.Clear()
        Dim id As Integer
        Do Until recordset.EOF
            'recordset.Fields("empresa").Value
            id = recordset.Fields("id").Value
            Dim item As ListViewItem = New ListViewItem()
            item.Tag = id
            item.Text = recordset.Fields("empresa").Value

            If id Mod 2 = 0 Then
                item.ImageIndex = 0
            Else
                item.ImageIndex = 1
            End If

            ListView1.Items.Add(item)

            'Dim item As ListViewItem = ListBox1.Items.Item(id)
            'item.Tag = recordset.Fields("id")
            recordset.MoveNext()
        Loop
    End Sub

    Private Sub frmListaLocalizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carga()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        frmAddLocalizacion.MdiParent = frmPrincipal
        frmAddLocalizacion.Show()
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        Dim query As String
        query = "DELETE FROM `localizacion` WHERE id = " & ListView1.SelectedItems(0).Tag & ";"
        Dim confirmacion As Integer = MsgBox("¿Realmente quiere eliminar el elemento seleccionado?", MsgBoxStyle.OkCancel)
        If confirmacion = vbOK Then
            frmPrincipal.conexion.exec(query)
            carga()
        End If
    End Sub

    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click

    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click

    End Sub
End Class