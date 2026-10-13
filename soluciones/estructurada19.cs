// ============================================================================
// SOLUCIÓN ejercicio 19 — Tipo de sangre (Switch expresión)
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Pedir un número (1-4) y devolver el tipo de sangre:
// 1=A+, 2=A-, 3=B+, 4=O+; cualquier otro, "Desconocido".
//
// Conceptos: switch EXPRESIÓN (C# 8+) — devuelve un valor directamente,
// es más conciso que el switch de sentencias. El guion bajo _ es el
// "default" de la expresión y garantiza que sea exhaustiva.
//
// Ejecutar: dotnet run estructurada19.cs
// ============================================================================

Console.Write("Tipo (1-4): ");
int.TryParse(Console.ReadLine(), out int num);

string tipo = num switch
{
    1 => "A+",
    2 => "A-",
    3 => "B+",
    4 => "O+",
    _ => "Desconocido" // Rama por defecto (obligatoria para que compile)
};

Console.WriteLine($"Tipo de sangre: {tipo}");
