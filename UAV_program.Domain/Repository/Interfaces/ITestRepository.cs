using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;

namespace UAV_program.Domain.Repository.Interfaces
{
	public interface ITestRepository : IRepository<Test>
	{
		Task AddTestAsync(Test newTest, CancellationToken token);
		Task<List<Test>> ReadAllTestsAsync(CancellationToken token);
		Task<Test?> GetTestByIdAsync(Guid Id, CancellationToken token);
		Task UpdateTestAsync(Test updTest, CancellationToken token);
		Task DeleteTestByIdAsync(Guid Id, CancellationToken token);
		Task DeleteTestAsync(Test test, CancellationToken token);
	}
}
