
using Microsoft.Data.SqlClient;

namespace HomeLibraryTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var connection = new SqlConnection(
                       @"Server=localhost\EiriksSQL;
                        Database=HomeLibrary;
                        User ID = sa;
                        Password = 123;
                        TrustServerCertificate=True;"
                       ))
            {
                connection.Open();
                var cmd = new SqlCommand("INSERT INTO authors (id, author_name) VALUES (3, 'Eirik');",
                    connection);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows+" Rows affected");
                connection.Close();
            }

            Console.ReadLine();
            /*
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();

            app.Run();
            */
        }
    }
}
