using Microsoft.AspNetCore.Mvc;
using dotnet10_api.Models;

namespace dotnet10_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new[]
    {
        new TodoItem(1, "Create polyglot sample", true),
        new TodoItem(2, "Compare framework styles", false),
        new TodoItem(3, "Push repo to GitHub", false)
    });
}
