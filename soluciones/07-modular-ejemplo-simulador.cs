// ============================================================================
// Simulador de vuelo (piloto automático) — UD02/ejemplos
//
// ENUNCIADO: ver UD02/practicas/05-preparacion-examen.md — Ejercicio 1.
// Simular el funcionamiento de un piloto automático durante 5 minutos
// usando programación estructurada y modular.
//   - Altitud y velocidad iniciales: 1000.0 m y 800.0 km/h (constantes
//     conocidas y propias del sistema).
//   - Los objetivos se piden con leerParametro: altitud dentro del ±25%
//     de la inicial y velocidad dentro del ±15%. Se informa de cuántos
//     intentos hizo falta; si un parámetro supera los 10 intentos, se
//     sale del piloto automático (bandera de control).
//   - La simulación dura 5 minutos, comprobando los parámetros cada 2 s.
//   - En cada ciclo se comprueba el fallo (SystemException si el factor
//     aleatorio < 0.1), se leen los sensores con desviación aleatoria
//     (±2.0 m / ±2.0 km/h) y se rectifica altitud y velocidad hacia el
//     objetivo con los módulos. El fallo provoca la vuelta al control
//     manual informando del error.
//
// Conceptos UD02 que ilustra:
//   - Función con valor de retorno vs. procedimiento con ref — 3.3 A/B
//   - Parámetros de salida (out) en leerParametro — 3.3 C
//   - Excepción SystemException y try-catch (vuelta a control manual) — 4
//   - Bucle do-while de simulación con banderas — 2.5 A y 2.9
//   - SRP: el algoritmo en Simulacion (try-catch + do-while) y
//     CicloDeSimulacion (un ciclo) — 3.1
//   - Sensores SIMÉTRICOS: altitud y velocidad hacen lo mismo (±2 sobre
//     su valor); cambia solo el mecanismo — return (función) vs. ref
//     (procedimiento)
//
// Ejecutar: dotnet run 07-modular-ejemplo-simulador.cs
// ============================================================================
using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8; // Para emojis

// ------------------------------------------------------------
// CONSTANTES DEL SISTEMA (todo lo marcado como "definido en el sistema")
// ------------------------------------------------------------
const double ALTITUD_INICIAL = 1000.0;        // metros
const double VELOCIDAD_INICIAL = 800.0;       // km/h
const double MARGEN_ALTITUD = 0.25;           // objetivo: ±25% sobre la inicial
const double MARGEN_VELOCIDAD = 0.15;         // objetivo: ±15% sobre la inicial
const int DURACION_SIMULACION = 300;          // 5 minutos, en segundos
const int INTERVALO_COMPROBACION = 2;         // comprobar cada 2 segundos
const double DESVIACION_SENSOR = 2.0;         // desviación de hasta ±2.0
const double UMBRAL_FALLO = 0.1;              // fallo si factor aleatorio < 0.1
const int MAX_INTENTOS_PARAMETRO = 10;        // más de 10 intentos => salida

Random rnd = new(); // Un SOLO generador de azar para todo el programa (2.8)

WriteLine("✈️ Piloto automático");

// ------------------------------------------------------------
// FASE 1: objetivos de vuelo (con salida por bandera si se superan los intentos)
// ------------------------------------------------------------
double altitudObjetivo = LeerParametro(
    "Altitud objetivo en metros (±25% de " + ALTITUD_INICIAL + ")",
    ALTITUD_INICIAL * (1 - MARGEN_ALTITUD),
    ALTITUD_INICIAL * (1 + MARGEN_ALTITUD),
    out int intentosAltitud);

WriteLine($"✅ Altitud objetivo fijada en {altitudObjetivo} m tras {intentosAltitud} intento(s).");

double velocidadObjetivo = LeerParametro(
    "Velocidad objetivo en km/h (±15% de " + VELOCIDAD_INICIAL + ")",
    VELOCIDAD_INICIAL * (1 - MARGEN_VELOCIDAD),
    VELOCIDAD_INICIAL * (1 + MARGEN_VELOCIDAD),
    out int intentosVelocidad);

WriteLine($"✅ Velocidad objetivo fijada en {velocidadObjetivo} km/h tras {intentosVelocidad} intento(s).");

