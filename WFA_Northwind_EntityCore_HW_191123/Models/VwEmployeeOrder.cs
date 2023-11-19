using System;
using System.Collections.Generic;

namespace WFA_Northwind_EntityCore_HW_191123.Models
{
    public partial class VwEmployeeOrder
    {
        public string ÇalışanAdSoyad { get; set; } = null!;
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
