using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicController : ControllerBase
{
    [HttpGet]
    public IActionResult Basic()
    {
        return Ok();
    }
}