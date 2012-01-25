Imports System.Data.SqlClient

Public Class frmListaLocalizacion
    Private Sub frmListaLocalizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM tecnico")

        Dim tabla As DataTable = New DataTable("Prueba")
        Dim adaptador As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
        Dim setter As DataSet = New DataSet()

        adaptador.Fill(tabla, recordset)

        dgListado.DataSource = tabla
    End Sub
End Class