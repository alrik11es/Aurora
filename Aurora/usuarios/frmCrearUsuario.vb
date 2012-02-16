Imports System.Data.OleDb
Public Class frmCrearUsuario
    
    
    'Guardar
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        ' Dim comando As New OleDbCommand("Insert into clientes (Usuario,Password, Telefono, Email, ) values('" & MiControlUsuario1.txtUsuario.Text & "','" & MiControlUsuario1.txtPassword.Text & "' , '" & MiControlUsuario1.txtTelefono.Text & "'  , '" & MiControlUsuario1.txtEmail.Text & "')", conexion)
        Dim recorset As ADODB.Recordset = frmPrincipal.conexion.exec("")
        'ejecuta una consulta    llamando a la clase mysqlConexion   en api

    End Sub


    'limpiar el control

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.Close()
    End Sub

   
End Class