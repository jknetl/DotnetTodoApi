using Microsoft.AspNetCore.Mvc;

namespace DotnetTodoApi.Controllers;

[ApiController]
[Route("[controller]")]
[Route("/")]
public class HealthController : ControllerBase
{

    [HttpGet]
    public String Get()
    {
        return "OK";
    }
}
