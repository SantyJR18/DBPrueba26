Public Class Tbl_Ciudad

    Dim _idCiudad As Integer
    Dim _nombreCiudad As Integer
    Dim _estado As Boolean

    Public Sub New(idCiudad As Integer, nombreCiudad As Integer, estado As Boolean)
        _idCiudad = idCiudad
        _nombreCiudad = nombreCiudad
        _estado = estado
    End Sub

    Public Property IdCiudad As Integer
        Get
            Return _idCiudad
        End Get
        Set(value As Integer)
            _idCiudad = value
        End Set
    End Property

    Public Property NombreCiudad As Integer
        Get
            Return _nombreCiudad
        End Get
        Set(value As Integer)
            _nombreCiudad = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
End Class