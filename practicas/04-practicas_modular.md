# Batería de Ejercicios: Programación Modular y Control de Excepciones en C# 14

**Instrucciones:** Para cada ejercicio, escribe el código completo en C# usando Top-Level Statements dentro de un archivo `.cs`. Ejecuta cada ejercicio con `dotnet run tu_ejercicio.cs`. Recuerda: **primero el diseño en papel, luego la codificación**.

---

### Bloque I: Funciones Básicas con Valor de Retorno (Ejercicios 1-8)

**Ejercicio 1: Calculadora de Propinas**
Crea un archivo `ej01.cs` con una función `double CalcularPropina(double cuenta, double porcentaje)` que devuelva la propina. Pide la cuenta y el porcentaje al usuario. Muestra: "Cuenta: {cuenta}€ + Propina: {propina}€ = Total: {total}€".

**Ejercicio 2: Conversor de Temperatura**
Crea un archivo `ej02.cs` con dos funciones: `double CentigradosAFahrenheit(double c)` y `double FahrenheitACentigrados(double f)`. El programa pide al usuario la temperatura y el sentido de la conversión (C→F o F→C). Muestra el resultado.

**Ejercicio 3: ¿Es un Palíndromo?**
Crea un archivo `ej03.cs` con una función `bool EsPalindromo(string texto)` que compruebe si una palabra se lee igual al derecho que al revés (ej: "oso", "reconocer"). Pide una palabra y muestra el resultado.

**Ejercicio 4: Calculadora de IMC con Clasificación**
Crea un archivo `ej04.cs` con una función `string ClasificarIMC(double imc)` que devuelva "Bajo peso", "Normal", "Sobrepeso" o "Obesidad". Otra función `double CalcularIMC(double peso, double altura)` calcula el IMC. Pide datos al usuario y muestra la clasificación.

**Ejercicio 5: Generador de Contraseña Segura**
Crea un archivo `ej05.cs` con una función `string GenerarContraseña(int longitud)` que genere una contraseña aleatoria con mayúsculas, minúsculas y números. Usa `Random`. Pide la longitud y muestra la contraseña generada.

**Ejercicio 6: Validador de DNI**
Crea un archivo `ej06.cs` con una función `bool ValidarDNI(string dni)` que compruebe si tiene exactamente 8 dígitos y una letra. Pide un DNI y muestra si es válido o no.

**Ejercicio 7: Calculadora de Edad Exacta**
Crea un archivo `ej07.cs` con una función `int CalcularEdad(DateTime fechaNacimiento)` que devuelva la edad exacta en años. Pide la fecha de nacimiento y muestra la edad.

**Ejercicio 8: Contador de Palabras**
Crea un archivo `ej08.cs` con una función `int ContarPalabras(string frase)` que cuente cuántas palabras tiene una frase (separadas por espacios). Pide una frase y muestra el resultado.

---

### Bloque II: Procedimientos con Parámetros (Ejercicios 9-16)

**Ejercicio 9: Mostrar Bonito con Procedimiento**
Crea un archivo `ej09.cs` con un procedimiento `void MostrarConRecuadro(string texto)` que imprima el texto dentro de un recuadro de asteriscos:
```
**********
* Hola   *
**********
```
Llámalo 3 veces con textos diferentes.

**Ejercicio 10: Paso por Referencia: Intercambiar Nombres**
Crea un archivo `ej10.cs` con un procedimiento `void Intercambiar(ref string a, ref string b)` que intercambie dos strings. Declara `string nombre1 = "Ana";` `string nombre2 = "Luis";`, intercámbialos y muestra antes y después.

**Ejercicio 11: Parámetro `out`: Múltiples Resultados**
Crea un archivo `ej11.cs` con un procedimiento `void AnalizarTexto(string texto, out int palabras, out int vocales, out int consonantes)` que analice un texto y devuelva estadísticas. Pide un texto y muestra las 3 estadísticas.

**Ejercicio 12: Parámetro `in`: Solo Lectura**
Crea un archivo `ej12.cs` con una función `double CalcularDescuento(in double precio, in double porcentaje)` que calcule el descuento SIN modificar los originales. Intenta modificar `precio` dentro de la función y comenta el error.

