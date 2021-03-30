using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
       public Customer Retrieve(int customerId)
        {
            //-- this instance of a customer is an example of a collaborative relationship
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "monkeydluffy@strawhat.com";
                customer.FirstName = "Monkey D. ";
                customer.LastName = "Luffy";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
