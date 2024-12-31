using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities.Interfaces;

namespace UAV_program.Domain.Repository.Interfaces
{
	public interface IRepository<TEntity> where TEntity : IEntity
	{

	}
}
