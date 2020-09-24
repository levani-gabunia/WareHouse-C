using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class LostProduct
    {
        public int TransactionDetailID { get; set; }
        public decimal LostQuantity  { get; set; }
        public string Comment { get; set; }
    }
}
