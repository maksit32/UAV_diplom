using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Constants;
using UAV_program.Domain.Entities;
using UAV_program.Domain.Services.Interfaces;
using static UAV_program.Domain.Constants.Questions;

namespace UAV_program.Services
{
	public class TestService : ITestService
	{
		public Test CreateDbTest(List<Answer> lstAnswers, List<int> lstIndexes, User user)
		{
			if (lstAnswers == null || lstIndexes == null)
				throw new ArgumentException("Списки ответов и индексов не должны быть null.");

			int correct = 0;

			//сколько ОТВЕЧЕННЫХ вопросов
			int totalQuestions = lstIndexes.Count;

			for (int i = 0; i < totalQuestions; i++)
			{
				if (lstAnswers[i].CorrectIndex == lstIndexes[i])
					correct++;
			}

			int mark = (correct * 100) / totalQuestions; //Избегаем целочисленного деления

			Test testObj = new Test(user, correct, totalQuestions, mark);
			testObj.UserId = user.Id;

			return testObj;
		}

		//уникальные 10 вопросов рандомим
		public List<Answer> GenerateTest()
		{
			var selectedQuestions = LstQuestions.OrderBy(x => new Random().Next()).Take(10).ToList();

			return selectedQuestions;
		}
	}
}
