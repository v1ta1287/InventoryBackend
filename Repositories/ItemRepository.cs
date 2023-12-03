using InventoryBackend.Data;
using InventoryBackend.Interfaces;
using InventoryBackend.Models;

namespace InventoryBackend.Repositories
{
    public class ItemRepository : ItemRepositoryInterface
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Item> GetItems()
        {
            return _context.Item.ToList();
        }
    }
}
