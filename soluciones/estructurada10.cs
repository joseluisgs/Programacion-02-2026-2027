// Ejercicio 10: Par o Impar (Condicionales simples)
Console.Write("Introduce un número: ");
int.TryParse(Console.ReadLine(), out int num);

if (num % 2 == 0)
    Console.WriteLine($"{num} es par");
else
    Console.WriteLine($"{num} es impar");
