# Workshop for Class 06 - Books Library CRUD Web API  
<br>  
<br>  

## **Part 1**: Working with classes  

### Exercise 1: Create a Book Class  
- **Task**: Create a `Book` class with specific properties.  
- **Instructions**:  
  - Create a class named `Book`.  
  - Add the following properties to the `Book` class:  
    - `Id`: An integer property to store the book's unique identifier.  
    - `Title`: A string property to store the book's title.  
    - `Author`: A string property to store the author's name.  
    - `YearPublished`: An integer property to store the year the book was published.  
    - `Genre`: A property of the `GenreEnum` enumeration to represent the book's genre.

### Exercise 2: Define GenreEnum  
- **Task**: Define an enumeration for book genres.  
- **Instructions**:  
  - Create an enumeration named `GenreEnum`.  
  - Define three genre values:  
    - `Fiction` with a value of 1.  
    - `NonFiction` with a value of 2.  
    - `Fantasy` with a value of 3.

<br>  
<br>  

## **Part 2**: Implement existing DTOs in this project  

### Implement an AddBookDto Class  
- **Task**: Implement an `AddBookDto` class with specific properties for adding a new book.  
- **Instructions**:  
  - Add the following properties to the `AddBookDto` class:  
    - `Title`: A string property to store the book's title.  
    - `Author`: A string property to store the author's name.  
    - `YearPublished`: An integer property to store the year the book was published.  
    - `Genre`: A property of the `GenreEnum` enumeration to represent the book's genre.

### Implement a BookDto Class  
- **Task**: Implement a `BookDto` class with specific properties for displaying book information.  
- **Instructions**:  
  - Add the following properties to the `BookDto` class:  
    - `Title`: A string property to store the book's title.  
    - `Author`: A string property to store the author's name.  
    - `YearPublished`: An integer property to store the year the book was published.  
    - `Genre`: A property of the `GenreEnum` enumeration to represent the book's genre.

### Implement an UpdateBookDto Class  
- **Task**: Implement an `UpdateBookDto` class with specific properties for updating existing book details.  
- **Instructions**:  
  - Add the following properties to the `UpdateBookDto` class:  
    - `Id`: An integer property to uniquely identify the book to be updated.  
    - `Title`: A string property to store the book's updated title.  
    - `Author`: A string property to store the updated author's name.  
    - `YearPublished`: An integer property to store the book's updated publication year.  
    - `Genre`: A property of the `GenreEnum` enumeration to represent the book's updated genre.

<br>  
<br>  

## **Part 3**: Implement actions in Controller  

### Exercise 1: Retrieve All Books  
- Implement an action to retrieve all books (GET request).  
- Use the `BookDto` model to represent each book.

### Exercise 2: Retrieve a Book by ID  
- Implement an action that retrieves a book by its ID (GET request).  
- Ensure that the action handles cases where the provided ID is negative, where a book with the given ID does not exist, and where a valid book is found.  
- Return an appropriate response in each case.

### Exercise 3: Filter Books by Genre and Year  
- Implement an action that allows filtering books by genre and/or year (GET request) using query string parameters.  
- Validate the filter parameters and return a list of filtered books.  
- Handle cases where no filter parameters are provided and where filter results are found.

### Exercise 4: Update Book Details  
- Implement an action to update book details (PUT request) using the `UpdateBookDto`.  
- Implement validation for the provided data, including checking for a valid book, a non-empty title, a valid author name, a non-negative year, and a genre not being empty.  
- Update the book if all validations pass and return a success response.

### Exercise 5: Delete Book by ID  
- Implement an action to delete a book by its ID (DELETE request).  
- Handle cases where the provided ID is negative, and where a book with the given ID does not exist.  
- Remove the book if it exists and return an appropriate response.

### Exercise 6: Add a New Book  
- Create an action called AddBook to create a new book (POST request, from Body) using the `AddBookDto` as a parameter.  
- Implement validation for the provided data, including checking for a non-empty title, a valid author name, and a non-negative year.  
- Create a new book if all validations pass and return a success response.

### Exercise 7: Add Swagger support for the project  
