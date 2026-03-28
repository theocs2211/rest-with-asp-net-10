using RestWithASPNET10.Configurations;
using RestWithASPNET10.Services;
using RestWithASPNET10.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IPersonService, PersonServiceImpl>();
builder.Services.AddDatabaseConfiguration(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//banco de dados
//Senha: SenhaForteDocker2026
//Porta: 1444
//Ip: 127.0.0.1
//usuario: sa