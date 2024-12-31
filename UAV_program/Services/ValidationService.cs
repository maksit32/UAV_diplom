using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;
using UAV_program.Domain.Services.Interfaces;


namespace UAV_program.Services
{
	public class ValidationService : IValidationService
	{
		public bool ValidateUser(User user)
		{
			if (user is null) throw new ArgumentNullException(nameof(user), "User  cannot be null.");
			if (string.IsNullOrWhiteSpace(user.Name)) throw new ArgumentException("Name cannot be null or empty.", nameof(user.Name));

			return true;
		}
	}
}
