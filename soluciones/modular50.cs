// ============================================================================
// Ejercicio extra — Simulador modular parametrizado (ejemplo de examen)
//
// ENUNCIADO: Como el simulador simple (ejercicio de la sesión), pero
// PARAMETRIZADO: la función Simular recibe duración, incremento y
// probabilidad de salida, de forma que la misma función sirve para
// cualquier simulación (el "motor" no cambia, solo los datos).
//
// Conceptos UD02: la versatilidad de lo modular — una función bien
// parametrizada reemplaza a media docena de copias pegadas (DRY).
// do-while con dos condiciones de parada unidas con &&.
//
// Ejecutar: dotnet run modular50.cs
// ============================================================================

void Simular(int tiempoMaximo, int incremento, decimal probabilidadSalida)
{
    int tiempo = 0;
    bool salida = false;

    do
    {
        Thread.Sleep(incremento);
        tiempo += incremento;
        Console.WriteLine($"Tiempo: {tiempo}ms");
        salida = Probabilidad(probabilidadSalida);
    } while (tiempo < tiempoMaximo && !salida); // Tiene por azar O por tiempo

    Console.WriteLine(salida
        ? "Salida por probabilidad"
        : "Tiempo de simulación agotado");
}

bool Probabilidad(decimal prob)
{
    Random rnd = new();
    return (decimal)rnd.NextDouble() < prob;
}

Console.WriteLine("=== Simulador ===");
Simular(5000, 1000, 0.30m); // Máx. 5s, pasos de 1s, 30% de probabilidad por paso
