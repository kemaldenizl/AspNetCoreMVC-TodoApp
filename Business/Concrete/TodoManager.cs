using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TodoManager : ITodoService
    {
        private readonly ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public List<Todo> GetAllTodos()
        {
            var todos = _todoDal.GetList();
            return todos;
        }

        public Todo GetTodo(int id)
        {
            var todo = _todoDal.Get(t => t.Id == id);
            return todo;
        }

        public List<Todo> GetUnComplatedTodos()
        {
            var todos = _todoDal.GetList(t => t.IsComplated == false);
            return todos;
        }

        public List<Todo> GetComplatedTodos()
        {
            var todos = _todoDal.GetList(t => t.IsComplated == true);
            return todos;
        }

        public void Add(Todo todo)
        {
            
        }
        public void Update(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void Delete(Todo todo)
        {
            throw new NotImplementedException();
        }
        
    }
}
