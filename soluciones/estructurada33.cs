// Ejercicio 33: Factorial (For)
Console.Write("Número: ");
int.TryParse(Console.ReadLine(), out int num);

long factorial = 1;
for (int i = 2; i <= num; i++)
    factorial *= i;

Console.WriteLine($"{num}! = {factorial}");
