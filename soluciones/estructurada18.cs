// Ejercicio 18: Menú con Opciones (Switch)
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
    default: Console.WriteLine("Opción no válida"); break;
}
