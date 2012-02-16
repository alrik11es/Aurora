Public Class MySQLConexion
    Public host As String
    Public database As String
    Public user As String
    Public password As String
    Public port As String
    Public conn As ADODB.Connection

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
            Dim recordset As New ADODB.Recordset
            recordset = Me.exec("SHOW DATABASES;")
            Me.close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Sub connect()
        Me.conn = New ADODB.Connection
        'Me.conn.ConnectionString = Me.ConnectString()
        Me.conn.Open(Me.ConnectString())
    End Sub

    Function exec(query As String)
        Return Me.conn.Execute(query)
    End Function

    Sub close()
        If Me.conn.State <> 0 Then
            Me.conn.Close()
        End If
    End Sub

    Private Function ConnectString() As String

        ConnectString = "Driver={MySQL ODBC 5.1 Driver};" & _
                        "Server=" & Me.host & _
                        ";Port=" & Me.port & _
                        ";Database=" & Me.database & ";" & _
                        "User=" & Me.user & _
                        ";Password=" & Me.password & ";Option=3"
    End Function

End Class
