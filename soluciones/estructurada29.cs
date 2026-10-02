// Ejercicio 29: Media con Centinela (While)
double suma = 0;
int count = 0;
double nota;

do
{
    Console.Write("Nota (-1 para salir): ");
    bool input = double.TryParse(Console.ReadLine(), out nota);
    if (input && nota >= 0)
    {
        suma += nota;
        count++;
    }
} while (nota >= 0);

if (count > 0)
    Console.WriteLine($"Media: {suma / count:F2}");
else
    Console.WriteLine("No se introdujeron notas");
