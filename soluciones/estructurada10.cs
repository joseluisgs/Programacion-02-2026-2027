// ============================================================================
// SOLUCIÓN ejercicio 10 — Par o impar (Condicionales simples)
// Batería: programación estructurada, bloque I
//
// ENUNCIADO: Pedir un número y decir si es par o impar usando %.
//
// Conceptos: condicional simple if-else. La clave matemática: un número es
// PAR cuando su resto al dividirlo entre 2 es exactamente 0.
//
// Ejecutar: dotnet run estructurada10.cs
// ============================================================================

Console.Write("Introduce un número: ");
int.TryParse(Console.ReadLine(), out int num);

if (num % 2 == 0) // ¿Resto 0 al dividir entre 2?
    Console.WriteLine($"{num} es par");
else
    Console.WriteLine($"{num} es impar");
