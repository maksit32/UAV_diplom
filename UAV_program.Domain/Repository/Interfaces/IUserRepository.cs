using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;


namespace UAV_program.Domain.Repository.Interfaces
{
	public interface IUserRepository : IRepository<Test>
	{
		Task AddUserAsync(Test newUser, CancellationToken token);
		Task<List<Test>> ReadAllUsersAsync(CancellationToken token);
		Task<Test?> GetUserByIdAsync(Guid Id, CancellationToken token);
		Task UpdateUserAsync(Test updUser, CancellationToken token);
		Task DeleteUserByIdAsync(Guid Id, CancellationToken token);
		Task DeleteUserAsync(Test user, CancellationToken token);
	}
}
