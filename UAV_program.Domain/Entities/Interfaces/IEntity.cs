using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_program.Domain.Entities.Interfaces
{
	//от реализуются классы в БД
	public interface IEntity
	{
		Guid Id { get; init; }
	}
}
