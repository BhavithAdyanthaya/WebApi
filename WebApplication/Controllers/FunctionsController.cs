
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
public class FunctionsController : ControllerBase
{
    [HttpGet("/[action]")]
    public IActionResult AddTwoValues(decimal value1, decimal value2)
    {
        return Ok(value1 + value2);
    }

}
