# 🐮 La Granja de Flor 🚜

**La Granja de Flor** es un videojuego educativo interactivo e infantil desarrollado en **Unity (C#)**. Creado en **2019**, estuvo publicado comercialmente en la tienda **Google Play Store (Android)** desde 2019 hasta 2023.

Diseñado especialmente para niños en etapa preescolar y primaria, el juego combina actividades pedagógicas con minijuegos dinámicos para aprender números, colores, nombres de animales y ejercitar la memoria.

---

## 📸 Capturas de Pantalla

| Menú Principal | Números y Conteo | Juego de Flores y Colores |
| :---: | :---: | :---: |
| ![Menú Principal](screenshots/Screenshot_20200501-225008.png) | ![Actividad Números](screenshots/Screenshot_20200326-221450.png) | ![Flores y Colores](screenshots/Screenshot_20200326-221339.png) |

| Minijuego Memory (Parejas) | Reconocimiento de Animales | Minijuego Simon Dice |
| :---: | :---: | :---: |
| ![Minijuego Memoria](screenshots/Screenshot_20200501-225054.png) | ![Animales Granja](screenshots/Screenshot_20200326-220916.png) | ![Score / Puntuación](screenshots/Screenshot_20200712-202717.png) |

---

## ✨ Características Principales

* 🎨 **Sección de Actividades Educativas:**
  * **Conteo y Números (1 al 9):** Identificación de números y representación con animales en pantalla.
  * **Aprende los Colores:** Presentación interactiva de colores con flores animadas.
  * **Conoce los Animales:** Interacción directa con el gato, perro, vaca, caballo, oveja, gallina, conejo y cerdo.
  * **Sección de Cuentos:** Cuentos infantiles e interactivos incorporados.
* 🎮 **Sección de Minijuegos:**
  * **Memory / Memotest:** Juego de encontrar parejas con 3 niveles de dificultad ajustables (Fácil, Intermedio, Difícil), cronómetro y menú de victoria.
  * **Flor Dice (Simón Says):** Minijuego de memoria visual y auditiva basado en la reproducción de secuencias de luz y sonido con animales. Guarda el récord del jugador (*Hi Score*) en almacenamiento local.
* 🛠️ **Panel de Configuración y Menú:**
  * Menús interactivos adaptados para pantallas extendidas de teléfonos modernos.
  * Ajustes de dificultad, control de música/sonidos, enlaces a redes sociales y acuerdos de privacidad integrados.

---

## 🛠️ Tecnologías y Plataformas

* **Plataforma:** Android (Google Play Store 2019 - 2023)
* **Motor de Juego:** Unity (Actualizado a Unity 2022)
* **Lenguaje de Programación:** C# (.NET / Mono)
* **UI/UX:** Unity UI (Canvas, Sliders, TextMeshPro, Panels animables)
* **Almacenamiento Local:** `PlayerPrefs` para guardado de puntajes más altos (*Hi Score*) y preferencias de usuario.
* **Sistemas Internos:** Corrutinas de C#, Administrador de Audio (`AudioManagerG`) y Gestión de Estado (`GameManager`).

---

## 📜 Estructura del Código (Scripts Destacados)

* **`GameSimon.cs`**:
  * Controla la lógica del minijuego estilo *Simón Says*.
  * Genera secuencias aleatorias seleccionando botones de animales e incrementando la dificultad progresivamente.
  * Gestiona temporizadores con `Time.deltaTime` para iluminar los sprites y reproducir efectos de sonido acordes.
  * Almacena y actualiza la puntuación máxima utilizando `PlayerPrefs` (`HiScore`).
* **`GameManager.cs`**:
  * Controla el ciclo de vida de las actividades y la aparición secuencial de personajes y elementos interactivos en pantalla mediante `Coroutines`.
  * Administra el despliegue del conteo numérico (1 al 9) y la activación/desactivación temporizada de las caras de animales y colores.
* **`InterfazUsuario.cs`**:
  * Maneja la lógica de menús (Menú principal, Menú de ganadores, Paneles de configuración).
  * Controla la dificultad del minijuego de memoria (Fácil, Intermedio, Difícil).
  * Sistema de cronómetro integrado mediante `TimeSpan` para medir el tiempo del jugador.

---

## 🚀 Historial de Versiones Destacadas

* **v1.3.07 / v1.3.03:**
  * Migración a **Unity 2022**.
  * Incorporación de la sección de **Cuentos**.
  * Optimización de interfaz, reparación de botones interactivos y eliminación de anuncios.
* **v1.2.03 / v1.2.04:**
  * Implementación del minijuego **Flor Dice** y correcciones de balance de audio.
  * Soporte mejorado para teléfonos de pantalla extendida.
* **v1.1.06 / v1.1.41:**
  * Integración del minijuego **Memory (Memotest)**.
  * Rediseño completo de la arquitectura visual utilizando `PanelManager`, `PanelGames`, `PanelActivities` y `PanelConfig`.
  * Incorporación del filtro de privacidad y términos de usuario.
* **v1.0.01 (2019):** Lanzamiento inicial del juego en Google Play Store.

---

## 👤 Créditos y Desarrollo

* **Proyecto:** La Granja de Flor
* **Desarrollador / Equipo:** SerWer Data Lab
