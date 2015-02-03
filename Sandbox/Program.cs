using ConnectedBus.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Paul",
                LastName = "Krause"
            };

            var dataAccess = new DataStore();
            dataAccess.Write(customer);

            customer.FirstName = "David";
            dataAccess.Write(customer);
        }
    }
}
