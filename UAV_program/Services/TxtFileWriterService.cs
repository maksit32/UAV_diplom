using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;
using UAV_program.Domain.Services.Interfaces;

namespace UAV_program.Services
{
	public class TxtFileWriterService : IFIleWriterService
	{
		private readonly string _resultsFP;
		private readonly IRandomizer randomizer;

		public TxtFileWriterService(IRandomizer randomizer, string resultsFP)
		{
			_resultsFP = resultsFP;
			this.randomizer = randomizer;
		}

		public void WriteDataToFile(Test test)
		{
			try
			{
				string randomGuidName = randomizer.Randomize().ToString() + ".txt";
				string filePath = Path.Combine(_resultsFP, randomGuidName);

				using (StreamWriter writer = new StreamWriter(filePath, true))
				{
					writer.WriteLine("Имя:  " + test.User.Name);
					writer.WriteLine();

					// Форматируем дату и время
					string formattedDate = test.DateExam.ToString("dd.MM.yyyy HH:mm");
					writer.WriteLine("Дата проведения:  " + formattedDate);

					writer.WriteLine("Всего вопросов: " + test.TotalQuestions);
					writer.WriteLine("Из них правильных: " + test.CorrectAnswers);
					writer.WriteLine();
					writer.WriteLine("Ваша оценка: " + test.Mark);
				}
			}
			catch (Exception)
			{
				MessageBox.Show($"Произошла ошибка при записи в файл!",
					"Внимание, ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
