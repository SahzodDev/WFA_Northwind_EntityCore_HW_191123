using System;
using System.Collections.Generic;

namespace WFA_Northwind_EntityCore_HW_191123.Models
{
    public partial class ViewEmployeeManager
    {
        public int ManagerId { get; set; }
        public string Manager { get; set; } = null!;
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; } = null!;
    }
}
