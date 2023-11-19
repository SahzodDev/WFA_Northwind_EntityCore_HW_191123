using System.Windows.Forms;
using WFA_Northwind_EntityCore_HW_191123.Contexts;
using WFA_Northwind_EntityCore_HW_191123.Models;

namespace WFA_Northwind_EntityCore_HW_191123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvOrders.AutoGenerateColumns = false;

            DataGridViewColumn column;


            column = new DataGridViewTextBoxColumn();
            column.Name = "OrderID";
            column.HeaderText = "Order ID";
            column.DataPropertyName = "OrderId";
            dgvOrders.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.Name = "OrderDate";
            column.HeaderText = "Order Date";
            column.DataPropertyName = "OrderDate";
            dgvOrders.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.Name = "ShipCity";
            column.HeaderText = "Ship City";
            column.DataPropertyName = "ShipCity";
            dgvOrders.Columns.Add(column);

            
        }
        NorthwindContext db;


        private void Form1_Load(object sender, EventArgs e)
        {




            //dgvOrders.ColumnHeadersVisible = true;
            //dgvOrders.RowHeadersVisible = true;

            //for (int i = 0; i < 20; i++)
            //{
            //    dgvOrders.Rows.Add();
            //}


            db = new NorthwindContext();

            List<Employee> employees = db.Employees.ToList();


            lstEmployees.DataSource = employees;
            lstEmployees.DisplayMember = "FirstName";
            lstEmployees.ValueMember = "EmployeeId";

            List<Shipper> shippers = db.Shippers.ToList();



            lstShippers.DataSource = shippers;
            lstShippers.DisplayMember = "CompanyName";
            lstShippers.ValueMember = "ShipperId";

            lstEmployees.SelectedIndex = -1;
            lstShippers.SelectedIndex = -1;

            
        }

        private void btnGetorderList_Click(object sender, EventArgs e)
        {
            db = new NorthwindContext();

            List<Order> orders = db.Orders.ToList();






            if (lstEmployees.SelectedItems.Count == 0 && lstShippers.SelectedItems.Count == 0)
            {

                dgvOrders.DataSource = orders;
            }
            else if (lstEmployees.SelectedItems.Count != 0 && lstShippers.SelectedItems.Count == 0)
            {
                int employeeId = (int)lstEmployees.SelectedValue;
                dgvOrders.DataSource = orders.Where(o => o.EmployeeId == employeeId).ToList();

                lstEmployees.SelectedIndex = -1;
            }
            else if (lstShippers.SelectedItems.Count != 0 && lstEmployees.SelectedItems.Count == 0)
            {
                int shipperId = (int)lstShippers.SelectedValue;

                dgvOrders.DataSource = orders.Where(o => o.ShipVia == shipperId).ToList();
                lstShippers.SelectedIndex = -1;
            }
            else if (lstEmployees.SelectedItems.Count != 0 && lstShippers.SelectedItems.Count != 0)
            {
                int employeeId = (int)lstEmployees.SelectedValue;
                int shipperId = (int)lstShippers.SelectedValue;

                dgvOrders.DataSource = orders.Where(o => o.EmployeeId == employeeId && o.ShipVia == shipperId).ToList();


                lstEmployees.SelectedIndex = -1;
                lstShippers.SelectedIndex = -1;


            }









        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Silme iþlemini onaylýyor musunuz?", "Onay Mesajý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK) 
                {
                    int orderId = (int)dgvOrders.SelectedRows[0].Cells["OrderID"].Value;

                    Order order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);

                    db.Orders.Remove(order);
                    db.SaveChanges();
                }

                else
                {

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0) 
            {
                int orderId = (int)dgvOrders.SelectedRows[0].Cells["OrderID"].Value;

                Form2 frm = new Form2(orderId);

                frm.ShowDialog();
            }
        }
    }
}