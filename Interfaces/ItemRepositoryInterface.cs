using InventoryBackend.Models;

namespace InventoryBackend.Interfaces
{
    public interface ItemRepositoryInterface
    {
        ICollection<Item> GetItems();
        Item GetItem(int id);
        Item GetItem(string name);
        bool ItemExists(int id);
    }
}
