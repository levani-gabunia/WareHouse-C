using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class ProductRepositoryUnitTest : RepositoryTestBase<ProductRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("@ProductName", "სიგარეტ"),
					new SqlParameter("@CategoryID", 6),
					new SqlParameter("@IsTerm", true),
					getInsertReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetUpdareParameters()
		{
			getUpdateReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID",getInsertReturnValue.Value),
					new SqlParameter("@ProductName", "სიგარეტი"),
					new SqlParameter("@Description", "წინსტონი"),
					new SqlParameter("@categoryID", 8),
					new SqlParameter("@IsTerm", false),
					getUpdateReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetDeleteParameters()
		{
			getDeleteReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID",getInsertReturnValue.Value),
					getDeleteReturnValue
			};
		}
	}
}

