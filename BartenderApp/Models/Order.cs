using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public string drinkName { get; set; }
        public string customerName { get; set; }
    }
}
