// ============================================================================
// SOLUCIÓN ejercicio 29 — Media con centinela (While)
// Batería: programación estructurada, bloque III
//
// ENUNCIADO: Pedir notas al usuario hasta que escriba -1 (el CENTINELA):
// entonces se detiene y muestra la media de las notas válidas.
//
// Conceptos: control por centinela — el valor -1 marca el fin de la
// entrada de datos (no es una nota, es una señal). Acumuladores: suma y
// count se actualizan solo con notas válidas, y la media se divide al final.
// Ojo: se valida el formato (TryParse) y el rango (>= 0) a la vez.
//
// Ejecutar: dotnet run estructurada29.cs
// ============================================================================

double suma = 0;
int count = 0;
double nota;

do
{
    Console.Write("Nota (-1 para salir): ");
    bool input = double.TryParse(Console.ReadLine(), out nota);
    if (input && nota >= 0) // Solo cuenta si es número y no es el centinela
    {
        suma += nota;
        count++;
    }
} while (nota >= 0); // El -1 (centinela) detiene el bucle

if (count > 0)
    Console.WriteLine($"Media: {suma / count:F2}");
else
    Console.WriteLine("No se introdujeron notas"); // Sin notas, no hay media
