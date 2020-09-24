using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Product 
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string CategoryID { get; set; }
        public bool IsTerm { get; set; }
    }
}
