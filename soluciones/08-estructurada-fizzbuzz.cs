// ============================================================================
// SOLUCIÓN ejercicio 40 — FizzBuzz (el clásico de entrevistas)
// Batería: programación estructurada, bloque IV (el fichero se llama
// 08-estructurada-fizzbuzz.cs)
//
// ENUNCIADO: Del 1 al 100: si es múltiplo de 3 imprime "Fizz"; si es
// múltiplo de 5, "Buzz"; si es múltiplo de ambos, "FizzBuzz"; si no, el
// número.
//
// Conceptos: condicionales múltiples + módulo. TRUCO CLAVE: el orden de los
// if importa — hay que comprobar PRIMERO el caso más restrictivo (3 y 5 a
// la vez); si empezáramos por "i % 3 == 0", el 15 imprimiría solo "Fizz".
//
// Ejecutar: dotnet run 08-estructurada-fizzbuzz.cs
// ============================================================================

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) // Primero lo más específico
        Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine("Fizz");
    else if (i % 5 == 0)
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(i);
}


// Salida del 1 al 30
// 1
// 2
// Fizz
// 4
// Buzz
// Fizz
// 7
// 8
// Fizz
// Buzz
// 11
// Fizz
// 13
// 14
// FizzBuzz    *
// 16
// 17
// Fizz
// 19
// Buzz
// Fizz
// 22
// 23
// Fizz
// Buzz
// 26
// Fizz
// 28
// 29
// FizzBuzz    *
