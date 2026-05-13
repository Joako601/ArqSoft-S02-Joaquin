# 📘 Arquitectura de Software - Práctica 1

## 👨‍💻 Información del Estudiante

- **Nombre:** Joaquin Uriona
- **Matrícula:** SW2509057
- **Grupo:** A
- **Cuatrimestre:** Tercer Cuatrimestre
- **Carrera:** TSU en Desarrollo e Innovación de Software
- **Profesor:** Jorge Javier Pedrozo Romero
---

## 📋 Descripción del Proyecto

Este repositorio contiene el código fuente de una aplicación de consola desarrollada en **.NET**. El proyecto demuestra la implementación de patrones de diseño y separación de responsabilidades mediante la construcción de motores independientes para los clásicos juegos del Ahorcado y la Viborita, ejecutándose sobre una interfaz de línea de comandos (CLI).

---

## 🧩 Arquitectura de los Módulos

### Módulo 1: Motor Ahorcado (Gestión de Estado y Memoria)
Implementa la lógica de evaluación de caracteres y gestión del estado de una cadena oculta.
*   **Gestión de Repositorios:** Utiliza la interfaz `IRepositorioPalabras` para desacoplar el origen de los datos. La implementación actual (`PalabrasEnMemoria`) maneja categorías mediante colecciones en tiempo de ejecución.
*   **Validación de Estado:** El `MotorAhorcado` procesa las entradas del usuario, verifica colisiones (letras repetidas) y evalúa la condición de victoria/derrota sin interactuar directamente con la consola.

### Módulo 2: Motor Viborita (Lógica Espacial y Ciclos Continuos)
Implementa un sistema de coordenadas espaciales y un ciclo de ejecución ininterrumpido (*Game Loop*).
*   **Estructuras de Datos Eficientes:** Utiliza `LinkedList<T>` para manejar dinámicamente el estado y la posición de los segmentos (cuerpo) en la cuadrícula.
*   **Procesamiento Asíncrono Simulado:** Captura la entrada de teclado mediante interrupciones no bloqueantes, permitiendo que el motor espacial calcule colisiones y avance de forma independiente a la UI.

---

## 📁 Estructura del Proyecto

```
Ahorcado/
│
├── Lógica del Dominio (Motores)
│   ├── IMotorJuego.cs              # Contrato unificado para el ciclo de ejecución
│   ├── IMotorViborita.cs           # Interfaz específica para operaciones espaciales
│   ├── MotorAhorcado.cs            # Lógica de evaluación y estado de caracteres
│   ├── MotorViborita.cs            # Lógica espacial, colisiones y recálculo de coordenadas
│   └── Juego.cs                    # Lógica compartida de la sesión
│
├── Capa de Datos
│   ├── IRepositorioPalabras.cs     # Abstracción para la inyección de repositorios
│   └── PalabrasEnMemoria.cs        # Implementación de colecciones en memoria por categoría
│
├── Capa de Presentación (UI)
│   ├── ConsolaUI.cs                # Renderizado estático y peticiones para el Módulo 1
│   └── ConsolaUIViborita.cs        # Renderizado de cuadrícula dinámica para el Módulo 2
│
├── Core
│   └── Program.cs                  # Punto de entrada y enrutamiento principal
│
├── Ahorcado.csproj                 # Dependencias y configuración del entorno .NET
├── Ahorcado.slnx                   # Archivo de la solución
├── .gitignore                      # Archivos excluidos del control de versiones
└── README.md
```

---

### 🛠️ Tecnologías Utilizadas
### 🛠️ Tecnologías Utilizadas
* **Lenguaje:** C#
* **Framework:** .NET
* **Entorno:** Command-Line Interface (CLI)
* **Herramientas:** Visual Studio 2022, Git
---

## 🤝 Agradecimientos

- **Profesor Jorge Javier Pedrozo Romero** por la estructura del curso y la práctica
- **Tecnológico de Software** por la formación integral

---

## 📧 Contacto

- **Email Institucional:** joaquin.uriona@tecdesoftware.edu.mx
- **GitHub:** [Joako601](https://github.com/TU-USUARIO)

---

## 📄 Licencia

Este proyecto fue desarrollado por **Joaquin Uriona** como parte de las prácticas académicas para el **Tecnológico de Software**. 

Distribuido bajo la Licencia MIT. Siéntete libre de utilizar la arquitectura del código y el diseño de la interfaz para fines educativos o proyectos personales, siempre y cuando se mantenga el reconocimiento al autor original. 

Consulta el archivo `LICENSE` para más detalles.

---

## 🤖 Declaración de Uso de IA

Este proyecto integra asistencia de Inteligencia Artificial **exclusivamente para la correccion de la identacion**
---

<div align="center">

**⭐ Si te gustó este proyecto, dale una estrella ⭐**

Hecho con 💙 por Joaquin Uriona - 2026

</div>
