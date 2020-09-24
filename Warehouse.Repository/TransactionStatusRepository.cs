using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class TransactionStatusRepository : RepositoryBase
	{
		public void Insert(TransactionStatus transactionStatus)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", transactionStatus.StatusName),
			};
			Insert(param.ToArray());
		}

		internal override DataRow Get(int id)
		{
			string command = $"select * from {ObjectName} where @ID = ID";
			var result = _database.GetTable(command, CommandType.Text, new SqlParameter("@ID", id)).Rows[0];
			return result;
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionStatusRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionStatusRepository has not delete method!");
	}
}

