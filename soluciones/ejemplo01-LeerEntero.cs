// ============================================================
// Ejemplo 01 — Leer un entero del teclado: excepción y recuperación
//
// El teclado es una fuente de datos que NO controlamos: el usuario puede
// escribir "abc", dejarlo vacío o meter "99999999999". Por eso usamos
// excepciones: int.Parse "rebienta" (lanza) cuando el texto no es número,
// y nosotros lo recogemos con try-catch para que el programa NO se muera.
//
// Clave: cuando un try-catch recoge el error, la función DEBE cambiar lo
// que devuelve (el bool, el out, el return) para avisar a quien la llama
// de que la conversión ha fallado. Nunca se devuelve "basura silenciosa".
// ============================================================
using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8; // Para emojis

WriteLine("Hello, World!");
var cad = "123";

// var res = int.TryParse(cad, out int result);

var res = MiIntTryParse(cad, out var result);
if (res)
    WriteLine(result);
else
    WriteLine("No se pudo parsear " + cad);


cad = "123ca";
var otro = MiIntTryParse(cad, out var result2);

if (otro)
    WriteLine(result2);
else
    WriteLine("No se pudo parsear " + cad);


var entero = LeerEntero("Introduce un número", 0, 100);
WriteLine(entero);

LeerEnteroConOut("Introduce un número", 0, 100, out var otroValor);
WriteLine(otroValor);

// ---------
// Nuestro propio "TryParse" hecho a mano, para ver qué hay debajo.
//
// ¿Por qué excepción y no un simple if? Porque NO sabemos qué va a
// meter el usuario por teclado: si el texto no es un número, int.Parse
// lanza FormatException; si el número no cabe en un int, lanza
// OverflowException. En lugar de prever todos los casos imposibles,
// dejamos que la operación "rebiente" y la recogemos en el catch.
//
// Al recoger el error CAMBIAMOS lo que devuelve la función:
//   - return false       → el llamador sabe que la conversión falló
//   - convertResult = 0  → el out necesita SIEMPRE un valor (obligatorio
//     en C#), pero el resultado real del fallo lo comunica el false
bool MiIntTryParse(string input, out int convertResult) {
    try {
        // También puedo usar Convert
        convertResult = int.Parse(input);
        return true;
    }
    // Si el usuario metió basura por teclado, aquí se recoge
    catch (FormatException) {
        convertResult = 0;
        return false;
    }
    // Número demasiado grande para un int: otro tipo de rebentazo
    catch (OverflowException) {
        convertResult = 0;
        return false;
    }
}


// Versión con prevención (sin excepciones): TryParse ya devuelve un bool.
// El do-while re-pregunta hasta que el dato es válido, así que la
// función solo devuelve un entero que ESTÁ dentro del rango.
int LeerEntero(string mensaje, int min, int max) {
    int valor;
    bool esValido;

    do {
        Write($"{mensaje} ({min}-{max}): ");
        esValido = int.TryParse(ReadLine(), out valor);

        if (!esValido) {
            WriteLine("❌ No es un número válido.");
        }
        else if (valor < min || valor > max) {
            WriteLine($"❌ El valor debe estar entre {min} y {max}.");
            esValido = false;
        }
        // Si no es válido, el bucle vuelve a pedir el dato: nunca salimos
        // con un valor malo. Ese es el contrato de la función.
    } while (!esValido);

    return valor;
}

// Misma idea, pero el resultado sale por out. Como aquí NO devolvemos un
// bool, la única garantía de validez es el do-while: el out solo se
// "escapa" al llamador cuando el número ya es correcto y está en rango.
void LeerEnteroConOut(string mensaje, int min, int max, out int valor) {
    bool esValido;

    do {
        Write($"{mensaje} ({min}-{max}): ");
        esValido = int.TryParse(ReadLine(), out valor);

        if (!esValido) {
            WriteLine("❌ No es un número válido.");
        }
        else if (valor < min || valor > max) {
            WriteLine($"❌ El valor debe estar entre {min} y {max}.");
            esValido = false;
        }
    } while (!esValido);
}
