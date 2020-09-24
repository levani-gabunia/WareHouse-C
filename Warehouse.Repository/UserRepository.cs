using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class UserRepository : RepositoryBase
	{
        public void Insert(User user)
		{
            var param = new List<SqlParameter>
			{
				new SqlParameter("ID", user.ID),
				new SqlParameter("@Username", user.Username),
				new SqlParameter("@Password", user.Password),
				new SqlParameter("@UserGroup", user.UserGroup)
			};
			Insert(param.ToArray());
		}

		public void Update(User user)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", user.ID),
				new SqlParameter("@Username", user.Username),
				new SqlParameter("@Password", user.Password),
				new SqlParameter("@UserGroup", user.UserGroup)
			};
			Update(param.ToArray());
		}

		public void Delete(User user)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", user.ID)
			};
			Delete(param.ToArray());
		}

		public int UserLogin(string username, string password)
		{
			var userIDOutput = new SqlParameter("@UserID", SqlDbType.Int) { Direction = ParameterDirection.Output };

			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@Username", username),
				new SqlParameter("@Password", password),
				userIDOutput
			};
			_database.ExecuteNonQuery($"LoginUser_SP", CommandType.StoredProcedure, parameters.ToArray());
			return (int)userIDOutput.Value;
		}
	}
}
