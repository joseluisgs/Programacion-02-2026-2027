// ============================================================================
// Ejercicio 41 — Excepción con throw (batería de programación modular)
//
// ENUNCIADO: Validar una edad lanzando una excepción cuando esté fuera
// del rango 0..150, y recogerla en el programa principal.
//
// Conceptos UD02 (punto 4): throw con una excepción YA EXISTENTE de .NET
// (ArgumentOutOfRangeException) para reglas de negocio — sección 4.2 y 4.11.
// El que llama debe envolver la llamada en try-catch o dejar que burbujee.
//
// Ejecutar: dotnet run modular41.cs
// ============================================================================

void ValidarEdad(int edad)
{
    if (edad < 0 || edad > 150)
        // Consejo: en producción usa (nameof(edad), "mensaje") para que el
        // nombre del parámetro no se pierda si se renombra la variable
        throw new ArgumentOutOfRangeException("La edad debe estar entre 0 y 150");
    Console.WriteLine($"Edad válida: {edad}");
}

// en Program.cs, el programa principal, podemos envolver la llamada en try-catch para capturar la excepción y manejarla sin que el programa se cierre abruptamente
try
{
    ValidarEdad(25);  // Válida: se imprime
    ValidarEdad(-5);  // ¡BOOM! Lanza y SALTA directamente al catch
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Error: {ex.Message}"); // La transferencia NO continúa
}


// O podemos usar un if para validar antes de llamar a la función, evitando que se lance la excepción
int edad = 200;
if (edad < 0 || edad > 150)
{
    Console.WriteLine($"Error: La edad debe estar entre 0 y 150, pero se ha recibido {edad}");
}
else
{
    ValidarEdad(edad); // Llamada segura
}
