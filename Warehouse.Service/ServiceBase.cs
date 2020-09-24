using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public abstract class ServiceBase<TRepository>
	where TRepository : RepositoryBase, new()
	{
		protected TRepository _repository;

		public ServiceBase()
		{
			_repository = new TRepository();
		}
	}
}
