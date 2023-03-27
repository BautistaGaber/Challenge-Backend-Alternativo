using ChallengeAlternativo.Core.Repository;
using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Core.Services;
using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.Core.Users.Repository;
using ChallengeAlternativo.Core.Users.Repository.Interfaces;
using ChallengeAlternativo.Core.Users.Services;
using ChallengeAlternativo.Core.Users.Services.Interfaces;
using ChallengeAlternativo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddDbContext<AplicationDbContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });
services.AddScoped<IUserServices, UserServices>();
services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<IContinentRepository, ContinentRepository>();
services.AddScoped<ICountryRepository, CountryRepository>();
services.AddScoped<IGeographicIconsRepository, GeographicIconRepository>();
services.AddScoped<IContinentServices, ContinentServices>();
services.AddScoped<ICountryServices, CountryServices>();
services.AddScoped<IGeographicIconsServices, GeographicIconsServices>();

services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Alternativa", Version = "v1" });

    c.AddSecurityDefinition("Bearer",
    new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference {Type = ReferenceType.SecurityScheme, Id = "Bearer"},
                Scheme = "Bearer",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });

    // Set the comments path for the Swagger JSON and UI.
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
