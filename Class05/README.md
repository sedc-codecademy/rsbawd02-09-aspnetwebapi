# Workshop for Class 05 - Movies app CRUD Web API
<br>
<br>

## <strong>Part 1</strong>: Working with classes

### Exercise 1: Create a Movie Class
- **Task**: Create a `Movie` class with specific properties.
- **Instructions**: 
  - Create a class named `Movie`.
  - Add the following properties to the `Movie` class:
    - `Id`: An integer property to store the movie's unique identifier.
    - `Title`: A string property to store the movie's title.
    - `Description`: A string property to store a brief description of the movie.
    - `Year`: An integer property to store the year the movie was released.
    - `Genre`: A property of the `GenreEnum` enumeration to represent the movie's genre.

### Exercise 2: Define GenreEnum
- **Task**: Define an enumeration for movie genres.
- **Instructions**:
  - Create an enumeration named `GenreEnum`.
  - Define two genre values:
    - `Comedy` with a value of 1.
    - `Action` with a value of 2.

### Exercise 3: Uncomment code in the StaticDb class which is provided for you in the Database folder, the project should build without errors.

<br>
<br>

## <strong>Part 2</strong>: Implement existing DTOs in this project 

### Implement an AddMovieDto Class
- **Task**: Implement an `AddMovieDto` existing class with specific properties for adding a new movie.
- **Instructions**:
  - Implement (complete) a class named `AddMovieDto`.
  - Add the following properties to the `AddMovieDto` class:
    - `Title`: A string property to store the movie's title.
    - `Description`: A string property to store a brief description of the movie.
    - `Year`: An integer property to store the year the movie was released.
    - `Genre`: A property of the `GenreEnum` enumeration to represent the movie's genre.

### Implement a MovieDto Class
- **Task**: Implement (complete) a `MovieDto` existing class with specific properties for displaying movie information.
- **Instructions**:
  - Create a class named `MovieDto`.
  - Add the following properties to the `MovieDto` class:
    - `Title`: A string property to store the movie's title.
    - `Description`: A string property to store a brief description of the movie.
    - `Year`: An integer property to store the year the movie was released.
    - `Genre`: A property of the `GenreEnum` enumeration to represent the movie's genre.

### Implement an UpdateMovieDto Class
- **Task**: Implement (complete) an `UpdateMovieDto` existing class with specific properties for updating existing movie details.
- **Instructions**:
  - Create a class named `UpdateMovieDto`.
  - Add the following properties to the `UpdateMovieDto` class:
    - `Id`: An integer property to uniquely identify the movie to be updated.
    - `Title`: A string property to store the movie's updated title.
    - `Description`: A string property to store the movie's updated description.
    - `Year`: An integer property to store the movie's updated release year.
    - `Genre`: A property of the `GenreEnum` enumeration to represent the movie's updated genre.

<br>
<br>

## <strong>Part 3</strong>: Implement actions in Controller

## In the "Movies" Controller, Implement the Following Actions:

<br>

### (Hint: Test these with Swagger or with Postman)

<br>

### Exercise 1: Retrieve All Movies
- Implement an action to retrieve all movies (GET request).
- Use the `MovieDto` model to represent each movie.

### Exercise 2: Retrieve a Movie by ID
- Implement an action that retrieves a movie by its ID (GET request).
- Ensure that the action handles cases where the provided ID is negative, where a movie with the given ID does not exist, and where a valid movie is found.
- Return an appropriate response in each case.

### Exercise 3: Retrieve a Movie by ID Using Query String
- Implement an action that retrieves a movie by its ID using a query string parameter (GET request).
- Ensure that the action handles cases where the provided ID is negative, where a movie with the given ID does not exist, and where a valid movie is found.
- Return an appropriate response in each case.

### Exercise 4: Filter Movies by Genre and Year
- Implement an action that allows filtering movies by genre and/or year (GET request) using query string parameters.
- Validate the filter parameters and return a list of filtered movies.
- Handle cases where no filter parameters are provided and where filter results are found.

### Exercise 5: Update Movie Details
- Implement an action to update movie details (PUT request) using the `UpdateMovieDto`.
- Implement validation for the provided data, including checking for a valid movie, a non-empty title, a non-negative year, and a description not being empty.
- Update the movie if all validations pass and return a success response.

### Exercise 6: Delete Movie by ID
- Implement an action to delete a movie by its ID (DELETE request).
- Handle cases where the provided ID is negative, and where a movie with the given ID does not exist.
- Remove the movie if it exists and return an appropriate response.

### Exercise 7: Delete Movie by ID (Alternative Route)
- Implement an action to delete a movie by its ID using an alternative route (DELETE request) with a route parameter.
- Handle cases where the provided ID is negative, and where a movie with the given ID does not exist.
- Remove the movie if it exists and return an appropriate response.

### Exercise 8: Add a New Movie
- Create an action called AddMovie to create a new movie using (POST request, from Body) and using the `AddMovieDto` as a parameter.
- Implement validation for the provided data, including checking for a non-empty title, a description length not being empty, and a non-negative year.
- Create a new movie if all validations pass and return a success response.



