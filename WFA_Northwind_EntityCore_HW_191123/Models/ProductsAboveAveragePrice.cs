using System;
using System.Collections.Generic;

namespace WFA_Northwind_EntityCore_HW_191123.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
