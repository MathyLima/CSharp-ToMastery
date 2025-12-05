using Microsoft.AspNetCore.Mvc;

namespace GamingOrganization.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgressController : ControllerBase
    {
        [HttpGet]
        [Route("me")]
        public IActionResult MyProgress()
        {
            return Ok();
        }
    }
}
