using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class TransactionRepository : RepositoryBase
	{
		public void Insert(Transaction transaction)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("WarehouseID", transaction.WarehouseID),
				new SqlParameter("@UserID", transaction.UserID),
				new SqlParameter("@TransactionDate", transaction.TransactionDate),
				new SqlParameter("@TransactionStatusID", transaction.TransactionStatusID ),
			};
			Insert(param.ToArray());
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionRepository has not delete method!");
	}
}
