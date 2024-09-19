using Microsoft.AspNetCore.Mvc;
using SEDC.MoviesApp.Database;
using SEDC.MoviesApp.DTOs;
using SEDC.MoviesApp.Enums;
using SEDC.MoviesApp.Models;

namespace SEDC.MoviesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet] //api/movies
        public ActionResult<List<MovieDto>> Get()
        {
            List<MovieDto> movies = StaticDb
                .Movies
                .Select(m => new MovieDto()
                {
                    Description = m.Description,
                    Genre = m.Genre,
                    Title = m.Title,
                    Year = m.Year,
                })
                .ToList();

            return Ok(movies);
        }

        [HttpGet("{id}")] //api/movies/2
        public ActionResult<MovieDto> Get(int id)
        {
            if (id <= 0)
                return BadRequest();

            MovieDto movieResponse = new MovieDto();

            try
            {
                Movie movie = StaticDb
                        .Movies
                        .FirstOrDefault(m => m.Id == id);

                if (movie == null)
                    return NotFound();

                movieResponse.Description = movie.Description;
                movieResponse.Title = movie.Title;
                movieResponse.Year = movie.Year;
                movieResponse.Genre = movie.Genre;

                return Ok(movieResponse);
            }
            catch (Exception ex)
            {
                // Log the error;
                return StatusCode(500);
            }
        }

        [HttpGet("queryString")] //api/movies/queryString?index=1
        public ActionResult<MovieDto> GetById(int id)
        {
            MovieDto movieResponse = new MovieDto();

            Movie movie = StaticDb
                .Movies
                .FirstOrDefault(m => m.Id == id);

            movieResponse.Description = movie.Description;
            movieResponse.Title = movie.Title;
            movieResponse.Year = movie.Year;
            movieResponse.Genre = movie.Genre;

            return Ok(movieResponse);
        }

        [HttpGet("filter")]   //api/movies/filter?genre=1&year=2022  
        public ActionResult<List<MovieDto>> FilterMovieFromQuery(int? genre, int? year)
        {
            List<MovieDto> movies = StaticDb
                .Movies
                .Select(m => new MovieDto()
                {
                    Description = m.Description,
                    Genre = m.Genre,
                    Title = m.Title,
                    Year = m.Year,
                })
                .ToList();

            if (genre != null)
            {
                movies = movies
                    .Where(m => m.Genre == (GenreEnum)genre)
                    .ToList();
            }

            if (year != null)
            {
                movies = movies
                    .Where(m => m.Year == year)
                    .ToList();
            }

            return Ok(movies);  
        }

        [HttpPut]
        public IActionResult UpdateMovie([FromBody] UpdateMovieDto movie)
        {
            if (movie == null)
                return BadRequest();

            try
            {
               ; Movie existingMovie = StaticDb
                        .Movies
                        .Where(m => m.Id == movie.Id)
                        .FirstOrDefault();

                if (existingMovie == null)
                    return NotFound();

                existingMovie.Title = movie.Title;
                existingMovie.Year = movie.Year;
                existingMovie.Description = movie.Description;
                existingMovie.Genre = movie.Genre;

                return Ok();
            }
            catch (Exception ex)
            {
                // log the exception to the loggger
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public IActionResult DeleteMovie([FromBody] int id)
        {
            Movie existingMovie = StaticDb
               .Movies
               .Where(m => m.Id == id)
               .FirstOrDefault();

            if (existingMovie == null)
                return NotFound();

            StaticDb.Movies.Remove(existingMovie);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Movie existingMovie = StaticDb
              .Movies
              .Where(m => m.Id == id)
              .FirstOrDefault();

            if (existingMovie == null)
                return NotFound();

            StaticDb.Movies.Remove(existingMovie);

            return Ok();
        }

        [HttpPost("addMovie")]
        public IActionResult AddMovie([FromBody]AddMovieDto addMovieDto)
        {
            if (addMovieDto == null)
                return BadRequest();
            
            try
            {
                Movie movie = new Movie();

                movie.Title = addMovieDto.Title;
                movie.Year = addMovieDto.Year;
                movie.Description = addMovieDto.Description;
                movie.Genre = addMovieDto.Genre;
                movie.Id = ++StaticDb.MovieId;

                StaticDb.Movies.Add(movie);

                return Ok();
            }
            catch (Exception ex)
            {
                // log this exception somewhere to read it later...
                return StatusCode(500);
            }
        }
    }
}
