using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class OuterTransaction
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public TransactionType TransactionType { get; set; }
    }

    public enum TransactionType
    {
        purchase = 1,
        sell = 2,
    }
}
