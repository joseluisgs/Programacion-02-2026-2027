// Ejercicio 22: Menú Repetitivo (Do-While)
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
} while (opcion != 3);

// Aqui solo llegamos si has seleccionado la opción 3, 
// es decir, salir del programa
Console.WriteLine("¡Hasta luego!");
