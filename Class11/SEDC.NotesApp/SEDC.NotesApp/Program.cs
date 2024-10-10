using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SEDC.NotesApp.Helpers;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//read from appSettings.json, find the property AppSettings from the main object
var appSettings = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettings);

AppSettings appSettingsObject = appSettings.Get<AppSettings>();

//DEPENDENCY INJECTION
DependencyInjectionHelper.InjectDbContext(builder.Services, "CONNECTION_STRING___NotesAppAuthDb");
DependencyInjectionHelper.InjectRepositories(builder.Services);
//DependencyInjectionHelper.InjectAdoRepositories(builder.Services, "Server=.;Database=NotesAppDb;Trusted_Connection=True");
//DependencyInjectionHelper.InjectDapperRepositories(builder.Services, appSettingsObject.ConnectionString);
DependencyInjectionHelper.InjectServices(builder.Services);

//Configure JWT


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication(); // to be able to use JWT authentication
app.UseAuthorization();

app.MapControllers();

app.Run();
