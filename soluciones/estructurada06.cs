// ============================================================================
// SOLUCIÓN ejercicio 6 — Precio con IVA (Operaciones básicas)
// Batería: programación estructurada, bloque I
//
// ENUNCIADO: Pedir el precio base de un producto, calcular el IVA (21%) y
// el precio final. Mostrar: "{precio}€ + {iva}€ IVA = {total}€".
//
// Conceptos: constantes (const double IVA = 0.21 — el 21% vive en un solo
// sitio), operaciones aritméticas con decimal (dinero SIEMPRE en decimal,
// nunca double) y formato :F2 para dos decimales.
//
// Ejecutar: dotnet run estructurada06.cs
// ============================================================================

const double IVA = 0.21;

Console.Write("Introduce el precio base: ");
decimal.TryParse(Console.ReadLine(), out decimal precio);

decimal iva = precio * (decimal)IVA; // 21% del base
decimal total = precio + iva;

Console.WriteLine($"{precio:F2}€ + {iva:F2}€ IVA = {total:F2}€"); // Ej: 100.00€ + 21.00€ IVA = 121.00€
