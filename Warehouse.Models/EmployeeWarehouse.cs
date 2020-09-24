using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class EmployeeWarehouse
    {
        public int EmployeeID { get; set; }
        public string WarehouseID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
