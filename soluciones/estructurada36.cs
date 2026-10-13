// ============================================================================
// SOLUCIÓN ejercicio 36 — Tabla completa (for anidado)
// Batería: programación estructurada, bloque IV
//
// ENUNCIADO: Con dos for anidados, mostrar la tabla de multiplicar
// COMPLETA del 1 al 10.
//
// Conceptos: bucles anidados — el externo recorre las filas (i) y el
// interno las columnas (j); cada celda es i*j. El formato {i * j,4}
// reserva 4 espacios para que las columnas queden alineadas, y
// Console.WriteLine() tras cada fila salta de línea.
//
// Ejecutar: dotnet run estructurada36.cs
// ============================================================================

for (int i = 1; i <= 10; i++)       // Fila: el multiplicando
{
    for (int j = 1; j <= 10; j++)   // Columna: el multiplicador
        Console.Write($"{i * j,4}"); // ,4 = alineación de 4 caracteres
    Console.WriteLine();            // Fin de fila
}
