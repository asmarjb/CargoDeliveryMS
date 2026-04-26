using CargoDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoDelivery.Helpers
{
    internal static class Helper
    {
        public static void CheckFullName(string name) 
        { 
            if (string.IsNullOrEmpty(name)) 
            { 
                throw new ArgumentNullException("name"); 
            }
            
        }
        public static void CheckPhone(string phone) 
        {
            if (string.IsNullOrEmpty(phone)) 
            { 
                throw new ArgumentNullException("xeta"); 
            }
            if (phone.Length < 10 && phone.Length > 15) 
            {
                throw new ArgumentException("uzunluq 10dan boyuk 15den kicik olmalidr");
            }

        }
        public static void CheckAddress (string address) 
        { 
            if (string.IsNullOrEmpty(address)) 
            { 
                throw new ArgumentNullException("XETA"); 
            }
            
        }
        public static void CheckWeight(double weight)
        {
            if (double.IsNaN(weight))
            {
                throw new ArgumentException("XETA");
            }
            if (weight>100) 
            {
                throw new ArgumentException("100 kilodan artiq olmamalidir");
            }
        }
    }
}
