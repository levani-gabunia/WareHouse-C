using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Warehouse.Repository;

namespace Warehouse.UnitTest
{
	[TestClass]
	public abstract class RepositoryTestBase<TRepository> : TestBase
	where TRepository : RepositoryBase, new()
	{
		protected TRepository _repository;

		public RepositoryTestBase()
		{
			_repository = new TRepository();
		}

		static protected SqlParameter getInsertReturnValue { get; set; }
		static protected SqlParameter getUpdateReturnValue { get; set; }
		static protected SqlParameter getDeleteReturnValue { get; set; }

		protected abstract ICollection<SqlParameter> GetInsertParameters();
		protected abstract ICollection<SqlParameter> GetUpdareParameters();
		protected abstract ICollection<SqlParameter> GetDeleteParameters();

		[TestMethod, Priority(0)]
		public virtual void Test0_Insert()
		{
			var parameters = GetInsertParameters();
			_repository.Insert(parameters.ToArray());

			var expected = 74;

			Assert.AreEqual(expected, getInsertReturnValue.Value, "Is not working!");
		}

		[TestMethod, Priority(1)]
		public virtual void Test1_Get()
		{
			var result = _repository.Get((int)getInsertReturnValue.Value);
			var expected = 74;

			Assert.AreEqual(expected, result.ItemArray[0], "Is not working!");
		}

		[TestMethod, Priority(2)]
		public virtual void Test2_Update()
		{
			var parameters = GetUpdareParameters();
			_repository.Update(parameters.ToArray());
			int expected = 0;

			Assert.AreEqual(expected, getUpdateReturnValue.Value, "Is not working!");
		}

		[TestMethod, Priority(3)]
		public virtual void Test3_Delete()
		{
			var parameters = GetDeleteParameters();
			_repository.Delete(parameters.ToArray());
			int expected = 0;

			Assert.AreEqual(expected, getDeleteReturnValue.Value, "Is not working!");
		}
	}
}
