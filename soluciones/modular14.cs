// ============================================================================
// Ejercicio 14 — Parámetros por defecto (batería de programación modular)
//
// ENUNCIADO: Registrar un usuario mostrando sus datos, donde el flag
// "premium" es opcional (por defecto false).
//
// Conceptos UD02: parámetros con valor por defecto — sección 3.5.
// El parámetro opcional debe ir DESPUÉS de los obligatorios; al llamar,
// podemos omitirlo (Ana) o pasarlo explícitamente (Luis). También puedes
// usar argumentos nombrados: Registrar(email: "...", nombre: "...").
//
// Ejecutar: dotnet run modular14.cs
// ============================================================================

void Registrar(string nombre, string email, bool premium = false) // premium es opcional
{
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Email: {email}");
    Console.WriteLine($"Premium: {premium}");
}

Registrar("Ana", "ana@email.com");              // Usa el valor por defecto: false
Console.WriteLine("---");
Registrar("Luis", "luis@email.com", true);      // Lo indicamos explícitamente: true
