# Exercise 1: Implementing CRUD Operations in the `NoteRepository`

In this exercise, you will work with the `NoteRepository` class, which is responsible for performing CRUD (Create, Read, Update, Delete) operations on notes in the NotesApp database. Your task is to implement the existing methods to make the repository fully functional.

## First steps:

1. **Database Configuration:**

   Adjust the connection string in the Program.cs file to match your database setup.

2. **Add a Migration:**

   Using Entity Framework, create a migration to represent changes in your data model. Use the following command: **add-migration YourMigrationName**

3. **Update the Database:**

Apply the migration to update the database schema with the following command: **update-database**


## Instructions:

1. **Implement the `Add` method:**

   The `Add` method is used to add a new note to the database. Implement this method by adding the provided note entity to the `_notesAppDbContext` and saving the changes to the database using the `SaveChanges` method.

2. **Implement the `Delete` method:**

   The `Delete` method should delete the given note entity from the database. You need to remove the entity from the `_notesAppDbContext` and then call `SaveChanges` to persist the changes.

3. **Implement the `GetAll` method:**

   The `GetAll` method should return a list of all notes in the database. Ensure that you join the `Notes` table with the `Users` table using the `Include` method. Return the list of notes.

4. **Implement the `GetById` method:**

   The `GetById` method should retrieve a note by its unique identifier (id). Join the `Notes` table with the `Users` table using `Include` and return the first note where the id matches the provided parameter.

5. **Implement the `Update` method:**

   The `Update` method is used to update an existing note in the database. Implement this method by updating the provided note entity within the `_notesAppDbContext` and then call `SaveChanges` to persist the changes.

# Exercise 2: Implementing Note Service Methods

In this exercise, you will implement the `AddNote`, `GetAllNotes`, and `GetById` methods in the `NoteService` class. The `NoteService` is responsible for managing notes in the NotesApp application.

## Instructions:

1. **Implement the `AddNote` Method:**

   - Open the `NoteService` class.
   - Locate the `AddNote` method. This method is responsible for adding a new note to the database.
   - Implement the method to perform the following tasks:
     - Validate the `addNoteDto` input.
     - Check if the user with the specified `UserId` exists.
     - Ensure that the `Text` field is not empty and does not exceed 100 characters.
     - Map the `addNoteDto` to a `Note` domain model.
     - Add the new note to the database using the `_noteRepository`.

2. **Implement the `GetAllNotes` Method:**

   - Locate the `GetAllNotes` method in the `NoteService` class. This method retrieves a list of all notes from the database.
   - Implement the method to perform the following tasks:
     - Retrieve all notes from the database using the `_noteRepository`.
     - Map the retrieved `Note` objects to `NoteDto` objects.
     - Return a list of `NoteDto` objects.

3. **Implement the `GetById` Method:**

   - Find the `GetById` method in the `NoteService` class. This method retrieves a note by its unique identifier (id).
   - Implement the method to perform the following tasks:
     - Retrieve the note with the specified `id` from the database using the `_noteRepository`.
     - Check if the note exists, and if not, throw a `NoteNotFoundException`.
     - Map the retrieved `Note` object to a `NoteDto` object.
     - Return the `NoteDto`.

## Note:

- Pay attention to input validation and error handling to ensure the methods handle various scenarios correctly.

By completing this exercise, you will have implemented essential functionality in the `NoteService` for adding, retrieving all notes, and retrieving notes by their unique identifiers.

# Exercise 3: Implementing Controller Actions in ASP.NET Core

In this exercise, you will implement controller actions in an ASP.NET Core application by calling methods from the service layer. The controller is responsible for handling HTTP requests and returning appropriate responses.

## Scenario:

You are working on a NotesApp project, and you need to implement controller actions for managing notes. The `NotesController` interacts with the `INoteService` to perform CRUD operations on notes.

## Instructions:

1. **Implement the `Get` Action:**

   - Open the `NotesController` class.
   - Locate the `Get` action, which handles HTTP GET requests to retrieve all notes.
   - Implement the action by calling the `GetAllNotes` method from the `_noteService`.
   - Return an HTTP 200 status code with the list of `NoteDto` objects as the response.

2. **Implement the `GetById` Action:**

   - Find the `GetById` action in the `NotesController`. This action handles HTTP GET requests to retrieve a single note by its `id`.
   - Implement the action by calling the `GetById` method from the `_noteService`.
   - Handle potential exceptions, such as `NoteNotFoundException`, and return the appropriate status codes with error messages.

3. **Implement the `AddNote` Action:**

   - Locate the `AddNote` action, which handles HTTP POST requests to add a new note.
   - Implement the action by calling the `AddNote` method from the `_noteService` with the provided data from the request body.
   - Handle potential exceptions, such as `NoteDataException`, and return the appropriate status codes with error messages.

4. Test each of the implemented actions to ensure they work as expected by using tools like Postman or Swagger.

## Note:

- Pay attention to error handling and return the correct status codes and messages based on the outcomes of the service layer methods.

By completing this exercise, you will have implemented controller actions for managing notes in the NotesApp application by calling methods from the service layer.

# Exercise 4: Writing Unit Tests

In this exercise, you will write the unit tests for `NoteService` using `MockNoteRepository` and `MockUserRepository`.

## Scenario:

Inside `SEDC.NotesApp.Test` project add test class and test methods. 

## Instructions:

1. **Implement the `AddNote_InvalidUserId_Exception` Test Method:**
2. **Implement the `AddNote_EmptyText_Exception` Test Method:**
3. **Implement the `AddNote_LargerText_Exception` Test Method:**
4. **Implement the `GetAllNotes_Count` Test Method:**
5. **Implement the `GetNoteById_InvalidId_Exception` Test Method:**
6. **Implement the `GetNoteById_ValidUser_NoteDto` Test Method:**

## Note:

- Run the test using Visual Studio, all test should have gree icon, in another words all test should pass.

