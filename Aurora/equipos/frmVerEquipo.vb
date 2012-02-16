Imports MySql.Data.MySqlClient

Public Class frmVerEquipo
    Public localizacion As Integer
    Public id As Integer

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'System.Diagnostics.Process.Start("mstsc")
    End Sub

    Private Sub frmVerEquipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec("SELECT * FROM equipo WHERE id = " & id & ";")
        Me.Text = "Equipo: " & recordset.GetString("nombre")
        lblNombre.Text = "Nombre de equipo: " & recordset.GetString("nombre")
        txtNotas.Text = recordset.GetString("notas")
        lblTipo.Text = "Tipo de equipo: " & frmEditarEquipo.slTipo.Items(recordset.GetString("tipo")).ToString
        lblSO.Text = "Sistema operativo: " & recordset.GetString("so")
        lblFecha.Text = "Fecha de instalación: " & recordset.GetString("fecha_instalacion")
        recordset.Close()

        recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & localizacion)
        LinkLabel1.Text = recordset.GetString("empresa")
        recordset.Close()

    End Sub
End Class