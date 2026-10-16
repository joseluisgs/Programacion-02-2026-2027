// ============================================================================
// Ejercicio 16 — Sobrecarga de funciones (batería de programación modular)
//
// ENUNCIADO: Calcular el área de un cuadrado (un lado) y de un rectángulo
// (largo y ancho) con el MISMO nombre de función.
//
// Conceptos UD02: sobrecarga — sección 3.6. C# elige la versión adecuada
// según el NÚMERO y TIPO de los argumentos. Ojo: no se puede sobrecargar
// solo por el tipo de RETORNO (mismo nombre + mismos parámetros = error).
// Aquí se usa la expresión de cuerpo (=>) para métodos de una sola línea.
//
// Ejecutar: dotnet run modular16.cs
// ============================================================================

int Area(int lado) => lado * lado;                    // Un argumento -> cuadrado
int Area(int largo, int ancho) => largo * ancho;      // Dos argumentos -> rectángulo

Console.WriteLine($"Cuadrado lado 5: {Area(5)}");     // 25
Console.WriteLine($"Rectángulo 4x6: {Area(4, 6)}");   // 24
