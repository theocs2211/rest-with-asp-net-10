using RestWithASPNET10.Configurations;
using RestWithASPNET10.Repositories;
using RestWithASPNET10.Repositories.Implementations;
using RestWithASPNET10.Services;
using RestWithASPNET10.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddSerilogLogging();

builder.Services.AddControllers()
    .AddContentNegotiation();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenAPIConfig();
builder.Services.AddSwaggerConfig();
builder.Services.AddRouteConfig();

builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddEvolveConfiguration(builder.Configuration, builder.Environment);

builder.Services.AddScoped<PersonServiceImplV2>();
builder.Services.AddScoped<IPersonService, PersonServiceImplV1>();
builder.Services.AddScoped<IBookService, BookServiceImpl>();

builder.Services.AddScoped(typeof(IRepository<>), typeof (GenericRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSwaggerSpecification();

app.Run();

//banco de dados
//Senha: SenhaForteDocker2026
//Porta: 1444
//Ip: 127.0.0.1
//usuario: sa