**Ejercicio 13: Parámetros por Defecto: Registrar Usuario**
Crea un archivo `ej13.cs` con una función `void RegistrarUsuario(string nombre, string email, bool esPremium = false, string idioma = "es")` que muestre los datos. Llama a la función con 2, 3 y 4 argumentos para ver los defectos.

**Ejercicio 14: Parámetro `params`: Suma Variable**
Crea un archivo `ej14.cs` con una función `double Promedio(params double[] notas)` que calcule la media. Llámala con 2, 4 y 6 notas diferentes.

**Ejercicio 15: Sobrecarga de Funciones: Calcular Area**
Crea un archivo `ej15.cs` con dos funciones `double CalcularArea(double lado)` (cuadrado) y `double CalcularArea(double largo, double ancho)` (rectángulo). Prueba ambas.

**Ejercicio 16: Paso por Referencia: Acumulador**
Crea un archivo `ej16.cs` con un procedimiento `void Acumular(ref int total, int cantidad)` que sume la cantidad al total. Usa un bucle para acumular 5 cantidades que pide al usuario. Muestra el total final.

---

### Bloque III: Ámbito y Diseño Modular (Ejercicios 17-24)

**Ejercicio 17: Variables Locales vs Globales**
Crea un archivo `ej17.cs` con una variable global `int contador = 0;` y un procedimiento `void Incrementar()` que la incremente. Llámalo 5 veces y muestra el contador. Explica en un comentario por qué las globales son peligrosas.

**Ejercicio 18: Early Return en Validación de Email**
Crea un archivo `ej18.cs` con una función `bool ValidarEmail(string email)` que use Early Return: si es null o vacío, retorna false; si no contiene `@`, retorna false; si no contiene `.`, retorna false. Si todo está bien, retorna true. Prueba con 3 emails.

**Ejercicio 19: Early Return en Calificación**
Crea un archivo `ej19.cs` con una función `string Calificar(double nota)` que use Early Return: si nota < 0, retorna "Error"; si nota > 10, retorna "Error"; si nota < 5, retorna "Suspenso"; si nota < 7, retorna "Aprobado"; si nota < 9, retorna "Notable"; retorna "Sobresaliente".

**Ejercicio 20: Sobrecarga con Diferentes Tipos**
Crea un archivo `ej20.cs` con dos funciones `string Describir(int numero)` y `string Describir(string texto)`. La primera dice "Es un entero: {numero}", la segunda "Es un texto de {texto.Length} caracteres". Prueba ambas.

**Ejercicio 21: Función con Parámetro Nombrado**
Crea un archivo `ej21.cs` con una función `void MostrarInfo(string nombre, int edad, string ciudad)`. Llámala usando parámetros nombrados en orden desordenado: `MostrarInfo(ciudad: "Madrid", nombre: "Ana", edad: 25)`.

**Ejercicio 22: Recursividad: Suma de Digitos**
Crea un archivo `ej22.cs` con una función recursiva `int SumaDigitos(int numero)` que sume todos los dígitos de un número (ej: 123 → 1+2+3 = 6). Prueba con 456, 1000 y 9999.

**Ejercicio 23: Recursividad: Potencia**
Crea un archivo `ej23.cs` con una función recursiva `double Potencia(double baseNum, int exponente)` que calcule la potencia sin usar `Math.Pow`. Incluye la condición de parada. Prueba con 2^10, 3^0 y 5^3.

**Ejercicio 24: Recursividad: Fibonacci**
Crea un archivo `ej24.cs` con una función recursiva `int Fibonacci(int n)` que devuelva el término n de Fibonacci. Prueba con n=5, n=10 y n=1. Explica en un comentario por qué es ineficiente para valores grandes.

---

### Bloque IV: Parámetros `ref` y `out` Avanzados (Ejercicios 25-32)

**Ejercicio 25: Ordenar Tres Números con `ref`**
Crea un archivo `ej25.cs` con un procedimiento `void Ordenar(ref int a, ref int b, ref int c)` que ordene tres números de menor a mayor usando `ref`. Prueba con (5, 2, 8).

