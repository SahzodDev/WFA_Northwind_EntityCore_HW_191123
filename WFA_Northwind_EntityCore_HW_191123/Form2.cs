using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Northwind_EntityCore_HW_191123.Contexts;
using WFA_Northwind_EntityCore_HW_191123.Models;

namespace WFA_Northwind_EntityCore_HW_191123
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            db = new NorthwindContext();

            List<Employee> employees = db.Employees.ToList();

            List<Shipper> shippers = db.Shippers.ToList();

            cbEmployees.DataSource = employees;
            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";

            cbShipper.DataSource = shippers;
            cbShipper.DisplayMember = "CompanyName";
            cbShipper.ValueMember = "ShipperId";
        }

        public Form2(int orderId)
        {
            InitializeComponent();

            btnAdd.Text = "Update";

            db = new NorthwindContext();
            this.orderId = orderId;
            List<Employee> employees = db.Employees.ToList();

            List<Shipper> shippers = db.Shippers.ToList();

            cbEmployees.DataSource = employees;
            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";

            cbShipper.DataSource = shippers;
            cbShipper.DisplayMember = "CompanyName";
            cbShipper.ValueMember = "ShipperId";

            Order order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);

            cbEmployees.SelectedValue = order.EmployeeId;
            cbShipper.SelectedValue = order.ShipVia;

            txtShipCity.Text = order.ShipCity;
            dtpOrderDate.Value = (DateTime)order.OrderDate;
            

        }

        NorthwindContext db;

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        public void FillTheBoxes()
        {

        }
        int orderId;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (orderId == 0) 
            {
                int employeeId = (int)cbEmployees.SelectedValue;
                int shipperId = (int)cbShipper.SelectedValue;

                Order order = new Order();
                order.EmployeeId = employeeId;
                order.OrderDate = dtpOrderDate.Value;
                order.ShipCity = txtShipCity.Text;
                order.ShipVia = shipperId;

                db.Orders.Add(order);
                db.SaveChanges();
            }
            else
            {
                Order order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);

                order.EmployeeId = (int)cbEmployees.SelectedValue;

                order.OrderDate = dtpOrderDate.Value;

                order.ShipCity = txtShipCity.Text;
                order.ShipVia = (int)cbShipper.SelectedValue;

                db.Orders.Update(order);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
