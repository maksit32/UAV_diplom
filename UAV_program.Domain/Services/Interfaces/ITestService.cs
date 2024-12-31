using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;

namespace UAV_program.Domain.Services.Interfaces
{
	public interface ITestService
	{
		//рандомит 10 уникальных вопросов
		List<Answer> GenerateTest();
		//создает результат Test для записи в БД
		Test CreateDbTest(List<Answer> lstAnswers, List<int> lstIndexes, User user);
	}
}
