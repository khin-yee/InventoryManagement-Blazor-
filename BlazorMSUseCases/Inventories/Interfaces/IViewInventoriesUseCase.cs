using BlazorIMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorIMS.UseCases.Inventories.Interfaces
{
    public  interface IViewInventoriesUseCase
    {
      Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}
