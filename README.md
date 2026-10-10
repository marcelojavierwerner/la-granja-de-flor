# 🐮 La Granja de Flor 🚜

**La Granja de Flor** es un videojuego educativo interactivo e infantil desarrollado en **Unity (C#)**[cite: 8, 9, 10]. Creado en **2019**, estuvo publicado comercialmente en la tienda **Google Play Store (Android)** desde 2019 hasta 2023.

Diseñado especialmente para niños en etapa preescolar y primaria, el juego combina actividades pedagógicas con minijuegos dinámicos para aprender números, colores, nombres de animales y ejercitar la memoria.

---

## 📸 Capturas de Pantalla

| Menú Principal | Números y Conteo | Juego de Flores y Colores |
| :---: | :---: | :---: |
| ![Menú Principal](1b9596ee-61ef-4ac6-a2b2-5453d93faae2.jpg) | ![Actividad Números](4a11512d-737e-49c1-a7bd-a6aacc03de51.jpg) | ![Flores y Colores](8908a4d4-88cd-4026-8edb-6f802d919f93.jpg) |

| Minijuego Memory (Parejas) | Reconocimiento de Animales | Modo Desafío / Puntuación |
| :---: | :---: | :---: |
| ![Minijuego Memoria](71640d6b-8049-4f5d-8834-4d5b4f187ef7.jpg) | ![Animales Granja](ac4f0b56-102c-43c0-87a7-d78ed8c04246.jpg) | ![Score / Puntuación](Screenshot_20200712-202717.jpg) |

---

## ✨ Características Principales

* 🎨 **Sección de Actividades Educativas:**
  * **Conteo y Números (1 al 9):** Identificación de números y representación con animales en pantalla[cite: 2, 8].
  * **Aprende los Colores:** Presentación interactiva de colores con flores animadas[cite: 8].
  * **Conoce los Animales:** Interacción directa con el gato, perro, vaca, caballo, oveja, gallina, conejo y cerdo[cite: 8].
  * **Sección de Cuentos:** Cuentos infantiles e interactivos incorporados.
* 🎮 **Sección de Minijuegos:**
  * **Memory / Memotest:** Juego de encontrar parejas con 3 niveles de dificultad ajustables (Fácil, Intermedio, Difícil), cronómetro y menú de victoria[cite: 9].
  * **Flor Dice (Simón Says):** Minijuego de memoria visual y auditiva basado en la reproducción de secuencias de luz y sonido con animales[cite: 10]. Guarda el récord del jugador (*Hi Score*) en almacenamiento local[cite: 10].
* 🛠️ **Panel de Configuración y Menú:**
  * Menús interactivos adaptados para pantallas extendidas de teléfonos modernos.
  * Ajustes de dificultad, control de música/sonidos, enlaces a redes sociales y acuerdos de privacidad integrados[cite: 9, 10].

---

## 🛠️ Tecnologías y Plataformas

* **Plataforma:** Android (Google Play Store 2019 - 2023)
* **Motor de Juego:** Unity (Actualizado a Unity 2022)
* **Lenguaje de Programación:** C# (.NET / Mono)[cite: 8, 9, 10]
* **UI/UX:** Unity UI (Canvas, Sliders, TextMeshPro, Panels animables)[cite: 9, 10]
* **Almacenamiento Local:** `PlayerPrefs` para guardado de puntajes más altos (*Hi Score*) y preferencias de usuario[cite: 10].
* **Sistemas Internos:** Corrutinas de C#[cite: 8, 10], Administrador de Audio (`AudioManagerG`)[cite: 9] y Gestión de Estado (`GameManager`)[cite: 8].

---

## 📜 Estructura del Código (Scripts Destacados)

* **`GameSimon.cs`**:
  * Controla la lógica del minijuego estilo *Simón Says*.
  * Genera secuencias aleatorias seleccionando botones de animales e incrementando la dificultad progresivamente[cite: 10].
  * Gestiona temporizadores con `Time.deltaTime` para iluminar los sprites y reproducir efectos de sonido acordes[cite: 10].
  * Almacena y actualiza la puntuación máxima utilizando `PlayerPrefs` (`HiScore`)[cite: 10].
* **`GameManager.cs`**:
  * Controla el ciclo de vida de las actividades y la aparición secuencial de personajes y elementos interactivos en pantalla mediante `Coroutines`[cite: 8].
  * Administra el despliegue del conteo numérico (1 al 9) y la activación/desactivación temporizada de las caras de animales y colores[cite: 8].
* **`InterfazUsuario.cs`**:
  * Maneja la lógica de menús (Menú principal, Menú de ganadores, Paneles de configuración)[cite: 9].
  * Controla la dificultad del minijuego de memoria (Fácil, Intermedio, Difícil)[cite: 9].
  * Sistema de cronómetro integrado mediante `TimeSpan` para medir el tiempo del jugador[cite: 9].

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
