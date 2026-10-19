// ============================================================================
// Ejercicio 37 — Lectura segura de números (TryParse) — UD02/ejemplos
//
// ENUNCIADO: Pedir un número entero repitiendo la petición hasta que el
// usuario escriba algo que realmente sea un número.
//
// Conceptos UD02: prevención con TryParse — la regla de oro del punto 4:
// si el error es previsible (basura en el teclado), se previene con un if
// (aquí, la condición del while) en vez de dejar que estalle y recogerlo.
// Truco elegante: la propia condición del bucle HACE el TryParse con out.
//
// Ejecutar: dotnet run modular37.cs
// ============================================================================

int numero;
do
{
    Console.Write("Introduce un número entero: ");
} while (!int.TryParse(Console.ReadLine(), out numero)); // Mientras no convierta, insiste

Console.WriteLine($"Número válido: {numero}");
