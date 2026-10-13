// ============================================================================
// SOLUCIÓN ejercicio 45 — Break y continue juntos
// Batería: programación estructurada, bloque V
//
// ENUNCIADO: Del 1 al 50: si el número es múltiplo de 7, PARAR con break;
// si es impar, SALTARLO con continue. Mostrar los pares que no son
// múltiplos de 7.
//
// Conceptos: las dos sentencias de salto en el mismo bucle — break corta
// el bucle por completo (el 7, 14, 21... es múltiplo de 7 pero IMPAR, así
// que lo primero que dispara el break es el 14: el 7 ya lo descartó el
// continue... no: el 7 es múltiplo de 7, el break manda primero).
// Observa el ORDEN de los if: el de break va ANTES para que el múltiplo
// de 7 pare el bucle aunque también sea impar.
//
// Ejecutar: dotnet run estructurada45.cs
// ============================================================================

for (int i = 1; i <= 50; i++)
{
    if (i % 7 == 0) // Primero el break: manda sobre el continue
    {
        Console.WriteLine($"Break en {i}"); // El primero es 7
        break;
    }
    if (i % 2 != 0) continue; // Impares: saltar
    Console.WriteLine(i);     // Salen 2, 4, 6 (el 7 corta el bucle)
}
