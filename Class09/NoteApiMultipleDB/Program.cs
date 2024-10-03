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

            string noteTakingDBConnectionString = "YOUR CONNECTION STRING";

            // builder.Services.AddTransient<INoteRepository>(x => new NoteADORepository(noteTakingDBConnectionString));
            builder.Services.AddTransient<INoteRepository>(x => new NoteDapperRepository(noteTakingDBConnectionString));
            // regiseter user repostory here

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
