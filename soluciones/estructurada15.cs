// ============================================================================
// SOLUCIÓN ejercicio 15 — Mayor de edad con ternario
// Batería: programación estructurada, bloque II
//
// ENUNCIADO: Pedir la edad y usar el operador ternario para asignar el
// mensaje: "Puedes votar" si tiene 18 o más, "Todavía no puedes votar" si no.
//
// Conceptos: operador ternario ? : — forma reducida del if-else que
// DEVUELVE un valor (ideal para asignaciones de una línea). Si la lógica
// crece, mejor un if-else normal.
//
// Ejecutar: dotnet run estructurada15.cs
// ============================================================================

Console.Write("Edad: ");
int.TryParse(Console.ReadLine(), out int edad);

// condición ? valor_si_verdadero : valor_si_falso
string msg = edad >= 18 ? "Puedes votar" : "Todavía no puedes votar";
Console.WriteLine(msg);
