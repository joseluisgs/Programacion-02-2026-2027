// Ejercicio 15: Mayor de Edad con Ternario
Console.Write("Edad: ");
int.TryParse(Console.ReadLine(), out int edad);

string msg = edad >= 18 ? "Puedes votar" : "Todavía no puedes votar";
Console.WriteLine(msg);
