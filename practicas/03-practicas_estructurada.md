# Batería de Ejercicios: Programación Estructurada y Modular en C# 14

**Instrucciones:** Para cada ejercicio, escribe el código completo en C# usando Top-Level Statements dentro de un archivo `.cs`. Ejecuta cada ejercicio con `dotnet run tu_ejercicio.cs`. Recuerda: **primero el diseño en papel, luego la codificación**.

---

### Bloque I: Introducción y Secuencias (Ejercicios 1-5)

**Ejercicio 1: Tu Setup de Programador**
Crea un archivo `ej01.cs` que muestre en la consola tu setup de programador: marca del portátil (`string`), pulgadas de pantalla (`int`), RAM en GB (`int`), sistema operativo (`string`). Muestra todo con interpolación en un formato bonito. Añade un comentario explicando qué es la secuencia en programación.

**Ejercicio 2: Calculadora de Edad en Años, Meses y Días**
Crea un archivo `ej02.cs` que pida al usuario su edad en años. Calcula los meses aproximados (edad × 12) y los días (edad × 365). Muestra: "Tienes {edad} años, que son aproximadamente {meses} meses o {dias} días". Explica en un comentario por qué las instrucciones se ejecutan en orden (secuencia).

**Ejercicio 3: Inventario de un Videojuego**
Crea un archivo `ej03.cs` con variables para un inventario: `int pociones = 5;` `int espadas = 2;` `int escudos = 1;` `int monedas = 1500;`. Muestra el inventario completo. Luego suma 3 pociones más con `pociones += 3;` y resta 200 monedas con `monedas -= 200;`. Muestra el inventario actualizado.

**Ejercicio 4: Intercambio de Variables sin Temporal**
Crea un archivo `ej04.cs` con `int a = 10;` `int b = 25;`. Muestra los valores originales. Luego intercambia sus valores SIN usar una variable temporal (usa la aritmética: `a = a + b; b = a - b; a = a - b;`). Muestra los valores intercambiados. Comenta por qué este truco funciona.

**Ejercicio 5: Configuración de un Stream**
Crea un archivo `ej05.cs` que declare constantes de configuración de streaming: `const int RESOLUCION_MAXIMA = 1080;` `const double BITRATE = 6.0;` `const string CODEC = "H.264";` `const bool USAR_HARDWARE = true;`. Muestra la configuración. Intenta modificar `RESOLUCION_MAXIMA` y comenta qué error da.

---

### Bloque II: Condicionales Simple y Compuesto (Ejercicios 6-12)

**Ejercicio 6: ¿Eres Mayor de Edad para Competir?**
Crea un archivo `ej06.cs` que pida la edad al usuario. Si es mayor o igual a 18, muestra "Puedes entrar al torneo". Si es menor, muestra "Debes esperar unos años". Usa `if-else`.

**Ejercicio 7: Clasificador de Videojuegos por Edad**
Crea un archivo `ej07.cs` que pida la clasificación por edad de un juego (3, 7, 12, 16, 18). Usa `if-else if-else` para mostrar un mensaje según la edad: "Para toda la familia" (3), "Infantil" (7), "Teen" (12), "Maduro" (16), "Solo adultos" (18). Si la edad no es válida, muestra "Clasificación desconocida".

**Ejercicio 8: Calculadora de Descuentos**
Crea un archivo `ej08.cs` que pida el total de la compra. Si el total es mayor a 100€, aplica 10% de descuento. Si es mayor a 50€, aplica 5%. Si no, sin descuento. Muestra el descuento aplicado y el total final. Usa `if-else if-else`.

**Ejercicio 9: ¿Qué Consola de Gaming Tienes?**
Crea un archivo `ej09.cs` que pida al usuario una opción numérica: 1 = PlayStation, 2 = Xbox, 3 = Nintendo, 4 = PC. Usa `switch` para mostrar el nombre de la consola. Si elige otra cosa, muestra "Opción no válida". Incluye un `default` en el switch.

**Ejercicio 10: Día de la Semana con Switch**
Crea un archivo `ej10.cs` que pida un número del 1 al 7. Usa `switch` para mostrar el día de la semana. Si es 6 o 7, muestra "¡Fin de semana!". Usa `case 6: case 7:` para agrupar ambos casos.

