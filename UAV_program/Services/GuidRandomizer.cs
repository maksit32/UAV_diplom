using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Services.Interfaces;

namespace UAV_program.Services
{
	public class GuidRandomizer : IRandomizer
	{
		public Guid Randomize()
		{
			return Guid.NewGuid();
		}
	}
}
