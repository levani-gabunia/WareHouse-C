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
	public class CategoryRepository : RepositoryBase
	{
		protected override string PluralObjectName => "Categories";

		public void GetCategory(int id)
		{
			Get(id);
		}

		public void Insert(Category category)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("@CategoryName", category.CategoryName),
				new SqlParameter("@Description", category.Description),
				new SqlParameter("@ParentID", category.ParentID)
			};
			Insert(param.ToArray());
		}

		public void Update(Category category)
		{
			var param = new List<SqlParameter> {
				new SqlParameter("ID", category.ID),
				new SqlParameter("@ CategoryName", category.CategoryName),
				new SqlParameter("@Description", category.Description),
				new SqlParameter("@ ParentID", category.ParentID)
			};
			Update(param.ToArray());
		}

		public void Delete(Category category)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", category.ID)
			};
			Delete(param.ToArray());
		}
	}
}
