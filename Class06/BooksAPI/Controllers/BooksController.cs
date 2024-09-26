using BooksAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        // GET: api/books
        [HttpGet]
        public ActionResult<List<BookDto>> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        // GET: api/books/{id}
        [HttpGet("{id}")]
        public ActionResult<BookDto> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        // GET: api/books/filter?genre={genre}&year={year}
        [HttpGet("filter")]
        public ActionResult<List<BookDto>> FilterBooks([FromQuery] GenreEnum? genre, [FromQuery] int? year)
        {
            throw new NotImplementedException();
        }

        // PUT: api/books/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateBook(int id, [FromBody] UpdateBookDto updateBookDto)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/books/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/books
        // Implement AddBook Action here...
    }
}