using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_program.Domain.Services.Interfaces
{
	public interface IRandomizer
	{
		Guid Randomize();
	}
}
