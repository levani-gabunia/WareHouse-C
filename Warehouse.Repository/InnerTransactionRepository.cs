using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class InnerTransactionRepository : RepositoryBase
	{
		public void Insert(InnerTransaction innertransaction)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", innertransaction.ID),
				new SqlParameter("@WarehouseID ", innertransaction.WarehouseID),
				new SqlParameter("@UserID", innertransaction.UserID),
				new SqlParameter("@DeliveryDate", innertransaction.@DeliveryDate),
			};
			Insert(param.ToArray());
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionRepository has not delete method!");
	}
}
