// ============================================================================
// Números primos y gemelos (modular) — UD02/ejemplos
//
// ENUNCIADO: Mostrar los 100 primeros números primos, los 50 primeros pares
// de primos gemelos, y consultar gemelos dentro de un rango.
//   - Primo: número mayor que 1 divisible solo por 1 y por sí mismo.
//   - Primos gemelos: dos primos cuya diferencia es exactamente 2 (ej: 3 y 5,
//     5 y 7, 11 y 13).
//
// Conceptos UD02 que ilustra:
//   - Funciones bool que responden a una pregunta (IsPrime, EsPrimoGemelo)
//   - OJO con la SOBRECARGA: solo existe en métodos de CLASE, no en las
//     funciones locales de los top-level statements (error CS0128). Por eso
//     la versión de un parámetro se llama EsPrimoGemelo y no se puede
//     llamar igual que AreTwinPrimeNumbers(num1, num2)
//   - while para contar "los N primeros" y for para recorrer un rango
//   - Optimización: basta probar divisores hasta la raíz cuadrada, y solo
//     impares tras descartar el 2 (un primo > 2 nunca es par)
//
// Ejecutar: dotnet run 03-modular-primos.cs
// ============================================================================

Console.WriteLine("Hola Primos");

Console.WriteLine("Primeros 100 números primos");
PrintFirstPrimeNumbers(100);

Console.WriteLine("Primeros 50 números primos gemelos");
PrintFirstTwinPrimeNumbers(50);

// Procedimiento que imprime los primeros 'number' números primos
void PrintFirstPrimeNumbers(int number)
{
    int count = 0;
    int i = 2;

    while (count < number) // No sabemos cuántos números tocará recorrer: while
    {
        if (IsPrime(i))
        {
            Console.WriteLine($"{count + 1}: {i}");
            count++;
        }
        i++;
    }
}

// Procedimiento que imprime los primeros 'number' números primos gemelos
void PrintFirstTwinPrimeNumbers(int number)
{
    int count = 0;
    int i = 2;

    while (count < number)
    {
        if (EsPrimoGemelo(i)) // i e i+2 forman la pareja de gemelos
        {
            Console.WriteLine($"{count + 1}: {i}, {i + 2}");
            count++;
        }
        i++;
    }
}

// Procedimiento que imprime números primos gemelos en un rango
void PrintTwinPrimeNumbersInRange(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        if (EsPrimoGemelo(i))
        {
            Console.WriteLine($"{i}, {i + 2}");
        }
    }
}

// Comprueba si num y num+2 son gemelos
// (Nombre distinto al de dos parámetros: las funciones locales NO se pueden
// sobrecargar — con métodos de clase, SÍ podrían llamarse igual)
bool EsPrimoGemelo(int num)
{
    return AreTwinPrimeNumbers(num, num + 2);
}

// Comprueba si dos números son primos gemelos
bool AreTwinPrimeNumbers(int num1, int num2)
{
    return IsPrime(num1) && IsPrime(num2) && Math.Abs(num1 - num2) == 2;
}

// Comprueba si un número es primo
bool IsPrime(int num)
{
    if (num == 0 || num == 1)
        return false; // Casos base: 0 y 1 no son primos
    if (num == 2 || num == 3)
        return true;  // El 2 es el único primo PAR
    if (num % 2 == 0)
        return false; // Descartamos todos los pares de golpe

    // Solo hace falta probar los impares hasta la raíz cuadrada:
    // si num = a * b, uno de los dos factores no puede superar √num
    int sqrtNum = (int)Math.Sqrt(num);

    for (int i = 3; i <= sqrtNum; i += 2)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}
