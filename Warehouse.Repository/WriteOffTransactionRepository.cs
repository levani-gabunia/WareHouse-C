using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class WriteOffTransactionRepository : RepositoryBase
	{
		public void Insert(WriteOffTransaction WriteOffTransaction)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID",  WriteOffTransaction.ID),
				new SqlParameter("@Description", WriteOffTransaction.@Description),
			};
			Insert(param.ToArray());
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionRepository has not delete method!");
	}
}
