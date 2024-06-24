using Microsoft.AspNetCore.Mvc;

namespace testApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicController : ControllerBase
{
    [HttpGet]
    [Route("Basic")]
    public IActionResult Basic()
    {
        return Ok();
    }

    [HttpGet]
    [Route("Teste")]
    public IActionResult Test()
    {
        return Ok();
    }
}