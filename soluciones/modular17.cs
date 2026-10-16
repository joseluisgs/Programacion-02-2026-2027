// ============================================================================
// Ejercicio 17 — Early Return en validación (batería de programación modular)
//
// ENUNCIADO: Validar una edad (0..120) usando cláusulas de guardia:
// se descartan los casos erróneos con return inmediato y el "camino feliz"
// queda al final, plano y legible.
//
// Conceptos UD02: Early Return / Guard Clauses — sección 3.7. Evita el
// "efecto cascada" de if anidados (el Hadouken del tema).
//
// Ejecutar: dotnet run modular17.cs
// ============================================================================

bool ValidarEdad(int edad)
{
    if (edad < 0) return false;   // Guard clause 1: fuera de rango por abajo
    if (edad > 120) return false; // Guard clause 2: fuera de rango por arriba
    return true;                  // Si llegamos aquí, el dato es válido
}

Console.WriteLine(ValidarEdad(25) ? "Válida" : "Inválida");   // Válida
Console.WriteLine(ValidarEdad(-5) ? "Válida" : "Inválida");  // Inválida
Console.WriteLine(ValidarEdad(150) ? "Válida" : "Inválida"); // Inválida
