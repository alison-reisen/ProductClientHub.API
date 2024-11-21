using Microsoft.AspNetCore.Mvc;

namespace ProjectClientHub.API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Registro()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualiza()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPorID(Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Deleta()
        {
            return Ok();
        }
    }
}
