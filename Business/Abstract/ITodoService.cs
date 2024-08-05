using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITodoService
    {
        List<Todo> GetAllTodos();
        Todo GetTodo(int id);
        List<Todo> GetUnComplatedTodos();
        List<Todo> GetComplatedTodos();
        void Add(Todo todo);
        void Update(Todo todo);
        void Delete(Todo todo);
    }
}
