Imports System.Console
Public Class Fahrzeug
    Private m_Farbe As String
    Private m_Sitzplaetze As Integer
    Private m_geschwindigkeit As Integer

    Public Property Farbe As String
        Get
            Return m_Farbe
        End Get
        Set(value As String)
            m_Farbe = value
        End Set
    End Property

    Public Property Sitzplaetze() As Integer
        Get
            Return m_Sitzplaetze
        End Get
        Set(value As Integer)
            m_Sitzplaetze = value
        End Set
    End Property

    Public Property Geschwindigkeit() As Integer
        Get
            Return m_geschwindigkeit
        End Get
        Set(value As Integer)
            m_geschwindigkeit = value
        End Set
    End Property
    Public Sub Beschleunigen(i As Integer)
        If i > 0 Then
            m_geschwindigkeit = m_geschwindigkeit + i
        End If
        WriteLine("Die aktuelle Geschwindigkeit ist {0} km/h", m_geschwindigkeit)
    End Sub
    Public Sub Bremsen(i As Integer)
        If i > 0 And i <= m_geschwindigkeit Then

            m_geschwindigkeit = m_geschwindigkeit - i
        ElseIf i > 0 And i > m_geschwindigkeit Then
            m_geschwindigkeit = 0
        End If
        WriteLine("Die aktuelle Geschwindigkeit ist {0} km/h", m_geschwindigkeit)
    End Sub
    Public Sub Lenken(r As Boolean)
        If r = True Then
            WriteLine("Wir fahren nach rechts")

        Else
            WriteLine("Wir fahren nach links")
        End If
    End Sub


End Class
