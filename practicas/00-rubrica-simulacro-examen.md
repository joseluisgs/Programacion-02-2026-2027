# Rúbrica de autocorrección guiada: simulacro de examen (UD02)

Esta rúbrica no sirve para copiarte la nota: sirve para **aprender a corregirte**. Un programador profesional dedica más tiempo a corregir que a escribir, y esa habilidad se entrena. La nota que te salga hoy es tu punto de partida, no tu destino.

**Qué necesitas:** tu código, la solución oficial (`ejemplos/07-modular-ejemplo-simulador.cs` y `ejemplos/05-modular-piedra-papel-tijera.cs`) y el enunciado, lado a lado.

---

## El método de corrección (hazlo en este orden)

1. **Ejecuta tu programa tal cual está**, sin tocar nada. ¿Arranca? ¿Se entiende lo que pide? ¿Muere en algún punto? Apunta los sustos en un papel: eso es material de oro.
2. **Corrige por bloques, no de arriba abajo.** Recorre los criterios en orden. Un criterio **o está o no está**: no hay "más o menos" (si lo has hecho a medias, cuenta como no hecho y anota la causa).
3. **Antes de mirar la solución, escribe tú la causa del fallo**: "he usado `Parse` en vez de `TryParse`", "he olvidado asignar el `out`". El valor del aprendizaje está en la causa, no en el parche.
4. **Solo después, compara con la solución oficial** y aplica el arreglo.
5. **Aplica las penalizaciones al final**, una sola vez cada una, y sigue: un fallo es información, no un castigo. Si llevas más de 10 minutos atascado en un criterio, salta al siguiente y vuelve al final.

---

## Las reglas para puntuarse (apréndelas: es el oficio)

Para que tu nota sea honesta y útil, calcula con estas cuatro reglas:

1. **Criterio completo, criterio entero.** Un criterio se da **entero** o **no se da**. Si lo has hecho "a medias", cuenta como no hecho: apunta la causa en tu lista de errores y sigue. No hay medias puntas.
2. **Suma por bloques, luego por ejercicio.** Primero los puntos de cada bloque (A + B + C + D); esa suma es la nota del ejercicio (máximo 10).
3. **Las penalizaciones se restan al final de cada ejercicio**, una sola vez por fallo, y **un ejercicio nunca baja de 0**.
4. **Decimales a secas.** 8,75 es una nota tan válida como 9: no redondees a favor tuyo.

**Ejemplo resuelto — así se puntúa (el caso de "Ana"):**

Ana corrige su Ejercicio 1 y va anotando qué bloques le dan y qué bloques no:

| Bloque | Qué le ha fallado | Puntos que SÍ le dan |
|--------|-------------------|----------------------|
| A | `leerParametro` no devuelve los intentos | 3 de 4 |
| B | La salida por >10 intentos no llega al control manual | 2,5 de 3 |
| C | Su código tiene dos `Random` | 1,75 de 2 |
| D | — (todo correcto) | 1 de 1 |

Subtotal: **8,25**. Después aplica las penalizaciones del ejercicio: Random en funciones (−0,5) y salida por intentos sin control manual (−0,5) → **nota del Ejercicio 1: 7,25**.

En el Ejercicio 2, Ana suma 8 (falla los empates, la trampa del jefe y el historial por valor) y le restan −1,5 → **6,5**.

**Sus dos notas: 7,25 en el Ejercicio 1 → Notable; 6,5 en el Ejercicio 2 → Suficiente.** Cada ejercicio tiene su propia nota y su propia interpretación: no se suman ni se promedian. Aquí las dos le dicen cosas distintas: el simulador lo tiene casi; la batalla necesita repasar el diseño (el `ref` del historial y la trampa). Fíjate también en esto:

- Un mismo error le ha costado **dos veces**: pierde el punto del criterio (no lo hizo bien) y además la penalización (mal hábito: el azar repartido por funciones). No es un doble castigo arbitrario: es el precio de la mala práctica.

---

# Ejercicio 1: Simulador de vuelo — 10 puntos

*De qué va: montar un piloto automático con módulos de contratos exactos: unos devuelven valores, otros modifican en el origen, otro deja un resultado "por fuera" (`out`) y otro puede reventar con una excepción.*

