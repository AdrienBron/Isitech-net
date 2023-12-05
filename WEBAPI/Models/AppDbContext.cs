using Microsoft.EntityFrameworkCore;
namespace WEBAPI.Models;
public class AppDbContext : DbContext
{ 
    private const string ConnectionString ="Filename=C:/sqlite/BookDb.db"; //@"Server=localhost:5059;Database=BookDb;Trusted_Connection=True;"

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //var currentFolder = Directory.GetCurrentDirectory();
        optionsBuilder.UseSqlite(ConnectionString); //"Filename=C:/sqlite/BookDb.db"
        Console.WriteLine("ok");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder
    }

    public DbSet<Book> Books { get; set; }
    //public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}