// ============================================================================
// Ejercicio 39: Pirámide de números (bucles anidados) — UD02/ejemplos
//
// ENUNCIADO: Dibujar en consola una escalera de números de 5 filas, donde
// la fila i imprime los números desde 1 hasta i.
//
// Salida esperada:
//   1
//   12
//   123
//   1234
//   12345
//
// Conceptos: igual que el triángulo de asteriscos (ejercicio 37), pero el
// bucle interior imprime el VALOR de j (no un carácter fijo): la única
// diferencia es Console.Write(j) en vez de Console.Write("*").
// ============================================================================

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write(j);
    Console.WriteLine();
}
