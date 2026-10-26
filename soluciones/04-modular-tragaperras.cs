// ============================================================================
// ENUNCIADO — Máquina Tragaperras (versión MODULAR)
//
// El mismo juego que 01-estructurada-tragaperras.cs, pero organizado con
// programación MODULAR: cada cosa vive en su sitio (principio SRP).
//
// Reglas del juego:
//   1. El saldo inicial debe ser superior a 0.00€.
//   2. Menú principal: 1) Tirar, 2) Gestionar saldo (añadir/retirar),
//      3) Ver premios, 4) Salir.
//   3. Apuesta mínima: APUESTA_MINIMA. Nunca puedes apostar más de tu saldo.
//   4. Se generan TRES números aleatorios entre 0 y 9 y se premia:
//        - JACKPOT (tres 7)      -> x10 lo apostado
//        - VICTORIA (tres iguales, no 7) -> x3
//        - SALVADO (dos iguales) -> x1.5
//        - MALA SUERTE (ninguno igual)   -> pierdes la apuesta
//   5. Si te quedas sin saldo, el programa te obliga a recargar o sale.
//
// Qué demuestra este ejemplo (UD02 + repaso UD01):
//   - Funciones con return (CalcularPremio, LeerEntero...) y procedimientos
//     void (EjecutarMenu, TirarTragaperras...) — sección 3.2
//   - Paso por REFERENCIA con ref: el saldo se modifica dentro de los
//     métodos y el cambio se ve fuera — sección 3.3 B
//   - enum para las opciones de menú y para el resultado de la tirada:
//     sustituyen a los números mágicos por NOMBRES (repaso UD01). Los
//     valores del menú son las teclas del teclado.
//   - struct Tirada: los tres rodillos viajan JUNTOS como un solo valor;
//     sin él, CalcularPremio recibiría tres sueltos que se pueden trocar.
//   - Tupla nombrada en CalcularPremio: devuelve DOS respuestas (qué
//     pasó y cuánto se paga) sin out y sin estructuras temporales.
//     struct = un DATO con identidad (la tirada); tupla = la RESPUESTA
//     de un cálculo (el resultado). Diferencia clave de la 3.3.
//   - UN SOLO Random para todo el programa (la 2.8): se crea al
//     principio y lo usa quien lo necesita (GenerarTirada).
//   - Constantes en mayúsculas para las reglas de negocio: si cambia el
//     premio, se toca un solo sitio — principio DRY
//   - Entrada robusta con TryParse + do-while (prevención, no excepciones)
//   - SRP: cada módulo hace UNA sola cosa; ahora hasta el MENSAJE vive
//     fuera del cálculo (CalcularPremio no imprime: solo calcula)
//
// Ejecutar: dotnet run 04-modular-tragaperras.cs
// ==============================================================================

// ==============================================================================
// 1. CONSTANTES GLOBALES (Reglas de Negocio)
// ==============================================================================
const decimal APUESTA_MINIMA = 0.01m;
const int JACKPOT_NUM = 7;

const int PREMIO_JACKPOT_MULT = 10;
const int PREMIO_TRES_IGUALES_MULT = 3;
const decimal PREMIO_DOS_IGUALES_MULT = 1.5m;

// Un SOLO generador de azar para todo el programa (2.8)
Random rnd = new();



// ==============================================================================
// 4. PROGRAMA PRINCIPAL (MAIN)
// ==============================================================================

decimal saldo = 0.0m;


Console.WriteLine("Bienvenido a la Máquina Tragaperras");

// 1. Solicitar saldo inicial
InicializarSaldo(ref saldo);

// 2. Ejecutar el menú principal hasta que el usuario decida salir
EjecutarMenu(ref saldo);

// 3. Mensaje de despedida
Console.WriteLine("Ha sido un placer, ¡vuelve pronto!");

return;

// ==============================================================================
// 2. FUNCIONES DE ENTRADA (Lectura Robusta)
// ==============================================================================

int LeerEntero(string mensaje)
{
    int valorLeido = 0;
    bool formatoCorrecto = false;

    do
    {
        Console.Write(mensaje);
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            valorLeido = valor;
            formatoCorrecto = true;
        }
        else
        {
            Console.WriteLine("Error de formato. Debe introducir un número entero.");
        }
    } while (!formatoCorrecto);

    return valorLeido;
}

