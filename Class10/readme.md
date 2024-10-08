# Exercise 1: Implementing CRUD Operations in the `Movie App`

In this exercise, you will work with the `MovieRepository`, Service and Controller class, which is responsible for performing CRUD (Create, Read, Update, Delete) operations on notes in the MoviesApp database. Your task is to implement the existing methods to make the repository and other components fully functional.

## First steps:


1. **Database Configuration:**

   Adjust the connection string in the Program.cs file to match your database setup.

2. **Add a Migration:**

   Using Entity Framework, create a migration to represent changes in your data model. Use the following command: **add-migration YourMigrationName**

3. **Update the Database:**
    
    Apply the migration to update the database schema with the following command: **update-database**

# Exercise: Implementing Movie Repository Methods

In this exercise, you will implement various methods in the `MovieRepository` class, responsible for interacting with the MoviesDbContext to perform CRUD operations on movie data.

## Task:

Your goal is to complete the implementation of the methods in the `MovieRepository` class. Follow the instructions for each method to ensure accurate and functional behavior.

**1. Implement the `Add` Method:**

   - Open the `MovieRepository` class.
   - Find the `Add` method, which adds a new movie to the database.
   - Implement the method to add the provided movie entity to the `_context.Movies` and save the changes to the database using `_context.SaveChanges()`.

**2. Implement the `Delete` Method:**

   - Locate the `Delete` method in the `MovieRepository`.
   - Implement the method to remove the specified movie entity from the `_context.Movies` and save the changes to the database.

**3. Implement the `FilterMovies` Method:**

   - Find the `FilterMovies` method in the `MovieRepository`. This method filters movies based on the provided year and genre.
   - Implement the method to return a list of movies based on the following conditions:
      - If both `year` and `genre` are null, return all movies.
      - If only `year` is null, return movies filtered by genre.
      - If only `genre` is null, return movies filtered by year.
      - If both `year` and `genre` are provided, return movies filtered by both.

**4. Implement the `GetAll` Method:**

   - Find the `GetAll` method in the `MovieRepository`. This method retrieves all movies from the database.
   - Implement the method to return all movies in the `_context.Movies`.

**5. Implement the `GetById` Method:**

   - Locate the `GetById` method in the `MovieRepository`. This method retrieves a movie by its unique identifier (id).
   - Implement the method to return the movie from `_context.Movies` where the id matches the provided parameter.

**6. Implement the `Update` Method:**

   - Find the `Update` method in the `MovieRepository`. This method updates an existing movie in the database.
   - Implement the method to update the provided movie entity within the `_context.Movies` and save the changes to the database.

## Note:

- Ensure that you handle exceptions and potential errors that may occur during database operations.
- Test each of the implemented methods to verify their correctness and functionality.

By completing this exercise, you will gain hands-on experience in implementing CRUD operations in the `MovieRepository` class, reinforcing your understanding of database interactions in ASP.NET Core applications.


# Exercise: Implementing Movie Controller Actions

In this exercise, you will implement various actions in the `MoviesController` class, responsible for handling HTTP requests related to movies. The controller interacts with the `IMovieService` to perform operations on movie data.

## Task:

Your goal is to complete the implementation of the actions in the `MoviesController` class. Follow the instructions for each action to ensure accurate and functional behavior.

**1. Implement the `Get` Action:**

   - Open the `MoviesController` class.
   - Locate the `Get` action, which retrieves all movies.
   - Implement the action to call the corresponding method in the `_movieRepository` to get all movies.
   - Handle exceptions and return appropriate status codes and messages.

**2. Implement the `Filter` Action:**

   - Find the `Filter` action in the `MoviesController`. This action filters movies based on the provided `year` and `genre`.
   - Implement the action to call the corresponding method in the `_movieRepository` to filter movies by `year` and `genre`.
   - Handle exceptions and return appropriate status codes and messages.

**3. Implement the `GetById` Action:**

   - Locate the `GetById` action in the `MoviesController`. This action retrieves a movie by its unique identifier (`id`).
   - Implement the action to call the corresponding method in the `_movieRepository` to get the movie by `id`.
   - Handle exceptions and return appropriate status codes and messages.

**4. Implement the `UpdateMovie` Action:**

   - Find the `UpdateMovie` action in the `MoviesController`. This action updates an existing movie.
   - Implement the action to call the corresponding method in the `_movieRepository` to update the existing movie.
   - Handle exceptions and return appropriate status codes and messages.

**5. Implement the `Delete` Action:**

   - Locate the `Delete` action in the `MoviesController`. This action deletes a movie by its unique identifier (`id`).
   - Implement the action to call the corresponding method in the `_movieRepository` to delete the movie.
   - Handle exceptions and return appropriate status codes and messages.

**6. Implement the `AddMovie` Action:**

   - Find the `AddMovie` action in the `MoviesController`. This action adds a new movie.
   - Implement the action to call the corresponding method in the `` to add the new movie.
   - Handle exceptions and return appropriate status codes and messages.

## Note:

- Ensure that you handle exceptions and potential errors that may occur during movie operations.
- Test each of the implemented actions using tools like Postman or Swagger to verify their correctness and functionality.

By completing this exercise, you will gain hands-on experience in implementing controller actions for movie operations in an ASP.NET Core application.
