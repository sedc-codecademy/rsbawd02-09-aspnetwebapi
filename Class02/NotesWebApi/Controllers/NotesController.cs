using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesWebApi.Data;
using NotesWebApi.Models;

namespace NotesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        public NotesController() { }

        [HttpGet("getAll")]
        public ActionResult<List<NoteItem>> GetAll()
        {
            List<NoteItem> result = StaticDB
                .SimpleNotes
                .OrderBy(x => x.Content)
                .ToList();

            return Ok(result);
        }

        [HttpGet("getById/{id}")]
        public ActionResult<NoteItem> GetById(int id) 
        {
            NoteItem result = StaticDB
                    .SimpleNotes
                    .Where(ni => ni.Id == id)
                    .FirstOrDefault();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost("create")]
        public ActionResult Create([FromBody] NoteItem item) 
        {
            if (item == null)
                return BadRequest("The provided data can not be null");

            StaticDB.SimpleNotes.Add(item);

            return Ok();
        }
    }
}
