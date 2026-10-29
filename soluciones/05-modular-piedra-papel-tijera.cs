// ============================================================================
// Piedra, Papel o Tijera (modular) — UD02/ejemplos
//
// ENUNCIADO: UD02/practicas/05-preparacion-examen.md — Ejercicio 2
// ("La batalla de Piedra, Papel o Tijera"). Torneo con menú, combates
// normales al mejor de 3, un Jefe Final que HACE TRAMPA (2 de cada 3
// rondas) al mejor de 5, acceso exigente (5 victorias) y castigo si te
// vence (se queda con 2 de tus victorias).
//
// Conceptos UD02/UD01 que ilustra:
//   - enum con valores numerados (Piedra = 1, ...) — repaso de UD01
//   - ref: marcadores y victorias viajan por referencia — 3.3 B
//   - SRP: una función, una sola responsabilidad — 3.1
//   - Early Return: la puerta del jefe y la ronda inválida — 3.2
//   - do-while: menú, partida y batalla final — 2.4 B
//   - switch (menú) y switch expression (nombres de figura) — 2.3 D/E
//   - Entradas robustas con TryParse — punto 4
//   - UN SOLO Random para todo el programa — 2.8
//   - Estructura "dueño del combate + una ronda" (como Simulacion y
//     CicloDeSimulacion del simulador de vuelo)
//
// Ejecutar: dotnet run 05-modular-piedra-papel-tijera.cs
// ============================================================================
using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8; // Para emojis

// ------------------------------------------------------------
// CONSTANTES DEL TORNEO (nada de números sueltos por el código)
// ------------------------------------------------------------

// Opciones del menú principal
const int OPCION_RONDA = 1;
const int OPCION_JEFE = 2;
const int OPCION_PROBABILIDADES = 3;
const int OPCION_SALIR = 4;

// Reglas de combate
const int RONDAS_PARA_GANAR_PARTIDA = 2;    // Best of 3: el primero en 2
const int RONDAS_PARA_GANAR_JEFE = 3;       // Best of 5: el primero en 3
const int VICTORIAS_DE_ACCESO_AL_JEFE = 5;  // Experiencia mínima para retar al jefe
const int CASTIGO_POR_PERDER_AL_JEFE = 2;   // Victorias que se queda el jefe si te vence

// Resultados posibles de una ronda
const int JUGADOR_GANA = 1;
const int ORDENADOR_GANA = -1;
const int EMPATE = 0;

Random rnd = new(); // Un SOLO generador de azar para todo el programa (2.8)

// ------------------------------------------------------------
// PROGRAMA PRINCIPAL
// ------------------------------------------------------------

// El nombre llega ya validado (LeerNombre no suelta sin uno bueno)
string participante = LeerNombre();
WriteLine($"🎖️ Un placer, {participante}. ¡Bienvenido al torneo!");

EjecutarMenu(participante);

WriteLine("Fin del programa.");

// ------------------------------------------------------------
// ENTRADAS (teclado siempre tratado con mimo)
// ------------------------------------------------------------

// LeerNombre: pide el nombre del participante. ReadLine() puede devolver
// null (entrada vacía o cerrada) y un nombre de solo espacios no sirve
// para nada, así que repetimos hasta tener un nombre de verdad.
string LeerNombre()
{
    string? nombre;

    do
    {
        Write("👤 Nombre del participante: ");
        nombre = ReadLine(); // ¡cuidado! puede ser null

        if (nombre is null || string.IsNullOrWhiteSpace(nombre))
        {
            WriteLine("❌ Ese nombre no sirve, héroe. Inténtalo de nuevo.");
        }

    } while (nombre is null || string.IsNullOrWhiteSpace(nombre));

    return nombre; // el compilador ya sabe que aquí no es null
}

// LeerEntero: lee un número entero del teclado repitiendo mientras el
// texto no sea un número válido (TryParse en lugar de Parse: prevención,
// no reacción — punto 4).
int LeerEntero(string mensaje)
{
    int valorLeido = 0;
    bool isFormatoCorrecto = false;

    do
    {
        Write(mensaje);

        if (int.TryParse(ReadLine(), out int valor))
        {
            valorLeido = valor;
            isFormatoCorrecto = true;
        }
        else
        {
            WriteLine("❌ Error de formato. Debe introducir un número entero.");
        }

    } while (!isFormatoCorrecto);

    return valorLeido;
}

