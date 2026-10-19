// ============================================================================
// Ejercicio 43 — Conexión simulada con try-catch-finally (batería modular)
//
// ENUNCIADO: Simular la conexión a una base de datos que puede fallar,
// mostrando que el bloque finally se ejecuta SIEMPRE (con o sin error).
//
// Conceptos UD02 (punto 4): la trinidad try/catch/finally — sección 4.7.
//   - try: el código que puede fallar
//   - catch: recoge el error y evita que el programa muera
//   - finally: "hagas lo que hagas" — ideal para liberar recursos
//
// Ejecutar: dotnet run modular43.cs
// ============================================================================

void Conectar(string cadenaConexion)
{
    try
    {
        if (cadenaConexion == "error")
            throw new Exception("Error de conexión"); // Simulamos el fallo
        Console.WriteLine("Conectado a la BD");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    finally
    {
        // Se ejecuta tanto si hubo error como si no: cierre garantizado
        Console.WriteLine("Conexión cerrada");
    }
}

Conectar("ok");     // Imprime: Conectado... y luego "Conexión cerrada"
Console.WriteLine("---");
Conectar("error");  // Imprime: Error... y AUN ASÍ "Conexión cerrada"
