// Ejercicio 24: Validar Contraseña (Do-While)
string password;
do
{
    Console.Write("Introduce contraseña (mín. 8 caracteres): ");
    password = Console.ReadLine();
} while (password.Length < 8);

Console.WriteLine("Contraseña aceptada");
