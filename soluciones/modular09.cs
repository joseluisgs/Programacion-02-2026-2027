// ============================================================================
// Ejercicio 9 — Tabla de multiplicar modular (batería de programación modular)
//
// ENUNCIADO: Mostrar la tabla de multiplicar (del 1 al 10) de un número,
// reutilizando el mismo procedimiento para cualquier número.
//
// Conceptos UD02: procedimiento VOID (muestra, no devuelve nada) — 3.2 B.
// La reutilización es la gracia de lo modular: una sola tabla de código
// sirve para la tabla del 5, del 7 o de cualquier otro.
//
// Ejecutar: dotnet run modular09.cs
// ============================================================================

// Muestra la tabla de multiplicar del 1 al 10 del número recibido
void MostrarTabla(int numero)
{
    for (int i = 1; i <= 10; i++)
        Console.WriteLine($"{numero} x {i} = {numero * i}");
}

MostrarTabla(5); // Misma función, distintos datos
Console.WriteLine("---");
MostrarTabla(7);