decimal LeerDecimal(string mensaje)
{
    decimal valorLeido = 0.0m;
    bool formatoCorrecto = false;

    do
    {
        Console.Write(mensaje);
        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            valorLeido = valor;
            formatoCorrecto = true;
        }
        else
        {
            Console.WriteLine("Error de formato. Debe introducir un número (ej: 10 o 5.50).");
        }
    } while (!formatoCorrecto);

    return valorLeido;
}

// ==============================================================================
// 3. FUNCIÓN DE UTILIDAD Y VALIDACIÓN
// ==============================================================================

bool IsSuperiorA(decimal num, decimal umbral)
{
    return num > umbral;
}

// ==============================================================================
// X. PROCEDIMIENTO PARA INICIALIZAR EL SALDO (SRP)
// ==============================================================================
void InicializarSaldo(ref decimal saldo)
{
    bool isSaldoValido;
    do
    {
        Console.WriteLine("----------------------");
        saldo = LeerDecimal("¿Con cuánto saldo deseas iniciar? (€): ");
        isSaldoValido = IsSuperiorA(saldo, 0.0m);
        if (!isSaldoValido)
            Console.WriteLine("Error. La cantidad debe ser superior a 0.00€.");
    } while (!isSaldoValido);
}

// ==============================================================================
// 5. PROCEDIMIENTO PRINCIPAL PARA EL MENÚ DE OPCIONES
// ==============================================================================

void EjecutarMenu(ref decimal saldo)
{
    // El enum sustituye al int: "OpcionMenu.Tirar" se lee solo, mientras
    // que el 1 era un número mágico que había que recordar
    OpcionMenu opcionElegida;

    do
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Saldo actual: {saldo}€");
        Console.WriteLine("Elija una opción:");
        Console.WriteLine($"{(int)OpcionMenu.Tirar}.- Tirar de la tragaperras.");
        Console.WriteLine($"{(int)OpcionMenu.Gestionar}.- Gestionar saldo.");
        Console.WriteLine($"{(int)OpcionMenu.Premios}.- Ver premios.");
        Console.WriteLine($"{(int)OpcionMenu.Salir}.- Salir.");

        // El usuario escribe un número; el enum es un número por debajo,
        // así que el casting es seguro y el switch queda autoexplicativo
        opcionElegida = (OpcionMenu)LeerEntero("Opción elegida = ");

        switch (opcionElegida)
        {
            case OpcionMenu.Tirar:
                TirarTragaperras(ref saldo);
                break;
            case OpcionMenu.Gestionar:
                GestionarSaldo(ref saldo);
                break;
            case OpcionMenu.Premios:
                ImprimirListaPremios();
                break;
            case OpcionMenu.Salir:
                Console.WriteLine("Saliendo del programa...");
                break;
            default: // el default cubre números que no son opciones (p. ej. 9)
                Console.WriteLine($"Opción no válida. Introduzca una opción de {(int)OpcionMenu.Tirar} a {(int)OpcionMenu.Salir}.");
                break;
        }

        if (saldo <= 0.0m)
        {
            Console.WriteLine("¡Te has quedado sin saldo! Debes recargar o el juego terminará.");
            if (opcionElegida != OpcionMenu.Gestionar)
                GestionarSaldo(ref saldo);
            if (saldo <= 0.0m)
                opcionElegida = OpcionMenu.Salir;
        }

    } while (opcionElegida != OpcionMenu.Salir);
}

// ==============================================================================
// 6. PROCEDIMIENTO PARA LA TIRADA DE LA TRAGAPERRAS
// ==============================================================================

