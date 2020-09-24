using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class ProductService : ServiceBase<ProductRepository>
	{
		public DataTable ProductList(int parentID)
		{
			return _repository.ProductList(parentID);
		}

		public void Insert(Product product)
		{
			_repository.Insert(product);
		}

		public void Update(Product product)
		{
			_repository.Update(product);
		}

		public void Delete(Product product)
		{
			_repository.Delete(product);
		}
	}
}
