using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class WarehouseRepository : RepositoryBase
	{
		public void Insert(WarehouseModels warehouseModel)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("@Name", warehouseModel.Name),
				new SqlParameter("@TaxCode", warehouseModel.TaxCode),
				new SqlParameter("@Address", warehouseModel.Address),
				new SqlParameter("@ContactPhone", warehouseModel.ContactPhone)
			};
			Insert(param.ToArray());
		}

		public void Update(WarehouseModels warehouseModel)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", warehouseModel.ID),
				new SqlParameter("@Name", warehouseModel.Name),
				new SqlParameter("@TaxCode", warehouseModel.TaxCode),
				new SqlParameter("@PersonalID", warehouseModel.PersonalID),
				new SqlParameter("@Address", warehouseModel.Address),
				new SqlParameter("@ContactPhone", warehouseModel.ContactPhone)
			};
			Update(param.ToArray());
		}

		public void Delete(WarehouseModels warehouseModels)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", warehouseModels.ID)
			};
			Delete(param.ToArray());
		}
	}
}
