// ============================================================================
// Ejercicio 35 — Contar pares e impares con out (batería de programación modular)
//
// ENUNCIADO: Dado un rango de números, contar cuántos pares e impares hay,
// devolviendo AMBOS conteos desde el mismo procedimiento.
//
// Conceptos UD02: dos parámetros out en un mismo método — 3.3 C.
// Trucos: recorrer el rango con un for y usar el módulo `% 2` para decidir
// si un número es par; los out obligan a asignar ambos conteos antes de
// salir del método.
//
// Ejecutar: dotnet run modular35.cs
// ============================================================================

void ContarRango(int inicio, int fin, out int pares, out int impares)
{
    pares = 0; // out: obligatorio asignar antes de salir
    impares = 0;

    for (int i = inicio; i <= fin; i++)
    {
        if (i % 2 == 0)
            pares++;
        else
            impares++;
    }
}

ContarRango(1, 10, out int p, out int imp);
Console.WriteLine($"Rango 1-10 → Pares: {p}, Impares: {imp}"); // Pares: 5, Impares: 5

ContarRango(20, 25, out p, out imp);
Console.WriteLine($"Rango 20-25 → Pares: {p}, Impares: {imp}"); // Pares: 3, Impares: 3
