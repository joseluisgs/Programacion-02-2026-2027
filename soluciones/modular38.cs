// ============================================================================
// Ejercicio 38 — División segura con try-catch — UD02/ejemplos
//
// ENUNCIADO: Pedir dos enteros y dividirlos, capturando la
// DivideByZeroException si el divisor resulta ser 0.
//
// Conceptos UD02 (punto 4): reacción con try-catch. OJO: en la regla de oro
// del punto 4, la división por cero es PREDECIBLE con if (b == 0); este
// ejercicio muestra deliberadamente el enfoque de excepción para practicar
// el try-catch. En un programa real, preferiríamos el if.
//
// Ejecutar: dotnet run modular38.cs
// ============================================================================

Console.Write("Dividendo: ");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Divisor: ");
int.TryParse(Console.ReadLine(), out int b);

try
{
    Console.WriteLine($"{a} / {b} = {a / b}"); // Si b es 0, "rebienta" aquí
}
catch (DivideByZeroException) // Recogemos el error y el programa sigue vivo
{
    Console.WriteLine("Error: No se puede dividir por cero");
}

// siempre que puedas usa un if (b == 0) en vez de try-catch, porque es más eficiente y claro

if (b == 0)
    Console.WriteLine("Error: No se puede dividir por cero");
else
    Console.WriteLine($"{a} / {b} = {a / b}");