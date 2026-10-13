// ============================================================================
// SOLUCIÓN ejercicio 42 — Continue: solo pares (For)
// Batería: programación estructurada, bloque V
//
// ENUNCIADO: Del 1 al 20, usar continue para saltar los impares y mostrar
// solo los pares.
//
// Conceptos: continue — SALTA a la siguiente iteración sin ejecutar el
// código que queda. Fíjate en el orden: el continue va ANTES del
// WriteLine, así que los impares nunca llegan a imprimirse.
//
// Ejecutar: dotnet run estructurada42.cs
// ============================================================================

for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)
        continue; // Impar: nos saltamos el resto del cuerpo
    Console.WriteLine(i); // Solo llegan los pares: 2, 4, 6... 20
}
