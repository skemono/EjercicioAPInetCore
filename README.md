# API con .NET Core y SQL Server

Este ejercicio tiene como objetivo desarrollar una API utilizando .NET Core, la cual se conectará a una base de datos SQL Server. A continuación se detallan los pasos para configurar y ejecutar el proyecto desde la línea de comandos.

## Prerrequisitos

Antes de ejecutar el proyecto, asegúrate de tener instalados los siguientes componentes:

- **Docker**: Descarga e instala docker para levantar los contenedores y la api.
- **Git** (opcional): Para clonar el repositorio si aún no tienes los archivos del proyecto.

## Instrucciones de Configuración

1. **Clonar el Repositorio**  
   Si aún no has descargado el proyecto, clónalo usando Git:
   ```bash
   git clone https://github.com/skemono/EjercicioAPInetCore.git
   ```
2. **Entrar a la carpeta principal**  
   ```bash
   cd EjercicioAPInetCore
   ```
3. **Buildea los contenedores con docker compose.**
   ```bash
   docker-compose up --build
   ```
   La aplicación estara escuchando en `http://localhost:8080` y `http://localhost:8080/incidents`

## Endpoints
- **POST /incidents**  
  Crea un nuevo incidente.

- **GET /incidents**  
  Obtiene la lista de incidentes.

- **GET /incidents/{id}**  
  Obtiene un incidente específico.

- **PUT /incidents/{id}**  
  Actualiza los datos de un incidente.

- **DELETE /incidents/{id}**  
  Elimina un incidente existente.

