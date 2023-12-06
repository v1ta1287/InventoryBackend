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

        public Item GetItem(int id)
        {
            return _context.Item.Where(i => i.ItemId == id).FirstOrDefault()!;
        }

        public Item GetItem(string name)
        {
            return _context.Item.Where(i => i.ItemName == name).FirstOrDefault()!;
        }

        public ICollection<Item> GetItems()
        {
            return _context.Item.ToList();
        }

        public bool ItemExists(int id)
        {
            return _context.Item.Any(i => i.ItemId == id);
        }
    }
}
