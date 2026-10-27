// ============================================================================
// Reloj digital (modular) — UD02/ejemplos
//
// ENUNCIADO: UD02/practicas/05-preparacion-examen.md — Ejercicio 3.
// Un reloj digital que pide formato (24 h o AM/PM), hora de inicio y hora
// final (todas las entradas validadas como enteros en rango), comprueba
// que la final no es inferior a la inicial —comparando justamente aunque
// los formatos difieran—, espera un ENTER y luego "tickea" segundo a
// segundo hasta la hora final, mostrando FIN al llegar.
//
// Conceptos UD02/UD01 que ilustra:
//   - Simulación con do-while + Thread.Sleep (un tic = 1 s REAL) — 2.9
//   - Entradas robustas: TryParse + validación de rango — punto 4
//   - enum con valores (FormatoReloj, Periodo) — repaso UD01
//   - struct como parámetro y return (HoraReloj): tipo de valor que se
//     COPIA, igual que un int — 3.3 (tuplas, enums y structs)
//   - Escala común para comparar: convertir todo a minutos — 3.1
//   - SRP: formato, pedir hora, periodo, formatear y simular, cada uno
//     en su función — 3.1
//   - switch expression para pintar según el formato — 2.3 E
//   - Parámetro opcional con valor por defecto (ticMs) — 3.5
//   - La línea del reloj se redibuja en el mismo sitio con "\r"
//     (retorno de carro). Con varias líneas se usaría
//     Console.SetCursorPosition(x, y).
//
// Ejecutar: dotnet run 08-modular-reloj-digital.cs
// ============================================================================
using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8; // Para emojis

// ------------------------------------------------------------
// CONSTANTES DEL RELOJ (nada de números sueltos por el código)
// ------------------------------------------------------------
// Rangos válidos de entrada según el formato
const int HORA_MINIMA_24H = 0;
const int HORA_MAXIMA_24H = 23;
const int HORA_MINIMA_AMPM = 1;
const int HORA_MAXIMA_AMPM = 12;
const int MINUTO_MINIMO = 0;
const int MINUTO_MAXIMO = 59;

// Conversiones de tiempo
const int MINUTOS_POR_HORA = 60;
const int SEGUNDOS_POR_MINUTO = 60;
const int MILISEGUNDOS_POR_SEGUNDO = 1000; // Thread.Sleep espera en milisegundos

// ------------------------------------------------------------
// PROGRAMA PRINCIPAL
// ------------------------------------------------------------

WriteLine("🕐 Reloj digital — simulación del paso del tiempo");

// 1) ¿En qué formato vive el reloj?
FormatoReloj formato = PedirFormato();

// 2) Horas de inicio y final (cada una validada al leerla)
HoraReloj inicio = PedirHora("inicio", formato);
HoraReloj fin = PedirHora("final", formato);

// 3) Las comparamos en una escala común: minutos desde medianoche.
//    Así el formato en que se escribieron deja de importar.
int inicioMinutos = AMinutosDesdeMedianoche(inicio, formato);
int finMinutos = AMinutosDesdeMedianoche(fin, formato);

while (finMinutos < inicioMinutos)
{
    WriteLine("❌ La hora final no puede ser inferior a la de inicio. Vuelve a introducirla.");
    fin = PedirHora("final", formato);
    finMinutos = AMinutosDesdeMedianoche(fin, formato);
}

// 4) Todo validado: el usuario da permiso y el reloj arranca
WriteLine($"✅ Desde {FormatearReloj(inicioMinutos * SEGUNDOS_POR_MINUTO, formato)} "
        + $"hasta {FormatearReloj(finMinutos * SEGUNDOS_POR_MINUTO, formato)}.");
Write("⏰ Pulsa ENTER para arrancar el reloj... ");
ReadLine();

// 5) La simulación (ticMs se omite: manda el valor por defecto de 1 s)
SimularReloj(inicioMinutos, finMinutos, formato);
// Para una demo rápida: SimularReloj(inicioMinutos, finMinutos, formato, ticMs: 10);

// ------------------------------------------------------------
// PEDIDAS AL USUARIO (siempre con validación)
// ------------------------------------------------------------

