using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoDelivery.Models
{
    internal class Customer
    {

        static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        public int PackageCount { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Customer(int id, string fullName, int packageCount, string address, int phoneNumber)
        {

            Id = ++_id;
            FullName = fullName;
            PackageCount = packageCount;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
