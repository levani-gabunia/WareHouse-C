using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class WriteOffTransactionService : ServiceBase<WriteOffTransactionRepository>
	{
		public void Insert(WriteOffTransaction writeOffTransaction)
		{
			_repository.Insert(writeOffTransaction);
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
