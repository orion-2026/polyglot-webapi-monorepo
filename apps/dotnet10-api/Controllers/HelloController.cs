using Microsoft.AspNetCore.Mvc;

namespace dotnet10_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new
    {
        message = "Hello from .NET 10 WebAPI",
        framework = ".NET 10",
        timestamp = DateTimeOffset.UtcNow
    });
}
