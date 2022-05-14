using DemoApp13.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApp13.Db
{
    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
