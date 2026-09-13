# Batería de Ejercicios: Programación Modular y Excepciones en C# 14

**Instrucciones:** Para cada ejercicio, escribe el código completo en C# usando Top-Level Statements dentro de un archivo `.cs`. Ejecuta cada ejercicio con `dotnet run tu_ejercicio.cs`. Recuerda: **primero el diseño en papel, luego la codificación**.

---

### Bloque I: Funciones con Valor de Retorno (Ejercicios 1-10)

**Ejercicio 1: Calculadora de Propinas**
Crea un archivo `ej01.cs` con `double CalcularPropina(double cuenta, double porcentaje)`. Pide datos y muestra: "{cuenta}€ + {propina}€ = {total}€".

**Ejercicio 2: Conversor de Temperatura**
Crea un archivo `ej02.cs` con `double CentigradosAFahrenheit(double c)` y `double FahrenheitACentigrados(double f)`. El usuario elige el sentido.

**Ejercicio 3: ¿Es Palíndromo?**
Crea un archivo `ej03.cs` con `bool EsPalindromo(string texto)`. Prueba con "oso", "reconocer", "hola".

**Ejercicio 4: Clasificador de IMC**
Crea un archivo `ej04.cs` con `double CalcularIMC(double peso, double altura)` y `string ClasificarIMC(double imc)`.

**Ejercicio 5: Generador de Contraseña**
Crea un archivo `ej05.cs` con `string GenerarContraseña(int longitud)` usando `Random`. Mayúsculas, minúsculas y números.

**Ejercicio 6: Validador de Email**
Crea un archivo `ej06.cs` con `bool ValidarEmail(string email)`: debe contener `@` y `.`.

**Ejercicio 7: Contador de Palabras**
Crea un archivo `ej07.cs` con `int ContarPalabras(string frase)`. Pide una frase y muestra cuántas palabras tiene.

**Ejercicio 8: Texto Más Largo**
Crea un archivo `ej08.cs` con `string MasLargo(string a, string b)`. Devuelve el más largo.

**Ejercicio 9: Tabla de Multiplicar Modular**
Crea un archivo `ej09.cs` con `void MostrarTabla(int numero)`. Llámala para el 5, el 7 y el 12.

**Ejercicio 10: Promedio de 3 Notas**
Crea un archivo `ej10.cs` con `double Promedio(double n1, double n2, double n3)`. Pide notas y muestra si ha aprobado.

---

### Bloque II: Procedimientos y Parámetros (Ejercicios 11-20)

**Ejercicio 11: Mostrar con Recuadro**
Crea un archivo `ej11.cs` con `void MostrarConRecuadro(string texto)`. Llámalo 3 veces con textos diferentes.

**Ejercicio 12: Intercambiar con `ref`**
Crea un archivo `ej12.cs` con `void Intercambiar(ref int a, ref int b)`. Declara `x=5, y=15`. Muestra antes/después.

**Ejercicio 13: División con `out`**
Crea un archivo `ej13.cs` con `bool Dividir(int a, int b, out int resultado)`. Si b=0, devuelve false. Prueba con 10/3 y 10/0.

**Ejercicio 14: Parámetros por Defecto**
Crea un archivo `ej14.cs` con `void Registrar(string nombre, string email, bool premium = false)`. Llama con 2 y 3 argumentos.

**Ejercicio 15: `params` para Suma**
Crea un archivo `ej15.cs` con `int SumarTodos(params int[] numeros)`. Llama con 3, 5 y 2 argumentos.

**Ejercicio 16: Sobrecarga de Funciones**
Crea un archivo `ej16.cs` con `int Area(int lado)` y `int Area(int largo, int ancho)`. Prueba ambas.

**Ejercicio 17: Early Return**
Crea un archivo `ej17.cs` con `bool ValidarEdad(int edad)`: < 0 o > 120 → false. Prueba con 25, -5, 150.

**Ejercicio 18: Parámetro Nombrado**
Crea un archivo `ej18.cs` con `void MostrarInfo(string nombre, int edad, string ciudad)`. Llama en orden desordenado con `nombre:`, `ciudad:`, `edad:`.

**Ejercicio 19: Recursividad: Suma de Dígitos**
Crea un archivo `ej19.cs` con `int SumaDigitos(int n)` recursiva. Prueba con 123 → 6.

**Ejercicio 20: Recursividad: Potencia**
Crea un archivo `ej20.cs` con `double Potencia(double b, int e)` recursiva. Prueba con 2^10, 3^0.

---

### Bloque III: Ámbito y Diseño (Ejercicios 21-28)

**Ejercicio 21: Variables Globales**
Crea un archivo `ej21.cs` con `int contador = 0;` global y `void Incrementar()`. Llámalo 5 veces. Comenta por qué las globales son peligrosas.

**Ejercicio 22: Early Return en Email**
Crea un archivo `ej22.cs` con `bool ValidarEmail(string email)` con Early Return: null → false, sin `@` → false, sin `.` → false.

**Ejercicio 23: Sobrecarga con Diferentes Tipos**
Crea un archivo `ej23.cs` con `string Describir(int n)` y `string Describir(string s)`. Prueba ambas.

**Ejercicio 24: Recursividad: Fibonacci**
Crea un archivo `ej24.cs` con `int Fibonacci(int n)` recursiva. Prueba con n=5, n=10.

