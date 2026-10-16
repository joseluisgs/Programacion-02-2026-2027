# Batería de ejercicios: programación modular y excepciones en C# 14

**Instrucciones:** Para cada ejercicio, implementa el código en C# usando Top-Level Statements. Puedes usar C# scripting (`dotnet run ejercicio.cs`) o crear un proyecto. Recuerda: **primero el diseño en papel, luego la codificación**.

---

### Bloque I: Funciones con valor de retorno (ejercicios 1-10)

**Ejercicio 1: Calculadora de Propinas**
Implementa una función `double CalcularPropina(double cuenta, double porcentaje)` que devuelva la propina. El programa pide la cuenta y el porcentaje. Muestra: "{cuenta}€ + {propina}€ = {total}€".

**Ejercicio 2: Conversor de Temperatura**
Implementa dos funciones: `double CentigradosAFahrenheit(double c)` y `double FahrenheitACentigrados(double f)`. El usuario elige el sentido de la conversión.

**Ejercicio 3: ¿Es un año bisiesto?**
Implementa una función `bool EsBisiesto(int anio)` que compruebe la regla del calendario: es bisiesto si es divisible entre 4, salvo que sea divisible entre 100 sin serlo entre 400. Prueba con 2024, 1900 y 2000.

**Ejercicio 4: Clasificador de IMC**
Implementa una función `double CalcularIMC(double peso, double altura)` y otra `string ClasificarIMC(double imc)`. Pide datos al usuario y muestra la clasificación.

**Ejercicio 5: Generador de Dados**
Implementa una función `int GenerarDado(int caras)` que devuelva una tirada aleatoria de un dado usando `Random` (prueba con 6 y con 20 caras). **Documenta** la función con XMLDoc (`/// <summary>`, `/// <param>`, `/// <returns>`).

**Ejercicio 6: Validador de Compra**
Implementa una función `void ValidarCompra(int cantidad, double precio)` que lance `ArgumentException` si la cantidad es 0 o negativa, y `ArgumentOutOfRangeException` si el precio supera los 10000€. Usa `try-catch` en el programa principal para capturar cada tipo de excepción por separado. Prueba con 3 compras diferentes.

**Ejercicio 7: Suma de Rango**
Implementa una función `int SumarRango(int inicio, int fin)` que devuelva la suma de todos los números comprendidos entre `inicio` y `fin` (ambos incluidos). Pide el rango y muestra el resultado.

**Ejercicio 8: Comparar Dos Números**
Implementa una función `string Comparar(int a, int b)` que devuelva "a es mayor", "b es mayor" o "iguales" según los valores. Prueba con varios pares de números.

**Ejercicio 9: Tabla de Multiplicar Modular**
Implementa un procedimiento `void MostrarTabla(int numero)` que muestre la tabla de multiplicar. Llámalo para el 5, el 7 y el 12.

**Ejercicio 10: Promedio de 3 Notas**
Implementa una función `double Promedio(double n1, double n2, double n3)` que devuelva la media. Pide 3 notas y muestra si ha aprobado (>=5).

---

### Bloque II: Procedimientos y parámetros (ejercicios 11-20)

**Ejercicio 11: Dibujar Rectángulo**
Implementa un procedimiento `void DibujarRectangulo(int ancho, int alto)` que dibuje un rectángulo de asteriscos con bucles `for` anidados. Llámalo 3 veces con tamaños diferentes.

**Ejercicio 12: Intercambiar con `ref`**
Implementa un procedimiento `void Intercambiar(ref int a, ref int b)` que intercambie dos valores. Declara `x=5, y=15`, intercámbialos y muestra antes/después.

**Ejercicio 13: División con `out`**
Implementa una función `bool Dividir(int a, int b, out int resultado)` que divida `a` entre `b`. Si `b` es 0, devuelve `false`. Prueba con 10/3 y 10/0.

**Ejercicio 14: Parámetros por Defecto**
Implementa un procedimiento `void Registrar(string nombre, string email, bool premium = false)` que muestre los datos. Llama con 2 y 3 argumentos para ver los valores por defecto.

**Ejercicio 15: Paso por Valor**
Implementa un procedimiento `void IntentarDoblar(int n)` que multiplique `n` por 2 y lo muestre por pantalla. Llámalo con el valor 5 y comprueba en el programa principal que la variable original **no ha cambiado**. Comenta por qué ocurre y cómo lo arreglaría el modificador `ref` (recuerda el Ejercicio 12).

**Ejercicio 16: Sobrecarga de Funciones**
Implementa dos funciones `int Area(int lado)` (cuadrado) y `int Area(int largo, int ancho)` (rectángulo). Prueba ambas.

