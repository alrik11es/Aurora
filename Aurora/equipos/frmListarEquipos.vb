Public Class frmListarEquipos


    Public Sub carga()
        cargaListadoConTipo("SELECT * FROM equipo", "nombre", listadoEquipos)
    End Sub

    Private Sub frmListarEquipos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carga()
    End Sub
End Class