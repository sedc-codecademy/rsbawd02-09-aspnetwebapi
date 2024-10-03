using NoteApiMultipleDB.Abstraction;
using NoteApiMultipleDB.Repositories;

namespace NoteApiMultipleDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            string noteTakingDBConnectionString 
                = "---------------";

            builder.Services.AddTransient<INoteRepository>(x => new NoteADORepository(noteTakingDBConnectionString));

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