**Ejercicio 25: Múltiples Parámetros por Defecto**
Crea un archivo `ej25.cs` con `void MostrarMensaje(string msg, string color = "blanco", int tamano = 12)`. Llama con 1, 2 y 3 argumentos.

**Ejercicio 26: Sobrecarga Simulada**
Crea un archivo `ej26.cs` con `void CrearUsuario(string nombre)` y `void CrearUsuario(string nombre, string email)`. Prueba ambas.

**Ejercicio 27: Recursividad: Regresión**
Crea un archivo `ej27.cs` con `void ContarRegresivo(int n)` que imprima n, n-1... hasta 1. Prueba con 5.

**Ejercicio 28: Early Return en Calificación**
Crea un archivo `ej28.cs` con `string Calificar(double nota)` con Early Return: < 0 → "Error", > 10 → "Error", < 5 → "Suspenso", < 7 → "Aprobado", < 9 → "Notable", → "Sobresaliente".

---

### Bloque IV: `ref`, `out` e `in` (Ejercicios 29-36)

**Ejercicio 29: Ordenar con `ref`**
Crea un archivo `ej29.cs` con `void Ordenar(ref int a, ref int b, ref int c)`. Prueba con (5, 2, 8).

**Ejercicio 30: Calcular Edad con `out`**
Crea un archivo `ej30.cs` con `void CalcularEdad(int anioNac, int mesNac, int diaNac, out int anios, out int meses)`. Usa DateTime.Now.

**Ejercicio 31: Cambio con `out`**
Crea un archivo `ej31.cs` con `void CalcularCambio(double total, double pagado, out int m2, out int m1, out int m50)`. Prueba con 4.70€ pagando 10€.

**Ejercicio 32: Estadísticas con `ref`**
Crea un archivo `ej32.cs` con `void ActualizarStats(double valor, ref double suma, ref int count, ref double max, ref double min)`. Procesa 5 valores.

**Ejercicio 33: Validación con `out`**
Crea un archivo `ej33.cs` con `bool Validar(string nombre, string pass, out string error)`. Si nombre < 2 chars o pass < 6, error explica qué falla.

**Ejercicio 34: Swap con `ref`**
Crea un archivo `ej34.cs` con `void Swap(ref int a, ref int b)`. Prueba con (10, 20).

**Ejercicio 35: Contar Vocales con `out`**
Crea un archivo `ej35.cs` con `void ContarVocales(string texto, out int vocales, out int consonantes)`. Prueba con "Hola Mundo".

**Ejercicio 36: `in` para Constantes**
Crea un archivo `ej36.cs` con `double CalcularDescuento(in double precio, in double porcentaje)`. Intenta modificar `precio` dentro.

---

### Bloque V: Try-Catch (Ejercicios 37-44)

**Ejercicio 37: Lectura Segura**
Crea un archivo `ej37.cs` que pida un número con `int.TryParse` en `while` hasta que sea válido.

**Ejercicio 38: División Segura**
Crea un archivo `ej38.cs` que pida dos números. Usa `try` para dividir. Captura `DivideByZeroException` y `FormatException`.

**Ejercicio 39: Calculadora con Excepciones**
Crea un archivo `ej39.cs` con calculadora (+, -, *, /). Cada operación es función. División con `try-catch`.

**Ejercicio 40: Excepción en Conversión**
Crea un archivo `ej40.cs` que pida un entero. Usa `try-catch` para capturar `FormatException` si no es un número.

**Ejercicio 41: Excepción Personalizada**
Crea un archivo `ej41.cs` con `void ValidarEdad(int edad)` que lance `ArgumentOutOfRangeException` si < 0 o > 150.

**Ejercicio 42: Múltiples Catch**
Crea un archivo `ej42.cs` que pida un número y un índice. Catch separados para `FormatException`, `OverflowException`.

**Ejercicio 43: Conexión Simulada**
Crea un archivo `ej43.cs` con `void Conectar(string conn)` que lance excepción si conn="error". Usa `try-catch-finally`.

**Ejercicio 44: Throw con Mensaje**
Crea un archivo `ej44.cs` con `void Transferir(double saldo, double cant)` que lance `ArgumentException("Saldo insuficiente")` si cant > saldo.

---

### Bloque VI: Finally y Avanzado (Ejercicios 45-50)

**Ejercicio 45: Finally con Recursos**
Crea un archivo `ej45.cs` con `void Procesar()` que simule un recurso. En `finally` cierra siempre. Prueba con éxito y con excepción.

**Ejercicio 46: Excepciones en Bucle**
Crea un archivo `ej46.cs` que pida 5 números. Para cada uno `try-catch`. Si falla uno, sigue con el siguiente.

**Ejercicio 47: Asertión**
Crea un archivo `ej47.cs` con `void CalcularPorcentaje(double total, double porc)` que use `Debug.Assert(porc >= 0 && porc <= 100)`.

**Ejercicio 48: Throw en Recursividad**
Crea un archivo `ej48.cs` con `int Fibonacci(int n)` que lance `ArgumentOutOfRangeException` si n < 0.

**Ejercicio 49: Validación Completa**
Crea un archivo `ej49.cs` con `void CrearUsuario(string nombre, string email, int edad)` que valide todo y lance la primera excepción que falle.

**Ejercicio 50: Proceso Crítico**
Crea un archivo `ej50.cs` con `void ProcesoCritico()` que simule 3 pasos. Usa `try-catch-finally` para "Desconectar siempre".