void TirarTragaperras(ref decimal saldo)
{
    decimal saldoApostado;
    bool isApuestaValida;

    do
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Saldo actual: {saldo}€");
        saldoApostado = LeerDecimal("¿Cuánto saldo desea apostar?: ");

        isApuestaValida = IsSuperiorA(saldoApostado, 0.0m) && (saldoApostado <= saldo) && (saldoApostado >= APUESTA_MINIMA);

        if (!isApuestaValida)
        {
            if (saldoApostado > saldo)
                Console.WriteLine($"Error. El saldo apostado ({saldoApostado}€) no puede ser superior al saldo actual ({saldo}€).");
            else
                Console.WriteLine($"Error. La apuesta mínima es de {APUESTA_MINIMA}€.");
        }
    } while (!isApuestaValida);

    saldo -= saldoApostado;

    // Los tres rodillos viajan como UN dato (struct), no tres ints sueltos
    Tirada tirada = GenerarTirada();
    Console.WriteLine($"La tragaperras muestra: {tirada.Reel1} {tirada.Reel2} {tirada.Reel3}");

    // CalcularPremio responde DOS cosas a la vez (tupla nombrada):
    // qué ha pasado y cuánto se paga. La desestructuramos al recibir.
    var (resultado, premio) = CalcularPremio(tirada, saldoApostado);
    saldo += premio;

    // El mensaje sale aquí (SRP): el cálculo calcula, el llamador informa
    string mensaje = resultado switch
    {
        ResultadoTirada.Jackpot => "¡¡JACKPOT!!",
        ResultadoTirada.TresIguales => "¡VICTORIA! Tres números iguales.",
        ResultadoTirada.DosIguales => "¡SALVADO! Dos números iguales.",
        ResultadoTirada.NingunoIgual => "Mala suerte. Inténtelo de nuevo.",
        _ => "" // red de seguridad
    };

    Console.WriteLine(mensaje);
    Console.WriteLine($"Saldo actual: {saldo}€");
}

// ==============================================================================
// 7. GENERADOR DE TIRADA (SRP: solo saca los números)
// ==============================================================================

// GenerarTirada: los tres rodillos al azar (0-9 cada uno). Usa el ÚNICO
// Random del programa: el azar es un servicio global, no de una función.
Tirada GenerarTirada()
{
    Tirada tirada;
    tirada.Reel1 = rnd.Next(0, 10);
    tirada.Reel2 = rnd.Next(0, 10);
    tirada.Reel3 = rnd.Next(0, 10);
    return tirada;
}

// ==============================================================================
// 8. FUNCIÓN QUE CALCULA EL PREMIO (SRP: calcula, NO imprime)
// ==============================================================================

// CalcularPremio: dado el resultado de la tirada y lo apostado, devuelve
// DOS respuestas juntas como tupla nombrada: el tipo de desenlace (enum)
// y el dinero ganado. Sin out, sin parámetros de más. Si el premio
// depende de reglas de negocio, se toca SOLO aquí.
(ResultadoTirada resultado, decimal premio) CalcularPremio(Tirada tirada, decimal apuesta)
{
    ResultadoTirada resultado;

    if (tirada.Reel1 == JACKPOT_NUM && tirada.Reel2 == JACKPOT_NUM && tirada.Reel3 == JACKPOT_NUM)
    {
        resultado = ResultadoTirada.Jackpot;
    }
    else if (tirada.Reel1 == tirada.Reel2 && tirada.Reel2 == tirada.Reel3)
    {
        resultado = ResultadoTirada.TresIguales;
    }
    else if (tirada.Reel1 == tirada.Reel2 || tirada.Reel2 == tirada.Reel3 || tirada.Reel1 == tirada.Reel3)
    {
        resultado = ResultadoTirada.DosIguales;
    }
    else
    {
        resultado = ResultadoTirada.NingunoIgual;
    }

    // La tabla de premios, como switch expression sobre el enum
    decimal premio = resultado switch
    {
        ResultadoTirada.Jackpot => PREMIO_JACKPOT_MULT * apuesta,
        ResultadoTirada.TresIguales => PREMIO_TRES_IGUALES_MULT * apuesta,
        ResultadoTirada.DosIguales => PREMIO_DOS_IGUALES_MULT * apuesta,
        ResultadoTirada.NingunoIgual => 0.0m,
        _ => 0.0m // red de seguridad
    };

    return (resultado, premio);
}

// ==============================================================================
// 9. PROCEDIMIENTOS MODULARES PARA GESTIONAR SALDO (SRP)
// ==============================================================================

void AnadirSaldo(ref decimal saldo)
{
    Console.WriteLine("----------------------");
    decimal saldoIntroducido = LeerDecimal("Saldo a añadir: ");

    if (!IsSuperiorA(saldoIntroducido, 0.0m))
    {
        Console.WriteLine("Error. La cantidad a añadir debe ser positiva.");
    }
    else
    {
        saldo += saldoIntroducido;
        Console.WriteLine($"Saldo añadido. Saldo actual: {saldo}€");
    }
}

