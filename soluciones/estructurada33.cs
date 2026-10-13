// ============================================================================
// SOLUCIÓN ejercicio 33 — Factorial (For)
// Batería: programación estructurada, bloque IV
//
// ENUNCIADO: Pedir un número y con un for calcular su factorial
// (n! = n × (n-1) × ... × 2 × 1). Documentar qué es el factorial.
//
// Conceptos: acumulador multiplicativo — se parte de 1 (el neutro de la
// multiplicación; con 0 el resultado sería siempre 0). OJO elegir long:
// el factorial DESBORDA el int muy pronto (13! ya no cabe en un int).
//
// Ejecutar: dotnet run estructurada33.cs
// ============================================================================

// El factorial de n es el producto de todos los enteros de n a 1.
// Por definición: 0! = 1 y 1! = 1.
Console.Write("Número: ");
int.TryParse(Console.ReadLine(), out int num);

long factorial = 1; // long: 13! = 6.227.020.800 ya desbordaría un int
for (int i = 2; i <= num; i++)
    factorial *= i;

Console.WriteLine($"{num}! = {factorial}"); // Ej: 5! = 120