// ------------------------------------------------------------
// EL TORNEO (menú principal)
// ------------------------------------------------------------

// EjecutarMenu: mantiene vivo el torneo hasta que el participante elige
// salir. Las victorias totales nacen aquí y viajan por ref a los
// submenús: son el "historial" del jugador.
void EjecutarMenu(string participante)
{
    int victorias = 0; // acumulador que viaja por referencia
    int opcion;

    do
    {
        MostrarMenu(participante);
        opcion = LeerEntero("🎮 Opción elegida: ");

        switch (opcion)
        {
            case OPCION_RONDA:
                SimularPartida(participante, ref victorias);
                break;
            case OPCION_JEFE:
                SimularJefe(participante, ref victorias);
                break;
            case OPCION_PROBABILIDADES:
                MostrarProbabilidades(victorias);
                break;
            case OPCION_SALIR:
                WriteLine($"🚪 Ha sido un placer, {participante}. ¡Vuelve pronto!");
                break;
            default:
                WriteLine("❌ Opción no válida. Elija un camino del 1 al 4.");
                break;
        }

    } while (opcion != OPCION_SALIR); // el torneo acaba solo si él se va
}

// MostrarMenu: pinta los cuatro caminos del torneo.
void MostrarMenu(string participante)
{
    WriteLine("------------------------");
    WriteLine($"Elige tu camino, {participante}:");
    WriteLine($"{OPCION_RONDA}.- ⚔️  Combate normal.");
    WriteLine($"{OPCION_JEFE}.- 👹 Retar al Jefe Final.");
    WriteLine($"{OPCION_PROBABILIDADES}.- 📊 Ver probabilidades.");
    WriteLine($"{OPCION_SALIR}.- 🚪 Retirarse con dignidad.");
}

// MostrarOpcionesFiguras: las tres figuras del juego ancestral.
void MostrarOpcionesFiguras()
{
    WriteLine("-----------");
    WriteLine($"{(int)Figura.Piedra} → 🪨 Piedra");
    WriteLine($"{(int)Figura.Papel} → 📄 Papel");
    WriteLine($"{(int)Figura.Tijera} → ✂️ Tijera");
}

// ------------------------------------------------------------
// COMBATES
// ------------------------------------------------------------

// SimularPartida: dueña del combate normal. Un do-while que juega rondas
// (CicloDeRonda) hasta que alguien se lleva RONDAS_PARA_GANAR_PARTIDA
// (best of 3). Si gana el jugador, su historial suma una victoria.
void SimularPartida(string participante, ref int victorias)
{
    int puntosJugador = 0;
    int puntosOrdenador = 0;

    WriteLine("------------------");
    WriteLine("⚔️ Bienvenido a la zona de juego...");
    WriteLine("¡Comienza la partida!");

    do
    {
        CicloDeRonda(participante, esJefe: false, ref puntosJugador, ref puntosOrdenador);

    } while (puntosJugador < RONDAS_PARA_GANAR_PARTIDA
          && puntosOrdenador < RONDAS_PARA_GANAR_PARTIDA);

    // Veredicto del duelo
    if (puntosJugador > puntosOrdenador)
    {
        victorias++;
        WriteLine($"🏆 ENHORABUENA {participante}: ¡Has ganado el duelo! +1 victoria");
    }
    else
    {
        WriteLine($"💀 Mala suerte, {participante}... ¡Más suerte la próxima vez!");
    }

    WriteLine($"🎖️ Victorias totales: {victorias}");
}

