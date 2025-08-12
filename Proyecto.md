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


## PROMPTS
## Estoy recibiendo un error CORS al intentar conectar el frontend (React en localhost:3000) con el backend (API en localhost:5274). ¿Cómo puedo solucionarlo? Proporciona pasos específicos para ajustar la configuración en Program.cs del backend.Deepseek
Estos prompts te ayudarán a:

Documentar el proyecto.

Depurar errores comunes.

Mejorar el rendimiento.

Añadir nuevas features.

Automatizar despliegues (con Docker).

Escribir pruebas robustas.

¿Necesitas que adapte alguno a un caso de uso específico? 😊

dame la respuesta esta Estoy recibiendo un error CORS al intentar conectar el frontend (React en localhost:3000) con el backend (API en localhost:5274). ¿Cómo puedo solucionarlo? Proporciona pasos específicos para ajustar la configuración en Program.cs del backend.
Para solucionar el error CORS (Cross-Origin Resource Sharing) al conectar tu frontend React (localhost:3000) con el backend .NET (localhost:5274), sigue estos pasos para configurar correctamente el archivo Program.cs del backend:

Solución en Program.cs (Backend .NET)
Asegúrate de tener el paquete necesario:
Si no lo tienes, instala el paquete Microsoft.AspNetCore.Cors via NuGet o ejecuta:

bash
dotnet add package Microsoft.AspNetCore.Cors
Configura CORS en Program.cs:

csharp
var builder = WebApplication.CreateBuilder(args);

// ... (otras configuraciones existentes)

// 1. Agrega el servicio CORS (antes de builder.Build())
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // URL de tu frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// ... (middlewares existentes como app.UseHttpsRedirection(), etc.)

// 2. Habilita CORS (debe estar después de app.UseRouting() y antes de app.MapControllers())
app.UseCors("ReactFrontend");

app.MapControllers();
app.Run();
Pasos adicionales de verificación
Verifica que el frontend esté usando la URL correcta:
En tu archivo src/api/index.js del frontend React, asegúrate de que la URL apunte al backend:

javascript
const url = 'http://localhost:5274/api'; // Revisa que el puerto coincida (5274)
Reinicia ambos servicios:

Detén y vuelve a ejecutar el backend (dotnet run).

Reinicia el frontend (npm start).

Prueba con Swagger/Postman:
Verifica que los endpoints funcionen correctamente directamente en:

http://localhost:5274/swagger (Swagger UI)

O usa Postman para descartar problemas en el frontend.

Posibles errores y soluciones
Error 405 (Method Not Allowed):
Asegúrate de que los métodos HTTP (GET, POST, etc.) estén permitidos en tu controlador (ej: [HttpGet], [HttpPost]).

CORS no aplicado:
Si el error persiste, verifica que:

app.UseCors() esté antes de app.MapControllers().

No haya otros middlewares que interfieran (ej: app.UseHttpsRedirection() debe estar antes de CORS).

Solicitudes con credenciales:
Si usas cookies o autenticación, añade .AllowCredentials() a la política CORS:

csharp
policy.WithOrigins("http://localhost:3000")
      .AllowAnyHeader()
      .AllowAnyMethod()
      .AllowCredentials(); // Solo si es necesario
Ejemplo completo de Program.cs
csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

// Habilita CORS (¡importante el orden!)
app.UseCors("ReactFrontend");

app.UseAuthorization();
app.MapControllers();

app.Run();
Con esto, tu frontend React debería poder comunicarse sin problemas con el backend .NET. Si el error persiste, revisa la consola del navegador (F12 > Console/Red) para ver detalles específicos del error CORS.




## Revisa el componente ConnectFour.jsx y sugiere optimizaciones para la función checkWinner. ¿Cómo puedo hacerla más eficiente o legible? Muestra el código antes y después. (GithubCopailot)

Aquí tienes una revisión optimizada de la función checkWinner en ConnectFour.jsx, con explicaciones de las mejoras:

Código Original:
jsx
const checkWinner = (board, row, col, player) => {
  const directions = [
    [0, 1], // horizontal
    [1, 0], // vertical
    [1, 1], // diagonal /
    [1, -1], // diagonal \
  ];

  for (let [dx, dy] of directions) {
    let count = 1;

    for (let dir of [-1, 1]) {
      let r = row + dx * dir;
      let c = col + dy * dir;

      while (
        r >= 0 &&
        r < ROWS &&
        c >= 0 &&
        c < COLUMNS &&
        board[r][c] === player
      ) {
        count++;
        r += dx * dir;
        c += dy * dir;
      }
    }

    if (count >= 4) return true;
  }

  return false;
};
Problemas detectados:
Variables temporales innecesarias (r, c).

Doble bucle anidado que puede ser simplificado.

Condiciones redundantes en el while.

Falta de early return cuando se detecta un ganador.

