// ============================================================================
// Ejercicio 49 — Validación completa con excepciones (batería modular)
//
// ENUNCIADO: Crear un pedido validando unidades, precio y día; cada regla
// violada lanza SU excepción con mensaje descriptivo. El programa de prueba
// muestra un caso bueno y uno con varios errores a la vez.
//
// Conceptos UD02 (punto 4):
//   - Un método puede lanzar DISTINTOS tipos de excepción según qué regla
//     se rompa (ArgumentException, ArgumentOutOfRangeException...)
//   - Solo se lanza la PRIMERA regla incumplida (el throw corta el método)
//   - El catch(Exception) del llamador recoge lo que burbujee; en la práctica
//     convendría catches específicos para responder mejor a cada error
//
// Ejecutar: dotnet run modular49.cs
// ============================================================================

void CrearPedido(int unidades, double precio, int dia)
{
    if (unidades <= 0)
        throw new ArgumentException("Las unidades deben ser positivas");
    if (precio <= 0 || precio > 10000)
        throw new ArgumentOutOfRangeException(nameof(precio), "El precio debe estar entre 0 y 10000€");
    if (dia < 1 || dia > 31)
        throw new ArgumentOutOfRangeException(nameof(dia), "El día debe estar entre 1 y 31");

    Console.WriteLine($"Pedido creado: {unidades} uds × {precio}€, día {dia}");
}

try
{
    CrearPedido(3, 49.90, 15); // Caso bueno
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    // Unidades negativas: se lanza ArgumentException AQUÍ y el precio y el
    // día ni siquiera se llegan a validar
    CrearPedido(-2, 99999, 40);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}"); // Solo verás el de las unidades
}


// Tambien con if para validar antes de llamar a la función, evitando que se lance la excepción
// Early Exit
int unidades = -2;
double precio = 99999;
int dia = 40;
if (unidades <= 0)
{
    Console.WriteLine($"Error: Las unidades deben ser positivas, pero se ha recibido {unidades}");
}
else if (precio <= 0 || precio > 10000)
{
    Console.WriteLine($"Error: El precio debe estar entre 0 y 10000€, pero se ha recibido {precio}€");
}
else if (dia < 1 || dia > 31)
{
    Console.WriteLine($"Error: El día debe estar entre 1 y 31, pero se ha recibido {dia}");
}
else
{
    CrearPedido(unidades, precio, dia); // Llamada segura
}
