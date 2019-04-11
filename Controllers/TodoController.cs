using System.Threading.Tasks;
using FeatureToggle.Interface;
using FeatureToggleDotnet.Data;
using FeatureToggleDotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FeatureToggleDotnet.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _context;
        private readonly IFeature _feature;
        
        public TodoController(TodoContext context, IFeature feature)
        {
            _context = context;
            _feature = feature;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            var todoItems = await _context.TodoItems.ToListAsync();
            if (_feature.IsFeatureEnabled("FTD-002-Remove-item"))
            {
                foreach (var item in todoItems)
                {
                    item.Done = false;
                }
            }
            var model = new TodoViewModel() { Items = todoItems };
            return View(model);
        }
    }
}