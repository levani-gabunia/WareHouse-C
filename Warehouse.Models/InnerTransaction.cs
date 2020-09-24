using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class InnerTransaction
    {
        public int ID { get; set; }
        public string WarehouseID { get; set; }
        public string UserID { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
