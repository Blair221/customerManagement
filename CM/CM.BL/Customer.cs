using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class Customer
    {
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        } 
    }
}
