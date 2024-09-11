using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Inventories.Interfaces;
using BlazorIMS.UseCases.PluginInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorIMS.UseCases.Inventories
{
    public class ViewInventoriesUseCase:IViewInventoriesUseCase
    {
        private readonly IInventoryRepository _inventoryrepo;
        public ViewInventoriesUseCase(IInventoryRepository inventoryrepo)
        {
            _inventoryrepo = inventoryrepo;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        { 
            return await _inventoryrepo.GetInventoriesByName(name);
        }
    }
}
