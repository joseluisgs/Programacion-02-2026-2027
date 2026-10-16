// ============================================================================
// SOLUCIÓN ejercicio 24 — Validar número de ticket (Do-While)
// Batería: programación estructurada, bloque III
//
// ENUNCIADO: Con do-while, pedir un número de ticket repitiendo la petición
// mientras esté fuera del rango 1000-9999. Mostrar "Ticket válido".
//
// Conceptos: do-while como "bucle de reintento" — el dato se pide al
// menos una vez y no se sale hasta que cumple la regla. Es el patrón de
// las lecturas robustas del punto 4 (LeerEntero): TryParse + condición
// en un solo sitio.
//
// Ejecutar: dotnet run estructurada24.cs
// ============================================================================

int ticket;
do
{
    Console.Write("Introduce el número de ticket (1000-9999): ");
} while (!int.TryParse(Console.ReadLine(), out ticket) || ticket < 1000 || ticket > 9999);
// Mientras no sea un número o se salga del rango, sigue pidiendo

Console.WriteLine("Ticket válido");
