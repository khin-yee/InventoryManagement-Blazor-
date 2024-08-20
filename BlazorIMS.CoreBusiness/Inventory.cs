﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorIMS.CoreBusiness
{
    public  class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
