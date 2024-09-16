# Building a Note API 📒

# Part 1

## Pull the code from the GitHub and you will get the `SEDC.NotesAndTagsApp` project initialized inside of Class04, do all the exercies inside of it:


### Exercise 1:
 - Define a class named `BaseEntity` with a single property `Id` of type `int`. This class serves as a base class for other entities in your application.

### Exercise 2: 
- Define the Tag class that inherits from the BaseEntity class. 
   - The Tag class should have the following properties:
     - `Name`: A property of type string to store the name of the tag.
     - `Color`: A property of type string that can represent the color associated with the tag.

### Exercise 3: 
- Define enum called PriorityEnum with following values:
    - Low = 1,
    - Medium,
    - High

### Exercise 4: 
- Define Note Class with Properties:
   - Add the following properties to the `Note` class:
     - `Text`: A property of type `string` to store the content of the note.
     - `Priority`: A property of an enumeration type (you can define your own `PriorityEnum` or use existing enums).
     - `User`: A property representing the user associated with the note.
     - `UserId`: An `int` property to store the unique identifier of the user.
     - `Tags`: A property that is a list of `Tag` objects. You can declare it as `List<Tag>` and initialize it in the constructor.

### Exercise 5: 
- Define the `User` class that inherits from the `BaseEntity` class. The `User` class should have the following properties:
     - `FirstName`: A property of type `string` to store the user's first name.
     - `LastName`: A property of type `string` to store the user's last name.
     - `Username`: A property of type `string` to store the user's username.
     - `Password`: A property of type `string` to store the user's password.
     - `Notes`: A property that is a list of `Note` objects. You can declare it as `List<Note>` and initialize it in the constructor.

### Exercise 6: 
- Uncomment code in the `StaticDb` class which is provided for you in the Database folder

# Part 2

## In the "Notes" Controller, Implement the Following Actions use `StaticDB` as a context (database) class:

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
- Implement validation for the provided data, including checking for the existence of the note, the text field being non-empty, and the existence of the associated user and tags.
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
- Implement validation for the provided data, including checking for the text field being non-empty, the existence of the associated user, and the existence of tags.
- Create a new note if all validations pass and return a success response.

