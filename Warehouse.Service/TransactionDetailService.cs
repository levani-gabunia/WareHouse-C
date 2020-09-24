using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class TransactionDetailService : ServiceBase<TransactionDetailRepository>
	{
		public void Insert(TransactionDetail transactionDetail)
		{
			_repository.Insert(transactionDetail);
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
