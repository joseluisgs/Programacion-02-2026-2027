// ============================================================================
// SOLUCIÓN ejercicio 1 — Tu Setup de Programador (Secuencias)
// Batería: programación estructurada, bloque I
//
// ENUNCIADO: Mostrar tu setup de programador: marca del portátil (string),
// pulgadas de pantalla (int), RAM en GB (int) y sistema operativo (string),
// todo con interpolación en un formato bonito.
//
// Conceptos: secuencia pura — las sentencias se ejecutan de arriba a
// abajo; se usan los tipos básicos (string, int) y la interpolación $"".
// Truco: \" imprime una comilla literal (pulgadas).
//
// Ejecutar: dotnet run estructurada01.cs
// ============================================================================

string marca = "Lenovo";
int pulgadas = 15;
int ram = 16;
string so = "Windows 11";

Console.WriteLine("=== Mi Setup de Programador ===");
Console.WriteLine($"Marca: {marca}");
Console.WriteLine($"Pantalla: {pulgadas}\"");
Console.WriteLine($"RAM: {ram} GB");
Console.WriteLine($"Sistema Operativo: {so}");
