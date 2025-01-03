using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;


namespace UAV_program.Domain.Repository.Interfaces
{
	public interface IUserRepository : IRepository<User>
	{
		Task AddUserAsync(User newUser, CancellationToken token);
		Task<List<User>> ReadAllUsersAsync(CancellationToken token);
		Task<User?> GetUserByIdAsync(Guid Id, CancellationToken token);
		Task UpdateUserAsync(User updUser, CancellationToken token);
		Task DeleteUserByIdAsync(Guid Id, CancellationToken token);
		Task DeleteUserAsync(User user, CancellationToken token);
	}
}
