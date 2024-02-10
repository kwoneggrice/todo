using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Contexts
{
	internal class TodoContext : DbContext
	{
		public DbSet<TodoInfo> Todos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-08KF2BF;Database=todo;User Id=sa;Password=sa;TrustServerCertificate=True;");
		}
	}
}
