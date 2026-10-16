// ============================================================================
// Ejercicio 27 — Factorial recursivo vs iterativo (batería modular)
//
// ENUNCIADO: Calcular el factorial de varios números con las DOS formas y
// comparar los resultados y las características de cada enfoque.
//
// Conceptos UD02: recursividad (3.8) frente a iteración. Regla nemotécnica
// del tema: todo lo que se puede hacer con bucles se puede hacer con
// recursividad, pero no al revés (árboles, carpetas... se piensan recursivos).
//
// Ejecutar: dotnet run modular27.cs
// ============================================================================

// --- FORMA RECURSIVA ---
int FactorialRecursivo(int n)
{
    if (n <= 1) return 1;           // Caso base
    return n * FactorialRecursivo(n - 1);  // Llamada recursiva
}

// --- FORMA ITERATIVA ---
int FactorialIterativo(int n)
{
    int resultado = 1;
    for (int i = 2; i <= n; i++)
        resultado *= i;
    return resultado;
}

// --- PRUEBAS ---
int[] valores = [0, 1, 5, 10, 12];

Console.WriteLine("N\tRecursivo\tIterativo\t¿Iguales?");
Console.WriteLine("─\t────────\t─────────\t─────────");

foreach (int n in valores)
{
    int r1 = FactorialRecursivo(n);
    int r2 = FactorialIterativo(n);
    Console.WriteLine($"{n}\t{r1}\t\t{r2}\t\t{r1 == r2}"); // Ambos dan lo mismo
}

// --- ANÁLISIS ---
Console.WriteLine();
Console.WriteLine("¿Cuál es más legible? → Recursivo (se parece a la definición matemática)");
Console.WriteLine("¿Cuál es más eficiente? → Iterativo (no crea pila de llamadas)");
Console.WriteLine("¿Cuándo usar recursión? → Cuando el problema se divide en subproblemas iguales");
Console.WriteLine("¿Cuándo usar iteración? → Cuando sabes el número de pasos o no necesitas pila");
