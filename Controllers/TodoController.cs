using System.Threading.Tasks;
using FeatureToggleDotnet.Data;
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
            return View(await _context.TodoItems.ToListAsync());
        }
    }
}