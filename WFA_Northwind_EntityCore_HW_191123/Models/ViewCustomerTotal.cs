using System;
using System.Collections.Generic;

namespace WFA_Northwind_EntityCore_HW_191123.Models
{
    public partial class ViewCustomerTotal
    {
        public string CompanyName { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public double? CustomerTotal { get; set; }
    }
}
