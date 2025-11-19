# Finshark API

A simple RESTful API built with **ASP.NET Core 8** that manages **Stocks** and **Comments** using the Repository Pattern.

## Features
- CRUD for Stocks  
- CRUD for Comments  
- Comment filtering, sorting, and pagination  
- DTO + Mapper for clean API responses  
- 1-to-many relationship: one Stock can have many Comments  
- Swagger UI included

## Endpoints

### Stocks
- GET    /api/stock
- GET    /api/stock/{id}
- POST   /api/stock
- PUT    /api/stock/{id}
- DELETE /api/stock/{id}

### Comments
- GET    /api/comment
- GET    /api/comment/{id}
- POST   /api/comment/{symbol}
- PUT    /api/comment/{id}
- DELETE /api/comment/{id}

## Tech Stack
- ASP.NET Core 8  
- Entity Framework Core  
- SQL Server  
- Swagger (Swashbuckle)  
- Newtonsoft.Json  

