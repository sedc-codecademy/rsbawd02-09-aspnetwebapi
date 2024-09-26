using BooksAPI.Database;
using BooksAPI.DTOs;
using BooksAPI.Enums;
using BooksAPI.Models;
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
            List<BookDto> books = StaticDb
                .Books
                .Select(book => new BookDto
                {
                    Title = book.Title,
                    Author = book.Author,
                    YearPublished = book.YearPublished,
                    Genre = book.Genre
                }).ToList();

            return Ok(books);
        }

        // GET: api/books/{id}
        [HttpGet("{id}")]
        public ActionResult<BookDto> GetBookById(int id)
        {
            Book? book = StaticDb
                .Books
                .FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound($"Book with Id {id} not found.");
            }

            BookDto bookDto = new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                YearPublished = book.YearPublished,
                Genre = book.Genre
            };

            return Ok(bookDto);
        }

        // GET: api/books/filter?genre={genre}&year={year}
        [HttpGet("filter")]
        public ActionResult<List<BookDto>> FilterBooks([FromQuery] GenreEnum? genre, [FromQuery] int? year)
        {
            List<Book> filteredBooks = StaticDb
                .Books
                .ToList();

            if (genre.HasValue)
            {
                filteredBooks = filteredBooks
                    .Where(b => b.Genre == genre.Value)
                    .ToList();
            }

            if (year.HasValue)
            {
                filteredBooks = filteredBooks
                    .Where(b => b.YearPublished == year.Value)
                    .ToList();
            }

            var result = filteredBooks.Select(book => new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                YearPublished = book.YearPublished,
                Genre = book.Genre
            }).ToList();

            return Ok(result);
        }

        // PUT: api/books/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateBook(int id, [FromBody] UpdateBookDto updateBookDto)
        {
            Book? book = StaticDb.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound($"Book with Id {id} not found.");
            }

            // Update the book with new details
            book.Title = updateBookDto.Title;
            book.Author = updateBookDto.Author;
            book.YearPublished = updateBookDto.YearPublished;
            book.Genre = updateBookDto.Genre;

            return Ok("Book updated successfully.");
        }

        // DELETE: api/books/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            Book? book = StaticDb
                .Books
                .FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound($"Book with Id {id} not found.");
            }

            StaticDb.Books.Remove(book);

            return Ok($"Book with Id {id} deleted successfully.");
        }

        // POST: api/books
        [HttpPost]
        public ActionResult AddBook([FromBody] AddBookDto addBookDto)
        {
            Book newBook = new Book
            {
                Id = ++StaticDb.BookId, // Incrementing the static Id for new book
                Title = addBookDto.Title,
                Author = addBookDto.Author,
                YearPublished = addBookDto.YearPublished,
                Genre = addBookDto.Genre
            };

            StaticDb.Books.Add(newBook);

            return CreatedAtAction(nameof(AddBook), new { id = newBook.Id }, newBook);
        }
    }
}