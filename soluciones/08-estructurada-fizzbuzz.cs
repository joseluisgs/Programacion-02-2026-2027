// 08 - Estructurada: FizzBuzz — El clásico interview question
// Consigna: Del 1 al 100, si es múltiplo de 3 imprime "Fizz", si es múltiplo de 5 imprime "Buzz",
// si es múltiplo de ambos imprime "FizzBuzz", si no imprime el número.

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
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