// SimularJefe: dueña de la batalla final. Early Return: sin 5 victorias
// ni te miran. Con acceso abierto, best of 5 contra un jefe que HACE
// TRAMPA; si te vence, se queda con CASTIGO_POR_PERDER_AL_JEFE de tus
// victorias.
void SimularJefe(string participante, ref int victorias)
{
    // Puerta de acceso: el jefe exige experiencia mínima
    if (victorias < VICTORIAS_DE_ACCESO_AL_JEFE)
    {
        WriteLine("👹 Aún no estás preparado. Sigue entrenando hasta obtener "
                + $"{VICTORIAS_DE_ACCESO_AL_JEFE} victorias.");
        WriteLine("Mucha suerte... la necesitarás.");
        return; // Early Return: ni se plantea la batalla
    }

    int puntosJugador = 0;
    int puntosOrdenador = 0;

    WriteLine("------------------");
    WriteLine($"👹 Bienvenido a la Batalla Final, {participante}. ¡Esto no va a ser fácil!");

    do
    {
        CicloDeRonda(participante, esJefe: true, ref puntosJugador, ref puntosOrdenador);

    } while (puntosJugador < RONDAS_PARA_GANAR_JEFE
          && puntosOrdenador < RONDAS_PARA_GANAR_JEFE);

    // Veredicto de la batalla final
    if (puntosJugador > puntosOrdenador)
    {
        WriteLine("👑 ¡HAS VENCIDO AL JEFE! Toma este premio, campeón.");
    }
    else
    {
        victorias -= CASTIGO_POR_PERDER_AL_JEFE; // el jefe se queda con 2 victorias
        WriteLine($"⛓️ ¡PERDISTE! El jefe se ha quedado con "
                + $"{CASTIGO_POR_PERDER_AL_JEFE} de tus victorias.");
    }

    WriteLine($"🎖️ Victorias en el historial: {victorias}");
}

// CicloDeRonda: UNA ronda del combate — lo mismo que hace
// CicloDeSimulacion en el avión, pero con figuras. Muestra las figuras,
// lee la del jugador (validando el rango), consigue la del rival (justa
// o tramposa según esJefe), decide el resultado y actualiza el marcador
// que viaja por referencia. Si la elección no es 1, 2 o 3, la ronda no
// cuenta y no se toca el marcador (Early Return).
void CicloDeRonda(string participante, bool esJefe, ref int puntosJugador, ref int puntosOrdenador)
{
    MostrarOpcionesFiguras();
    int eleccion = LeerEntero("🗡️ Opción elegida: ");

    if (eleccion < (int)Figura.Piedra || eleccion > (int)Figura.Tijera)
    {
        WriteLine($"❌ {participante}, eso no es una figura: usa 1, 2 o 3.");
        return; // Early Return: la ronda se anula, el marcador no cambia
    }

    // El enum es un número por debajo: convertimos la elección a Figura
    Figura figuraJugador = (Figura)eleccion;

    // El rival: a la justa (aleatorio) o con trampa de jefe
    Figura figuraRival = esJefe
        ? GenerarRespuestaJefe(figuraJugador)
        : GenerarFiguraOrdenador();

    int resultado = ObtenerResultadoRonda(figuraJugador, figuraRival);
    ActualizarMarcador(resultado, ref puntosJugador, ref puntosOrdenador);
    MostrarMarcador(figuraJugador, figuraRival, puntosJugador, puntosOrdenador, resultado, esJefe);
}

// ------------------------------------------------------------
// EL AZAR Y LA TRAMPA DEL JEFE
// ------------------------------------------------------------

// GenerarFiguraOrdenador: el rival normal juega A LA JUSTA: cualquier
// figura con la misma probabilidad (1 a 3 al azar).
Figura GenerarFiguraOrdenador()
{
    int tirada = rnd.Next((int)Figura.Piedra, (int)Figura.Tijera + 1); // el máx no se incluye
    return (Figura)tirada; // conversión número → enum
}

// GenerarRespuestaJefe: la trampa. El jefe mira tu figura y decide:
// 2 de cada 3 veces saca la que te gana; si no, la que pierde contra ti
// (nunca la misma: contra ella sería empate y al jefe no le gusta empatar).
Figura GenerarRespuestaJefe(Figura figuraJugador)
{
    int tirada = rnd.Next(1, 4); // 1, 2 o 3 al azar

    // 1 o 2 (2 de cada 3) → trampa pura; 3 → piedad
    return tirada <= 2 ? QueLeGana(figuraJugador) : QueLePierde(figuraJugador);
}

// QueLeGana: devuelve la figura que gana a la indicada. Truco del círculo:
// en Piedra(1) → Papel(2) → Tijera(3) → Piedra..., la siguiente en el
// ciclo siempre gana: (figura % 3) + 1.
Figura QueLeGana(Figura figura)
{
    return (Figura)(((int)figura % 3) + 1);
}

// QueLePierde: la figura que PIERDE contra la indicada. En el mismo
// círculo, dos pasos por delante ((figura + 1) % 3 + 1) es la que te
// tumba: piedra rompe tijera, tijera corta papel, papel envuelve piedra.
Figura QueLePierde(Figura figura)
{
    return (Figura)((((int)figura + 1) % 3) + 1);
}

// ------------------------------------------------------------
// REGLAS DEL JUEGO
// ------------------------------------------------------------

