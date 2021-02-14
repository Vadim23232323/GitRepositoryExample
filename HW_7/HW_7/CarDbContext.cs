using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using HW_7.models;
using System.Configuration;

namespace HW_7
{
    public class CarAdvancedContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CarsConnectionString"));
            //optionsBuilder.UseSqlServer("Server = DESKTOP - PGISH7S; Database = Cars; Trusted_Connection = SSPI");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1, CarName = "Audi", ModelName = "80", Color = "green", Year = 35 },
                new Car() { Id = 2, CarName = "Opel", ModelName = "astra", Color = "blue", Year = 35 },
                new Car() { Id = 3, CarName = "Audi", ModelName = "80", Color = "green", Year = 35 });
        }
    }
}
