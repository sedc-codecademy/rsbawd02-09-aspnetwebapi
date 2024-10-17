using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.NotesApp.Dtos;
using SEDC.NotesApp.Services.Interfaces;
using SEDC.NotesApp.Shared.CustomExceptions;

namespace SEDC.NotesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService) //DI
        {
        }

        [HttpGet]
        public ActionResult<List<NoteDto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<NoteDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("addNote")]
        public IActionResult AddNote([FromBody] AddNoteDto addNoteDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult UpdateNote([FromBody] UpdateNoteDto updateNoteDto)
        {
            try
            {
                _noteService.UpdateNote(updateNoteDto);
                return NoContent(); //204
            }
            catch(NoteNotFoundException e)
            {
                return NotFound(e.Message); //404
            }
            catch(NoteDataException e)
            {
                return BadRequest(e.Message); //400
            }
            catch (Exception e)
            {
                //log
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, contact the admin!");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            try
            {
                _noteService.DeleteNote(id);
                return Ok($"Note with id {id} successfully deleted!");
            }
            catch (NoteNotFoundException e)
            {
                return NotFound(e.Message); //404
            }
            catch (Exception e)
            {
                //log
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, contact the admin!");
            }
        }
    }
}
