using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
	public class TransactionDetail : Transaction
	{
		public int TransactionID { get; set; }
		public string ProductID { get; set; }
		public double UnitPrice { get; set; }
		public decimal Quantity { get; set; }
	}
}
