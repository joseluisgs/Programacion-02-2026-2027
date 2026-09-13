- [Práctica 1: Test de Conocimientos](#práctica-1-test-de-conocimientos)
  - [Bloque 1: Introducción y Fundamentos (Preguntas 1-8)](#bloque-1-introducción-y-fundamentos-preguntas-1-8)
  - [Bloque 2: Programación Estructurada (Preguntas 9-25)](#bloque-2-programación-estructurada-preguntas-9-25)
  - [Bloque 3: Programación Modular y Flujo Avanzado (Preguntas 26-45)](#bloque-3-programación-modular-y-flujo-avanzado-preguntas-26-45)
  - [Bloque 4: Control de Excepciones y Aserciones (Preguntas 46-50)](#bloque-4-control-de-excepciones-y-aserciones-preguntas-46-50)


# Práctica 1: Test de Conocimientos

**Instrucciones:** Lee atentamente cada pregunta y selecciona la opción que consideres correcta.

---

### Bloque 1: Introducción y Fundamentos (Preguntas 1-8)

1.  **¿Cuáles son los primeros paradigmas de programación que se deben aprender y dominar, ya que son la base para otros paradigmas más avanzados?**
    a) Programación Orientada a Objetos y Funcional
    b) Programación Estructurada y Modular
    c) Programación Lógica y Declarativa
    d) Programación Concurrente y Distribuida

2.  **En C# con Top-Level Statements, ¿dónde se escribe el código principal?**
    a) Dentro de un método Main explícito
    b) Directamente en el archivo, sin Main
    c) Dentro de una clase Program
    d) En un archivo separado

3.  **En C#, ¿qué tipo de dato se utiliza para almacenar números con decimales de alta precisión?**
    a) int
    b) float
    c) decimal
    d) double

4.  **¿Cuál es la regla de nomenclatura (convención de estilo) que se debe seguir en C# para declarar una constante?**
    a) camelCase
    b) snake_case
    c) MAYUSCULAS_CON_GUIONES
    d) PascalCase

5.  **La función de entrada de datos `Console.ReadLine()` en C# siempre devuelve un string. ¿Qué proceso es necesario para utilizar este dato como un número entero (int)?**
    a) Conversión Implícita
    b) Casting Explícito (e.g., int.Parse())
    c) Inferencia de Tipos (var)
    d) Paso por Referencia

6.  **¿Cuál es la característica principal de un lenguaje fuertemente tipado?**
    a) Los tipos de datos se asignan y cambian dinámicamente según la información
    b) El lenguaje realiza conversiones automáticas sin aviso
    c) Cada dato debe tener asignado explícitamente el tipo que le corresponde, aportando seguridad
    d) Permiten que las variables almacenen null por defecto

7.  **En la precedencia de operadores, ¿cuál es el operador lógico que tiene la mayor prioridad de evaluación?**
    a) `&&` (AND)
    b) `||` (OR)
    c) `!` (NOT)
    d) `+` (Suma)

8.  **¿Cuáles son las tres características esenciales de un algoritmo?**
    a) Lógico, rápido y reutilizable
    b) Imperativo, declarativo y modular
    c) Preciso, bien definido y finito
    d) Complejo, extenso y adaptable

### Bloque 2: Programación Estructurada (Preguntas 9-25)

9.  **Según el Teorema Fundamental de la Programación Estructurada, ¿cuáles son las tres estructuras de control básicas con las que se puede escribir cualquier programa propio?**
    a) Secuencial, Iterativa y GOTO
    b) Condicional, Recursiva y Modular
    c) Secuencial, Condicional e Iterativa
    d) Funciones, Procedimientos y Módulos

10.  **¿Qué característica define a un "programa propio" además de tener un único punto de entrada y salida?**
    a) Debe usar exclusivamente la estructura for
    b) No deben existir bucles sin fin
    c) Debe estar escrito en pseudocódigo
    d) Utiliza variables globales

