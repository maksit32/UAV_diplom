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
	public class UserRepository : IUserRepository
	{
		private readonly TestDbContext _dbContext;
		private DbSet<Test> Users => _dbContext.Set<Test>();

		public UserRepository(TestDbContext dbContext)
		{
			_dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
		}

		//CRUD
		public async Task AddUserAsync(Test newUser, CancellationToken token)
		{
			if (newUser is null) throw new ArgumentNullException(nameof(newUser));

			await Users.AddAsync(newUser, token);
			await _dbContext.SaveChangesAsync();
		}
		public async Task<Test?> GetUserByIdAsync(Guid Id, CancellationToken token)
		{
			return await Users.FirstOrDefaultAsync(u => u.Id == Id);
		}

		public async Task<List<Test>> ReadAllUsersAsync(CancellationToken token)
		{
			return await Users.ToListAsync(token);
		}

		public async Task UpdateUserAsync(Test updUser, CancellationToken token)
		{
			if (updUser is null) throw new ArgumentNullException(nameof(updUser));

			Users.Update(updUser);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteUserAsync(Test user, CancellationToken token)
		{
			if (user is null) throw new ArgumentNullException(nameof(user));

			Users.Remove(user);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteUserByIdAsync(Guid Id, CancellationToken token)
		{
			var user = await GetUserByIdAsync(Id, token);
			if (user is null) return;

			Users.Remove(user);
			await _dbContext.SaveChangesAsync();
		}
	}
}
