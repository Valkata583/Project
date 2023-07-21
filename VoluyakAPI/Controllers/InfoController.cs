using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoluyakAPI.Models;

namespace VoluyakAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly ProjectDatabaseContext _context;
        private readonly ProjectDatabaseContext _points;
        public InfoController(ProjectDatabaseContext context)
        {
            _context = context;
           // _points = points;
        }

        public InfoController(ProjectDatabaseContext points)
        {
            _points = points;
        }

        [HttpPost]
        public IActionResult GetGameDetails([FromBody] int id)
        {

            var data = _context.Games.Find(id);






            //var desc = new Description() { Title = "Test", Descripe = "Dneska hodiujaisdjkasdhkjasjhkdaksjh kjhasd kjhaskjhd askjhd kjh" };


            //desc.Title = "Test 2";
            //var data2 = _context.Descriptions.Add(desc);





            //_context.SaveChanges();
            return Ok(id.ToString());
        }

        public IActionResult CountPoints([FromBody] int id)
        {
            var p =_points.Leaderbords.Find(id);
            _points.Points += -_points;
            return Ok(id.ToString());
        }

    }
}
