using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_program.Domain.Constants
{
	public static class Filepaths
	{
		public static readonly string appSettingsPath = Environment.CurrentDirectory + "\\..\\..\\..\\Settings\\appsettings.json";
		public static readonly string literaturePath = Environment.CurrentDirectory + "\\..\\..\\..\\Literature\\";
		public static readonly string _literatureFP = Environment.CurrentDirectory + "\\..\\..\\..\\Literature\\";
		public static readonly string _resultsFP = Environment.CurrentDirectory + "\\..\\..\\..\\Results\\";
	}
}
