# API Gestion de Barajas y Cartas

en este proyecto se implementan microservicios implementados en .net 9, el cual permite la gestion de Barajas y Cartas para un mini juego.
(Observacion: el Gateway YARP con Docker tiene problemas al redirigir por su URL que seria el ```http://localhost:8002/ ```)

El sistema posee:
  * **BarajasService** encargado de gestionar las Barajas (CRUD de Barajas)
  * **CartasService** encargado de gestionar las Cartas (CRUD de Cartas)

## Tecnologías Utilizadas
  * ASP.NET Core 9
  * Docker + Docker Compose
  * DB PostgreSQL
  * Patron Repository, Services.
  * API Gateway YARP.

---

# Estructura del Proyecto
```bash
PracticaAPI/
├── GatewayService/           # Redirecciona solicitudes a microservicios
├── BarajasService/           # Microservicio de Barajas
├── CartasService/            # Microservicio de Cartas 
└── docker-compose.yml        # Orquestación de servicios
```

---

## Instrucciones del Proyecto.

1. Clonar Repositorio.
```bash
git clone https://github.com/ZeroxRikumi/APIPractica.git
```
2. Levantar Docker.
```bash
cd PracticaAPI
docker-compose up --build
```
3. Acceder a los Servicios.

Listar Cartas.
```bash
http://localhost:8003/api/cartas
```
Listar Barajas.
```bash
http://localhost:8004/api/barajas
```
Listar Carta Especifica.
```bash
http://localhost:8003/api/cartas/{id}
```
Listar Baraja Especifica.
```bash
http://localhost:8004/api/barajas/{id}
```
---
## Endpoints.

### Barajas.

 * `GET /api/barajas` → Lista todas las Barajas registradas.
 * `GET /api/barajas/{id}` → Lista una de las Barajas registradas en especifico.
 * `POST /api/barajas` → Crea una nueva Baraja.
 * `PUT /api/barajas/{id}` → Modifica una nueva Baraja.
 * `DELETE /api/barajas/{id}` → Elimina una Baraja especifica.

### Cartas.
 * `GET /api/cartas` → Lista todas las Cartas registradas.
 * `GET /api/cartas/{id}` → Lista una de las Cartas registradas en especifico.
 * `POST /api/cartas` → Crea una nueva Carta.
 * `PUT /api/cartas/{id}` → Modifica una nueva Carta.
 * `DELETE /api/cartas/{id}` → Elimina una Carta especifica.

---
