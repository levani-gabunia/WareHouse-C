using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class ProductRepository : RepositoryBase
	{
		public DataTable ProductList(int parentID)
		{
			var parameters = new SqlParameter("@parentID", parentID);

			var dataTable = _database.GetTable($"ProductList_SP", CommandType.StoredProcedure, parameters);
			return dataTable;
		}

		public void Insert(Product product)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("@ProductName ", product.ProductName ),
				new SqlParameter("@@Description", product.@Description),
				new SqlParameter("@CategoryID", product.CategoryID ),
				new SqlParameter("@IsTerm", product.IsTerm),
			};
			Insert(param.ToArray());
		}

		public void Update(Product product)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", product.ID),
				new SqlParameter("@ProductName ", product.ProductName ),
				new SqlParameter("@@Description", product.@Description),
				new SqlParameter("@CategoryID", product.CategoryID ),
				new SqlParameter("@IsTerm", product.IsTerm ),
			};
			Update(param.ToArray());
		}

		public void Delete(Product product)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", product.ID)
			};
			Delete(param.ToArray());
		}
	}
}