## Bloque A: Contratos de los módulos (4 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| `altitud` **devuelve** la lectura desviada (hasta ±2.0) sin tocar el original | Abre tu `altitud` y la oficial: ¿tu versión tiene `return` y no modifica su parámetro? Ejecuta la simulación: la altitud debe "fluctuar" un poco en cada ciclo (el sensor miente), no subir en línea recta. | 0,5 |
| `velocidad` **modifica en el origen** (hasta ±2.0) y no devuelve nada | En tu código: ¿el parámetro es de referencia y la función no tiene `return`? En ejecución, la velocidad debe cambiar aunque la función no devuelva nada. | 0,5 |
| `aumentarAltitud` / `disminuirAltitud`: ±1.0 metro **devolviendo** el nuevo valor | Comparación de código con la oficial: una suma o resta de 1.0 y un `return`. | 0,5 |
| `aumentarVelocidad` / `disminuirVelocidad`: ±1.0 km/h **en el origen** | Comparación de código: referencia sí, retorno no. Fíjate de no haberlas copiado "a estilo altitud": cada una tiene su contrato. | 0,5 |
| `espera`: pausa sin parámetros ni retorno | Lectura de código + ejecución: entre ciclo y ciclo debe haber **un segundo real de pausa**. Cronometra: si los 5 minutos pasan en un destello, falta la pausa. | 0,5 |
| `comprobarFallo`: lanza `SystemException` si un factor aleatorio es menor que 0.1 | Lectura de código (¿existe el `throw`?) + ejecución: deja correr la simulación; con un 10% por ciclo, en un par de minutos salta el fallo. | 0,5 |
| `leerParametro`: devuelve el valor **y deja indicado** los intentos; valida rango y mensaje | Ejecución: mete "abc", luego un número fuera de rango (p. ej. 5000 para la altitud), luego uno válido. ¿Te pide el rango? ¿Te dice cuántos intentos hizo falta? ¿Y tu versión devuelve el número de intentos por algún lado? | 1 |

## Bloque B: Algoritmo principal (3 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| Constantes para todo lo "definido en el sistema" | Busca números sueltos en el algoritmo (Ctrl+F: `300`, `2`, `0.1`, `25`...). Si el `do-while` compara contra `300` en vez de contra una constante, falla. | 0,5 |
| Los dos objetivos se piden con `leerParametro` informando los intentos | Ejecución: el programa debe pedir altitud y velocidad y decir "tras N intento(s)" en cada una. | 0,5 |
| Rangos correctos: altitud 750–1250 m, velocidad 680–920 km/h | Ejecución: prueba los bordes (750 y 1250 valen; 749 y 1251 no). Lo mismo con 680/920. | 0,5 |
| `do-while` de simulación: al menos un ciclo, 5 minutos, chequeo cada 2 s **con pausa real** | Ejecución cronometrada: la simulación debe avanzar de 2 en 2 segundos de verdad. Si termina al instante, no hay pausa; si no entra nunca, la condición del bucle está mal. | 0,5 |
| Rectificación hacia el objetivo con los módulos, y **los dos sensores funcionan igual**: la desviación (hasta ±2) entra en su valor — altitud con `return`, velocidad con `ref` | Ejecución: pon objetivo 1100 y observa: altitud Y velocidad avanzan hacia su objetivo con sacudidas de hasta ±2 por ciclo; ninguna sube en línea recta. Si una "baila" y la otra no, los sensores no son simétricos. | 0,5 |
| Más de 10 intentos en un parámetro → **fallo del sistema** → control manual | Ejecución: mete 11 números fuera de rango seguidos y luego uno válido. Debe aparecer el mensaje de fallo crítico **y la vuelta a control manual**, sin simular nada. | 0,5 |

