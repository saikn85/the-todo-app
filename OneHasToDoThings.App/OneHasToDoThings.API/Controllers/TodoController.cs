using Microsoft.AspNetCore.Mvc;
using OneHasToDoThings.Domain;

namespace OneHasToDoThings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController : ControllerBase
{
    #region Dependencies

    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    #endregion

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put([FromRoute] int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete([FromRoute] int id)
    {
    }
}
