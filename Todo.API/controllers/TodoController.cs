using Microsoft.AspNetCore.Mvc;

namespace TheTodoApp.API
{
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _log;
        public TodoController(ILogger<TodoController> log)
        {
            _log = log;
        }

        [HttpGet]
        public IActionResult GetAsync()
        {

        }

        [HttpGet("{id}")]
        public IActionResult GetAsync([FromRoute] int id)
        {

        }

        [HttpPost]
        public IActionResult PostAsync([FromBody] Todo todo)
        {

        }

        [HttpPatch("{id}")]
        public IActionResult PatchAsync([FromRoute] int id, [FromBody] Todo todo)
        {

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAsync([FromRoute] int id)
        {

        }
    }
}