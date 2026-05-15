# Juego de Viborita (Snake) 

##  Descripción del Proyecto
Este proyecto es una implementación del clásico juego de la "Viborita" (Snake) desarrollada como una aplicación de consola. El jugador controla a una serpiente que debe moverse por un tablero para comer (`*`), lo que incrementa su tamaño y su puntuación. El juego termina si la serpiente choca contra las paredes del tablero o contra su propio cuerpo.

Al igual que en otros módulos del proyecto, el diseño destaca por una excelente separación de responsabilidades y buenas prácticas de arquitectura (POO), dividiendo el sistema en:
* **Lógica del Juego (Motor):** Administrada por el motor de la víbora (`MotorViborita`), que controla las dimensiones del tablero (20x15), la posición del cuerpo usando una lista enlazada (`LinkedList`), la generación de comida, el sistema de puntuación y la detección de colisiones.
* **Interfaz de Usuario (UI):** La clase `ConsolaUIViborita` se encarga de renderizar los gráficos en la consola (usando `@` para la cabeza y `o` para el cuerpo), además de capturar las pulsaciones del teclado (flechas direccionales) sin bloquear la ejecución.

##  Tecnologías Usadas
* **Lenguaje:** C#
* **Framework:** .NET 10.0
* **Tipo de Proyecto:** Aplicación de Consola
* **Paradigma:** Programación Orientada a Objetos (POO)

##  Capturas de Pantalla

**LAS CAPTURAS SE ENCUENTRAN EN LA CARPETA DOCS** 

##  Cómo ejecutar el proyecto

Para correr esta aplicación necesitas tener instalado el [SDK de .NET 10.0](https://dotnet.microsoft.com/download/dotnet/10.0).

1. Abre tu terminal o consola de comandos.
2. Navega hasta la carpeta raíz del proyecto.
3. Ejecuta el siguiente comando:

\`\`\`bash
dotnet run
\`\`\`
4. En el menú principal, ingresa la opción **2** para iniciar el juego de la Viborita.

Este readme fue hecho usando Gemini AI
