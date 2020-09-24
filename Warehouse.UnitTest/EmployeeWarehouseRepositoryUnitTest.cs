using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class EmployeeWarehouseRepositoryUnitTest : RepositoryTestBase<EmployeeWarehouseRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("@EmployeeID", 69),
					new SqlParameter("@WarehouseID", 1),
					new SqlParameter("@StartDate", DateTime.Now),
					new SqlParameter("@EndDate", DateTime.Now),
					getInsertReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetUpdareParameters() => throw new NotSupportedException("TransactionRepository has not update method!");

		protected override ICollection<SqlParameter> GetDeleteParameters() => throw new NotSupportedException("TransactionRepository has not delete method!");


		[TestMethod, Ignore, Category("Has not Method")]
		public override void Test2_Update() => throw new NotSupportedException("TransactionRepository has not update method!");

		[TestMethod, Ignore, Category("Has not Method")]
		public override void Test3_Delete() => throw new NotSupportedException("TransactionRepository has not delete method!");
	}
}
