using Dapper;
using Microsoft.Data.SqlClient;
using NoteApiMultipleDB.Abstraction;
using NoteApiMultipleDB.Models;

namespace NoteApiMultipleDB.Repositories
{
    public class NoteDapperRepository : INoteRepository
    {

        private readonly string _connectionString;

        public NoteDapperRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Note entity)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string insertQuery = "INSERT INTO Notes (Text, Priority, Tag, UserId)" +
                                     "VALUES (@text, @priority, @tag, @userId)";

                sqlConnection.Query(insertQuery, entity);
            }
        }

        public void Delete(Note entity)
        {
            // for homework
            throw new NotImplementedException();
        }

        public List<Note> GetAll()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                List<Note> allNotes = sqlConnection
                    .Query<Note>("SELECT * FROM Notes")
                    .ToList();

                return allNotes;
            }
        }

        public Note GetById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                Note noteDb = sqlConnection
                    .Query<Note>("SELECT * FROM Notes WHERE ID = @id", new { id = id})
                    .FirstOrDefault();

                return noteDb;
            }
        }

        public void Update(Note model)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                string updateQuery =
                    "UPDATE Notes " +
                    "SET Text = @Text, Tag = @Tag, Priority = @Priority, UserId = @UserId " +
                    "WHERE ID = @Id";

                sqlConnection.Query(updateQuery, model);
            }
        }
    }
}
