using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_program.Domain.Exceptions
{
	public class IrrelevantDateTimeException : Exception
	{
		public IrrelevantDateTimeException() { }
		public IrrelevantDateTimeException(string message) : base(message) { }
		public IrrelevantDateTimeException(string message, Exception inner) : base(message, inner) { }
	}
}
