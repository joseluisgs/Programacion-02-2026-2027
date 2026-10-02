// Ejercicio 16: Ternario Anidado: Nota
Console.Write("Nota (0-10): ");
double.TryParse(Console.ReadLine(), out double nota);

string resultado = nota < 4 ? "Malo"
    : nota < 7 ? "Regular"
    : nota < 9 ? "Bueno"
    : "Excelente";

Console.WriteLine($"{nota} → {resultado}");
