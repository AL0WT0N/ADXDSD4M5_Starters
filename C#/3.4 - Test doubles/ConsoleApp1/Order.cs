using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        public void processAllOrders()
        {
            List<Customer> customers = getCustomersFromDatabase();
            registerCustomers(customers);
            processOrdersUsingCustomersList(customers);
        }

        public void processOrdersUsingCustomersList(List<Customer> customers)
        {
            throw new NotImplementedException();
        }
    }
}
