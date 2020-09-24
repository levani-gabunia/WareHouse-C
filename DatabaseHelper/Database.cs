using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseHelper
{
	public class Database
	{
		#region Private Members

		private string _connectionString;
		private static SqlConnection _connection;
		private static SqlTransaction _transaction;

		#endregion

		#region Constructor
		public Database(string connectionString)
		{
			_connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
		}

		#endregion

		#region Connection

		public string ConnectionString {
			get { return _connectionString; }
		}

		public SqlConnection GetConnection(string connectionString)
		{
			if (_connection == null)
			{
				_connection = new SqlConnection(connectionString);
			}
			return _connection;
		}

		public SqlConnection GetConnection()
		{
			return GetConnection(_connectionString);
		}

		#endregion

		#region Command

		public SqlCommand GetCommand(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			var command = new SqlCommand();
			command.Connection = GetConnection();
			command.CommandText = commandText;
			command.CommandType = commandType;
			command.Parameters.AddRange(parameters);

			return command;
		}

		public SqlCommand GetCommand(string commandText, params SqlParameter[] parameters)
		{
			return GetCommand(commandText, CommandType.Text, parameters);
		}

		#endregion

		#region ExecuteScalar

		public object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			var command = GetCommand(commandText, commandType, parameters);
			try
			{
				command.Connection.Open();
				return command.ExecuteScalar();
			}
			finally
			{
				command.Connection.Close();
			}
		}

		public object ExecuteScalar(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteScalar(commandText, CommandType.Text, parameters);
		}

		#endregion

		#region ExecuteNonQuery

		public object ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			var command = GetCommand(commandText, commandType, parameters);
			object result;
			try
			{
				command.Connection.Open();
				result = command.ExecuteNonQuery();
			}
			finally
			{
				command.Connection.Close();
			}
			return result;
		}

		public object ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteNonQuery(commandText, CommandType.Text, parameters);
		}

		#endregion

		#region ExecuteReader
		//close from out
		public object ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			var command = GetCommand(commandText, commandType, parameters);
			try
			{
				command.Connection.Open();
				return command.ExecuteReader(CommandBehavior.CloseConnection);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public object ExecuteReader(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteReader(commandText, CommandType.Text, parameters);
		}

		#endregion

		#region Transaction

		public object ExecuteNonQueryWithTransaction(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			var command = GetCommand(commandText, commandType, parameters);
			object result;
			try
			{
				command.Transaction = GetTransaction();
				result = command.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		public object ExecuteNonQueryWithTransaction(string commandText, params SqlParameter[] parameters)
		{
			return ExecuteNonQueryWithTransaction(commandText, CommandType.Text, parameters);
		}

		public SqlTransaction GetTransaction()
		{
			if (_transaction == null)
			{
				_transaction = GetConnection().BeginTransaction();
			}
			return _transaction;
		}

		#endregion

		#region DataTable
		public DataTable GetTable(string commandText, CommandType commandType, params SqlParameter[] parameters)
		{
			var result = new DataTable();
			var reader = ExecuteReader(commandText, commandType, parameters);
			result.Load((SqlDataReader)reader);
			return result;
		}

		public DataTable GetTable(string commandText, params SqlParameter[] parameters)
		{
			return GetTable(commandText, CommandType.Text, parameters);
		}
		#endregion
	}
}