**Ejercicio 26: Calcular Edad con `out`**
Crea un archivo `ej26.cs` con una función `bool CalcularEdad(DateTime nacimiento, out int anios, out int meses)` que devuelva la edad en años y meses. Usa `DateTime.Now`. Prueba con 3 fechas diferentes.

**Ejercicio 27: Devolución de Cambio con `out`**
Crea un archivo `ej27.cs` con un procedimiento `void CalcularCambio(double total, double pagado, out int monedas2, out int monedas1, out int monedas50, out int monedas20)` que calcule el cambio en monedas. Prueba con total=4.70€, pagado=10€.

**Ejercicio 28: Análisis de Temperaturas con `ref`**
Crea un archivo `ej28.cs` con un procedimiento `void ActualizarEstadisticas(double nuevaTemp, ref double suma, ref int contador, ref double maxima, ref double minima)` que actualice estadísticas con cada temperatura. Procesa 5 temperaturas.

**Ejercicio 29: Validación con Múltiples `out`**
Crea un archivo `ej29.cs` con una función `bool ValidarUsuario(string nombre, string password, out string error)` que valide: nombre > 2 caracteres, password > 6 caracteres. Si falla, `error` explica el problema. Prueba con datos válidos e inválidos.

**Ejercicio 30: Intercambiar Arrays con `ref`**
Crea un archivo `ej30.cs` con un procedimiento `void IntercambiarArrays(ref int[] a, ref int[] b)` que intercambie dos arrays. Prueba con `a = {1,2,3}` y `b = {4,5,6}`.

**Ejercicio 31: Buscar y Reemplazar con `out`**
Crea un archivo `ej31.cs` con una función `string BuscarYReemplazar(string texto, string buscar, string reemplazar, out int ocurrencias)` que reemplace un texto y cuente cuántas veces lo hizo. Prueba con "hola mundo hola" reemplazando "hola" por "adiós".

**Ejercicio 32: Parámetro `in`: Calcular Distancia**
Crea un archivo `ej32.cs` con una función `double CalcularDistancia(in double x1, in double y1, in double x2, in double y2)` que calcule la distancia entre dos puntos. Intenta modificar `x1` dentro y comenta el error.

---

### Bloque V: Manejo de Excepciones con Try-Catch (Ejercicios 33-40)

**Ejercicio 33: Lectura Segura de Números**
Crea un archivo `ej33.cs` que pida un número al usuario. Usa `int.TryParse` en un bucle `while` hasta que introduzca un número válido. Muestra el número.

**Ejercicio 34: División Segura con Try-Catch**
Crea un archivo `ej34.cs` que pida dos números. Usa `try` para dividir. Si el divisor es 0, captura `DivideByZeroException` y muestra "No se puede dividir por cero". Si el formato es incorrecto, captura `FormatException`.

**Ejercicio 35: Calculadora con Excepciones**
Crea un archivo `ej35.cs` con una calculadora que pida dos números y una operación (+, -, *, /). Cada operación es una función. La división usa `try-catch` para `DivideByZeroException`. La lectura usa `double.TryParse`.

**Ejercicio 36: Acceso a Array con Índice Inválido**
Crea un archivo `ej36.cs` con `string[] frutas = { "Manzana", "Pera", "Naranja" };`. Pide un índice al usuario. Usa `try` para acceder al array. Si el índice está fuera de rango, captura `IndexOutOfRangeException`.

**Ejercicio 37: Parse de Múltiples Tipos**
Crea un archivo `ej37.cs` que pida al usuario 3 valores (un entero, un decimal y un booleano). Usa `try-catch` para cada conversión. Si alguna falla, muestra un error específico.

**Ejercicio 38: Archivo que Puede No Existir**
Crea un archivo `ej38.cs` que intente leer un archivo "datos.txt" con `File.ReadAllText`. Usa `try-catch` para capturar `FileNotFoundException` y mostrar "Archivo no encontrado".

