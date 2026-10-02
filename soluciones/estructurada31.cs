// Ejercicio 31: Tabla de Multiplicar (For)
Console.Write("Número: ");
int.TryParse(Console.ReadLine(), out int num);

for (int i = 1; i <= 10; i++)
    Console.WriteLine($"{num} x {i} = {num * i}");
