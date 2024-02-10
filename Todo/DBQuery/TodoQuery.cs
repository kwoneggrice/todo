using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Contexts;
using Todo.Models;

namespace Todo.DBQuery
{
	internal class TodoQuery
	{
		private static TodoQuery _instance;
		private static readonly object _lock = new object();

		public static TodoQuery Instance
		{
			get
			{
				lock (_lock)
				{
					if (_instance == null)
					{
						_instance = new TodoQuery();

					}
					return _instance;
				}
			}
		}

		public void SaveQuery(string content, DateTime startDate, DateTime endDate)
		{
			using (TodoContext db = new TodoContext())
			{
				TodoInfo todoInfo = new TodoInfo();
				todoInfo.Content = content;
				todoInfo.StartDate = startDate;
				todoInfo.EndDate = endDate;

				db.Todos.Add(todoInfo);
				db.SaveChanges();
			}
		}

		public List<TodoInfo> SelectAllQuery()
		{
			using (TodoContext db = new TodoContext())
			{
				List<TodoInfo> selectAllQuery = db.Todos.ToList();
				return selectAllQuery;
			}
		}

		public void DeleteQuery(int id)
		{
			using (TodoContext db = new TodoContext())
			{
				TodoInfo query = db.Todos.SingleOrDefault(p => p.Id == id);

				if (query == null)
				{
					return;
				}

				db.Todos.Remove(query);
				db.SaveChanges();
			}
		}

	}
}