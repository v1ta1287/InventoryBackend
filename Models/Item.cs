namespace InventoryBackend.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
        public DateTime DateAdded { get; set; }
        public string? WarehouseName { get; set; }
        public string? PhotoFileName { get; set; }



    }
}
