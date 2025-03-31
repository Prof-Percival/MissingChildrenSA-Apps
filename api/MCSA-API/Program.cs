
using MCSA_API.Data;
using MCSA_API.Data.Repositories;
using MCSA_API.Domain.Azure;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Domain.Security;
using MCSA_API.Domain.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MCSA_API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<MCSAContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MCSA_DB")));

        // Bind the JwtSettings section in appsettings.json to the JwtSettings class
        builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

        // Add services for JWT authentication
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                // Get JwtSettings from configuration
                var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();

                //TODO: Disable?
                //options.RequireHttpsMetadata = false;
                options.SaveToken = true;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
                    ClockSkew = TimeSpan.Zero, // No clock skew for token expiration
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience
                };

                //Uncomment to debug JWT Validations
                /*options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        // Log authentication errors
                        Console.WriteLine($"Authentication failed: {context.Exception.Message}");
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        // Log token validated
                        Console.WriteLine($"Token validated for: {context.Principal.Identity.Name}");
                        return Task.CompletedTask;
                    }
                };*/
            });

        // Register IHttpContextAccessor for accessing the HTTP context
        builder.Services.AddHttpContextAccessor();

        //Register Domain Services
        builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

        builder.Services.AddSingleton<IDateProvider, DateProvider>();
        builder.Services.AddSingleton<IJwtHelper, JwtHelper>();
        builder.Services.AddSingleton<IBlobService, BlobService>();
        builder.Services.AddScoped<IUserService, UserService>();

        //Register Repositories
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IRepository<MissingPerson>, MissingPersonRepository>();
        builder.Services.AddScoped<IRepository<MissingPersonModerationQueue>, MissingPersonModerationQueueRepository>();

        builder.Services.AddControllers();

        //TODO: Enable api versioning
        //builder.Services.AddApiVersioning();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseSwagger();
        // Enabling Swagger UI in both Development and Production environments
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "MCSA API v1");
            //c.RoutePrefix = string.Empty; // Optional: If you want to access Swagger at root (/), not /swagger
        });

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}