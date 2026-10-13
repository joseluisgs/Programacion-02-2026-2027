// ============================================================================
// SOLUCIÓN ejercicio 22 — Menú repetitivo (Do-While)
// Batería: programación estructurada, bloque III
//
// ENUNCIADO: Con do-while, mostrar un menú (1=Jugar, 2=Opciones,
// 3=Salir). Si elige 3, se sale; si no, vuelve a mostrar el menú.
//
// Conceptos: do-while — la condición se evalúa DESPUÉS, así que el menú
// se muestra SIEMPRE al menos una vez (perfecto para menús). Salida: la
// única forma de salir es la opción 3.
//
// Ejecutar: dotnet run estructurada22.cs
// ============================================================================

int opcion;
do
{
    Console.WriteLine("\n=== Menú ===");
    Console.WriteLine("1. Jugar");
    Console.WriteLine("2. Opciones");
    Console.WriteLine("3. Salir");
    Console.Write("Opción: ");
    int.TryParse(Console.ReadLine(), out opcion);

    if (opcion != 3)
        Console.WriteLine($"Seleccionaste: {opcion}");
} while (opcion != 3); // Se repite hasta que elija salir

// Aqui solo llegamos si has seleccionado la opción 3, 
// es decir, salir del programa
Console.WriteLine("¡Hasta luego!");