void RetirarSaldo(ref decimal saldo)
{
    Console.WriteLine("----------------------");
    decimal saldoIntroducido = LeerDecimal("Saldo a retirar: ");

    if (!IsSuperiorA(saldoIntroducido, 0.0m))
    {
        Console.WriteLine("Error. La cantidad a retirar debe ser positiva.");
    }
    else if (saldoIntroducido > saldo)
    {
        Console.WriteLine($"Error. No puedes retirar más de lo que tienes. (Máximo: {saldo}€)");
    }
    else
    {
        saldo -= saldoIntroducido;
        Console.WriteLine($"Saldo retirado. Saldo actual: {saldo}€");
    }
}

// ==============================================================================
// 10. PROCEDIMIENTO GESTOR DE SALDO (Delega la acción)
// ==============================================================================

void GestionarSaldo(ref decimal saldo)
{
    Console.WriteLine("----------------------");
    Console.WriteLine($"Gestión de Saldo. Saldo actual = {saldo}€");
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine($"{(int)OpcionGestion.Anadir}.- Añadir saldo.");
    Console.WriteLine($"{(int)OpcionGestion.Retirar}.- Retirar saldo.");
    Console.WriteLine($"{(int)OpcionGestion.Volver}.- Volver al menú.");

    // Mismo truco que en el menú principal: número → enum
    OpcionGestion opcionElegida = (OpcionGestion)LeerEntero("Opción elegida = ");

    switch (opcionElegida)
    {
        case OpcionGestion.Anadir:
            AnadirSaldo(ref saldo);
            break;
        case OpcionGestion.Retirar:
            RetirarSaldo(ref saldo);
            break;
        case OpcionGestion.Volver:
            Console.WriteLine("Volviendo al menú principal...");
            break;
        default:
            Console.WriteLine("Error. Opción no válida");
            break;
    }
}

// ==============================================================================
// 11. PROCEDIMIENTO PARA IMPRIMIR LA LISTA DE PREMIOS (SRP)
// ==============================================================================

void ImprimirListaPremios()
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Posibles Premios:");
    Console.WriteLine($"- JACKPOT ({JACKPOT_NUM} {JACKPOT_NUM} {JACKPOT_NUM}): Ganas x{PREMIO_JACKPOT_MULT} veces lo apostado.");
    Console.WriteLine($"- VICTORIA (3 Iguales, no {JACKPOT_NUM}): Ganas x{PREMIO_TRES_IGUALES_MULT} veces lo apostado.");
    Console.WriteLine($"- SALVADO (2 Iguales): Ganas x{PREMIO_DOS_IGUALES_MULT} veces lo apostado.");
    Console.WriteLine("- MALA SUERTE (Ninguno igual): Pierdes el dinero apostado.");
}

// ==============================================================================
// 12. TIPOS DEL JUEGO
// (En archivos con Top-Level Statements, los tipos se declaran DESPUÉS
// de todo el código — repaso de UD01)
// ==============================================================================

// Opciones del menú principal: los valores SON las teclas que teclea el
// usuario (1-4), y los nombres hacen el switch legible sin recordar números.
enum OpcionMenu
{
    Tirar = 1,
    Gestionar = 2,
    Premios = 3,
    Salir = 4
}

// Opciones del submenú de gestión de saldo (1-3).
enum OpcionGestion
{
    Anadir = 1,
    Retirar = 2,
    Volver = 3
}

// Los cuatro desenlaces posibles de una tirada: un conjunto CERRADO con
// nombres. El enum se usa en la tupla de CalcularPremio y en el switch
// de mensajes — añadir un premio nuevo es añadir un miembro y mirar los
// dos switches (el compilador avisa de los que falten en los brazos).
enum ResultadoTirada
{
    Jackpot,     // tres 7
    TresIguales, // tres iguales que no son 7
    DosIguales,  // dos iguales: te salvas
    NingunoIgual // mala suerte
}

// Los tres rodillos de la máquina, viajando JUNTOS como un solo valor.
// Es un STRUCT (tipo de valor, repaso UD01): al pasarlo como parámetro
// se COPIA igual que un int — una tirada es un dato que solo se lee,
// nadie debe "mocinarla" por el camino.
struct Tirada
{
    public int Reel1;
    public int Reel2;
    public int Reel3;
}
