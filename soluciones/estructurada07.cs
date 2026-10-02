// Ejercicio 7: División Entera y Resto (Aritmética)
Console.Write("Dividendo: ");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Divisor: ");
int.TryParse(Console.ReadLine(), out int b);

Console.WriteLine($"{a} / {b} = {a / b}"); // 3 / 2 = 1
Console.WriteLine($"{a} % {b} = {a % b}"); // 3 % 2 = 1
