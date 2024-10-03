using Microsoft.Data.SqlClient;
using NoteApiMultipleDB.Abstraction;
using NoteApiMultipleDB.Models;

namespace NoteApiMultipleDB.Repositories
{
    public class NoteADORepository : INoteRepository
    {
        private readonly string _connectionString;

        public NoteADORepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Note entity)
        {
            // 1. Create new connection to the SQL DB
            SqlConnection sqlConnection = new SqlConnection(_connectionString);

            // 2. Open the connection
            sqlConnection.Open();

            // 3. Create SQL Command
            SqlCommand sqlCommand = new SqlCommand();

            // 4. Connect the command to the opened connection
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = "INSERT INTO Notes (Text, Priority, Tag, UserId)" + 
                                     "VALUES (@text, @priority, @tag, @userId)";

            // 5. Add parameters
            sqlCommand.Parameters.AddWithValue("@text", entity.Text);
            sqlCommand.Parameters.AddWithValue("@priority", entity.Priority);
            sqlCommand.Parameters.AddWithValue("@tag", entity.Tag);
            sqlCommand.Parameters.AddWithValue("@userId", entity.UserId);

            // 6. Execution
            sqlCommand.ExecuteNonQuery();

            // 7. Close connection
            sqlConnection.Close();
        }

        public List<Note> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = "SELECT * FROM Notes";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Note> notesList = new List<Note>();

            while(sqlDataReader.Read())
            {
                notesList.Add(new Note() 
                { 
                    Id = (int) sqlDataReader["Id"],
                    Text = (string)sqlDataReader["Text"],
                    Priority = (int)sqlDataReader["Priority"],
                    Tag = (int)sqlDataReader["Tag"],
                    UserId = (int)sqlDataReader["UserId"],
                });
            }

            sqlConnection.Close();

            return notesList;
        }

        public void Delete(Note entity)
        {
            //1. Create new connection to the SQL db
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            
            //2. Open the connection
            sqlConnection.Open();
            
            //3. Create sql command
            SqlCommand command = new SqlCommand();
            
            //4. connect the command 
            command.Connection = sqlConnection;

            command.CommandText = "DELETE FROM Notes WHERE Id = @id";
           
            command.Parameters.AddWithValue("@id", entity.Id);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public Note GetById(int id)
        {
            // for homework!
            throw new NotImplementedException();
        }

        public void Update(Note model)
        {
            // for homework!
            throw new NotImplementedException();
        }
    }
}
