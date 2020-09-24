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
	public class EmployeeWarehouseRepository : RepositoryBase
	{
		public void Insert(EmployeeWarehouse employeeWarehouse)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("EmployeeID", employeeWarehouse.EmployeeID),
				new SqlParameter("@WarehouseID", employeeWarehouse.WarehouseID),
				new SqlParameter("@StartDate", employeeWarehouse.StartDate),
				new SqlParameter("@EndDate", employeeWarehouse.EndDate ),
			};
			Insert(param.ToArray());
		}

		internal override DataRow Get(int id)
		{
			string command = $"select * from {PluralObjectName} where @EmployeeID = EmployeeID";
			var result = _database.GetTable(command, CommandType.Text, new SqlParameter("@EmployeeID", id)).Rows[0];
			return result;
		}

		internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionStatusRepository has not update method!");

		internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("TransactionStatusRepository has not delete method!");
	}
}
