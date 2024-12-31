using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities.Interfaces;

namespace UAV_program.Domain.Entities
{
	[Serializable]
	public class Test : IEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; init; }
		public int CorrectAnswers { get; set; }
		public int TotalQuestions { get; } = 10;
		public int Mark { get; set; }
        public DateTime DateExam { get; set; }
		public Guid UserId { get; set; }
		public Test User { get; set; }

		public Test(Test user, int correctQuestions = 0, int totalQuesions = 10, int mark = 2)
		{
			CorrectAnswers = correctQuestions;
			TotalQuestions = totalQuesions;
			Mark = mark;
			DateExam = DateTime.UtcNow;
			User = user;
		}
	}
}
