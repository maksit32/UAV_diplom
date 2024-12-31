using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAV_program.Domain.Entities;

namespace UAV_program.DbContexts
{
	public class TestDbContext : DbContext
	{
		private readonly string _connectionString;
		public DbSet<Test> Users => Set<Test>();
		public DbSet<Test> Tests => Set<Test>();
		public TestDbContext(string connectionString)
		{
			if (string.IsNullOrWhiteSpace(connectionString))
				throw new ArgumentException($"\"{nameof(connectionString)}\" не может быть пустым или содержать только пробел.", nameof(connectionString));
			_connectionString = connectionString;

			Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Test>()
			.HasOne(e => e.User)
			.WithMany(u => u.Tests)
			.OnDelete(DeleteBehavior.Cascade);

			base.OnModelCreating(modelBuilder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(_connectionString);
		}
	}
}
