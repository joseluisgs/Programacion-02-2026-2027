// ============================================================================
// Ejercicio 13 — División con out (batería de programación modular)
//
// ENUNCIADO: Dividir dos enteros devolviendo el resultado por un parámetro
// de salida, e indicar con un bool si la división fue posible.
//
// Conceptos UD02: parámetros out — sección 3.3 C.
//   - out NO necesita inicializarse antes de la llamada...
//   - ...PERO el método está OBLIGADO a asignarlo en TODOS los caminos
//     antes de salir (por eso resultado = 0 en el caso del cero)
//   - El bool devuelve la información de éxito/fracaso; el out, el dato.
//
// Ejecutar: dotnet run modular13.cs
// ============================================================================

bool Dividir(int a, int b, out int resultado)
{
    if (b == 0)
    {
        resultado = 0; // Asignación obligatoria aunque haya error
        return false;
    }
    resultado = a / b;
    return true;
}

if (Dividir(10, 3, out int res)) // out en línea: se declara y usa a la vez
    Console.WriteLine($"10 / 3 = {res}");
else
    Console.WriteLine("No se puede dividir por cero");

if (Dividir(10, 0, out int res2))
    Console.WriteLine($"10 / 0 = {res2}");
else
    Console.WriteLine("No se puede dividir por cero"); // Se imprime este