## Bloque C: Robustez y estilo (2 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| `try-catch` de `SystemException`: informa y vuelve a control manual sin morir | Ejecución: deja correr hasta que salte el fallo. El programa debe imprimir el error, la vuelta a control manual y el informe final. Si muere con excepción sin capturar, falla. | 0,75 |
| Un **solo** `Random` en todo el programa | Ctrl+F `new Random` (o `Random rnd`): debe aparecer **una sola vez**, al principio. | 0,25 |
| Todos los módulos comentados explicando su funcionamiento | Lectura: cada módulo tiene un comentario que explica **qué hace y por qué**, no solo su nombre. | 0,5 |
| Si descomponaste más (dueño de la simulación + ciclo): responsabilidades separadas | Lectura: ¿una función es dueña del bucle/reloj y otra hace un solo ciclo? Compara la estructura con la oficial (no tiene por qué ser idéntica, pero debe verse la separación). | 0,5 |

## Bloque D: Ejecución (1 punto)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| Compila y arranca | `dotnet run tu_archivo.cs`. Cero errores. | 0,25 |
| Las dos rutas de fallo (entrada y vuelo) informan del desenlace | Ejecuta la ruta de los 11 intentos **y** deja correr una simulación hasta el fallo aleatorio. Ambas deben terminar con mensajes claros, no en silencio. | 0,25 |
| Entradas inválidas no rompen el programa | Mete letras donde pide números: debe avisar y volver a pedir, no reventar. | 0,25 |
| Informe final coherente según cómo terminó | Fallo → "terminada por fallo"; si completa los 5 minutos → mensaje de completada. ¿Tu programa distingue los dos casos? | 0,25 |

---

# Ejercicio 2: La batalla de Piedra, Papel o Tijera — 10 puntos

*De qué va: leer entre líneas un enunciado de cuento y convertirlo en un torneo bien construido: menú, combates, un jefe tramposo y un historial que debe sobrevivir de una función a otra.*

## Bloque A: Entradas y menú (2 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| El nombre se pide en bucle hasta que no es nulo ni vacío | Ejecución: pulsa Enter a la fuerza y escribe "     " (solo espacios). Debe rechazarlos y volver a pedir. Si acepta un nombre vacío o el programa muere, falla. | 0,75 |
| Menú de 4 opciones que se repite hasta pedir salir; opción inválida avisa | Ejecución: elige "9". Debe decirte que no vale y volver al menú. La única forma de terminar debe ser la opción de retirarse. | 0,5 |
| Lecturas numéricas sin excepciones al meter texto (`TryParse`) | Ejecución: escribe "abc" donde pide un número. Debe avisar y pedir de nuevo, sin reventar. | 0,25 |
| Las figuras tienen nombre y rango (enum o su equivalente) | Lectura: ¿existe un tipo/constante que represente las figuras con sus valores 1, 2, 3, en vez de números sueltos por todo el código? | 0,5 |

## Bloque B: Combate normal (3 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| Best of 3: termina cuando alguien suma 2 rondas | Ejecución: juega un combate completo. Debe acabarse solo al llegar a 2 rondas de un lado, y no antes. | 0,75 |
| Los empates **no suman** y la ronda se repite | Ejecución: juega hasta ver un empate y mira el marcador. Si tras un empate alguien suma, falla. | 0,75 |
| Reglas: piedra rompe tijera, papel envuelve piedra, tijera corta papel | Ejecución: juega piedra varias veces. Cuando el rival saque tijera debes ganar; cuando saque papel, perder. | 0,75 |
| Ganar el duelo suma +1 a las victorias totales | Ejecución: gana un combate y mira el mensaje de victorias totales: debe decir 1 (y sumar en el siguiente). | 0,75 |

## Bloque C: Jefe Final (3 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| Con menos de 5 victorias no se enfrenta: mensaje y de vuelta al menú | Ejecución con 0 victorias: opción 2 → mensaje de "aún no estás preparado" **sin jugar ninguna ronda**. | 0,75 |
| Best of 5: el primero en 3 rondas | Lectura del código de la batalla final: la condición del bucle debe ser 3, no 2. | 0,5 |
| La trampa: 2 de cada 3 rondas saca la figura que gana a la del jugador | Lectura: ¿el jefe decide con probabilidad (2 de 3) la figura que te gana, o saca azar como el normal? Compara con la oficial si dudas del truco del círculo. | 0,75 |
| Perder resta 2 victorias; ganar da premio | Lectura del código + (si puedes) forzar una derrota con el jefe: el historial debe bajar en 2. | 0,5 |
| Probabilidades: las normales siempre; las del jefe solo con 5 victorias | Ejecución: opción 3 con 0 victorias (mensaje de no listo) y, si llegas, con 5 o más (muestra las del jefe). | 0,25 |

