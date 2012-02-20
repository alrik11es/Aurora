Public Class MiConUsuUsuarios

    Public Sub micontrol_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Width < 200 Then Me.Width = 200
        If Me.Height < 124 Then Me.Height = 124
        'txtUsuario.Width = Me.Width - 180
        'txtPassword.Width = Me.Width - 180
        'txtTelefono.Width = Me.Width - 180
        'txtEmail.Width = Me.Width - 180
    End Sub

    Public Property usuario() As String
        'Get es lo que ve el programador cuando examina la propiedad nombre
        Get
            usuario = StrConv(txtUsuario.Text, VbStrConv.ProperCase)
        End Get
        'SET determina lo que ocurre cuando se define o modifica la propiedad nombre
        Set(ByVal Value As String)
            txtUsuario.Text = Value
        End Set
    End Property
    Public Property password() As String
        Get
            Password = StrConv(txtPassword.Text, VbStrConv.ProperCase)
        End Get
        Set(ByVal Value As String)
            txtPassword.Text = Value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Telefono = txtTelefono.Text
        End Get
        Set(ByVal Value As String)
            txtTelefono.Text = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Email = StrConv(txtEmail.Text, VbStrConv.ProperCase)
        End Get
        Set(ByVal Value As String)
            txtEmail.Text = Value
        End Set
    End Property

    Public Sub Clear()
        txtUsuario.Text = ""
        txtPassword.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
    End Sub



End Class


























































