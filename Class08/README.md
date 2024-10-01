# Building a Note API 📒

# Part 1

## Pull the code from the GitHub and you will get the `NoteWebApi` project initialized inside of Class08, do all the exercies inside of it:

### Exercise 1:

## IN SQL Server create database called, NotesEightDB

 - Define a table Users with following columns
	- Id
	- FirstName
	- LastName
	- Address

### Exercise 2:
 - Define a table Notes with following columns
	- Id
	- Text
	- Priority
	- UserId

 
# Part 2

## In Visual Studio project, Scaffold the DB context and that should create the models and database context for this exercise.

# Part 3

## In the "Notes" Controller, Implement the Following Actions use `NoteDB` as a context (database) class:

<br>

### Tips:
### - Uncomment code in the DTOs folder when particular DTO is used
### - Make sure to use try-catch in the right way, make sure to cover catch path in the right way.
### - `IMPORTANT`: Test all the actions (end-points) using the `Postman` tool. Create new collection inside of it, and keep all the requests saved there. 
<br>

### Exercise 1: Retrieve All Notes
- Implement an action to retrieve all notes (GET request).
- Use the `NoteDto` model to represent each note.
- Handle potential errors and return appropriate responses.

### Exercise 2: Retrieve a Note by ID
- Implement an action that retrieves a note by its ID (GET request).
- Ensure that the action handles cases where the provided ID is negative, where a note with the given ID does not exist, and where a valid note is found.
- Return an appropriate response in each case.

### Exercise 3: Retrieve a Note by ID Using Query String
- Implement an action that retrieves a note by its ID using a query string parameter (GET request).
- Ensure that the action handles cases where the provided ID is negative, where a note with the given ID does not exist, and where a valid note is found.
- Return an appropriate response in each case.

### Exercise 4: Update a Note
- Implement an action that allows updating an existing note (PUT request) using the `UpdateNoteDto`.
- Implement validation for the provided data, including checking for the existence of the note, the text field being non-empty, and the existence of the associated user.
- Update the note if all validations pass and return a success response.

### Exercise 5: Delete a Note by ID
- Implement an action to delete a note by its ID (DELETE request).
- Ensure that the action handles cases where the provided ID is less than or equal to zero, and where a note with the given ID does not exist.
- Remove the note if it exists and return an appropriate response.

### Exercise 6: Retrieve Notes by User ID
- Implement an action to retrieve all notes associated with a specific user (GET request) using a route parameter.
- Handle cases where no notes are found for the given user ID and where notes are found.
- Return the list of user-specific notes.

### Exercise 7: Add a New Note
- Implement an action to create a new note (POST request) using the `AddNoteDto`.
- Implement validation for the provided data, including checking for the text field being non-empty, the existence of the associated user.
- Create a new note if all validations pass and return a success response.

### Exercise 8: Add Swagger to the Project
