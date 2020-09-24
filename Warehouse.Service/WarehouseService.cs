using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class WarehouseService : ServiceBase<WarehouseRepository>
	{
		public void Insert(WarehouseModels warehouse)
		{
			_repository.Insert(warehouse);
		}

		public void Update(WarehouseModels warehouse)
		{
			_repository.Update(warehouse);
		}

		public void Delete(WarehouseModels warehouse)
		{
			_repository.Delete(warehouse);
		}
	}
}
