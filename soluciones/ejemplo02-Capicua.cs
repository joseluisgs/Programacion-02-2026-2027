using System.Text;
using static System.Console;

// Configuramos la codificación de la consola para soportar tildes y caracteres especiales
OutputEncoding = Encoding.UTF8;

// Definimos el número que queremos evaluar
var numero = 12321;

// Evaluamos si el número es capicúa utilizando nuestra función modular
if (EsCapicua(numero))
    WriteLine($"El número {numero} es capicúa.");
else
    WriteLine($"El número {numero} no es capicúa.");


numero = 12323;

if (EsCapicua(numero))
    WriteLine($"El número {numero} es capicúa.");
else
    WriteLine($"El número {numero} no es capicúa.");


// ==========================================
// MÓDULO 1: Validación de Capicúa
// ==========================================
// Función principal que recibe un número entero y devuelve true si es capicúa, o false en caso contrario.
bool EsCapicua(int n) {
    // Por convención matemática, los números negativos no se consideran capicúas
    if (n < 0) return false;
    
    // Un número es capicúa si es exactamente igual al resultado de invertir sus dígitos
    return n == InvertirNumero(n);
}


// ==========================================
// MÓDULO 2: Inversión Matemática del Número
// ==========================================
// Explicación detallada del algoritmo aritmético (sin usar strings):
// 1. Inicializamos un acumulador llamado 'invertido' en 0.
// 2. Mientras el número original 'n' sea mayor que 0:
//    a) Obtenemos el último dígito calculando el módulo por 10 (n % 10).
//    b) Multiplicamos el valor actual de 'invertido' por 10 para desplazar los dígitos 
//       a la izquierda y hacemos espacio para sumar el nuevo dígito obtenido.
//    c) Dividimos 'n' entre 10 (división entera) para eliminar la última cifra que ya procesamos.
// 3. Repetimos el proceso hasta que 'n' se quede en 0.
// 4. Devolvemos el número completamente invertido.
//
// ------------------------------------------
// EJEMPLO DE TRAZA PASO A PASO (para n = 12321):
// ------------------------------------------
// Estado inicial: n = 12321, invertido = 0
//
// Iteración 1:
//   - ¿n > 0? (12321 > 0) -> Sí.
//   - resto = 12321 % 10 = 1
//   - invertido = (0 * 10) + 1 = 1
//   - n = 12321 / 10 = 1232
//
// Iteración 2:
//   - ¿n > 0? (1232 > 0) -> Sí.
//   - resto = 1232 % 10 = 2
//   - invertido = (1 * 10) + 2 = 12
//   - n = 1232 / 10 = 123
//
// Iteración 3:
//   - ¿n > 0? (123 > 0) -> Sí.
//   - resto = 123 % 10 = 3
//   - invertido = (12 * 10) + 3 = 123
//   - n = 123 / 10 = 12
//
// Iteración 4:
//   - ¿n > 0? (12 > 0) -> Sí.
//   - resto = 12 % 10 = 2
//   - invertido = (123 * 10) + 2 = 1232
//   - n = 12 / 10 = 1
//
// Iteración 5:
//   - ¿n > 0? (1 > 0) -> Sí.
//   - resto = 1 % 10 = 1
//   - invertido = (1232 * 10) + 1 = 12321
//   - n = 1 / 10 = 0
//
// Fin del bucle (n es 0). Se devuelve invertido = 12321.
// Al comparar (12321 == 12321), el resultado es true.
// ==========================================
int InvertirNumero(int n) {
    var invertido = 0; // Variable acumuladora donde iremos formando el número al revés
    
    // Bucle que se ejecuta mientras queden dígitos por procesar en 'n'
    while (n > 0) {
        var resto = n % 10;                  // Obtenemos el último dígito de la derecha
        invertido = (invertido * 10) + resto; // Desplazamos los dígitos a la izquierda y añadimos el nuevo
        n /= 10;                             // Descartamos la última cifra del número original
    }
    
    // Devolvemos el número ya invertido
    return invertido;
}