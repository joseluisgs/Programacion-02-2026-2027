// ============================================================================
// SOLUCIÓN ejercicio 7 — División entera y resto (Aritmética)
// Batería: programación estructurada, bloque I
//
// ENUNCIADO: Pedir dos números enteros y mostrar la división entera (/)
// y el módulo (%). Ejemplo: 17 / 5 = 3 y 17 % 5 = 2.
//
// Conceptos: división de enteros (descarta los decimales) y módulo
// (devuelve el resto de la división). La combinación / y % es la base
// de muchos algoritmos (descomposición en dígitos, cambio de monedas...).
//
// Ejecutar: dotnet run estructurada07.cs
// ============================================================================

Console.Write("Dividendo: ");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Divisor: ");
int.TryParse(Console.ReadLine(), out int b);

Console.WriteLine($"{a} / {b} = {a / b}"); // 3 / 2 = 1
Console.WriteLine($"{a} % {b} = {a % b}"); // 3 % 2 = 1
