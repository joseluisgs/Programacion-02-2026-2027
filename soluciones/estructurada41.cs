// Ejercicio 41: Break en Bucle (While)
int numero;
do
{
    Console.Write("Introduce un número: ");
    int.TryParse(Console.ReadLine(), out numero);
} while (numero != 42);

Console.WriteLine("¡Encontrado!");
