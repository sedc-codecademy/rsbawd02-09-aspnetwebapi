using Our.MoviesApp.Enums;
using Our.MoviesApp.Models;

namespace Our.MoviesApp.Database;

public static class StaticDb
{
    public static int MovieId = 6;

    public static List<Movie> Movies = new List<Movie>()
    {
        new Movie
        {
            Id = 1,
            Title = "Top Gun:Maverick",
            Description = "Action movie",
            Genre = GenreEnum.Action,
            Year = 2022
        },

        new Movie
        {
            Id = 2,
            Title = "Dumb and dumber",
            Description = "Action movie",
            Genre = GenreEnum.Comedy,
            Year = 1994
        },

        new Movie
        {
            Id = 3,
            Title = "The Shawshank Redemption",
            Description = "Drama movie",
            Genre = GenreEnum.Action,
            Year = 1994
        },

        new Movie
        {
            Id = 4,
            Title = "The Dark Knight",
            Description = "Action movie",
            Genre = GenreEnum.Action,
            Year = 2008
        },

        new Movie
        {
            Id = 5,
            Title = "Forrest Gump",
            Description = "Drama movie",
            Genre = GenreEnum.Action,
            Year = 1994
        },

        new Movie
        {
            Id = 6,
            Title = "The Lord of the Rings: The Fellowship of the Ring",
            Description = "Fantasy movie",
            Genre = GenreEnum.Action,
            Year = 2001
        },
    };
}
