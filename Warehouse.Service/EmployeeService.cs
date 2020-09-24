using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class EmployeeService : ServiceBase<EmployeeRepository>
	{
		public void Insert(Employee employee)
		{
			_repository.Insert(employee);
		}

		public void Update(Employee employee)
		{
			_repository.Update(employee);
		}

		public void Delete(Employee employee)
		{
			_repository.Delete(employee);
		}
	}
}
