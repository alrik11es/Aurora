Imports System.Data.SqlClient

Public Class frmListaLocalizacion
    Private Sub frmListaLocalizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion")

        Dim tabla As DataTable = New DataTable("Prueba")
        Dim adaptador As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
        'Dim setter As DataSet = New DataSet()

        Dim id As Integer
        Do Until recordset.EOF
            id = ListBox1.Items.Add(recordset.Fields("empresa").Value & "-" & recordset.Fields("direccion").Value)
            'Dim item As ListViewItem = ListBox1.Items.Item(id)
            'item.Tag = recordset.Fields("id")
            recordset.MoveNext()
        Loop
    End Sub
End Class