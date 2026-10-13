// ============================================================================
// SOLUCIÓN ejercicio 46 — Números primos (for con anidado)
// Batería: programación estructurada, bloque V
//
// ENUNCIADO: Del 2 al 50, comprobar con un bucle anidado si cada número
// es primo y mostrar los que lo son.
//
// Conceptos: bucle anidado + bandera (bool esPrimo) + break. La bandera
// empieza en "true" y el bucle interior la pone en false si encuentra un
// divisor; el break evita seguir comprobando de más. Solo hace falta
// probar hasta la raíz cuadrada del número.
//
// Ejecutar: dotnet run estructurada46.cs
// ============================================================================

for (int num = 2; num <= 50; num++)
{
    bool esPrimo = true; // Bandera: asumimos primo hasta demostrar lo contrario
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) // ¿Alguno lo divide exacto?
        {
            esPrimo = false;
            break; // No hace falta seguir: ya sabemos que no es primo
        }
    }
    if (esPrimo)
        Console.WriteLine($"{num} es primo"); // 2, 3, 5, 7, 11... 47
}
