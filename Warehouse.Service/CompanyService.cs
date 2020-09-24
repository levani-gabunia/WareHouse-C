using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class CompanyService : ServiceBase<CompanyRepository>
	{
		public void Insert(Company company)
		{
			_repository.Insert(company);
		}

		public void Update(Company company)
		{
			_repository.Update(company);
		}

		public void Delete(Company company)
		{
			_repository.Delete(company);
		}
	}
}
