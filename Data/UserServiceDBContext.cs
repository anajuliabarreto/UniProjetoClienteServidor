using Microsoft.EntityFrameworkCore;
using ProjetoClienteServidor.Models.User;

namespace ProjetoClienteServidor.Data
{
    public class UserServiceDBContext : DbContext
    {
        public UserServiceDBContext(DbContextOptions<UserServiceDBContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}