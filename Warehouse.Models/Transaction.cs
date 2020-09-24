using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class Transaction
    {
        public int WarehouseID { get; set; }
        public string UserID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionStatusID { get; set; }
    }
}
