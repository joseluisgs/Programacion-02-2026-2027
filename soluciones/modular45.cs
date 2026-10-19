// ============================================================================
// Ejercicio 45 — Finally con recursos (batería de programación modular)
//
// ENUNCIADO: Procesar datos con un recurso abierto, simulando un fallo,
// y demostrar que el recurso se cierra SIEMPRE gracias a finally.
//
// Conceptos UD02 (punto 4): finally como "limpieza garantizada" — la
// alternativa manual a los bloques using que vimos en el punto 4.7.
// Prueba a ejecutarlo con fallar=false y fallar=true: el "Recurso cerrado"
// se imprime en AMBOS casos.
//
// Ejecutar: dotnet run modular45.cs
// ============================================================================

void Procesar(bool fallar)
{
    bool recursoAbierto = true;
    try
    {
        Console.WriteLine("Procesando datos...");
        if (fallar) throw new Exception("Error de procesamiento");
        Console.WriteLine("Datos procesados correctamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    finally
    {
        // Liberar el recurso AQUÍ es la ubicación clásica: se ejecuta
        // haya error o no, e incluso si el try hace un return
        recursoAbierto = false;
        Console.WriteLine("Recurso cerrado (finally)");
    }
}

Procesar(false); // Caso feliz
Console.WriteLine("---");
Procesar(true);  // Caso de fallo: el finally se ejecuta igualmente
