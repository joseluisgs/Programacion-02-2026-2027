// ============================================================================
// Ejercicio 48: Encontrar el mayor de 5 números (con aserciones) — UD02/ejemplos
//
// ENUNCIADO: Pedir 5 números al usuario y mostrar el mayor de todos,
// VERIFICANDO la lógica del máximo con una aserción Debug.Assert en cada
// iteración: si en algún momento el máximo parcial no supera al número
// recién leído, el programa se detiene y avisa del error lógico.
//
// Conceptos UD02 que ilustra:
//   - El patrón clásico del máximo: se parte de int.MinValue y se va
//     actualizando solo cuando aparece un valor mayor
//   - Aserciones con Debug.Assert (sección 2.8): verifican SUPUESTOS del
//     programador, no datos del usuario. En Release desaparecen.
//   - TryParse para leer el teclado sin excepciones (prevención)
//
// Ejecutar: dotnet run estructurada48.cs
// ============================================================================

using System.Diagnostics;

// Empezamos en el mínimo posible: cualquier número leído será mayor
int max = int.MinValue;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Introduce el número {i}: ");
    int.TryParse(Console.ReadLine(), out int valor);

    int maxAnterior = max;
    if (valor > max)
        max = valor;

    // Aserción: verifica que max siempre es >= al valor introducido
    Debug.Assert(max >= valor, $"Error lógico: max ({max}) debería ser >= valor ({valor})");
    Console.WriteLine($"  Máximo parcial: {max}");
}

Console.WriteLine($"El mayor de los 5 números es: {max}");
