using Microsoft.AspNetCore.Mvc;
using NotesAndTagsApp.DTOs;

namespace NotesAndTagsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet("getAll")]
        public ActionResult<List<NoteDto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<NoteDto> GetNoteById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("findById")] //http://localhost:[port]/api/notes/findById?id=2
        public ActionResult<NoteDto> FindById(int id) //id is a query string param
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateNoteDto updateNoteDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("user/{userId}")] //route params
        public ActionResult<List<NoteDto>> GetNotesByUser(int userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("addNote")]
        public IActionResult AddNote([FromBody] AddNoteDto addNoteDto)
        {
            throw new NotImplementedException();
        }
    }
}
