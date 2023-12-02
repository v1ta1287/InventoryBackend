using InventoryBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryBackend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
