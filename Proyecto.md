# Proyecto Final SC-701 - Programación Avanzada en Web  
## Juego Connect4

---

## 1. Información del Curso  
**Curso:** Programación Avanzada en Web (SC-701)  
**Profesor:** Luis Andrés Rojas Matey  
**Grupo:** Grupo 2

---

## 2. Integrantes del Grupo

| Nombre Completo                | Carné      | Usuario de GitHub   | Correo Electrónico               |
|-------------------------------|------------|--------------------|--------------------------------|
| Melannie Espinoza Palacio      | FH22011877 | Mela231            | espinozamelani290@gmail.com    |
| Rusdwin Jimenez Morales        | FH15000251 | RuzJim             | r.alejimenez@gmail.com          |
| Miguel Mesen Molina            | FH23015025 | miguemesen         | miguemesen12@gmail.com          |
| Paula Mariana Gonzalez Pozo    | FH23014777 | paulagonzalezp     | pgonzalez70755@ufiide.ac.cr     |

---

## 3. Justificación del Proyecto  
El presente proyecto consiste en la implementación del juego Connect4 como una aplicación web basada en arquitectura cliente-servidor. Se desarrolló un backend RESTful API utilizando ASP.NET Core que expone los servicios necesarios para la gestión de jugadores y partidas. Por su parte, el frontend se construyó con React, brindando una interfaz interactiva y dinámica para los usuarios. La comunicación entre cliente y servidor se realiza mediante peticiones HTTP con datos en formato JSON, asegurando una interacción eficiente y escalable.

---

## 4. Descripción del Proyecto

### Backend  
**Lenguaje y Framework:**  
Se seleccionó C# con ASP.NET Core por su robustez, capacidad para crear APIs RESTful y su integración nativa con Entity Framework Core. Esta combinación permitió estructurar un backend modular, con controladores encargados de la lógica de negocio y endpoints bien definidos.

**Arquitectura:**  
Se adoptó el patrón Modelo-Vista-Controlador (MVC) para organizar el código, favoreciendo el mantenimiento y la legibilidad mediante la separación clara entre modelos, controladores y configuración.

**Base de Datos:**  
Se utilizó SQLite como motor de base de datos por ser liviano y portátil, adecuado para proyectos con un alcance local sin necesidad de un servidor dedicado.

**ORM:**  
Entity Framework Core facilitó el mapeo de objetos C# a tablas de la base de datos mediante un enfoque Code-First, disminuyendo la necesidad de consultas SQL manuales y simplificando la gestión de migraciones.

**Documentación:**  
Se integró Swagger para la documentación automática y prueba directa de los endpoints, mejorando la usabilidad del API.

---

### Frontend  
**Framework:**  
React fue escogido por su capacidad para manejar interfaces complejas mediante componentes reutilizables y un flujo de datos predecible a través de props y estado.

**Estilos:**  
Se empleó SASS para una mejor organización de estilos mediante anidamiento y variables, y CSS modularizado para mantener la coherencia visual por componente.

**Gestión de Rutas:**  
Se implementó react-router-dom para el enrutamiento interno, permitiendo la navegación fluida entre vistas como Inicio, Jugadores y Login sin recarga completa de página.

**Iconografía:**  
Se incorporaron íconos vectoriales mediante react-icons para un diseño ligero y escalable.

**Conexión con Backend:**  
Las peticiones HTTP se manejan a través de la API fetch, centralizadas en funciones ubicadas en `src/api/index.js`, asegurando la separación de la lógica de comunicación con el resto de la aplicación.

**Tipo de Aplicación:**  
El backend funciona como una API multi-página (MPA) mientras que el frontend se comporta como una aplicación de página única (SPA), donde React controla las interacciones sin recargar toda la interfaz.

**Modelo SaaS/PaaS:**  
El sistema no depende de un SaaS público, pero es compatible para su despliegue en plataformas PaaS como Azure App Service o Vercel. En el entorno académico, se ejecuta localmente con una arquitectura escalable.

---

## 5. Beneficios del Enfoque  
- Separación clara entre frontend y backend para facilitar mantenimiento y escalabilidad.  
- Capacidad para modificar o reemplazar componentes sin afectar otras capas.  
- Reutilización de servicios y componentes en futuras ampliaciones.  
- Facilidad para integrar nuevas funcionalidades, como rankings, reinicio de partidas y autenticación.

---

## 6. Ejemplos de Prompts de IA Utilizados

**Backend (ASP.NET Core):**  
*"Genera un controlador en C# para ASP.NET Core con endpoints GET, POST, PUT y DELETE para una entidad Jugador usando Entity Framework Core con SQLite."*  
Este prompt sirvió como base para el desarrollo del `JugadorController` adaptado a la lógica del juego.

**Frontend (React):**  
*"Crea un componente Connect Four en React con una matriz de 6 filas y 7 columnas que permita alternar fichas entre dos jugadores y detectar ganador en todas las direcciones."*  
Se utilizó como referencia para la implementación de `ConnectFour.jsx`.

**Estilos (SASS):**  
*"Diseña estilos en SASS para un tablero de Connect Four con fichas circulares rojas y amarillas y un diseño responsivo."*  
Inspiró la estructura y anidamiento de estilos en `ConnectFour.scss`.

**Integración API en React:**  
*"Implementa funciones en React para consumir una API REST usando fetch con manejo de errores desde `api/index.js`."*  
Se aplicó para centralizar las llamadas a la API en funciones como `getAllPlayers` y `postPlayer`.

**Optimización de Experiencia de Usuario:**  
*"Sugiere mejoras para la interfaz de un juego Connect Four que incluya reinicio de partida, carga de juegos previos y visualización de tabla de jugadores."*  
Influyó en la incorporación de botones y opciones en el menú principal.

---

## 7. Diagrama de Base de Datos  
El diseño y explicación detallada del modelo de datos se encuentran en el archivo `DBD.md`, ubicado en la ruta:  
`ProyectoFinalG2Miercoles\API4EnLinea`

---

## 8. Comandos Útiles  

### Backend  
- `dotnet run` : Inicia la API.  
- `dotnet ef migrations add <nombre_migracion>` : Crea una nueva migración.  
- `dotnet ef database update` : Aplica las migraciones a la base de datos.

### Frontend  
- `npm start` : Ejecuta la aplicación en modo desarrollo.  
- `npm run build` : Genera una versión optimizada para producción.  
- `npm test` : Ejecuta las pruebas unitarias.

---
