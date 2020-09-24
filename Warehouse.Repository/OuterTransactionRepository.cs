using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class OuterTransactionRepository : RepositoryBase
	{
		public void Insert(OuterTransaction outerTransaction)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", outerTransaction.ID),
				new SqlParameter("@CompanyID", outerTransaction.CompanyID),
				new SqlParameter("@TransactionType", outerTransaction.TransactionType),
			};
			Insert(param.ToArray());
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("OuterTransactionRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("OuterTransactionRepository has not delete method!");
	}
}
