using Microsoft.AspNetCore.Mvc;

namespace dotnet10_api.Controllers;

[ApiController]
public class HealthController : ControllerBase
{
    [HttpGet("/health")]
    public IActionResult Get() => Ok(new { status = "ok", service = ".NET 10 WebAPI" });
}
