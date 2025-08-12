# Manual de Uso del Juego Connect 4

## 1\. Configuración e Instalación

Para poner en marcha el proyecto, sigue estos pasos en el orden correcto.

### 1.1. Iniciar el Backend (API)

El backend está desarrollado con .NET y se encuentra en la carpeta `API4EnLinea`.

1.  Abre la terminal y navega hasta la carpeta del proyecto.

    cd ProyectoFinalG2Miercoles/API4EnLinea

2.  Inicia la API con el siguiente comando:

    dotnet run

    La API se ejecutará por defecto en `http://localhost:5274`.

### 1.2. Iniciar el Frontend (Cliente Web)

El frontend está desarrollado con React y se encuentra en la carpeta `four-in-a-row`.

1.  En una nueva terminal, navega a la carpeta del frontend.
   
    cd four-in-a-row
  
2.  Instala las dependencias del proyecto. Si es la primera vez que lo ejecutas, esto es fundamental.

    npm install

3.  Asegúrate de que la ruta de la API en el archivo `src/api/index.js` sea correcta. Por defecto, debería ser `http://localhost:5274/api`.
4.  Inicia la aplicación web.

    npm start

    La aplicación se abrirá en tu navegador en `http://localhost:3000`.

-----

## 2\. Cómo Jugar

### 2.1. Crear Jugadores

Antes de empezar una partida, necesitas al menos dos jugadores.

1.  En la aplicación, ve a la sección "**Players**" en el menú lateral.
2.  Haz clic en "**Create New Player**".
3.  Ingresa un **ID único** y un **nombre** para el jugador.
4.  Haz clic en "**Create Player**" para guardarlo.

### 2.2. Iniciar una Partida Nueva

1.  Desde la página principal, haz clic en el botón "**New Game**".
2.  Selecciona dos jugadores diferentes de los menús desplegables.
3.  Haz clic en cualquier columna del tablero para que empiece el primer turno.

### 2.3. Cargar una Partida Existente

1.  En la página principal, haz clic en el botón "**Load Game**".
2.  Selecciona una de las partidas guardadas de la lista.
3.  Haz clic en "**Play**" para continuar la partida desde donde la dejaste.

### 2.4. Dinámica del Juego

  * Los jugadores se turnan para hacer clic en una columna.
  * El juego detecta automáticamente cuando un jugador logra **4 fichas en línea** (horizontal, vertical o diagonal).
  * Si el tablero se llena y no hay un ganador, la partida termina en **empate**.
  * Puedes reiniciar la partida en cualquier momento con el botón "**Restart**".

-----

## 3\. Comandos Útiles

### 3.1. Para el Backend (`API4EnLinea`)

  * `dotnet run`: Inicia el servidor de la API.
  * `dotnet ef migrations add <nombre_migracion>`: Crea una nueva migración de la base de datos.
  * `dotnet ef database update`: Aplica las migraciones pendientes a la base de datos, creando o actualizando las tablas.

### 3.2. Para el Frontend (`four-in-a-row`)

  * `npm start`: Inicia la aplicación en modo de desarrollo.
  * `npm run build`: Compila la aplicación para su despliegue en producción.
  * `npm test`: Ejecuta las pruebas del proyecto.

-----

## 4\. Pruebas con Postman o Swagger

Puedes verificar el funcionamiento de la API probando sus endpoints.

### Endpoints de la API

  * **Obtener todos los jugadores**: `GET http://localhost:5274/api/Jugador`
  * **Crear un nuevo jugador**:
      * `POST http://localhost:5274/api/Jugador`
      * **Body (JSON)**: `{"id": 1, "nombre": "Jugador1"}`
  * **Obtener todas las partidas**: `GET http://localhost:5274/api/Partida`
  * **Crear una nueva partida**:
      * `POST http://localhost:5274/api/Partida`
      * **Body (JSON)**: `{"jugador1_Id": 1, "jugador2_Id": 2, "estado": "iniciado", "tablero": "[[null,null,...]]", "resultado": "pendiente", "turno": 0}`

-----

## 5\. Solución de Problemas Comunes

### La API no se conecta a la base de datos

  * Verifica que el archivo `connect4.db` exista en la carpeta del backend.
  * Ejecuta `dotnet ef database update` para recrear o actualizar la base de datos.

### El frontend no se puede conectar con el backend

  * Asegúrate de que la API esté corriendo en `http://localhost:5274`.
  * Verifica que la URL del backend en `src/api/index.js` sea la correcta.
  * Confirma que no haya problemas de CORS. El backend ya está configurado para permitir las peticiones del frontend (`http://localhost:3000`).

### Problemas con las dependencias

  * Para el frontend, si tienes errores de dependencias, borra la carpeta `node_modules` y vuelve a ejecutar `npm install`.
  * Para el backend, ejecuta `dotnet restore` para restaurar todas las dependencias del proyecto.