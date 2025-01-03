using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Exceptions;

namespace UAV_program.Domain.Entities
{
	public class Answer
	{
		public string Question { get; init; }
		public List<string> AnswersLst { get; init; }
		public int CorrectIndex { get; }

		public Answer(string question, List<string> answersLst, int correctIndex)
		{
			if (answersLst.Count == 0) throw new EmptyListException("Answers list is empty!");

			Question = question;
			AnswersLst = answersLst ?? throw new ArgumentNullException(nameof(answersLst));
			this.CorrectIndex = correctIndex;
		}
		public override string ToString()
		{
			int index = 1;
			string lstString = "";
			foreach (var answ in AnswersLst)
				lstString += index + ") " + answ + $"{Environment.NewLine}";
			string returnStr = $"{Question}{Environment.NewLine}{Environment.NewLine}" + lstString;
			return returnStr;
		}
	}
}
