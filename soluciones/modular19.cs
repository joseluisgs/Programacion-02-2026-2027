// ============================================================================
// Ejercicio 19 — Recursividad: suma de dígitos (batería de programación modular)
//
// ENUNCIADO: Calcular la suma de los dígitos de un número entero de forma
// recursiva (123 -> 1+2+3 = 6; 9999 -> 36).
//
// Conceptos UD02: recursividad — sección 3.8.
//   - Caso base: si el número tiene un solo dígito (n < 10), ese es el resultado
//   - Paso recursivo: n % 10 saca el ÚLTIMO dígito y n / 10 lo quita
//
// Ejecutar: dotnet run modular19.cs
// ============================================================================

int SumaDigitos(int n)
{
    if (n < 10) return n;                        // Caso base: un solo dígito
    return n % 10 + SumaDigitos(n / 10);         // Último dígito + suma del resto
}

Console.WriteLine($"Suma de dígitos de 123: {SumaDigitos(123)}");     // 6
Console.WriteLine($"Suma de dígitos de 9999: {SumaDigitos(9999)}");   // 36
