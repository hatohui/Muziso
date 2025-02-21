using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("hello")]
public class DoGetFirst : ControllerBase
{
    [HttpGet]
    public IActionResult GetString()
    {
        var hello = new
        {
            message = "Hello"
        };

        return Ok(hello); 
    }
}