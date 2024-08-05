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
            throw new NotImplementedException();
        }

        public List<Todo> GetUnComplatedTodos()
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetComplatedTodos()
        {
            throw new NotImplementedException();
        }

        public void Add(Todo todo)
        {
            throw new NotImplementedException();
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
