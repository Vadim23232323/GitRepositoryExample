using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using HW_8.models;
using System.Configuration;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HW_8
{
    public class CarAdvancedContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        //public CarAdvancedContext()
        //{
        //    Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CarsConnectionString"));
            // optionsBuilder.UseSqlServer("Server = DESKTOP - PGISH7S; Database = Cars; Trusted_Connection = SSPI");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1, CarName = "Audi", ModelName = "80", Color = "green", Year = 35 , AuthorID = 1,},
                new Car() { Id = 2, CarName = "Opel", ModelName = "astra", Color = "blue", Year = 35 , AuthorID = 2},
                new Car() { Id = 3, CarName = "Audi", ModelName = "80", Color = "green", Year = 35 ,AuthorID = 3});

            modelBuilder.Entity<Author>().HasData(
                new Author() {Id = 1, FirstName = "Vadim", LastName = "Dubovskiy", Description = "My car audi",},
                new Author() {Id = 2, FirstName = "Vadim", LastName = "Dubovskiy", Description = "My car audi",},
                new Author() {Id = 3, FirstName = "Vadim", LastName = "Dubovskiy", Description = "My car audi",});
        }
    }
}
