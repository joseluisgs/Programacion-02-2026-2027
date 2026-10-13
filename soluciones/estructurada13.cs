// ============================================================================
// SOLUCIÓN ejercicio 13 — Consola de gaming (Switch)
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Pedir una opción numérica (1-4) y con switch mostrar:
// 1=PlayStation, 2=Xbox, 3=Nintendo, 4=PC. Opción no válida en el default.
//
// Conceptos: estructura switch — más limpia que una cadena de if-else if
// cuando comparamos UNA variable contra valores concretos. Cada case
// termina con break (en C#, sin break sería error de compilación).
//
// Ejecutar: dotnet run estructurada13.cs
// ============================================================================

Console.Write("Consola (1=PS, 2=Xbox, 3=Nintendo, 4=PC): ");
int.TryParse(Console.ReadLine(), out int op);

switch (op)
{
    case 1: Console.WriteLine("PlayStation"); break;
    case 2: Console.WriteLine("Xbox"); break;
    case 3: Console.WriteLine("Nintendo"); break;
    case 4: Console.WriteLine("PC"); break;
    default: Console.WriteLine("Inválido"); break; // Si no coincide con ninguno
}
