// Ejercicio 45: Break y Continue Juntos
for (int i = 1; i <= 50; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"Break en {i}");
        break;
    }
    if (i % 2 != 0) continue;
    Console.WriteLine(i);
}
