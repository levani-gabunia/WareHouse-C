using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Repository
{
	public class EmployeeRepository : RepositoryBase
	{
		public void Insert(Employee employee)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("@FirstName", employee.FirstName),
				new SqlParameter("@LastName", employee.LastName),
				new SqlParameter("@PersonalID", employee.PersonalID ),
				new SqlParameter("@Address", employee.Address),
				new SqlParameter("@ContactPhone", employee.ContactPhone)
			};
			Insert(param.ToArray());
		}

		public void Update(Employee employee)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", employee.ID),
				new SqlParameter("@FirstName", employee.FirstName),
				new SqlParameter("@LastName", employee.LastName),
				new SqlParameter("@PersonalID", employee.PersonalID ),
				new SqlParameter("@Address", employee.Address ),
				new SqlParameter("@ContactPhone", employee.ContactPhone)
			};
			Update(param.ToArray());
		}

		public void Delete(Employee employee)
		{
			var param = new List<SqlParameter>
			{
				new SqlParameter("ID", employee.ID)
			};
			Delete(param.ToArray());
		}
	}
}
