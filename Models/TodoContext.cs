using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;    //有需要與資料庫連線，使用連線字串，就必須要引用 Microsoft.EntityFrameworkCore

namespace TodoApi.Models
{
	public class TodoContext : DbContext
	{
		
		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options) { }

		public DbSet<TodoItem> TodoItems { get; set; }
	}
}
