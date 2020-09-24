using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class EmployeeRepositoryUnitTest : RepositoryTestBase<EmployeeRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("@FirstName", "ლევან"),
					new SqlParameter("@LastName", "გაბუნ"),
					new SqlParameter("@PersonalID", "2221222"),
					getInsertReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetUpdareParameters()
		{
			getUpdateReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID",getInsertReturnValue.Value),
					new SqlParameter("@FirstName", "ლევანი"),
					new SqlParameter("@LastName", "გაბუნია"),
					new SqlParameter("@PersonalID", "00611310"),
					new SqlParameter("@Address", "რუსთავი"),
					new SqlParameter("@ContactPhone", "01013339"),
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
