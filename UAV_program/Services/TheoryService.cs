using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Services.Interfaces;
using static UAV_program.Domain.Constants.Theory;

namespace UAV_program.Services
{
	public class TheoryService : ITheoryService
	{
		public KeyValuePair<string, string> MoveTheoryIndex(ref int index, bool moveNext)
		{
			//проверка на габариты
			if (index < 0 || index >= LstTheory.Count)
				index = 0;

			return LstTheory.ElementAt(index);
		}
	}
}
