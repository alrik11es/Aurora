Imports MySql.Data.MySqlClient

Public Class frmVerEquipo
    Public localizacion As Integer
    Public id As Integer
    Dim command As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dataset As DataSet
    Dim recordset As MySqlDataReader
    Dim insert_num As Integer

    Private Sub loadDataGrid(ByVal query As String, ByVal table As String, ByVal datagrid As DataGridView)
        command = New MySqlCommand(query, frmPrincipal.conexion.conn)
        adapter = New MySqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset, table)
    End Sub

    Sub loadIP()
        loadDataGrid("SELECT * FROM config_ip WHERE equipo = " & Me.id, "ip", dataGridIp)
        dataGridIp.DataSource = dataset.Tables(0)
        dataGridIp.Columns(0).Visible = False
        dataGridIp.Columns(2).Visible = False
        dataGridIp.Columns(1).Width = 145
    End Sub

    Sub loadUsr()
        loadDataGrid("SELECT * FROM config_pass WHERE equipo = " & Me.id, "ip", dataGridUP)
        dataGridUP.DataSource = dataset.Tables(0)
        dataGridUP.Columns(0).Visible = False
        dataGridUP.Columns(3).Visible = False
    End Sub

    Sub loadMisc()
        loadDataGrid("SELECT * FROM config_varios WHERE equipo = " & Me.id, "ip", dataGridMisc)
        dataGridMisc.DataSource = dataset.Tables(0)
        dataGridMisc.Columns(0).Visible = False
        dataGridMisc.Columns(3).Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmEditarLocalizacion.id = Me.localizacion
        frmEditarLocalizacion.MdiParent = frmPrincipal
        frmEditarLocalizacion.Show()
    End Sub

    Private Sub btnConnectIP_Click(sender As System.Object, e As System.EventArgs) Handles btnConnectIP.Click
        If dataGridIp.SelectedRows.Count > 0 Then
            Dim ip As String = dataGridIp.SelectedRows(0).Cells("ip").Value
            Dim proceso As ProcessStartInfo = New ProcessStartInfo()
            proceso.FileName = "cmd.exe"
            proceso.Arguments = "/C mstsc.exe /v " & ip
            proceso.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(proceso)
        End If
    End Sub

    Private Sub btnEditarEquipo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarEquipo.Click
        frmEditarEquipo.id = Me.id
        frmEditarEquipo.MdiParent = frmPrincipal
        frmEditarEquipo.Show()
    End Sub

    Private Sub frmVerEquipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        recordset = frmPrincipal.conexion.exec("SELECT * FROM equipo WHERE id = " & id & ";")
        Me.Text = "Equipo: " & recordset.GetString("nombre")
        lblNombre.Text = "Nombre de equipo: " & recordset.GetString("nombre")
        txtNotas.Text = recordset.GetString("notas")
        lblTipo.Text = "Tipo de equipo: " & frmEditarEquipo.slTipo.Items(recordset.GetString("tipo")).ToString
        lblSO.Text = "Sistema operativo: " & recordset.GetString("so")
        lblFecha.Text = "Fecha de instalación: " & recordset.GetString("fecha_instalacion")
        Me.localizacion = recordset.GetString("localizacion")
        recordset.Close()

        recordset = frmPrincipal.conexion.exec("SELECT * FROM localizacion WHERE id = " & localizacion)
        LinkLabel1.Text = recordset.GetString("empresa")
        recordset.Close()

        loadIP()
        loadUsr()
        loadMisc()
    End Sub

    ' IP's DEL EQUIPO

    Private Sub dataGridIp_UserAddedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dataGridIp.UserAddedRow
        Dim ip As String = e.Row.Cells("ip").Value
        'MsgBox(e.Row.Cells("ip").Value)
        recordset = frmPrincipal.conexion.exec("INSERT INTO config_ip SET ip='" & ip & "', equipo = '" & Me.id & "'")
        recordset.Close()
        recordset = frmPrincipal.conexion.exec("SELECT LAST_INSERT_ID() as ult FROM config_ip")
        insert_num = recordset.GetValue(0)
        recordset.Close()
    End Sub

    Private Sub dataGridIp_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridIp.CellValueChanged
        Dim ip_row As Integer
        If IsDBNull(dataGridIp.Rows(e.RowIndex).Cells("id").Value) Then
            ip_row = insert_num
        Else
            ip_row = dataGridIp.Rows(e.RowIndex).Cells("id").Value
        End If

        Dim ip As String = dataGridIp.Rows(e.RowIndex).Cells("ip").Value
        recordset = frmPrincipal.conexion.exec("UPDATE config_ip SET ip='" & ip & "', equipo = '" & Me.id & "' WHERE id = " & ip_row)
        recordset.Close()
        loadIP()
    End Sub

    Private Sub dataGridIp_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dataGridIp.UserDeletingRow
        Dim row_id As Integer = e.Row.Cells("id").Value.ToString
        recordset = frmPrincipal.conexion.exec("DELETE FROM config_ip WHERE id = '" & row_id & "'")
        recordset.Close()
    End Sub

    ' USUARIO Y PASSWORDS

    Private Sub dataGridUP_UserAddedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dataGridUP.UserAddedRow
        recordset = frmPrincipal.conexion.exec("INSERT INTO config_pass SET nombre='', equipo = '" & Me.id & "'")
        recordset.Close()
        recordset = frmPrincipal.conexion.exec("SELECT LAST_INSERT_ID() as ult FROM config_pass")
        insert_num = recordset.GetValue(0)
        recordset.Close()
    End Sub

    Private Sub dataGridUP_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridUP.CellValueChanged
        Dim ip_row As Integer
        If IsDBNull(dataGridUP.Rows(e.RowIndex).Cells("id").Value) Then
            ip_row = insert_num
        Else
            ip_row = dataGridUP.Rows(e.RowIndex).Cells("id").Value
        End If

        Dim nombre As String = dataGridUP.Rows(e.RowIndex).Cells("nombre").Value.ToString
        Dim password As String = dataGridUP.Rows(e.RowIndex).Cells("password").Value.ToString
        recordset = frmPrincipal.conexion.exec("UPDATE config_pass SET nombre='" & nombre & "', password='" & password & "', equipo = '" & Me.id & "' WHERE id = " & ip_row)
        recordset.Close()
        loadUsr()
    End Sub

    Private Sub dataGridUP_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dataGridUP.UserDeletingRow
        Dim row_id As Integer = e.Row.Cells("id").Value
        recordset = frmPrincipal.conexion.exec("DELETE FROM config_pass WHERE id = '" & row_id & "'")
        recordset.Close()
    End Sub

    ' CLAVES Y VALORES

    Private Sub dataGridMisc_UserAddedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dataGridMisc.UserAddedRow
        recordset = frmPrincipal.conexion.exec("INSERT INTO config_varios SET clave='',valor='', equipo = '" & Me.id & "'")
        recordset.Close()
        recordset = frmPrincipal.conexion.exec("SELECT LAST_INSERT_ID() as ult FROM config_varios")
        insert_num = recordset.GetValue(0)
        recordset.Close()
    End Sub

    Private Sub dataGridMisc_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridMisc.CellValueChanged
        Dim ip_row As Integer
        If IsDBNull(dataGridMisc.Rows(e.RowIndex).Cells("id").Value) Then
            ip_row = insert_num
        Else
            ip_row = dataGridMisc.Rows(e.RowIndex).Cells("id").Value
        End If

        Dim clave As String = dataGridMisc.Rows(e.RowIndex).Cells("clave").Value.ToString
        Dim valor As String = dataGridMisc.Rows(e.RowIndex).Cells("valor").Value.ToString
        recordset = frmPrincipal.conexion.exec("UPDATE config_varios SET clave='" & clave & "', valor='" & valor & "', equipo = '" & Me.id & "' WHERE id = " & ip_row)
        recordset.Close()
        loadMisc()
    End Sub

    Private Sub dataGridMisc_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dataGridMisc.UserDeletingRow
        Dim row_id As Integer = e.Row.Cells("id").Value
        recordset = frmPrincipal.conexion.exec("DELETE FROM config_varios WHERE id = '" & row_id & "'")
        recordset.Close()
    End Sub
End Class