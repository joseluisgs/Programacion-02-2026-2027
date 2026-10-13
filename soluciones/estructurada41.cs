// ============================================================================
// SOLUCIÓN ejercicio 41 — Break en bucle (While)
// Batería: programación estructurada, bloque V
//
// ENUNCIADO: Pedir números al usuario; cuando escriba 42, mostrar
// "¡Encontrado!" y salir.
//
// Conceptos: salir del bucle. Esta solución resuelve la salida con la
// CONDICIÓN del do-while (numero != 42). Equivalente con break, como pide
// el enunciado literal:
//
//   while (true) {
//       Console.Write("Introduce un número: ");
//       int.TryParse(Console.ReadLine(), out int numero);
//       if (numero == 42) { Console.WriteLine("¡Encontrado!"); break; }
//   }
//
// Ejecutar: dotnet run estructurada41.cs
// ============================================================================

int numero;
do
{
    Console.Write("Introduce un número: ");
    int.TryParse(Console.ReadLine(), out numero);
} while (numero != 42); // Mientras no sea el 42, sigue pidiendo

Console.WriteLine("¡Encontrado!");
