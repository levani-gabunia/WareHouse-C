using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class WriteOffTransactionRepositoryUnitTest : RepositoryTestBase<WriteOffTransactionRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID", 15),
					new SqlParameter("@Description", "madona"),
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