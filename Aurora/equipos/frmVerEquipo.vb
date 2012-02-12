Public Class frmVerEquipo
    Public localizacion As Integer
    Public id As Integer

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'System.Diagnostics.Process.Start("mstsc")
    End Sub

    Private Sub frmVerEquipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec("SELECT * FROM equipo WHERE id = " & id & ";")
        Me.Text = "Equipo: " & recordset.Fields("nombre").Value
        lblNombre.Text = "Nombre de equipo: " & recordset.Fields("nombre").Value
        txtNotas.Text = recordset.Fields("notas").Value
        lblTipo.Text = "Tipo de equipo: " & frmEditarEquipo.slTipo.Items(recordset.Fields("tipo").Value).ToString
        lblSO.Text = "Sistema operativo: " & recordset.Fields("so").Value
        lblFecha.Text = "Fecha de instalación: " & recordset.Fields("fecha_instalacion").Value

        recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & localizacion)
        LinkLabel1.Text = recordset.Fields("empresa").Value
    End Sub
End Class