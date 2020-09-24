using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Repository;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			UserRepository userRepository = new UserRepository();

			int id = 2;
			var result = userRepository.Get(id);
			Console.WriteLine($"{result["ID"]} , {result["Username"]} , {result["Password"]}");

			//userRepository.Insert(new SqlParameter("ID", 5), new SqlParameter("@Username", "levani"), new SqlParameter("@Password", "levani2"), new SqlParameter("@UserGroup", "Group1"));

			userRepository.Update(new SqlParameter("ID", 5), new SqlParameter("@Username", "levani111"), new SqlParameter("@Password", "levani8888"), new SqlParameter("@UserGroup", "group1"));

			//userRepository.Delete(new SqlParameter("ID", 5));

			Console.ReadLine();
		}
	}
}