// ObtenerResultadoRonda: la vieja ley. Mismo → EMPATE; si tu figura es
// la que le gana a la del rival → JUGADOR_GANA; en otro caso → ORDENADOR_GANA.
int ObtenerResultadoRonda(Figura figuraJugador, Figura figuraRival)
{
    if (figuraJugador == figuraRival)
    {
        return EMPATE;
    }

    if (figuraJugador == QueLeGana(figuraRival)) // tu figura es la suya...
    {
        return JUGADOR_GANA;                      // ...de al lado: le gana
    }

    return ORDENADOR_GANA;
}

// ActualizarMarcador: aplica el resultado de la ronda. Los puntos viajan
// por referencia: esta función los modifica para quien la llama.
void ActualizarMarcador(int resultado, ref int puntosJugador, ref int puntosOrdenador)
{
    if (resultado == JUGADOR_GANA)
    {
        puntosJugador++;
    }
    else if (resultado == ORDENADOR_GANA)
    {
        puntosOrdenador++;
    }

    // Un EMPATE no suma puntos a nadie: las figuras vuelven a la mesa
}

// MostrarMarcador: informa de lo ocurrido en la ronda. Los nombres de las
// figuras salen del propio enum (NombreFigura) y el resultado se traduce
// con ternarios: uno por cada desenlace posible.
void MostrarMarcador(Figura figuraJugador, Figura figuraRival,
                     int puntosJugador, int puntosOrdenador, int resultado, bool esJefe)
{
    string rival = esJefe ? "👹 El jefe" : "🤖 El ordenador";

    string textoResultado = resultado == JUGADOR_GANA   ? "🏆 ¡Ganaste la ronda!"
                          : resultado == ORDENADOR_GANA ? "💀 ¡Perdiste la ronda!"
                          : "🤝 ¡Empate! Nadie suma.";

    WriteLine($"Sacaste {NombreFigura(figuraJugador)}...");
    WriteLine($"{rival} saca... {NombreFigura(figuraRival)}!");
    WriteLine(textoResultado);
    WriteLine($"Marcador -> Tú: {puntosJugador} | Rival: {puntosOrdenador}");
}

// NombreFigura: traduce el enum a texto (con su emoji). El switch
// expression (2.3 E) recorre los casos del enum; el guion bajo es la
// red de seguridad por si llegara un valor imposible.
string NombreFigura(Figura figura)
{
    return figura switch
    {
        Figura.Piedra => "🪨 PIEDRA",
        Figura.Papel => "📄 PAPEL",
        Figura.Tijera => "✂️ TIJERA",
        _ => "❓ DESCONOCIDA"
    };
}

// ------------------------------------------------------------
// INFORMACIÓN PARA EL PÚBLICO
// ------------------------------------------------------------

// MostrarProbabilidades: informa de las esperanzas del jugador. Las del
// jefe solo se cuentan a quien ya tiene experiencia suficiente.
void MostrarProbabilidades(int victorias)
{
    WriteLine("------------------------");
    WriteLine("📊 PROBABILIDADES - COMBATE NORMAL");
    WriteLine("  🏆 Victoria: 33%   🤝 Empate: 33%   💀 Derrota: 33%");
    WriteLine("------------------------");

    if (victorias < VICTORIAS_DE_ACCESO_AL_JEFE)
    {
        WriteLine("👹 Las del Jefe... aún no estás listo. Vuelve con "
                 + $"{VICTORIAS_DE_ACCESO_AL_JEFE} victorias.");
        return; // Early Return: la info del jefe es para veteranos
    }

    WriteLine("📊 PROBABILIDADES - JEFE FINAL");
    WriteLine("  🏆 Victoria: ~33%   🤝 Empate: poco probable   💀 Derrota: ~66%");
    WriteLine("  (¿Te lo esperabas? El jefe hace trampa... 😈)");
}

// ------------------------------------------------------------
// LAS TRES FIGURAS DEL TORNEO
// ------------------------------------------------------------

// El enum es un número por debajo: por eso puede llevar valores (UD01).
// Piedra = 1, Papel = 2 y Tijera = 3 son exactamente las teclas que
// teclea el jugador, y el truco del círculo (QueLeGana/QueLePierde)
// funciona aritméticamente sobre esos valores.
enum Figura
{
    Piedra = 1,
    Papel = 2,
    Tijera = 3
}