**Ejercicio 17: Early Return en Validación**
Implementa una función `bool ValidarEdad(int edad)` que use Early Return: si es menor a 0 o mayor a 120, retorna `false`. Prueba con 25, -5 y 150.

**Ejercicio 18: Parámetro Nombrado**
Implementa un procedimiento `void MostrarInfo(string nombre, int edad, string ciudad)`. Llámala usando parámetros nombrados en orden desordenado: `MostrarInfo(ciudad: "Madrid", nombre: "Ana", edad: 25)`.

**Ejercicio 19: Recursividad: Suma de Dígitos**
Implementa una función recursiva `int SumaDigitos(int n)` que sume todos los dígitos de un número (ej: 123 → 1+2+3 = 6). Prueba con 456, 1000 y 9999.

**Ejercicio 20: Recursividad: Potencia**
Implementa una función recursiva `double Potencia(double baseNum, int exponente)` que calcule la potencia sin usar `Math.Pow`. Incluye la condición de parada. Prueba con 2^10, 3^0 y 5^3.

---

### Bloque III: Ámbito y diseño modular (ejercicios 21-28)

**Ejercicio 21: Variables Locales vs Globales**
Implementa un programa con una variable global `int contador = 0;` y un procedimiento `void Incrementar()` que la incremente. Llámalo 5 veces y muestra el contador. Comenta por qué las variables globales son peligrosas.

**Ejercicio 22: Early Return en Triángulo**
Implementa una función `bool EsTriangulo(int a, int b, int c)` con Early Return: si alguno de los lados es menor o igual que 0 → false; si la suma de dos lados no supera al tercero (`a + b <= c`, etc.) → false; si todo está bien → true.

**Ejercicio 23: Sobrecarga con Diferentes Tipos**
Implementa dos funciones `string Describir(int numero)` y `string Describir(string texto)`. La primera dice "Es un entero: {numero}", la segunda "Recibí el texto: {texto}". Prueba ambas.

**Ejercicio 24: Recursividad: Fibonacci**
Implementa una función recursiva `int Fibonacci(int n)` que devuelva el término n de la sucesión de Fibonacci. Prueba con n=5, n=10 y n=1.

**Ejercicio 25: Múltiples Parámetros por Defecto**
Implementa un procedimiento `void MostrarMensaje(string msg, string color = "blanco", int tamano = 12)` que muestre un mensaje con formato. Llama con 1, 2 y 3 argumentos.

**Ejercicio 26: Sobrecarga Simulada**
Implementa dos procedimientos `void CrearUsuario(string nombre)` y `void CrearUsuario(string nombre, string email)`. El primero muestra "Usuario: {nombre}", el segundo "Usuario: {nombre}, Email: {email}". Prueba ambos.

**Ejercicio 27: Factorial Recursivo vs Iterativo**
Implementa el factorial de dos formas: una función recursiva `int FactorialRecursivo(int n)` y una función iterativa `int FactorialIterativo(int n)` con un `for`. Prueba ambas con los mismos valores (5, 10, 0) y comprueba que dan el mismo resultado. Reflexiona: ¿cuál es más legible? ¿Cuál es más eficiente?

**Ejercicio 28: Early Return en Calificación**
Implementa una función `string Calificar(double nota)` con Early Return: < 0 → "Error", > 10 → "Error", < 5 → "Suspenso", < 7 → "Aprobado", < 9 → "Notable", → "Sobresaliente".

---

### Bloque IV: `ref`, `out` e `in` (ejercicios 29-36)

**Ejercicio 29: Ordenar Tres Números con `ref`**
Implementa un procedimiento `void Ordenar(ref int a, ref int b, ref int c)` que ordene tres números de menor a mayor. Prueba con (5, 2, 8).

**Ejercicio 30: Calcular Edad con `out`**
Implementa una función `void CalcularEdad(int anioNac, int mesNac, int diaNac, out int anios, out int meses)` que calcule la edad exacta. Usa `DateTime.Now`.

**Ejercicio 31: Cambio en Monedas con `out`**
Implementa un procedimiento `void CalcularCambio(double total, double pagado, out int m2, out int m1, out int m50, out int m20)` que calcule el cambio en monedas. **Usa `Debug.Assert`** para verificar que `pagado >= total` antes de calcular. Prueba con total=4.70€, pagado=10€.

**Ejercicio 32: Estadísticas con `ref`**
Implementa un procedimiento `void ActualizarStats(double valor, ref double suma, ref int count, ref double max, ref double min)` que actualice estadísticas con cada valor. Procesa 5 valores que pida al usuario.

