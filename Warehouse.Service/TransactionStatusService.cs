using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class TransactionStatusService : ServiceBase<TransactionStatusRepository>
	{
		public void Insert(TransactionStatus transactionStatus)
		{
			_repository.Insert(transactionStatus);
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
