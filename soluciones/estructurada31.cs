// ============================================================================
// SOLUCIÓN ejercicio 31 — Tabla de multiplicar (For)
// Batería: programación estructurada, bloque IV
//
// ENUNCIADO: Pedir un número y con un for del 1 al 10 mostrar su tabla
// de multiplicar.
//
// Conceptos: bucle for — sabemos EXACTAMENTE cuántas veces repetir
// (10 iteraciones): inicialización, condición e incremento en una línea.
//
// Ejecutar: dotnet run estructurada31.cs
// ============================================================================

Console.Write("Número: ");
int.TryParse(Console.ReadLine(), out int num);

for (int i = 1; i <= 10; i++)
    Console.WriteLine($"{num} x {i} = {num * i}"); // Ej: 5 x 3 = 15