**Ejercicio 39: Conexión Simulada a Base de Datos**
Crea un archivo `ej39.cs` con un procedimiento `void ConectarBD(string cadenaConexion)` que simule una conexión. Si la cadena es "error", lanza una excepción personalizada `Exception("Error de conexión")`. Usa `try-catch-finally` para mostrar "Conexión cerrada" en el `finally`.

**Ejercicio 40: Excepción Personalizada con Throw**
Crea un archivo `ej40.cs` con una función `void ValidarEdad(int edad)` que lance `ArgumentOutOfRangeException` si la edad es negativa o > 150. Usa `try-catch` para capturarla. Prueba con 25, -5 y 200.

---

### Bloque VI: Finally, Assertions y Excepciones Avanzadas (Ejercicios 41-50)

**Ejercicio 41: Finally con Recursos**
Crea un archivo `ej41.cs` con un procedimiento `void ProcesarDatos()` que simule usar un recurso (variable `bool recursoAbierto = true;`). En `try` procesa datos, en `finally` cierra el recurso (`recursoAbierto = false`). Prueba con datos válidos y con una excepción.

**Ejercicio 42: Múltiples Catch para Diferentes Errores**
Crea un archivo `ej42.cs` que pida un número y luego un índice. Primer `try`: intenta convertir el número. Segundo `try`: intenta acceder a un array de 5 posiciones con el índice. Usa catch separados para `FormatException`, `OverflowException` e `IndexOutOfRangeException`.

**Ejercicio 43: Throw con Mensaje Descriptivo**
Crea un archivo `ej43.cs` con una función `void Transferir(double saldo, double cantidad)` que lance `ArgumentException("Saldo insuficiente")` si cantidad > saldo. Lanza `ArgumentOutOfRangeException("Cantidad no válida")` si cantidad <= 0. Captura ambas en el Main.

**Ejercicio 44: Excepciones en un Bucle**
Crea un archivo `ej44.cs` que pida 5 números al usuario. Para cada uno, usa `try-catch` para convertirlo. Si falla uno, muestra error y sigue con el siguiente. Al final, muestra cuántos se introdujeron correctamente.

**Ejercicio 45: Asertión para Verificar Precondiciones**
Crea un archivo `ej45.cs` con una función `void CalcularPorcentaje(double total, double porcentaje)` que use `Debug.Assert(porcentaje >= 0 && porcentaje <= 100, "El porcentaje debe estar entre 0 y 100")` antes de calcular. Prueba con 50 y con -10.

**Ejercicio 46: Excepción en una Función Recursiva**
Crea un archivo `ej46.cs` con una función recursiva `int Fibonacci(int n)` que lance `ArgumentOutOfRangeException` si n < 0. Usa `try-catch` para capturar la excepción. Prueba con -1 y 10.

**Ejercicio 47: Cadena de Excepciones**
Crea un archivo `ej47.cs` con una función `void ProcesarPedido(int cantidad, bool enStock, double saldo)` que lance excepciones en cascada: si cantidad <= 0, `ArgumentException`; si !enStock, `InvalidOperationException`; si saldo insuficiente, `OutOfMemoryException`. Captura cada una por separado.

**Ejercicio 48: Try-Catch con Throw Original**
Crea un archivo `ej48.cs` con una función `void Dividir(int a, int b)` que lance `DivideByZeroException` si b=0. En el `catch`, haz `throw;` (sin parámetros) para relanzar la excepción original. Captura en el Main.

**Ejercicio 49: Validación Completa con Excepciones**
Crea un archivo `ej49.cs` con una función `void CrearUsuario(string nombre, string email, int edad)` que valide todo: nombre > 2 caracteres (`ArgumentException`), email contiene `@` (`FormatException`), edad > 0 y < 150 (`ArgumentOutOfRangeException`). Lanza la primera que falle.

**Ejercicio 50: Simulación de Proceso Crítico con Finally**
Crea un archivo `ej50.cs` con un procedimiento `void ProcesoCritico()` que simule 3 pasos: "Conectar", "Leer", "Procesar". Cada paso es una función que puede fallar. Usa `try` para el proceso, `catch` para cada tipo de error, y `finally` para "Desconectar siempre". Prueba tanto el caso de éxito como el de fallo.
