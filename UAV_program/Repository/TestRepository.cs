using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.DbContexts;
using UAV_program.Domain.Entities;
using UAV_program.Domain.Repository.Interfaces;

namespace UAV_program.Repository
{
	public class TestRepository : ITestRepository
	{
		private readonly TestDbContext _dbContext;
		private DbSet<Test> Tests => _dbContext.Set<Test>();

		public TestRepository(TestDbContext dbContext)
		{
			_dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
		}

		//CRUD
		public async Task AddTestAsync(Test newTest, CancellationToken token)
		{
			if (newTest is null) throw new ArgumentNullException(nameof(newTest));

			await Tests.AddAsync(newTest, token);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<Test>> ReadAllTestsAsync(CancellationToken token)
		{
			return await Tests.ToListAsync(token);
		}

		public async Task<Test?> GetTestByIdAsync(Guid Id, CancellationToken token)
		{
			return await Tests.FirstOrDefaultAsync(t => t.Id == Id);
		}

		public async Task UpdateTestAsync(Test updTest, CancellationToken token)
		{
			if (updTest is null) throw new ArgumentNullException(nameof(updTest));

			Tests.Update(updTest);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteTestByIdAsync(Guid Id, CancellationToken token)
		{
			var test = await GetTestByIdAsync(Id, token);
			if (test is null) throw new ArgumentNullException(nameof(test));

			Tests.Remove(test);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteTestAsync(Test test, CancellationToken token)
		{
			if (test is null) throw new ArgumentNullException(nameof(test));

			Tests.Remove(test);
			await _dbContext.SaveChangesAsync();
		}
	}
}