// PedirFormato: pregunta si el reloj vive en 24 h o en AM/PM.
// LeerEnteroRango garantiza que la opción es 1 o 2, así que el
// casting a enum siempre cae en un valor válido.
FormatoReloj PedirFormato()
{
    WriteLine("------------------------");
    WriteLine("Formato del reloj:");
    WriteLine($"{(int)FormatoReloj.VeinticuatroHoras}.- 24 horas (00 - 23)");
    WriteLine($"{(int)FormatoReloj.AmPm}.- AM/PM (1 - 12)");

    int opcion = LeerEnteroRango("Elige formato: ",
                                 (int)FormatoReloj.VeinticuatroHoras,
                                 (int)FormatoReloj.AmPm);

    return (FormatoReloj)opcion; // el enum es un número por debajo
}

// PedirHora: pide hora y minuto validados según el formato. En AM/PM
// pregunta además el periodo. Devuelve el momento tal cual se escribió:
// la conversión a una escala común la hace quien la necesita.
HoraReloj PedirHora(string momento, FormatoReloj formato)
{
    HoraReloj hora;

    if (formato == FormatoReloj.VeinticuatroHoras)
    {
        hora.Hora = LeerEnteroRango($"Hora de {momento} (0-23): ", HORA_MINIMA_24H, HORA_MAXIMA_24H);
        hora.Minuto = LeerEnteroRango($"Minuto de {momento} (0-59): ", MINUTO_MINIMO, MINUTO_MAXIMO);
        hora.Periodo = Periodo.AM; // en 24 h el periodo no se usa
    }
    else
    {
        // Formato AM/PM: la hora va de 1 a 12 y el periodo hace el resto
        hora.Hora = LeerEnteroRango($"Hora de {momento} (1-12): ", HORA_MINIMA_AMPM, HORA_MAXIMA_AMPM);
        hora.Minuto = LeerEnteroRango($"Minuto de {momento} (0-59): ", MINUTO_MINIMO, MINUTO_MAXIMO);
        hora.Periodo = PedirPeriodo();
    }

    return hora;
}

// PedirPeriodo: AM o PM. Repite mientras no sea una de las dos letras
// (con mayúscula o minúscula).
Periodo PedirPeriodo()
{
    Periodo periodo = Periodo.AM; // valor de arranque, se sobrescribe
    bool valido = false;

    do
    {
        Write("¿Es AM (A) o PM (P)? ");
        string? entrada = ReadLine();

        if (entrada == "A" || entrada == "a")
        {
            periodo = Periodo.AM;
            valido = true;
        }
        else if (entrada == "P" || entrada == "p")
        {
            periodo = Periodo.PM;
            valido = true;
        }
        else
        {
            WriteLine("❌ Debe escribir A (AM) o P (PM).");
        }

    } while (!valido);

    return periodo;
}

// LeerEnteroRango: lee un número entero repitiendo mientras el texto no
// sea un número válido (TryParse) O se salga del rango permitido. Una
// "a" no es una hora, y las 25 horas no existen.
int LeerEnteroRango(string mensaje, int minimo, int maximo)
{
    int valor;
    bool valido;

    do
    {
        Write(mensaje);
        valido = int.TryParse(ReadLine(), out valor) && valor >= minimo && valor <= maximo;

        if (!valido)
        {
            WriteLine($"❌ Valor no válido: debe ser un número entero entre {minimo} y {maximo}.");
        }

    } while (!valido);

    return valor;
}

// ------------------------------------------------------------
// EL TIEMPO: ESCALA COMÚN Y FORMATEO
// ------------------------------------------------------------

// AMinutosDesdeMedianoche: convierte una hora leída a MINUTOS desde
// medianoche en formato 24 h. Es la escala común que permite comparar
// horas escritas en formatos distintos (11:59 PM = 1439, y 12:30 AM = 30:
// el AM/PM es "por dónde vas contando", no un número mayor o menor).
int AMinutosDesdeMedianoche(HoraReloj h, FormatoReloj formato)
{
    if (formato == FormatoReloj.VeinticuatroHoras)
    {
        return h.Hora * MINUTOS_POR_HORA + h.Minuto;
    }

    // Reglas del reloj de 12 horas: 12 AM = medianoche (00:00),
    // 12 PM = mediodía (12:00); el resto, hora % 12 más el desfase.
    int hora24 = h.Hora % 12; // 12 → 0; 1..11 se quedan igual

    if (h.Periodo == Periodo.PM)
    {
        hora24 += 12;
    }

    return hora24 * MINUTOS_POR_HORA + h.Minuto;
}

