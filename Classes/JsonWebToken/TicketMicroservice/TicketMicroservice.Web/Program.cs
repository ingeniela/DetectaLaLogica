using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Net;
using System.Text;
using TicketMicroservice.EntityFramework;
using TicketMicroservice.Shared.Config;
using TicketMicroservice.Web;
using TicketMicroservice.Web.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add swagger documentation
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Ticket Microservice API (JsonWebToken Tutorial)",
        Description = "An ASP.NET Core Web API for managing a ticket database",
        Contact = new OpenApiContact
        {
            Name = "Contact the creator Daniela Barazarte",
            Url = new Uri("https://github.com/danielabarazarte/")
        }
    });
});

// Add Jwt Token Validation
builder.Services.Configure<JwtTokenValidationSettings>(builder.Configuration.GetSection("JwtTokenValidationSettings"));

var tokenValidationSettings = builder.Configuration.GetSection("JwtTokenValidationSettings").Get<JwtTokenValidationSettings>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = tokenValidationSettings.ValidIssuer,
            ValidateAudience = true,
            ValidAudience = tokenValidationSettings.ValidAudience,
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(tokenValidationSettings.SecretKey)),
            ValidateIssuerSigningKey = true,
        };
    });

// Connection with MySQL
var connectionString = builder.Configuration.GetConnectionString("TicketDatabase");

// Configure context of database
builder.Services.AddDbContext<TicketMicroserviceContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Add Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 7;
    options.Password.RequiredUniqueChars = 4;
})
.AddEntityFrameworkStores<TicketMicroserviceContext>()
.AddDefaultTokenProviders();

// Add transient
builder.Services.AddTransient<IJwtIssuerOptions, JwtIssuerFactory>();

var app = builder.Build();

// Add Error handlers
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error-development");
    app.UseHsts();
}
else
{
    app.UseExceptionHandler("/error");
}

// Enable middleware to serve generated Swagger as a JSON endpoint
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
// specifying the Swagger JSON endpoint.
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "tickets";

    // Add the authorization token input box to Swagger UI
    options.OAuthClientId("swagger");
    options.OAuthClientSecret("secret");
    options.OAuthAppName("Ticket Microservice API");
    options.OAuthUsePkce();
});


// Init Database
app.InitDb();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();