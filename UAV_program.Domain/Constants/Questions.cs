using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;

namespace UAV_program.Domain.Constants
{
	public static class Questions
	{
		//Банк вопросов с ответами
		public static List<Answer> LstQuestions { get; set; } = new List<Answer>()
		{
			new Answer("Вопрос 1", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 0),
			new Answer("Вопрос 2", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 1),
			new Answer("Вопрос 3", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 2),
			new Answer("Вопрос 4", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 3),
			new Answer("Вопрос 5", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 0),
			new Answer("Вопрос 6", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 1),
			new Answer("Вопрос 7", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 2),
			new Answer("Вопрос 8", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 3),  new Answer("Вопрос 1", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 0),
			new Answer("Вопрос 9", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 1),
			new Answer("Вопрос 10", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 2),
			new Answer("Вопрос 11", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 3),
			new Answer("Вопрос 12", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 0),
			new Answer("Вопрос 13", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 1),
			new Answer("Вопрос 14", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 2),
			new Answer("Вопрос 15", new List<string>(){ "Ответ1", "Ответ2", "ответ 3", "ответ 4" }, 3),
		};
	}
}
