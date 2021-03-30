using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class CustomerRepository
    {
       public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "monkeydluffy@strawhat.com";
                customer.FirstName = "Monkey D. ";
                customer.LastName = "Luffy";            
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            // code that saves the passed in customer

            return true;
        }
    }
}
