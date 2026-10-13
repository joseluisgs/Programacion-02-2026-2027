// ============================================================================
// SOLUCIÓN ejercicio 18 — Menú con opciones (Switch)
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Mostrar un menú (1=Jugar, 2=Opciones, 3=Salida), pedir una
// opción y decir qué se ha seleccionado; si no es válida, avisar.
//
// Conceptos: switch con default — el "cubrecalentazos" que evita respuestas
// silenciosas cuando el usuario escribe algo fuera del 1-3.
//
// Ejecutar: dotnet run estructurada18.cs
// ============================================================================

Console.WriteLine("1. Jugar");
Console.WriteLine("2. Opciones");
Console.WriteLine("3. Salir");
Console.Write("Opción: ");
int.TryParse(Console.ReadLine(), out int op);

switch (op)
{
    case 1: Console.WriteLine("Iniciando juego..."); break;
    case 2: Console.WriteLine("Abriendo opciones..."); break;
    case 3: Console.WriteLine("Saliendo..."); break;
    default: Console.WriteLine("Opción no válida"); break; // Fuera del 1-3
}
