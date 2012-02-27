
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmUsuarios
    Dim command As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dataset As DataSet
    Dim recordset As MySqlDataReader
    Dim insert_num As Integer

    Private Sub loadDataGrid(ByVal query As String, ByVal table As String, ByVal datagrid As DataGridView)
        Command = New MySqlCommand(query, frmPrincipal.conexion.conn)
        adapter = New MySqlDataAdapter(Command)
        DataSet = New DataSet
        adapter.Fill(DataSet, table)
    End Sub

    Sub loadUsr()
        loadDataGrid("SELECT * FROM tecnico", "tabla", usuarios)
        usuarios.DataSource = dataset.Tables(0)
        usuarios.Columns(0).Visible = False
        usuarios.Columns(1).Width = 145
    End Sub

    Private Sub frmUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadUsr()
    End Sub

    ' CLAVES Y VALORES
    Private Sub usuarios_UserAddedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles usuarios.UserAddedRow
        recordset = frmPrincipal.conexion.exec("INSERT INTO tecnico SET usuario=''")
        recordset.Close()
        recordset = frmPrincipal.conexion.exec("SELECT LAST_INSERT_ID() as ult FROM tecnico")
        insert_num = recordset.GetValue(0)
        recordset.Close()
    End Sub

    Private Sub usuarios_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles usuarios.CellValueChanged
        Dim ip_row As Integer
        If IsDBNull(usuarios.Rows(e.RowIndex).Cells("id").Value) Then
            ip_row = insert_num
        Else
            ip_row = usuarios.Rows(e.RowIndex).Cells("id").Value
        End If

        Dim usuario As String = usuarios.Rows(e.RowIndex).Cells(1).Value.ToString
        Dim password As String = usuarios.Rows(e.RowIndex).Cells(2).Value.ToString
        Dim telefono As String = usuarios.Rows(e.RowIndex).Cells(3).Value.ToString
        Dim correo As String = usuarios.Rows(e.RowIndex).Cells(4).Value.ToString
        recordset = frmPrincipal.conexion.exec("UPDATE tecnico SET usuario='" & usuario & "', password='" & password & "', telefono = '" & telefono & "', correo = '" & correo & "' WHERE id = " & ip_row)
        recordset.Close()
        loadUsr()
    End Sub

    Private Sub usuarios_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles usuarios.UserDeletingRow
        Dim row_id As Integer = e.Row.Cells("id").Value
        recordset = frmPrincipal.conexion.exec("DELETE FROM tecnico WHERE id = '" & row_id & "'")
        recordset.Close()
    End Sub
End Class