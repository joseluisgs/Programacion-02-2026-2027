// ============================================================================
// Simulador simple con probabilidad (modular) — UD02/ejemplos
//
// ENUNCIADO: Simular un proceso que avanza en pasos de 1 segundo (1000 ms)
// durante un máximo de 10 segundos. En cada paso hay un 20% de probabilidad
// de que el proceso termine antes por azar. El programa informa de si salió
// por probabilidad o por haber agotado el tiempo.
//
// Conceptos UD02 que ilustra:
//   - Bucle do-while con DOS condiciones de parada (tiempo O probabilidad)
//     unidas con && — sección 2.4
//   - Thread.Sleep para simular el paso del tiempo
//   - Función bool que encapsula la aleatoriedad (Probabilidad)
//
// Ejecutar: dotnet run 06-modular-simulador.cs
// ============================================================================

const int TIEMPO_SIMULACION = 10000; // Duración máxima en milisegundos
const int INCREMENTO_TIEMPO = 1000;  // Cada "tick" dura 1 segundo
const decimal PROBABILIDAD_ACCION = 0.20m; // 20% de salir en cada tick

Random rnd = new(); // Un SOLO generador para toda la simulación (sección 2.8)

int tiempo = 0;
bool salidaPorProbabilidad = false;
bool condicionSalida = false;

do
{
    Thread.Sleep(INCREMENTO_TIEMPO); // Pausa REAL de 1 s: el reloj del simulador (sin ella, el bucle terminaría en milisegundos)
    tiempo += INCREMENTO_TIEMPO;
    Console.WriteLine($"Tiempo: {(double)tiempo/1000} s");

    salidaPorProbabilidad = Probabilidad(PROBABILIDAD_ACCION);

    // El bucle para por cualquiera de las dos causas: tiempo agotado
    // (tiempo >= máximo) o por la probabilidad (salidaPorProbabilidad)
    condicionSalida = tiempo < TIEMPO_SIMULACION && !salidaPorProbabilidad;
} while (condicionSalida);

if (salidaPorProbabilidad)
    Console.WriteLine("Se ha salido por probabilidad");
else
    Console.WriteLine("Se ha llegado al tiempo de simulación");

Console.WriteLine("Fin de la simulación");

// ----------------------------------------------------
// FUNCIONES AUXILIARES
// ----------------------------------------------------

// Devuelve true con la probabilidad indicada (0.20 = 20%)
bool Probabilidad(decimal probabilidad)
{
    return (decimal)rnd.NextDouble() < probabilidad;
}
