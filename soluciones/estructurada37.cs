// ============================================================================
// Ejercicio 37: Triángulo de asteriscos (bucles anidados) — UD02/ejemplos
//
// ENUNCIADO: Dibujar en consola un triángulo rectángulo de 5 filas con
// asteriscos, donde la fila i tiene exactamente i asteriscos.
//
// Salida esperada:
//   *
//   **
//   ***
//   ****
//   *****
//
// Conceptos: bucle for anidado (sección 2.5 C). El bucle EXTERNO recorre
// las filas (i) y el INTERNO imprime i asteriscos: fíjate en que su
// condición (j <= i) depende de la fila actual — por eso el triángulo crece.
// Console.Write pega los asteriscos y Console.WriteLine salta de línea.
// ============================================================================

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}
