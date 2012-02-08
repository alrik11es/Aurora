Imports System.Data.SqlClient

Public Class frmListaLocalizacion

    Public Sub carga()
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion")

        Dim tabla As DataTable = New DataTable("Prueba")
        Dim adaptador As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
        'Dim setter As DataSet = New DataSet()

        Dim id As Integer
        Do Until recordset.EOF
            'recordset.Fields("empresa").Value
            'recordset.Fields("empresa").Value & " - " & recordset.Fields("direccion").Value
            id = ListBox1.Items.Add()

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
        query = "DELETE FROM `localizacion` WHERE id = ;"

    End Sub
End Class