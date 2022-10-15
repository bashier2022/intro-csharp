using System.Data;

namespace sqlProject
{
    public partial class Form1 : Form
    {
        private DataAccess data = new DataAccess();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCustomersId_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCustomers.DataSource = data.GetAllCustomers();
            lstCustomers.DisplayMember = "ContactName";
           
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item  = lstCustomers.SelectedItem as DataRowView;
            if(item == null)
            {
                return;
            }
            var customer = item.Row as NorthWind.CustomersRow;
            if(customer == null)
            {
                return;
            }
            var id = customer.CustomerID;
            //lstOrders.DataSource =  data.GetOrdersByCustomerId(id);
            //lstOrders.DisplayMember = "ShipCity";

            lstOrders.Items.Clear();
            foreach (var order in data.GetOrdersByCustomerId(id))
            {

                lstOrders.Items.Add($"[{order.OrderID}] {order.ShipCountry} {order.ShipCity}    {order.Freight}");
            }

            //dataGridView1.DataSource = northWindBindingSource;
            //northWindBindingSource.DataSource = data.GetOrdersByCustomerId(id);

            dataGridView1.DataSource = data.GetOrdersByCustomerId(id);
            

        }
    }
}