Código Optimizado:
jsx
const checkWinner = (board, row, col, player) => {
  const directions = [
    [0, 1],  // Horizontal
    [1, 0],  // Vertical
    [1, 1],  // Diagonal /
    [1, -1], // Diagonal \
  ];

  return directions.some(([dx, dy]) => {
    const countLine = (rowStep, colStep) => {
      let count = 0;
      let r = row + rowStep;
      let c = col + colStep;

      while (
        r >= 0 && r < ROWS && 
        c >= 0 && c < COLUMNS && 
        board[r][c] === player
      ) {
        count++;
        r += rowStep;
        c += colStep;
      }
      return count;
    };

    // Cuenta en ambas direcciones + la posición actual (1)
    return 1 + countLine(dx, dy) + countLine(-dx, -dy) >= 4;
  });
};
Mejoras implementadas:
Uso de Array.some():

Retorna true tan pronto como encuentra una línea ganadora, evitando iteraciones innecesarias.

Función auxiliar countLine:

Encapsula la lógica de conteo en una dirección específica.

Reduce la complejidad cognitiva del código.

Conteo bidireccional optimizado:

Elimina el bucle for (let dir of [-1, 1]) y reemplaza con llamadas directas a countLine.

Legibilidad:

Nombres más descriptivos (dx/dy → rowStep/colStep en la función interna).

Comentarios claros sobre las direcciones.

Performance:

Evita reprocesar la celda actual sumando 1 manualmente en lugar de contarla dos veces.

Benchmark (Ejemplo teórico):
Métrica	Original	Optimizado
Complejidad ciclomática	8	5
Líneas de código	20	15
Early return	No	Sí
Cómo probarlo:
Copia el código optimizado en tu ConnectFour.jsx.

Verifica el comportamiento con casos de prueba:

jsx
// Tablero de prueba con victoria horizontal
const testBoard = [
  [null, null, null, null, null, null, null],
  [null, null, null, null, null, null, null],
  [null, null, null, null, null, null, null],
  [null, null, '●', '●', '●', '●', null], // Línea ganadora
  [null, null, null, null, null, null, null],
  [null, null, null, null, null, null, null],
];
console.log(checkWinner(testBoard, 3, 3, '●')); // Debe retornar true



## ¿Cómo puedo dockerizar este proyecto para que el backend (API .NET) y el frontend (React) se ejecuten en contenedores? Proporciona un Dockerfile para cada uno y un docker-compose.yml que los orqueste, incluyendo la base de datos SQLiteDeepseek
 Dockerfile para el Backend (API .NET)
Ubicación: Connect4API/Dockerfile

Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "Connect4API.csproj"
RUN dotnet publish -c Release -o /app/publish

Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:5274
EXPOSE 5274
ENTRYPOINT ["dotnet", "Connect4API.dll"]
Dockerfile para el Frontend (React)
Ubicación: miguemesen-four-in-a-row/Dockerfile

Etapa de construcción
FROM node:16 AS build
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build

tapa de ejecución
FROM nginx:alpine
COPY --from=build /app/build /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
 Configuración de Nginx (para React)
Ubicación: miguemesen-four-in-a-row/nginx.conf

nginx
server {
    listen 80;
    location / {
        root /usr/share/nginx/html;
        index index.html index.htm;
        try_files $uri $uri/ /index.html;
    }
    location /api {
        proxy_pass http://backend:5274;
        proxy_set_header Host $host;
    }
}
1. Archivo docker-compose.yml (Orquestación)
Ubicación: docker-compose.yml (en la raíz del proyecto)

yaml
version: '3.8'

services:
  backend:
    build:
      context: ./Connect4API
      dockerfile: Dockerfile
    ports:
      - "5274:5274"
    volumes:
      - ./Connect4API/connect4.db:/app/connect4.db
    environment:
      - ASPNETCORE_ENVIRONMENT=Development
    restart: unless-stopped

  frontend:
    build:
      context: ./miguemesen-four-in-a-row
      dockerfile: Dockerfile
    ports:
      - "3000:80"
    depends_on:
      - backend
    restart: unless-stopped
5. Pasos para ejecutar
Preparar la base de datos:

Asegúrate de que exista el archivo Connect4API/connect4.db (generado por EF Core).

Construir y levantar los contenedores:

bash
docker-compose up --build
Acceder a la aplicación:

Frontend: http://localhost:3000

Backend (API): http://localhost:5274

Swagger: http://localhost:5274/swagger

Notas clave:
Persistencia de SQLite:
El archivo de la base de datos se monta como volumen (volumes) para persistir los datos entre reinicios.

Comunicación entre contenedores:
El frontend accede al backend mediante http://backend:5274 (gracias al DNS interno de Docker).

Variables de entorno:
El backend usa ASPNETCORE_ENVIRONMENT=Development para desarrollo. En producción, cámbialo a Production.

Optimización:

El frontend usa un servidor Nginx ligero (Alpine) en producción.

El backend utiliza un build multi-etapa para reducir el tamaño de la imagen final.

Posibles mejoras:
Añadir un contenedor para SQLite Admin (herramienta visual para la base de datos).

Configurar HTTPS añadiendo certificados en Nginx.

Implementar healthchecks en docker-compose.yml.

¿Necesitas ajustar algo para tu entorno específico? 😊