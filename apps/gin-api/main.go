package main

import (
    "net/http"
    "time"

    "github.com/gin-gonic/gin"
)

type TodoItem struct {
    ID    int    `json:"id"`
    Title string `json:"title"`
    Done  bool   `json:"done"`
}

func main() {
    r := gin.Default()

    r.GET("/health", func(c *gin.Context) {
        c.JSON(http.StatusOK, gin.H{"status": "ok", "service": "Go Gin API"})
    })

    r.GET("/api/hello", func(c *gin.Context) {
        c.JSON(http.StatusOK, gin.H{
            "message":   "Hello from Go Gin API",
            "framework": "Gin",
            "timestamp": time.Now().UTC().Format(time.RFC3339),
        })
    })

    r.GET("/api/todos", func(c *gin.Context) {
        c.JSON(http.StatusOK, []TodoItem{
            {ID: 1, Title: "Create polyglot sample", Done: true},
            {ID: 2, Title: "Compare framework styles", Done: false},
            {ID: 3, Title: "Push repo to GitHub", Done: false},
        })
    })

    _ = r.Run(":8081")
}
