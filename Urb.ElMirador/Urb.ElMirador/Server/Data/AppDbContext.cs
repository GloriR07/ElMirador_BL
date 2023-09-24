using Urb.ElMirador.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace Urb.ElMirador.Server.Data;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //Referenciamos los modelos que vaya a utilizar Entity Framework. 
        public virtual DbSet<Assembly> Assembly { get; set; }
    }