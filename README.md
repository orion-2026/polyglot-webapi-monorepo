# Polyglot WebAPI Monorepo

A small comparison monorepo with three minimal Web API implementations:

- .NET 10 WebAPI
- Go + Gin
- NestJS

## Structure

- `apps/dotnet10-api`
- `apps/gin-api`
- `apps/nestjs-api`

## Common endpoints

Each service exposes:

- `GET /health` → service health check
- `GET /api/hello` → hello payload
- `GET /api/todos` → sample todo list

## Ports

- .NET 10 WebAPI: default ASP.NET development port
- Gin API: `8081`
- NestJS API: default Nest port `3000`

## Shared API spec

- Root spec file: `openapi.yaml`
- Goal: keep all three implementations aligned on the same contract

## Run locally

### .NET 10 WebAPI

```bash
export PATH="/home/ubuntu/.local/share/dotnet:$PATH"
cd apps/dotnet10-api
dotnet run
```

### Go + Gin

```bash
cd apps/gin-api
go run .
```

### NestJS

```bash
cd apps/nestjs-api
npm install
npm run start
```

## Run with Docker

Build and start all services:

```bash
docker compose up --build
```

Then access:

- .NET 10 WebAPI → `http://localhost:8080`
- Go Gin API → `http://localhost:8081`
- NestJS API → `http://localhost:3000`
