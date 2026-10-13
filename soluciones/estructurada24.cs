// ============================================================================
// SOLUCIÓN ejercicio 24 — Validar contraseña (Do-While)
// Batería: programación estructurada, bloque III
//
// ENUNCIADO: Con do-while, pedir una contraseña repitiendo la petición
// mientras tenga menos de 8 caracteres. Mostrar "Contraseña aceptada".
//
// Conceptos: do-while como "bucle de reintento" — el dato se pide al
// menos una vez y no se sale hasta que cumple la regla. Es el patrón de
// las lecturas robustas del tema 4 (LeerEntero).
//
// Ejecutar: dotnet run estructurada24.cs
// ============================================================================

string password;
do
{
    Console.Write("Introduce contraseña (mín. 8 caracteres): ");
    password = Console.ReadLine();
} while (password.Length < 8); // Mientras sea corta, insiste

Console.WriteLine("Contraseña aceptada");
