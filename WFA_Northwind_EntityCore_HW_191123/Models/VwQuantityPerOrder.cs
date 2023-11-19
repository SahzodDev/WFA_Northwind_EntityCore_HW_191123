using System;
using System.Collections.Generic;

namespace WFA_Northwind_EntityCore_HW_191123.Models
{
    public partial class VwQuantityPerOrder
    {
        public int OrderId { get; set; }
        public int? TotalProductQuantity { get; set; }
    }
}
