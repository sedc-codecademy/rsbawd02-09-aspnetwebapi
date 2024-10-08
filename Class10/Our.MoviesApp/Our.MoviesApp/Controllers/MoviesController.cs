using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Our.MoviesApp.DataAccess;
using Our.MoviesApp.Domain;
using Our.MoviesApp.Dtos;
using Our.MoviesApp.Shared;

namespace Our.MoviesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet] //api/movies
        public ActionResult<List<MovieDto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("filter")]
        public ActionResult<List<MovieDto>> Filter(int year, GenreEnum? genre)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")] //api/movies/2
        public ActionResult<MovieDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult UpdateMovie([FromBody] UpdateMovieDto movie)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("addMovie")]
        public IActionResult AddMovie([FromBody] AddMovieDto movieDto)
        {
            throw new NotImplementedException();
        }
    }
}
