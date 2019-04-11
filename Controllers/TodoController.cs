using System.Threading.Tasks;
using FeatureToggleDotnet.Data;
using FeatureToggleDotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FeatureToggleDotnet.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _context;
        
        public TodoController(TodoContext context)
        {
            _context = context;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            var todoItems = await _context.TodoItems.ToListAsync();
            var model = new TodoViewModel() { Items = todoItems };
            return View(model);
        }
    }
}