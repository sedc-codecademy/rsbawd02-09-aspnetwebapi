using Microsoft.AspNetCore.Mvc;
using NoteApiMultipleDB.Abstraction;
using NoteApiMultipleDB.Models;

namespace NoteApiMultipleDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private INoteRepository _noteRepository;
        public NotesController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }


        [HttpPost]
        [Route("addNewNote")]
        public IActionResult Create([FromBody] Note model)
        {
            try
            {
                _noteRepository.Add(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Note> allNotes =  _noteRepository.GetAll();

                return Ok(allNotes);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete([FromBody] Note model)
        {
            try
            {
                _noteRepository.Delete(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Note note = _noteRepository.GetById(id);
                
                return Ok(note);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Note model)
        {
            try
            {
                _noteRepository.Update(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
