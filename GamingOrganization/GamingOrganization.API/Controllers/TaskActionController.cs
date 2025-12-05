using Microsoft.AspNetCore.Mvc;
/**
 * 
 * Controller para ações específicas da tarefa, como completá-la, abandoná-la ou iniciá-la
 * 
 */
namespace GamingOrganization.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskActionController : ControllerBase
    {
        [HttpPost]
        [Route("{Id}/complete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CompleteTask([FromRoute] Guid Id)
        {
            return Ok();
        }


        [HttpPost]
        [Route("{Id}/start")]
        public IActionResult StartTask([FromRoute] Guid Id)
        {
            return Ok();
        }


        [HttpPost]
        [Route("{Id}/abandon")]
        public IActionResult StopTask([FromRoute] Guid Id)
        {
            return Ok();
        }
    }
}
