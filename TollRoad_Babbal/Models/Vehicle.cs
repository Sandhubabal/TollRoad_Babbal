using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TollRoad_Babbal.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string VehicleType { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