11.  **¿Qué tipo de estructura condicional permite ejecutar un bloque de código si la condición se cumple y un bloque alternativo si la condición no se cumple?**
    a) Alternativa simple (if)
    b) Alternativa doble (if-else)
    c) Alternativa múltiple (switch)
    d) Secuencial

12.  **En sentencias if anidadas, si no se usan llaves para delimitar bloques, ¿con qué if se asocia la parte else?**
    a) Con el primer if de la estructura
    b) Con el if más lejano posible
    c) Con el if más cercano posible
    d) Con el if que contenga la condición booleana más simple

13.  **¿Qué principal ventaja ofrece la estructura switch frente a una larga cadena de if-else if-else?**
    a) Permite evaluar expresiones lógicas complejas
    b) Ofrece una alternativa más limpia y organizada para comparar una variable contra múltiples valores
    c) Permite saltar a cualquier parte del código usando GOTO
    d) Garantiza que el bucle se ejecute al menos una vez

14.  **En el contexto de los bucles, ¿qué se debe garantizar siempre para evitar un bucle infinito?**
    a) Que exista una variable de control
    b) Que exista una condición de parada
    c) Que el bucle sea definido (for)
    d) Que se utilicen solo operadores lógicos

15.  **¿Cuál es la principal diferencia entre los bucles indefinidos while y do-while?**
    a) while solo puede usarse con contadores, mientras que do-while usa centinelas
    b) do-while evalúa la condición después de la primera iteración, garantizando al menos una ejecución
    c) while evalúa la condición al final, mientras que do-while lo hace al principio
    d) do-while solo se usa para menús

16.  **¿Cuándo se recomienda usar bucles definidos (for)?**
    a) Cuando no se sabe cuántas iteraciones se necesitarán
    b) Cuando se utiliza una bandera para la condición de salida
    c) Cuando se conoce de antemano el número exacto de veces que se quiere repetir el código
    d) Cuando se necesita la estructura de repetición mínima de una vez

17.  **En una estructura for, ¿qué sucede con la variable de control?**
    a) Se puede modificar libremente dentro del bucle
    b) Su valor es siempre 0 al finalizar el bucle
    c) No se puede modificar dentro del bucle
    d) Se incrementa de dos en dos por defecto

18.  **¿Cuál de las siguientes es una de las tres formas típicas de controlar la ejecución de un bucle?**
    a) Bucles recursivos
    b) Bucles con centinela
    c) Bucles con if-else
    d) Bucles con return

19.  **¿Qué son las banderas (flags) en el control de bucles?**
    a) Variables que almacenan texto para la salida
    b) Variables que solo pueden tomar dos valores (normalmente booleanos) para controlar la condición de parada
    c) Variables que solo se usan en bucles for
    d) La condición lógica que se evalúa al inicio de un bucle

20.  **En un bucle controlado por centinela, ¿qué es el centinela?**
    a) El contador del bucle
    b) Un valor especial introducido por el usuario o detectado por el programa que indica la parada
    c) Una variable booleana que cambia de true a false
    d) La variable de acumulación de una suma o producto

21.  **¿Para qué es especialmente útil la técnica de bucles anidados?**
    a) Para manejar la recursividad
    b) Para el manejo de matrices
    c) Para simplificar el paso por referencia
    d) Para la validación de entradas con early return

22.  **¿Qué representa la estructura Secuencial?**
    a) Un bloque de código que se repite
    b) La ejecución de las instrucciones una detrás de la otra, en el orden en que están escritas
    c) La ejecución de un bloque de código u otro dependiendo de una condición
    d) La división del programa en módulos

23.  **¿Qué es la Iteración (o bucle)?**
    a) Un bloque de código que se repite mientras se cumpla una determinada condición
    b) La ejecución de sentencias una detrás de otra
    c) La evaluación de una expresión para decidir la siguiente sentencia a ejecutar
    d) El único punto de entrada de un programa

