using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8; // Para emogis

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
bool MiIntTryParse(string input, out int convertResult) {
    try {
        // También puedo usar Convert
        convertResult = int.Parse(input);
        return true;
    }
    catch (FormatException) {
        convertResult = 0;
        return false;
    }
    catch (OverflowException) {
        convertResult = 0;
        return false;
    }
}


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
    } while (!esValido);

    return valor;
}

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