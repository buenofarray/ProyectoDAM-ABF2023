using Microsoft.EntityFrameworkCore;

namespace ProyectoDAM_ABF2023.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 

        }

        public DbSet<Book> Books => Set<Book>();
    }
}
