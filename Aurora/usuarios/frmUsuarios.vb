Imports System.Data.OleDb
Public Class frmUsuarios

    Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDEB.4.0; Data Source=tabla.mdb") 'como conecto con .sql????

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim comando As New OleDbCommand("INSERT INTO tecnico (id,usuario,password,telefono,correo) values( )", conexion)

        If conexion.State = 1 Then
            conexion.Close()
        End If
        conexion.Open()

        Dim NFilasInsertadas As Integer = comando.ExecuteNonQuery()
        MsgBox("Usuario modificado")
        conexion.Close()
        Me.MiConUsuUsuarios.Clear()
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Dim comando As New OleDbCommand()
        If conexion.State = 1 Then
            conexion.Close()
        End If
        conexion.Open()
        Dim NFilasInsertadas As Integer = comando.ExecuteNonQuery()
        MsgBox("Usuario registrado")
        conexion.Close()
        Me.MiConUsuUsuarios.Clear()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim comando As New OleDbCommand()
        If conexion.State = 1 Then
            conexion.Close()
        End If
        If MsgBox("Esta a punto de borrar un usuario.¿Esta seguro?", MsgBoxStyle.OkCancel) = 1 Then
            conexion.Open()
            Dim NFilasBorradas As Integer = comando.ExecuteNonQuery()
            If NFilasBorradas > 0 Then
                MsgBox("Registro borrado correctamente.")
            End If
            conexion.Close()
            Me.MiConUsuUsuarios.Clear()
        End If

    End Sub

   
End Class