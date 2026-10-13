// ============================================================================
// SOLUCIÓN ejercicio 14 — Día de la semana (Switch con agrupación)
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Pedir un número del 1 al 7 y con switch mostrar el día. Si es
// 6 o 7, mostrar "¡Fin de semana!" agrupando los casos con case 6: case 7:.
//
// Conceptos: agrupación de cases — los case vacíos "se apilan" y comparten
// el mismo bloque de sentencias (es la única excepción a la obligación de
// break en C#).
//
// Ejecutar: dotnet run estructurada14.cs
// ============================================================================

Console.Write("Día (1-7): ");
int.TryParse(Console.ReadLine(), out int dia);

switch (dia)
{
    case 1: Console.WriteLine("Lunes"); break;
    case 2: Console.WriteLine("Martes"); break;
    case 3: Console.WriteLine("Miércoles"); break;
    case 4: Console.WriteLine("Jueves"); break;
    case 5: Console.WriteLine("Viernes"); break;
    case 6: case 7: Console.WriteLine("¡Fin de semana!"); break; // Casos agrupados
    default: Console.WriteLine("No válido"); break;
}
