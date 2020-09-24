using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class EmployeeWarehouseService : ServiceBase<EmployeeWarehouseRepository>
	{
		public void Insert(EmployeeWarehouse employeeWarehouse)
		{
			_repository.Insert(employeeWarehouse);
		}

		public void Update()
		{
			throw new NotSupportedException("TransactionStatusRepository has not update method!");
		}

		public void Delete()
		{
			throw new NotSupportedException("TransactionStatusRepository has not delete method!");
		}
	}
}
