using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserNotesAPI.Domain;

namespace UserNotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly NoteTakingDbContext _dbContext;
        public NotesController(NoteTakingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Note> response = _dbContext
                .Notes
                .Where(n => n.Text == "Test")
                .ToList();

            return Ok(response);
        }
    }
}
