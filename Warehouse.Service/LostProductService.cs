using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class LostProductService : ServiceBase<LostProductRepository>
	{
		public void Insert(LostProduct lostProduct)
		{
			_repository.Insert(lostProduct);
		}

		public void Update()
		{
			//_repository.Update();
		}

		public void Delete()
		{
			//_repository.Delete();
		}
	}
}
