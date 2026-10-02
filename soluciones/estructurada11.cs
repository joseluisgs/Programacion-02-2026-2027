// Ejercicio 11: Clasificación por Edad (if-else if-else)
Console.Write("Introduce tu edad: ");
int.TryParse(Console.ReadLine(), out int edad);

if (edad < 12)
    Console.WriteLine("Niño");
else if (edad < 18)
    Console.WriteLine("Adolescente");
else if (edad < 65)
    Console.WriteLine("Adulto");
else
    Console.WriteLine("Mayor");
