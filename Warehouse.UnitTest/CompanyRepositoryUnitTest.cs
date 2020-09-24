using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class CompanyRepositoryUnitTest : RepositoryTestBase<CompanyRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("@CompanyName", "Company"),
					new SqlParameter("@TaxCode", "966996699"),
					getInsertReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetUpdareParameters()
		{
			getUpdateReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("@ID", getInsertReturnValue.Value),
					new SqlParameter("@CompanyName", "Company7"),
					new SqlParameter("@TaxCode", "22222222222"),
					new SqlParameter("@Address", null),
					new SqlParameter("@ContactPerson", "N/A"),
					new SqlParameter("@ContactTitle", "N/A"),
					new SqlParameter("@ContactPhone", "N/A"),
					new SqlParameter("@Email", "997"),
					new SqlParameter("@Head", "N/A"),
					new SqlParameter("@Description", "N/A"),
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
