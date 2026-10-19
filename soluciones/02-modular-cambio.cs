// ============================================================================
// Cambio de monedas (modular) — UD02/ejemplos
//
// ENUNCIADO: Dada una cantidad en euros introducida por el usuario, mostrar
// el cambio en monedas (de mayor a menor denominación): 2€, 1€, 50c, 20c,
// 10c, 5c, 2c y 1c. Ejemplo: 3.87€ -> 1x2€ + 1€ + 1x50c + 1x20c + 1x10c + 1x5c + 1x2c.
//
// Conceptos UD02 que ilustra:
//   - Función con return (LeerCantidad) y procedimiento void (CambioMonedas)
//   - División entera (/) para contar cuántas monedas de cada tipo caben
//     y módulo (%) para ir quedándonos con el resto
//   - Constantes con nombre en mayúsculas (DRY: el valor de la moneda está en un solo sitio)
//   - Entrada robusta: TryParse + do-while hasta que el dato sea válido
//
// Ejecutar: dotnet run 02-modular-cambio.cs
// ============================================================================

Console.WriteLine("Hola Cambio");

decimal cantidad = LeerCantidad();
CambioMonedas(cantidad);

// Función auxiliar para leer y validar un valor decimal positivo
// (prevención con TryParse: el usuario puede escribir lo que quiera)
decimal LeerCantidad()
{
    decimal cantidad = 0.0m;
    bool isSaldoInvalido = true;

    do
    {
        Console.Write("Introduce la cantidad a cambiar: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal cantidadLeida))
        {
            cantidad = cantidadLeida;
            if (cantidad > 0)
            {
                isSaldoInvalido = false;
            }
            else
            {
                Console.WriteLine("Error: La cantidad debe ser positiva.");
            }
        }
        else
        {
            Console.WriteLine("Error: Entrada no válida. Introduce un número decimal.");
        }
    } while (isSaldoInvalido);

    return cantidad;
}

// Procedimiento para calcular y mostrar el cambio de monedas
// Algoritmo voraz: siempre cogemos las monedas de MAYOR valor primero.
void CambioMonedas(decimal cantidad)
{
    // Trabajamos en céntimos (int) para evitar los problemas de precisión del decimal
    int cantidadCentimos = (int)(cantidad * 100);

    const int MONEDA_2_EURO = 200;
    const int MONEDA_1_EURO = 100;
    const int MONEDA_50_CENT = 50;
    const int MONEDA_20_CENT = 20;
    const int MONEDA_10_CENT = 10;
    const int MONEDA_5_CENT = 5;
    const int MONEDA_2_CENT = 2;
    const int MONEDA_1_CENT = 1;

    int resto = cantidadCentimos;

    Console.WriteLine("Cambio en monedas:");

    // Patrón repetido en cada bloque:
    //   monedas = resto / valorMoneda  -> cuántas monedas de este tipo caben
    //   resto %= valorMoneda           -> nos quedamos con lo que sobra
    if (resto >= MONEDA_2_EURO)
    {
        int monedas = resto / MONEDA_2_EURO;
        resto %= MONEDA_2_EURO;
        Console.WriteLine($"{monedas} moneda(s) de 2€");
    }
    if (resto >= MONEDA_1_EURO)
    {
        int monedas = resto / MONEDA_1_EURO;
        resto %= MONEDA_1_EURO;
        Console.WriteLine($"{monedas} moneda(s) de 1€");
    }
    if (resto >= MONEDA_50_CENT)
    {
        int monedas = resto / MONEDA_50_CENT;
        resto %= MONEDA_50_CENT;
        Console.WriteLine($"{monedas} moneda(s) de 50c");
    }
    if (resto >= MONEDA_20_CENT)
    {
        int monedas = resto / MONEDA_20_CENT;
        resto %= MONEDA_20_CENT;
        Console.WriteLine($"{monedas} moneda(s) de 20c");
    }
    if (resto >= MONEDA_10_CENT)
    {
        int monedas = resto / MONEDA_10_CENT;
        resto %= MONEDA_10_CENT;
        Console.WriteLine($"{monedas} moneda(s) de 10c");
    }
    if (resto >= MONEDA_5_CENT)
    {
        int monedas = resto / MONEDA_5_CENT;
        resto %= MONEDA_5_CENT;
        Console.WriteLine($"{monedas} moneda(s) de 5c");
    }
    if (resto >= MONEDA_2_CENT)
    {
        int monedas = resto / MONEDA_2_CENT;
        resto %= MONEDA_2_CENT;
        Console.WriteLine($"{monedas} moneda(s) de 2c");
    }
    // Última moneda: lo que queda entero SOLO puede ser 0 o 1 céntimo
    if (resto >= MONEDA_1_CENT)
    {
        Console.WriteLine($"{resto} moneda(s) de 1c");
    }
}
