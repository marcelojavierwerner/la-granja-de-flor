# 📜 Scripts de C# - La Granja de Flor

Esta carpeta contiene los scripts en **C# (.NET / Mono)** desarrollados en **Unity** que controlan la lógica principal del videojuego, incluyendo la navegación de menús, actividades pedagógicas y los minijuegos interactivos.

---

## 🗂️ Índice de Scripts

| Script | Descripción Principal | Patrones / Mecánicas |
| :--- | :--- | :--- |
| **`GameManager.cs`** | Controlador central de las actividades educativas (números, colores y animales). | Singleton, Corrutinas (`IEnumerator`), Gestión de visibilidad de GameObjects. |
| **`InterfazUsuario.cs`** | Administrador de la interfaz (Canvas), cronómetros, menús de victoria y selector de dificultad. | Unity UI (`Slider`, `Text`), Invoking temporizado, `TimeSpan`. |
| **`GameSimon.cs`** | Lógica completa del minijuego **Flor Dice** (estilo *Simón Says*). | Persistencia local (`PlayerPrefs`), secuencia aleatoria (`Random.Range`), feedback visual/sonoro. |

---

## 🛠️ Detalles Técnicos de los Scripts

### 1. `GameManager.cs`
* **Patrón Singleton:** Implementa `Awake()` para garantizar una única instancia global accesible mediante `GameManager.gm`.
* **Corrutinas de Secuencia:** Utiliza métodos `IEnumerator` con `yield return new WaitForSeconds(3)` para mostrar y ocultar de forma sincronizada los personajes, números (del 1 al 9) y los colores en pantalla.

### 2. `InterfazUsuario.cs`
* **Control de Menús:** Métodos para abrir/cerrar menús principales y de victoria (`MostrarMenu`, `EsconderMenuGanador`).
* **Ajuste de Dificultad:** Lee el valor del `Slider` para alternar la dificultad del minijuego de memoria en 3 niveles (Fácil = 4, Intermedio = 6, Difícil = 8).
* **Sistema de Cronómetro:** Calcula el tiempo transcurrido en el minijuego utilizando `TimeSpan` y refresca el contador de la interfaz segundo a segundo.

### 3. `GameSimon.cs`
* **Lógica del Minijuego:** Construye dinámicamente listas de secuencias (`List<int> activeSequence`) añadiendo botones aleatorios a medida que el jugador avanza de ronda.
* **Manejo de Transiciones Visuales:** Utiliza `stayLitCounter` y `stayLit` con `Time.deltaTime` para regular el tiempo que se ilumina la imagen del animal y suena su audio asociado.
* **Persistencia de Puntaje:** Almacena la puntuación máxima lograda por el usuario usando `PlayerPrefs.SetInt("HiScore", ...)`.

---

## ⚙️ Requisitos y Dependencias

* **Motor de Juego:** Unity 2019 / Unity 2022.
* **Módulos Requeridos:**
  * `UnityEngine`
  * `UnityEngine.UI`
  * `System.Collections`
  * `System.Collections.Generic`
