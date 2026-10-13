// ============================================================================
// SOLUCIÓN ejercicio 21 — Cuenta atrás (While)
// Batería: programación estructurada, bloque III
//
// ENUNCIADO: Con un while, mostrar una cuenta atrás del 10 al 0 y, al
// llegar a 0, imprimir "¡Lanzamiento!".
//
// Conceptos: bucle while — la condición se evalúa ANTES de cada iteración;
// la variable de control (i) se decrementa dentro del bucle (si no,
// bucle infinito). Alternativa equivalente con for descendente.
//
// Ejecutar: dotnet run estructurada21.cs
// ============================================================================

int i = 10;
while (i >= 0)
{
    Console.WriteLine(i);
    i--; // Sin esto, el bucle nunca terminaría
}
Console.WriteLine("¡Lanzamiento!");

// Alternativa con for
for (int j = 10; j >= 0; j--)
{
    Console.WriteLine(j);
}
Console.WriteLine("¡Lanzamiento!");
