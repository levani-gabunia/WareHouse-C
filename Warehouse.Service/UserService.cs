using System.Data;
using Warehouse.Models;
using Warehouse.Repository;

namespace Warehouse.Service
{
	public class UserService : ServiceBase<UserRepository>
	{
		public void Insert(User user)
		{
			_repository.Insert(user);
		}

		public void Update(User user)
		{
			_repository.Update(user);
		}

		public void Delete(User user)
		{
			_repository.Delete(user);
		}

		public int Login(string username, string password)
		{
			return _repository.UserLogin(username, password);
		}
	}
}
