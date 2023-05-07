Public Class Tbl_Persona

    Dim _idPersona As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _fechaNac As DateTime
    Dim _sexo As Boolean
    Dim _telefono As String
    Dim _correo As String
    Dim _idCiudad As Integer
    Dim _direccion As String
    Dim _activo As Boolean

    Public Sub New(idPersona As Integer, primerNombre As String, segundoNombre As String,
                   primerApellido As String, segundoApellido As String, fechaNac As Date,
                   sexo As Boolean, telefono As String, correo As String,
                   idCiudad As Integer, direccion As String, activo As Boolean)
        _idPersona = idPersona
        _primerNombre = primerNombre
        _segundoNombre = segundoNombre
        _primerApellido = primerApellido
        _segundoApellido = segundoApellido
        _fechaNac = fechaNac
        _sexo = sexo
        _telefono = telefono
        _correo = correo
        _idCiudad = idCiudad
        _direccion = direccion
        _activo = activo
    End Sub

    Public Property IdPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property PrimerNombre As String
        Get
            Return _primerNombre
        End Get
        Set(value As String)
            _primerNombre = value
        End Set
    End Property

    Public Property SegundoNombre As String
        Get
            Return _segundoNombre
        End Get
        Set(value As String)
            _segundoNombre = value
        End Set
    End Property

    Public Property PrimerApellido As String
        Get
            Return _primerApellido
        End Get
        Set(value As String)
            _primerApellido = value
        End Set
    End Property

    Public Property SegundoApellido As String
        Get
            Return _segundoApellido
        End Get
        Set(value As String)
            _segundoApellido = value
        End Set
    End Property

    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property

    Public Property Sexo As Boolean
        Get
            Return _sexo
        End Get
        Set(value As Boolean)
            _sexo = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property IdCiudad As Integer
        Get
            Return _idCiudad
        End Get
        Set(value As Integer)
            _idCiudad = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property
End Class
