using BooksAPI.Enums;

namespace BooksAPI.Models;

public class Book
{
    public int Id { get; set; }            // Unique identifier for the book
    public string Title { get; set; }       // Title of the book
    public string Author { get; set; }      // Author of the book
    public int YearPublished { get; set; }  // Year the book was published
    public GenreEnum Genre { get; set; }    // Genre of the book
}
