// ============================================================================
// Ejercicio 12 — Intercambiar con ref (batería de programación modular)
//
// ENUNCIADO: Intercambiar los valores de dos variables usando un
// procedimiento, de forma que el cambio se vea FUERA del método.
//
// Conceptos UD02: paso por REFERENCIA con ref — sección 3.3 B.
// Sin ref, el método trabajaría con copias y el intercambio se perdería al
// salir; con ref, a y b son los MISMOS huecos de memoria que x e y.
// Recuerda: hay que escribir ref también en la LLAMADA (ref x, ref y).
//
// Ejecutar: dotnet run modular12.cs
// ============================================================================

void Intercambiar(ref int a, ref int b)
{
    int temp = a; // Clásico intercambio con variable auxiliar
    a = b;
    b = temp;


    // Otra forma es con tuplas
    // (a, b) = (b, a);
}

int x = 5, y = 15;
Console.WriteLine($"Antes: x={x}, y={y}");
Intercambiar(ref x, ref y);
Console.WriteLine($"Después: x={x}, y={y}"); // x=15, y=5: el cambio es REAL
