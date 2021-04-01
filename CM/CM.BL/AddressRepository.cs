using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Dadan's House";
                address.StreetLine2 = "Mountains";
                address.City = "Foosha Village";
                address.State = "Goa Kingdom";
                address.Country = "East Blue";
                address.PostalCode = "2121";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Dadan's House",
                StreetLine2 = "Mountains",
                City = "Foosha Village",
                State = "Goa Kingdom",
                Country = "East Blue",
                PostalCode = "2121"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Thousand Sunny",
                StreetLine2 = "Ship on the ocean",
                City = "Water 7",
                State = "Franky Family",
                Country = "Grand Line",
                PostalCode = "1212"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
