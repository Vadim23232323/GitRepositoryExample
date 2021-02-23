using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using HW_9.models;
using System.Configuration;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HW_9
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
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Car>().Property(p => p.CarName).HasMaxLength(50);

            modelBuilder.Entity<Car>().Property(p => p.ModelName).HasMaxLength(50);


            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1, CarName = "Audi", ModelName = "80", Color = "green", Year = 35 , AuthorID = 1,},
                new Car() { Id = 2, CarName = "Opel", ModelName = "astra", Color = "blue", Year = 35 , AuthorID = 2},
                new Car() { Id = 3, CarName = "Audi", ModelName = "80", Color = "green", Year = 35 ,AuthorID = 3});

            modelBuilder.Entity<Author>().HasData(
                new Author() { AuthorIdentifier = 1, FirstName = "Vadim", LastName = "Dubovskiy", Description = "My car audi",},
                new Author() { AuthorIdentifier = 2, FirstName = "Vadim", LastName = "Dubovskiy", Description = "My car audi",},
                new Author() { AuthorIdentifier = 3, FirstName = "Vadim", LastName = "Dubovskiy", Description = "My car audi",});
        }
    }
}
