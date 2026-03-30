FROM golang:1.22-alpine AS build
WORKDIR /app
COPY apps/gin-api/go.mod apps/gin-api/go.sum ./
RUN go mod download
COPY apps/gin-api/ .
RUN CGO_ENABLED=0 GOOS=linux go build -o gin-api .

FROM alpine:3.20
WORKDIR /app
COPY --from=build /app/gin-api ./gin-api
EXPOSE 8081
CMD ["./gin-api"]
