// ============================================================================
// SOLUCIÓN ejercicio 11 — Clasificación por edad (if-else if-else)
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Pedir la edad y clasificar con if-else if-else:
// Niño (<12), Adolescente (12-17), Adulto (18-64), Mayor (65+).
//
// Conceptos: condicionales múltiples encadenados — se evalúan DE ARRIBA A
// ABAJO y se ejecuta SOLO el primero que se cumple. Por eso el orden va de
// menor a mayor rango: si pusiéramos "edad < 65" primero, nadie sería Mayor.
//
// Ejecutar: dotnet run estructurada11.cs
// ============================================================================

Console.Write("Introduce tu edad: ");
int.TryParse(Console.ReadLine(), out int edad);

if (edad < 12)
    Console.WriteLine("Niño");
else if (edad < 18)   // Implica: edad >= 12
    Console.WriteLine("Adolescente");
else if (edad < 65)   // Implica: edad >= 18
    Console.WriteLine("Adulto");
else                  // Todo lo demás: 65 o más
    Console.WriteLine("Mayor");
