using Our.MoviesApp.Domain;


namespace Our.MoviesApp.DataAccess
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> FilterMovies(int? year, GenreEnum? genre);
    }
}