## Bloque D: Diseño (2 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| SRP: funciones pequeñas, una responsabilidad cada una | Lectura: hazte la pregunta de los apuntes de cada función: **"¿Cómo sale este bucle?"** y **"¿qué haría si tuviera que cambiar una regla?"**. Si cambiar la trampa del jefe obliga a tocar 5 funciones, el SRP falla. | 0,75 |
| El historial de victorias viaja entre funciones y **sobrevive** | Ejecución: gana un duelo, sal de él y vuelve al menú. ¿Las victorias siguen ahí? Si ganaste y el contador vuelve a 0, el historial viaja **por valor** en vez de por referencia: es el fallo más clásico de este ejercicio. | 0,5 |
| La ronda aislada en su función (dueño del combate + ronda) | Lectura: ¿hay una función que haga **una sola ronda** y otra (o dos) que sea el dueña del bucle del combate? Compara con la estructura de la oficial. | 0,5 |
| Código comentado y legible | Lectura: nombres que se entienden sin comentario, y comentarios donde hay truco (la trampa, el historial). | 0,25 |

---

# Ejercicio 3: El reloj digital — 10 puntos

*De qué va: un simulador de tiempo real —cada tic es un segundo REAL de espera— donde las entradas se escriben en dos formatos distintos y la comparación de horas debe ser justa en ambos.*

## Bloque A: Entradas y validación (4 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| El formato (24 h / AM-PM) se pide en bucle hasta elegir uno válido | Ejecución: elige "5" primero; debe rechazarlo y volver a preguntar | 0,5 |
| Hora y minuto de inicio: números enteros dentro de su rango | Ejecución: mete "abc", luego "25" en 24 h (o "13" en AM/PM); debe avisar y repetir | 0,75 |
| Hora y minuto final: ídem | Ejecución con entradas malas | 0,5 |
| El periodo AM/PM se valida (solo A o P) | Ejecución con "X"; debe rechazarlo | 0,5 |
| La hora final no puede ser inferior a la de inicio: si lo es, se vuelve a pedir | Ejecución: empieza a las 11:30 PM y termina a 1:00 AM — debe rechazarlo (60 < 1410) | 1 |
| La comparación usa una escala común (p. ej. minutos desde medianoche), no números "a pelo" de formatos distintos | Lectura del código: hay una función de conversión antes de comparar | 0,75 |

## Bloque B: Simulación (3 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| El reloj queda fijo en la misma posición (`\r` o `SetCursorPosition`): no se acumula línea tras línea | Ejecución: el reloj se redibuja en su sitio, no imprime 60 líneas para un minuto | 0,75 |
| Avanza segundo a segundo con pausa real (`Thread.Sleep(1000)`) | Cronómetro: 1 minuto de reloj tarda ~1 minuto real | 0,75 |
| Recorre el rango completo hasta llegar justo a la hora final | Ejecución con un tramo corto (p. ej. 11:58 → 11:59 PM) | 0,75 |
| Al llegar a la hora final muestra **FIN** | Ejecución: debe terminar con el mensaje FIN, no seguir | 0,75 |

## Bloque C: Diseño (2 puntos)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| Funciones pequeñas con SRP: una para formato, otra para pedir hora, otra para el periodo, otra para formatear, otra para simular | Lectura del código: si cambiar el formato obligara a tocar la simulación, falla | 1 |
| Constantes para rangos, formatos y conversiones (0-23, 1-12, 0-59, 60, 1000...) | Lectura del código: sin números sueltos en la lógica | 0,5 |
| Comentarios explicando los trucos (`\r`, la escala común, las reglas 12 AM = medianoche) | Lectura del código | 0,5 |

## Bloque D: Ejecución (1 punto)

