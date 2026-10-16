// ============================================================================
// Ejercicio 29 — Ordenar con ref (batería de programación modular)
//
// ENUNCIADO: Ordenar de menor a mayor tres números usando un procedimiento,
// de forma que el orden se aplique a las variables originales.
//
// Conceptos UD02: paso por referencia con ref + intercambio con TUPLAS:
// (a, b) = (b, a) es la forma moderna y limpia de hacer el swap sin variable
// temporal (sección 3.3, apartado de tuplas).
// El algoritmo es una burbuja mínima: 3 comparaciones fijas.
//
// Ejecutar: dotnet run modular29.cs
// ============================================================================

void Ordenar(ref int a, ref int b, ref int c)
{
    if (a > b) (a, b) = (b, a); // Intercambio con desestructuración de tupla
    if (a > c) (a, c) = (c, a); // El menor acaba en la primera posición
    if (b > c) (b, c) = (c, b); // Y el mayor en la última
}

int x = 5, y = 2, z = 8;
Console.WriteLine($"Antes: {x}, {y}, {z}");
Ordenar(ref x, ref y, ref z);
Console.WriteLine($"Después: {x}, {y}, {z}"); // Después: 2, 5, 8
