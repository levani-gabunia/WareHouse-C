using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class CategoryService : ServiceBase<CategoryRepository>
	{
		public void GetCategory(int id)
		{
			_repository.GetCategory(id);
		}

		public void Insert(Category category)
		{
			_repository.Insert(category);
		}

		public void Update(Category category)
		{
			_repository.Update(category);
		}

		public void Delete(Category category)
		{
			_repository.Delete(category);
		}
	}
}
