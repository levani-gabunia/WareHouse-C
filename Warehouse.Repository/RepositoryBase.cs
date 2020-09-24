//#define USE_HARDCODED_CONNECTION
using DatabaseHelper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Warehouse.Repository
{
	public abstract class RepositoryBase
	{
		protected Database _database;

		protected virtual string ObjectName => this.GetType().Name.Replace("Repository", string.Empty);
		protected virtual string PluralObjectName => $"{ObjectName}s";

		public RepositoryBase()
		{
#if USE_HARDCODED_CONNECTION
			_database = new Database(@"server = LEVANI\SQLEXPRESS; database = Warehouse; integrated security = true");
#else
			_database = new Database(ConfigurationManager.ConnectionStrings["AppDB"].ConnectionString);
#endif
		}

		internal virtual void Insert(params SqlParameter[] parameters)
		{
			_database.ExecuteNonQuery($"Insert{ObjectName}_SP", CommandType.StoredProcedure, parameters);
		}

		internal virtual DataRow Get(int id)
		{
			string command = $"select * from {PluralObjectName} where @ID = ID";
			var result = _database.GetTable(command, CommandType.Text, new SqlParameter("@ID", id)).Rows[0];
			return result;
		}

		internal virtual void Update(params SqlParameter[] parameters)
		{
			_database.ExecuteNonQuery($"Update{ObjectName}_SP", CommandType.StoredProcedure, parameters);
		}

		internal virtual void Delete(params SqlParameter[] parameters)
		{
			_database.ExecuteNonQuery($"Delete{ObjectName}_SP", CommandType.StoredProcedure, parameters);
		}
	}
}
