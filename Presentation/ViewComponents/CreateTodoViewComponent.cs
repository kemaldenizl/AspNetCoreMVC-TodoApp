using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Presentation.Models;

namespace Presentation.ViewComponents
{
    public class CreateTodoViewComponent : ViewComponent
    {
        private readonly ITodoService _todoService;
        public CreateTodoViewComponent(ITodoService todoService)
        {
            _todoService = todoService;
        }
        public ViewViewComponentResult Invoke()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewViewComponentResult Invoke([Bind("Id, Description, CreateDate, StartDate, EndDate, IsComplated")] Todo todo)
        {
            if (ModelState.IsValid)
            {
                _todoService.Add(todo);
                return View();
            }

            return View(todo);
        }
    }
}
