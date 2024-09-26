using BooksAPI.Enums;

namespace BooksAPI.DTOs;

public class AddBookDto
{
    public string Title { get; internal set; }
    public string Author { get; internal set; }
    public int YearPublished { get; internal set; }
    public GenreEnum Genre { get; internal set; }
}
