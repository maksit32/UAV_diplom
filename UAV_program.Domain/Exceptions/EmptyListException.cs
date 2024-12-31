using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_program.Domain.Exceptions
{
	public class EmptyListException : Exception
	{
		public EmptyListException() { }
		public EmptyListException(string message) : base(message) { }
		public EmptyListException(string message, Exception inner) : base(message, inner) { }
	}
}
