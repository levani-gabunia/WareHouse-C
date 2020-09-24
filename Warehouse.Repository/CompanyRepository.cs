using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class CompanyRepository : RepositoryBase
	{
		protected override string PluralObjectName => "Companies";
		public void Insert(Company company)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("@CompanyName", company.CompanyName),
				new SqlParameter("@TaxCode", company.TaxCode),
				new SqlParameter("@Address", company.Address),
				new SqlParameter("ContactPerson", company.ContactPerson),
				new SqlParameter("@ContactTitle", company.ContactTitle),
				new SqlParameter("@Email", company.Email),
				new SqlParameter("@Head", company.Head),
				new SqlParameter("@Description", company.Description)
			};
			Insert(param.ToArray());
		}

		public void Update(Company company)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", company.ID),
				new SqlParameter("@CompanyName", company.CompanyName),
				new SqlParameter("@TaxCode", company.TaxCode),
				new SqlParameter("@Address", company.Address),
				new SqlParameter("ContactPerson", company.ContactPerson),
				new SqlParameter("@ContactTitle", company.ContactTitle),
				new SqlParameter("@Email", company.Email),
				new SqlParameter("@Head", company.Head),
				new SqlParameter("@Description", company.Description)
			};
			Update(param.ToArray());
		}

		public void Delete(Company company)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", company.ID)
			};
			Delete(param.ToArray());
		}
	}
}
