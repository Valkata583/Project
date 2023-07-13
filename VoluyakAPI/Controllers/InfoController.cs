using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VoluyakAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetGameDetails([FromBody] string id)
        {

            return Ok(id.ToString());
        }
    }
}
