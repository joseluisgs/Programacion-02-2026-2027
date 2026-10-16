// ============================================================================
// Ejercicio 1 — Calculadora de propinas (batería de programación modular)
//
// ENUNCIADO: Pedir la cuenta y el porcentaje de propina, y mostrar la
// propina calculada junto al total a pagar.
//
// Conceptos UD02: función CON return (devuelve un double) — sección 3.2 A.
// Fíjate en el orden: la función solo CALCULA; el programa principal se
// encarga de pedir los datos y de mostrarlos (responsabilidades separadas).
//
// Ejecutar: dotnet run modular01.cs
// ============================================================================

// Devuelve la cantidad de propina: cuenta * porcentaje / 100
double CalcularPropina(double cuenta, double porcentaje)
{
    return cuenta * porcentaje / 100;
}

Console.Write("Cuenta: ");
double.TryParse(Console.ReadLine(), out double cuenta);
Console.Write("Propina (%): ");
double.TryParse(Console.ReadLine(), out double porcentaje);

double propina = CalcularPropina(cuenta, porcentaje);
Console.WriteLine($"{cuenta}€ + {propina}€ = {cuenta + propina}€"); // Ej: 20€ + 2€ = 22€
