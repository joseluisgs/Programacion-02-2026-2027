// ============================================================================
// Ejercicio 31 — Cambio en monedas con out y aserciones — UD02/ejemplos
//
// ENUNCIADO: Dado un total a pagar y la cantidad pagada, devolver por
// parámetros out cuántas monedas de 2€, 1€, 50c y 20c componen el cambio,
// verificando con una aserción que el pagado cubre el total.
//
// Conceptos UD02:
//   - Múltiples out: un método puede devolver varios resultados — 3.3 C
//   - Debug.Assert: verifica el SUPUESTO del programador (pagado >= total),
//     no datos del usuario — sección 2.8
//   - División entera y módulo para descomponer el cambio (como el ejercicio
//     de propinas de la batería, pero devolviendo el resultado por out)
//
// Ejecutar: dotnet run modular31.cs
// ============================================================================

using System.Diagnostics;

/// <summary>
/// Calcula el cambio en monedas de 2€, 1€, 50ct y 20ct.
/// </summary>
/// <param name="total">Importe total a pagar.</param>
/// <param name="pagado">Cantidad pagada (debe ser >= total).</param>
/// <param name="m2">Número de monedas de 2€.</param>
/// <param name="m1">Número de monedas de 1€.</param>
/// <param name="m50">Número de monedas de 50céntimos.</param>
/// <param name="m20">Número de monedas de 20céntimos.</param>
/// <param name="m10">Número de monedas de 10céntimos.</param>
/// <param name="m05">Número de monedas de 5céntimos.</param>
/// <param name="m02">Número de monedas de 2céntimos.</param>
/// <param name="m01">Número de monedas de 1céntimo.</param>
void CalcularCambio(double total, double pagado, out int m2, out int m1, out int m50, out int m20, out int m10, out int m05, out int m02, out int m01)
{
    // Aserción: el pagado debe ser mayor o igual al total
    Debug.Assert(pagado >= total, $"Error lógico: pagado ({pagado}€) < total ({total}€)");

    int cambio = (int)((pagado - total) * 100); // En céntimos
    m2 = cambio / 200; cambio %= 200;           // Monedas de 2€ y resto
    m1 = cambio / 100; cambio %= 100;           // Monedas de 1€ y resto
    m50 = cambio / 50; cambio %= 50;            // Monedas de 50c y resto
    m20 = cambio / 20; cambio %= 20;            // Monedas de 20c y resto
    m10 = cambio / 10; cambio %= 10;            // Monedas de 10c y resto
    m05 = cambio / 5; cambio %= 5;              // Monedas de 5c y resto
    m02 = cambio / 2; cambio %= 2;              // Monedas de 2c y resto
    m01 = cambio;                               // Monedas de 1c (resto final)
    //                          // El resto en 20c (queda simple)
}

// Se paga 10.00€ por un total de 4.70€ -> cambio de 5.30€
var importeTotal = 4.79;
var pagado = 10.0;
Console.WriteLine($"Importe total: {importeTotal}€, pagado: 10.00€, cambio: {pagado - importeTotal}€");
CalcularCambio(importeTotal, pagado, out int m2, out int m1, out int m50, out int m20, out int m10, out int m05, out int m02, out int m01);
Console.WriteLine($"Cambio: {m2}x2€, {m1}x1€, {m50}x50c, {m20}x20c, {m10}x10c, {m05}x5c, {m02}x2c, {m01}x1c"); // 1x10c, 1x5c, 1x2c, 0x1c