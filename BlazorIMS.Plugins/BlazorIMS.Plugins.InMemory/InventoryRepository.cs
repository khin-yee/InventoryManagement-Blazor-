using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginInterfaces;

namespace BlazorIMS.Plugins.InMemory
{
    public class InventoryRepository:IInventoryRepository
    {
        private List<Inventory> _inventory;
        public InventoryRepository()
        {
            _inventory = new List<Inventory>()
            {
                new Inventory{InventoryId = 1,InventoryName = "Bike Seat", Quantity = 10, Price = 2},
                new Inventory{InventoryId = 1,InventoryName = "Bike Body", Quantity = 10, Price = 5},
                new Inventory{InventoryId = 1,InventoryName = "Bike Wheels", Quantity = 10, Price = 10},
                new Inventory{InventoryId = 1,InventoryName = "Bike Pedels", Quantity = 10, Price = 10},
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventory);
            return _inventory.Where(x => x.InventoryName.Contains(name,StringComparison.OrdinalIgnoreCase));
        }
    }
}
