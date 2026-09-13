# Batería de Ejercicios: Programación Estructurada en C# 14

**Instrucciones:** Para cada ejercicio, escribe el código completo en C# usando Top-Level Statements dentro de un archivo `.cs`. Ejecuta cada ejercicio con `dotnet run tu_ejercicio.cs`. Recuerda: **primero el diseño en papel, luego la codificación**.

---

### Bloque I: Secuencias y Operaciones Básicas (Ejercicios 1-10)

**Ejercicio 1: Tu Setup de Programador**
Crea un archivo `ej01.cs` que muestre tu setup de programador: marca del portátil (`string`), pulgadas de pantalla (`int`), RAM en GB (`int`), sistema operativo (`string`). Muestra todo con interpolación.

**Ejercicio 2: Calculadora de Edad**
Crea un archivo `ej02.cs` que pida la edad en años. Calcula meses (edad × 12) y días (edad × 365). Muestra: "Tienes {edad} años, {meses} meses o {dias} días".

**Ejercicio 3: Inventario de Videojuego**
Crea un archivo `ej03.cs` con `int pociones = 5;` `int espadas = 2;` `int monedas = 1500;`. Muestra el inventario. Suma 3 pociones y resta 200 monedas. Muestra el actualizado.

**Ejercicio 4: Intercambio de Variables**
Crea un archivo `ej04.cs` con `int a = 10;` `int b = 25;`. Intercambia sin variable temporal (aritmética). Muestra antes y después.

**Ejercicio 5: Constantes de Streaming**
Crea un archivo `ej05.cs` con `const int RESOLUCION = 1080;` `const double BITRATE = 6.0;` `const string CODEC = "H.264";`. Muestra la configuración.

**Ejercicio 6: Precio con IVA**
Crea un archivo `ej06.cs` que pida el precio base. Calcula IVA (21%) y precio final. Muestra: "{precio}€ + {iva}€ IVA = {total}€".

**Ejercicio 7: División Entera y Resto**
Crea un archivo `ej07.cs` que pida dos números. Muestra la división entera (`/`) y el módulo (`%`).

**Ejercicio 8: Clasificación de Servidor**
Crea un archivo `ej08.cs` que pida la temperatura. < 30 → "OK", >= 30 y < 50 → "Advertencia", >= 50 → "CRÍTICO".

**Ejercicio 9: Saludo por Horario**
Crea un archivo `ej09.cs` que pida la hora (0-23). < 12 → "Buenos días", >= 12 y < 20 → "Buenas tardes", >= 20 → "Buenas noches".

**Ejercicio 10: Par o Impar**
Crea un archivo `ej10.cs` que pida un número. Usa `%` para mostrar si es par o impar.

---

### Bloque II: Condicionales Múltiples y Ternario (Ejercicios 11-20)

**Ejercicio 11: Clasificación por Edad**
Crea un archivo `ej11.cs` que pida la edad. Usa `if-else if-else`: "Niño" (<12), "Adolescente" (12-17), "Adulto" (18-64), "Mayor" (65+).

**Ejercicio 12: Descuento por Compra**
Crea un archivo `ej12.cs` que pida el total. > 100€ → 10% descuento, > 50€ → 5%, si no → sin descuento. Muestra el total final.

**Ejercicio 13: Consola de Gaming**
Crea un archivo `ej13.cs` que pida una opción (1-4). Usa `switch`: 1=PlayStation, 2=Xbox, 3=Nintendo, 4=PC. Default → "Inválido".

**Ejercicio 14: Día de la Semana**
Crea un archivo `ej14.cs` que pida un número (1-7). Usa `switch` para el día. 6 o 7 → "¡Fin de semana!".

**Ejercicio 15: Ternario: Mayor de Edad**
Crea un archivo `ej15.cs` que pida la edad. Usa ternario: `string msg = edad >= 18 ? "Puedes votar" : "Todavía no puedes votar";`.

**Ejercicio 16: Ternario Anidado: Nota**
Crea un archivo `ej16.cs` que pida una nota (0-10). Ternario anidado: "Malo" (<4), "Regular" (4-6), "Bueno" (7-8), "Excelente" (9-10).

**Ejercicio 17: Ternario: Mayor de Dos**
Crea un archivo `ej17.cs` que pida dos números. Usa ternario para mostrar el mayor.

**Ejercicio 18: Menú con Switch**
Crea un archivo `ej18.cs` que muestre menú: 1=Jugar, 2=Opciones, 3=Salir. Pide opción y muestra qué se seleccionó.

**Ejercicio 19: Tipo de Sangre con Switch**
Crea un archivo `ej19.cs` que pida un número (1-4). Usa `switch`: 1=A+, 2=A-, 3=B+, 4=O+. Default → "Desconocido".

**Ejercicio 20: Ternario con Operaciones**
Crea un archivo `ej20.cs` que pida dos números. Muestra el resultado de una operación según la opción que elija el usuario.

---

### Bloque III: Bucles While y Do-While (Ejercicios 21-30)

**Ejercicio 21: Cuenta Atrás**
Crea un archivo `ej21.cs` con `while` que muestre cuenta atrás de 10 a 0. En 0 muestra "¡Lanzamiento!".

