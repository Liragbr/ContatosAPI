using CrudAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Contatos> Contatos { get; set; }
    }
}
