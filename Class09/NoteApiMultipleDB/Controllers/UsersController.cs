using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApiMultipleDB.Abstraction;
using NoteApiMultipleDB.Models;

namespace NoteApiMultipleDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                // for homework
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete([FromBody] User model)
        {
            try
            {
                // for homework
                throw new NotImplementedException();

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
                // for homework
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] User model)
        {
            try
            {
                // for homework
                throw new NotImplementedException();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

    }
}
