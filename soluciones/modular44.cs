// ============================================================================
// Ejercicio 44 — Throw con mensajes descriptivos (batería modular)
//
// ENUNCIADO: Simular una transferencia bancaria que valida dos reglas de
// negocio (cantidad positiva y saldo suficiente) lanzando una excepción
// DISTINTA para cada violación, con mensajes claros.
//
// Conceptos UD02 (punto 4):
//   - Elegir la excepción más adecuada: ArgumentOutOfRangeException para
//     rangos, ArgumentException para reglas generales — sección 4.11
//   - Los mensajes deben decirle al usuario QUÉ está mal, no "error genérico"
//   - El primer catch(Exception) recoge CUALQUIER burbujeo del try
//
// Ejecutar: dotnet run modular44.cs
// ============================================================================

void Transferir(double saldo, double cantidad)
{
    if (cantidad <= 0)
        throw new ArgumentOutOfRangeException("La cantidad debe ser positiva");
    if (cantidad > saldo)
        throw new ArgumentException("Saldo insuficiente");
    Console.WriteLine($"Transferencia exitosa: {cantidad}€. Saldo restante: {saldo - cantidad}€");
}

try
{
    Transferir(100, 50); // OK: se transfiere
    Transferir(100, -10); // ¡BOOM! ArgumentOutOfRangeException
}
catch (Exception ex)
{
    // Captura cualquier excepción que haya burbujeado desde Transferir
    Console.WriteLine($"Error: {ex.Message}"); // "La cantidad debe ser positiva"
}


// O lo hago con un if para validar antes de llamar a la función, evitando que se lance la excepción
double saldo = 100;
double cantidad = 150;
if (cantidad <= 0)
{
    Console.WriteLine($"Error: La cantidad debe ser positiva, pero se ha recibido {cantidad}");
}
else if (cantidad > saldo)
{
    Console.WriteLine($"Error: Saldo insuficiente. Saldo actual: {saldo}€, cantidad solicitada: {cantidad}€");
}
else
{
    Transferir(saldo, cantidad); // Llamada segura
}
