using Microsoft.AspNetCore.Mvc;
using NotesAndTagsApp.Database;
using NotesAndTagsApp.DTOs;
using NotesAndTagsApp.Models;

namespace NotesAndTagsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet("getAll")]
        public ActionResult<List<NoteDto>> Get()
        {
            List<NoteDto> reponse = StaticDb
                .Notes
                .Select(n => new NoteDto()
                {
                     Priority = n.Priority,
                     Tags = n.Tags.Select(t => t.Name).ToList(),
                     Text = n.Text,
                     User = $"{n.User.FirstName} {n.User.LastName}"
                }).ToList();

            return Ok(reponse);
        }

        [HttpGet("{id}")]
        public ActionResult<NoteDto> GetNoteById(int id)
        {
            if (id == 0)
                return BadRequest();

            NoteDto reponse = StaticDb
                .Notes
                .Where(n => n.Id == id)
                .Select(n => new NoteDto()
                {
                    Priority = n.Priority,
                    Tags = n.Tags.Select(t => t.Name).ToList(),
                    Text = n.Text,
                    User = $"{n.User.FirstName} {n.User.LastName}"
                }).FirstOrDefault();

            if (reponse == null)
                return NotFound();

            return Ok(reponse);
        }

        [HttpGet("findById")] //http://localhost:[port]/api/notes/findById?id=2
        public ActionResult<NoteDto> FindById(int id) //id is a query string param
        {
            if (id == 0)
                return BadRequest();

            NoteDto reponse = StaticDb
                .Notes
                .Where(n => n.Id == id)
                .Select(n => new NoteDto()
                {
                    Priority = n.Priority,
                    Tags = n.Tags.Select(t => t.Name).ToList(),
                    Text = n.Text,
                    User = $"{n.User.FirstName} {n.User.LastName}"
                }).FirstOrDefault();

            if (reponse == null)
                return NotFound();

            return Ok(reponse);
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateNoteDto updateNoteDto)
        {
            if (updateNoteDto == null)
                return BadRequest();

            Note entity = StaticDb
                .Notes
                .Where(n => n.Id == updateNoteDto.Id)
                .FirstOrDefault();

            if (entity == null)
                return NotFound();

            // We update the "old" data with new updated data from passed dto
            entity.Text = updateNoteDto.Text;
            entity.User = StaticDb
                .Users
                .FirstOrDefault(u => u.Id == updateNoteDto.UserId);
            entity.Priority = updateNoteDto.Priority;
            entity.Tags = StaticDb
                .Tags
                .Where(t => updateNoteDto.TagIds.Contains(t.Id))
                .ToList();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            if (id <= 0)
                return BadRequest();

            Note entity = StaticDb
                .Notes
                .Where(n => n.Id == id)
                .FirstOrDefault();

            StaticDb
                .Notes
                .Remove(entity);

            return Ok();
        }

        [HttpGet("user/{userId}")] //route params
        public ActionResult<List<NoteDto>> GetNotesByUser(int userId)
        {
            List<NoteDto> reponse = StaticDb
                 .Notes
                 .Where (n => n.UserId == userId)
                 .Select(n => new NoteDto()
                 {
                     Priority = n.Priority,
                     Tags = n.Tags.Select(t => t.Name).ToList(),
                     Text = n.Text,
                     User = $"{n.User.FirstName} {n.User.LastName}"
                 }).ToList();

            return Ok(reponse);
        }

        [HttpPost("addNote")]
        public IActionResult AddNote([FromBody] AddNoteDto addNoteDto)
        {
            Note note = new Note()
            {
                Id = ++StaticDb.NoteId,
                Priority = addNoteDto.Priority,
                Text = addNoteDto.Text,
                UserId = addNoteDto.UserId,
                User = StaticDb
                    .Users
                    .FirstOrDefault(u => u.Id == addNoteDto.UserId),
                Tags = StaticDb
                    .Tags
                    .Where(t => addNoteDto.TagIds.Contains(t.Id))
                    .ToList()
            };

            StaticDb
                .Notes
                .Add(note);

            return Ok();
        }
    }
}
