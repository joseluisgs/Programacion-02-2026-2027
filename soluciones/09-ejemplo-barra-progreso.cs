// ============================================================================
// Barra de progreso: escribir "en el mismo sitio" — UD02/ejemplos
//
// DOS formas de animar la consola sin que el texto se acumule:
//
//   1) \r (retorno de carro): el cursor vuelve al principio de la línea
//      actual y la siguiente Write la SOBRESCRIBE. Simple, para una sola
//      línea, y funciona incluso con la salida redirigida (pipes).
/ Borramos la consola
Clear();/
//   2) Console.SetCursorPosition(x, y): fija coordenadas concretas de la
//      pantalla. Más potente (varias zonas a la vez) pero necesita
//      consola real: si la salida está redirigida, lanza excepción.
//
// Conceptos UD02: bucle for, Thread.Sleep como reloj (2.9),
//   interpolación, CursorLeft/CursorTop y SetCursorPosition (técnica).
//
// Ejecutar: dotnet run 09-ejemplo-barra-progreso.cs
// ============================================================================
using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8; // Para emojis

// Ponemos titulo y descripción
Title = "Ejemplo: barra de progreso";

//

// -----------------------------------------------------
// 1) CON \r: la forma más simple (una sola línea)
// -----------------------------------------------------
WriteLine("1) Barra de progreso con \\r (retorno de carro)");
Write("   ");

for (int i = 0; i <= 100; i += 5)
{
    // \r devuelve el cursor al principio de la Write la sobrescribe.
    // Los espacios del final borran restos si el texto anterior era más largo.
    Write($"\r   📦 [{DibujarBarra(i)}] {i}% ");

    Thread.Sleep(50); // medio décimo de segundo por tic
}

WriteLine();
WriteLine("   ✅ ¡Completado con éxito!");
WriteLine();

// -----------------------------------------------------
// 2) CON SetCursorPosition: coordenadas fijas (varias líneas)
// -----------------------------------------------------
WriteLine("2) Barra de progreso con SetCursorPosition (coordenadas guardadas)");

if (IsOutputRedirected)
{
    // Sin consola real no hay pantalla que posicionar: lo contamos y seguimos
    WriteLine("   (Salida redirigida: SetCursorPosition no está disponible, se omite)");
}
else
{
    // Guardamos las coordenadas donde queremos que se escriba siempre
    int left = CursorLeft;
    int top = CursorTop;

    for (int i = 1; i <= 10; i++)
    {
        // Volvemos a la misma posición en cada tic
        SetCursorPosition(left, top);

        // Escribimos el texto (los espacios del final borran si el
        // texto anterior era más largo)
        Write($"   🚀 Preparando recursos... {i}/10   ");

        Thread.Sleep(300);
    }

    // Terminamos en la misma posición, pero con el mensaje final
    SetCursorPosition(left, top);
    WriteLine("   ✅ ¡Listo! Recursos preparados (10/10).");
}

WriteLine();
WriteLine("🏁 Fin de la demostración.");

// -----------------------------------------------------
// FUNCIONES AUXILIARES
// -----------------------------------------------------

// DibujarBarra: traduce un porcentaje (0-100) en una barra de 20 huecos:
// los completados con '#' y los pendientes con '-'.
string DibujarBarra(int porcentaje)
{
    int completados = porcentaje / 5; // de 0 a 20
    string barra = "";

    for (int hueco = 0; hueco < 20; hueco++)
    {
        barra += hueco < completados ? "#" : "-";
    }

    return barra;
}

// -----------------------------------------------------
// ¿CUÁL USO? (resumen en comentarios)
// -----------------------------------------------------
// - \r        → una sola línea que se actualiza: barras, relojes,
//               contadores, "cargando...". Funciona en cualquier contexto.
// - SetCoordenadas → varias zonas fijas a la vez (paneles, tablas que
//               se actualizan). Requiere consola real.
// Truco común a ambas: termina la línea con espacios ("...   ") para
// borrar restos si el texto nuevo es más corto que el anterior.
