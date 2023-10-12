Public Class Motorrad
    Inherits Fahrzeug
    Private m_Gepaecktraeger As Boolean

    Public Sub New(farbe As String, sitze As Integer, gepaecktraeger As Boolean)
        MyBase.New(farbe, sitze)
        m_Gepaecktraeger = gepaecktraeger
    End Sub

    Public Property Gepaecktraeger As Boolean
        Get
            Return m_Gepaecktraeger
        End Get
        Set(value As Boolean)
            m_Gepaecktraeger = value
        End Set
    End Property
End Class
