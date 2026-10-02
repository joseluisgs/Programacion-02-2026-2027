// Ejercicio 6: Precio con IVA (Operaciones básicas)
const double IVA = 0.21;

Console.Write("Introduce el precio base: ");
decimal.TryParse(Console.ReadLine(), out decimal precio);

decimal iva = precio * (decimal)IVA;
decimal total = precio + iva;

Console.WriteLine($"{precio:F2}€ + {iva:F2}€ IVA = {total:F2}€");
