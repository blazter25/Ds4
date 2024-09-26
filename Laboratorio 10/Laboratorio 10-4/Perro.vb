' Definición de la clase Perro
Public Class Perro
    ' Propiedades públicas de la clase
    Public nombre As String
    Public raza As String
    Public altura As String

    ' Método para obtener una cadena describiendo al perro y lo que come
    Public Function comer(carne As String) As String
        Return nombre & " mide " & altura & " y comerá " & carne
    End Function

    ' Métodos para las acciones del perro (sin implementación)
    Public Sub dormir()
    End Sub
    Public Sub ladrar()
    End Sub

    ' Método para calcular el costo total con impuesto
    Public Function calcularCosto(costo As Double, impuesto As Double) As Double
        Dim precioTotal As Double
        precioTotal = costo + (costo * impuesto)
        Return precioTotal
    End Function

    ' Constructores de la clase
    Public Sub New()
    End Sub
    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class