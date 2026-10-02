// Ejercicio 14: Día de la Semana (Switch con agrupación)
Console.Write("Día (1-7): ");
int.TryParse(Console.ReadLine(), out int dia);

switch (dia)
{
    case 1: Console.WriteLine("Lunes"); break;
    case 2: Console.WriteLine("Martes"); break;
    case 3: Console.WriteLine("Miércoles"); break;
    case 4: Console.WriteLine("Jueves"); break;
    case 5: Console.WriteLine("Viernes"); break;
    case 6: case 7: Console.WriteLine("¡Fin de semana!"); break;
    default: Console.WriteLine("No válido"); break;
}
