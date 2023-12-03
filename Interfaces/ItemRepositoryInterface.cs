using InventoryBackend.Models;

namespace InventoryBackend.Interfaces
{
    public interface ItemRepositoryInterface
    {
        ICollection<Item> GetItems();
    }
}
