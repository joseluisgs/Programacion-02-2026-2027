// ============================================================================
// Ejercicio 20 — Recursividad: potencia (batería de programación modular)
//
// ENUNCIADO: Calcular b^e de forma recursiva, soportando también
// exponentes negativos (b^-n = 1 / b^n).
//
// Conceptos UD02: recursividad — sección 3.8.
//   - Caso base doble: e == 0 -> 1 (por definición)
//   - Camino negativo: se delega en la versión positiva (e < 0)
//   - Paso recursivo: b * Potencia(b, e - 1)
//
// Ejecutar: dotnet run modular20.cs
// ============================================================================

double Potencia(double b, int e)
{
    if (e == 0) return 1;                          // Caso base: cualquier base^0 = 1
    if (e < 0) return 1.0 / Potencia(b, -e);       // Exponente negativo -> inverso
    return b * Potencia(b, e - 1);                 // Paso recursivo
}

Console.WriteLine($"2^10 = {Potencia(2, 10)}");    // 1024
Console.WriteLine($"3^0 = {Potencia(3, 0)}");      // 1
Console.WriteLine($"5^3 = {Potencia(5, 3)}");      // 125
