using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;

namespace UAV_program.Domain.Services.Interfaces
{
	public interface IValidationService
	{
		//валидация имени пользователя
		bool ValidateUser(User user);
	}
}
