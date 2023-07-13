using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VoluyakAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetScores()
        {
            return Ok("Volyak GET");
        }

        [HttpPost]
        public IActionResult List()
        {
            return Ok("Volyak POST");
        }
    }
}