| Criterio | Cómo lo compruebas (paso a paso) | Puntos |
|----------|----------------------------------|--------|
| Compila y arranca | `dotnet run tu_archivo.cs` sin errores | 0,25 |
| Entradas inválidas no rompen el programa | Letras donde pide números, rangos imposibles | 0,25 |
| El formato AM/PM muestra bien las horas críticas (12 AM = medianoche, 12 PM = mediodía) | Ejecución: programa un reloj de 11:58 PM a 12:02 AM y mira el cambio | 0,25 |
| FIN en el momento exacto y salida limpia | Ejecución: no debe pasar de la hora final ni quedarse corto | 0,25 |

---

# Errores frecuentes: qué significa, cómo se arregla y cuánto cuesta

No te limites a restar: **escribe cuál te ha salido a ti y arréglalo en tu código**. Cada penalización se aplica **una sola vez** por error, aunque el error se repita varias veces en el código. **La suma de penalizaciones de un ejercicio nunca pasa de −2.**

## Errores típicos del Ejercicio 1 (Simulador de vuelo)

| Error frecuente | Penalización | Por qué está mal | Cómo se arregla |
|-----------------|--------------|------------------|-----------------|
| El `out` no se asigna antes del `return` | −0,5 | C# exige que un parámetro de salida tenga valor **siempre**, aunque la función salga por otro camino | Asigna el `out` al entrar (p. ej. `intentos = 0`) |
| Varios `Random` repartidos por el código | −0,5 | Uno por llamada = números peor repartidos y semántica confusa: el azar es un servicio del programa, no de una función | Crea **un** `Random` al principio y reutilízalo |
| Sin pausa real: la simulación termina en milisegundos | −0,5 | El bucle corre a la velocidad del procesador; no simulas el tiempo, solo lo cuentas | `Thread.Sleep` en cada ciclo |
| La salida por >10 intentos no llega al control manual | −0,5 | El enunciado dice que es un **fallo del sistema**: se informa y se vuelve a control manual | Comprueba el resultado de los intentos y enruta el fallo igual que una excepción |
| El programa muere al meter letras donde pide un número | −0,25 | Una entrada del usuario no es un error del sistema: es algo previsible | `TryParse` en las lecturas (regla de oro del punto 4) |
| El `try-catch` envuelve el programa entero sin criterio | −0,25 | Si lo envuelves todo, no sabes qué parte puede fallar realmente | El `try` cubre solo la simulación; el `catch` informa del fallo |

## Errores típicos del Ejercicio 2 (Piedra, Papel o Tijera)

| Error frecuente | Penalización | Por qué está mal | Cómo se arregla |
|-----------------|--------------|------------------|-----------------|
| El historial de victorias se copia por valor | −1 | La función recibe una copia: suma dentro y la copia se tira a la basura al salir; las victorias "se borran" | Paso por referencia (`ref`) en el historial |
| Los empates suman puntos | −0,5 | El cuento dice que nadie suma: es la trampa de asumir "resultado = punto" | Solo suma en victoria/derrota; el empate no toca el marcador |
| El jefe "siempre gana" (o nunca empata) | −0,5 | El enunciado dice **2 de cada 3**, ni más ni menos | Decide con probabilidad: 2 de 3 → la que te gana; 1 de 3 → la que pierde |
| El programa muere al meter letras donde pide un número | −0,25 | Una entrada del usuario no es un error del sistema: es algo previsible | `TryParse` en las lecturas (regla de oro del punto 4) |
| El mismo bloque copiado en partida normal y en la del jefe | −0,25 | Copiar y pegar = DRY roto: cuando corrijas una mitad, la otra se queda vieja | Una única función de ronda parametrizada por el tipo de rival |

## Errores típicos del Ejercicio 3 (El reloj digital)

| Error frecuente | Penalización | Por qué está mal | Cómo se arregla |
|-----------------|--------------|------------------|-----------------|
| Sin `TryParse`: "abc" reventaría el programa | −0,25 | Una entrada del usuario es algo previsible, no un error del sistema | `TryParse` + rango en la misma comprobación |
| Comparar horas de formatos distintos sin escala común (1:00 AM "parece" menor que 11:30 PM) | −0,5 | En AM/PM los números no van en la misma línea: 1:00 AM es DESPUÉS de 11:30 PM | Convertir ambas a minutos desde medianoche y comparar ahí |
| Sin `Thread.Sleep`: el reloj termina en milisegundos | −0,5 | El bucle corre a la velocidad del procesador; no simulas el tiempo | Un `Thread.Sleep(1000)` por tic |
| El reloj no queda fijo: se acumula línea tras línea | −0,25 | Un reloj que imprime en vez de redibujar no es un reloj | `\r` al inicio de cada `Write` (o `SetCursorPosition`) |
| Falta el FIN o el bucle no termina nunca | −0,25 | El enunciado fija una hora final: el bucle debe tener techo | Comparar contra la hora final en cada tic |
| El bloque de "pedir hora" copiado dos veces en vez de reutilizado | −0,25 | DRY roto: inicio y final son exactamente la misma petición | Una función de pedir hora reutilizada por ambos |

