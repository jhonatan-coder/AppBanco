using AppBanco.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBanco.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios {get; set;}
    }
}