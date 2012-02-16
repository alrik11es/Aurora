Imports MySql.Data.MySqlClient

Public Class MySQLConexion
    Public host As String
    Public database As String
    Public user As String
    Public password As String
    Public port As String
    Public conn As MySqlConnection
    Public dreader As MySqlDataReader

    Public connection

    Sub New(host As String, port As String, user As String, password As String, database As String)

        ' Primero comprobamos si ya existe la configuración.

        ' En caso de que no exista la guardamos.
        Me.host = host
        If IsNumeric(port) Then
            Me.port = port
        End If
        Me.user = user
        Me.password = password
        Me.database = database
    End Sub

    Sub New()
        Dim database As String = GetSetting("aurora", "dbinfo", "database")
        Dim port As String = GetSetting("aurora", "dbinfo", "port")
        Dim host As String = GetSetting("aurora", "dbinfo", "host")
        Dim user As String = GetSetting("aurora", "dbinfo", "user")
        Dim password As String = GetSetting("aurora", "dbinfo", "password")

        ' Primero comprobamos si ya existe la configuración.

        ' En caso de que no exista la guardamos.
        Me.host = host
        If IsNumeric(port) Then
            Me.port = port
        End If
        Me.user = user
        Me.password = password
        Me.database = database
    End Sub

    Function exist()
        Try
            Me.connect()
            Dim reader As MySqlDataReader = Me.exec("SHOW DATABASES;")
            Me.close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Sub connect()
        Me.conn = New MySqlConnection()
        'Me.conn.ConnectionString = Me.ConnectString()
        Me.conn.ConnectionString = Me.ConnectString()
        Me.conn.Open()
    End Sub

    Function exec(query As String)
        Try
            Dim command As MySqlCommand = New MySqlCommand(query, Me.conn)
            Me.dreader = command.ExecuteReader
            Me.dreader.Read()
            Return Me.dreader
        Catch ex As Exception
            Return False
        End Try
        
    End Function

    Sub close()
        If Me.conn.State <> 0 Then
            Me.conn.Close()
        End If
    End Sub

    Private Function ConnectString() As String

        '   con.ConnectionString = "server=" & Servidor & ";" _
        '& "user id=" & Usuario & ";" _
        '& "password=" & Pass & ";" _
        '& "database=" & BasedeDatos & ""

        ConnectString = "Server=" & Me.host & _
                        ";Port=" & Me.port & _
                        ";database=" & Me.database & ";" & _
                        "user id=" & Me.user & _
                        ";password=" & Me.password
    End Function

End Class
