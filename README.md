# API con .NET Core y SQL Server

Este ejercicio tiene como objetivo desarrollar una API utilizando .NET Core, la cual se conectará a una base de datos SQL Server. A continuación se detallan los pasos para configurar y ejecutar el proyecto desde la línea de comandos.

## Prerrequisitos

Antes de ejecutar el proyecto, asegúrate de tener instalados los siguientes componentes:

- **.NET SDK**: Descarga e instala la última versión (9.0) del [SDK de .NET](https://dotnet.microsoft.com/download). Verifica la instalación ejecutando:
  ```bash
  dotnet --version
  ```
- **Git** (opcional): Para clonar el repositorio si aún no tienes los archivos del proyecto.

## Instrucciones de Configuración

1. **Clonar el Repositorio**  
   Si aún no has descargado el proyecto, clónalo usando Git:
   ```bash
   git clone https://github.com/skemono/EjercicioAPInetCore.git
   cd EjercicioAPInetCore
   ```
2. **Clonar el Repositorio**  
   Si aún no has descargado el proyecto, clónalo usando Git:
   ```bash
   git clone https://github.com/skemono/EjercicioAPInetCore.git
   cd EjercicioAPInetCore
   ```
3. **Entrar a la carpeta principal**  
   ```bash
   cd EjercicioAPInetCore
   ```
4. **Restaurar Dependencias**
   Restaura los paquetes NuGet necesarios:
   ```bash
   dotnet restore
   ```
5. **Construir el Proyecto**  
   Compila el proyecto para asegurarte de que todo se construye correctamente:
   ```bash
   dotnet build
   ```

6. **Ejecutar la API**  
   Ejecuta la API con:
   ```bash
   dotnet run
   ```
   La aplicación estara escuchando en `https://localhost:7146/incidents` y `http://localhost:5004/incidents`.

## Endpoints
- **POST /incidents**  
  Crea un nuevo incidente.

- **GET /incidents**  
  Obtiene la lista de incidentes.

- **GET /incidents/{id}**  
  Obtiene un incidente específico.

- **PUT /incidents/{id}**  
  Actualiza el estado de un incidente.

- **DELETE /incidents/{id}**  
  Elimina un incidente reportado por error.

