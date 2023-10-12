Imports System.Console

Public Class Fahrzeug
    Private m_Farbe As String
    Private m_Sitzplaetze As Integer
    Private m_Geschwindigkeit As Integer
    Property Geschwindigkeit() As Integer
        Get
            Return m_Geschwindigkeit
        End Get
        Set(value As Integer)
            m_Geschwindigkeit = value

        End Set

    End Property
    ReadOnly Property Farbe() As String
        Get
            Return m_Farbe
        End Get


    End Property
    ReadOnly Property Sitzplaetze() As Integer
        Get
            Return m_Sitzplaetze
        End Get


    End Property
    Public Sub New(farbe As String, sitze As Integer)

        m_Farbe = farbe
        m_Sitzplaetze = sitze
    End Sub
    Public Sub Starten()
        WriteLine("Brumm")

    End Sub
    Public Sub Beschleunigen(i As Integer)
        If i > 0 Then
            m_Geschwindigkeit = m_Geschwindigkeit + i
        End If
        WriteLine("Die aktuelle Geschwindigkeit wurde um {0} km/h erhöht.", i)
    End Sub
    Public Sub Bremsen(i As Integer)
        If i > 0 And i <= m_Geschwindigkeit Then

            m_Geschwindigkeit = m_Geschwindigkeit - i
        ElseIf i > 0 And i > m_Geschwindigkeit Then
            m_Geschwindigkeit = 0
        End If
        WriteLine("Die aktuelle Geschwindigkeit wurde um {0} km/h reduziert.", i)
    End Sub
    Public Sub Lenken(r As Boolean)
        If r = True Then
            WriteLine("Wir fahren nach rechts")

        Else
            WriteLine("Wir fahren nach links")
        End If
    End Sub

End Class