24.  **¿Por qué el Teorema Fundamental de la Programación Estructurada establece que el uso de la sentencia GOTO es innecesaria?**
    a) Porque GOTO complica el uso de bucles
    b) Porque las estructuras secuencial, condicional e iterativa son suficientes
    c) Porque GOTO solo funciona en lenguajes no tipados
    d) Porque solo se permite su uso en procedimientos

25.  **¿Qué se denomina bucle infinito?**
    a) La ejecución de la sentencia for
    b) Un bucle cuya condición de parada nunca se cumple
    c) El uso de la recursividad sin condición de fin
    d) El efecto de los bucles anidados

### Bloque 3: Programación Modular y Flujo Avanzado (Preguntas 26-45)

26.  **La programación modular se basa en la técnica de descomponer un problema grande en subproblemas más simples. ¿Cómo se conoce esta técnica?**
    a) Recursividad
    b) Ámbito Global
    c) Divide y Vencerás (DAC)
    d) Paso por Referencia

27.  **¿Cuál de las siguientes es una ventaja clave de la Programación Modular?**
    a) Aumenta la complejidad del diseño
    b) Permite que varios programadores trabajen en el mismo proyecto y reduce el tiempo de desarrollo
    c) Reduce la necesidad de la sentencia return
    d) Obliga al uso exclusivo de variables globales

28.  **¿Qué es un procedimiento en el contexto de la Programación Modular?**
    a) Un bloque de código que siempre devuelve un valor
    b) Un bloque de código que realiza una tarea específica y no devuelve ningún valor
    c) Una variable con ámbito global
    d) El punto de entrada principal del programa

29.  **¿Qué es un parámetro en la definición de una función o procedimiento?**
    a) Un valor real que se utiliza en la llamada
    b) La dirección de memoria de una variable
    c) Una variable que actúa como "marcador de posición" para los valores que se pasarán
    d) El resultado que devuelve la función

30.  **Cuando se pasa un argumento a un módulo por valor, ¿qué recibe la función?**
    a) La dirección de memoria de la variable original
    b) Una copia del dato original
    c) Un puntero
    d) El resultado de la operación

31.  **En C#, ¿qué palabra clave se utiliza para forzar el paso por referencia de un argumento?**
    a) out
    b) const
    c) ref
    d) var

32.  **¿Cuál es la principal razón de diseño para utilizar el paso por valor (comportamiento por defecto)?**
    a) Para modificar directamente la variable original
    b) Para garantizar seguridad y predictibilidad (inmunidad a efectos secundarios)
    c) Para devolver múltiples valores de una función
    d) Para ahorrar memoria al copiar grandes estructuras de datos

33.  **¿En qué escenario se recomienda el paso por referencia?**
    a) Cuando la función solo necesita devolver un valor único
    b) Cuando se necesita que un módulo modifique múltiples valores
    c) Para trabajar con datos simples como enteros o booleanos
    d) Cuando el parámetro es una constante

34.  **¿Qué determina el ámbito (o alcance) de una variable?**
    a) Si es de tipo entero o real
    b) La parte del programa donde puede ser accedida o modificada
    c) Si ha sido declarada con ref o out
    d) Su nombre y su valor inicial

35.  **¿Cuál es el principal inconveniente de abusar de las variables de ámbito global?**
    a) Hacen el código más fácil de mantener y depurar
    b) Complica el código, pudiendo derivar en código "spaghetti"
    c) Se restringe su uso a una sola función
    d) Requiere el uso de la sentencia return

36.  **¿Qué se conoce como efectos laterales en Programación Modular?**
    a) Las variables que se usan en bucles anidados
    b) La comunicación de datos entre algoritmos al margen de los canales habituales (parámetros y devolución de funciones)
    c) El uso de funciones de librería como Math.Sqrt()
    d) La definición de parámetros por defecto

37.  **Si una función se define con el mismo nombre que otra, pero acepta una lista de parámetros diferente (en tipo o número), ¿cómo se llama esta característica?**
    a) Encapsulamiento
    b) Herencia
    c) Sobrecarga de funciones
    d) Recursividad

