using Our.MoviesApp.Domain;
using Our.MoviesApp.Dtos;

namespace Our.MoviesApp.Mappers
{
    public static class MovieMapper
    {
        public static Movie ToMovie(this AddMovieDto addMovieDto)
        {
            return new Movie
            {
                Year = addMovieDto.Year,
                Description = addMovieDto.Description,
                Genre = addMovieDto.Genre,
                Title = addMovieDto.Title
            };
        }

        public static MovieDto ToMovieDto(this Movie movie)
        {
            return new MovieDto
            {
                Year = movie.Year,
                Description = movie.Description,
                Genre = movie.Genre,
                Title = movie.Title
            };
        }
    }
}
