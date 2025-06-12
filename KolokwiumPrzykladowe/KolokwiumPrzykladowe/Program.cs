using KolokwiumPrzykladowe.Data;
using KolokwiumPrzykladowe.Services;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        
        string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddControllers();
        builder.Services.AddDbContext<DatabaseContext>(opt =>
        {
            opt.UseSqlServer(connectionString);
        });
        builder.Services.AddScoped<IDbService, DbService>();
        
        var app = builder.Build();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}

