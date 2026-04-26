using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoDelivery.Models
{
    internal class Courier
    {
        static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int DeliveredCount { get; private set; }
    }
}