// Bandera de control: ¿se han fijado los objetivos dentro del límite de intentos?
bool objetivosValidos = intentosAltitud <= MAX_INTENTOS_PARAMETRO
                     && intentosVelocidad <= MAX_INTENTOS_PARAMETRO;

// FASE 2: simulación. El resultado vuelve como bandera: hubo fallo del sistema.
bool fallo;

if (!objetivosValidos)
{
    // No se pudo fijar un objetivo a tiempo: es un fallo del sistema.
    fallo = true;
    WriteLine();
    WriteLine($"🚨 ¡FALLO CRÍTICO! Se superó el límite de {MAX_INTENTOS_PARAMETRO} intentos tomando un parámetro.");
}
else
{
    fallo = Simulacion(altitudObjetivo, velocidadObjetivo);
}

// Robustez común a ambos fallos (entrada o vuelo): se vuelve al control manual
if (fallo)
{
    WriteLine();
    WriteLine("🛩️ Vuelta a control manual del piloto.");
    WriteLine("🛬 Simulación terminada antes de tiempo por fallo del sistema.");
}
else
{
    WriteLine($"🏁 Simulación completada: {DURACION_SIMULACION} s de piloto automático.");
}


return; // Finalizamos el programa

// ------------------------------------------------------------
// ALGORITMO DE LA SIMULACIÓN (descomposición adicional permitida)
// ------------------------------------------------------------

// Simulacion: ejecuta los 5 minutos de piloto automático comprobando los
// parámetros de vuelo cada 2 segundos. Recibe los objetivos y devuelve
// true si el vuelo terminó por un fallo del sistema (false si agotó los
// 5 minutos). La robustez vive aquí: un SystemException de cualquier
// ciclo no rompe el programa, solo marca el fallo.
bool Simulacion(double altitudObjetivo, double velocidadObjetivo)
{
    double altitud = ALTITUD_INICIAL;
    double velocidad = VELOCIDAD_INICIAL;
    int tiempoTranscurrido = 0;
    bool falloEnVuelo = false;

    WriteLine();
    WriteLine($"Iniciando simulación: {DURACION_SIMULACION} s, comprobación cada {INTERVALO_COMPROBACION} s.");

    try
    {
        // do-while: el piloto automático trabaja al menos un ciclo (2.9)
        do
        {
            // El reloj avanza antes de cada ciclo para informar del tiempo de vuelo
            tiempoTranscurrido += INTERVALO_COMPROBACION;

            CicloDeSimulacion(ref altitud, ref velocidad,
                          altitudObjetivo, velocidadObjetivo, tiempoTranscurrido);

        } while (tiempoTranscurrido < DURACION_SIMULACION);
    }
    catch (SystemException ex)
    {
        falloEnVuelo = true;
        WriteLine();
        WriteLine($"🚨 ¡FALLO CRÍTICO! {ex.Message}");
    }

    return falloEnVuelo;
}

// CicloDeSimulacion: un ciclo del piloto automático — fallo, sensores y
// rectificación. Recibe la altitud y la velocidad por referencia para
// dejar en el origen el resultado del ciclo; el tiempo transcurrido solo
// se usa para informar del estado del vuelo.
void CicloDeSimulacion(ref double altitud, ref double velocidad,
                   double altitudObjetivo, double velocidadObjetivo, int tiempoTranscurrido)
{
    // 1) ¿Fallo crítico del sistema? (puede lanzar SystemException)
    ComprobarFallo();

    // 2) Sensores: los DOS hacen lo mismo — la desviación (hasta ±2.0)
    //    entra en su valor. Cambia SOLO el mecanismo: altitud devuelve la
    //    lectura y el que llama la guarda; velocidad modifica en el origen.
    altitud = Altitud(altitud);     // por valor: la lectura devuelta se guarda
    Velocidad(ref velocidad);       // ref: el módulo actualiza en el origen

    // 3) Rectificación simétrica con los módulos ±1 sobre el valor ya
    //    perturbado: como los dos sensores son iguales, las dos variables
    //    avanzan hacia su objetivo "bailando" de la misma manera
    if (altitud < altitudObjetivo)
        altitud = AumentarAltitud(altitud);
    else if (altitud > altitudObjetivo)
        altitud = DisminuirAltitud(altitud);

    if (velocidad < velocidadObjetivo)
        AumentarVelocidad(ref velocidad);
    else if (velocidad > velocidadObjetivo)
        DisminuirVelocidad(ref velocidad);

    // 4) Estado del ciclo
    WriteLine(
        $"[{tiempoTranscurrido} s] Altitud: {altitud:F1} m (obj. {altitudObjetivo:F1}) | " +
        $"Velocidad: {velocidad:F1} km/h (obj. {velocidadObjetivo:F1})");

    // 5) Espera hasta el siguiente ciclo
    Espera();
}

