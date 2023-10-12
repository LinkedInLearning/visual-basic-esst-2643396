Public Class Auto
    Inherits Fahrzeug
    Private m_Form As String
    Sub New(farbe As String, sitze As Integer, form As String)
        MyBase.New(farbe, sitze)
        m_Form = form

    End Sub

    Public Property Form As String
        Get
            Return m_Form
        End Get
        Set(value As String)
            m_Form = value
        End Set
    End Property
End Class
