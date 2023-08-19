using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configura la documentación de Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Tienda Online de Ropa API",
        Description = "An ASP.NET Core Web API for managing a online shop's orders",
        Contact = new OpenApiContact
        {
            Name = "Contact the creator Daniela Barazarte",
            Url = new Uri("https://github.com/danielabarazarte/")
        },
        License = new OpenApiLicense
        {
            Name = "GitHub's repository link",
            Url = new Uri("https://github.com/danielabarazarte/DetectaLaLogica")
        }
    });
});

var app = builder.Build();

// Configura Swagger
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Tienda Online de Ropa API v1");
    options.RoutePrefix = "store";
});
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