// ------------------------------------------------------------
// MÓDULOS DEL SISTEMA (cada uno con su contrato)
// ------------------------------------------------------------

// altitud: simula la lectura del sensor. Regla: introduce una desviación
// aleatoria de hasta ±2.0 metros sobre la altitud recibida. Recibe el
// valor actual y devuelve la lectura simulada (por valor: no toca el original).
double Altitud(double valorActual)
{
    double desviacion = (rnd.NextDouble() * 2.0 - 1.0) * DESVIACION_SENSOR;
    return valorActual + desviacion;
}

// velocidad: simula la lectura y actualización del sensor. Regla: aplica
// una desviación aleatoria de hasta ±2.0 km/h al valor de velocidad.
// Recibe el valor por referencia (se modifica en el origen) y no devuelve valor.
void Velocidad(ref double valorActual)
{
    double desviacion = (rnd.NextDouble() * 2.0 - 1.0) * DESVIACION_SENSOR;
    valorActual += desviacion;
}

// aumentarAltitud: incrementa la altitud en 1.0 metro. Recibe el valor
// actual y devuelve el nuevo valor.
double AumentarAltitud(double valorActual)
{
    return valorActual + 1.0;
}

// disminuirAltitud: reduce la altitud en 1.0 metro. Recibe el valor actual
// y devuelve el nuevo valor.
double DisminuirAltitud(double valorActual)
{
    return valorActual - 1.0;
}

// aumentarVelocidad: incrementa la velocidad en 1.0 km/h. Recibe el valor
// actual para ser modificado en el origen y no devuelve valor.
void AumentarVelocidad(ref double valorActual)
{
    valorActual += 1.0;
}

// disminuirVelocidad: reduce la velocidad en 1.0 km/h. Recibe el valor
// actual para ser modificado en el origen y no devuelve valor.
void DisminuirVelocidad(ref double valorActual)
{
    valorActual -= 1.0;
}

// espera: pausa la simulación durante el intervalo de comprobación (2 s).
// No recibe ni devuelve valor.
void Espera()
{
    Thread.Sleep(INTERVALO_COMPROBACION * 1000);
}

// comprobarFallo: simula un fallo crítico. Si un factor aleatorio es
// menor que 0.1 (umbral definido en el sistema), lanza un error en
// tiempo de ejecución de tipo SystemException. No recibe ni devuelve valor.
void ComprobarFallo()
{
    if (rnd.NextDouble() < UMBRAL_FALLO)
    {
        throw new SystemException("Fallo aleatorio en el sistema de control de vuelo.");
    }
}

// leerParametro: lee la información de entrada asegurando que no hay
// problemas en su procesamiento y que es válida y está dentro de los
// parámetros objetivos (inferior y superior). Devuelve el valor leído y
// deja indicado en 'out' el número de intentos realizados hasta obtener
// un valor válido. Usa un mensaje para indicar qué se requiere.
double LeerParametro(string mensaje, double minimo, double maximo, out int intentos)
{
    double valor;
    bool valido;
    intentos = 0; // el out debe asignarse SIEMPRE antes de salir

    do
    {
        intentos++;
        Write($"{mensaje}: ");
        valido = double.TryParse(ReadLine(), out valor)
                && valor >= minimo && valor <= maximo;

        if (!valido)
        {
            WriteLine($"  ❌ Valor no válido. Se requiere un número entre {minimo:F1} y {maximo:F1}.");
        }
    } while (!valido);

    return valor;
}