**Ejercicio 33: Validación de Pago con `out`**
Implementa una función `bool ValidarPago(double total, double pagado, out string error)` que valide: que `total` sea positivo y que `pagado` sea mayor o igual que `total`. Si falla, `error` explica el problema.

**Ejercicio 34: Intercambiar con `ref`**
Implementa un procedimiento `void Swap(ref int a, ref int b)` que intercambie dos valores. Prueba con (10, 20).

**Ejercicio 35: Contar Pares e Impares con `out`**
Implementa un procedimiento `void ContarRango(int inicio, int fin, out int pares, out int impares)` que recorra el rango [inicio, fin] y cuente cuántos números pares e impares hay. Prueba con 1-10 y 20-25.

**Ejercicio 36: `in` para Solo Lectura**
Implementa una función `double CalcularDescuento(in double precio, in double porcentaje)` que calcule el descuento SIN modificar los originales. Intenta modificar `precio` dentro y comenta el error.

---

### Bloque V: Try-Catch (ejercicios 37-44)

**Ejercicio 37: Lectura Segura de Números**
Implementa un programa que pida un número al usuario. Usa `int.TryParse` en un bucle `while` hasta que introduzca un número válido.

**Ejercicio 38: División Segura**
Implementa un programa que pida dos números. Usa `try` para dividir. Si el divisor es 0, captura `DivideByZeroException`. Si el formato es incorrecto, captura `FormatException`.

**Ejercicio 39: Calculadora con Excepciones**
Implementa una calculadora que pida dos números y una operación (+, -, *, /). Cada operación es una función. La división usa `try-catch` para `DivideByZeroException`.

**Ejercicio 40: Excepción en Conversión**
Implementa un programa que pida un entero al usuario. Usa `try-catch` para capturar `FormatException` si no es un número válido.

**Ejercicio 41: Excepción Personalizada**
Implementa una función `void ValidarEdad(int edad)` que lance `ArgumentOutOfRangeException` si la edad es negativa o mayor a 150. Usa `try-catch` para capturarla.

**Ejercicio 42: Múltiples Catch**
Implementa un programa que pida un número y luego un índice. Usa catch separados para `FormatException` (si el número no es válido) y `OverflowException` (si es demasiado grande).

**Ejercicio 43: Conexión Simulada**
Implementa un procedimiento `void Conectar(string cadenaConexion)` que simule una conexión. Si la cadena es "error", lanza una excepción. Usa `try-catch-finally` para mostrar "Conexión cerrada" en el `finally`.

**Ejercicio 44: Throw con Mensaje Descriptivo**
Implementa una función `void Transferir(double saldo, double cantidad)` que lance `ArgumentException("Saldo insuficiente")` si cantidad > saldo. Lanza `ArgumentOutOfRangeException("Cantidad no válida")` si cantidad <= 0.

---

### Bloque VI: Finally y avanzado (ejercicios 45-50)

**Ejercicio 45: Finally con Recursos**
Implementa un procedimiento `void Procesar()` que simule usar un recurso (`bool recursoAbierto = true;`). En `try` procesa datos, en `finally` cierra el recurso. Prueba con datos válidos y con una excepción.

**Ejercicio 46: Excepciones en Bucle**
Implementa un programa que pida 5 números al usuario. Para cada uno, usa `try-catch` para convertirlo. Si falla uno, muestra error y sigue con el siguiente. Al final, muestra cuántos se introdujeron correctamente.

**Ejercicio 47: Aserción con Debug.Assert**
Implementa una función `void CalcularPorcentaje(double total, double porcentaje)` que use `Debug.Assert(porcentaje >= 0 && porcentaje <= 100, "El porcentaje debe estar entre 0 y 100")` antes de calcular.

**Ejercicio 48: Throw en Recursividad**
Implementa una función recursiva `int Fibonacci(int n)` que lance `ArgumentOutOfRangeException` si n < 0. Usa `try-catch` en el Main para capturar la excepción.

**Ejercicio 49: Validación Completa con Excepciones**
Implementa una función `void CrearPedido(int unidades, double precio, int dia)` que valide todo: unidades > 0 (`ArgumentException`), precio entre 0 y 10000 (`ArgumentOutOfRangeException`), día del mes entre 1 y 31 (`ArgumentOutOfRangeException`). Lanza la primera que falle.

**Ejercicio 50: Proceso Crítico con Finally**
Implementa un procedimiento `void ProcesoCritico()` que simule 3 pasos: "Conectar", "Leer", "Procesar". Usa `try` para el proceso, `catch` para cada tipo de error, y `finally` para "Desconectar siempre". Prueba tanto el caso de éxito como el de fallo.
