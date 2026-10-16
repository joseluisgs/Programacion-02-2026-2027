// ============================================================================
// Ejercicio 24 — Recursividad: Fibonacci (batería de programación modular)
//
// ENUNCIADO: Calcular la sucesión de Fibonacci de forma recursiva:
// F(0)=0, F(1)=1 y F(n)=F(n-1)+F(n-2). Mostrar los primeros 11 términos.
//
// Conceptos UD02: recursividad — sección 3.8.
//   - Caso base doble: 0 y 1 son la propia sucesión
//   - OJO: esta es la versión CLÁSICA pero INEFICIENTE: cada llamada hace
//     dos llamadas hijas -> crece exponencialmente O(2^n). Con programación
//     dinámica (UD07+) se guarda lo ya calculado y es lineal.
//
// Ejecutar: dotnet run modular24.cs
// ============================================================================

int Fibonacci(int n)
{
    if (n <= 1) return n;                            // Casos base: F(0)=0, F(1)=1
    return Fibonacci(n - 1) + Fibonacci(n - 2);      // Suma de los dos anteriores
}

for (int i = 0; i <= 10; i++)
    Console.WriteLine($"F({i}) = {Fibonacci(i)}");   // 0 1 1 2 3 5 8 13 21 34 55
