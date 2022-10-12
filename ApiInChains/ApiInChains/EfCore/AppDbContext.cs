using ApiInChains.TestData;
using Microsoft.EntityFrameworkCore;

namespace ApiInChains.EfCore
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ApiInChainsDb; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(_user);
            modelBuilder.Entity<Pet>()
                .HasData(_pets);
        }

        private List<User> _user = new List<User>()
        {
            new User{Id = 1, FirstName = "Harry", LastName = "Doe" },
            new User{Id = 2, FirstName = "Garry", LastName = "Doe" },
            new User{Id = 3, FirstName = "Barry", LastName = "Doe" },
            new User{Id = 4, FirstName = "Larry", LastName = "Doe" },
            new User{Id = 5, FirstName = "Aarry", LastName = "Doe" },
        };

        private List<Pet> _pets = new List<Pet>()
        {
            new Pet{Id = 1, Name = "Kira", Species = "Chinchilla", UserId = 1 },
            new Pet{Id = 2, Name = "Freya", Species = "Chinchilla", UserId = 1 },
            new Pet{Id = 3, Name = "Lexa", Species = "Cat", UserId = 2 },
            new Pet{Id = 4, Name = "Czarek", Species = "Cat", UserId = 3 },
            new Pet{Id = 5, Name = "Tito", Species = "Dog", UserId = 5 },
            new Pet{Id = 6, Name = "Ira", Species = "Dog", UserId = 5 },
        };
    }
}