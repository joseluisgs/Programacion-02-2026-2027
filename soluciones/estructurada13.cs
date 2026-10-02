// Ejercicio 13: Consola de Gaming (Switch)
Console.Write("Consola (1=PS, 2=Xbox, 3=Nintendo, 4=PC): ");
int.TryParse(Console.ReadLine(), out int op);

switch (op)
{
    case 1: Console.WriteLine("PlayStation"); break;
    case 2: Console.WriteLine("Xbox"); break;
    case 3: Console.WriteLine("Nintendo"); break;
    case 4: Console.WriteLine("PC"); break;
    default: Console.WriteLine("Inválido"); break;
}