**Ejercicio 11: Ternario: Skin Rara o Común**
Crea un archivo `ej11.cs` que pida al usuario un número del 1 al 100 (simulando un drop de un juego). Si el número es menor o igual a 5, muestra "¡Skin Legendaria!". Si no, muestra "Skin común". Usa el operador ternario `? :`.

**Ejercicio 12: Ternario Anidado: Nivel de Rango**
Crea un archivo `ej12.cs` que pida la puntuación de un jugador (0-100). Usa un ternario anidado para asignar rango: "Hierro" (<20), "Bronce" (20-39), "Plata" (40-59), "Oro" (60-79), "Diamante" (80+). Muestra el rango.

---

### Bloque III: Condicionales Múltiples y Nulos (Ejercicios 13-17)

**Ejercicio 13: Switch Expresión: Tipo de Pokémon**
Crea un archivo `ej13.cs` que pida un número del 1 al 5. Usa una expresión `switch` para asignar el tipo de Pokémon: 1 = Fuego, 2 = Agua, 3 = Planta, 4 = Eléctrico, 5 = Normal. Usa `_ => "Desconocido"` para el default. Muestra el tipo.

**Ejercicio 14: Calificación con Switch Expresión**
Crea un archivo `ej14.cs` que pida una nota del 0 al 10. Usa una expresión `switch` para mostrar: "Muy deficiente" (0-2), "Insuficiente" (3-4), "Suficiente" (5-6), "Notable" (7-8), "Sobresaliente" (9-10). Fuera de rango, muestra "Nota no válida".

**Ejercicio 15: Comprobación de Nulos con `is not null`**
Crea un archivo `ej15.cs` con `string? nombreUsuario = null;`. Si el nombre NO es null, muestra "Bienvenido, {nombre}". Si es null, muestra "Usuario anónimo". Usa `is not null` en el `if`.

**Ejercicio 16: Extraer Valor con `is { }`**
Crea un archivo `ej16.cs` con `string? mensaje = "Hola Mundo";`. Si el mensaje no es null, extráelo con `is { } mensajeLimpio` y muestra su longitud. Luego prueba con `mensaje = null` y muestra "No hay mensaje".

**Ejercicio 17: Patrón con `is string` para Casting Seguro**
Crea un archivo `ej17.cs` con `object dato = 42;`. Usa `if (dato is int numero)` para comprobar que es un entero Y extraerlo. Muestra el doble del número. Luego prueba con `dato = "Hola"` y `if (dato is string texto)` para mostrar el texto en mayúsculas.

---

### Bloque IV: Bucles While y Do-While (Ejercicios 18-24)

**Ejercicio 18: Cuenta Atrás de un Lanzamiento**
Crea un archivo `ej18.cs` que muestre una cuenta atrás desde 10 hasta 0 usando un bucle `while`. Cuando llegue a 0, muestra "¡Lanzamiento!".

**Ejercicio 19: Menú con Do-While**
Crea un archivo `ej19.cs` que muestre un menú repetitivo con `do-while`: 1 = Jugar, 2 = Opciones, 3 = Salir. Pide una opción al usuario. Si elige 3, se sale del bucle. Si no, muestra "Has elegido la opción {opcion}" y vuelve a mostrar el menú.

**Ejercicio 20: Suma de Números hasta Negativo**
Crea un archivo `ej20.cs` que pida números al usuario repetidamente con `while`. La suma se acumula. Cuando el usuario escriba un número negativo, el bucle se detiene y muestra la suma total.

**Ejercicio 21: Validación de Contraseña con Do-While**
Crea un archivo `ej21.cs` que pida una contraseña al usuario. Si no tiene al menos 8 caracteres, vuelve a pedirla con `do-while` hasta que sea válida. Muestra "Contraseña aceptada".

**Ejercicio 22: Buscar un Número en una Lista**
Crea un archivo `ej22.cs` con un array `int[] numeros = { 5, 12, 8, 23, 1, 47, 9 };`. Usa un `while` para buscar el número 23. Cuando lo encuentres, muestra "Encontrado en la posición {i}" y sal del bucle con `break`.

