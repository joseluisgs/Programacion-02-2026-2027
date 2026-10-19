# Preparación del examen

**Instrucciones:** Para cada ejercicio, implementa el código en C# usando Top-Level Statements. Puedes usar C# scripting (`dotnet run ejercicio.cs`) o crear un proyecto. Recuerda: **primero el diseño en papel, luego la codificación**.

---

**Ejercicio 1: Simulador de vuelo (piloto automático)**

Nos piden simular el funcionamiento de un piloto automático durante 5 minutos usando programación estructurada y modular.

**Módulos a implementar**

| Módulo | Descripción del módulo y regla de implementación | Contrato clave para la firma |
|--------|--------------------------------------------------|------------------------------|
| `altitud` | Simula la lectura del sensor. Regla: introduce una desviación aleatoria de hasta ±2.0 metros sobre la altitud recibida. | Recibe el valor actual y devuelve el valor (por valor) de la lectura simulada. |
| `velocidad` | Simula la lectura y actualización del sensor. Regla: aplica una desviación aleatoria de hasta ±2.0 km/h al valor de velocidad. | Recibe el valor actual para ser modificado en el origen y no devuelve valor. |
| `aumentarAltitud` | Incrementa la altitud en 1.0 metro. | Recibe el valor actual y devuelve el nuevo valor. |
| `disminuirAltitud` | Reduce la altitud en 1.0 metro. | Recibe el valor actual y devuelve el nuevo valor. |
| `aumentarVelocidad` | Incrementa la velocidad en 1.0 km/h. | Recibe el valor actual para ser modificado en el origen y no devuelve valor. |
| `disminuirVelocidad` | Reduce la velocidad en 1.0 km/h. | Recibe el valor actual para ser modificado en el origen y no devuelve valor. |
| `espera` | Pausa la simulación durante un número determinado de segundos. | No recibe ni devuelve valor. |
| `comprobarFallo` | Simula un fallo crítico: el módulo debe lanzar un error en tiempo de ejecución de tipo `SystemException` si un factor aleatorio es menor que 0.1 (definido en el sistema). | No recibe ni devuelve valor. |
| `leerParametro` | Lee la información de entrada asegurando que no hay problemas en su procesamiento y que es válida. Además, debe estar dentro de los parámetros objetivos. | Devuelve el valor de la información leída y deja indicado, además, el número de intentos realizados hasta obtener un valor válido. Usa un mensaje para indicar qué se requiere y estar dentro de los parámetros válidos (inferior y superior). |

**Funcionamiento principal del sistema de pilotaje automático**

- Partimos de una altitud y velocidad iniciales de 1000.0 m y 800.0 km/h; son conocidas y propias del sistema.
- Usando el módulo `leerParametro`, se solicitan y validan la altitud objetivo y la velocidad objetivo al comienzo, informando de cuántos intentos hizo falta para fijar cada objetivo.
  - Si el número de intentos realizados en la toma de un parámetro supera 10, se considera un fallo del sistema: se sale del piloto automático y se vuelve al control manual informando del error.
  - La altitud objetivo debe estar en un intervalo del 25% superior e inferior a la inicial para ser válida.
  - La velocidad objetivo debe estar en un intervalo del 15% superior e inferior de la inicial para ser válida.
- La simulación durará 5 minutos (definido en el sistema), comprobando los parámetros de vuelo cada 2 segundos (definido en el sistema).
- Durante la simulación, comprobaremos si hay fallo. Tenemos que mantener velocidad y altitud rectificando los parámetros que hagan falta usando los módulos desarrollados cuando sea necesario. Es crucial ser robustos en el caso de que surja el fallo inesperado, el cual provoca la vuelta al control manual informando de este error.
- Los módulos indicados en la tabla son obligatorios, con sus contratos tal como se describen, y el algoritmo principal debe cumplir el funcionamiento descrito. Si se desea, el simulador puede descomponerse en módulos adicionales.

---

**Ejercicio 2: La batalla de Piedra, Papel o Tijera**

Te embarcas en un torneo clandestino de Piedra, Papel o Tijera en las cloacas de la ciudad. El guardián de la puerta te pide tu nombre: será el que grite el público cuando ganes... o el que susurre cuando caigas.

En el centro de la arena hay una mesa y un rival que nunca se cansa. Cuatro caminos se abren ante ti: desafiarle a un combate normal (1), retar al temido Jefe Final (2), consultar las probabilidades de cada duelo (3) o retirarte con dignidad (4). Elige tu camino cada vez que vuelvas a la mesa; si el guardián no entiende tu elección, te obligará a repetirla.

En un combate normal sacas tu figura —en la arena cada una tiene su nombre propio y su rango: 1 es Piedra, 2 es Papel y 3 es Tijera; no hay más en este juego ancestral—, y el rival saca la suya al azar, sin trampas... por ahora. Manda la vieja ley: la piedra rompe la tijera, el papel envuelve la piedra y la tijera corta el papel. Un empate es un choque sin vencedor: nadie suma y las figuras vuelven a la mesa. El combate se decide al mejor de tres: quien primero se lleve dos rondas gana el duelo, y cada duelo ganado añade una victoria más a tu historial. Ojo con la ansiedad: si en la mesa tecleas algo que no sea 1, 2 o 3, la jugada no cuenta y tendrás que elegir de nuevo.

El Jefe Final es otra historia. El viejo maestro no pierde el tiempo con novatos: necesitas al menos cinco victorias en tu historial para que siquiera te mire a los ojos; si no, te mandará a entrenar con una sonrisa. Con el acceso abierto, la batalla es al mejor de cinco —tres rondas a tu favor—. Y ahí está lo feo: el maestro es un sinvergüenza y hace trampa, dos de cada tres veces saca exactamente la figura que gana a la tuya. Si lo derrotas, te colmará de halagos; si te vence, el castigo es doble: se queda con dos de tus duramente ganadas victorias.

Cuentan en la barra del bar que las probabilidades de un combate normal se reparten a partes iguales entre victoria, empate y derrota. Las del Jefe solo las cuenta quien ya se ha enfrentado al maestro cinco veces.

El público espera. Te susurra un veterano que los grandes campeones de este torneo tienen un gran aliado: el SRP —cada guerrero, una sola misión—, y que donde los novatos ven un amasijo de golpes, los maestros ven ejércitos pequeños y bien organizados. Lo tiene claro: en este combate, la modularización marca el camino a la victoria. Que la batalla quede tan bien contada en tu código como en la arena.
