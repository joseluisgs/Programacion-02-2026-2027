// ============================================================================
// SOLUCIÓN ejercicio 16 — Ternario anidado: nota (Bloque II)
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Pedir una nota (0-10) y con ternario ANIDADO mostrar:
// "Malo" (<4), "Regular" (4-6), "Bueno" (7-8), "Excelente" (9-10).
//
// Conceptos: ternarios encadenados — el ": " de cada ternario contiene el
// siguiente ternario. Es conciso, pero con más de 3 niveles se vuelve ilegible:
// ahí conviene if-else if.
//
// Ejecutar: dotnet run estructurada16.cs
// ============================================================================

Console.Write("Nota (0-10): ");
double.TryParse(Console.ReadLine(), out double nota);

// Se evalúa de izquierda a derecha: al primer ternario que cumple, se queda
string resultado = nota < 4 ? "Malo"
    : nota < 7 ? "Regular"
    : nota < 9 ? "Bueno"
    : "Excelente"; // Si ninguno anterior cumple, este es el "else" final

Console.WriteLine($"{nota} → {resultado}"); // Ej: 8.5 → Bueno