**Ejercicio 23: Bucle con Centinela: Chat**
Crea un archivo `ej23.cs` que simule un chat. Usa un `while` que pida mensajes al usuario. Si escribe "salir", el bucle termina. Muestra cada mensaje con el prefijo "Tú: ".

**Ejercicio 24: ¿Cuántos Intentos para Adivinar?**
Crea un archivo `ej24.cs` con un número secreto `int secreto = 7;`. Usa un `do-while` para pedir intentos al usuario. Cuenta los intentos. Cuando acierte, muestra "¡Acertaste en {intentos} intentos!".

---

### Bloque V: Bucles For y Foreach (Ejercicios 25-31)

**Ejercicio 25: Tabla de Multiplicar**
Crea un archivo `ej25.cs` que pida un número al usuario. Usa un bucle `for` del 1 al 10 para mostrar su tabla de multiplicar: "{numero} x {i} = {resultado}".

**Ejercicio 26: Suma de Números Pares**
Crea un archivo `ej26.cs` que use un `for` para sumar todos los números pares del 1 al 100. Muestra el resultado final.

**Ejercicio 27: Factorial con For**
Crea un archivo `ej27.cs` que pida un número al usuario. Usa un `for` para calcular su factorial (n * (n-1) * (n-2) * ... * 1). Muestra el resultado.

**Ejercicio 28: Recorrer un Array con Foreach**
Crea un archivo `ej28.cs` con `string[] videos = { "Intro C#", "POO", "Bases de Datos", "APIs", "Deploy" };`. Usa un `foreach` para mostrar cada video con su posición: "Video 1: Intro C#".

**Ejercicio 29: Contar Vocales con Foreach**
Crea un archivo `ej29.cs` que pida una frase al usuario. Usa un `foreach` para recorrer cada carácter y contar cuántas vocales tiene. Muestra el resultado.

**Ejercicio 30: Bucle For Anidado: Tabla de Multiplicar Completa**
Crea un archivo `ej30.cs` que use dos bucles `for` anidados para mostrar la tabla de multiplicar completa del 1 al 10. Solo muestra los resultados donde el multiplicador es menor o igual al multiplicando.

**Ejercicio 31: Patrón de Asteriscos con For Anidado**
Crea un archivo `ej31.cs` que use bucles `for` anidados para dibujar un triángulo de asteriscos de 5 filas:
```
*
**
***
****
*****
```

---

### Bloque VI: Break, Continue y Control de Bucles (Ejercicios 32-35)

**Ejercicio 32: Break en un Array**
Crea un archivo `ej32.cs` con `int[] precios = { 15, 25, 8, 42, 3, 19 };`. Usa un `for` para buscar el primer precio mayor a 30. Cuando lo encuentres, muestra "Primer precio mayor a 30: {precio}" y sal con `break`.

**Ejercicio 33: Continue: Saltar Impares**
Crea un archivo `ej33.cs` que use un `for` del 1 al 20. Usa `continue` para saltar los números impares y solo mostrar los pares.

**Ejercicio 34: Break en un Menú**
Crea un archivo `ej34.cs` con un `while (true)` que muestre un menú: 1 = Perfil, 2 = Configuración, 3 = Salir. Si elige 3, usa `break` para salir del bucle infinito.

**Ejercicio 35: Continue en una Suma Filtrada**
Crea un archivo `ej35.cs` con `int[] edades = { 15, 22, 8, 30, 12, 25, 6, 18 };`. Usa un `foreach` con `continue` para sumar solo las edades mayores a 10. Muestra la suma.

---

### Bloque VII: Funciones con Valor de Retorno (Ejercicios 36-40)

**Ejercicio 36: Función Calcular IMC**
Crea un archivo `ej36.cs` con una función `double CalcularIMC(double peso, double altura)` que devuelva el IMC. Pide peso y altura al usuario, llama a la función y muestra el resultado.

**Ejercicio 37: Función EsPar**
Crea un archivo `ej37.cs` con una función `bool EsPar(int numero)` que devuelva `true` si el número es par. Pide 5 números al usuario y muestra cuáles son pares.

