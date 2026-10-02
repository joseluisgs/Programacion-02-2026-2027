// Ejercicio 19: Tipo de Sangre (Switch expresión)
Console.Write("Tipo (1-4): ");
int.TryParse(Console.ReadLine(), out int num);

string tipo = num switch
{
    1 => "A+",
    2 => "A-",
    3 => "B+",
    4 => "O+",
    _ => "Desconocido"
};

Console.WriteLine($"Tipo de sangre: {tipo}");
