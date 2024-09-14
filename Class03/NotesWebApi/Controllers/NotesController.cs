using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
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

        [HttpGet("getByIdQueryParams")]
        public ActionResult<NoteItem> GetByIdQuery(int? identificationNumber, string userName)
        {
            if (identificationNumber == null)
                return BadRequest();

            NoteItem result = StaticDB
                    .SimpleNotes
                    .Where(ni => ni.Id == identificationNumber)
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

        [HttpPost("createv2")]
        public ActionResult CreateItem([FromQuery]NoteItem item, [FromQuery(Name = "tag")] string tag)
        {
            if (item == null)
                return BadRequest("The provided data can not be null");

            StaticDB.SimpleNotes.Add(item);

            return Ok();
        }

        [HttpPost("echo")]
        public ActionResult Echo([FromHeader(Name = "SEAVUS_TOKEN")] string token)
        {
            return Ok(token);
        }

        [HttpPost("headersTest")]
        public ActionResult HeaderTest([FromHeader(Name = "Accept-Language")] string? language)
        {
            if (language == "en")
            {
                string content = "Some en language content";
                return Ok(content);
            }

            return Ok("Language unknown");
        }

        /// <summary>
        /// This is an endpoint for deleting notes, the caller must provided valid ID for the note to be deleted... this is written by dev team. 14.09.2024 Release 1.26.0
        /// </summary>
        [HttpDelete("deleteNote")]
        public ActionResult DeleteNote(int id)
        {
            NoteItem noteToDelete = StaticDB
                .SimpleNotes
                .FirstOrDefault(x => x.Id == id);

            if (noteToDelete == null)
                return NotFound();
          
            bool removed = StaticDB
                .SimpleNotes
                .Remove(noteToDelete);

            if (removed)
                return Ok();

            return BadRequest();
        }
    }
}
