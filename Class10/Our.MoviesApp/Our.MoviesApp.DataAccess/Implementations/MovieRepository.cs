using Our.MoviesApp.Domain;
using Our.MoviesApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Our.MoviesApp.DataAccess
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext _context;
        public MovieRepository(MoviesDbContext context)
        {
            _context = context;
        }

        public void Add(Movie entity)
        {
            // Implement the logic to add a movie to the database
            // ...

            throw new NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            // Implement the logic to delete a movie from the database
            // ...

            throw new NotImplementedException();
        }

        public List<Movie> FilterMovies(int? year, GenreEnum? genre)
        {
            // Implement the logic to filter movies based on year and genre
            // ...

            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            // Implement the logic to retrieve all movies from the database
            // ...

            // Placeholder for NotImplementedException
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            // Implement the logic to retrieve a movie by its ID
            // ...

            throw new NotImplementedException();
        }

        public void Update(Movie update)
        {
            // Implement the logic to update a movie in the database
            // ...

            throw new NotImplementedException();
        }
    }
}
