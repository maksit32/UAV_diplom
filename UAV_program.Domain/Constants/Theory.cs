using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_program.Domain.Constants
{
	public static class Theory
	{
		//список filepaths к фотографиям и теориия (к фото)
		public static Dictionary<string, string> LstTheory { get; set; } = new Dictionary<string, string>()
		{
			{ "C:\\Users\\korni\\source\\repos\\UAV_sol\\UAV_program\\Images\\1.jpg", "Полетный контроллер" },
			{ "C:\\Users\\korni\\source\\repos\\UAV_sol\\UAV_program\\Images\\2.jpg", "Винты" }
		};
	}
}