38.  **¿Qué palabra clave se usa en C# para definir un parámetro que puede aceptar un número indeterminado de valores?**
    a) ref
    b) params
    c) out
    d) void

39.  **¿Cuál es el propósito del mecanismo de Parámetros de Salida (out)?**
    a) Devolver un valor usando la sentencia return
    b) Permitir que una función o procedimiento devuelva múltiples valores
    c) Establecer el valor por defecto de un parámetro
    d) Inicializar una variable antes de llamarla

40.  **¿Cuál es la diferencia clave entre ref y out al pasar variables a una función?**
    a) Con out, la variable se inicializa automáticamente a cero
    b) Con ref, la variable debe estar inicializada antes de pasarla; con out, no es necesario, pero debe asignarse dentro de la función
    c) ref se usa para procedimientos y out para funciones
    d) No hay diferencia, son sinónimos

41.  **¿Cuál es la principal ventaja de utilizar la técnica de Salida Anticipada (Early Return)?**
    a) Permite usar variables globales sin riesgo
    b) Permite evitar anidar estructuras if-else if-else complejas, aplanando la lógica y mejorando la legibilidad
    c) Garantiza que la función devuelva siempre un valor nulo
    d) Se aplica solo en estructuras while

42.  **La validación de entradas o condiciones fallidas al comienzo de una función que utiliza Early Return se conoce como:**
    a) Bucle controlado por centinela
    b) Guard Clauses (Cláusulas de Guardia)
    c) Sobrecarga de funciones
    d) Paso por valor

43.  **¿En qué contexto se aplica exclusivamente la técnica de Early Return?**
    a) Solo en el bloque Main {}
    b) Solo dentro de bucles for y while
    c) Dentro de funciones y procedimientos
    d) Exclusivamente en la estructura switch

44.  **¿Qué técnica consiste en que una función o procedimiento se llama a sí mismo de forma repetida?**
    a) Sobrecarga
    b) Iteración
    c) Modularidad
    d) Recursividad

45.  **¿Qué debe incluir obligatoriamente un problema resuelto recursivamente para evitar un bucle infinito?**
    a) Una variable de tipo bool
    b) Una condición de parada o de fin
    c) Un parámetro por referencia
    d) Un bloque Main

### Bloque 4: Control de Excepciones y Aserciones (Preguntas 46-50)

46.  **En C#, la técnica de Control de Excepciones está basada en una clase fundamental de la cual heredan todas las demás. ¿Cuál es esta clase base?**
    a) SystemError
    b) Throwable
    c) Exception
    d) Error

47.  **Las excepciones en C# son catalogadas como no requeridas (unchecked). ¿Cuál es la principal implicación de este diseño para el desarrollador?**
    a) El compilador obliga a manejar todas las excepciones con try-catch
    b) Se debe usar la sentencia `assert` en lugar de `throw`
    c) El código es más limpio, pero la responsabilidad de manejar los errores recae por completo en el desarrollador
    d) Permite que las excepciones se propaguen automáticamente sin detener el programa

48.  **¿Qué bloque dentro de la estructura de manejo de excepciones (try, catch, finally) se ejecuta siempre, sin importar si se lanzó o capturó una excepción?**
    a) try
    b) catch
    c) finally
    d) throw

49.  **¿Cuál es la función principal de la palabra clave throw en el manejo de excepciones?**
    a) Capturar y gestionar una excepción en el bloque catch
    b) Verificar que una condición sea verdadera durante la depuración
    c) Lanzar una excepción de forma explícita para definir errores de lógica de negocio
    d) Marcar un bloque de código como potencialmente riesgoso

50.  **La aserción (assert) es una herramienta que lanza una AssertionException si una condición es falsa. ¿Para qué se utiliza principalmente esta herramienta?**
    a) Para manejar la entrada de datos incorrecta por parte del usuario
    b) Para verificar supuestos sobre el estado interno del programa durante los procesos de depuración y prueba
    c) Para asegurar el cierre de conexiones en el bloque finally
    d) Para forzar la conversión de tipos (casting) de manera segura
