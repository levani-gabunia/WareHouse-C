using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class LostProductRepository : RepositoryBase
	{
        public void Insert(LostProduct lostProduct)
        {
            var param = new List<SqlParameter>
            {
                new SqlParameter("TransactionDetailID", lostProduct.TransactionDetailID),
                new SqlParameter("@LostQuantity ", lostProduct.LostQuantity ),
                new SqlParameter("@Comment", lostProduct.Comment),         
            };
            Insert(param.ToArray());
        }

        internal override DataRow Get(int id)
		{
			string command = $"select * from {PluralObjectName} where @TransactionDetailID = @TransactionDetailID";
			var result = _database.GetTable(command, CommandType.Text, new SqlParameter("@TransactionDetailID", id)).Rows[0];
			return result;
		}

        internal override void Update(params SqlParameter[] parameters) => throw new NotSupportedException("LostProductRepository has not update method!");

        internal override void Delete(params SqlParameter[] parameters) => throw new NotSupportedException("LostProductRepository has not delete method!");
    }
}
