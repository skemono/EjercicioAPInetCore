# API con .NET Core y SQL Server

Este ejercicio tiene como objetivo desarrollar una API utilizando .NET Core, la cual se conectará a una base de datos SQL Server. A continuación se detallan los pasos para configurar y ejecutar el proyecto desde la línea de comandos.

## Prerrequisitos

Antes de ejecutar el proyecto, asegúrate de tener instalados los siguientes componentes:

- **.NET SDK**: Descarga e instala la última versión del [SDK de .NET](https://dotnet.microsoft.com/download). Verifica la instalación ejecutando:
  ```bash
  dotnet --version
  ```
- **Git** (opcional): Para clonar el repositorio si aún no tienes los archivos del proyecto.

## Instrucciones de Configuración

1. **Clonar el Repositorio**  
   Si aún no has descargado el proyecto, clónalo usando Git:
   ```bash
   git clone https://github.com/skemono/EjercicioAPInetCore.git
   cd tuprojecto
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
4. **Construir el Proyecto**  
   Compila el proyecto para asegurarte de que todo se construye correctamente:
   ```bash
   dotnet build
   ```

5. **Ejecutar la API**  
   Ejecuta la API (equivalente a usar Ctrl+F5 en Visual Studio Code) con:
   ```bash
   dotnet run
   ```
   La aplicación se iniciará y, por lo general, estará disponible en `http://localhost:5004` sino revise el output en la consola.