// FormatearReloj: convierte unos segundos desde medianoche al texto del
// reloj en el formato elegido. El switch expression recorre los casos
// del enum de formato (2.3 E).
string FormatearReloj(int segundosTotales, FormatoReloj formato)
{
    int minutos = segundosTotales / SEGUNDOS_POR_MINUTO;
    int segundos = segundosTotales % SEGUNDOS_POR_MINUTO;
    int hora24 = minutos / MINUTOS_POR_HORA;
    int minuto = minutos % MINUTOS_POR_HORA;

    // Traducción AM/PM (se calcula por si el formato la pide)
    int hora12 = hora24 % 12 == 0 ? 12 : hora24 % 12; // 0 y 12 se muestran como 12
    string textoPeriodo = hora24 < 12 ? "AM" : "PM";

    return formato switch
    {
        FormatoReloj.VeinticuatroHoras => $"{hora24:D2}:{minuto:D2}:{segundos:D2}",
        FormatoReloj.AmPm => $"{hora12:D2}:{minuto:D2}:{segundos:D2} {textoPeriodo}",
        _ => "" // red de seguridad por si llegara un valor imposible
    };
}

// ------------------------------------------------------------
// LA SIMULACIÓN
// ------------------------------------------------------------

// SimularReloj: el corazón del ejercicio. El reloj avanza segundo a
// segundo (cada tic espera un segundo REAL con Thread.Sleep) desde la
// hora inicial hasta la final, y redibuja la línea SIEMPRE en el mismo
// sitio: cada Write empieza con "\r" (retorno de carro), que devuelve el
// cursor al principio de la línea y la sobrescribe. Para varias líneas se
// usaría Console.SetCursorPosition(x, y). Al llegar a la hora final: FIN.
// ticMs es OPCIONAL: por defecto, un tic dura 1 s real (el reloj "de
// verdad"); en una demo o una prueba puedes acelerarlo —p. ej. ticMs: 10—
// sin cambiar el resto del programa (3.5 Parámetros por defecto).
void SimularReloj(int inicioMinutos, int finMinutos, FormatoReloj formato,
                  int ticMs = MILISEGUNDOS_POR_SEGUNDO)
{
    if (!IsOutputRedirected)
    {
        Clear(); // solo tiene sentido si hay consola real delante
    }

    string nombreFormato = formato == FormatoReloj.VeinticuatroHoras ? "24 h" : "AM/PM";

    WriteLine($"🕐 Reloj digital — formato {nombreFormato}");
    WriteLine($"   De {FormatearReloj(inicioMinutos * SEGUNDOS_POR_MINUTO, formato)} "
            + $"a {FormatearReloj(finMinutos * SEGUNDOS_POR_MINUTO, formato)}");
    Write("   ");

    int segundosActuales = inicioMinutos * SEGUNDOS_POR_MINUTO;
    int segundosFinales = finMinutos * SEGUNDOS_POR_MINUTO;

    do
    {
        // \r = retorno de carro: el cursor vuelve al principio y la
        // sobrescribe — el reloj queda fijo en su posición
        Write($"\r{FormatearReloj(segundosActuales, formato)}   ");

        Thread.Sleep(ticMs); // un tic = 1 s REAL (o lo que pase ticMs)

        segundosActuales++;

    } while (segundosActuales < segundosFinales);

    // Llegamos a la hora final: el reloj se queda en el sitio y dice FIN
    Write($"\r{FormatearReloj(segundosFinales, formato)}  ⏰ ¡FIN!                         ");
    WriteLine();
    WriteLine("🏁 Simulación terminada.");
}

// ------------------------------------------------------------
// TIPOS DEL RELOJ
// (En archivos con Top-Level Statements, los tipos se declaran
// DESPUÉS de todo el código — repaso de UD01)
// ------------------------------------------------------------

// El formato decide cómo se pide y cómo se pinta la hora.
// Los valores son las teclas del menú (1 y 2).
enum FormatoReloj
{
    VeinticuatroHoras = 1,
    AmPm = 2
}

// El periodo solo tiene significado en el formato AM/PM.
enum Periodo
{
    AM,
    PM
}

// Un momento del día tal y como lo escribe el usuario.
// Es un STRUCT (repaso de UD01): tipo de valor, así que al pasarlo
// como parámetro se COPIA igual que un int — nadie lo modifica por el
// camino. Cada campo va documentado con su rango.
struct HoraReloj
{
    public int Hora;        // 0-23 en formato 24 h; 1-12 en AM/PM
    public int Minuto;      // 0-59 siempre
    public Periodo Periodo; // solo con significado en AM/PM
}