**Ejercicio 38: Función ObtenerRango**
Crea un archivo `ej38.cs` con una función `string ObtenerRango(int nota)` que devuelva "Muy deficiente" (0-2), "Insuficiente" (3-4), "Suficiente" (5-6), "Notable" (7-8), "Sobresaliente" (9-10). Pide 3 notas y muestra el rango de cada una.

**Ejercicio 39: Función Area Circulo**
Crea un archivo `ej39.cs` con una función `double AreaCirculo(double radio)` que calcule el área (π × radio²). Usa `Math.PI`. Pide el radio y muestra el área.

**Ejercicio 40: Función ContarLetra**
Crea un archivo `ej40.cs` con una función `int ContarLetra(string texto, char letra)` que cuente cuántas veces aparece una letra en un texto. Pide un texto y una letra, y muestra el resultado.

---

### Bloque VIII: Procedimientos y Parámetros (Ejercicios 41-45)

**Ejercicio 41: Procedimiento MostrarMenu**
Crea un archivo `ej41.cs` con un procedimiento `void MostrarMenu()` que muestre un menú de opciones. Llámalo desde el Main.

**Ejercicio 42: Paso por Referencia con `ref`**
Crea un archivo `ej42.cs` con un procedimiento `void Duplicar(ref int numero)` que duplique el valor de la variable. Declara `int valor = 10;`, llámalo con `ref` y muestra antes y después.

**Ejercicio 43: Parámetro de Salida con `out`**
Crea un archivo `ej43.cs` con una función `bool Dividir(int a, int b, out int resultado)` que divida `a` entre `b`. Si `b` es 0, devuelve `false` y `resultado = 0`. Si no, devuelve `true` y el resultado. Prueba con 10/3 y 10/0.

**Ejercicio 44: Parámetros con `ref` para Intercambiar**
Crea un archivo `ej44.cs` con un procedimiento `void Intercambiar(ref int a, ref int b)` que intercambie dos valores. Declara `int x = 5;` `int y = 15;`, llámalo y muestra antes y después.

**Ejercicio 45: Parámetro `params` para Suma Variable**
Crea un archivo `ej45.cs` con una función `int SumarTodos(params int[] numeros)` que sume todos los argumentos. Llámala con 3, 5 y 2 argumentos diferentes y muestra los resultados.

---

### Bloque IX: Sobrecarga, Recursividad y Early Return (Ejercicios 46-48)

**Ejercicio 46: Sobrecarga de Funciones**
Crea un archivo `ej46.cs` con dos funciones `int Doble(int numero)` y `double Doble(double numero)`. La primera duplica un entero, la segunda un decimal. Llama a ambas y muestra los resultados.

**Ejercicio 47: Factorial Recursivo**
Crea un archivo `ej47.cs` con una función recursiva `int Factorial(int n)` que calcule el factorial. Incluye la condición de parada (`if (n <= 1) return 1;`). Prueba con 5, 0 y 10.

**Ejercicio 48: Early Return en Validación**
Crea un archivo `ej48.cs` con una función `void ProcesarPedido(int cantidad, bool estaEnStock)` que use Early Return: si `cantidad <= 0`, muestra "Cantidad inválida" y retorna; si `!estaEnStock`, muestra "Sin stock" y retorna. Si todo está bien, muestra "Pedido procesado". Prueba los 3 casos.

---

### Bloque X: Excepciones y Asertaciones (Ejercicios 49-50)

**Ejercicio 49: Try-Catch en una Calculadora**
Crea un archivo `ej49.cs` que pida dos números al usuario. Usa `int.TryParse` para convertirlos. Si la conversión falla, captura la situación y muestra "Número no válido". Si funciona, muestra la suma, resta, multiplicación y división. Para la división, usa `try-catch` para capturar `DivideByZeroException` si el segundo número es 0.

**Ejercicio 50: Excepciones Personalizadas con Throw**
Crea un archivo `ej50.cs` con una función `void ValidarEdad(int edad)` que lance una excepción `ArgumentException` si la edad es negativa o mayor a 150. Usa `try-catch` para capturar la excepción y mostrar el mensaje de error. Prueba con edad 25, edad -5 y edad 200.