---

## Tu hoja de puntuación (se rellena en 5 minutos)

**Cómo se cuenta un bloque — el truco está en mirar lo que FALLA:**

1. Abre la tabla del bloque en la corrección de arriba.
2. Marca los criterios que **NO** cumplas. Los que sí cumplen dan sus puntos solos.
3. **Tu bloque = máximo del bloque − puntos de los criterios marcados.** Así solo haces una resta por bloque.

Ejemplo: Bloque A del Ejercicio 1 (máximo 4) — si solo te falla `leerParametro` (1 punto): 4 − 1 = **3**.

**Paso 1 — Nota por bloques:**

| Ejercicio | Bloque A | Bloque B | Bloque C | Bloque D | Subtotal (suma los 4) |
|-----------|----------|----------|----------|----------|------------------------|
| 1: Simulador de vuelo | /4 | /3 | /2 | /1 | /10 |
| 2: Piedra, papel o tijera | /2 | /3 | /3 | /2 | /10 |
| 3: El reloj digital | /4 | /3 | /2 | /1 | /10 |

**Paso 2 — Penalizaciones:** mira la tabla de errores de **tu** ejercicio; si te reconoces en un error, apunta aquí su resta (una sola vez por error):

| Ejercicio | Errores en los que te reconoces | Resta total |
|-----------|----------------------------------|-------------|
| 1 | | |
| 2 | | |
| 3 | | |

**Paso 3 — Nota final** (Subtotal − penalizaciones):

| Ejercicio | Subtotal | − Penalización | = Nota |
|-----------|----------|----------------|--------|
| 1: Simulador de vuelo | | | /10 |
| 2: Piedra, papel o tijera | | | /10 |
| 3: El reloj digital | | | /10 |

Cada ejercicio tiene **su propia nota sobre 10**: no se suman ni se promedian entre ellos.

**Paso 4 — Interprétalo ejercicio a ejercicio.** Cada ejercicio se corrige **en su escala de 10**: es perfectamente normal que uno te salga Sobresaliente y el otro Insuficiente — esa diferencia es exactamente tu plan de repaso. El total es un dato de contexto, no una nota única.

| Rango (de cada ejercicio, sobre 10) | Qué te dice |
|--------------------------------------|-------------|
| 0 – 4,5 | Insuficiente: repasa el punto, corrige con la solución al lado y **vuelve a intentarlo en 48 horas sin mirarla** |
| 5 – 6,9 | Suficiente: la lógica funciona; tu repaso es el diseño (SRP, `ref`, comentarios) |
| 7 – 8,9 | Notable: bien razonado y bien construido |
| 9 – 10 | Sobresaliente: podrías corregir ese ejercicio tú mismo |

## Antes de guardar, contesta esto (es lo que de verdad aprendes)

1. **Justifica cada nota en una frase**: "en el simulador me he sacado una X porque me han fallado Y y Z; en la batalla, una W porque...". Si no sabes justificarlas, no las has calculado bien: vuelve al Paso 1.
2. **¿Qué criterio has fallado y cuál era la causa exacta?** (escríbelo: "usé `Parse`...", "olvidé el `out`...").
3. **¿Qué concepto de la unidad te ha pillado?** (¿`ref`? ¿Early Return? ¿el círculo de figuras?) Apúntalo: es tu lista personal de repaso antes del examen real.
4. **Vuelve dentro de 48 horas** y resuelve el ejercicio que peor te haya salido **sin abrir la solución**. Si sale, lo has aprendido de verdad.