**Ejercicio 22: Menú Repetitivo**
Crea un archivo `ej22.cs` con `do-while` que muestre menú. Si elige 3, sale. Si no, vuelve a mostrar.

**Ejercicio 23: Suma hasta Negativo**
Crea un archivo `ej23.cs` con `while` que pida números. Si escribe -1, para y muestra la suma.

**Ejercicio 24: Validar Contraseña**
Crea un archivo `ej24.cs` con `do-while` que pida contraseña. Si tiene < 8 caracteres, vuelve a pedir.

**Ejercicio 25: Adivina el Número**
Crea un archivo `ej25.cs` con número secreto 7. Usa `do-while` para pedir intentos. Cuando acierte, muestra intentos.

**Ejercicio 26: Suma de Pares**
Crea un archivo `ej26.cs` con `while` que sume pares del 1 al 100.

**Ejercicio 27: Multiplicar por Restas**
Crea un archivo `ej27.cs` que pida dos números. Usa `while` para multiplicar por restas sucesivas.

**Ejercicio 28: Dividir por Restas**
Crea un archivo `ej28.cs` que pida dividendo y divisor. Usa `while` para obtener cociente y resto.

**Ejercicio 29: Media con Centinela**
Crea un archivo `ej29.cs` con `while` que pida notas. -1 como centinela. Muestra la media.

**Ejercicio 30: Contador con Bandera**
Crea un archivo `ej30.cs` con `bool encontrado = false;` y un número objetivo 23. Usa `while` pidiendo números al usuario hasta que escriba 23.

---

### Bloque IV: Bucles For (Ejercicios 31-40)

**Ejercicio 31: Tabla de Multiplicar**
Crea un archivo `ej31.cs` que pida un número. Usa `for` del 1 al 10 para mostrar su tabla.

**Ejercicio 32: Suma de Pares con For**
Crea un archivo `ej32.cs` con `for` que sume pares del 1 al 100.

**Ejercicio 33: Factorial**
Crea un archivo `ej33.cs` que pida un número. Usa `for` para calcular su factorial.

**Ejercicio 34: Contador de Dígitos**
Crea un archivo `ej34.cs` que pida un número entero. Usa `for` con divisiones sucesivas por 10 para contar sus dígitos.

**Ejercicio 35: Suma de Dígitos**
Crea un archivo `ej35.cs` que pida un número. Usa `for` para sumar sus dígitos (ej: 123 → 1+2+3 = 6).

**Ejercicio 36: Tabla Completa (For Anidado)**
Crea un archivo `ej36.cs` con dos `for` anidados para mostrar la tabla de multiplicar del 1 al 10.

**Ejercicio 37: Triángulo de Asteriscos**
Crea un archivo `ej37.cs` con `for` anidados para dibujar un triángulo de 5 filas:
```
*
**
***
****
*****
```

**Ejercicio 38: Triángulo Invertido**
Crea un archivo `ej38.cs` con `for` anidados para dibujar:
```
*****
****
***
**
*
```

**Ejercicio 39: Pirámide de Números**
Crea un archivo `ej39.cs` con `for` anidados:
```
1
12
123
1234
12345
```

**Ejercicio 40: FizzBuzz**
Crea un archivo `ej40.cs` con `for` del 1 al 100. Múltiplo de 3 → "Fizz", de 5 → "Buzz", de ambos → "FizzBuzz", si no → el número.

---

### Bloque V: Break, Continue y Control (Ejercicios 41-50)

**Ejercicio 41: Break en Bucle**
Crea un archivo `ej41.cs` con `while` que pida números. Cuando escriba 42, muestra "¡Encontrado!" y sale con `break`.

**Ejercicio 42: Continue: Saltar Impares**
Crea un archivo `ej42.cs` con `for` del 1 al 20. Usa `continue` para mostrar solo pares.

**Ejercicio 43: Break en Menú**
Crea un archivo `ej43.cs` con `while (true)` y menú. Opción 3 → `break`.

**Ejercicio 44: Continue en Suma**
Crea un archivo `ej44.cs` con `for` del 1 al 10. Usa `continue` para sumar solo los pares.

**Ejercicio 45: Break y Continue Juntos**
Crea un archivo `ej45.cs` con `for` del 1 al 50. Si es múltiplo de 7, `break`. Si es impar, `continue`. Muestra los pares que no son múltiplos de 7.

**Ejercicio 46: Buscar Número Primo**
Crea un archivo `ej46.cs` con `for` del 2 al 50. Usa un bucle anidado para comprobar si cada número es primo. Muestra los primos.

**Ejercicio 47: Comprobar Primo con Flag**
Crea un archivo `ej47.cs` que pida un número. Usa `bool esPrimo = true;` y un `for` para comprobar si es primo.

**Ejercicio 48: Encontrar el Mayor de 5 Números**
Crea un archivo `ej48.cs` con `for` que pida 5 números al usuario. Usa una variable `max` para guardar el mayor.

**Ejercicio 49: Encontrar el Menor de 5 Números**
Crea un archivo `ej49.cs` con `for` que pida 5 números. Usa una variable `min` para guardar el menor.

**Ejercicio 50: Contador de Positivos y Negativos**
Crea un archivo `ej50.cs` con `for` que pida 10 números. Cuenta cuántos son positivos y cuántos negativos.
