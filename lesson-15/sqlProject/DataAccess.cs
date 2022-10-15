using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlProject
{
    public  class DataAccess
    {
        private NorthWindTableAdapters.CustomersTableAdapter customers = new NorthWindTableAdapters.CustomersTableAdapter();
        private NorthWindTableAdapters.OrdersTableAdapter orderes = new();

        public NorthWind.OrdersDataTable GetOrdersByCustomerId(string id)
        {
            return orderes.GetDataById(id);
        }

        public NorthWind.CustomersDataTable GetAllCustomers()
        {
            return customers.GetData();
        }
    }
}
