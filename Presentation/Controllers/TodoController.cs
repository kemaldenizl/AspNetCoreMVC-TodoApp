using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using System.Diagnostics;

namespace Presentation.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;
        private readonly TodoViewModel _todoViewModel;
        public TodoController(ITodoService todoService, TodoViewModel todoViewModel)
        {
            _todoService = todoService;
            _todoViewModel = todoViewModel;
        }

        public IActionResult Index()
        {
            _todoViewModel.Todos = _todoService.GetAllTodos();
            return View(_todoViewModel.Todos);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
