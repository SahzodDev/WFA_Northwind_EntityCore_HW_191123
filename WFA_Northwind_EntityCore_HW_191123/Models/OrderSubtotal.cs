﻿using System;
using System.Collections.Generic;

namespace WFA_Northwind_EntityCore_HW_191123.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
