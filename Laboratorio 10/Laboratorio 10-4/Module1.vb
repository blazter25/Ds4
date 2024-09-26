

' Programa principal
Module Program
    Sub Main()
        ' Crear objetos de la clase Perro
        Dim perrito As New Perro()
        perrito.nombre = "Chizu"
        perrito.raza = "Pastor Alemán"
        perrito.altura = "0.70cm"

        Console.WriteLine(perrito.comer("Carne"))

        Dim perrito2 As New Perro()
        perrito2.nombre = "Lassie"
        perrito2.altura = "0.60cm"

        Console.WriteLine(perrito2.comer("Pollo"))

        Dim perrito3 As New Perro("Peluchin", "Poodle", "0.50")
        Console.WriteLine(perrito3.comer("Pan"))
    End Sub
End Module