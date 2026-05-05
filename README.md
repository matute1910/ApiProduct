# 🚀 API de Productos - ASP.NET Core + JWT

API REST desarrollada con **ASP.NET Core Web API** aplicando arquitectura en capas, autenticación con **JWT**, persistencia con **Entity Framework Core** y base de datos **SQL Server**.

Este proyecto simula un backend real con gestión de productos y usuarios autenticados.

-----------------------------------------------------------------------------------------------

 🧠 Tecnologías

- C#
- .NET 6 / .NET 7
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT (JSON Web Token)
- ASP.NET Identity
- Swagger (OpenAPI)

-----------------------------------------------------------------------------------------------

 📂 Arquitectura

El proyecto sigue una **arquitectura en capas**:

Estructura:
Controllers/
Services/
Repositories/
DTOs/
Models/
Data/
Middleware/
Authentication/


-----------------------------------------------------------------------------------------------

 🔐 Autenticación

Se implementa autenticación basada en **JWT**.

Flujo:

1. Registro de usuario
2. Login
3. Generación de token
4. Acceso a endpoints protegidos con `[Authorize]`

-----------------------------------------------------------------------------------------------

 📌 Endpoints principales

 🔑 Auth

| Método | Endpoint            | Descripción            |
|--------|--------------------|------------------------|
| POST   | /api/auth/register | Registro de usuario     |
| POST   | /api/auth/login    | Login y obtención JWT   |
| GET    | /api/auth/profile  | Usuario autenticado     |

---

### 📦 Productos

| Método | Endpoint              | Descripción              |
|--------|----------------------|--------------------------|
| GET    | /api/products        | Obtener todos            |
| GET    | /api/products/{id}   | Obtener por ID           |
| POST   | /api/products        | Crear producto 🔒        |
| PUT    | /api/products/{id}   | Actualizar producto 🔒   |
| DELETE | /api/products/{id}   | Eliminar producto 🔒     |

🔒 Requiere token JWT

-----------------------------------------------------------------------------------------------

## ⚙️ Cómo ejecutar el proyecto

### 1. Clonar repositorio

```bash
git clone https://github.com/matute1910/dotnet-api-jwt-clean-architecture.git
cd dotnet-api-jwt-clean-architecture
-----------------------------------------------------------------------------------------------
⚙️ Configuración

1. Base de datos

Editar `appsettings.json`:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=APIProductosDb;Trusted_Connection=True;TrustServerCertificate=True;"
}

-----------------------------------------------------------------------------------------------

 ▶️ Ejecución
### 2. Ejecutar migraciones

```bash
dotnet ef database update
3. Ejecutar la API
dotnet run

-----------------------------------------------------------------------------------------------

## 🧪 Pruebas con Swagger

Ir a:
https://localhost:xxxx/swagger
-----------------------------------------------------------------------------------------------
🔐 Autenticación
LOGIN: 
POST `/api/auth/login`

JSON
{
  "email": "admin@test.com",
  "password": "123456"
}
1- Usar token
2- Copiar token
3- Ir a Swagger → botón Authorize
4- Ingresar:
5- Bearer TU_TOKEN
-----------------------------------------------------------------------------------------------
💡 Características implementadas
- ✔ CRUD completo de productos  
- ✔ Arquitectura en capas (Controller / Service / Repository)  
- ✔ DTOs para separación de responsabilidades  
- ✔ Autenticación con JWT  
- ✔ ASP.NET Identity  
- ✔ Middleware de manejo de errores  
- ✔ Validaciones con Data Annotations  
- ✔ Uso de async/await  
- ✔ Logging con ILogger
----------------------------------------------------------------------------------------------- 
📈 Mejoras futuras
- Roles (Admin / User)
- Paginación y filtros
- AutoMapper
- Dockerización
- Tests unitarios
-----------------------------------------------------------------------------------------------
👨‍💻 Autor
**Matías Fernández**

- 💼 LinkedIn: https://www.linkedin.com/in/MatiasFernandez31  
- 💻 GitHub: https://github.com/matute1910  
- 📧 Email: matias_fernandez@live.com.ar  
-----------------------------------------------------------------------------------------------
## ⭐ Objetivo
Este proyecto forma parte de mi portfolio como desarrollador .NET Backend Developer Trainee / Junior, enfocado en buenas prácticas, arquitectura limpia y desarrollo de APIs REST.

