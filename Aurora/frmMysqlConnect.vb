Imports System.IO

Public Class frmMysqlConnect

    Dim conn As MySQLConexion

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        conn = New MySQLConexion(txtHost.Text, txtPort.Text, txtUser.Text, txtPassword.Text, txtDatabase.Text)
        Try
            conn.exist()
            btnGuardar.Enabled = True
        Catch ex As Exception
            MsgBox("No se ha podido realizar la prueba. Por favor compruebe los datos" &
                   " y asegurese de tener permisos en el servidor. Mensaje: " & ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        ' Si se llega a este punto se entienden los datos como válidos. Por tanto guardamos:
        SaveSetting("aurora", "dbinfo", "database", conn.database)
        SaveSetting("aurora", "dbinfo", "port", conn.port)
        SaveSetting("aurora", "dbinfo", "host", conn.host)
        SaveSetting("aurora", "dbinfo", "user", conn.user)
        SaveSetting("aurora", "dbinfo", "password", conn.password)
        frmPrincipal.menuItemConectar.Enabled = True
    End Sub

    Private Sub frmMysqlConnect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtDatabase.Text = GetSetting("aurora", "dbinfo", "database")
        txtPort.Text = GetSetting("aurora", "dbinfo", "port")
        txtHost.Text = GetSetting("aurora", "dbinfo", "host")
        txtUser.Text = GetSetting("aurora", "dbinfo", "user")
        txtPassword.Text = GetSetting("aurora", "dbinfo", "password")

        If txtHost.Text = "" Then
            txtHost.Text = "localhost"
        End If

        If txtPort.Text = "" Then
            txtPort.Text = "3306"
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        DeleteSetting("aurora", "dbinfo", "database")
        DeleteSetting("aurora", "dbinfo", "port")
        DeleteSetting("aurora", "dbinfo", "host")
        DeleteSetting("aurora", "dbinfo", "user")
        DeleteSetting("aurora", "dbinfo", "password")

        frmMysqlConnect_Load(sender, e)
    End Sub

    Private Sub compruebaCambios_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHost.TextChanged, txtDatabase.TextChanged,
        txtPassword.TextChanged, txtPort.TextChanged, txtUser.TextChanged
        btnGuardar.Enabled = False
    End Sub
End Class