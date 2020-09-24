using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class TransactionDetailRepository : RepositoryBase
	{
		public void Insert(TransactionDetail trsnsactionDetail)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("TransactionID", trsnsactionDetail.TransactionID),
				new SqlParameter("@ProductID", trsnsactionDetail.ProductID),
				new SqlParameter("@UnitPrice", trsnsactionDetail.UnitPrice),
				new SqlParameter("@Quantity", trsnsactionDetail.@Quantity ),
			};
			Insert(param.ToArray());
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionDetailRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionDetailRepository has not delete method!");
	}
}
