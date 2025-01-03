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
	public class User : IEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }
        public string Name { get; set; }

		//Fluent API
		public List<Test> Tests { get; set; } = new();

		protected User() { }
		public User(string name)
		{
			Name = name;
		}
		public override string ToString()
		{
			return $"Ваше имя:  {Name}";
		}
	}
}
