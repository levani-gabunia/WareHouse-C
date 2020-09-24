using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class TransactionService : ServiceBase<TransactionRepository>
	{
		public void Insert(Transaction transaction)
		{
			_repository.Insert(transaction);
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
