using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class WarehouseRepositoryUnitTest : RepositoryTestBase<WarehouseRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("@Name", "WareHouse"),
					getInsertReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetUpdareParameters()
		{
			getUpdateReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID",getInsertReturnValue.Value),
					new SqlParameter("@Name", "WareHouse3"),
					new SqlParameter("@TaxCode", "6966969"),
					new SqlParameter("@Address", "tbilisi"),
					new SqlParameter("@ContactPhone", "69696969"),
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
