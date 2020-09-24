using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Repository;
using Warehouse.UnitTest;

namespace Warehouse.UnitTest
{
	[TestClass]
	public class UserRepositoryUnitTest : RepositoryTestBase<UserRepository>
	{
		protected override ICollection<SqlParameter> GetInsertParameters()
		{
			getInsertReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID", 69),
					new SqlParameter("@Username", "levan"),
					new SqlParameter("@Password", "levani1"),
					new SqlParameter("@UserGroup", "group1"),
					getInsertReturnValue
			};
		}

		protected override ICollection<SqlParameter> GetUpdareParameters()
		{
			getUpdateReturnValue = new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue };
			return new List<SqlParameter>
			{
					new SqlParameter("ID",getInsertReturnValue.Value),
					new SqlParameter("@Username", "Levani1"),
					new SqlParameter("@Password", "Levani22"),
					new SqlParameter("@UserGroup", "group2"),
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
