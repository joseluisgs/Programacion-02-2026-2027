// Ejercicio 46: Números Primos (For con anidado)
for (int num = 2; num <= 50; num++)
{
    bool esPrimo = true;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
    if (esPrimo)
        Console.WriteLine($"{num} es primo");
}
