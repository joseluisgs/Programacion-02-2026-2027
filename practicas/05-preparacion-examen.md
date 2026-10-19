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
  - La altitud objetivo debe estar en un intervalo del 25% superior e inferior a la inicial para ser válida.
  - La velocidad objetivo debe estar en un intervalo del 15% superior e inferior de la inicial para ser válida.
- La simulación durará 5 minutos (definido en el sistema), comprobando los parámetros de vuelo cada 2 segundos (definido en el sistema).
- Durante la simulación, comprobaremos si hay fallo. Tenemos que mantener velocidad y altitud rectificando los parámetros que hagan falta usando los módulos desarrollados cuando sea necesario. Es crucial ser robustos en el caso de que surja el fallo inesperado, el cual provoca la vuelta al control manual informando de este error.
